using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;

namespace WindowsFormUI.Views.Moduls.Cariler
{
    public partial class FrmCariGrup : FrmBase
    {
        private ICariCategoryService _cariCategoryService;
        private CariCategory _secilenCategory;
        private List<CariCategory> _cariCategoryler;
        private bool _secTiklandiMi = false;

        public bool SecimIcin { get; set; }

        public FrmCariGrup(ICariCategoryService cariCategoryService)
        {
            this.InitializeComponent();
            _cariCategoryService = cariCategoryService;
            SecimIcin = false;
            if (SecimIcin)
            {
                uscGruplar.Visible = false;
                grpEkleGuncelle.Height = 55;
            }
            this.ClearScreen();
        }

        private void ClearScreen()
        {
            txtGrupKodAd.Text = "";
            _secilenCategory = null;
            lblStatusBar.Text = "";
            uscGruplar.BtnDelete_Enable = false;
            uscGruplar.BtnSave_Enable = false;
            uscGruplar.BtnSave_Text = "Kaydet";
            uscGruplar.LblStatus_Text = "";
            _cariCategoryler = _cariCategoryService.GetList().Data;
            dgvGruplar.DataSource = _cariCategoryler.OrderByDescending(s => s.Id).ToList();
        }

        private void WriteToScreen(CariCategory cariCategory)
        {
            txtGrupKodAd.Text = cariCategory.Ad;
            uscGruplar.BtnDelete_Enable = true;
            uscGruplar.BtnSave_Enable = true;
            uscGruplar.BtnSave_Text = "Güncelle";
            lblStatusBar.Text = "";
        }
        #region USCButtons
        private void UscGruplar_GrupEkleGuncelle(object sender, EventArgs e)
        {
            IResult result;
            try
            {
                if (_secilenCategory == null)
                {
                    _secilenCategory = new CariCategory { Ad = txtGrupKodAd.Text };
                    result = _cariCategoryService.Add(_secilenCategory);
                }
                else
                {
                    _secilenCategory.Ad = txtGrupKodAd.Text;
                    result = _cariCategoryService.Update(_secilenCategory);
                }
                this.ClearScreen();
                lblStatusBar.Text = result.Message;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UscGruplar_GrupSil(object sender, EventArgs e)
        {
            try
            {
                var result = _cariCategoryService.Delete(_secilenCategory);
                this.ClearScreen();
                lblStatusBar.Text = result.Message;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UscGruplar_ClickClear(object sender, EventArgs e)
        {
            this.ClearScreen();
        }
        #endregion

        private void TxtGrupAd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _cariCategoryler.Where(s => s.Ad.Contains(txtGrupKodAd.Text));
                uscGruplar.BtnSave_Enable = txtGrupKodAd.Text.Length > 2;
                lblStatusBar.Text = "";
                dgvGruplar.DataSource = result.OrderByDescending(s => s.Id).ToList();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DgvGruplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int categoryId = (int)dgvGruplar.Rows[e.RowIndex].Cells["colId"].Value;
                _secilenCategory = _cariCategoryService.GetById(categoryId).Data;
                if (SecimIcin)
                {
                    StaticPrimitives.SecilenCariCategoryId = _secilenCategory.Id;
                    _secilenCategory = null;
                    _secTiklandiMi = true;
                    this.Close();
                }
                else this.WriteToScreen(_secilenCategory);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void FrmStokGrup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_secTiklandiMi)
                StaticPrimitives.SecilenCariCategoryId = 0;
        }
    }
}