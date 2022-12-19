using Business.Abstract;
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
        private readonly List<Banka> _bankalar;
        private bool ciftTiklandiMi = false;
        private bool isUpdate = false;
        public bool SecimIcin { get; set; }

        public FrmBankaKart(IBankaService bankaService)
        {
            InitializeComponent();
            _bankaService = bankaService;
            _bankalar = new();
            SecimIcin = false;
        }

        private void FrmBankaKart_Load(object sender, EventArgs e)
        {
            if (SecimIcin)
            {
                uscBankalar.Enabled = false;
                uscBankalar.Visible = false;
                grpEkleGuncelle.Height -= uscBankalar.Height;
            }
            else
            {
                txtBankaAd.TextChanged -= Txt_TextChanged;
                txtSubeAd.TextChanged -= Txt_TextChanged;
                txtHesapNo.TextChanged -= Txt_TextChanged;
                txtIBAN.TextChanged -= Txt_TextChanged;
            }
            ClearScreen();
        }

        private void ClearScreen()
        {
            try
            {
                txtBankaAd.Text = "";
                txtSubeAd.Text = "";
                txtHesapNo.Text = "";
                txtIBAN.Text = "";
                lblStatusBar.Text = "";
                uscBankalar.BtnDelete_Enable = false;
                uscBankalar.BtnSave_Text = "Kaydet";
                uscBankalar.LblStatus_Text = "";
                _bankalar.Clear();
                _bankalar.AddRange(_bankaService.GetList().Data);
                WriteBankalartoDgv(_bankalar);
                isUpdate = false;
                txtBankaAd.Focus();
            }
            catch (UnauthorizedAccessException err)
            {
                MessageHelper.ErrorMessageBuilder(err);
                this.BeginInvoke(new MethodInvoker(Close));
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _bankalar.Where(s => s.BankaAd.Contains(txtBankaAd.Text) &&
                                                  s.BankaSubeAd.Contains(txtSubeAd.Text) &&
                                                  s.HesapNo.Contains(txtHesapNo.Text) &&
                                                  s.IBAN.Contains(txtIBAN.Text)
                                                  ).ToList();
                lblStatusBar.Text = "";
                WriteBankalartoDgv(result);
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }
        
        private void WriteBankalartoDgv(List<Banka> bankalar)
        {
            dgvBankalar.DataSource = bankalar.OrderByDescending(s => s.Id).Select(a => new
            {
                a.Id,
                a.BankaAd,
                a.BankaSubeAd,
                a.HesapNo,
                a.IBAN,
                Bakiye = _bankaService.GetHesapBakiye(a.Id).Data
            }).ToList();
        }

        private void DgvBankalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                StaticPrimitives.SecilenBankaId = (int)dgvBankalar.Rows[e.RowIndex].Cells["colId"].Value;
                if (SecimIcin)
                {
                    ciftTiklandiMi = true;
                    this.Close();
                }
                else
                {
                    isUpdate = true;
                    this.WriteBankaToForm(_bankalar.Where(s => s.Id == StaticPrimitives.SecilenBankaId).Single());
                }
            }
        }

        private void WriteBankaToForm(Banka secilenBanka)
        {
            txtBankaAd.Text = secilenBanka.BankaAd;
            txtSubeAd.Text = secilenBanka.BankaSubeAd;
            txtHesapNo.Text = secilenBanka.HesapNo;
            txtIBAN.Text = secilenBanka.IBAN;
            uscBankalar.BtnDelete_Enable = true;
            uscBankalar.BtnSave_Enable = true;
            uscBankalar.BtnSave_Text = "Güncelle";
            lblStatusBar.Text = "";
        }

        private void UscBankalar_ClickClear(object sender, EventArgs e)
        {
            this.ClearScreen();
        }

        private void UscBankalar_ClickCancel(object sender, EventArgs e)
        {
            try
            {
                var result = _bankaService.Delete(new Banka { Id = StaticPrimitives.SecilenBankaId });
                ClearScreen();
                lblStatusBar.Text = result.Message;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void UscBankalar_ClickSave(object sender, EventArgs e)
        {
            try
            {
                var result = isUpdate ? _bankaService.Update(ReadBankaFromForm()) : _bankaService.Add(ReadBankaFromForm());
                ClearScreen();
                lblStatusBar.Text = result.Message;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private Banka ReadBankaFromForm() => new()
        {
            Id = StaticPrimitives.SecilenBankaId,
            BankaAd = txtBankaAd.Text,
            BankaSubeAd = txtSubeAd.Text,
            HesapNo = txtHesapNo.Text,
            IBAN = txtIBAN.Text
        };

        private void FrmBankaKart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ciftTiklandiMi)
                StaticPrimitives.SecilenBankaId = 0;
        }
    }
}