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
    public partial class FrmMusteridenEvrakAl : FrmBase
    {
        private readonly ICekSenetBordroService _cekSenetBordroService;
        private readonly ICariService _cariService;
        private readonly List<CekSenetMusteri> _musteriCekSenetler;
        private CekSenetBordro _secilenTahsilatBordro;
        private Cari _secilenCari;
        private int _secilenMusteriEvrakIndex = -1;
        private decimal _evrakTutar;
        private bool isUpdate = false;

        public FrmMusteridenEvrakAl(ICekSenetBordroService cekSenetBordroService,
                                    ICariService cariService)
        {
            InitializeComponent();
            _cekSenetBordroService = cekSenetBordroService;
            _cariService = cariService;
            _musteriCekSenetler = new List<CekSenetMusteri>();
        }

        private void FrmMusteridenEvrakAl_Load(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void DtpInputEngelle(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

            uscMusteriyeEvrakCik.BtnClear_Visible = true;
            uscMusteriyeEvrakCik.BtnDelete_Enable = true;
            uscMusteriyeEvrakCik.BtnSave_Enable = true;
        }

        private void UscMusteriyeEvrakCik_ClickClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void UscMusteriyeEvrakCik_ClickSave(object sender, EventArgs e)
        {
            try
            {
                _secilenTahsilatBordro.CariHareket = new CariHareket
                {
                    CariId = _secilenTahsilatBordro.Cari.Id,
                    Tarih = _secilenTahsilatBordro.Tarih,
                    Tutar = _secilenTahsilatBordro.CekSenetMusteriler.Sum(c => c.Tutar) * -1,
                    Aciklama = $"{_secilenTahsilatBordro.No} nolu müşteri evrağı"
                };
                _secilenTahsilatBordro.CekSenetMusteriler = _musteriCekSenetler;
                var result = _cekSenetBordroService.Add(_secilenTahsilatBordro);
                MessageHelper.SuccessMessageBuilder(result.Message, Messages.CekSenetMessages.MusteriCekSenetEklendi);
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
            ClearScreen();
        }

        private void UscMusteriyeEvrakCik_ClickCancel(object sender, EventArgs e)
        {
            ClearScreen();
            this.Close();
        }

        private void DgvMusteridenEvrakAl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            dgvMusteridenEvrakAl.DataSource = musteriEvraklar.Select(s => new
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

            txtEvrakNo.Focus();
        }

        private void ClearScreen()
        {
            ClearCurrentEvrak();

            txtCariKod.Text = "";
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            lblCariUnvan.Text = "";

            txtEvrakNo.Enabled = false;
            dtpAlisTarih.Enabled = false;
            txtBordroAciklama.Enabled = false;
            dtpAlisTarih.Value = DateTime.Today;
            txtAciklama.Text = "";

            _musteriCekSenetler.Clear();
            _secilenTahsilatBordro = null;

            uscMusteriyeEvrakCik.BtnClear_Visible = false;
            uscMusteriyeEvrakCik.BtnSave_Enable = false;
            uscMusteriyeEvrakCik.BtnDelete_Enable = false;

            txtCariKod.Focus();
        }

        private void OpenNewBordro()
        {
            StaticPrimitives.SecilenBordroId = -1;
            _secilenTahsilatBordro = new();
            var bordro = txtBordroNo.Text;
            ClearScreen();
            txtBordroNo.Text = bordro;
            txtBordroNo.Enabled = false;
            uscMusteriyeEvrakCik.BtnClear_Visible = true;
            uscMusteriyeEvrakCik.BtnSave_Enable = true;
            uscMusteriyeEvrakCik.BtnSave_Text = "Bordro Kaydet";
            txtCariKod.Text = "";
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            lblCariUnvan.Text = "";
            dtpAlisTarih.Enabled = true;
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
            uscMusteriyeEvrakCik.BtnClear_Visible = true;
            uscMusteriyeEvrakCik.BtnDelete_Enable = true;
            uscMusteriyeEvrakCik.BtnSave_Enable = true;
            uscMusteriyeEvrakCik.BtnSave_Text = "Güncelle";
        }
    }
}