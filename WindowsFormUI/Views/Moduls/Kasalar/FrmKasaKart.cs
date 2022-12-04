using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;

namespace WindowsFormUI.Views.Moduls.Kasalar
{
    public partial class FrmKasaKart : FrmBase
    {
        private IKasaService _kasaService;
        private List<Kasa> _kasalar;
        private Kasa _secilenKasa;
        private bool ciftTiklandiMi = false;

        public bool SecimIcin { get;set; }

        public FrmKasaKart(IKasaService kasaService)
        {
            InitializeComponent();
            _kasaService = kasaService;
            SecimIcin = false;
        }

        private void FrmKasaKart_Load(object sender, EventArgs e)
        {
            this.ClearScreen();
            if (SecimIcin)
            {
                uscKasalar.Enabled = false;
                uscKasalar.Visible = false;
                grpEkleGuncelle.Height -= uscKasalar.Height;
            }
        }

        private void ClearScreen()
        {
            try
            {
                txtKasaAd.Text = "";
                _secilenKasa = null;
                lblStatusBar.Text = "";
                uscKasalar.BtnDelete_Enable = false;
                uscKasalar.BtnSave_Enable = false;
                uscKasalar.BtnSave_Text = "Kaydet";
                uscKasalar.LblStatus_Text = "";
                _kasalar = _kasaService.GetList().Data;
                dgvKasalar.DataSource = _kasalar.OrderByDescending(s => s.Id).ToList();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void TxtKasaAd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _kasalar.Where(s => s.Ad.Contains(txtKasaAd.Text));
                uscKasalar.BtnSave_Enable = txtKasaAd.Text.Length > 5 && txtKasaAd.Text.Length < 50;
                lblStatusBar.Text = "";
                dgvKasalar.DataSource = result.OrderByDescending(s => s.Id).ToList();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DgvKasalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int kasaId = (int)dgvKasalar.Rows[e.RowIndex].Cells["colId"].Value;
                if (kasaId > 0)
                {
                    _secilenKasa = _kasaService.GetById(kasaId).Data;
                    if (SecimIcin)
                    {
                        StaticPrimitives.SecilenKasaId = kasaId;
                        ciftTiklandiMi = true;
                        this.Close();
                        return;
                    }
                    this.WriteToScreen(_secilenKasa);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void WriteToScreen(Kasa secilenKasa)
        {
            txtKasaAd.Text = secilenKasa.Ad;
            uscKasalar.BtnDelete_Enable = true;
            uscKasalar.BtnSave_Enable = true;
            uscKasalar.BtnSave_Text = "Güncelle";
            lblStatusBar.Text = "";
        }

        private void TxtKasaAd_Leave(object sender, EventArgs e)
        {
            if (txtKasaAd.Text.Length != 0)
            {
                txtKasaAd.Leave -= TxtKasaAd_Leave;
                var result = _kasaService.GetByAd(txtKasaAd.Text);
                if (result.Data != null)
                {
                    _secilenKasa = result.Data;
                    WriteToScreen(_secilenKasa);
                }
                else
                {
                    var txt = txtKasaAd.Text;
                    ClearScreen();
                    txtKasaAd.Text = txt;
                    uscKasalar.BtnClear_Visible = true;
                    txtKasaAd.Enabled = false;
                    uscKasalar.BtnSave_Enable = true;
                }
                txtKasaAd.Leave += TxtKasaAd_Leave;
            }
        }

        private void UscKasalar_ClickClear(object sender, EventArgs e)
        {
            this.ClearScreen();
            txtKasaAd.Focus();
        }

        private void UscKasalar_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                var result = _kasaService.Delete(_secilenKasa);
                this.ClearScreen();
                lblStatusBar.Text = result.Message;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UscKasalar_ClickSave(object sender, EventArgs e)
        {
            IResult result;
            try
            {
                if (_secilenKasa == null)
                {
                    _secilenKasa = new Kasa { Ad = txtKasaAd.Text };
                    result = _kasaService.Add(_secilenKasa);
                }
                else
                {
                    _secilenKasa.Ad = txtKasaAd.Text;
                    result = _kasaService.Update(_secilenKasa);
                }
                this.ClearScreen();
                lblStatusBar.Text = result.Message;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}