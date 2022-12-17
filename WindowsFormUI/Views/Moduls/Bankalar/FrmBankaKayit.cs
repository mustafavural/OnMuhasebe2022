using Autofac;
using Business.Abstract;
using Business.Constants;
using Core.Extensions;
using Core.Utilities.Results;
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

namespace WindowsFormUI.Views.Moduls.Bankalar
{
    public partial class FrmBankaKayit : FrmBase
    {
        private readonly IBankaService _bankaService;
        private readonly IBankaHareketService _bankaHareketService;
        private readonly ICariService _cariService;
        private readonly List<BankaHareket> _bankaHareketler;
        private Banka _secilenHesap;
        private Cari _secilenCari;
        private BankaHareket _secilenBankaHareket;
        private decimal _girenCikanMiktar = 0;

        public BankaIslemTuru BankaIslemTuru { get; set; }

        public FrmBankaKayit(IBankaService bankaService, IBankaHareketService bankaHareketService, ICariService cariService)
        {
            InitializeComponent();
            _bankaService = bankaService;
            _bankaHareketService = bankaHareketService;
            _cariService = cariService;
            BankaIslemTuru = BankaIslemTuru.Hepsi;
            _bankaHareketler = new();
        }

        private void FrmBankaKayit_Load(object sender, EventArgs e)
        {
            ClearForm_IslemBilgileri();
            UpdateDgvBankaHareketler();
        }

        private void ClearForm_IslemBilgileri()
        {
            txtHesapNo.Text = "";
            txtHesapNo.Enabled = true;
            btnHesapBul.Enabled = true;

            txtCariKod.Text = "";
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            lblCariAd.Text = "";

            txtEvrakNo.Text = "";
            txtEvrakNo.Enabled = false;
            btnEvrakBul.Enabled = false;

            txtMiktar.Text = "";
            txtMiktar.Enabled = false;

            txtAciklama.Text = "";
            txtAciklama.Enabled = false;

            dtpBankaTarih.Value = DateTime.Today;
            dtpBankaTarih.Enabled = false;

            uscBankaButtons.BtnClear_Visible = false;
            uscBankaButtons.BtnDelete_Enable = false;
            uscBankaButtons.BtnSave_Enable = false;
            uscBankaButtons.BtnSave_Text = "Kaydet";

            txtHesapNo.Focus();

            /////////////////////////////////
            _secilenHesap = null;
            _secilenCari = null;
            _secilenBankaHareket = null;

        }

        private void UpdateDgvBankaHareketler()
        {
            _bankaHareketler.Clear();
            _bankaHareketler.AddRange(_bankaHareketService.GetList(s => s.EvrakNo.StartsWith(BankaIslemTuru.ToCharString())).Data);
            dgvBankaHareketler.DataSource = _bankaHareketler.Select(s => new
            {
                s.Id,
                s.BankaId,
                s.CariId,
                _cariService.GetById(s.CariId).Data.Unvan,
                s.EvrakNo,
                s.GirenCikanMiktar,
                s.Tarih,
                s.Aciklama
            }).ToList();
        }

        private void BtnHesapBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBankaKart>();
            form.SecimIcin = true;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenBankaId > 0)
                {
                    _secilenHesap = _bankaService.GetById(StaticPrimitives.SecilenBankaId).Data;
                    txtHesapNo.Text = _secilenHesap.HesapNo;
                    StaticPrimitives.SecilenBankaId = 0;
                }
                else txtHesapNo.Text = "";
                txtHesapNo.Focus();
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
                    StaticPrimitives.SecilenCariId = 0;
                }
                else txtCariKod.Text = "";
                txtCariKod.Focus();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void BtnEvrakBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBankaHareketListe>();
            form.BankaIslemTuru = BankaIslemTuru;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenBankaHareketId > 0)
                {
                    _secilenBankaHareket = _bankaHareketService.GetById(StaticPrimitives.SecilenBankaHareketId).Data;
                    txtEvrakNo.Text = _secilenBankaHareket.EvrakNo;
                    StaticPrimitives.SecilenBankaHareketId = 0;
                }
                else txtEvrakNo.Text = "";
                txtEvrakNo.Focus();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void UscBankaButtons_ClickClear(object sender, EventArgs e)
        {
            ClearForm_IslemBilgileri();
            UpdateDgvBankaHareketler();
        }

        private void UscBankaButtons_ClickSave(object sender, EventArgs e)
        {
            try
            {
                IResult result = _secilenBankaHareket == null
                    ? _bankaHareketService.Add(ReadBankaHareketFromForm())
                    : _bankaHareketService.Update(_secilenBankaHareket);
                uscBankaButtons.LblStatus_Text = result.Message;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private BankaHareket ReadBankaHareketFromForm() => new()
        {
            Id = 0,
            BankaId = _secilenHesap.Id,
            CariId = _secilenCari.Id,
            EvrakNo = txtEvrakNo.Text,
            GirenCikanMiktar = _girenCikanMiktar,
            Tarih = dtpBankaTarih.Value,
            Aciklama = txtAciklama.Text
        };

        private void UscBankaButtons_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                if (_secilenBankaHareket != null)
                {
                    var result = _bankaHareketService.Delete(_secilenBankaHareket);
                    ClearForm_IslemBilgileri();
                    uscBankaButtons.LblStatus_Text = result.Message;
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
                string controlName = ((Control)sender).Name.ToFirstLetterUpperCase();
                controlName += "_Leaved";

                MethodInfo methodInfo = this.GetType().GetMethod(controlName, BindingFlags.NonPublic | BindingFlags.Instance);
                methodInfo.Invoke(this, null);
            }
        }

        private void TxtBankaAd_Leaved()
        {
            try
            {
                _secilenHesap ??= _bankaService.GetByHesapNo(txtHesapNo.Text).Data;
                if (_secilenHesap == null)
                {
                    MessageHelper.SuccessMessageBuilder(Messages.BankaMessages.HesapBulunamadi, this.Text);
                    txtHesapNo.Focus();
                    return;
                }

                txtCariKod.Enabled = true;
                btnCariBul.Enabled = true;

                txtHesapNo.Enabled = false;
                btnHesapBul.Enabled = false;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
            txtCariKod.Focus();
        }

        private void TxtCariKod_Leaved()
        {
            try
            {
                var result = _cariService.GetByKod(txtCariKod.Text);
                if (result.Data == null)
                    throw new Exception(Messages.CariMessages.CariYok);
                else
                {
                    _secilenCari = result.Data;
                    lblCariAd.Text = _secilenCari.Unvan;
                }
                //
                BankaHareket yenifis = _bankaHareketService.GetList((s => s.BankaId == _secilenHesap.Id && s.EvrakNo.StartsWith(BankaIslemTuru.ToCharString()))).Data?.MaxBy(s => s.Id);
                int fisNo = yenifis == null ? 1 : yenifis.EvrakNo[1..].Trim('0').ToInt() + 1;
                txtEvrakNo.Text = fisNo.ToString();
                //
                txtEvrakNo.Enabled = true;

                txtCariKod.Enabled = false;
                btnCariBul.Enabled = false;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
                txtCariKod.Focus();
            }
        }

        private void TxtEvrakNo_Leaved()
        {
            string evrakNo = "";
            if (txtEvrakNo.Text.Length > 12)
            {
                MessageHelper.SuccessMessageBuilder(Messages.BankaMessages.EvrakNoHatali, this.Text);
                txtEvrakNo.Text = "";
            }
            else
                evrakNo = ModulExtensions.FormatNoString(txtEvrakNo.Text, 14, 'K');
            if (_secilenBankaHareket == null)
            {
                var result = _bankaHareketService.GetByEvrakNo(evrakNo);
                if (result.Data != null)
                {
                    _secilenBankaHareket = result.Data;
                    BringExistingBankaHareket(_secilenBankaHareket);
                }
            }
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            txtEvrakNo.Text = evrakNo;
            txtEvrakNo.Enabled = false;
            btnEvrakBul.Enabled = false;
            txtCariKod.Focus();
        }

        private void TxtMiktar_Leaved()
        {
            if(txtMiktar.Text.Length> 0)
            { 
                txtAciklama.Enabled = true;
                _girenCikanMiktar = txtMiktar.Text.ToDecimal();
                txtMiktar.Text = _girenCikanMiktar.ToString("#,###.## TL");
                txtMiktar.Enabled = false;
            }
            else
            {
                MessageHelper.SuccessMessageBuilder(Messages.BankaMessages.MiktarBosGecilemez, this.Text);
                txtMiktar.Focus();
            }
        }

        private void TxtAciklama_Leaved()
        {
            if (txtAciklama.Text != "")
            {
                dtpBankaTarih.Enabled = true;
                txtAciklama.Enabled = false;
            }
            else
            {
                MessageHelper.SuccessMessageBuilder(Messages.BankaMessages.AciklamaBosGecilemez, this.Text);
                txtAciklama.Focus();
            }
        }

        private void DtpBankaTarih_Leaved()
        {
            if (dtpBankaTarih.Value.Date < DateTime.Today.Date)
            {
                uscBankaButtons.TabStop = true;
                uscBankaButtons.BtnSave_Enable = true;
                dtpBankaTarih.Enabled = false;
            }
            else
            {
                MessageHelper.SuccessMessageBuilder(Messages.BankaMessages.TarihHatali, this.Text);
                dtpBankaTarih.Focus();
            }
        }

        private void HarfEngelle(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Contains(','))
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void DgvBankaHareketler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var id = (int)dgvBankaHareketler.Rows[e.RowIndex].Cells["colId"].Value;
                _secilenBankaHareket = _bankaHareketService.GetById(id).Data;
                BringExistingBankaHareket(_secilenBankaHareket);
            }
        }

        private void BringExistingBankaHareket(BankaHareket secilenBankaHareket)
        {
            txtHesapNo.Enabled = true;
            btnHesapBul.Enabled = true;
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            txtEvrakNo.Enabled = true;
            btnEvrakBul.Enabled = true;
            txtMiktar.Enabled = true;
            txtAciklama.Enabled = true;
            dtpBankaTarih.Enabled = true;
            uscBankaButtons.BtnClear_Visible = true;
            uscBankaButtons.BtnDelete_Enable = true;
            uscBankaButtons.BtnSave_Enable = true;

            _secilenHesap = secilenBankaHareket.Banka;
            txtHesapNo.Text = _secilenHesap.BankaAd;
            txtEvrakNo.Text = secilenBankaHareket.EvrakNo;
            _secilenCari = secilenBankaHareket.CariHareket.Cari;
            txtCariKod.Text = _secilenCari.Kod;
            lblCariAd.Text = _secilenCari.Unvan;
            txtMiktar.Text = secilenBankaHareket.GirenCikanMiktar.ToString("#,###.## TL");
            dtpBankaTarih.Value = secilenBankaHareket.Tarih;
            txtAciklama.Text = secilenBankaHareket.Aciklama;
            uscBankaButtons.BtnSave_Text = "Güncelle";
        }
    }
}