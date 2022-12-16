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
using WindowsFormUI.Properties;
using WindowsFormUI.Views.Moduls.Cariler;
using WindowsFormUI.Views.UserExtensions;

namespace WindowsFormUI.Views.Moduls.Bankalar
{
    public partial class FrmBankaKayit : FrmBase
    {
        private readonly IBankaService _bankaService;
        private readonly IBankaHareketService _bankaHareketService;
        private readonly ICariService _cariService;
        private Banka _secilenBanka;
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
        }

        private void FrmBankaKayit_Load(object sender, EventArgs e)
        {
            if (BankaIslemTuru == BankaIslemTuru.Tahsilat)
            {
                this.Icon = Resources.Banka_Tahsilat32x321;
                this.Text += "  --  Tahsilat Yap";
            }
            else if (BankaIslemTuru == BankaIslemTuru.Tediye)
            {
                this.Icon = Resources.Banka_Odeme32x321;
                this.Text += "  --  Tediye (Ödeme) Yap";
            }
            ClearScreen();
        }

        private void ClearScreen()
        {
            uscBankaButtons.TabStop = false;

            txtBankaAd.Enabled = true;
            btnBankaBul.Enabled = true;
            txtBankaAd.Text = "00-Merkez Banka";

            txtCariKod.Enabled = false;
            txtCariKod.Text = "";
            btnCariBul.Enabled = false;
            lblCariAd.Text = "";

            txtEvrakNo.Enabled = false;
            txtEvrakNo.Text = "";
            btnEvrakBul.Enabled = false;

            txtMiktar.Enabled = false;
            txtMiktar.Text = "";

            txtAciklama.Enabled = false;
            txtAciklama.Text = "";

            dtpBankaTarih.Enabled = false;

            uscBankaButtons.BtnClear_Visible = false;
            uscBankaButtons.BtnDelete_Enable = false;
            uscBankaButtons.BtnSave_Enable = false;
            uscBankaButtons.BtnSave_Text = "Kaydet";

            _secilenBanka = null;
            _secilenCari = null;
            _secilenBankaHareket = null;

            dgvBankaHareketler.DataSource = ListeyeYaz(_bankaHareketService.GetList(s => s.EvrakNo.StartsWith(BankaIslemTuru.ToCharString())).Data);
            txtBankaAd.Focus();
        }

        private object ListeyeYaz(List<BankaHareket> bankaHareketler)
        {
            return bankaHareketler.Select(s => new
            {
                s.Id,
                s.BankaId,
                BankaAd = _bankaService.GetById(s.BankaId).Data.Ad,
                s.CariId,
                _cariService.GetById(s.CariId).Data.Unvan,
                s.EvrakNo,
                s.GirenCikanMiktar,
                s.Tarih,
                s.Aciklama
            }).ToList();
        }

        private void BtnBankaBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBankaKart>();
            form.SecimIcin = true;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenBankaId > 0)
                {
                    _secilenBanka = _bankaService.GetById(StaticPrimitives.SecilenBankaId).Data;
                    StaticPrimitives.SecilenBankaId = 0;
                    txtBankaAd.Text = _secilenBanka.Ad;
                }
                else txtBankaAd.Text = "";
                txtBankaAd.Focus();
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
                    StaticPrimitives.SecilenCariId = 0;
                    txtCariKod.Text = _secilenCari.Kod;
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
            var form = Program.Container.Resolve<FrmBankaListe>();
            form.BankaIslemTuru = BankaIslemTuru;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenBankaHareketId > 0)
                {
                    _secilenBankaHareket = _bankaHareketService.GetById(StaticPrimitives.SecilenBankaHareketId).Data;
                    StaticPrimitives.SecilenBankaHareketId = 0;
                    txtEvrakNo.Text = _secilenBankaHareket.EvrakNo;
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
            ClearScreen();
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

        private BankaHareket ReadBankaHareketFromForm()
        {
            return new BankaHareket
            {
                BankaId = _secilenBanka.Id,
                CariId = _secilenCari.Id,
                EvrakNo = txtEvrakNo.Text,
                Aciklama = txtAciklama.Text,
                GirenCikanMiktar = _girenCikanMiktar,
                Tarih = dtpBankaTarih.Value
            };
        }

        private void UscBankaButtons_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                if (_secilenBankaHareket != null)
                {
                    var result = _bankaHareketService.Delete(_secilenBankaHareket);
                    ClearScreen();
                    uscBankaButtons.LblStatus_Text = result.Message;
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void ThrowLeaveOnlyWithTabKey(object sender, PreviewKeyDownEventArgs e)
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
                _secilenBanka ??= _bankaService.GetByAd(txtBankaAd.Text).Data;
                if (_secilenBanka == null)
                {
                    MessageHelper.SuccessMessageBuilder(Messages.BankaMessages.BankaBulunamadi, this.Text);
                    txtBankaAd.Focus();
                    return;
                }

                txtEvrakNo.Enabled = true;
                btnEvrakBul.Enabled = true;
                uscBankaButtons.BtnClear_Visible = true;
                //
                BankaHareket yenifis = _bankaHareketService.GetList((s => s.BankaId == _secilenBanka.Id && s.EvrakNo.StartsWith(BankaIslemTuru.ToCharString()))).Data?.MaxBy(s => s.Id);
                int fisNo = yenifis == null ? 1 : yenifis.EvrakNo[1..].Trim('0').ToInt() + 1;
                txtEvrakNo.Text = fisNo.ToString();
                //
                txtBankaAd.Enabled = false;
                btnBankaBul.Enabled = false;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
            txtEvrakNo.Focus();
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

        private void TxtCariKod_Leaved()
        {
            try
            {
                if (_secilenCari == null)
                {
                    var result = _cariService.GetByKod(txtCariKod.Text);
                    if (result.Data != null)
                        _secilenCari = result.Data;
                    else
                        throw new Exception(Messages.CariMessages.CariYok);
                }
                txtMiktar.Enabled = true;
                lblCariAd.Text = _secilenCari.Unvan;
                txtCariKod.Enabled = false;
                btnCariBul.Enabled = false;
            }
            catch(Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
                txtCariKod.Focus();
            }
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
            txtBankaAd.Enabled = true;
            btnBankaBul.Enabled = true;
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

            _secilenBanka = secilenBankaHareket.Banka;
            txtBankaAd.Text = _secilenBanka.Ad;
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