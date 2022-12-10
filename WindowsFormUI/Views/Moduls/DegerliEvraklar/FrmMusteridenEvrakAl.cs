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

namespace WindowsFormUI.Views.Moduls.DegerliEvraklar
{
    public partial class FrmMusteridenEvrakAl : FrmBase
    {
        private readonly IMusteriEvrakService _musteriEvrakService;
        private readonly ICariService _cariService;
        private readonly List<MusteriEvrak> _musteriEvraklar;
        private Cari _secilenCari;
        private decimal tutar;
        private bool isUpdate = false;
        private int secilenMusteriEvrakIndex;

        public FrmMusteridenEvrakAl(IMusteriEvrakService musteriEvrakService, ICariService cariService)
        {
            InitializeComponent();
            _musteriEvrakService = musteriEvrakService;
            _cariService = cariService;
            _musteriEvraklar = new List<MusteriEvrak>();
        }

        private void FrmMusteridenEvrakAl_Load(object sender, EventArgs e)
        {
            ClearScreen();
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

        private void TxtCariKod_Leave()
        {
            if (txtCariKod.Text.Length != 0)
            {
                var result = _cariService.GetByKod(txtCariKod.Text);
                if (result.Data != null)
                {
                    _secilenCari = result.Data;
                    txtCariKod.Enabled = false;
                    btnCariBul.Enabled = false;
                    lblCariUnvan.Text = _secilenCari.Unvan;

                    uscEvrakEkleGuncelleSil.BtnClear_Visible = true;
                    txtEvrakKod.Enabled = true;
                    txtEvrakKod.Focus();
                    
                }
                else
                {
                    MessageHelper.ErrorMessageBuilder(result.Message, "Veri Hatası");
                }
            }
        }

        private void TxtEvrakKod_Leave()
        {
            if (txtEvrakKod.Text.Length != 0)
            {
                txtEvrakKod.Text = FormatEvrakNo(txtEvrakKod.Text);
                txtEvrakKod.Enabled = false;
                dtpVade.Enabled = true;

                uscEvrakEkleGuncelleSil.BtnClear_Visible = true;
                dtpVade.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Evrak No Boş Geçilemez", "Veri Hatası");
                txtEvrakKod.Focus();
            }
        }

        public bool IsFormattedEvrakNo(string value)
        {
            if (value.Length == 14 && value.StartsWith("M"))
                return true;
            else
                return false;
        }

        public string FormatEvrakNo(string value)
        {
            if (this.IsFormattedEvrakNo(value))
                return value;
            else
            {
                string txt = value;
                value = "M";
                for (int i = 0; i < 13 - txt.Length; i++)
                    value += "0";
                value += txt;
                return value;
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
            if(txtTutar.Text.Length > 0)
            {
                tutar = txtTutar.Text.ToDecimal();
                txtTutar.Text = tutar.ToString("#,###.## TL");
                txtTutar.Enabled=false;
                dtpAlisTarih.Enabled= true;
                dtpAlisTarih.Focus();
            }
        }

        private void DtpAlisTarih_Leave()
        {
            if (dtpAlisTarih.Value == DateTime.Today.Date)
            {
                dtpAlisTarih.Enabled = false;
                txtAsilBorclu.Enabled = true;
                txtAsilBorclu.Focus();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Geçmiş tarihli evrak kabulu yapılamaz.", "Tarih Hatası");
                dtpAlisTarih.Focus();
            }
        }

        private void DtpInputEngelle(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtAsilBorclu_Leave()
        {
            if (txtAsilBorclu.Text.Length>0)
            {
                txtAsilBorclu.Enabled=false;
                txtAciklama.Enabled= true;
                txtAciklama.Focus();
            }
        }

        private void TxtAciklama_Leave()
        {
            if (txtAciklama.Text.Length>0)
            {
                txtAciklama.Enabled= false;
                uscEvrakEkleGuncelleSil.BtnSave_Enable = true;
                uscEvrakEkleGuncelleSil.Focus();
            }
        }

        private void UscEvrakEkleGuncelleSil_ClickClear(object sender, EventArgs e)
        {
            ClearCurrentEvrak();
        }

        private void UscEvrakEkleGuncelleSil_ClickSave(object sender, EventArgs e)
        {
            if (isUpdate)
                _musteriEvraklar.Update(secilenMusteriEvrakIndex, ReadMusteriEvrakFromForm());
            else
                _musteriEvraklar.Add(ReadMusteriEvrakFromForm());

            ClearCurrentEvrak();

            uscMusteriyeEvrakCik.BtnClear_Visible = true;
            uscMusteriyeEvrakCik.BtnDelete_Enable = true;
            uscMusteriyeEvrakCik.BtnSave_Enable = true;
        }

        private MusteriEvrak ReadMusteriEvrakFromForm()
        {
            return new()
            {
                Kod = txtEvrakKod.Text,
                AlinanCariHareketId = _secilenCari.Id,
                AlisTarihi = dtpAlisTarih.Value,
                AsilBorclu = txtAsilBorclu.Text,
                Vade = dtpVade.Value,
                Tutar = tutar,
                Aciklama = txtAciklama.Text
            };
        }

        private void WriteMusteriEvrakToForm(MusteriEvrak secilenMusteriEvrak)
        {
            ClearCurrentEvrak();
            txtEvrakKod.Text = secilenMusteriEvrak.Kod;
            dtpVade.Value = secilenMusteriEvrak.Vade;
            txtTutar.Text = secilenMusteriEvrak.Tutar.ToString().TrimEnd(" TL".ToCharArray());
            dtpAlisTarih.Value = secilenMusteriEvrak.AlisTarihi;
            txtAsilBorclu.Text = secilenMusteriEvrak.AsilBorclu;
            txtAciklama.Text = secilenMusteriEvrak.Aciklama;
            txtEvrakKod.Focus();
        }

        private void WriteToDgvMusteridenEvrakAl(List<MusteriEvrak> musteriEvraklar)
        {
            dgvMusteridenEvrakAl.DataSource = musteriEvraklar.Select(s => new
            {
                s.Id,
                s.Kod,
                s.AlinanCariHareketId,
                CariUnvan = _secilenCari.Unvan,
                s.Vade,
                Tutar = s.Tutar.ToString("#,###.## TL"),
                s.AlisTarihi,
                s.AsilBorclu,
                s.Aciklama
            }).ToList();
        }

        private void ClearCurrentEvrak()
        {
            WriteToDgvMusteridenEvrakAl(_musteriEvraklar);
            
            txtEvrakKod.Text = "";
            txtEvrakKod.Enabled = true;

            dtpVade.Value = DateTime.Today;
            dtpVade.Enabled = false;

            txtTutar.Text = "";
            txtTutar.Enabled = false;

            dtpAlisTarih.Value = DateTime.Today;
            dtpAlisTarih.Enabled = false;
            
            txtAsilBorclu.Text = "";
            txtAsilBorclu.Enabled = false;
            
            txtAciklama.Text = "";
            txtAciklama.Enabled = false;

            isUpdate = false;
            secilenMusteriEvrakIndex = -1;
            uscEvrakEkleGuncelleSil.BtnClear_Visible = false;
            uscEvrakEkleGuncelleSil.BtnSave_Enable = false;
            uscEvrakEkleGuncelleSil.BtnSave_Text = "Ekle";
            uscEvrakEkleGuncelleSil.BtnDelete_Enable = false;

            txtEvrakKod.Focus();
        }

        private void ClearScreen()
        {
            ClearCurrentEvrak();

            txtCariKod.Text = "";
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            lblCariUnvan.Text = "";

            txtEvrakKod.Enabled = false;

            _musteriEvraklar.Clear();

            uscMusteriyeEvrakCik.BtnClear_Visible = false;
            uscMusteriyeEvrakCik.BtnSave_Enable = false;
            uscMusteriyeEvrakCik.BtnDelete_Enable = false;

            txtCariKod.Focus();
        }

        private void UscMusteriyeEvrakCik_ClickClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void UscMusteriyeEvrakCik_ClickSave(object sender, EventArgs e)
        {
            try
            {
                foreach (var evrak in _musteriEvraklar)
                {
                    evrak.AlinanCariHareket = new CariHareket
                    {
                        CariId = _secilenCari.Id,
                        Tarih = evrak.AlisTarihi,
                        Tutar = evrak.Tutar * -1,
                        Aciklama = $"{evrak.Kod} nolu müşteri evrağı"
                    };
                }
                var result = _musteriEvrakService.MusteridenEvraklarAl(_musteriEvraklar);
                MessageHelper.SuccessMessageBuilder(result.Message, Messages.MusteriEvrakMessages.EvraklarAlindi);
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
            ClearScreen();
        }

        private void UscMusteriyeEvrakCik_ClickCancel(object sender, EventArgs e)
        {
            ClearScreen();
            this.Close();
        }

        private void DgvMusteridenEvrakAl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var secilenMusteriEvrak = _musteriEvraklar[e.RowIndex];
                WriteMusteriEvrakToForm(secilenMusteriEvrak);
                uscEvrakEkleGuncelleSil.BtnSave_Text = "Güncelle";
                uscEvrakEkleGuncelleSil.BtnSave_Enable = true;
                isUpdate = true;
                secilenMusteriEvrakIndex = e.RowIndex;
            }
        }
    }
}