using Autofac;
using System;

namespace WindowsFormUI.Views.Moduls.Cariler
{
    public partial class FrmCari : FrmMdiBase
    {
        public FrmCari()
        {
            InitializeComponent();
        }

        private void TsmiCariKart_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmCariKart>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiCariGrup_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmCariGrup>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiCariListe_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmCariListe>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiCariExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}