using Autofac;
using System;

namespace WindowsFormUI.Views.Moduls.Companies
{
    public partial class FrmCompanyMdi : FrmMdiBase
    {
        public FrmCompanyMdi()
        {
            InitializeComponent();
        }

        private void TsmiKayitCompany_Click(object sender, EventArgs e)
        {            
            var form = Program.Container.Resolve<FrmCompany>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiKayitTransfer_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmCompanyTransfer>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiCompanyExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}