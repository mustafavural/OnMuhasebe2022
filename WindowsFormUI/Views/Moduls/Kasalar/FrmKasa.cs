using Autofac;
using Core.Extensions;
using System;
using System.Windows.Forms;

namespace WindowsFormUI.Views.Moduls.Kasalar
{
    public enum KasaIslemTuru { Hepsi = 0, Tahsilat = 1, Tediye = 2 }
    public partial class FrmKasa : FrmMdiBase
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        private void TsmiCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsmiKayitKart_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmKasaKart>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiKayitYap_Click(object sender, EventArgs e)
        {
            KasaIslemTuru kasaIslemTuru = (KasaIslemTuru)(((ToolStripMenuItem)sender).Tag.ToString().ToInt());
            var form = Program.Container.Resolve<FrmKasaKayit>();
            form.MdiParent = this;
            form.KasaIslemTuru = kasaIslemTuru;
            form.Show();
        }

        private void TsmiKayitListe_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmKasaListe>();
            form.MdiParent = this;
            form.Show();
        }
    }
}