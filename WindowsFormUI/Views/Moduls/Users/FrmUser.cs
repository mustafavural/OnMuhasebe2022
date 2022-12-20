using Core.Business.Abstract;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using Core.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormUI.Helpers;

namespace WindowsFormUI.Views.Moduls.Users
{
    public partial class FrmUser : FrmBase
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;
        private readonly List<User> _users;
        public FrmUser(IUserService userService, IAuthService authService)
        {
            InitializeComponent();
            _userService = userService;
            _authService = authService;
            _users = new();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ClearScreen()
        {
            txtUserFirstName.Text = string.Empty;
            txtUserLastName.Text = string.Empty;
            txtUserEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPasswordAgain.Text = string.Empty;

            txtUserFirstName.Enabled = true;
            txtUserLastName.Enabled = false;
            txtUserEmail.Enabled = false;
            txtPassword.Enabled = false;
            txtPasswordAgain.Enabled = false;

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

        private void TxtUserFirstName_Leave()
        {
            if (txtUserFirstName.Text.Length > 0)
            {
                txtUserFirstName.Enabled = false;
                txtUserLastName.Enabled = true;
                uscAddDeleteUser.BtnClear_Visible = true;
                txtUserLastName.Focus();
            }
        }

        private void TxtUserLastName_Leave()
        {
            if (txtUserLastName.Text.Length > 0)
            {
                txtUserLastName.Enabled = false;
                txtUserEmail.Enabled = true;
                txtUserEmail.Focus();
            }
        }

        private void TxtUserEmail_Leave()
        {
            if (txtUserEmail.Text.Length > 0)
            {
                txtUserEmail.Enabled = false;
                txtPassword.Enabled = true;
                txtPasswordAgain.Enabled = true;
                txtPassword.Focus();
            }
        }

        private void TxtPassword_Leave()
        {
            if (txtPassword.Text.Length > 0)
            {
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

        }

        private void BtnDeleteClaim_Click(object sender, EventArgs e)
        {

        }
    }
}