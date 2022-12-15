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
            ClearScreen();
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
                    _secilenTediyeBordro.Cari = _cariService.GetById(StaticPrimitives.SecilenCariId).Data;
                    _secilenTediyeBordro.CariId = _secilenTediyeBordro.Cari.Id;
                    txtCariKod.Text = _secilenTediyeBordro.Cari.Kod;
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
                    var evrak = _cekSenetMusteriService.GetById(StaticPrimitives.SecilenMusteriEvrakId).Data;
                    _secilenMusteriEvrakIndex = _musteriCekSenetler.FindIndex(evrak);
                    if (_secilenMusteriEvrakIndex > -1)
                        _musteriCekSenetler.Update(_secilenMusteriEvrakIndex, evrak);
                    else
                        _musteriCekSenetler.Add(evrak);
                    ClearCurrentEvrak();
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void UscEvrakSil_ClickCancel(object sender, EventArgs e)
        {
            _musteriCekSenetler.RemoveAt(_secilenMusteriEvrakIndex);
            uscEvrakSil.BtnDelete_Enable = false;
            WriteEvraklarToDgv(_musteriCekSenetler);
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
                    if (result.Data.Tur == "Tediye")
                    {
                        _secilenTediyeBordro = result.Data;
                        BringExistingBordro(_secilenTediyeBordro);
                    }
                    else
                    {
                        MessageHelper.ErrorMessageBuilder("Girdiğiniz numara bir tahsilat bordrosuna ait. Bu ekranda kullanılamaz...", "Yanlış Evrak");
                        txtBordroNo.Text = "";
                        txtBordroNo.Focus();
                        return;
                    }
                }
                else
                    OpenNewBordro();
                txtCariKod.Focus();
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
            if (dtpCikisTarih.Value == DateTime.Today.Date)
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
                txtEvrakNo.Enabled = false;
                var evrak = _cekSenetMusteriService.GetByNo(txtEvrakNo.Text).Data;
                _secilenMusteriEvrakIndex = _musteriCekSenetler.FindIndex(evrak);
                if (_secilenMusteriEvrakIndex >= 0)
                    _musteriCekSenetler.Update(_secilenMusteriEvrakIndex, evrak);
                else
                    _musteriCekSenetler.Add(evrak);
                ClearCurrentEvrak();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
                txtEvrakNo.Focus();
            }
        }

        private void WriteEvraklarToDgv(List<CekSenetMusteri> musteriEvraklar)
        {
            dgvMusteridenEvrakAl.DataSource = musteriEvraklar.Select(s => new
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

        private void ClearCurrentEvrak()
        {
            WriteEvraklarToDgv(_musteriCekSenetler);

            txtEvrakNo.Text = "";
            txtEvrakNo.Enabled = true;

            _secilenMusteriEvrakIndex = -1;

            txtEvrakNo.Focus();
        }

        private void ClearScreen()
        {
            ClearCurrentEvrak();
            StaticPrimitives.SecilenBordroId = -1;

            var yenifis = _cekSenetBordroService.GetList().Data?.MaxBy(s => s.Id);
            int fisNo = yenifis == null ? 1 : yenifis.No[1..].Trim('0').ToInt() + 1;
            txtBordroNo.Text = fisNo.ToString();
            txtBordroNo.Enabled = true;
            btnBordroBul.Enabled = true;

            txtCariKod.Text = "";
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            lblCariUnvan.Text = "";

            txtEvrakNo.Enabled = false;
            dtpCikisTarih.Enabled = false;
            dtpCikisTarih.Value = DateTime.Today;
            txtBordroAciklama.Enabled = false;

            _musteriCekSenetler.Clear();
            WriteEvraklarToDgv(_musteriCekSenetler);
            _secilenTediyeBordro = null;

            uscMusteriyeEvrakCik.BtnClear_Visible = false;
            uscMusteriyeEvrakCik.BtnSave_Enable = false;
            uscMusteriyeEvrakCik.BtnDelete_Enable = false;

            txtBordroNo.Focus();
        }

        private void OpenNewBordro()
        {
            var bordro = txtBordroNo.Text;
            ClearScreen();
            _secilenTediyeBordro = new();
            txtBordroNo.Text = bordro;
            txtBordroNo.Enabled = false;
            btnBordroBul.Enabled = false;
            uscMusteriyeEvrakCik.BtnClear_Visible = true;
            uscMusteriyeEvrakCik.BtnSave_Enable = true;
            uscMusteriyeEvrakCik.BtnSave_Text = "Kaydet";
            txtCariKod.Text = "";
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            lblCariUnvan.Text = "";
            dtpCikisTarih.Value = DateTime.Today;
        }

        private void BringExistingBordro(CekSenetBordro secilenBordro)
        {
            ClearScreen();
            StaticPrimitives.SecilenBordroId = secilenBordro.Id;
            txtBordroNo.Text = secilenBordro.No;
            txtBordroNo.Enabled = false;
            btnBordroBul.Enabled = false;
            txtCariKod.Text = secilenBordro.Cari.Kod;
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            dtpCikisTarih.Enabled = false;
            dtpCikisTarih.Value = secilenBordro.Tarih;
            txtBordroAciklama.Text = secilenBordro.Aciklama;
            lblCariUnvan.Text = secilenBordro.Cari.Unvan;

            WriteEvraklarToDgv(secilenBordro.CekSenetMusteriler);

            uscMusteriyeEvrakCik.BtnClear_Visible = true;
            uscMusteriyeEvrakCik.BtnDelete_Enable = true;
            uscMusteriyeEvrakCik.BtnSave_Enable = true;
            uscMusteriyeEvrakCik.BtnSave_Text = "Güncelle";
        }

        private void DgvMusteridenEvrakAl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _secilenMusteriEvrakIndex = e.RowIndex;
                uscEvrakSil.BtnDelete_Enable = true;
            }
        }

        private void UscMusteriyeEvrakCik_ClickClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void UscMusteriyeEvrakCik_ClickCancel(object sender, EventArgs e)
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

        private void UscMusteriyeEvrakCik_ClickSave(object sender, EventArgs e)
        {
            try
            {
                if (_secilenTediyeBordro.Id > 0)
                {
                    _cekSenetBordroService.Update(_secilenTediyeBordro);
                }
                else
                {
                    _secilenTediyeBordro.Id = 0;
                    _secilenTediyeBordro.No = txtBordroNo.Text;
                    _secilenTediyeBordro.Tur = "Muşteri Tediye";
                    _secilenTediyeBordro.CariId = _secilenCari.Id;
                    _secilenTediyeBordro.Cari = _secilenCari;
                    _secilenTediyeBordro.CariHareket = new()
                    {
                        Id = 0,
                        CariId = _secilenCari.Id,
                        Cari = _secilenCari,
                        Tutar = _musteriCekSenetler.Sum(s => s.Tutar),
                        Tarih = dtpCikisTarih.Value,
                        Aciklama = $"{_secilenTediyeBordro.No} numaralı müşteriye ciro bordrosu."
                    };
                    _secilenTediyeBordro.Tarih = dtpCikisTarih.Value;
                    _secilenTediyeBordro.CekSenetMusteriler = _musteriCekSenetler;
                    _secilenTediyeBordro.Aciklama = txtBordroAciklama.Text;
                    _cekSenetBordroService.Add(_secilenTediyeBordro);
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }
    }
}