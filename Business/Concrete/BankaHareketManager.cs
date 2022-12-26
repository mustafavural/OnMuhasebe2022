using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Security;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Extensions;
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
        private readonly IBankaService _bankaService;

        public BankaHareketManager(IBankaHareketDal bankaHareketDal, ICariHareketService cariHareketService, IBankaService bankaService)
        {
            _bankaHareketDal = bankaHareketDal;
            _cariHareketService = cariHareketService;
            _bankaService = bankaService;
        }

        private BankaHareket Get(Expression<Func<BankaHareket, bool>> filter)
        {
            var bankaHareket = _bankaHareketDal.Get(filter);
            if (bankaHareket != null)
            {
                bankaHareket.Banka = _bankaService.GetById(bankaHareket.BankaId).Data;
                bankaHareket.CariHareket = _cariHareketService.GetById(bankaHareket.Id).Data;
            }
            return bankaHareket;
        }

        private List<BankaHareket> GetAll(Expression<Func<BankaHareket, bool>>? filter = null)
        {
            var bankaHareketler = _bankaHareketDal.GetList(filter);
            if (bankaHareketler.Count > 0)
            {
                bankaHareketler.ForEach(b => b.Banka = _bankaService.GetById(b.BankaId).Data);
                bankaHareketler.ForEach(b => b.CariHareket = _cariHareketService.GetById(b.Id).Data);
            }
            return bankaHareketler;
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<BankaHareket> GetById(int entityId)
        {
            return new SuccessDataResult<BankaHareket>(Get(s => s.Id == entityId));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<BankaHareket> GetByEvrakNo(string evrakNo)
        {
            return new SuccessDataResult<BankaHareket>(Get(s => s.EvrakNo == evrakNo));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<int> GetNewRowsEvrakNo()
        {
            var hareket = GetAll().MaxBy(s => s.Id);
            return new SuccessDataResult<int>(hareket == null ? 1 : hareket.EvrakNo[1..].Trim('0').ToInt() + 1);
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<BankaHareket>> GetListByBankaHesapId(int bankaHesapId)
        {
            return new SuccessDataResult<List<BankaHareket>>(GetAll(s => s.BankaId == bankaHesapId));
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<BankaHareket>> GetListBetweenFiyatlar(decimal min, decimal max)
        {
            return new SuccessDataResult<List<BankaHareket>>(GetAll(s => s.GirenCikanMiktar >= min && s.GirenCikanMiktar <= max));
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<BankaHareket>> GetListBetweenTarihler(DateTime first, DateTime last)
        {
            return new SuccessDataResult<List<BankaHareket>>(GetAll(s => s.Tarih >= first && s.Tarih <= last));
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(1)]
        [LogAspect(typeof(DatabaseLogger))]
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