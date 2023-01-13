using Autofac;
using Core.Business.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Windows.Forms;
using WindowsFormUI.Views.Moduls.Bankalar;
using WindowsFormUI.Views.Moduls.Cariler;
using WindowsFormUI.Views.Moduls.CekSenetler;
using WindowsFormUI.Views.Moduls.Companies;
using WindowsFormUI.Views.Moduls.Faturalar;
using WindowsFormUI.Views.Moduls.Kasalar;
using WindowsFormUI.Views.Moduls.Stoklar;
using WindowsFormUI.Views.Moduls.Users;

namespace WindowsFormUI.Views
{
    public partial class FrmWelcome : FrmBase
    {
        public FrmWelcome(ICompanyService companyService)
        {
            InitializeComponent();
            using (var context = new SIRKETLERContext())
            {
                if(context.Database.EnsureCreated())
                {
                    Thread.Sleep(1000);
                    context.Database.ExecuteSqlRaw(CreateNewDatabase.InsertDatabaseSehirlerSQL);
                    context.Database.ExecuteSqlRaw(CreateNewDatabase.InsertDatabaseIlcelerSQL);
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnWelcomeStok_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<FrmStok>().Show();
        }

        private void BtnWelcomeCari_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<FrmCari>().Show();
        }

        private void BtnWelcomeFatura_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<FrmFatura>().Show();
        }

        private void BtnWelcomeKasa_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<FrmKasa>().Show();
        }

        private void BtnWelcomeCekSenet_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<FrmCekSenet>().Show();
        }

        private void BtnWelcomeBanka_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<FrmBanka>().Show();
        }

        private void BtnWelcomeUser_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<FrmUser>().Show();
        }

        private void BtnWelcomeCompany_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<FrmCompanyMdi>().Show();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}