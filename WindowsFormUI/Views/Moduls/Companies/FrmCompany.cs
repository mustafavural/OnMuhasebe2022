using Autofac;
using Core.Business.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;

namespace WindowsFormUI.Views.Moduls.Companies
{
    public partial class FrmCompany : FrmMdiBase
    {
        private readonly ICompanyService _companyService;
        private readonly IUserService _userService;
        private User _secilenUser;
        private Company _secilenCompany;

        public FrmCompany(IUserService userService, ICompanyService companyService)
        {
            InitializeComponent();
            _userService = userService;
            _companyService = companyService;
        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ClearScreen()
        {
            txtCompanyName.Text = string.Empty;
            txtCompanyYear.Text = string.Empty;
            txtCompanyDetail.Text = string.Empty;

            grpUsers.Enabled = false;

            dgvUsers.DataSource = new List<User>();

            uscAddDeleteCompany.BtnClear_Visible = true;
            uscAddDeleteCompany.BtnSave_Text = "Ekle  ";
            uscAddDeleteCompany.BtnSave_Enable = true;
            uscAddDeleteCompany.BtnDelete_Text = "Çıkış  ";
            uscAddDeleteCompany.BtnDelete_Enable = true;

            txtCompanyName.Focus();
        }

        private void TxtCompanyName_Leave(object sender, EventArgs e)
        {
            var result = _companyService.GetByName(txtCompanyName.Text);
            if (result.Data != null)
            {
                ClearScreen();
                txtCompanyName.Text = result.Data.Name;
                txtCompanyYear.Text = result.Data.Year;
                txtCompanyDetail.Text = result.Data.Detail;
                _secilenCompany = result.Data;
                txtCompanyDetail.Enabled = false;
                txtCompanyName.Enabled = false;
                txtCompanyYear.Enabled = false;
                grpUsers.Enabled = true;
            }
        }

        private void UscAddDeleteCompany_ClickCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UscAddDeleteCompany_ClickClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void UscAddDeleteCompany_ClickSave(object sender, EventArgs e)
        {
            var result = _companyService.Add(new Company
            {
                Id = 0,
                Name = txtCompanyName.Text,
                Status = true,
                Year = txtCompanyYear.Text,
                Detail = txtCompanyDetail.Text
            });
            if (!result.IsSuccess)
            {
                MessageHelper.ErrorMessageBuilder(result.Message, "Hata !");
            }
        }

        private void BtnAddUserToCompany_Click(object sender, EventArgs e)
        {
            var frm = Program.Container.Resolve<FrmUserList>();
            frm.ShowDialog();
            if (StaticPrimitives.SecilenUserId > 0)
            {
                //_companyService.AddUserToCompany(_userService.GetById(StaticPrimitives.SecilenUserId));
            }
        }

        private void BtnDeleteUserFromCompany_Click(object sender, EventArgs e)
        {
            if (_secilenUser != null)
            {
                //_companyService.DeleteUserFromCompany(_secilenUser);
                _secilenUser = null;
                btnDeleteUser.Enabled = false;
            }
        }

        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteUser.Enabled = false;
        }

        private void DgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                var secilenUserEmail = dgvUsers.Rows[e.RowIndex].Cells["colEmail"].Value.ToString();
                _secilenUser = _userService.GetByMail(secilenUserEmail);
                btnDeleteUser.Enabled = true;
            }
        }
    }
}