using Autofac;
using Business.Abstract;
using Core.Extensions;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;
using WindowsFormUI.Properties;
using WindowsFormUI.Views.Moduls.Cariler;

namespace WindowsFormUI.Views.Moduls.Kasalar
{
    public partial class FrmKasaKayit : FrmBase
    {
        private struct KasaView
        {
            public int Id { get; set; }
            public int KasaId { get; set; }
            public string KasaAd { get; set; }
            public int CariId { get; set; }
            public string CariAd { get; set; }
            public string EvrakNo { get; set; }
            public decimal GirenCikanMiktar { get; set; }
            public DateTime Tarih { get; set; }
            public string Aciklama { get; set; }
        }

        private IKasaService _kasaService;
        private IKasaHareketService _kasaHareketService;
        private ICariService _cariService;
        private Kasa _secilenKasa;
        private Cari _secilenCari;
        private KasaHareket _secilenKasaHareket, _yeniKasaHareket;
        private int _secilenKasaId = 0, _secilenCariId = 0, _secilenKasaHareketId = 0;
        private List<KasaView> _kasaHareketler;

        public KasaIslemTuru KasaIslemTuru { get; set; }

        public FrmKasaKayit(IKasaService kasaService, IKasaHareketService kasaHareketService, ICariService cariService)
        {
            InitializeComponent();
            _kasaService = kasaService;
            _cariService = cariService;
            KasaIslemTuru = KasaIslemTuru.Hepsi;
            _kasaHareketService = kasaHareketService;
        }

        private void FrmKasaKayit_Load(object sender, EventArgs e)
        {
            if (KasaIslemTuru == KasaIslemTuru.Tahsilat)
            {
                this.Icon = Resources.Kasa_Tahsilat32x321;
                this.Text += "  --  Tahsilat Yap";
            }
            else if (KasaIslemTuru == KasaIslemTuru.Tediye)
            {
                this.Icon = Resources.Kasa_Odeme32x321;
                this.Text += "  --  Tediye (Ödeme) Yap";
            }
            ClearScreen();
        }

        private void ClearScreen()
        {
            btnKasaBul.TabStop = false;
            btnEvrakBul.TabStop = false;
            btnCariBul.TabStop = false;
            uscKasaButtons.TabStop = false;
            txtKasaAd.Enabled = true;
            btnKasaBul.Enabled = true;
            txtKasaAd.Text = "00-Merkez Kasa";

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

            dtpKasaTarih.Enabled = false;

            uscKasaButtons.BtnClear_Visible = false;
            uscKasaButtons.BtnDelete_Enable = false;
            uscKasaButtons.BtnSave_Enable = false;
            uscKasaButtons.BtnSave_Text = "Kaydet";
            _secilenKasa = null;
            _secilenCari = null;
            _secilenKasaHareket = null;
            _yeniKasaHareket = new KasaHareket();
            _kasaHareketler = _kasaHareketService.GetList().Data.Select(s => new KasaView
            {
                Id = s.Id,
                KasaId = s.KasaId,
                KasaAd = _kasaService.GetById(s.KasaId).Data.Ad,
                CariId = s.CariId,
                CariAd = _cariService.GetById(s.CariId).Data.Unvan,
                EvrakNo = s.EvrakNo,
                GirenCikanMiktar = s.GirenCikanMiktar,
                Tarih = s.Tarih,
                Aciklama = s.Aciklama
            }).ToList();
            dgvKasaHareketler.DataSource = _kasaHareketler;
        }

        private void BtnKasaBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmKasaKart>();
            form.SecimIcin = true;
            form.Show();
            try
            {
                if (StaticPrimitives.SecilenKasaId > 0)
                {
                    _secilenKasaId = StaticPrimitives.SecilenKasaId;
                    StaticPrimitives.SecilenKasaId = 0;
                    _secilenKasa = _kasaService.GetById(_secilenKasaId).Data;
                    txtKasaAd.Text = _secilenKasa.Ad;
                }
                else txtKasaAd.Text = "";
                txtKasaAd.Focus();
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
            form.Show();
            try
            {
                if (StaticPrimitives.SecilenCariId > 0)
                {
                    _secilenCariId = StaticPrimitives.SecilenCariId;
                    StaticPrimitives.SecilenCariId = 0;
                    txtCariKod.Text = _cariService.GetById(_secilenCariId).Data.Kod;
                }
                else txtCariKod.Text = "";
                txtCariKod.Focus();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnEvrakBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmKasaListe>();
            form.SecimIcin = true;
            form.Show();
            try
            {
                if (StaticPrimitives.SecilenKasaHareketId > 0)
                {
                    _secilenKasaHareketId = StaticPrimitives.SecilenKasaHareketId;
                    StaticPrimitives.SecilenKasaHareketId = 0;
                    txtEvrakNo.Text = _kasaHareketService.GetById(_secilenKasaHareketId).Data.EvrakNo;
                }
                else txtEvrakNo.Text = "";
                txtEvrakNo.Focus();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UscKasaButtons_ClickClear(object sender, EventArgs e)
        {
            ClearScreen();
            txtKasaAd.Focus();
        }

        private void UscKasaButtons_ClickSave(object sender, EventArgs e)
        {
            try
            {
                if (_secilenKasaHareket == null)
                {
                    IResult result;
                    if (KasaIslemTuru == KasaIslemTuru.Tahsilat)
                    {
                        result = _kasaHareketService.Add(_yeniKasaHareket);
                    }
                    else
                    {
                        _yeniKasaHareket.GirenCikanMiktar *= -1;
                        result = _kasaHareketService.Add(_yeniKasaHareket);
                    }
                    ClearScreen();
                    uscKasaButtons.LblStatus_Text = result.Message;
                }
                else
                {
                    IResult result;
                    if (KasaIslemTuru == KasaIslemTuru.Tahsilat)
                    {
                        result = _kasaHareketService.Update(_secilenKasaHareket);
                    }
                    else
                    {
                        _secilenKasaHareket.GirenCikanMiktar *= -1;
                        result = _kasaHareketService.Update(_secilenKasaHareket);
                    }
                    uscKasaButtons.LblStatus_Text = result.Message;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UscKasaButtons_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                if (_secilenKasaHareket != null)
                {
                    var result = _kasaHareketService.Delete(_secilenKasaHareket);
                    ClearScreen();
                    uscKasaButtons.LblStatus_Text = result.Message;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void TxtKasaAd_Leaved(object sender, EventArgs e)
        {
            if (_secilenKasa == null)
            {
                var resultKasa = _kasaService.GetByAd(txtKasaAd.Text);
                if (resultKasa.Data != null)
                    _secilenKasa = resultKasa.Data;
                else
                    throw new Exception(resultKasa.Message);
            }
            txtEvrakNo.Enabled = true;
            btnEvrakBul.Enabled = true;
            uscKasaButtons.BtnClear_Visible = true;
            _yeniKasaHareket.KasaId = _secilenKasa.Id;
            //
            List<string> evrakNoList;
            var resultHareket = _kasaHareketService.GetListByKasaId(_secilenKasa.Id);
            if (resultHareket.Data != null)
            {
                if (KasaIslemTuru == KasaIslemTuru.Tahsilat)
                {
                    var evrak = resultHareket.Data.Where(a => a.EvrakNo.StartsWith("T")).ToList();
                    evrakNoList = evrak.Capacity != 0 ? evrak.Select(s => s.EvrakNo[1..]).ToList() : null;
                }
                else
                {
                    var evrak = resultHareket.Data.Where(a => a.EvrakNo.StartsWith("O")).ToList();
                    evrakNoList = evrak.Capacity != 0 ? evrak.Select(s => s.EvrakNo[1..]).ToList() : null;
                }
                int yenifis = evrakNoList != null ? evrakNoList.Select(s => s.TrimStart('0').ToInt()).ToList().Max() + 1 : 1;
                txtEvrakNo.Text = yenifis.ToString();
            }
            else
                txtEvrakNo.Text = "1";
            //
            txtEvrakNo.Focus();
        }

        public bool IsFormattedEvrakNo(string value)
        {
            if (KasaIslemTuru == KasaIslemTuru.Tahsilat)
                return value.Length == 14 && value.StartsWith("T");
            if (KasaIslemTuru == KasaIslemTuru.Tediye)
                return value.Length == 14 && value.StartsWith("O");
            return false;
        }

        public string FormatEvrakNo(string value)
        {
            if (IsFormattedEvrakNo(value))
                return value;
            else
            {
                string txt = value;
                value = KasaIslemTuru == KasaIslemTuru.Tahsilat ? "T" : "O";
                for (int i = 0; i < 13 - txt.Length; i++)
                    value += "0";
                value += txt;
                return value;
            }
        }

        private void TxtEvrakNo_Leaved(object sender, EventArgs e)
        {
            string evrakNo = FormatEvrakNo(txtEvrakNo.Text);
            if (_secilenKasaHareket == null)
            {
                var result = _kasaHareketService.GetByEvrakNo(evrakNo);
                if (result.Data != null)
                {
                    _secilenKasaHareket = result.Data;
                    WriteToScreen(_secilenKasaHareket);
                }
            }
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            _yeniKasaHareket.EvrakNo = evrakNo;
            txtEvrakNo.Text = evrakNo;
            txtCariKod.Focus();
        }

        private void TxtCariKod_Leaved(object sender, EventArgs e)
        {
            if (_secilenCari == null)
            {
                var result = _cariService.GetByKod(txtCariKod.Text);
                if (result.Data != null)
                    _secilenCari = result.Data;
                else
                    return;
            }
            txtMiktar.Enabled = true;
            _yeniKasaHareket.CariId = _secilenCari.Id;
            lblCariAd.Text = _secilenCari.Unvan;
            txtMiktar.Focus();
        }

        private void TxtMiktar_Leaved(object sender, EventArgs e)
        {
            txtMiktar.Leave -= TxtMiktar_Leaved;
            try
            {
                txtAciklama.Enabled = true;
                _yeniKasaHareket.GirenCikanMiktar = txtMiktar.Text.ToDecimal();
            }
            catch (Exception err)
            {
                MessageBox.Show("Miktar alanı boş geçilemez \n " + err.Message, "Veri Hatası");
            }
            txtMiktar.Text = _yeniKasaHareket.GirenCikanMiktar.ToString("#,###.## TL");
            txtAciklama.Focus();
            txtMiktar.Leave += TxtMiktar_Leaved;
        }

        private void TxtAciklama_Leaved(object sender, EventArgs e)
        {
            dtpKasaTarih.Enabled = true;
            _yeniKasaHareket.Aciklama = txtAciklama.Text;
            dtpKasaTarih.Focus();
        }

        private void DtpTarih_Leaved(object sender, EventArgs e)
        {
            uscKasaButtons.BtnSave_Enable = true;
            _yeniKasaHareket.Tarih = dtpKasaTarih.Value;
            uscKasaButtons.Focus();
        }

        private void HarfEngelle(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Contains(','))
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void DgvKasaHareketler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = e.RowIndex;
            if (secilenSatir > -1)
            {
                _secilenKasaHareketId = (int)dgvKasaHareketler.Rows[secilenSatir].Cells["colId"].Value;
                _secilenKasaHareket = _kasaHareketService.GetById(_secilenKasaHareketId).Data;
                WriteToScreen(_secilenKasaHareket);
            }
        }

        private void WriteToScreen(KasaHareket secilenKasaHareket)
        {
            txtKasaAd.Enabled = true;
            btnKasaBul.Enabled = true;
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            txtEvrakNo.Enabled = true;
            btnEvrakBul.Enabled = true;
            txtMiktar.Enabled = true;
            txtAciklama.Enabled = true;
            dtpKasaTarih.Enabled = true;
            uscKasaButtons.BtnClear_Visible = true;
            uscKasaButtons.BtnDelete_Enable = true;
            uscKasaButtons.BtnSave_Enable = true;

            _secilenKasa = _kasaService.GetById(secilenKasaHareket.KasaId).Data;
            txtKasaAd.Text = _secilenKasa.Ad;
            txtEvrakNo.Text = secilenKasaHareket.EvrakNo;
            _secilenCari = _cariService.GetById(secilenKasaHareket.CariId).Data;
            txtCariKod.Text = _secilenCari.Kod;
            lblCariAd.Text = _secilenCari.Unvan;
            txtMiktar.Text = secilenKasaHareket.GirenCikanMiktar.ToString("#,###.## TL");
            dtpKasaTarih.Value = secilenKasaHareket.Tarih;
            txtAciklama.Text = secilenKasaHareket.Aciklama;
            uscKasaButtons.BtnSave_Text = "Güncelle";
            _yeniKasaHareket = new KasaHareket();
        }
    }
}