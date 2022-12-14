using Business.Abstract;
using Core.Extensions;
using Entities.Concrete;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;
using WindowsFormUI.Views.UserExtensions;
using System.Linq;
using Autofac;
using WindowsFormUI.Views.Moduls.Cariler;

namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    public partial class FrmMusteriyeEvrakCik : FrmBase
    {
        private readonly ICekSenetBordroService _cekSenetBordroService;
        private readonly ICekSenetMusteriService _cekSenetMusteriService;
        private readonly ICariService _cariService;
        private readonly List<CekSenetMusteri> _musteriCekSenetler;
        private CekSenetBordro _secilenTediyeBordro;
        private Cari _secilenCari;
        private int _secilenMusteriEvrakIndex;

        public FrmMusteriyeEvrakCik(ICekSenetBordroService cekSenetBordroService, ICariService cariService, ICekSenetMusteriService cekSenetMusteriService)
        {
            InitializeComponent();
            _cekSenetBordroService = cekSenetBordroService;
            _cekSenetMusteriService = cekSenetMusteriService;
            _cariService = cariService;
            _musteriCekSenetler = _cekSenetMusteriService.GetListPortfoydekiler().Data;
        }

        private void DtpInputEngelle(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtBelgeNoHarfEngelle(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnBordroNoBul_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBordroListe>();
            form.BordroTur = BordroTurleri.Tediye;
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
                    if (_musteriCekSenetler.FindIndex(s => s.Id == evrak.Id) >= 0)
                        _musteriCekSenetler.Update(_musteriCekSenetler.FindIndex(s => s.Id == evrak.Id), evrak);
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

        private void UscEvrakEkleGuncelleSil_ClickClear(object sender, EventArgs e)
        {
            ClearCurrentEvrak();
        }

        private void UscEvrakEkleGuncelleSil_ClickCancel(object sender, EventArgs e)
        {
            _musteriCekSenetler.RemoveAt(_secilenMusteriEvrakIndex);
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
                    _secilenTediyeBordro = result.Data;
                    BringExistingBordro(_secilenTediyeBordro);
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
                    uscEvrakEkleGuncelleSil.BtnClear_Visible = true;
                    dtpAlisTarih.Enabled = true;
                    dtpAlisTarih.Focus();
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

        private void DtpAlisTarih_Leave()
        {
            if (dtpAlisTarih.Value == DateTime.Today.Date)
            {
                dtpAlisTarih.Enabled = false;
                txtBordroAciklama.Enabled = true;
                txtBordroAciklama.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Geçmiş tarihli evrak kabulu yapılamaz.", "Tarih Hatası");
                dtpAlisTarih.Focus();
            }
        }

        private void TxtBordroAciklama_Leave()
        {
            if (txtBordroAciklama.Text.Length > 0)
            {
                txtBordroAciklama.Enabled = false;
                grpEvrakBilgiler.Enabled = true;

                var yenifis = _cekSenetMusteriService.GetList().Data?.MaxBy(s => s.Id);
                int fisNo = yenifis == null ? 1 : yenifis.No[1..].Trim('0').ToInt() + 1;
                txtEvrakNo.Text = fisNo.ToString();

                txtEvrakNo.Enabled = true;
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
                uscEvrakEkleGuncelleSil.BtnClear_Visible = true;
                var evrak = _cekSenetMusteriService.GetByNo(txtEvrakNo.Text).Data;
                if (_musteriCekSenetler.FindIndex(s => s.Id == evrak.Id) >= 0)
                    _musteriCekSenetler.Update(_musteriCekSenetler.FindIndex(s => s.Id == evrak.Id), evrak);
                else
                    _musteriCekSenetler.Add(evrak);
                ClearCurrentEvrak();
            }
            catch(Exception err)
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
            uscEvrakEkleGuncelleSil.BtnClear_Visible = false;
            uscEvrakEkleGuncelleSil.BtnSave_Enable = false;
            uscEvrakEkleGuncelleSil.BtnSave_Text = "Ekle";
            uscEvrakEkleGuncelleSil.BtnDelete_Enable = false;

            txtEvrakNo.Focus();
        }

        private void ClearScreen()
        {
            ClearCurrentEvrak();

            txtCariKod.Text = "";
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            lblCariUnvan.Text = "";

            txtEvrakNo.Enabled = false;
            dtpAlisTarih.Enabled = false;
            txtBordroAciklama.Enabled = false;
            dtpAlisTarih.Value = DateTime.Today;

            _musteriCekSenetler.Clear();
            _secilenTediyeBordro = null;

            uscMusteriyeEvrakCik.BtnClear_Visible = false;
            uscMusteriyeEvrakCik.BtnSave_Enable = false;
            uscMusteriyeEvrakCik.BtnDelete_Enable = false;

            txtBordroNo.Focus();
        }

        private void OpenNewBordro()
        {
            StaticPrimitives.SecilenBordroId = -1;
            _secilenTediyeBordro = new();
            var bordro = txtBordroNo.Text;
            ClearScreen();
            txtBordroNo.Text = bordro;
            txtBordroNo.Enabled = false;
            btnBordroNoBul.Enabled = false;
            uscMusteriyeEvrakCik.BtnClear_Visible = true;
            uscMusteriyeEvrakCik.BtnSave_Enable = true;
            uscMusteriyeEvrakCik.BtnSave_Text = "Kaydet";
            txtCariKod.Text = "";
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            lblCariUnvan.Text = "";
            dtpAlisTarih.Value = DateTime.Today;
            grpEvrakBilgiler.Enabled = false;
        }

        private void BringExistingBordro(CekSenetBordro secilenBordro)
        {
            ClearScreen();
            StaticPrimitives.SecilenBordroId = secilenBordro.Id;
            txtBordroNo.Text = secilenBordro.No;
            txtBordroNo.Enabled = false;
            btnBordroNoBul.Enabled = false;
            txtCariKod.Text = secilenBordro.Cari.Kod;
            txtCariKod.Enabled = false;
            btnCariBul.Enabled = false;
            dtpAlisTarih.Enabled = false;
            dtpAlisTarih.Value = secilenBordro.Tarih;
            txtBordroAciklama.Text = secilenBordro.Aciklama;
            lblCariUnvan.Text = secilenBordro.Cari.Unvan;

            WriteEvraklarToDgv(secilenBordro.CekSenetMusteriler);

            grpEvrakBilgiler.Enabled = true;
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
                uscEvrakEkleGuncelleSil.BtnDelete_Enable = true;
                uscEvrakEkleGuncelleSil.BtnDelete_Text = "erase";   
            }
        }
    }
}