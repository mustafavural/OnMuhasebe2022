﻿using Autofac;
using Core.Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;

namespace WindowsFormUI.Views.Moduls.Companies
{
    public partial class FrmCompany : FrmBase
    {
        private readonly ICompanyService _companyService;
        private readonly IUserService _userService;
        private User _secilenUser;
        private Company _secilenCompany;
        private int _addedCompanyId;

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
                dgvUsers.DataSource = _userService.GetListByCompanyId(result.Data.Id).Data.Select(s => new
                {
                    s.Id,
                    s.Email,
                    s.FirstName,
                    s.LastName
                }).ToList();
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
            string tempDb = DataAccess.Properties.Statics.DatabaseName;
            var result = _companyService.Add(new Company
            {
                Id = 0,
                Name = txtCompanyName.Text,
                Status = true,
                Year = txtCompanyYear.Text,
                Detail = txtCompanyDetail.Text
            });
            if (result.IsSuccess)
            {
                try
                {
                    DataAccess.Properties.Statics.DatabaseName = txtCompanyName.Text;
                    using (var context = new SIRKETLERContext())
                    {
                        context.Database.EnsureCreated();
                    }
                }
                catch(Exception err)
                {
                    MessageHelper.ErrorMessageBuilder(err);
                }

                _companyService.InsertSQLQuery(CreateNewDatabase.InsertDatabaseSehirlerSQL);
                _companyService.InsertSQLQuery(CreateNewDatabase.InsertDatabaseIlcelerSQL);
                DataAccess.Properties.Statics.DatabaseName = tempDb;
            }
            else
                MessageHelper.ErrorMessageBuilder(result.Message, "Hata !");
        }

        private void BtnAddUserToCompany_Click(object sender, EventArgs e)
        {
            var frm = Program.Container.Resolve<FrmUserList>();
            frm.ShowDialog();
            if (StaticPrimitives.SecilenUserId > 0)
            {
                if (_userService.GetUserCompany(StaticPrimitives.SecilenUserId, _secilenCompany.Id).Data == null)
                {
                    _companyService.AddUserToCompany(new UserCompany { UserId = StaticPrimitives.SecilenUserId, CompanyId = _secilenCompany.Id });
                    StaticPrimitives.SecilenUserId = 0;

                    TxtCompanyName_Leave(sender, e);
                }
            }
        }

        private void BtnDeleteUserFromCompany_Click(object sender, EventArgs e)
        {
            if (_secilenUser != null)
            {
                _companyService.DeleteUserFromCompany(_userService.GetUserCompany(_secilenUser.Id, _secilenCompany.Id).Data);
                _secilenUser = null;
                btnDeleteUser.Enabled = false;

                TxtCompanyName_Leave(sender, e);
            }
        }

        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteUser.Enabled = false;
        }

        private void DgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var secilenUserEmail = dgvUsers.Rows[e.RowIndex].Cells["colEmail"].Value.ToString();
                _secilenUser = _userService.GetByMail(secilenUserEmail).Data;
                btnDeleteUser.Enabled = true;
            }
        }
    }
}