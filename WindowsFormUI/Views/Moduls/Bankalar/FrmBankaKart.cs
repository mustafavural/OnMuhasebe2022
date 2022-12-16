using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;

namespace WindowsFormUI.Views.Moduls.Bankalar
{
    public partial class FrmBankaKart : FrmBase
    {
        private readonly IBankaService _bankaService;
        private List<Banka> _bankalar;
        private Banka _secilenBanka;
        private bool ciftTiklandiMi = false;

        public bool SecimIcin { get;set; }

        public FrmBankaKart(IBankaService bankaService)
        {
            InitializeComponent();
            _bankaService = bankaService;
            SecimIcin = false;
        }

        private void FrmBankaKart_Load(object sender, EventArgs e)
        {
            this.ClearScreen();
            if (SecimIcin)
            {
                uscBankalar.Enabled = false;
                uscBankalar.Visible = false;
                grpEkleGuncelle.Height -= uscBankalar.Height;
            }
        }

        private void ClearScreen()
        {
            try
            {
                txtBankaAd.Text = "";
                _secilenBanka = null;
                lblStatusBar.Text = "";
                uscBankalar.BtnDelete_Enable = false;
                uscBankalar.BtnSave_Enable = false;
                uscBankalar.BtnSave_Text = "Kaydet";
                uscBankalar.LblStatus_Text = "";
                _bankalar = _bankaService.GetList().Data;
                dgvBankalar.DataSource = _bankalar.OrderByDescending(s => s.Id).ToList();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void TxtBankaAd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _bankalar.Where(s => s.Ad.Contains(txtBankaAd.Text));
                uscBankalar.BtnSave_Enable = txtBankaAd.Text.Length > 5 && txtBankaAd.Text.Length < 50;
                lblStatusBar.Text = "";
                dgvBankalar.DataSource = result.OrderByDescending(s => s.Id).ToList();
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void DgvBankalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    StaticPrimitives.SecilenBankaId = (int)dgvBankalar.Rows[e.RowIndex].Cells["colId"].Value;
                    _secilenBanka = _bankaService.GetById(StaticPrimitives.SecilenBankaId).Data;
                    if (SecimIcin)
                    {
                        ciftTiklandiMi = true;
                        this.Close();
                    }
                    this.WriteToScreen(_secilenBanka);
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void WriteToScreen(Banka secilenBanka)
        {
            txtBankaAd.Text = secilenBanka.Ad;
            uscBankalar.BtnDelete_Enable = true;
            uscBankalar.BtnSave_Enable = true;
            uscBankalar.BtnSave_Text = "Güncelle";
            lblStatusBar.Text = "";
        }

        private void TxtBankaAd_Leave(object sender, EventArgs e)
        {
            if (txtBankaAd.Text.Length != 0)
            {
                txtBankaAd.Leave -= TxtBankaAd_Leave;
                var result = _bankaService.GetByAd(txtBankaAd.Text);
                if (result.Data != null)
                {
                    _secilenBanka = result.Data;
                    WriteToScreen(_secilenBanka);
                }
                else
                {
                    var txt = txtBankaAd.Text;
                    ClearScreen();
                    txtBankaAd.Text = txt;
                    uscBankalar.BtnClear_Visible = true;
                    txtBankaAd.Enabled = false;
                    uscBankalar.BtnSave_Enable = true;
                }
                txtBankaAd.Leave += TxtBankaAd_Leave;
            }
        }

        private void UscBankalar_ClickClear(object sender, EventArgs e)
        {
            this.ClearScreen();
            txtBankaAd.Focus();
        }

        private void UscBankalar_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                var result = _bankaService.Delete(_secilenBanka);
                this.ClearScreen();
                lblStatusBar.Text = result.Message;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void UscBankalar_ClickSave(object sender, EventArgs e)
        {
            IResult result;
            try
            {
                if (_secilenBanka == null)
                {
                    _secilenBanka = new Banka { Ad = txtBankaAd.Text };
                    result = _bankaService.Add(_secilenBanka);
                }
                else
                {
                    _secilenBanka.Ad = txtBankaAd.Text;
                    result = _bankaService.Update(_secilenBanka);
                }
                this.ClearScreen();
                lblStatusBar.Text = result.Message;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void FrmBankaKart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ciftTiklandiMi)
                StaticPrimitives.SecilenBankaId = 0;
        }
    }
}