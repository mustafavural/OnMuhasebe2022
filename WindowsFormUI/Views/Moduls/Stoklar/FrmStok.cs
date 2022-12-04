using Autofac;
using System;

namespace WindowsFormUI.Views.Moduls.Stoklar
{
    public partial class FrmStok : FrmMdiBase
    {
        public FrmStok()
        {
            InitializeComponent();
        }
        private void TsmiStokKart_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmStokKart>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiStokGrup_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmStokGrup>();
            form.MdiParent = this;
            form.Show();
        }
        private void TsmiStokListe_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmStokListe>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiStokExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}