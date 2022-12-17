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
    public class KasaManager : IKasaService
    {
        private readonly IKasaDal _kasaDal;
        public KasaManager(IKasaDal kasaDal)
        {
            _kasaDal = kasaDal;
        }
        #region BusinessRules

        private IResult KontrolKasaIdZatenVarMi(int id)
        {
            return _kasaDal.Get(s => s.Id == id) == null ? new SuccessResult() : new ErrorResult(Messages.KasaMessages.KasaZatenMevcut);
        }

        private IResult KontrolKasaAdZatenVarMi(string ad)
        {
            return _kasaDal.Get(k => k.Ad == ad) == null ? new SuccessResult() : new ErrorResult(Messages.KasaMessages.KasaAdZatenMevcut);
        }

        private IResult KontrolKasaMevcutMu(int id)
        {
            return _kasaDal.Get(s => s.Id == id) != null ? new SuccessResult() : new ErrorResult(Messages.KasaMessages.KasaBulunamadi);
        }
        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Kasa> GetById(int id)
        {
            return new SuccessDataResult<Kasa>(_kasaDal.Get(s => s.Id == id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<Kasa>> GetList(Expression<Func<Kasa, bool>>? filter = null)
        {
            return new SuccessDataResult<List<Kasa>>(_kasaDal.GetList(filter));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Kasa> GetByAd(string kasaAd)
        {
            return new SuccessDataResult<Kasa>(_kasaDal.Get(s => s.Ad == kasaAd));
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(KasaValidator), Priority = 1)]
        [CacheRemoveAspect("IKasaService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Add(Kasa kasa)
        {
            IResult result = BusinessRules.Run(KontrolKasaAdZatenVarMi(kasa.Ad),
                                               KontrolKasaIdZatenVarMi(kasa.Id));

            if (!result.IsSuccess)
                return result;

            _kasaDal.Add(kasa);
            return new SuccessResult(Messages.KasaMessages.KasaEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [CacheRemoveAspect("IKasaService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(Kasa kasa)
        {
            IResult result = BusinessRules.Run(KontrolKasaMevcutMu(kasa.Id));

            if (!result.IsSuccess)
                return result;

            _kasaDal.Delete(kasa);
            return new SuccessResult(Messages.KasaMessages.KasaSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [ValidationAspect(typeof(KasaValidator), Priority = 1)]
        [CacheRemoveAspect("IKasaService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(Kasa kasa)
        {
            IResult result = BusinessRules.Run(KontrolKasaAdZatenVarMi(kasa.Ad),
                                               KontrolKasaMevcutMu(kasa.Id));

            if (!result.IsSuccess)
                return result;

            _kasaDal.Update(kasa);
            return new SuccessResult(Messages.KasaMessages.KasaGuncellendi);
        }
    }
}