using Autofac;
using Core.Business.Abstract;
using Core.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormUI.Views.Moduls.Cariler;

namespace WindowsFormUI.Views
{
    public partial class FrmLogin : FrmBase
    {
        private readonly IAuthService _authService;
        private readonly ICompanyService _companyService;
        public FrmLogin(IAuthService authService, ICompanyService companyService)
        {
            InitializeComponent();
            _authService = authService;
            _companyService = companyService;
            cmbSirketAd.Items.AddRange(_companyService.GetList().Select(s => s.Name).ToArray());
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            UserForLoginDto userForLoginDto = new()
            {
                Email = txtKullaniciAd.Text,
                Password = txtKullaniciSifre.Text
            };
            var userToLogin = _authService.Login(userForLoginDto);
            //if (!userToLogin.IsSuccess)
            //    return BadRequest(userToLogin.Message);

            var result = _authService.CreateAccessToken(userToLogin.Data);
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
