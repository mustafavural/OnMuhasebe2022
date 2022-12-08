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

namespace WindowsFormUI.Views.Moduls.Kasalar
{
    public partial class FrmKasaKayit : FrmBase
    {
        private readonly IKasaService _kasaService;
        private readonly IKasaHareketService _kasaHareketService;
        private readonly ICariService _cariService;
        private Kasa _secilenKasa;
        private Cari _secilenCari;
        private KasaHareket _secilenKasaHareket;
        private decimal _girenCikanMiktar = 0;

        public KasaIslemTuru KasaIslemTuru { get; set; }

        public FrmKasaKayit(IKasaService kasaService, IKasaHareketService kasaHareketService, ICariService cariService)
        {
            InitializeComponent();
            _kasaService = kasaService;
            _kasaHareketService = kasaHareketService;
            _cariService = cariService;
            KasaIslemTuru = KasaIslemTuru.Hepsi;
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

            dgvKasaHareketler.DataSource = ListeyeYaz(_kasaHareketService.GetList(s => s.EvrakNo.StartsWith(KasaIslemTuru.ToCharString())).Data);
            txtKasaAd.Focus();
        }

        private object ListeyeYaz(List<KasaHareket> kasaHareketler)
        {
            return kasaHareketler.Select(s => new
            {
                s.Id,
                s.KasaId,
                KasaAd = _kasaService.GetById(s.KasaId).Data.Ad,
                s.CariId,
                _cariService.GetById(s.CariId).Data.Unvan,
                s.EvrakNo,
                s.GirenCikanMiktar,
                s.Tarih,
                s.Aciklama
            }).ToList();
        }

        private void BtnKasaBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmKasaKart>();
            form.SecimIcin = true;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenKasaId > 0)
                {
                    _secilenKasa = _kasaService.GetById(StaticPrimitives.SecilenKasaId).Data;
                    StaticPrimitives.SecilenKasaId = 0;
                    txtKasaAd.Text = _secilenKasa.Ad;
                }
                else txtKasaAd.Text = "";
                txtKasaAd.Focus();
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
            var form = Program.Container.Resolve<FrmKasaListe>();
            form.KasaIslemTuru = KasaIslemTuru;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenKasaHareketId > 0)
                {
                    _secilenKasaHareket = _kasaHareketService.GetById(StaticPrimitives.SecilenKasaHareketId).Data;
                    StaticPrimitives.SecilenKasaHareketId = 0;
                    txtEvrakNo.Text = _secilenKasaHareket.EvrakNo;
                }
                else txtEvrakNo.Text = "";
                txtEvrakNo.Focus();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void UscKasaButtons_ClickClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void UscKasaButtons_ClickSave(object sender, EventArgs e)
        {
            try
            {
                IResult result = _secilenKasaHareket == null 
                    ? _kasaHareketService.Add(ReadKasaHareketFromForm()) 
                    : _kasaHareketService.Update(_secilenKasaHareket);
                uscKasaButtons.LblStatus_Text = result.Message;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private KasaHareket ReadKasaHareketFromForm()
        {
            return new KasaHareket
            {
                KasaId = _secilenKasa.Id,
                CariId = _secilenCari.Id,
                EvrakNo = txtEvrakNo.Text,
                Aciklama = txtAciklama.Text,
                GirenCikanMiktar = _girenCikanMiktar,
                Tarih = dtpKasaTarih.Value
            };
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

        private void TxtKasaAd_Leaved()
        {
            try
            {
                _secilenKasa ??= _kasaService.GetByAd(txtKasaAd.Text).Data;
                if (_secilenKasa == null)
                {
                    MessageHelper.SuccessMessageBuilder(Messages.KasaMessages.KasaBulunamadi, this.Text);
                    txtKasaAd.Focus();
                    return;
                }

                txtEvrakNo.Enabled = true;
                btnEvrakBul.Enabled = true;
                uscKasaButtons.BtnClear_Visible = true;
                //
                KasaHareket yenifis = _kasaHareketService.GetList((s => s.KasaId == _secilenKasa.Id && s.EvrakNo.StartsWith(KasaIslemTuru.ToCharString()))).Data?.MaxBy(s => s.Id);
                int fisNo = yenifis == null ? 1 : yenifis.EvrakNo[1..].Trim('0').ToInt() + 1;
                txtEvrakNo.Text = fisNo.ToString();
                //
                txtKasaAd.Enabled = false;
                btnKasaBul.Enabled = false;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
            txtEvrakNo.Focus();
        }

        public bool IsFormattedEvrakNo(string value)
        {
            return value.Length == 14 && value.StartsWith(KasaIslemTuru.ToCharString());
        }

        public string FormatEvrakNo(string value)
        {
            string txt = "";
            if (!IsFormattedEvrakNo(value))
            {
                txt = value;
                value = KasaIslemTuru.ToCharString();
                do
                    value += "0";
                while (!IsFormattedEvrakNo(value + txt));
            }
            return value += txt;
        }

        private void TxtEvrakNo_Leaved()
        {
            string evrakNo = "";
            if (txtEvrakNo.Text.Length > 12)
            {
                MessageHelper.SuccessMessageBuilder(Messages.KasaMessages.EvrakNoHatali, this.Text);
                txtEvrakNo.Text = "";
            }
            else
                evrakNo = FormatEvrakNo(txtEvrakNo.Text);
            if (_secilenKasaHareket == null)
            {
                var result = _kasaHareketService.GetByEvrakNo(evrakNo);
                if (result.Data != null)
                {
                    _secilenKasaHareket = result.Data;
                    BringExistingKasaHareket(_secilenKasaHareket);
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
                        throw new Exception(Messages.CariMessages.KodYok);
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
                MessageHelper.SuccessMessageBuilder(Messages.KasaMessages.MiktarBosGecilemez, this.Text);
                txtMiktar.Focus();
            }
        }

        private void TxtAciklama_Leaved()
        {
            if (txtAciklama.Text != "")
            {
                dtpKasaTarih.Enabled = true;
                txtAciklama.Enabled = false;
            }
            else
            {
                MessageHelper.SuccessMessageBuilder(Messages.KasaMessages.AciklamaBosGecilemez, this.Text);
                txtAciklama.Focus();
            }
        }

        private void DtpKasaTarih_Leaved()
        {
            if (dtpKasaTarih.Value.Date < DateTime.Today.Date)
            {
                uscKasaButtons.TabStop = true;
                uscKasaButtons.BtnSave_Enable = true;
                dtpKasaTarih.Enabled = false;
            }
            else
            {
                MessageHelper.SuccessMessageBuilder(Messages.KasaMessages.TarihHatali, this.Text);
                dtpKasaTarih.Focus();
            }
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
            if (e.RowIndex > -1)
            {
                var id = (int)dgvKasaHareketler.Rows[e.RowIndex].Cells["colId"].Value;
                _secilenKasaHareket = _kasaHareketService.GetById(id).Data;
                BringExistingKasaHareket(_secilenKasaHareket);
            }
        }

        private void BringExistingKasaHareket(KasaHareket secilenKasaHareket)
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

            _secilenKasa = secilenKasaHareket.Kasa;
            txtKasaAd.Text = _secilenKasa.Ad;
            txtEvrakNo.Text = secilenKasaHareket.EvrakNo;
            _secilenCari = secilenKasaHareket.CariHareket.Cari;
            txtCariKod.Text = _secilenCari.Kod;
            lblCariAd.Text = _secilenCari.Unvan;
            txtMiktar.Text = secilenKasaHareket.GirenCikanMiktar.ToString("#,###.## TL");
            dtpKasaTarih.Value = secilenKasaHareket.Tarih;
            txtAciklama.Text = secilenKasaHareket.Aciklama;
            uscKasaButtons.BtnSave_Text = "Güncelle";
        }
    }
}