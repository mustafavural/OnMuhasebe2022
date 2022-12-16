using Autofac;
using Core.Extensions;
using System;
using System.Windows.Forms;

namespace WindowsFormUI.Views.Moduls.Bankalar
{
    public enum BankaIslemTuru { Hepsi = 0, Tahsilat = 1, Tediye = 2 }
    public partial class FrmBanka : FrmMdiBase
    {
        public FrmBanka()
        {
            InitializeComponent();
        }

        private void TsmiCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsmiKayitKart_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBankaKart>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiKayitYap_Click(object sender, EventArgs e)
        {
            BankaIslemTuru bankaIslemTuru = (BankaIslemTuru)(((ToolStripMenuItem)sender).Tag.ToString().ToInt());
            var form = Program.Container.Resolve<FrmBankaKayit>();
            form.MdiParent = this;
            form.BankaIslemTuru = bankaIslemTuru;
            form.Show();
        }

        private void TsmiKayitListe_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBankaListe>();
            form.MdiParent = this;
            form.BankaIslemTuru = BankaIslemTuru.Hepsi;
            form.Show();
        }
    }
}