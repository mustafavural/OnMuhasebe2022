using Autofac;
using Business.Abstract;
using Core.Extensions;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;
using WindowsFormUI.Views.Moduls.Cariler;
using WindowsFormUI.Views.UserExtensions;

namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    public partial class FrmMusteriyePortfoydenEvrakCik : FrmBase
    {
        private readonly ICekSenetBordroService _cekSenetBordroService;
        private readonly ICekSenetMusteriService _cekSenetMusteriService;
        private readonly ICariService _cariService;
        private readonly ICariHareketService _cariHareketService;
        private readonly List<CekSenetMusteri> _musteriCekSenetler;
        private CekSenetBordro _secilenTediyeBordro;
        private Cari _secilenCari;
        private int _secilenMusteriEvrakIndex;

        public FrmMusteriyePortfoydenEvrakCik(ICekSenetBordroService cekSenetBordroService, ICariService cariService, ICekSenetMusteriService cekSenetMusteriService, ICariHareketService cariHareketService)
        {
            InitializeComponent();
            _cekSenetBordroService = cekSenetBordroService;
            _cekSenetMusteriService = cekSenetMusteriService;
            _cariService = cariService;
            _cariHareketService = cariHareketService;
            _musteriCekSenetler = new();
            ClearForm_EvrakBilgiler();
            ClearForm_BordroBilgiler();
            ClearParameters();
        }

        private void HarfEngelle(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnBordroNoBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBordroListe>();
            form.BordroTur = BordroTurleri.MusteriTediye;
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
                    _secilenCari = _cariService.GetById(StaticPrimitives.SecilenCariId).Data;
                    txtCariKod.Text = _secilenCari.Kod;
                    txtCariKod.Focus();
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void BtnEvrakBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmPortfoydekiEvraklar>();
            form.SecimIcin = true;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenMusteriEvrakId > 0)
                {
                    string evrakNo = _cekSenetMusteriService.GetById(StaticPrimitives.SecilenMusteriEvrakId).Data.No;
                    txtEvrakNo.Text = evrakNo;
                    txtEvrakNo.Focus();
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void DgvEvraklar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _secilenMusteriEvrakIndex = e.RowIndex;
                uscEvrak.BtnDelete_Enable = true;
            }
        }

        private void UscEvrak_ClickSil(object sender, EventArgs e)
        {
            _musteriCekSenetler.RemoveAt(_secilenMusteriEvrakIndex);
            _secilenMusteriEvrakIndex = -1;
            uscEvrak.BtnDelete_Enable = false;
            Update_DgvPortfoydenEvrakCik();
        }

        private void UscBordro_ClickClear(object sender, EventArgs e)
        {
            ClearForm_BordroBilgiler();
        }

        private void UscBordro_ClickSil(object sender, EventArgs e)
        {
            try
            {
                _cekSenetBordroService.Delete(_secilenTediyeBordro);
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void UscBordro_ClickSave(object sender, EventArgs e)
        {
            try
            {
                if (_secilenTediyeBordro.Id > 0)
                {
                    _secilenTediyeBordro.CekSenetMusteriler = _musteriCekSenetler;
                    _cekSenetBordroService.Update(_secilenTediyeBordro);
                }
                else
                {
                    _secilenTediyeBordro.Id = 0;
                    _secilenTediyeBordro.No = txtBordroNo.Text;
                    _secilenTediyeBordro.Tur = BordroTurleri.MusteriTediye.ToText();
                    _secilenTediyeBordro.CariId = _secilenCari.Id;
                    _secilenTediyeBordro.Cari = _secilenCari;
                    _secilenTediyeBordro.CariHareket = new()
                    {
                        Id = 0,
                        CariId = _secilenCari.Id,
                        Cari = _secilenCari,
                        Tutar = _musteriCekSenetler.Sum(s => s.Tutar),
                        Tarih = dtpCikisTarih.Value,
                        Aciklama = $"{_secilenTediyeBordro.No} nolu {BordroTurleri.MusteriTediye.ToText()}"
                    };
                    _secilenTediyeBordro.Tarih = dtpCikisTarih.Value;
                    _secilenTediyeBordro.CekSenetMusteriler = _musteriCekSenetler;
                    _secilenTediyeBordro.Aciklama = txtBordroAciklama.Text;
                   
                    var result = _cekSenetBordroService.Add(_secilenTediyeBordro);
                    if (result.IsSuccess)
                    {
                        MessageHelper.SuccessMessageBuilder(result.Message, "Başarılı");
                        ClearForm_EvrakBilgiler();
                        ClearForm_BordroBilgiler();
                        ClearParameters();
                    }
                    else MessageHelper.ErrorMessageBuilder(result.Message, "Başarısız");
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
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
                    if (result.Data.Tur == "Ciro Tediye Bordrosu")
                    {
                        _secilenTediyeBordro = result.Data;
                        GetOldBordro(_secilenTediyeBordro);
                        txtCariKod.Focus();
                    }
                    else
                    {
                        MessageHelper.ErrorMessageBuilder("Girdiğiniz numara başka bir tahsilat veya borç tediye bordrosuna ait. Bu ekranda kullanılamaz...", "Yanlış Evrak");
                        txtBordroNo.Text = "";
                        txtBordroNo.Focus();
                    }
                }
                else
                    GetNewBordro();
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
            if (dtpCikisTarih.Value >= DateTime.Today.Date)
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
                txtEvrakNo.Enabled = true;
                btnEvrakBul.Enabled = true;
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
            try
            {
                txtEvrakNo.Text = ModulExtensions.FormatNoString(txtEvrakNo.Text, 14, 'E');
                var evrak = _cekSenetMusteriService.GetByNo(txtEvrakNo.Text).Data;
                if (_musteriCekSenetler.Find(s => s.No == evrak.No) == null)
                    _musteriCekSenetler.Add(evrak);
                Update_DgvPortfoydenEvrakCik();
                ClearForm_EvrakBilgiler();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
                txtEvrakNo.Focus();
            }
        }

        private void Update_DgvPortfoydenEvrakCik()
        {
            dgvPortfoydenEvrakCik.DataSource = _musteriCekSenetler.Select(s => new
            {
                s.Id,
                s.No,
                _cariHareketService.GetById(s.BordroTahsilatId).Data.Cari.Unvan,
                s.Vade,
                Tutar = s.Tutar.ToString("#,###.## TL"),
                s.AsilBorclu,
                s.Aciklama
            }).ToList();
        }

        private void ClearForm_EvrakBilgiler()
        {
            txtEvrakNo.Text = "";
            txtEvrakNo.Enabled = true;
            btnEvrakBul.Enabled = true;
        }

        private void ClearForm_BordroBilgiler()
        {
            txtBordroNo.Text = _cekSenetBordroService.GetNewRowsEvrakNo().Data.ToString();
            txtBordroNo.Enabled = true;
            btnBordroBul.Enabled = true;

            txtCariKod.Text = "";
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            lblCariUnvan.Text = "";

            dtpCikisTarih.Value = DateTime.Today;
            dtpCikisTarih.Enabled = false;

            txtBordroAciklama.Text = "";
            txtBordroAciklama.Enabled = false;

            txtEvrakNo.Text = "";
            txtEvrakNo.Enabled = false;
            btnEvrakBul.Enabled = false;
        }

        private void ClearParameters()
        {
            _musteriCekSenetler.Clear();
            _secilenTediyeBordro = null;
            _secilenCari = null;
            _secilenMusteriEvrakIndex = -1;
        }

        private void GetNewBordro()
        {
            _secilenTediyeBordro = new();
            txtBordroNo.Enabled = false;
            btnBordroBul.Enabled = false;
            
            txtCariKod.Text = "";
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            lblCariUnvan.Text = "";
            
            dtpCikisTarih.Value = DateTime.Today;

            uscBordro.BtnClear_Visible = true;
            uscBordro.BtnSave_Enable = true;
            uscBordro.BtnSave_Text = "Kaydet";
            txtCariKod.Focus();
        }

        private void GetOldBordro(CekSenetBordro secilenBordro)
        {
            ClearForm_BordroBilgiler();
            _secilenTediyeBordro = secilenBordro;
            StaticPrimitives.SecilenBordroId = _secilenTediyeBordro.Id;
            _musteriCekSenetler.Clear();
            _musteriCekSenetler.AddRange(_secilenTediyeBordro.CekSenetMusteriler);

            txtBordroNo.Text = _secilenTediyeBordro.No;
            txtCariKod.Text = _secilenTediyeBordro.Cari.Kod;
            dtpCikisTarih.Value = _secilenTediyeBordro.Tarih;
            txtBordroAciklama.Text = _secilenTediyeBordro.Aciklama;
            lblCariUnvan.Text = _secilenTediyeBordro.Cari.Unvan;


            Update_DgvPortfoydenEvrakCik();

            uscBordro.BtnClear_Visible = true;
            uscBordro.BtnDelete_Enable = true;
            uscBordro.BtnSave_Enable = true;
            uscBordro.BtnSave_Text = "Güncelle";
        }
    }
}