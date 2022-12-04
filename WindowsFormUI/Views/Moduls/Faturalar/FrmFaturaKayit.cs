using Autofac;
using Business.Abstract;
using Business.Constants;
using Core.Extensions;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        private List<FaturaKalemDto> faturaKalemEntities;
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
            faturaKalemEntities = new List<FaturaKalemDto>();
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
            stokMiktar = 0; stokFiyat = 0; stokBrutFiyat = 0; stokKdv = 0; stokNetFiyat = 0;
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

            dgvFaturaKalemler.DataSource = new List<FaturaKalemDto>();
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
            txtFaturaNo.Text = fatura.No;
            txtFaturaNo.Enabled = false;
            btnFaturaBul.Enabled = false;
            txtCariKod.Text = _cariService.GetById(fatura.CariId).Data.Kod;
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            txtFaturaAciklama.Text = fatura.Aciklama;
            dtpTarih.Enabled = true;
            dtpTarih.Value = fatura.Tarih;
            lblCariAd.Text = _cariService.GetById(fatura.CariId).Data.Unvan;

            faturaKalemEntities = _faturaService.GetFaturaKalemler(fatura.No).Data.Select(s => new FaturaKalemDto
            {
                Id = s.Id,
                FaturaNo = s.Fatura.No,
                StokKodu = s.Stok.Kod,
                StokAd = _stokService.GetByKod(s.Stok.Kod).Data.Ad,
                Miktar = s.Miktar < 0 ? s.Miktar * -1 : s.Miktar,
                Birim = s.Birim,
                Fiyat = s.Fiyat,
                Kdv = s.Kdv,
                BrutTutar = s.BrutTutar ?? 0,
                NetTutar = s.NetTutar ?? 0,
                Tarih = s.Tarih,
                Aciklama = s.Aciklama
            }).ToList();
            dgvFaturaKalemler.DataSource = faturaKalemEntities;

            txtFaturaAraToplam.Text = _faturaService.GetBrutToplam(fatura.No).Data.Value.ToString("#,###.## TL");
            txtFaturaKDVlerToplam.Text = _faturaService.GetFaturaKalemler(fatura.No).Data.Sum(f => f.NetTutar - f.BrutTutar).Value.ToString("#,###.## TL");
            txtFaturaGenelToplam.Text = _faturaService.GetNetToplam(fatura.No).Data.Value.ToString("#,###.## TL");
            uscFaturaEkleSilGuncelle.BtnClear_Visible = true;
            uscFaturaEkleSilGuncelle.BtnDelete_Enable = true;
            uscFaturaEkleSilGuncelle.BtnSave_Enable = true;
            uscFaturaEkleSilGuncelle.BtnSave_Text = "Güncelle";
            grpFaturaKalem.Enabled = true;
        }

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

        public bool IsFormattedFaturaNo(string value)
        {
            if (value.Length == 14 && value.StartsWith("F"))
                return true;
            else
                return false;
        }

        public string FormatFaturaNo(string value)
        {
            if (this.IsFormattedFaturaNo(value))
                return value;
            else
            {
                string txt = value;
                value = "F";
                for (int i = 0; i < 13 - txt.Length; i++)
                    value += "0";
                value += txt;
                return value;
            }
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

        private void TxtFaturaNo_Leave(object sender, EventArgs e)
        {
            if (txtFaturaNo.Text.Length != 0)
            {
                txtFaturaNo.Leave -= TxtFaturaNo_Leave;

                txtFaturaNo.Text = FormatFaturaNo(txtFaturaNo.Text);
                var result = _faturaService.GetByNo(txtFaturaNo.Text).Data;
                if (result != null)
                {
                    _secilenFatura = result;
                    BringExistingFatura(_secilenFatura);
                }
                else
                    OpenNewFatura();

                txtFaturaNo.Leave += TxtFaturaNo_Leave;
            }
        }

        private void TxtCariKod_Leave(object sender, EventArgs e)
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

        private void TxtFaturaAciklama_Leave(object sender, EventArgs e)
        {
            grpFaturaKalem.Enabled = true;
            txtStokKod.Focus();
        }

        private void TxtStokKod_Leave(object sender, EventArgs e)
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

        private void TxtStokFiyat_Leave(object sender, EventArgs e)
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

        private void UscKalemEkleSilGuncelle_ClickClear(object sender, EventArgs e)
        {
            ClearItems();
            txtStokKod.Focus();
        }

        private void UpdateAltBilgiler()
        {
            txtFaturaAraToplam.Text = faturaKalemEntities.Sum(s => s.BrutTutar).ToString("#,###.## TL");
            txtFaturaKDVlerToplam.Text = faturaKalemEntities.Sum(s => s.NetTutar - s.BrutTutar).ToString("#,###.## TL");
            txtFaturaGenelToplam.Text = faturaKalemEntities.Sum(s => s.NetTutar).ToString("#,###.## TL");
        }

        private void UscKalemEkleSilGuncelle_ClickSave(object sender, EventArgs e)
        {
            var newEntity = new FaturaKalemDto
            {
                StokKodu = txtStokKod.Text,
                FaturaNo = txtFaturaNo.Text,
                StokAd = lblStokAd.Text,
                Miktar = stokMiktar,
                Birim = txtStokBirim.Text,
                Fiyat = stokFiyat,
                BrutTutar = stokBrutFiyat,
                Kdv = stokKdv.ToString().ToInt(),
                NetTutar = stokNetFiyat,
                Tarih = dtpTarih.Value,
                Aciklama = txtFaturaNo.Text
            };

            if (_secilenKalemIndex > -1)
            {
                faturaKalemEntities.Update(_secilenKalemIndex, newEntity);
            }
            else
            {
                faturaKalemEntities.Add(newEntity);
            }
            dgvFaturaKalemler.DataSource = new List<FaturaKalemDto>();
            dgvFaturaKalemler.DataSource = faturaKalemEntities;
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
                dgvFaturaKalemler.DataSource = new List<FaturaKalemDto>();
                dgvFaturaKalemler.DataSource = faturaKalemEntities;
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

        private void UscFaturaEkleSilGuncelle_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                var result = _faturaService.Delete(new Fatura { Id = StaticPrimitives.SecilenFaturaId });
                StaticPrimitives.SecilenFaturaId = -1;
                uscFaturaEkleSilGuncelle.LblStatus_Text = result.Message;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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
                    Aciklama = txtFaturaAciklama.Text
                };
                var stokHareketler = (from stokhareket in faturaKalemEntities
                                      select new StokHareket
                                      {
                                          Id = stokhareket.Id,
                                          Miktar = stokhareket.Miktar,
                                          Birim = stokhareket.Birim,
                                          Fiyat = stokhareket.Fiyat,
                                          Tarih = stokhareket.Tarih,
                                          Aciklama = stokhareket.Aciklama
                                      }).ToList();
                IResult result;
                if (_faturaService.GetByNo(fatura.No).Data != null)
                {
                    fatura.StokHareketler = stokHareketler;
                    result = _faturaService.Update(fatura);
                }
                else
                {
                    fatura.StokHareketler = stokHareketler;
                    result = _faturaService.Add(fatura);
                }
                ClearScreen();
                uscFaturaEkleSilGuncelle.LblStatus_Text = result.Message;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}