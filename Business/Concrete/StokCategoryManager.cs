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
    public class StokCategoryManager : IStokCategoryService
    {
        private readonly IStokCategoryDal _stokCategoryDal;
        private readonly IStokGrupDal _stokGrupDal;

        public StokCategoryManager(IStokCategoryDal stokCategoryDal, IStokGrupDal stokGrupDal)
        {
            _stokCategoryDal = stokCategoryDal;
            _stokGrupDal = stokGrupDal;
        }

        #region BusinessRules
        private IResult KontrolStokCategoryIdVarMi(int id)
        {
            return _stokCategoryDal.Get(s => s.Id == id) != null ? new SuccessResult() : new ErrorResult(Messages.StokMessages.CategoryYok);
        }
        private IResult KontrolStokCategoryAdVarMi(string stokCategoryAd)
        {
            return _stokCategoryDal.Get(s => s.Ad == stokCategoryAd) == null ? new SuccessResult() : new ErrorResult(Messages.StokMessages.CategoryIsmiZatenMevcut);
        }
        private IResult KontrolStokCategoryKullaniliyorMu(int id)
        {
            return _stokGrupDal.GetList(g => g.StokCategoryId == id).Count == 0 ? new SuccessResult() : new ErrorResult(Messages.StokMessages.CategoryKullaniliyor);
        }
        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<StokCategory> GetById(int id)
        {
            return new SuccessDataResult<StokCategory>(_stokCategoryDal.Get(s => s.Id == id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<StokCategory>> GetList(Expression<Func<StokCategory, bool>>? filter = null)
        {
            return new SuccessDataResult<List<StokCategory>>(_stokCategoryDal.GetList());
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(StokCategoryValidator), Priority = 1)]
        [CacheRemoveAspect("IStokCategoryService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Add(StokCategory entity)
        {
            IResult result = BusinessRules.Run(KontrolStokCategoryAdVarMi(entity.Ad));
            if (!result.IsSuccess)
                return result;

            _stokCategoryDal.Add(entity);
            return new SuccessResult(Messages.StokMessages.CategoryEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [CacheRemoveAspect("IStokCategoryService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(StokCategory entity)
        {
            IResult result = BusinessRules.Run(KontrolStokCategoryIdVarMi(entity.Id),
                                               KontrolStokCategoryKullaniliyorMu(entity.Id));
            if (!result.IsSuccess)
                return result;

            _stokCategoryDal.Delete(new StokCategory { Id = entity.Id });
            return new SuccessResult(Messages.StokMessages.CategorySilindi);
        }

        [SecuredOperation("Update,Admin")]
        [CacheRemoveAspect("IStokCategoryService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(StokCategory entity)
        {
            IResult result = BusinessRules.Run(KontrolStokCategoryIdVarMi(entity.Id),
                                               KontrolStokCategoryAdVarMi(entity.Ad));
            if (!result.IsSuccess)
                return result;

            _stokCategoryDal.Update(entity);
            return new SuccessResult(Messages.StokMessages.CategoryGuncellendi);
        }
    }
}