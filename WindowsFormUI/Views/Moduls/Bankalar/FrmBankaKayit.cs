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
        private bool isUpdate;

        public BankaIslemTurleri BankaIslemTuru { get; set; }

        public FrmBankaKayit(IBankaService bankaService, IBankaHareketService bankaHareketService, ICariService cariService)
        {
            InitializeComponent();
            _bankaService = bankaService;
            _bankaHareketService = bankaHareketService;
            _cariService = cariService;
            BankaIslemTuru = BankaIslemTurleri.Hepsi;
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
            try
            {
                _bankaHareketler.Clear();
                string startWith = BankaIslemTuru.ToChar().ToString();
                _bankaHareketler.AddRange(_bankaHareketService.GetList(s => s.EvrakNo.StartsWith(startWith)).Data);
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

        private void BtnHesapBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBankaKart>();
            form.SecimIcin = true;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenBankaId > 0)
                {
                    txtHesapNo.Text = _bankaService.GetById(StaticPrimitives.SecilenBankaId).Data.HesapNo;
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
                    txtCariKod.Text = _cariService.GetById(StaticPrimitives.SecilenCariId).Data.Kod;
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
                    txtEvrakNo.Text = _bankaHareketService.GetById(StaticPrimitives.SecilenBankaHareketId).Data.EvrakNo;
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
                IResult result;
                if (isUpdate)
                {
                    result = _bankaHareketService.Update(ReadBankaHareketFromForm());
                }
                else
                {
                    _secilenBankaHareket = ReadBankaHareketFromForm();
                    _secilenBankaHareket.CariHareket = new()
                    {
                        Id = 0,
                        CariId = _secilenCari.Id,
                        Tarih = dtpBankaTarih.Value,
                        Aciklama = $"{txtEvrakNo.Text} evrak nolu {BankaIslemTuru.ToText()}",
                        Tutar = BankaIslemTuru == BankaIslemTurleri.Tahsilat ? _girenCikanMiktar * -1 : _girenCikanMiktar,
                    };
                    result = _bankaHareketService.Add(_secilenBankaHareket);
                }
                ClearForm_IslemBilgileri();
                UpdateDgvBankaHareketler();
                uscBankaButtons.LblStatus_Text = result.Message;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void UscBankaButtons_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                if (_secilenBankaHareket != null)
                {
                    var result = _bankaHareketService.Delete(_secilenBankaHareket);
                    ClearForm_IslemBilgileri();
                    UpdateDgvBankaHareketler();
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

        private void TxtHesapNo_Leaved()
        {
            try
            {
                _secilenHesap = _bankaService.GetByHesapNo(txtHesapNo.Text).Data;
                if (_secilenHesap != null)
                {
                    btnHesapBul.Enabled = false;
                    txtHesapNo.Enabled = false;

                    txtCariKod.Enabled = true;
                    btnCariBul.Enabled = true;

                    uscBankaButtons.BtnClear_Visible = true;

                    txtCariKod.Focus();
                }
                else
                {
                    MessageHelper.SuccessMessageBuilder(Messages.BankaMessages.HesapBulunamadi, "Veri Hatası");
                    txtHesapNo.Focus();
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
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

                    txtEvrakNo.Text = _bankaHareketService.GetNewRowsEvrakNo().Data.ToString();
                    txtEvrakNo.Enabled = true;

                    txtCariKod.Enabled = false;
                    btnCariBul.Enabled = false;
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
                txtCariKod.Focus();
            }
        }

        private void TxtEvrakNo_Leaved()
        {
            if (txtEvrakNo.Text.Length <= 14)
            {
                var evrakNo = ModulExtensions.FormatNoString(txtEvrakNo.Text, 14, BankaIslemTuru.ToChar());
                txtEvrakNo.Text = evrakNo;
                var result = _bankaHareketService.GetByEvrakNo(evrakNo);
                if (result.Data == null)
                    GetNewBankaHareket();
                else
                    GetOldBankaHareket(result.Data);
                txtMiktar.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder(Messages.BankaMessages.EvrakNoHatali, this.Text);
                txtEvrakNo.Focus();
            }
        }

        private void TxtMiktar_Leaved()
        {
            if (txtMiktar.Text.Length > 0)
            {
                _girenCikanMiktar = txtMiktar.Text.ToDecimal();
                txtMiktar.Text = _girenCikanMiktar.ToString("#,###.## TL");
                dtpBankaTarih.Enabled = true;
                txtMiktar.Enabled = false;
                dtpBankaTarih.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder(Messages.BankaMessages.MiktarBosGecilemez, this.Text);
                txtMiktar.Focus();
            }
        }

        private void DtpBankaTarih_Leaved()
        {
            if (dtpBankaTarih.Value.Date <= DateTime.Today.Date)
            {
                txtAciklama.Enabled = true;
                dtpBankaTarih.Enabled = false;
            }
            else
            {
                MessageHelper.ErrorMessageBuilder(Messages.BankaMessages.TarihHatali, this.Text);
                dtpBankaTarih.Focus();
            }
        }

        private void TxtAciklama_Leaved()
        {
            if (txtAciklama.Text != "")
            {
                uscBankaButtons.BtnSave_Enable = true;
                txtAciklama.Enabled = false;
            }
            else
            {
                MessageHelper.ErrorMessageBuilder(Messages.BankaMessages.AciklamaBosGecilemez, this.Text);
                txtAciklama.Focus();
            }
        }

        private void GetNewBankaHareket()
        {
            txtMiktar.Enabled = true;
            txtEvrakNo.Enabled = false;
            btnEvrakBul.Enabled = false;
        }

        private void GetOldBankaHareket(BankaHareket bankaHareket)
        {
            _secilenBankaHareket = bankaHareket;
            _secilenHesap = _secilenBankaHareket.Banka;
            _secilenCari = _secilenBankaHareket.CariHareket.Cari;

            txtHesapNo.Text = _secilenHesap.HesapNo;
            txtHesapNo.Enabled = false;
            btnHesapBul.Enabled = false;

            txtCariKod.Text = _secilenCari.Kod;
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            lblCariAd.Text = _secilenCari.Unvan;

            txtEvrakNo.Text = _secilenBankaHareket.EvrakNo;
            txtEvrakNo.Enabled = true;
            btnEvrakBul.Enabled = true;

            txtMiktar.Text = _secilenBankaHareket.GirenCikanMiktar.ToString("#,###.## TL");
            txtMiktar.Enabled = true;

            dtpBankaTarih.Value = _secilenBankaHareket.Tarih;
            dtpBankaTarih.Enabled = false;

            txtAciklama.Text = _secilenBankaHareket.Aciklama;
            txtAciklama.Enabled = false;

            uscBankaButtons.BtnClear_Visible = true;
            uscBankaButtons.BtnDelete_Enable = true;
            uscBankaButtons.BtnSave_Enable = false;

            uscBankaButtons.BtnSave_Text = "Güncelle";
            isUpdate = true;
        }

        private BankaHareket ReadBankaHareketFromForm() => new()
        {
            Id = 0,
            BankaId = _secilenHesap.Id,
            CariId = _secilenCari.Id,
            EvrakNo = txtEvrakNo.Text,
            GirenCikanMiktar = BankaIslemTuru == BankaIslemTurleri.Tahsilat ? _girenCikanMiktar : _girenCikanMiktar *= -1,
            Tarih = dtpBankaTarih.Value,
            Aciklama = txtAciklama.Text
        };

        private void DgvBankaHareketler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var id = (int)dgvBankaHareketler.Rows[e.RowIndex].Cells["colId"].Value;
                GetOldBankaHareket(_bankaHareketService.GetById(id).Data);
            }
        }

        private void HarfEngelle(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Contains(','))
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}