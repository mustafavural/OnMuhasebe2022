using Autofac;
using Business.Abstract;
using Business.Constants;
using Core.Extensions;
using Core.Utilities.Results;
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
using WindowsFormUI.Views.Moduls.Stoklar;
using WindowsFormUI.Views.UserExtensions;

namespace WindowsFormUI.Views.Moduls.Faturalar
{
    public partial class FrmFaturaKayit : FrmBase
    {
        private readonly IFaturaService _faturaService;
        private readonly ICariService _cariService;
        private readonly IStokService _stokService;
        private List<StokHareket> FaturaKalemEntities { get; set; }

        private int _secilenKalemIndex = -1;
        private Cari _secilenCari;
        private Stok _secilenStok;
        private Fatura _secilenFatura;
        decimal stokMiktar, stokFiyat, stokBrutFiyat, stokKdv, stokNetFiyat;

        public FaturaTurleri FaturaTur { get; set; }

        public FrmFaturaKayit(IFaturaService faturaService,
                              ICariService cariService,
                              IStokService stokService)
        {
            InitializeComponent();
            _faturaService = faturaService;
            _cariService = cariService;
            _stokService = stokService;
            FaturaTur = FaturaTurleri.Hepsi;
            FaturaKalemEntities = new List<StokHareket>();
        }

        private void FrmFaturaKayit_Load(object sender, EventArgs e)
        {
            switch (FaturaTur)
            {
                case FaturaTurleri.Alis:
                    lblFaturaTurEkran.Text = "Alış Faturası";
                    this.Text = "Alış Faturası";
                    break;
                case FaturaTurleri.Satis:
                    lblFaturaTurEkran.Text = "Satış Faturası";
                    this.Text = "Satış Faturası";
                    break;
            }

            ClearScreen();
        }

        #region LeaveEvents
        private void ThrowLeaveOnlyWithTabButton(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                string txtbox = ((TextBox)sender).Name;
                txtbox = "T" + txtbox[1..] + "_Leave";

                MethodInfo methodInfo = this.GetType().GetMethod(txtbox, BindingFlags.NonPublic | BindingFlags.Instance);
                methodInfo.Invoke(this, null);
            }
        }

        private void TxtFaturaNo_Leave()
        {
            if (txtFaturaNo.Text.Length != 0)
            {
                txtFaturaNo.Text = ModulExtensions.FormatNoString(txtFaturaNo.Text, 14, 'F');
                var result = _faturaService.GetByNo(txtFaturaNo.Text);
                if (result.Data != null)
                {
                    _secilenFatura = result.Data;
                    BringExistingFatura(_secilenFatura);
                }
                else
                    OpenNewFatura();
            }
        }

        private void TxtCariKod_Leave()
        {
            if (txtCariKod.Text.Length != 0)
            {
                var result = _cariService.GetByKod(txtCariKod.Text);
                if (result.Data != null)
                {
                    _secilenCari = result.Data;
                    StaticPrimitives.SecilenCariId = _secilenCari.Id;
                    txtCariKod.Text = _secilenCari.Kod;
                    txtCariKod.Enabled = false;
                    btnCariBul.Enabled = false;
                    lblCariAd.Text = _secilenCari.Unvan;
                    grpFaturaKalem.Enabled = true;
                }
            }
        }

        private void TxtStokKod_Leave()
        {
            if (txtStokKod.Text.Length != 0)
            {
                var result = _stokService.GetByKod(txtStokKod.Text);
                if (result.Data != null)
                {
                    _secilenStok = result.Data;
                    StaticPrimitives.SecilenStokId = _secilenStok.Id;
                    txtStokKod.Enabled = false;
                    lblStokAd.Text = _secilenStok.Ad;
                    txtStokBirim.Text = _secilenStok.Birim;
                    txtStokKDV.Text = _secilenStok.Kdv.ToString();
                }
                else
                    MessageBox.Show(Messages.StokMessages.StokYok);
            }
        }

        private void TxtStokFiyat_Leave()
        {
            if (txtStokFiyat.Text.Length != 0)
            {
                stokMiktar = txtStokMiktar.Text.ToDecimal();
                stokFiyat = txtStokFiyat.Text.ToDecimal();
                stokKdv = txtStokKDV.Text.ToDecimal();
                stokBrutFiyat = stokMiktar * stokFiyat;
                stokNetFiyat = stokBrutFiyat * (stokKdv / 100 + 1);

                txtStokFiyat.Text = stokFiyat.ToString("#,###.## TL");
                txtStokBrutTutar.Text = stokBrutFiyat.ToString("#,###.## TL");
                txtStokNetTutar.Text = stokNetFiyat.ToString("#,###.## TL");
                uscKalemEkleSilGuncelle.BtnClear_Visible = true;
                uscKalemEkleSilGuncelle.BtnSave_Enable = true;
            }
        }
        #endregion

        #region Bul_ClickEvents
        private void BtnFaturaBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmFaturaListe>();
            form.FaturaTur = FaturaTur;
            form.ShowDialog();

            try
            {
                if (StaticPrimitives.SecilenFaturaId > 0)
                {
                    _secilenFatura = _faturaService.GetById(StaticPrimitives.SecilenFaturaId).Data;
                    txtFaturaNo.Text = _secilenFatura.No;
                    txtFaturaNo.Focus();
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

        private void BtnStokBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmStokListe>();
            form.SecimIcin = true;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenStokId > 0)
                {
                    _secilenStok = _stokService.GetById(StaticPrimitives.SecilenStokId).Data;
                    txtStokKod.Text = _secilenStok.Kod;
                    txtStokKod.Focus();
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }
        #endregion

        private void ClearItems()
        {
            txtStokKod.Text = "";
            txtStokKod.Enabled = true;
            lblStokAd.Text = "";
            txtStokMiktar.Text = "";
            txtStokBirim.Text = "";
            txtStokKDV.Text = "";
            txtStokFiyat.Text = "";
            txtStokBrutTutar.Text = "";
            txtStokNetTutar.Text = "";
            uscKalemEkleSilGuncelle.BtnClear_Visible = false;
            uscKalemEkleSilGuncelle.BtnSave_Enable = false;
            uscKalemEkleSilGuncelle.BtnDelete_Enable = false;
            stokMiktar = 0;
            stokFiyat = 0;
            stokBrutFiyat = 0;
            stokKdv = 0;
            stokNetFiyat = 0;
            txtStokKod.Focus();
        }

        private void ClearScreen()
        {
            ClearItems();
            txtFaturaNo.Text = "";
            txtFaturaNo.Enabled = true;
            btnFaturaBul.Enabled = true;
            txtCariKod.Text = "";
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            dtpTarih.ResetText();
            dtpTarih.Enabled = false;
            lblCariAd.Text = "";
            txtFaturaAciklama.Text = "";

            dgvFaturaKalemler.DataSource = new List<StokHareket>();
            FaturaKalemEntities.Clear();
            txtFaturaAraToplam.Text = "";
            txtFaturaKDVlerToplam.Text = "";
            txtFaturaGenelToplam.Text = "";
            uscFaturaEkleSilGuncelle.BtnClear_Visible = false;
            uscFaturaEkleSilGuncelle.BtnDelete_Enable = false;
            uscFaturaEkleSilGuncelle.BtnSave_Enable = false;
            grpFaturaKalem.Enabled = false;
            txtFaturaNo.Focus();
        }

        private void BringExistingFatura(Fatura fatura)
        {
            ClearScreen();
            StaticPrimitives.SecilenFaturaId = fatura.Id;
            txtFaturaNo.Text = fatura.No;
            txtFaturaNo.Enabled = false;
            btnFaturaBul.Enabled = false;
            txtCariKod.Text = fatura.Cari.Kod;
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            txtFaturaAciklama.Text = fatura.Aciklama;
            dtpTarih.Enabled = true;
            dtpTarih.Value = fatura.Tarih;
            lblCariAd.Text = fatura.Cari.Unvan;
            FaturaKalemEntities = fatura.StokHareketler;
            dgvFaturaKalemler.DataSource = HareketleriListeyeYaz(FaturaKalemEntities);

            UpdateAltBilgiler();
            uscFaturaEkleSilGuncelle.BtnClear_Visible = true;
            uscFaturaEkleSilGuncelle.BtnDelete_Enable = true;
            uscFaturaEkleSilGuncelle.BtnSave_Enable = true;
            uscFaturaEkleSilGuncelle.BtnSave_Text = "Güncelle";
            grpFaturaKalem.Enabled = true;
        }

        private StokHareket ReadStokHareketFromForm()
        {
            return new StokHareket
            {
                StokId = _stokService.GetByKod(txtStokKod.Text).Data.Id,
                Miktar = stokMiktar,
                Birim = txtStokBirim.Text,
                Fiyat = stokFiyat,
                BrutTutar = stokBrutFiyat,
                Kdv = stokKdv.ToString().ToInt(),
                NetTutar = stokNetFiyat
            };
        }

        private Fatura ReadFaturaFromForm()
        {
            return new Fatura
            {
                No = txtFaturaNo.Text,
                CariId = _secilenCari.Id,
                Cari = _secilenCari,
                KayitTarihi = DateTime.Now.Date,
                Tarih = dtpTarih.Value,
                Tur = lblFaturaTurEkran.Text,
                Aciklama = txtFaturaAciklama.Text,
                StokHareketler = FaturaKalemEntities
            };
        }

        private object HareketleriListeyeYaz(List<StokHareket> stokHareketler)
        {
            object result = null;
            try
            {
                result = stokHareketler.Select(h => new
                {
                    h.Id,
                    StokKod = _stokService.GetById(h.StokId).Data.Kod,
                    StokAd = _stokService.GetById(h.StokId).Data.Ad,
                    h.Miktar,
                    h.Birim,
                    h.Fiyat,
                    h.BrutTutar,
                    h.Kdv,
                    h.NetTutar,
                }).ToList();
            }
            catch(Exception err) 
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
            return result;
        }

        private void OpenNewFatura()
        {
            StaticPrimitives.SecilenFaturaId = -1;
            _secilenFatura = null;
            string fNo = txtFaturaNo.Text;
            ClearScreen();
            txtFaturaNo.Text = fNo;
            txtFaturaNo.Enabled = false;
            uscFaturaEkleSilGuncelle.BtnClear_Visible = true;
            uscFaturaEkleSilGuncelle.BtnSave_Enable = true;
            uscFaturaEkleSilGuncelle.BtnSave_Text = "Fatura Kes";
            txtCariKod.Text = "";
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            dtpTarih.Enabled = true;
            dtpTarih.Value = DateTime.Today;
            lblCariAd.Text = "";
        }

        private void UpdateAltBilgiler()
        {
            txtFaturaAraToplam.Text = FaturaKalemEntities.Sum(s => s.BrutTutar).Value.ToString("#,###.## TL");
            txtFaturaKDVlerToplam.Text = FaturaKalemEntities.Sum(s => s.NetTutar - s.BrutTutar).Value.ToString("#,###.## TL");
            txtFaturaGenelToplam.Text = FaturaKalemEntities.Sum(s => s.NetTutar).Value.ToString("#,###.## TL");
        }

        private void UscKalemEkleSilGuncelle_ClickClear(object sender, EventArgs e)
        {
            ClearItems();
            txtStokKod.Focus();
        }

        private void UscKalemEkleSilGuncelle_ClickSave(object sender, EventArgs e)
        {
            var newStok = ReadStokHareketFromForm();

            if (_secilenKalemIndex > -1) FaturaKalemEntities.Update(_secilenKalemIndex, newStok);
            else FaturaKalemEntities.Add(newStok);

            dgvFaturaKalemler.DataSource = HareketleriListeyeYaz(FaturaKalemEntities);
            UpdateAltBilgiler();
            ClearItems();
        }

        private void UscKalemEkleSilGuncelle_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                FaturaKalemEntities.RemoveAt(_secilenKalemIndex);
                _secilenKalemIndex = -1;
                uscKalemEkleSilGuncelle.BtnDelete_Enable = false;
                dgvFaturaKalemler.DataSource = HareketleriListeyeYaz(FaturaKalemEntities);
                uscKalemEkleSilGuncelle.LblStatus_Text = Messages.FaturaMessages.KalemSilindi;
                UpdateAltBilgiler();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void DgvFaturaKalemler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _secilenKalemIndex = e.RowIndex;
                uscKalemEkleSilGuncelle.BtnDelete_Enable = true;
            }
        }

        private void UscFaturaEkleSilGuncelle_ClickClear(object sender, EventArgs e)
        {
            ClearScreen();
            txtFaturaNo.Focus();
        }

        private void UscFaturaEkleSilGuncelle_ClickSave(object sender, EventArgs e)
        {
            try
            {
                Fatura fatura = ReadFaturaFromForm();
                IResult result = _faturaService.GetByNo(fatura.No).Data == null ? _faturaService.Add(fatura) : _faturaService.Update(fatura);
                ClearScreen();
                uscFaturaEkleSilGuncelle.LblStatus_Text = result.Message;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void UscFaturaEkleSilGuncelle_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                if (StaticPrimitives.SecilenFaturaId > 0)
                {
                    var result = _faturaService.Delete(new Fatura { Id = StaticPrimitives.SecilenFaturaId });
                    StaticPrimitives.SecilenFaturaId = -1;
                    uscFaturaEkleSilGuncelle.LblStatus_Text = result.Message;
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }
    }
}