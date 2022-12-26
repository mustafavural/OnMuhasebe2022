using Autofac;
using Business.DependencyResolvers.Autofac;
using Core.DependencyResolvers;
using Core.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using WindowsFormUI.Views;
using WindowsFormUI.Views.Moduls.Bankalar;
using WindowsFormUI.Views.Moduls.Cariler;
using WindowsFormUI.Views.Moduls.CekSenetler;
using WindowsFormUI.Views.Moduls.Companies;
using WindowsFormUI.Views.Moduls.Faturalar;
using WindowsFormUI.Views.Moduls.Kasalar;
using WindowsFormUI.Views.Moduls.Stoklar;
using WindowsFormUI.Views.Moduls.Users;

namespace WindowsFormUI
{
    public static class Program
    {
        public static IContainer Container { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Transactions.TransactionManager.ImplicitDistributedTransactions = true;
            Container = ConfigureContainer();
            ConfigureServices(new ServiceCollection());
            Application.Run(Container.Resolve<FrmLogin>());
        }
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new AutofacBusinessModule());
            builder.RegisterModule(new Core.DependencyResolvers.AutofacCoreModule.AutofacCoreModule());
            builder.RegisterType<FrmBase>().AsSelf();
            builder.RegisterType<FrmMdiBase>().AsSelf();
            builder.RegisterType<FrmLogin>().AsSelf();
            builder.RegisterType<FrmWelcome>().AsSelf();
            builder.RegisterType<FrmStok>().AsSelf();
            builder.RegisterType<FrmStokKart>().AsSelf();
            builder.RegisterType<FrmStokGrup>().AsSelf();
            builder.RegisterType<FrmStokListe>().AsSelf();
            builder.RegisterType<FrmCari>().AsSelf();
            builder.RegisterType<FrmCariKart>().AsSelf();
            builder.RegisterType<FrmCariGrup>().AsSelf();
            builder.RegisterType<FrmCariListe>().AsSelf();
            builder.RegisterType<FrmFatura>().AsSelf();
            builder.RegisterType<FrmFaturaKayit>().AsSelf();
            builder.RegisterType<FrmFaturaListe>().AsSelf();
            builder.RegisterType<FrmKasa>().AsSelf();
            builder.RegisterType<FrmKasaKart>().AsSelf();
            builder.RegisterType<FrmKasaKayit>().AsSelf();
            builder.RegisterType<FrmKasaListe>().AsSelf();
            builder.RegisterType<FrmBordroListe>().AsSelf();
            builder.RegisterType<FrmCekSenet>().AsSelf();
            builder.RegisterType<FrmEvrakAl>().AsSelf();
            builder.RegisterType<FrmMusteriyePortfoydenEvrakCik>().AsSelf();
            builder.RegisterType<FrmPortfoydekiEvraklar>().AsSelf();
            builder.RegisterType<FrmBorcEvrakCik>().AsSelf();
            builder.RegisterType<FrmBanka>().AsSelf();
            builder.RegisterType<FrmBankaKart>().AsSelf();
            builder.RegisterType<FrmBankaKayit>().AsSelf();
            builder.RegisterType<FrmBankaHareketListe>().AsSelf();
            builder.RegisterType<FrmUser>().AsSelf();
            builder.RegisterType<FrmClaim>().AsSelf();
            builder.RegisterType<FrmCompany>().AsSelf();
            builder.RegisterType<FrmCompanyMdi>().AsSelf();
            builder.RegisterType<FrmCompanyTransfer>().AsSelf();
            builder.RegisterType<FrmUserList>().AsSelf();

            return builder.Build();
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDependencyResolvers(new CoreModule());
        }
    }
}