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
    public class CekSenetBorcManager : ICekSenetBorcService
    {
        private readonly ICekSenetBorcDal _borcCekSenetDal;

        public CekSenetBorcManager(ICekSenetBorcDal borcCekSenetDal)
        {
            _borcCekSenetDal = borcCekSenetDal;
        }

        #region BusinessRules
        private IResult KontrolEvrakIdZatenVarMi(int id)
        {
            return Get(b => b.Id == id) == null ? new SuccessResult() : new ErrorResult(Messages.CekSenetMessages.EvrakZatenMevcut);
        }

        private IResult KontrolEvrakNoZatenMevcutMu(string no)
        {
            return Get(b => b.No == no) != null ? new SuccessResult() : new ErrorResult(Messages.CekSenetMessages.EvrakNoZatenMevcut);
        }

        private IResult KontrolEvrakIdMevcutMu(int id)
        {
            return Get(b => b.Id == id) != null ? new SuccessResult() : new ErrorResult(Messages.CekSenetMessages.EvrakYok);
        }
        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        private CekSenetBorc Get(Expression<Func<CekSenetBorc, bool>> filter)
        {
            return _borcCekSenetDal.Get(filter);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        private List<CekSenetBorc> GetAll(Expression<Func<CekSenetBorc, bool>>? filter = null)
        {
            return _borcCekSenetDal.GetList(filter);
        }

        public IDataResult<CekSenetBorc> GetById(int id)
        {
            return new SuccessDataResult<CekSenetBorc>(Get(b => b.Id == id));
        }

        public IDataResult<CekSenetBorc> GetByNo(string no)
        {
            return new SuccessDataResult<CekSenetBorc>(Get(b => b.No == no));
        }

        public IDataResult<List<CekSenetBorc>> GetListByBordroTediye(int tediyeId)
        {
            return new SuccessDataResult<List<CekSenetBorc>>(GetAll(b => b.BordroTediyeId == tediyeId));
        }

        public IDataResult<List<CekSenetBorc>> GetListByVade(DateTime vade)
        {
            return new SuccessDataResult<List<CekSenetBorc>>(GetAll(b => b.Vade == vade));
        }

        [PerformanceAspect(5)]
        public IDataResult<List<CekSenetBorc>> GetList(Expression<Func<CekSenetBorc, bool>>? filter = null)
        {
            return new SuccessDataResult<List<CekSenetBorc>>(GetAll(filter));
        }

        [SecuredOperation("Add,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("ICekSenetBorcService.Get")]
        public IResult Add(CekSenetBorc entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdZatenVarMi(entity.Id),
                                           KontrolEvrakNoZatenMevcutMu(entity.No));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _borcCekSenetDal.Add(entity);
            return new SuccessResult(Messages.CekSenetMessages.BorcCekSenetEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("ICekSenetBorcService.Get")]
        public IResult Delete(CekSenetBorc entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdMevcutMu(entity.Id));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _borcCekSenetDal.Delete(entity);
            return new SuccessResult(Messages.CekSenetMessages.BorcCekSenetSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("ICekSenetBorcService.Get")]
        public IResult Update(CekSenetBorc entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdMevcutMu(entity.Id));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _borcCekSenetDal.Update(entity);
            return new SuccessResult(Messages.CekSenetMessages.BorcCekSenetGuncellendi);
        }
    }
}