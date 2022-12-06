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
        private readonly IStokHareketService _stokHareketService;

        private List<StokHareket> faturaKalemEntities;
        private int _secilenKalemIndex = -1;
        private Cari _secilenCari;
        private Stok _secilenStok;
        private Fatura _secilenFatura;
        decimal stokMiktar, stokFiyat, stokBrutFiyat, stokKdv, stokNetFiyat;

        public FaturaTurleri FaturaTur { get; set; }

        public FrmFaturaKayit(IFaturaService faturaService,
                              ICariService cariService,
                              IStokService stokService,
                              IStokHareketService stokHareketService)
        {
            InitializeComponent();
            _faturaService = faturaService;
            _cariService = cariService;
            _stokService = stokService;
            _stokHareketService = stokHareketService;
            FaturaTur = FaturaTurleri.Hepsi;
            faturaKalemEntities = new List<StokHareket>();
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
                var result = _faturaService.GetByNo(txtFaturaNo.Text).Data;
                if (result != null)
                {
                    _secilenFatura = result;
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
                }
            }
        }

        private void TxtFaturaAciklama_Leave()
        {
            grpFaturaKalem.Enabled = true;
            txtStokKod.Focus();
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
                uscKalemEkleSilGuncelle.Focus();
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
                MessageBox.Show(err.Message);
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
                MessageBox.Show(err.Message);
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
                MessageBox.Show(err.Message);
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
            txtFaturaAraToplam.Text = "";
            txtFaturaKDVlerToplam.Text = "";
            txtFaturaGenelToplam.Text = "";
            uscFaturaEkleSilGuncelle.BtnClear_Visible = false;
            uscFaturaEkleSilGuncelle.BtnDelete_Enable = false;
            uscFaturaEkleSilGuncelle.BtnSave_Enable = false;
            grpFaturaKalem.Enabled = false;
        }

        private void BringExistingFatura(Fatura fatura)
        {
            ClearItems();
            StaticPrimitives.SecilenFaturaId = fatura.Id;
            var cari = _cariService.GetById(fatura.CariId).Data;
            txtFaturaNo.Text = fatura.No;
            txtFaturaNo.Enabled = false;
            btnFaturaBul.Enabled = false;
            txtCariKod.Text = cari.Kod;
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            txtFaturaAciklama.Text = fatura.Aciklama;
            dtpTarih.Enabled = true;
            dtpTarih.Value = fatura.Tarih;
            lblCariAd.Text = cari.Unvan;

            dgvFaturaKalemler.DataSource = HareketleriListeyeYaz(fatura.StokHareketler);//.Select(s => new
            //{
            //    s.Id,
            //    StokKodu = s.Stok.Kod,
            //    StokAd = s.Stok.Ad,
            //    FaturaNo = fatura.No,
            //    Miktar = s.Miktar < 0 ? s.Miktar * -1 : s.Miktar,
            //    s.Birim,
            //    s.Fiyat,
            //    BrutTutar = s.BrutTutar ?? 0,
            //    s.Kdv,
            //    NetTutar = s.NetTutar ?? 0,
            //    s.Tarih,
            //    s.Aciklama,
            //    StokMiktar = _stokHareketService.GetStokBakiye(s.Stok.Kod)
            //}).ToList();

            txtFaturaAraToplam.Text = fatura.StokHareketler.Sum(f => f.BrutTutar).Value.ToString("#,###.## TL");
            txtFaturaKDVlerToplam.Text = fatura.StokHareketler.Sum(f => f.NetTutar - f.BrutTutar).Value.ToString("#,###.## TL");
            txtFaturaGenelToplam.Text = fatura.StokHareketler.Sum(f => f.NetTutar).Value.ToString("#,###.## TL");
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
                Id = 0,
                StokId = _stokService.GetByKod(txtStokKod.Text).Data.Id,
                FaturaId = _faturaService.GetByNo(txtFaturaNo.Text).Data?.Id ?? 0,
                Miktar = stokMiktar,
                Birim = txtStokBirim.Text,
                Fiyat = stokFiyat,
                BrutTutar = stokBrutFiyat,
                Kdv = stokKdv.ToString().ToInt(),
                NetTutar = stokNetFiyat,
                Tarih = dtpTarih.Value,
                Aciklama = txtFaturaNo.Text
            };
        }

        private object HareketleriListeyeYaz(List<StokHareket> stokHareketler)
        {
            return stokHareketler.Select(h => new
            {
                h.Id,
                StokKod = _stokService.GetById(h.StokId).Data.Kod,
                StokAd = _stokService.GetById(h.StokId).Data.Ad,
                h.Miktar,
                h.Birim,
                h.Fiyat,
                h.BrutTutar,
                h.Kdv,
                h.NetTutar
            }).ToList();
        }

        private void OpenNewFatura()
        {
            StaticPrimitives.SecilenFaturaId = -1;
            _secilenFatura = null;
            string fNo = txtFaturaNo.Text;
            ClearScreen();
            txtFaturaNo.Text = fNo;
            uscFaturaEkleSilGuncelle.BtnClear_Visible = true;
            txtFaturaNo.Enabled = false;
            uscFaturaEkleSilGuncelle.BtnSave_Enable = true;
            uscFaturaEkleSilGuncelle.BtnSave_Text = "Fatura Kes";
            txtCariKod.Text = "";
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            dtpTarih.Enabled = true;
            dtpTarih.Value = DateTime.Now;
            lblCariAd.Text = "";
        }

        private void UpdateAltBilgiler()
        {
            txtFaturaAraToplam.Text = faturaKalemEntities.Sum(s => s.BrutTutar).Value.ToString("#,###.## TL");
            txtFaturaKDVlerToplam.Text = faturaKalemEntities.Sum(s => s.NetTutar - s.BrutTutar).Value.ToString("#,###.## TL");
            txtFaturaGenelToplam.Text = faturaKalemEntities.Sum(s => s.NetTutar).Value.ToString("#,###.## TL");
        }

        private void UscKalemEkleSilGuncelle_ClickClear(object sender, EventArgs e)
        {
            ClearItems();
            txtStokKod.Focus();
        }

        private void UscKalemEkleSilGuncelle_ClickSave(object sender, EventArgs e)
        {
            var newStok = ReadStokHareketFromForm();

            if (_secilenKalemIndex > -1) faturaKalemEntities.Update(_secilenKalemIndex, newStok);
            else faturaKalemEntities.Add(newStok);

            dgvFaturaKalemler.DataSource = HareketleriListeyeYaz(faturaKalemEntities);
            UpdateAltBilgiler();
            ClearItems();
        }

        private void UscKalemEkleSilGuncelle_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                faturaKalemEntities.RemoveAt(_secilenKalemIndex);
                _secilenKalemIndex = -1;
                uscKalemEkleSilGuncelle.BtnDelete_Enable = false;
                dgvFaturaKalemler.DataSource = HareketleriListeyeYaz(faturaKalemEntities);
                uscKalemEkleSilGuncelle.LblStatus_Text = Messages.FaturaMessages.KalemSilindi;
                UpdateAltBilgiler();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
                var fatura = new Fatura
                {
                    No = txtFaturaNo.Text,
                    CariId = _secilenCari.Id,
                    KayitTarihi = DateTime.Now.Date,
                    Tarih = dtpTarih.Value,
                    Tur = lblFaturaTurEkran.Text,
                    Aciklama = txtFaturaAciklama.Text,
                    StokHareketler = faturaKalemEntities.Select(s => new StokHareket
                    {
                        Id = s.Id,
                        Miktar = s.Miktar,
                        Birim = s.Birim,
                        Fiyat = s.Fiyat,
                        Kdv = s.Kdv,
                        Tarih = s.Tarih,
                        Aciklama = s.Aciklama
                    }).ToList()
                };
                IResult result = _faturaService.GetByNo(fatura.No).Data == null ? _faturaService.Add(fatura) : _faturaService.Update(fatura);
                ClearScreen();
                uscFaturaEkleSilGuncelle.LblStatus_Text = result.Message;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
                MessageBox.Show(err.Message);
            }
        }
    }
}