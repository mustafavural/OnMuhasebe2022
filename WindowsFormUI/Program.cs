using Autofac;
using Business.DependencyResolvers.Autofac;
using Core.DependencyResolvers;
using Core.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using WindowsFormUI.Views;
using WindowsFormUI.Views.Moduls.Cariler;
using WindowsFormUI.Views.Moduls.DegerliEvraklar;
using WindowsFormUI.Views.Moduls.Faturalar;
using WindowsFormUI.Views.Moduls.Kasalar;
using WindowsFormUI.Views.Moduls.Stoklar;

namespace WindowsFormUI
{
    public static class Program
    {
        public static IContainer Container { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //System.Transactions.TransactionManager.ImplicitDistributedTransactions = true;
            Container = ConfigureContainer();
            ConfigureServices(new ServiceCollection());
            Application.Run(Container.Resolve<FrmWelcome>());
        }
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new AutofacBusinessModule());
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
            builder.RegisterType<FrmDegerliEvrak>().AsSelf();
            builder.RegisterType<FrmWelcome>().AsSelf();
            builder.RegisterType<FrmMdiBase>().AsSelf();
            builder.RegisterType<FrmBase>().AsSelf();

            return builder.Build();
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDependencyResolvers(new CoreModule());
        }
    }
}