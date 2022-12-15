using Autofac;
using Business.Abstract;
using Business.Constants;
using Core.Extensions;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;
using WindowsFormUI.Views.Moduls.Cariler;
using WindowsFormUI.Views.UserExtensions;

namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    public partial class FrmEvrakAl : FrmBase
    {
        private readonly ICekSenetBordroService _cekSenetBordroService;
        private readonly ICariService _cariService;
        private readonly ICekSenetMusteriService _cekSenetMusteriService;
        private readonly List<CekSenetMusteri> _musteriCekSenetler;
        private CekSenetBordro _secilenTahsilatBordro;
        private Cari _secilenCari;
        private int _secilenMusteriEvrakIndex = -1;
        private decimal _evrakTutar;
        private bool isUpdate = false;

        public FrmEvrakAl(ICekSenetBordroService cekSenetBordroService,
                                    ICariService cariService,
                                    ICekSenetMusteriService cekSenetMusteriService)
        {
            InitializeComponent();
            _cekSenetBordroService = cekSenetBordroService;
            _cariService = cariService;
            _cekSenetMusteriService = cekSenetMusteriService;
            _musteriCekSenetler = new List<CekSenetMusteri>();
            ClearScreen();
        }

        private void TxtDecimalHarfEngelle(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Contains(','))
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void TxtBelgeNoHarfEngelle(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnBordroNoBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBordroListe>();
            form.BordroTur = BordroTurleri.Tahsilat;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenBordroId > 0)
                {
                    _secilenTahsilatBordro = _cekSenetBordroService.GetById(StaticPrimitives.SecilenBordroId).Data;
                    txtBordroNo.Text = _secilenTahsilatBordro.No;
                    txtBordroNo.Focus();
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void BtnCariBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmCariListe>();
            form.SecimIcin = true;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenCariId > 0)
                {
                    _secilenTahsilatBordro.Cari = _cariService.GetById(StaticPrimitives.SecilenCariId).Data;
                    txtCariKod.Text = _secilenTahsilatBordro.Cari.Kod;
                    txtCariKod.Focus();
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void UscEvrakEkleGuncelleSil_ClickClear(object sender, EventArgs e)
        {
            ClearCurrentEvrak();
        }

        private void UscEvrakEkleGuncelleSil_ClickSave(object sender, EventArgs e)
        {
            if (isUpdate)
                _musteriCekSenetler.Update(_secilenMusteriEvrakIndex, ReadCekSenetMusteriFromForm());
            else
                _musteriCekSenetler.Add(ReadCekSenetMusteriFromForm());

            ClearCurrentEvrak();

            uscEvrakAl.BtnClear_Visible = true;
            uscEvrakAl.BtnDelete_Enable = true;
            uscEvrakAl.BtnSave_Enable = true;
        }

        private void UscEvrakAl_ClickClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void UscEvrakAl_ClickSave(object sender, EventArgs e)
        {
            try
            {
                _secilenTahsilatBordro.CekSenetMusteriler = _musteriCekSenetler;
                _secilenTahsilatBordro.CariHareket = new CariHareket
                {
                    CariId = _secilenTahsilatBordro.Cari.Id,
                    Tarih = _secilenTahsilatBordro.Tarih,
                    Tutar = _secilenTahsilatBordro.CekSenetMusteriler.Sum(c => c.Tutar) * -1,
                    Aciklama = $"{_secilenTahsilatBordro.No} nolu evrak tahsilat bordrosu."
                };
                var result = _cekSenetBordroService.Add(_secilenTahsilatBordro);
                MessageHelper.SuccessMessageBuilder(result.Message, Messages.CekSenetMessages.MusteriCekSenetEklendi);
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
            ClearScreen();
        }

        private void UscEvrakAl_ClickCancel(object sender, EventArgs e)
        {
            ClearScreen();
            this.Close();
        }

        private void DgvEvrakAl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var secilenMusteriEvrak = _musteriCekSenetler[e.RowIndex];
                WriteCekSenetMusteriToForm(secilenMusteriEvrak);
                uscEvrakEkleGuncelleSil.BtnSave_Text = "Güncelle";
                uscEvrakEkleGuncelleSil.BtnSave_Enable = true;
                isUpdate = true;
                _secilenMusteriEvrakIndex = e.RowIndex;
            }
        }

        private void LeaveOnlyWithTabKey(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                string control = ((Control)sender).Name.ToFirstLetterUpperCase();
                control += "_Leave";

                MethodInfo methodInfo = this.GetType().GetMethod(control, BindingFlags.NonPublic | BindingFlags.Instance);
                methodInfo.Invoke(this, null);
            }
        }

        private void TxtBordroNo_Leave()
        {
            if (txtBordroNo.Text.Length != 0)
            {
                txtBordroNo.Text = ModulExtensions.FormatNoString(txtBordroNo.Text, 14, 'B');
                var result = _cekSenetBordroService.GetByNo(txtBordroNo.Text);
                if (result.Data != null)
                {
                    _secilenTahsilatBordro = result.Data;
                    BringExistingBordro(_secilenTahsilatBordro);
                }
                else
                    OpenNewBordro();
                txtCariKod.Focus();
            }
        }

        private void TxtCariKod_Leave()
        {
            try
            {
                var result = _cariService.GetByKod(txtCariKod.Text);
                if (result.Data != null)
                {
                    _secilenCari = result.Data;
                    txtCariKod.Enabled = false;
                    btnCariBul.Enabled = false;
                    lblCariUnvan.Text = _secilenCari.Unvan;
                    uscEvrakEkleGuncelleSil.BtnClear_Visible = true;
                    dtpAlisTarih.Enabled = true;
                    dtpAlisTarih.Focus();
                }
                else
                {
                    MessageHelper.ErrorMessageBuilder(result.Message, "Veri Hatası");
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void DtpAlisTarih_Leave()
        {
            if (dtpAlisTarih.Value == DateTime.Today.Date)
            {
                dtpAlisTarih.Enabled = false;
                txtBordroAciklama.Enabled = true;
                txtBordroAciklama.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Geçmiş tarihli evrak kabulu yapılamaz.", "Tarih Hatası");
                dtpAlisTarih.Focus();
            }
        }

        private void TxtBordroAciklama_Leave()
        {
            if (txtBordroAciklama.Text.Length > 0)
            {
                txtBordroAciklama.Enabled = false;
                grpEvrakBilgiler.Enabled = true;
                _secilenTahsilatBordro = ReadCekSenetBordroFromForm();

                txtEvrakNo.Enabled = true;
                txtEvrakNo.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Bir açıklama girilmelidir.", "Veri Hatası");
                txtBordroAciklama.Focus();
            }
        }

        private void TxtEvrakNo_Leave()
        {
            if (txtEvrakNo.Text.Length != 0)
            {
                txtEvrakNo.Text = ModulExtensions.FormatNoString(txtEvrakNo.Text, 14, 'E');
                txtEvrakNo.Enabled = false;
                dtpVade.Enabled = true;

                uscEvrakEkleGuncelleSil.BtnClear_Visible = true;
                dtpVade.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Evrak No Boş Geçilemez", "Veri Hatası");
                txtEvrakNo.Focus();
            }
        }

        private void DtpVade_Leave()
        {
            if (dtpVade.Value >= DateTime.Today.Date)
            {
                dtpVade.Enabled = false;
                txtTutar.Enabled = true;
                txtTutar.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Vadesi geçmiş evrak girilmez", "Tarih Hatası");
                dtpVade.Focus();
            }
        }

        private void TxtTutar_Leave()
        {
            if (txtTutar.Text.Length > 0)
            {
                _evrakTutar = txtTutar.Text.ToDecimal();
                txtTutar.Text = _evrakTutar.ToString("#,###.## TL");
                txtTutar.Enabled = false;
                txtAsilBorclu.Enabled = true;
                txtAsilBorclu.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Tutar bilgisi boş geçilemez.", "Veri Hatası");
                txtTutar.Focus();
            }
        }

        private void TxtAsilBorclu_Leave()
        {
            if (txtAsilBorclu.Text.Length > 0)
            {
                txtAsilBorclu.Enabled = false;
                txtAciklama.Enabled = true;
                txtAciklama.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Evrağın asıl borçlusunu giriniz!.. Evrak müşterinize ait ise kendisi olark belirtiniz.", "Veri hatası");
                txtAsilBorclu.Focus();
            }
        }

        private void TxtAciklama_Leave()
        {
            if (txtAciklama.Text.Length > 0)
            {
                txtAciklama.Enabled = false;
                uscEvrakEkleGuncelleSil.BtnSave_Enable = true;
                uscEvrakEkleGuncelleSil.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Bir açıklama girilmesi gerekir.", "Veri Hatası");
                txtAciklama.Focus();
            }
        }

        private CekSenetBordro ReadCekSenetBordroFromForm() => new CekSenetBordro()
        {
            No = txtBordroNo.Text,
            Cari = _secilenCari,
            CariId = _secilenCari.Id,
            Tarih = dtpAlisTarih.Value,
            Tur = "Tahsilat",
            Aciklama = txtBordroAciklama.Text
        };

        private CekSenetMusteri ReadCekSenetMusteriFromForm() => new CekSenetMusteri()
        {
            No = txtEvrakNo.Text,
            Vade = dtpVade.Value,
            Tutar = _evrakTutar,
            AsilBorclu = txtAsilBorclu.Text,
            Aciklama = txtAciklama.Text
        };

        private void WriteCekSenetMusteriToForm(CekSenetMusteri secilenMusteriEvrak)
        {
            ClearCurrentEvrak();
            txtEvrakNo.Text = secilenMusteriEvrak.No;
            dtpVade.Value = secilenMusteriEvrak.Vade;
            txtTutar.Text = secilenMusteriEvrak.Tutar.ToString("#,###.## TL");
            txtAsilBorclu.Text = secilenMusteriEvrak.AsilBorclu;
            txtAciklama.Text = secilenMusteriEvrak.Aciklama;
            txtEvrakNo.Focus();
        }

        private void WriteEvraklarToDgv(List<CekSenetMusteri> musteriEvraklar)
        {
            dgvEvrakAl.DataSource = musteriEvraklar.Select(s => new
            {
                s.Id,
                s.No,
                s.Vade,
                Tutar = s.Tutar.ToString("#,###.## TL"),
                s.AsilBorclu,
                s.Aciklama
            }).ToList();
        }

        private void ClearCurrentEvrak()
        {
            WriteEvraklarToDgv(_musteriCekSenetler);

            txtEvrakNo.Text = "";
            txtEvrakNo.Enabled = true;

            dtpVade.Value = DateTime.Today;
            dtpVade.Enabled = false;

            txtTutar.Text = "";
            txtTutar.Enabled = false;

            txtAsilBorclu.Text = "";
            txtAsilBorclu.Enabled = false;

            txtAciklama.Text = "";
            txtAciklama.Enabled = false;

            isUpdate = false;
            _secilenMusteriEvrakIndex = -1;
            uscEvrakEkleGuncelleSil.BtnClear_Visible = false;
            uscEvrakEkleGuncelleSil.BtnSave_Enable = false;
            uscEvrakEkleGuncelleSil.BtnSave_Text = "Ekle";
            uscEvrakEkleGuncelleSil.BtnDelete_Enable = false;

            var yenifis = _cekSenetMusteriService.GetList().Data?.MaxBy(s => s.Id);
            int fisNo = yenifis == null ? 1 : yenifis.No[1..].Trim('0').ToInt() + 1;
            txtEvrakNo.Text = fisNo.ToString();

            txtEvrakNo.Focus();
        }

        private void ClearScreen()
        {
            ClearCurrentEvrak();

            txtCariKod.Text = "";
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            lblCariUnvan.Text = "";

            txtEvrakNo.Enabled = false;
            dtpAlisTarih.Enabled = false;
            txtBordroAciklama.Enabled = false;
            dtpAlisTarih.Value = DateTime.Today;
            txtAciklama.Text = "";

            _musteriCekSenetler.Clear();
            _secilenTahsilatBordro = null;

            uscEvrakAl.BtnClear_Visible = false;
            uscEvrakAl.BtnSave_Enable = false;
            uscEvrakAl.BtnDelete_Enable = false;

            CekSenetBordro yeniBordro = _cekSenetBordroService.GetList().Data?.MaxBy(s => s.Id);
            int bordroNo = yeniBordro == null ? 1 : yeniBordro.No[1..].Trim('0').ToInt() + 1;
            txtBordroNo.Text = bordroNo.ToString();

            txtBordroNo.Focus();
        }

        private void OpenNewBordro()
        {
            StaticPrimitives.SecilenBordroId = -1;
            _secilenTahsilatBordro = new();
            var bordro = txtBordroNo.Text;
            ClearScreen();
            txtBordroNo.Text = bordro;
            txtBordroNo.Enabled = false;
            btnBordroNoBul.Enabled = false;
            uscEvrakAl.BtnClear_Visible = true;
            uscEvrakAl.BtnSave_Enable = true;
            uscEvrakAl.BtnSave_Text = "Bordro Kaydet";
            txtCariKod.Text = "";
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            lblCariUnvan.Text = "";
            dtpAlisTarih.Value = DateTime.Today;
            grpEvrakBilgiler.Enabled = false;
        }

        private void BringExistingBordro(CekSenetBordro secilenBordro)
        {
            ClearScreen();
            StaticPrimitives.SecilenBordroId = secilenBordro.Id;
            txtBordroNo.Text = secilenBordro.No;
            txtBordroNo.Enabled = false;
            btnBordroNoBul.Enabled = false;
            txtCariKod.Text = secilenBordro.Cari.Kod;
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            dtpAlisTarih.Enabled = false;
            dtpAlisTarih.Value = secilenBordro.Tarih;
            txtBordroAciklama.Text = secilenBordro.Aciklama;
            lblCariUnvan.Text = secilenBordro.Cari.Unvan;

            WriteEvraklarToDgv(secilenBordro.CekSenetMusteriler);

            grpEvrakBilgiler.Enabled = true;
            uscEvrakAl.BtnClear_Visible = true;
            uscEvrakAl.BtnDelete_Enable = true;
            uscEvrakAl.BtnSave_Enable = true;
            uscEvrakAl.BtnSave_Text = "Güncelle";
        }
    }
}