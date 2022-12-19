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
    public partial class FrmBorcEvrakCik : FrmBase
    {
        private readonly ICekSenetBordroService _cekSenetBordroService;
        private readonly ICariService _cariService;
        private readonly ICekSenetBorcService _cekSenetBorcService;
        private readonly List<CekSenetBorc> _borcCekSenetler;
        private CekSenetBordro _secilenTediyeBordro;
        private Cari _secilenCari;
        private int _secilenBorcEvrakIndex = -1;
        private decimal _evrakTutar;
        private bool isUpdate = false;

        public FrmBorcEvrakCik(ICekSenetBordroService cekSenetBordroService,
                                    ICariService cariService,
                                    ICekSenetBorcService cekSenetBorcService)
        {
            InitializeComponent();
            _cekSenetBordroService = cekSenetBordroService;
            _cariService = cariService;
            _cekSenetBorcService = cekSenetBorcService;
            _borcCekSenetler = new();
        }

        private void FrmBorcEvrakCik_Load(object sender, EventArgs e)
        {
            try
            {
                ClearScreen();
                //
                CekSenetBordro yeniBordro = _cekSenetBordroService.GetList().Data?.MaxBy(s => s.Id);
                int bordroNo = yeniBordro == null ? 1 : yeniBordro.No[1..].Trim('0').ToInt() + 1;
                txtBordroNo.Text = bordroNo.ToString();
                //
            }
            catch (UnauthorizedAccessException err)
            {
                MessageHelper.ErrorMessageBuilder(err);
                this.BeginInvoke(new MethodInvoker(Close));
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
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
            form.BordroTur = BordroTurleri.BorcTediye;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenBordroId > 0)
                {
                    _secilenTediyeBordro = _cekSenetBordroService.GetById(StaticPrimitives.SecilenBordroId).Data;
                    txtBordroNo.Text = _secilenTediyeBordro.No;
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
                    _secilenTediyeBordro.Cari = _cariService.GetById(StaticPrimitives.SecilenCariId).Data;
                    txtCariKod.Text = _secilenTediyeBordro.Cari.Kod;
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
            var evrak = ReadCekSenetBorcFromForm();
            if (isUpdate)
                _borcCekSenetler.Update(_secilenBorcEvrakIndex, evrak);
            else
                _borcCekSenetler.Add(evrak);

            ClearCurrentEvrak();

            uscBorcEvrakCik.BtnClear_Visible = true;
            uscBorcEvrakCik.BtnDelete_Enable = true;
            uscBorcEvrakCik.BtnSave_Enable = true;
        }

        private void UscBorcEvrakCik_ClickClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void UscBorcEvrakCik_ClickSave(object sender, EventArgs e)
        {
            try
            {
                _secilenTediyeBordro.CekSenetBorclar = _borcCekSenetler;
                _secilenTediyeBordro.CariHareket = new CariHareket
                {
                    CariId = _secilenTediyeBordro.Cari.Id,
                    Tarih = _secilenTediyeBordro.Tarih,
                    Tutar = _secilenTediyeBordro.CekSenetBorclar.Sum(c => c.Tutar),
                    Aciklama = $"{_secilenTediyeBordro.No} nolu borç evrak tediye bordrosu."
                };
                var result = _cekSenetBordroService.Add(_secilenTediyeBordro);
                MessageHelper.SuccessMessageBuilder(result.Message, Messages.CekSenetMessages.MusteriCekSenetEklendi);
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
            ClearScreen();
        }

        private void UscBorcEvrakCik_ClickCancel(object sender, EventArgs e)
        {
            ClearScreen();
            this.Close();
        }

        private void DgvBorcEvrakCik_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var secilenBorcEvrak = _borcCekSenetler[e.RowIndex];
                WriteCekSenetBorcToForm(secilenBorcEvrak);
                uscEvrakEkleGuncelleSil.BtnSave_Text = "Güncelle";
                uscEvrakEkleGuncelleSil.BtnSave_Enable = true;
                isUpdate = true;
                _secilenBorcEvrakIndex = e.RowIndex;
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
                    _secilenTediyeBordro = result.Data;
                    BringExistingBordro(_secilenTediyeBordro);
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
                    dtpCikisTarih.Enabled = true;
                    dtpCikisTarih.Focus();
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

        private void DtpCikisTarih_Leave()
        {
            if (dtpCikisTarih.Value == DateTime.Today.Date)
            {
                dtpCikisTarih.Enabled = false;
                txtBordroAciklama.Enabled = true;
                txtBordroAciklama.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Geçmiş tarihli evrak kabulu yapılamaz.", "Tarih Hatası");
                dtpCikisTarih.Focus();
            }
        }

        private void TxtBordroAciklama_Leave()
        {
            if (txtBordroAciklama.Text.Length > 0)
            {
                txtBordroAciklama.Enabled = false;
                grpEvrakBilgiler.Enabled = true;
                _secilenTediyeBordro = ReadCekSenetBordroFromForm();

                var yenifis = _cekSenetBorcService.GetList().Data?.MaxBy(s => s.Id);
                int fisNo = yenifis == null ? 1 : yenifis.No[1..].Trim('0').ToInt() + 1;
                txtEvrakNo.Text = fisNo.ToString();

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
                txtAciklama.Enabled = true;
                txtAciklama.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Tutar bilgisi boş geçilemez.", "Veri Hatası");
                txtTutar.Focus();
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

        private CekSenetBordro ReadCekSenetBordroFromForm() => new()
        {
            No = txtBordroNo.Text,
            Cari = _secilenCari,
            CariId = _secilenCari.Id,
            Tarih = dtpCikisTarih.Value,
            Tur = "Borç Tediye",
            Aciklama = txtBordroAciklama.Text
        };

        private CekSenetBorc ReadCekSenetBorcFromForm() => new()
        {
            No = txtEvrakNo.Text,
            Vade = dtpVade.Value,
            Tutar = _evrakTutar,
            Aciklama = txtAciklama.Text
        };

        private void WriteCekSenetBorcToForm(CekSenetBorc secilenBorcEvrak)
        {
            ClearCurrentEvrak();
            txtEvrakNo.Text = secilenBorcEvrak.No;
            dtpVade.Value = secilenBorcEvrak.Vade;
            txtTutar.Text = secilenBorcEvrak.Tutar.ToString("#,###.## TL");
            txtAciklama.Text = secilenBorcEvrak.Aciklama;
            txtEvrakNo.Focus();
        }

        private void WriteEvraklarToDgv(List<CekSenetBorc> borcEvraklar)
        {
            dgvEvrakCik.DataSource = borcEvraklar.Select(s => new
            {
                s.Id,
                s.No,
                s.Vade,
                Tutar = s.Tutar.ToString("#,###.## TL"),
                s.Aciklama
            }).ToList();
        }

        private void ClearCurrentEvrak()
        {
            WriteEvraklarToDgv(_borcCekSenetler);

            txtEvrakNo.Text = "";
            txtEvrakNo.Enabled = true;

            dtpVade.Value = DateTime.Today;
            dtpVade.Enabled = false;

            txtTutar.Text = "";
            txtTutar.Enabled = false;

            txtAciklama.Text = "";
            txtAciklama.Enabled = false;

            isUpdate = false;
            _secilenBorcEvrakIndex = -1;
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
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            lblCariUnvan.Text = "";

            txtEvrakNo.Enabled = false;
            dtpCikisTarih.Enabled = false;
            txtBordroAciklama.Enabled = false;
            dtpCikisTarih.Value = DateTime.Today;
            txtAciklama.Text = "";

            _borcCekSenetler.Clear();
            _secilenTediyeBordro = null;

            uscBorcEvrakCik.BtnClear_Visible = false;
            uscBorcEvrakCik.BtnSave_Enable = false;
            uscBorcEvrakCik.BtnDelete_Enable = false;

            txtBordroNo.Focus();
        }

        private void OpenNewBordro()
        {
            StaticPrimitives.SecilenBordroId = -1;
            _secilenTediyeBordro = new();
            var bordro = txtBordroNo.Text;
            ClearScreen();
            txtBordroNo.Text = bordro;
            txtBordroNo.Enabled = false;
            btnBordroNoBul.Enabled = false;
            uscBorcEvrakCik.BtnClear_Visible = true;
            uscBorcEvrakCik.BtnSave_Enable = true;
            uscBorcEvrakCik.BtnSave_Text = "Kaydet";
            txtCariKod.Text = "";
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            lblCariUnvan.Text = "";
            dtpCikisTarih.Value = DateTime.Today;
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
            dtpCikisTarih.Enabled = false;
            dtpCikisTarih.Value = secilenBordro.Tarih;
            txtBordroAciklama.Text = secilenBordro.Aciklama;
            lblCariUnvan.Text = secilenBordro.Cari.Unvan;

            WriteEvraklarToDgv(secilenBordro.CekSenetBorclar);

            grpEvrakBilgiler.Enabled = true;
            uscBorcEvrakCik.BtnClear_Visible = true;
            uscBorcEvrakCik.BtnDelete_Enable = true;
            uscBorcEvrakCik.BtnSave_Enable = true;
            uscBorcEvrakCik.BtnSave_Text = "Güncelle";
        }
    }
}