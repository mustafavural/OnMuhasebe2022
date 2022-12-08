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
    public class StokManager : IStokService
    {
        private readonly IStokDal _stokDal;
        public StokManager(IStokDal stokDal)
        {
            _stokDal = stokDal;
        }

        #region BusinessRules
        private IResult KontrolStokIdVarMi(int id)
        {
            return _stokDal.Get(s => s.Id == id) != null ? new SuccessResult() : new ErrorResult(Messages.StokMessages.StokYok);
        }
        private IResult KontrolStokAdZatenVarMi(string ad)
        {
            return _stokDal.Get(s => s.Ad == ad) == null ? new SuccessResult() : new ErrorResult(Messages.StokMessages.IsmiZatenMevcut);
        }
        private IResult KontrolStokBarkodZatenVarMi(string barkod)
        {
            return _stokDal.Get(s => s.Barkod == barkod) == null ? new SuccessResult() : new ErrorResult(Messages.StokMessages.BarkodZatenMevcut);
        }
        private IResult KontrolStokKodZatenVarMi(string kod)
        {
            return _stokDal.Get(s => s.Kod == kod) == null ? new SuccessResult() : new ErrorResult(Messages.StokMessages.KodZatenMevcut);
        }
        private IResult KontrolStokGrupZatenVarMi(StokGrup stokGrup)
        {
            return _stokDal.GetStokGrup(stokGrup.StokId, stokGrup.StokCategoryId) == null ? new SuccessResult() : new ErrorResult(Messages.StokMessages.StokVeCategoryZatenEslenik);
        }
        #endregion

        private Stok Get(Expression<Func<Stok, bool>> filter)
        {
            var result = _stokDal.Get(filter);
            if (result != null)
                result.StokCategoryler = _stokDal.GetStokCategoryler(result.Id);
            return result;
        }

        private List<Stok> GetAll(Expression<Func<Stok, bool>>? filter = null)
        {
            var result = _stokDal.GetList(filter);
            result?.ForEach(s => s.StokCategoryler = _stokDal.GetStokCategoryler(s.Id));
            return result;
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Stok> GetById(int stokId)
        {
            return new SuccessDataResult<Stok>(Get(s => s.Id == stokId));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Stok> GetByKod(string stokKod)
        {
            return new SuccessDataResult<Stok>(Get(s => s.Kod == stokKod));
        }

        public IDataResult<List<Stok>> GetListByCategoryId(int categoryId)
        {
            //var result = _stokDal.GetListByCategoryId(categoryId);
            //result?.ForEach(s => s.StokCategoryler = _stokDal.GetStokCategoryler(s.Id));
            //return new SuccessDataResult<List<Stok>>(result);
            throw new NotImplementedException();
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(duration: 1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Stok>> GetList(Expression<Func<Stok, bool>>? filter = null)
        {
            return new SuccessDataResult<List<Stok>>(GetAll(filter));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<StokGrup> GetStokGrup(int stokId, int stokCategoryId)
        {
            return new SuccessDataResult<StokGrup>(_stokDal.GetStokGrup(stokId, stokCategoryId));
        }

        [CacheRemoveAspect("IStokService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult AddCategoryToStok(StokGrup stokGrup)
        {
            IResult result = BusinessRules.Run(KontrolStokGrupZatenVarMi(stokGrup));

            if (!result.IsSuccess)
                return result;

            _stokDal.AddCategoryToStok(stokGrup);
            return new SuccessResult(Messages.StokMessages.CategoryeEklendi);
        }

        [CacheRemoveAspect("IStokService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult DeleteCategoryFromStok(StokGrup grup)
        {
            _stokDal.DeleteCategoryFromStok(grup);
            return new SuccessResult(Messages.StokMessages.CategorydenSilindi);
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(StokValidator), Priority = 1)]
        [CacheRemoveAspect("IStokService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Add(Stok stok)
        {
            IResult result = BusinessRules.Run(KontrolStokKodZatenVarMi(stok.Kod),
                                               KontrolStokBarkodZatenVarMi(stok.Barkod),
                                               KontrolStokAdZatenVarMi(stok.Ad));
            if (!result.IsSuccess)
                return result;

            _stokDal.Add(stok);
            return new SuccessResult(Messages.StokMessages.Eklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [CacheRemoveAspect("IStokService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(Stok stok)
        {
            IResult result = BusinessRules.Run(KontrolStokIdVarMi(stok.Id));
            if (!result.IsSuccess)
                return result;

            _stokDal.Delete(stok);
            return new SuccessResult(Messages.StokMessages.Silindi);
        }

        [SecuredOperation("Update,Admin")]
        [ValidationAspect(typeof(StokValidator), Priority = 1)]
        [CacheRemoveAspect("IStokService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(Stok stok)
        {
            IResult result = BusinessRules.Run(KontrolStokIdVarMi(stok.Id));
            if (!result.IsSuccess)
                return result;

            _stokDal.Update(stok);
            return new SuccessResult(Messages.StokMessages.Guncellendi);
        }
    }
}