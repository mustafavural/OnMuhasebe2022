using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Security;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CekSenetMusteriManager : ICekSenetMusteriService
    {
        private readonly ICekSenetMusteriDal _cekSenetMusteriDal;
        private readonly ICariService _cariService;

        public CekSenetMusteriManager(ICekSenetMusteriDal borcCekSenetDal, ICariService cariService)
        {
            _cekSenetMusteriDal = borcCekSenetDal;
            _cariService = cariService;
        }

        #region BusinessRules
        private IResult KontrolEvrakNoZatenVarMi(string no)
        {
            return Get(b => b.No == no) == null ? new SuccessResult() : new ErrorResult(Messages.CekSenetMessages.EvrakNoZatenMevcut);
        }

        private IResult KontrolEvrakIdMevcutMu(int id)
        {
            return Get(b => b.Id == id) != null ? new SuccessResult() : new ErrorResult(Messages.CekSenetMessages.EvrakYok);
        }
        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        private CekSenetMusteri Get(Expression<Func<CekSenetMusteri, bool>> filter)
        {
            return _cekSenetMusteriDal.Get(filter);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        private List<CekSenetMusteri> GetAll(Expression<Func<CekSenetMusteri, bool>>? filter = null)
        {
            return _cekSenetMusteriDal.GetList(filter);
        }

        public IDataResult<CekSenetMusteri> GetById(int id)
        {
            return new SuccessDataResult<CekSenetMusteri>(Get(b => b.Id == id));
        }

        public IDataResult<CekSenetMusteri> GetByNo(string no)
        {
            return new SuccessDataResult<CekSenetMusteri>(Get(b => b.No == no));
        }

        public IDataResult<CekSenetMusteri> GetByAsilBorclu(string asilBorclu)
        {
            return new SuccessDataResult<CekSenetMusteri>(Get(b => b.AsilBorclu == asilBorclu));
        }

        public IDataResult<List<CekSenetMusteri>> GetListByBordroTediye(int tediyeId)
        {
            return new SuccessDataResult<List<CekSenetMusteri>>(GetAll(b => b.BordroTediyeId == tediyeId));
        }

        public IDataResult<List<CekSenetMusteri>> GetListByBordroTahsilat(int tahsilatId)
        {
            return new SuccessDataResult<List<CekSenetMusteri>>(GetAll(b => b.BordroTahsilatId == tahsilatId));
        }

        public IDataResult<List<CekSenetMusteri>> GetListByVade(DateTime vade)
        {
            return new SuccessDataResult<List<CekSenetMusteri>>(GetAll(b => b.Vade == vade));
        }

        public IDataResult<List<CekSenetMusteri>> GetListPortfoydekiler()
        {
            return new SuccessDataResult<List<CekSenetMusteri>>(GetAll(m => m.BordroTediyeId == null));
        }

        [PerformanceAspect(5)]
        public IDataResult<List<CekSenetMusteri>> GetList(Expression<Func<CekSenetMusteri, bool>>? filter = null)
        {
            return new SuccessDataResult<List<CekSenetMusteri>>(GetAll(filter));
        }

        [SecuredOperation("Add,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriCekSenetService.Get")]
        public IResult Add(CekSenetMusteri entity)
        {
            var result = BusinessRules.Run(KontrolEvrakNoZatenVarMi(entity.No));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _cekSenetMusteriDal.Add(entity);
            return new SuccessResult(Messages.CekSenetMessages.MusteriCekSenetEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriCekSenetService.Get")]
        public IResult Delete(CekSenetMusteri entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdMevcutMu(entity.Id));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _cekSenetMusteriDal.Delete(entity);
            return new SuccessResult(Messages.CekSenetMessages.MusteriCekSenetSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriCekSenetService.Get")]
        public IResult Update(CekSenetMusteri entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdMevcutMu(entity.Id));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _cekSenetMusteriDal.Update(entity);
            return new SuccessResult(Messages.CekSenetMessages.MusteriCekSenetGuncellendi);
        }
    }
}