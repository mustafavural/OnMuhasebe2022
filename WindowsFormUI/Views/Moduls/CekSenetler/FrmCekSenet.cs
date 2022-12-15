using Autofac;
using System;

namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    public enum BordroTurleri { Hepsi = 0, Tahsilat = 1, MusteriTediye = 2, BorcTediye = 3 }
    public partial class FrmCekSenet : FrmMdiBase
    {
        public FrmCekSenet()
        {
            InitializeComponent();
        }

        private void TsmiKayitMusteridenEvrakAl_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmEvrakAl>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiKayitMusteriyeEvrakCik_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmMusteriyePortfoydenEvrakCik>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiKayitPortfoydekiEvraklar_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmPortfoydekiEvraklar>();
            form.MdiParent = this;
            form.SecimIcin = false;
            form.Show();
        }

        private void TsmiKayitBordroListeler_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmBordroListe>();
            form.MdiParent = this;
            form.BordroTur = BordroTurleri.Hepsi;
            form.Show();
        }

        private void TsmiDegerliEvrakCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}