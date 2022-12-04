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
        private readonly IBankaHesapDal _bankaHesapDal;
        private readonly IBankaHareketService _bankaHareketService;

        public BankaHesapManager(IBankaHesapDal bankaHesapDal, IBankaHareketService bankaHareketService)
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
        public IDataResult<BankaHesap> GetById(int id)
        {
            return new SuccessDataResult<BankaHesap>(_bankaHesapDal.Get(s => s.Id == id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<BankaHesap>> GetList(Expression<Func<BankaHesap, bool>>? filter = null)
        {
            return new SuccessDataResult<List<BankaHesap>>(_bankaHesapDal.GetList(filter));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<BankaHesap> GetByHesapNo(string hesapNo)
        {
            return new SuccessDataResult<BankaHesap>(_bankaHesapDal.Get(s => s.HesapNo == hesapNo));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<decimal> GetHesapBakiye(int hesapId)
        {
            return new SuccessDataResult<decimal>(_bankaHareketService.GetList(s => s.BankaHesapId == hesapId).Data.Sum(s => s.GirenCikanMiktar));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<BankaHesap>> GetListByBankaAd(string bankaAd)
        {
            return new SuccessDataResult<List<BankaHesap>>(_bankaHesapDal.GetList(s => s.BankaAd == bankaAd));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<BankaHesap>> GetListByBankaSubeAd(string bankaSubeAd)
        {
            return new SuccessDataResult<List<BankaHesap>>(_bankaHesapDal.GetList(s => s.BankaSubeAd == bankaSubeAd));
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(BankaHesapValidator), Priority = 1)]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IBankaHesapService.Get")]
        public IResult Add(BankaHesap bankaHesap)
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
        public IResult Delete(BankaHesap bankaHesap)
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
        public IResult Update(BankaHesap bankaHesap)
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