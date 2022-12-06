using Autofac;
using Core.Extensions;
using System;
using System.Windows.Forms;

namespace WindowsFormUI.Views.Moduls.Faturalar
{
    public enum FaturaTurleri { Hepsi = 0, Alis = 1, Satis = 2 }
    public partial class FrmFatura : FrmMdiBase
    {
        public FrmFatura()
        {
            InitializeComponent();
        }

        private void TsmiKayit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            var faturaTur = (FaturaTurleri)tsmi.Tag.ToString().ToInt();
            
            var form = Program.Container.Resolve<FrmFaturaKayit>();
            form.MdiParent = this; 
            form.FaturaTur = faturaTur;
            form.Show();
        }

        private void TsmiKayitFaturaListe_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmFaturaListe>();
            form.MdiParent = this;
            form.FaturaTur = FaturaTurleri.Hepsi;
            form.Show();
        }

        private void TsmiFaturaExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}