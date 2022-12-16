using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Security;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class BankaHesapManager : IBankaHesapService
    {
        private readonly IBankaDal _bankaHesapDal;
        private readonly IBankaHareketService _bankaHareketService;

        public BankaHesapManager(IBankaDal bankaHesapDal, IBankaHareketService bankaHareketService)
        {
            _bankaHesapDal = bankaHesapDal;
            _bankaHareketService = bankaHareketService;
        }

        #region BusinessRules

        private IResult BankaHesapZatenVarmi(string hesapNo)
        {
            return _bankaHesapDal.Get(s => s.HesapNo == hesapNo) == null ? new SuccessResult() : new ErrorResult(Messages.BankaMessages.HesapZatenVar);
        }

        private IResult BankaHesapIdMevcutMu(int id)
        {
            return _bankaHesapDal.GetById(id) != null ? new SuccessResult() : new ErrorResult(Messages.BankaMessages.HesapIdBulunamadi);
        }

        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Banka> GetById(int id)
        {
            return new SuccessDataResult<Banka>(_bankaHesapDal.Get(s => s.Id == id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<Banka>> GetList(Expression<Func<Banka, bool>>? filter = null)
        {
            return new SuccessDataResult<List<Banka>>(_bankaHesapDal.GetList(filter));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Banka> GetByHesapNo(string hesapNo)
        {
            return new SuccessDataResult<Banka>(_bankaHesapDal.Get(s => s.HesapNo == hesapNo));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<decimal> GetHesapBakiye(int hesapId)
        {
            return new SuccessDataResult<decimal>(_bankaHareketService.GetList(s => s.BankaId == hesapId).Data.Sum(s => s.GirenCikanMiktar));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<Banka>> GetListByBankaAd(string bankaAd)
        {
            return new SuccessDataResult<List<Banka>>(_bankaHesapDal.GetList(s => s.BankaAd == bankaAd));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<Banka>> GetListByBankaSubeAd(string bankaSubeAd)
        {
            return new SuccessDataResult<List<Banka>>(_bankaHesapDal.GetList(s => s.BankaSubeAd == bankaSubeAd));
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(BankaHesapValidator), Priority = 1)]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IBankaHesapService.Get")]
        public IResult Add(Banka bankaHesap)
        {
            var result = BusinessRules.Run(BankaHesapZatenVarmi(bankaHesap.HesapNo));
            if (!result.IsSuccess)
                return result;

            _bankaHesapDal.Add(bankaHesap);
            return new SuccessResult(Messages.BankaMessages.HesapEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IBankaHesapService.Get")]
        public IResult Delete(Banka bankaHesap)
        {
            var result = BusinessRules.Run(BankaHesapIdMevcutMu(bankaHesap.Id));
            if (!result.IsSuccess)
                return result;

            _bankaHesapDal.Delete(bankaHesap);
            return new SuccessResult(Messages.BankaMessages.HesapSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [ValidationAspect(typeof(BankaHesapValidator), Priority = 1)]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IBankaHesapService.Get")]
        public IResult Update(Banka bankaHesap)
        {
            var result = BusinessRules.Run(BankaHesapIdMevcutMu(bankaHesap.Id),
                                           BankaHesapZatenVarmi(bankaHesap.HesapNo));
            if (!result.IsSuccess)
                return result;

            _bankaHesapDal.Update(bankaHesap);
            return new SuccessResult(Messages.BankaMessages.HesapGuncellendi);
        }
    }
}