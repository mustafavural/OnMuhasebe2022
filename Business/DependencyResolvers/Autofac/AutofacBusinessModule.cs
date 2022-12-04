using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            // SERVICES =====>>>>>> MANAGERS
            builder.RegisterType<StokManager>().As<IStokService>();
            builder.RegisterType<StokHareketManager>().As<IStokHareketService>();
            builder.RegisterType<StokCategoryManager>().As<IStokCategoryService>();

            builder.RegisterType<CariManager>().As<ICariService>();
            builder.RegisterType<CariHareketManager>().As<ICariHareketService>();
            builder.RegisterType<CariCategoryManager>().As<ICariCategoryService>();

            builder.RegisterType<FaturaManager>().As<IFaturaService>();

            builder.RegisterType<KasaManager>().As<IKasaService>();
            builder.RegisterType<KasaHareketManager>().As<IKasaHareketService>();

            builder.RegisterType<DegerliEvrakManager>().As<IDegerliEvrakService>();
            builder.RegisterType<MusteriEvrakManager>().As<IMusteriEvrakService>();

            builder.RegisterType<BankaHesapManager>().As<IBankaHesapService>();
            builder.RegisterType<BankaHareketManager>().As<IBankaHareketService>();

            builder.RegisterType<AdresManager>().As<IAdresService>();
            builder.RegisterType<IlceManager>().As<IIlceService>();
            builder.RegisterType<SehirManager>().As<ISehirService>();


            //IDataAccessLayer   ========>>>>>>>>>>>>>   EFDataAccessLayer
            builder.RegisterType<EfStokDal>().As<IStokDal>();
            builder.RegisterType<EfStokCategoryDal>().As<IStokCategoryDal>();
            builder.RegisterType<EfStokGrupDal>().As<IStokGrupDal>();
            builder.RegisterType<EfStokHareketDal>().As<IStokHareketDal>();

            builder.RegisterType<EfCariDal>().As<ICariDal>();
            builder.RegisterType<EfCariCategoryDal>().As<ICariCategoryDal>();
            builder.RegisterType<EfCariGrupDal>().As<ICariGrupDal>();
            builder.RegisterType<EfCariHareketDal>().As<ICariHareketDal>();

            builder.RegisterType<EfFaturaDal>().As<IFaturaDal>();

            builder.RegisterType<EfKasaDal>().As<IKasaDal>();
            builder.RegisterType<EfKasaHareketDal>().As<IKasaHareketDal>();

            builder.RegisterType<EfDegerliEvrakDal>().As<IDegerliEvrakDal>();
            builder.RegisterType<EfMusteriEvrakDal>().As<IMusteriEvrakDal>();

            builder.RegisterType<EfBankaHesapDal>().As<IBankaHesapDal>();
            builder.RegisterType<EfBankaHareketDal>().As<IBankaHareketDal>();

            builder.RegisterType<EfAdresDal>().As<IAdresDal>();
            builder.RegisterType<EfIlceDal>().As<IIlceDal>();
            builder.RegisterType<EfSehirDal>().As<ISehirDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}