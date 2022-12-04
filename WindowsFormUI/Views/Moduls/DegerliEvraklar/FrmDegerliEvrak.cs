using Autofac;
using Business.Abstract;
using System;
using WindowsFormUI.Helpers;
using WindowsFormUI.Views.Moduls.Kasalar;

namespace WindowsFormUI.Views.Moduls.DegerliEvraklar
{
    public partial class FrmDegerliEvrak : FrmMdiBase
    {
        IMusteriEvrakService _musteriEvrakService;
        ICariService _cariService;
        public FrmDegerliEvrak(IMusteriEvrakService musteriEvrakService, ICariService cariService)
        {
            InitializeComponent();
            _musteriEvrakService = musteriEvrakService;
            _cariService = cariService;
        }

        private void TsmiKayitMusteridenEvrakAl_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmMusteridenEvrakAl>();
            form.MdiParent = this;
            form.Show();
        }

        private void TsmiKayitMusteriyeEvrakCik_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FrmMusteriyeEvrakCik>();
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

        private void TsmiDegerliEvrakCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}