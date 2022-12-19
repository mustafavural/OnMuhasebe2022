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

namespace WindowsFormUI.Views.Moduls.Stoklar
{
    public partial class FrmStokGrup : FrmBase
    {
        private readonly IStokCategoryService _stokCategoryService;
        private List<StokCategory> _stokCategoryler;
        private StokCategory _secilenCategory;
        private bool _secTiklandiMi = false;

        public bool SecimIcin { get; set; }

        public FrmStokGrup(IStokCategoryService stokCategoryService)
        {
            this.InitializeComponent();
            _stokCategoryService = stokCategoryService;
            SecimIcin = false;
            if (SecimIcin)
            {
                uscGruplar.Visible = false;
                grpEkleGuncelle.Height = 55;
            }
        }

        private void FrmStokGrup_Load(object sender, EventArgs e)
        {
            this.ClearScreen();
        }

        private void ClearScreen()
        {
            try
            {
                _secilenCategory = null;
                _stokCategoryler = _stokCategoryService.GetList().Data;
                txtGrupKodAd.Text = "";
                uscGruplar.BtnDelete_Enable = false;
                uscGruplar.BtnSave_Enable = false;
                uscGruplar.BtnSave_Text = "Kaydet";
                lblStatusBar.Text = "";
                dgvGruplar.DataSource = _stokCategoryler.OrderByDescending(s => s.Id).ToList();
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

        private void WriteToScreen(StokCategory stokCategory)
        {
            if (!SecimIcin)
            {
                txtGrupKodAd.Text = stokCategory.Ad;
                _secilenCategory = stokCategory;
                uscGruplar.BtnDelete_Enable = true;
                uscGruplar.BtnSave_Enable = true;
                uscGruplar.BtnSave_Text = "Güncelle";
                lblStatusBar.Text = "";
            }
        }
        #region USCButtons
        private void UscGruplar_GrupEkleGuncelle(object sender, EventArgs e)
        {
            IResult result;
            if (_secilenCategory == null)
            {
                _secilenCategory = new StokCategory { Ad = txtGrupKodAd.Text };
                result = _stokCategoryService.Add(_secilenCategory);
            }
            else
            {
                _secilenCategory.Ad = txtGrupKodAd.Text;
                result = _stokCategoryService.Update(_secilenCategory);
            }
            this.ClearScreen();
            lblStatusBar.Text = result.Message;
        }

        private void UscGruplar_GrupSil(object sender, EventArgs e)
        {
            IResult result;
            result = _stokCategoryService.Delete(_secilenCategory);
            this.ClearScreen();
            lblStatusBar.Text = result.Message;
        }

        private void UscGruplar_ClickClear(object sender, EventArgs e)
        {
            this.ClearScreen();
        }
        #endregion

        private void TxtGrupAd_TextChanged(object sender, EventArgs e)
        {
            var result = _stokCategoryler.Where(s => s.Ad.ToLower().Contains(txtGrupKodAd.Text.ToLower()));
            uscGruplar.BtnSave_Enable = txtGrupKodAd.Text.Length > 2;
            lblStatusBar.Text = "";
            dgvGruplar.DataSource = result.OrderByDescending(s => s.Id).ToList();
        }

        private void DgvGruplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int categoryId = (int)dgvGruplar.Rows[e.RowIndex].Cells["colId"].Value;
                _secilenCategory = _stokCategoryler.Where(s => s.Id == categoryId).Single();
                this.WriteToScreen(_secilenCategory);
                if (SecimIcin)
                {
                    StaticPrimitives.SecilenStokCategoryId = _secilenCategory.Id;
                    _secTiklandiMi = true;
                    this.Close();
                }
            }
        }

        private void FrmStokGrup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_secTiklandiMi)
                StaticPrimitives.SecilenStokCategoryId = 0;
        }
    }
}