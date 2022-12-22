using Autofac;
using Core.Business.Abstract;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WindowsFormUI.Constants;
using WindowsFormUI.Helpers;

namespace WindowsFormUI.Views.Moduls.Users
{
    public partial class FrmUser : FrmBase
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;
        private User _secilenUser;
        private int _secilenClaimId;

        public FrmUser(IUserService userService, IAuthService authService)
        {
            InitializeComponent();
            _userService = userService;
            _authService = authService;
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ClearScreen()
        {
            txtUserEmail.Text = string.Empty;
            txtUserFirstName.Text = string.Empty;
            txtUserLastName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPasswordAgain.Text = string.Empty;

            txtUserEmail.Enabled = true;
            txtUserFirstName.Enabled = false;
            txtUserLastName.Enabled = false;
            txtPassword.Enabled = false;
            txtPasswordAgain.Enabled = false;

            grpClaims.Enabled = false;

            dgvClaims.DataSource = new List<OperationClaim>();

            uscAddDeleteUser.BtnClear_Visible = false;
            uscAddDeleteUser.BtnSave_Text = "Ekle   ";
            uscAddDeleteUser.BtnSave_Enable = false;
            uscAddDeleteUser.BtnDelete_Text = "Vazgeç ";
            uscAddDeleteUser.BtnDelete_Enable = true;

            txtUserFirstName.Focus();
        }

        private void LeaveOnlyWithTabKey(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                string methodName = ((TextBox)sender).Name.ToFirstLetterUpperCase() + "_Leave";

                MethodInfo methodInfo = this.GetType().GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
                methodInfo.Invoke(this, null);
            }
        }

        private void TxtUserEmail_Leave()
        {
            if (txtUserEmail.Text.Length > 3)
            {
                _secilenUser = _userService.GetByMail(txtUserEmail.Text).Data;
                if (_secilenUser != null)
                    WriteToScreenSelectedUser();
                txtUserEmail.Enabled = false;
                txtUserFirstName.Enabled = true;
                uscAddDeleteUser.BtnClear_Visible = true;
                txtUserFirstName.Focus();
            }
        }

        private void WriteToScreenSelectedUser()
        {
            txtUserEmail.Text = _secilenUser.Email;
            txtUserFirstName.Text = _secilenUser.FirstName;
            txtUserLastName.Text = _secilenUser.LastName;

            grpClaims.Enabled = true;

            dgvClaims.DataSource = _userService.GetClaims(_secilenUser).Data;
        }

        private void TxtUserFirstName_Leave()
        {
            if (txtUserFirstName.Text.Length > 0)
            {
                txtUserFirstName.Enabled = false;
                txtUserLastName.Enabled = true;
                txtUserLastName.Focus();
            }
        }

        private void TxtUserLastName_Leave()
        {
            if (txtUserLastName.Text.Length > 0)
            {
                txtUserLastName.Enabled = false;
                txtPassword.Enabled = true;
                txtPassword.Focus();
            }
        }

        private void TxtPassword_Leave()
        {
            if (txtPassword.Text.Length > 0)
            {
                txtPasswordAgain.Enabled = true;
                txtPasswordAgain.Focus();
            }
        }

        private void TxtPasswordAgain_Leave()
        {
            if (txtPasswordAgain.Text.Length > 0 && txtPassword.Text == txtPasswordAgain.Text)
            {
                uscAddDeleteUser.BtnSave_Enable = true;
                uscAddDeleteUser.Focus();
            }
        }

        private void UscAddDeleteUser_ClickClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void UscAddDeleteUser_ClickSave(object sender, EventArgs e)
        {
            try
            {
                UserForRegisterDto userForRegisterDto = new()
                {
                    FirstName = txtUserFirstName.Text,
                    LastName = txtUserLastName.Text,
                    Email = txtUserEmail.Text,
                    Password = txtPassword.Text
                };
                var result = _authService.Register(userForRegisterDto);
                if (result.IsSuccess)
                    MessageHelper.SuccessMessageBuilder(result.Message, "Kayıt Başarılı !");
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }

        private void UscAddDeleteUser_ClickCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddClaim_Click(object sender, EventArgs e)
        {
            var frm = Program.Container.Resolve<FrmClaim>();
            frm.SecimIcin = true;
            frm.ShowDialog();

            try
            {
                if (StaticPrimitives.SecilenClaimId > 0)
                {
                    var result = _userService.AddClaimToUser(new UserOperationClaim
                    {
                        UserId = _secilenUser.Id,
                        OperationClaimId = StaticPrimitives.SecilenClaimId
                    });
                    dgvClaims.DataSource = _userService.GetClaims(_secilenUser).Data;
                    btnGrupEkle.Focus();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DgvClaims_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>0)
            {
                btnDeleteClaim.Enabled = true;
                _secilenClaimId = (int)dgvClaims.Rows[e.RowIndex].Cells["colClaimId"].Value;
            }
        }

        private void DgvClaims_Click(object sender, EventArgs e)
        {
            btnDeleteClaim.Enabled = false;
        }

        private void BtnDeleteClaim_Click(object sender, EventArgs e)
        {
            try
            {
                var UserOperationClaim = _userService.GetUserOperationClaim(_secilenUser.Id, _secilenClaimId).Data;
                var result = _userService.DeleteClaimFromUser(UserOperationClaim);

                dgvClaims.DataSource = _userService.GetClaims(_secilenUser).Data;
                btnGrupSil.Enabled = false;
                _secilenClaimId = 0;
                btnDeleteClaim.Enabled = false;
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
            }
        }
    }
}