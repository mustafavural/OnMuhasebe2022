using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Security;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CariCategoryManager : ICariCategoryService
    {
        private readonly ICariCategoryDal _cariCategoryDal;
        private readonly ICariGrupDal _cariGrupDal;

        public CariCategoryManager(ICariCategoryDal cariCategoryDal, ICariGrupDal cariGrupDal)
        {
            _cariCategoryDal = cariCategoryDal;
            _cariGrupDal = cariGrupDal;
        }
        #region BusinessRules
        private IResult KontrolCategoryIdVarMi(int id)
        {
            return _cariCategoryDal.Get(s => s.Id == id) != null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.CategoryYok);
        }
        private IResult KontrolCariCategoryAdVarMi(string cariCategoryAd)
        {
            return _cariCategoryDal.Get(s => s.Ad == cariCategoryAd) == null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.CategoryIsmiZatenMevcut);
        }
        private IResult KontrolCategoryKullanılıyorMu(int categoryId)
        {
            return _cariGrupDal.GetList(s => s.CariCategoryId == categoryId).Count == 0 ? new SuccessResult() : new ErrorResult(Messages.CariMessages.CategoryKullaniliyor);
        }
        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<CariCategory> GetById(int id)
        {
            return new SuccessDataResult<CariCategory>(_cariCategoryDal.Get(s => s.Id == id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<CariCategory>> GetList(Expression<Func<CariCategory, bool>>? filter = null)
        {
            return new SuccessDataResult<List<CariCategory>>(_cariCategoryDal.GetList(filter));
        }

        [SecuredOperation("Add,Admin")]
        [CacheRemoveAspect("ICariCategoryService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Add(CariCategory entity)
        {
            IResult result = BusinessRules.Run(KontrolCariCategoryAdVarMi(entity.Ad));
            if (!result.IsSuccess)
                return result;

            _cariCategoryDal.Add(entity);
            return new SuccessResult(Messages.CariMessages.CategoryEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [CacheRemoveAspect("ICariCategoryService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(CariCategory entity)
        {
            IResult result = BusinessRules.Run(KontrolCategoryIdVarMi(entity.Id),
                                               KontrolCategoryKullanılıyorMu(entity.Id));
            if (!result.IsSuccess)
                return result;

            _cariCategoryDal.Delete(entity);
            return new SuccessResult(Messages.CariMessages.CategorySilindi);
        }

        [SecuredOperation("Update,Admin")]
        [CacheRemoveAspect("ICariCategoryService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(CariCategory entity)
        {
            IResult result = BusinessRules.Run(KontrolCategoryIdVarMi(entity.Id),
                                               KontrolCariCategoryAdVarMi(entity.Ad));
            if (!result.IsSuccess)
                return result;

            _cariCategoryDal.Update(entity);
            return new SuccessResult(Messages.CariMessages.CategoryGuncellendi);
        }
    }
}