using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
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
        public IDataResult<BankaHareket> GetById(int entityId)
        {
            var bankaHareket = _bankaHareketDal.GetById(entityId);
            bankaHareket.CariHareket = _cariHareketService.GetById(entityId).Data;
            return new SuccessDataResult<BankaHareket>(bankaHareket);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<BankaHareket> GetByEvrakNo(string evrakNo)
        {
            var bankaHareket = _bankaHareketDal.Get(s => s.EvrakNo == evrakNo);
            bankaHareket.CariHareket = _cariHareketService.GetById(bankaHareket.Id).Data;
            return new SuccessDataResult<BankaHareket>(bankaHareket);
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<BankaHareket>> GetListByCariId(int cariId)
        {
            var bankaHareketler = _bankaHareketDal.GetList(s => s.CariId == cariId);
            var cariHareket = _cariHareketService.GetList(c => bankaHareketler.Select(b => b.Id).Contains(c.Id)).Data;
            foreach (var item in bankaHareketler)
            {
                item.CariHareket = cariHareket.Where(c => c.Id == item.Id).SingleOrDefault();
            }
            return new SuccessDataResult<List<BankaHareket>>(bankaHareketler);
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<BankaHareket>> GetListByBankaHesapId(int bankaHesapId)
        {
            var bankaHareketler = _bankaHareketDal.GetList(s => s.BankaHesapId == bankaHesapId);
            var cariHareket = _cariHareketService.GetList(c => bankaHareketler.Select(b => b.Id).Contains(c.Id)).Data;
            foreach (var item in bankaHareketler)
            {
                item.CariHareket = cariHareket.Where(c => c.Id == item.Id).SingleOrDefault();
            }
            return new SuccessDataResult<List<BankaHareket>>(bankaHareketler);
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<BankaHareket>> GetListBetweenFiyatlar(decimal min, decimal max)
        {
            var bankaHareketler = _bankaHareketDal.GetList(s => s.GirenCikanMiktar >= min && s.GirenCikanMiktar <= max);
            var cariHareket = _cariHareketService.GetList(c => bankaHareketler.Select(b => b.Id).Contains(c.Id)).Data;
            foreach (var item in bankaHareketler)
            {
                item.CariHareket = cariHareket.Where(c => c.Id == item.Id).SingleOrDefault();
            }
            return new SuccessDataResult<List<BankaHareket>>(bankaHareketler);
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<BankaHareket>> GetListBetweenTarihler(DateTime first, DateTime last)
        {
            var bankaHareketler = _bankaHareketDal.GetList(s => s.Tarih >= first && s.Tarih <= last);
            var cariHareket = _cariHareketService.GetList(c => bankaHareketler.Select(b => b.Id).Contains(c.Id)).Data;
            foreach (var item in bankaHareketler)
            {
                item.CariHareket = cariHareket.Where(c => c.Id == item.Id).SingleOrDefault();
            }
            return new SuccessDataResult<List<BankaHareket>>(bankaHareketler);
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<BankaHareket>> GetList(Expression<Func<BankaHareket, bool>>? filter = null)
        {
            var bankaHareketler = _bankaHareketDal.GetList(filter);
            var cariHareket = _cariHareketService.GetList(c => bankaHareketler.Select(b => b.Id).Contains(c.Id)).Data;
            foreach (var item in bankaHareketler)
            {
                item.CariHareket = cariHareket.Where(c => c.Id == item.Id).SingleOrDefault();
            }
            return new SuccessDataResult<List<BankaHareket>>(bankaHareketler);
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