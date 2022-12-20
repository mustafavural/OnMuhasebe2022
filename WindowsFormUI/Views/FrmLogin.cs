using Autofac;
using Core.Business.Abstract;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using System;
using System.Data;
using System.Linq;
using WindowsFormUI.Helpers;

namespace WindowsFormUI.Views
{
    public partial class FrmLogin : FrmBase
    {
        private readonly IAuthService _authService;
        private readonly ICompanyService _companyService;
        private IDataResult<User> _user;
        private IDataResult<AccessToken> _accessToken;
        public FrmLogin(IAuthService authService, ICompanyService companyService)
        {
            InitializeComponent();
            _authService = authService;
            _companyService = companyService;
        }

        private void Login()
        {
            try
            {
                UserForLoginDto userForLoginDto = new()
                {
                    Email = txtKullaniciAd.Text,
                    Password = txtKullaniciSifre.Text
                };
                _user = _authService.Login(userForLoginDto);
                if (_user.IsSuccess)
                {
                    _accessToken = _authService.CreateAccessToken(_user.Data);
                    if (_accessToken.IsSuccess)
                    {
                        UserHelper.AccessToken = _accessToken.Data;
                        cmbSirketAd.Enabled = true;
                        cmbSirketAd.Items.AddRange(_companyService.GetListByUserId(_user.Data.Id).Select(s => s.Name).ToArray());
                    }
                    else
                    {
                        MessageHelper.ErrorMessageBuilder(_accessToken.Message, "Token Hatası");
                        ClearScreen();
                    }
                }
                else
                {
                    MessageHelper.ErrorMessageBuilder(_user.Message, "Kullanıcı Giriş Hatası");
                    ClearScreen();
                }
            }
            catch (Exception err)
            {
                MessageHelper.ErrorMessageBuilder(err);
                ClearScreen();
            }
        }

        private void ClearScreen()
        {
            txtKullaniciAd.Text = "";
            txtKullaniciSifre.Text = "";
            _user = null;
            btnGiris.Enabled = true;
            cmbSirketAd.Enabled = false;
        }

        private void LoginToCompany()
        {
            if (cmbSirketAd.SelectedIndex > -1)
            {
                DataAccess.Concrete.EntityFramework.Contexts.SIRKETLERContext.DatabaseName = cmbSirketAd.Text;
                this.Hide();
                Program.Container.Resolve<FrmWelcome>().ShowDialog();
                this.Close();
            }
            else
            {
                MessageHelper.ErrorMessageBuilder("Şirket Seçiniz!!!", "Giriş Hatası.");
            }
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                btnGiris.Enabled = false;
                Login();
            }
            else
            {
                LoginToCompany();
            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbSirketAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSirketAd.SelectedIndex > 0)
            {
                btnGiris.Enabled = cmbSirketAd.SelectedIndex > 0;
            }
        }
    }
}