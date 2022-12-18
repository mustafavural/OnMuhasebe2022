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
    public class BankaManager : IBankaService
    {
        private readonly IBankaDal _bankaDal;

        public BankaManager(IBankaDal bankaDal)
        {
            _bankaDal = bankaDal;
        }

        #region BusinessRules

        private IResult KontrolBankaHesapIdMevcutMu(int id)
        {
            return _bankaDal.Get(s => s.Id == id) != null ? new SuccessResult() : new ErrorResult(Messages.BankaMessages.HesapBulunamadi);
        }

        private IResult KontrolHesapNoZatenVarmi(string hesapNo)
        {
            return _bankaDal.Get(s => s.HesapNo == hesapNo) == null ? new SuccessResult() : new ErrorResult(Messages.BankaMessages.HesapNoZatenVar);
        }

        private IResult KontrolIBANZatenVarMi(string iban)
        {
            return _bankaDal.Get(s => s.IBAN == iban) == null ? new SuccessResult() : new ErrorResult(Messages.BankaMessages.IBANZatenVar);
        }

        private IResult KontrolHesapKullaniliyorMu(int id)
        {
            return _bankaDal.KontrolHesapKullaniliyorMu(id) ? new SuccessResult() : new ErrorResult(Messages.BankaMessages.HesapKullaniliyor);
        }

        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        private Banka Get(Expression<Func<Banka, bool>> filter)
        {
            return _bankaDal.Get(filter);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        private List<Banka> GetAll(Expression<Func<Banka, bool>>? filter = null)
        {
            return _bankaDal.GetList(filter);
        }

        public IDataResult<Banka> GetById(int id)
        {
            return new SuccessDataResult<Banka>(Get(s => s.Id == id));
        }

        public IDataResult<List<Banka>> GetList(Expression<Func<Banka, bool>>? filter = null)
        {
            return new SuccessDataResult<List<Banka>>(GetAll(filter));
        }

        public IDataResult<Banka> GetByHesapNo(string hesapNo)
        {
            return new SuccessDataResult<Banka>(Get(s => s.HesapNo == hesapNo));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<decimal> GetHesapBakiye(int hesapId)
        {
            return new SuccessDataResult<decimal>(_bankaDal.GetHesapBakiye(hesapId));
        }

        public IDataResult<List<Banka>> GetListByBankaAd(string bankaAd)
        {
            return new SuccessDataResult<List<Banka>>(GetAll(s => s.BankaAd == bankaAd));
        }

        public IDataResult<List<Banka>> GetListByBankaSubeAd(string bankaSubeAd)
        {
            return new SuccessDataResult<List<Banka>>(GetAll(s => s.BankaSubeAd == bankaSubeAd));
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(BankaValidator), Priority = 1)]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IBankaHesapService.Get")]
        public IResult Add(Banka bankaHesap)
        {
            var result = BusinessRules.Run(KontrolHesapNoZatenVarmi(bankaHesap.HesapNo),
                                           KontrolIBANZatenVarMi(bankaHesap.IBAN));
            if (!result.IsSuccess)
                return result;

            _bankaDal.Add(bankaHesap);
            return new SuccessResult(Messages.BankaMessages.HesapEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IBankaHesapService.Get")]
        public IResult Delete(Banka bankaHesap)
        {
            var result = BusinessRules.Run(KontrolBankaHesapIdMevcutMu(bankaHesap.Id),
                                           KontrolHesapKullaniliyorMu(bankaHesap.Id));
            if (!result.IsSuccess)
                return result;

            _bankaDal.Delete(bankaHesap);
            return new SuccessResult(Messages.BankaMessages.HesapSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [ValidationAspect(typeof(BankaValidator), Priority = 1)]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IBankaHesapService.Get")]
        public IResult Update(Banka bankaHesap)
        {
            var result = BusinessRules.Run(KontrolBankaHesapIdMevcutMu(bankaHesap.Id));
            if (!result.IsSuccess)
                return result;

            _bankaDal.Update(bankaHesap);
            return new SuccessResult(Messages.BankaMessages.HesapGuncellendi);
        }
    }
}