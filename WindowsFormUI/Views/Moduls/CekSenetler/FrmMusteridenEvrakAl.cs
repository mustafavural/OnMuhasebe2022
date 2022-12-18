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
    public partial class FrmEvrakAl : FrmBase
    {
        private readonly ICekSenetBordroService _cekSenetBordroService;
        private readonly ICariService _cariService;
        private readonly ICekSenetMusteriService _cekSenetMusteriService;
        private readonly List<CekSenetMusteri> _musteriCekSenetler;
        private CekSenetBordro _secilenTahsilatBordro;
        private Cari _secilenCari;
        private int _secilenEvrakIndex = -1;
        private decimal _evrakTutar;
        private bool isUpdate = false, isOldBordro = false;
        private int oldEvrakId = 0, evrakNo, bordroNo;

        public FrmEvrakAl(ICekSenetBordroService cekSenetBordroService,
                          ICariService cariService,
                          ICekSenetMusteriService cekSenetMusteriService)
        {
            InitializeComponent();
            _cekSenetBordroService = cekSenetBordroService;
            _cariService = cariService;
            _cekSenetMusteriService = cekSenetMusteriService;
            _musteriCekSenetler = new List<CekSenetMusteri>();
            ClearDeger_NoSayaclar();
            ClearForm_BordroBilgiler();
            ClearForm_EvrakBilgiler();
            ClearForm_EvrakListe();
            ClearForm_UscEvrak();
            ClearForm_UscBordro();
        }

        private void TxtBelgeNoHarfEngelle(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtDecimalHarfEngelle(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Contains(','))
                TxtBelgeNoHarfEngelle(sender, e);
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void BtnBordroNoBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBordroListe>();
            form.BordroTur = BordroTurleri.Tahsilat;
            form.ShowDialog();
            try
            {
                if (StaticPrimitives.SecilenBordroId > 0)
                {
                    _secilenTahsilatBordro = _cekSenetBordroService.GetById(StaticPrimitives.SecilenBordroId).Data;
                    txtBordroNo.Text = _secilenTahsilatBordro.No;
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

        private void UscEvrak_ClickClear(object sender, EventArgs e)
        {
            ClearForm_EvrakBilgiler();
            ClearForm_UscEvrak();
        }

        private void UscEvrak_ClickSave(object sender, EventArgs e)
        {
            var evrak = ReadEvrakFromForm();
            if (!isUpdate)
            {
                _musteriCekSenetler.Add(evrak);
                evrakNo++;
            }
            else
                _musteriCekSenetler.Update(_secilenEvrakIndex, evrak);

            UpdateForm_DgvEvraklar();
            ClearForm_EvrakBilgiler();
            uscBordro.BtnSave_Enable = true;
        }

        private void UscEvrak_ClickCancel(object sender, EventArgs e)
        {
            _musteriCekSenetler.RemoveAt(_secilenEvrakIndex);
            UpdateForm_DgvEvraklar();
            ClearForm_EvrakBilgiler();
            ClearForm_UscEvrak();
        }

        private void UscBordro_ClickClear(object sender, EventArgs e)
        {
            ClearDeger_NoSayaclar();
            ClearForm_BordroBilgiler();
            ClearForm_EvrakBilgiler();
            ClearForm_EvrakListe();
            ClearForm_UscEvrak();
            ClearForm_UscBordro();
        }

        private void UscBordro_ClickSave(object sender, EventArgs e)
        {
            try
            {
                _secilenTahsilatBordro.CekSenetMusteriler = _musteriCekSenetler;
                _secilenTahsilatBordro.CariHareket = new CariHareket
                {
                    Id = _secilenTahsilatBordro.Id,
                    CariId = _secilenTahsilatBordro.Cari.Id,
                    Tarih = _secilenTahsilatBordro.Tarih,
                    Tutar = _secilenTahsilatBordro.CekSenetMusteriler.Sum(c => c.Tutar) * -1,
                    Aciklama = $"{_secilenTahsilatBordro.No} nolu evrak tahsilat bordrosu."
                };
                var result = isOldBordro ? _cekSenetBordroService.Update(_secilenTahsilatBordro)
                                         : _cekSenetBordroService.Add(_secilenTahsilatBordro);

                MessageHelper.SuccessMessageBuilder(result.Message, Messages.CekSenetMessages.MusteriCekSenetEklendi);
                UscBordro_ClickClear(sender, e);
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
            bordroNo++;
            UscBordro_ClickClear(sender, e);
        }

        private void UscBordro_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                var result = _cekSenetBordroService.Delete(_secilenTahsilatBordro);
                if (result.IsSuccess)
                {
                    MessageHelper.SuccessMessageBuilder(result.Message, "Başarılı");
                    UscBordro_ClickClear(sender, e);
                }
                else
                    MessageHelper.ErrorMessageBuilder(result.Message, "Başarısız");
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
                var secilenMusteriEvrak = _musteriCekSenetler[e.RowIndex];
                WriteEvrakToForm(secilenMusteriEvrak);
                uscEvrak.BtnSave_Text = "Güncelle";
                uscEvrak.BtnSave_Enable = true;
                uscEvrak.BtnDelete_Enable = true;
                isUpdate = true;
                _secilenEvrakIndex = e.RowIndex;

                txtEvrakNo.Enabled = false;
                dtpVade.Enabled = true;
                dtpVade.Focus();
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
                    _secilenTahsilatBordro = result.Data;
                    GetOldBordro(_secilenTahsilatBordro);
                    isOldBordro = true;
                    uscBordro.BtnDelete_Enable = true;
                }
                else
                {
                    GetNewBordro();
                    isOldBordro = false;
                    txtCariKod.Enabled = true;
                    btnCariBul.Enabled = true;
                    _secilenTahsilatBordro.No = txtBordroNo.Text;
                }
                txtBordroNo.Enabled = false;
                btnBordroBul.Enabled = false;

                txtCariKod.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder(Messages.CekSenetMessages.BordroNumarasiBulunamadi, "Veri Hatası");
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
                    _secilenTahsilatBordro.Cari = _secilenCari;
                    _secilenTahsilatBordro.CariId = _secilenCari.Id;
                    dtpAlisTarih.Enabled = true;
                    dtpAlisTarih.Focus();
                }
                else
                {
                    MessageHelper.ErrorMessageBuilder(Messages.CariMessages.CariYok, "Veri Hatası");
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);

            }
        }

        private void DtpAlisTarih_Leave()
        {
            if (dtpAlisTarih.Value <= DateTime.Today.Date)
            {
                dtpAlisTarih.Enabled = false;
                _secilenTahsilatBordro.Tarih = dtpAlisTarih.Value;
                txtBordroAciklama.Enabled = true;
                txtBordroAciklama.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("İleri tarihli evrak kabulu yapılamaz.", "Tarih Hatası");
                dtpAlisTarih.Focus();
            }
        }

        private void TxtBordroAciklama_Leave()
        {
            if (txtBordroAciklama.Text.Length > 0)
            {
                txtBordroAciklama.Enabled = false;
                grpEvrakBilgiler.Enabled = true;
                _secilenTahsilatBordro.Aciklama = txtBordroAciklama.Text;


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
                var result = _cekSenetMusteriService.GetByNo(txtEvrakNo.Text);
                if (result.Data == null)
                {
                    var evrakno = txtEvrakNo.Text;
                    ClearForm_EvrakBilgiler();
                    txtEvrakNo.Text = evrakno;
                    txtEvrakNo.Enabled = false;
                    dtpVade.Enabled = true;

                    _secilenEvrakIndex = dgvEvraklar.FindRowIndexWithColumnValue("colNo", txtEvrakNo.Text);
                    isUpdate = _secilenEvrakIndex >= 0;
                    if (isUpdate) GetOldEvrak(_musteriCekSenetler[_secilenEvrakIndex]);
                    uscEvrak.BtnClear_Visible = true;
                    dtpVade.Focus();
                }
                else
                {
                    MessageHelper.ErrorMessageBuilder(Messages.CekSenetMessages.EvrakNoZatenMevcut, "Veri Hatası");
                    txtEvrakNo.Focus();
                }

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
                txtAsilBorclu.Enabled = true;
                txtAsilBorclu.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Tutar bilgisi boş geçilemez.", "Veri Hatası");
                txtTutar.Focus();
            }
        }

        private void TxtAsilBorclu_Leave()
        {
            if (txtAsilBorclu.Text.Length > 0)
            {
                txtAsilBorclu.Enabled = false;
                txtAciklama.Enabled = true;
                txtAciklama.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Evrağın asıl borçlusunu giriniz!.. Evrak müşterinize ait ise kendisi olark belirtiniz.", "Veri hatası");
                txtAsilBorclu.Focus();
            }
        }

        private void TxtAciklama_Leave()
        {
            if (txtAciklama.Text.Length > 0)
            {
                txtAciklama.Enabled = false;
                uscEvrak.BtnSave_Enable = true;
                uscEvrak.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Bir açıklama girilmesi gerekir.", "Veri Hatası");
                txtAciklama.Focus();
            }
        }

        private CekSenetMusteri ReadEvrakFromForm() => new()
        {
            Id = oldEvrakId,
            No = txtEvrakNo.Text,
            Vade = dtpVade.Value,
            Tutar = _evrakTutar,
            AsilBorclu = txtAsilBorclu.Text,
            Aciklama = txtAciklama.Text
        };

        private void WriteEvrakToForm(CekSenetMusteri secilenMusteriEvrak)
        {
            oldEvrakId = secilenMusteriEvrak.Id;
            txtEvrakNo.Text = secilenMusteriEvrak.No;
            dtpVade.Value = secilenMusteriEvrak.Vade;
            txtTutar.Text = secilenMusteriEvrak.Tutar.ToString();
            txtAsilBorclu.Text = secilenMusteriEvrak.AsilBorclu;
            txtAciklama.Text = secilenMusteriEvrak.Aciklama;
        }

        private void ClearForm_BordroBilgiler()
        {
            txtBordroNo.Text = bordroNo.ToString();
            txtBordroNo.Enabled = true;
            btnBordroBul.Enabled = true;

            txtCariKod.Text = "";
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            lblCariUnvan.Text = "";

            dtpAlisTarih.Value = DateTime.Today;
            dtpAlisTarih.Enabled = false;

            txtBordroAciklama.Text = "";
            txtBordroAciklama.Enabled = false;

            grpEvrakBilgiler.Enabled = false;
        }

        private void ClearForm_EvrakBilgiler()
        {
            txtEvrakNo.Text = evrakNo.ToString();
            txtEvrakNo.Enabled = true;

            dtpVade.Value = DateTime.Today;
            dtpVade.Enabled = false;

            txtTutar.Text = "";
            txtTutar.Enabled = false;

            txtAsilBorclu.Text = "";
            txtAsilBorclu.Enabled = false;

            txtAciklama.Text = "";
            txtAciklama.Enabled = false;

            isUpdate = false;
            oldEvrakId = 0;
        }

        private void ClearForm_EvrakListe()
        {
            _musteriCekSenetler.Clear();
            UpdateForm_DgvEvraklar();
        }

        private void ClearDeger_NoSayaclar()
        {
            bordroNo = _cekSenetBordroService.GetNewRowsEvrakNo().Data;
            evrakNo = _cekSenetMusteriService.GetLastRowIndex().Data;
        }

        private void UpdateForm_DgvEvraklar()
        {
            dgvEvraklar.DataSource = _musteriCekSenetler.Select(s => new
            {
                s.Id,
                s.No,
                s.Vade,
                Tutar = s.Tutar.ToString("#,###.## TL"),
                s.AsilBorclu,
                s.Aciklama
            }).ToList();
        }

        private void ClearForm_UscEvrak()
        {
            uscEvrak.BtnClear_Visible = false;
            uscEvrak.BtnSave_Text = "Ekle";
            uscEvrak.BtnSave_Enable = false;
            uscEvrak.BtnDelete_Text = "Sil     ";
            uscEvrak.BtnDelete_Enable = false;
        }

        private void ClearForm_UscBordro()
        {
            uscBordro.BtnClear_Visible = false;
            uscBordro.BtnDelete_Enable = false;
            uscBordro.BtnSave_Text = "Ekle";
            uscBordro.BtnDelete_Text = "Sil     ";
            uscBordro.BtnSave_Enable = false;
        }

        private void GetNewBordro()
        {
            StaticPrimitives.SecilenBordroId = -1;
            _secilenTahsilatBordro = new();
            _secilenTahsilatBordro.Tur = BordroTurleri.Tahsilat.ToText();
            uscBordro.BtnClear_Visible = true;
        }

        private void GetOldBordro(CekSenetBordro secilenBordro)
        {
            _secilenTahsilatBordro = secilenBordro;
            StaticPrimitives.SecilenBordroId = _secilenTahsilatBordro.Id;
            txtCariKod.Text = _secilenTahsilatBordro.Cari.Kod;
            dtpAlisTarih.Value = _secilenTahsilatBordro.Tarih;
            txtBordroAciklama.Text = _secilenTahsilatBordro.Aciklama;
            lblCariUnvan.Text = _secilenTahsilatBordro.Cari.Unvan;

            _musteriCekSenetler.AddRange(_secilenTahsilatBordro.CekSenetMusteriler);
            UpdateForm_DgvEvraklar();

            grpEvrakBilgiler.Enabled = true;

            uscBordro.BtnClear_Visible = true;
            uscBordro.BtnDelete_Text = "Sil      ";
            uscBordro.BtnSave_Text = "Güncelle";
        }

        private void GetOldEvrak(CekSenetMusteri cekSenetMusteri)
        {
            oldEvrakId = cekSenetMusteri.Id;
            txtEvrakNo.Text = cekSenetMusteri.No;
            dtpVade.Value = cekSenetMusteri.Vade;
            txtTutar.Text = cekSenetMusteri.Tutar.ToString();
            txtAsilBorclu.Text = cekSenetMusteri.AsilBorclu;
            txtAciklama.Text = cekSenetMusteri.Aciklama;

            uscEvrak.BtnClear_Visible = true;
            uscEvrak.BtnSave_Text = "Güncelle";
            uscEvrak.BtnSave_Enable = true;
            uscEvrak.BtnDelete_Text = "Sil      ";
            uscEvrak.BtnDelete_Enable = true;
        }
    }
}