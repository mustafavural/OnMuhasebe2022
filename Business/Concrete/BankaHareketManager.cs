using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Security;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class BankaHareketManager : IBankaHareketService
    {
        private readonly IBankaHareketDal _bankaHareketDal;
        private readonly ICariHareketService _cariHareketService;

        public BankaHareketManager(IBankaHareketDal bankaHareketDal, ICariHareketService cariHareketService)
        {
            _bankaHareketDal = bankaHareketDal;
            _cariHareketService = cariHareketService;
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        private BankaHareket Get(Expression<Func<BankaHareket, bool>> filter)
        {
            var bankaHareket = _bankaHareketDal.Get(filter);
            if (bankaHareket != null)
            {
                bankaHareket.CariHareket = _cariHareketService.GetById(bankaHareket.Id).Data;
            }
            return bankaHareket;
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(1)]
        [LogAspect(typeof(DatabaseLogger))]
        private List<BankaHareket> GetAll(Expression<Func<BankaHareket, bool>>? filter = null)
        {
            var bankaHareketler = _bankaHareketDal.GetList(filter);
            if (bankaHareketler.Count > 0)
            {
                bankaHareketler.ForEach(b => b.CariHareket = _cariHareketService.GetById(b.Id).Data);
            }
            return bankaHareketler;
        }

        public IDataResult<BankaHareket> GetById(int entityId)
        {
            return new SuccessDataResult<BankaHareket>(Get(s => s.Id == entityId));
        }

        public IDataResult<BankaHareket> GetByEvrakNo(string evrakNo)
        {
            return new SuccessDataResult<BankaHareket>(Get(s => s.EvrakNo == evrakNo));
        }

        public IDataResult<List<BankaHareket>> GetListByCariId(int cariId)
        {
            return new SuccessDataResult<List<BankaHareket>>(GetAll(s => s.CariId == cariId));
        }

        public IDataResult<List<BankaHareket>> GetListByBankaHesapId(int bankaHesapId)
        {
            return new SuccessDataResult<List<BankaHareket>>(GetAll(s => s.BankaId == bankaHesapId));
        }

        public IDataResult<List<BankaHareket>> GetListBetweenFiyatlar(decimal min, decimal max)
        {
            return new SuccessDataResult<List<BankaHareket>>(GetAll(s => s.GirenCikanMiktar >= min && s.GirenCikanMiktar <= max));
        }

        public IDataResult<List<BankaHareket>> GetListBetweenTarihler(DateTime first, DateTime last)
        {
            return new SuccessDataResult<List<BankaHareket>>(GetAll(s => s.Tarih >= first && s.Tarih <= last));
        }

        [PerformanceAspect(5)]
        public IDataResult<List<BankaHareket>> GetList(Expression<Func<BankaHareket, bool>>? filter = null)
        {
            return new SuccessDataResult<List<BankaHareket>>(GetAll(filter));
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(BankaHareketValidator), Priority = 1)]
        [CacheRemoveAspect("IBankaHareketService.Get")]
        [CacheRemoveAspect("ICariHareketService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Add(BankaHareket bankaHareket)
        {
            bankaHareket.CariHareket = new CariHareket
            {
                CariId = bankaHareket.CariId,
                Tarih = bankaHareket.Tarih,
                Tutar = bankaHareket.GirenCikanMiktar,
                Aciklama = bankaHareket.Aciklama
            };
            _cariHareketService.Add(bankaHareket.CariHareket);
            _bankaHareketDal.Add(bankaHareket);
            return new SuccessResult(Messages.BankaMessages.HesapHareketEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [CacheRemoveAspect("IBankaHareketService.Get")]
        [CacheRemoveAspect("ICariHareketService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(BankaHareket bankaHareket)
        {
            _bankaHareketDal.Delete(bankaHareket);
            _cariHareketService.Delete(bankaHareket.CariHareket);
            return new SuccessResult(Messages.BankaMessages.HesapHareketSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [ValidationAspect(typeof(BankaHareketValidator), Priority = 1)]
        [CacheRemoveAspect("IBankaHareketService.Get")]
        [CacheRemoveAspect("ICariHareketService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(BankaHareket bankaHareket)
        {
            _cariHareketService.Update(bankaHareket.CariHareket);
            _bankaHareketDal.Update(bankaHareket);
            return new SuccessResult(Messages.BankaMessages.HesapHareketGuncellendi);
        }
    }
}