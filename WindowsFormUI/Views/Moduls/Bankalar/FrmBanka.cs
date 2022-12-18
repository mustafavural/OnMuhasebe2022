using Autofac;
using Core.Extensions;
using System;
using System.Windows.Forms;
using WindowsFormUI.Properties;

namespace WindowsFormUI.Views.Moduls.Bankalar
{
    public enum BankaIslemTurleri { Hepsi = 0, Tahsilat = 1, Tediye = 2 }
    public partial class FrmBanka : FrmMdiBase
    {
        public FrmBanka()
        {
            InitializeComponent();
        }

        private void TsmiKayitKart_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBankaKart>();
            form.MdiParent = this;
            form.SecimIcin = false;
            form.Show();
        }

        private void TsmiKayitYap_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBankaKayit>();
            form.MdiParent = this;
            form.BankaIslemTuru = (BankaIslemTurleri)(((ToolStripMenuItem)sender).Tag.ToString().ToInt());
            if (form.BankaIslemTuru == BankaIslemTurleri.Tahsilat)
            {
                form.Icon = Resources.Banka_Havale32x321;
                form.Text += "  --  Havale/EFT Al";
            }
            else if (form.BankaIslemTuru == BankaIslemTurleri.Tediye)
            {
                form.Icon = Resources.BankaEFT32x321;
                form.Text += "  --  Havale/EFT Gönder";
            }
            form.Show();
        }

        private void TsmiKayitListe_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBankaHareketListe>();
            form.MdiParent = this;
            form.BankaIslemTuru = BankaIslemTurleri.Hepsi;
            form.Show();
        }

        private void TsmiCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}