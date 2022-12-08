using Autofac;
using Business.Abstract;
using Core.Extensions;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;
using WindowsFormUI.Views.Moduls.Cariler;
using WindowsFormUI.Views.Moduls.Kasalar;

namespace WindowsFormUI.Views.Moduls.DegerliEvraklar
{
    public partial class FrmMusteridenEvrakAl : FrmBase
    {
        private readonly IMusteriEvrakService _musteriEvrakService;
        private readonly ICariService _cariService;
        private Cari _secilenCari;
        private List<MusteriEvrak> _musteriEvraklar;
        public FrmMusteridenEvrakAl(IMusteriEvrakService musteriEvrakService, ICariService cariService)
        {
            InitializeComponent();
            _musteriEvrakService = musteriEvrakService;
            _cariService = cariService;
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

        private void TxtCariKod_Leave(object sender, EventArgs e)
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
                    uscEvrakEkleGuncelleSil.BtnSave_Enable = true;
                    uscEvrakEkleGuncelleSil.BtnDelete_Enable = true;
                }
                else
                {
                    MessageBox.Show(result.Message, "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UscEvrakEkleGuncelleSil_ClickClear(object sender, EventArgs e)
        {
            ClearCurrentEvrak();
        }

        private void UscEvrakEkleGuncelleSil_ClickSave(object sender, EventArgs e)
        {
            _musteriEvraklar.Add(new()
            {
                DegerliEvrak = new()
                {
                    Kod = txtEvrakKod.Text,
                    Vade = dtpVade.Value,
                    Tutar = txtTutar.Text.ToDecimal(),
                    Aciklama = txtAciklama.Text
                },
                AlinanCariId = _secilenCari.Id,
                AsilBorclu = txtAsilBorclu.Text,
                AlisTarihi = dtpAlisTarih.Value,
            });
            WriteToScreen(_musteriEvraklar);
            ClearCurrentEvrak();
        }

        private void WriteToScreen(List<MusteriEvrak> musteriEvraklar)
        {
            dgvMusteridenEvrakAl.DataSource = musteriEvraklar.Select(s => new
            {
                s.Id,
                s.AlinanCariId,
                s.DegerliEvrak.Kod,
                s.DegerliEvrak.Vade,
                s.AsilBorclu,
                s.DegerliEvrak.Tutar,
                s.AlisTarihi,
                s.DegerliEvrak.Aciklama,
                CariUnvan = lblCariUnvan.Text,
            }).ToList();
            uscMusteriyeEvrakCik.BtnClear_Visible = true;
            uscMusteriyeEvrakCik.BtnDelete_Enable = true;
            uscMusteriyeEvrakCik.BtnSave_Enable = true;
        }

        private void ClearCurrentEvrak()
        {
            txtEvrakKod.Text = "";
            dtpVade.Value = DateTime.Today;
            txtTutar.Text = "";
            dtpAlisTarih.Value = DateTime.Today;
            txtAsilBorclu.Text = "";
            txtAciklama.Text = "";

            uscEvrakEkleGuncelleSil.BtnClear_Visible = false;
            uscEvrakEkleGuncelleSil.BtnSave_Enable = true;
            uscEvrakEkleGuncelleSil.BtnDelete_Enable = false;
        }

        private void ClearScreen()
        {
            ClearCurrentEvrak();
            txtCariKod.Text = "";
            txtCariKod.Enabled = true;
            btnCariBul.Enabled = true;
            lblCariUnvan.Text = "";

            dgvMusteridenEvrakAl.DataSource = new List<MusteriEvrakDto>();
            _musteriEvraklar = new();

            uscMusteriyeEvrakCik.BtnClear_Visible = false;
            uscMusteriyeEvrakCik.BtnSave_Enable = false;
            uscMusteriyeEvrakCik.BtnDelete_Enable = true;
        }

        private void UscMusteriyeEvrakCik_ClickClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void UscMusteriyeEvrakCik_ClickCancel(object sender, EventArgs e)
        {
            ClearScreen();
            this.Close();
        }

        private void UscMusteriyeEvrakCik_ClickSave(object sender, EventArgs e)
        {
            try
            {
                var result = _musteriEvrakService.MusteridenEvraklarAl(_musteriEvraklar);
                MessageHelper.SuccessMessageBuilder(result.Message, "Evrak Başarılı!");
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
            ClearScreen();
        }

        private void DtpInputEngelle(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}