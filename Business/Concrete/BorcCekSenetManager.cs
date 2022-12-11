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
    public class BorcCekSenetManager : IBorcCekSenetService
    {
        private readonly IBorcCekSenetDal _borcCekSenetDal;
        private readonly IKiymetliEvrakBordroService _kiymetliEvrakBordroService;

        public BorcCekSenetManager(IBorcCekSenetDal borcCekSenetDal, IKiymetliEvrakBordroService kiymetliEvrakBordroService)
        {
            _borcCekSenetDal = borcCekSenetDal;
            _kiymetliEvrakBordroService = kiymetliEvrakBordroService;
        }

        #region BusinessRules
        private IResult KontrolEvrakIdZatenVarMi(int id)
        {
            return Get(b => b.Id == id) == null ? new SuccessResult() : new ErrorResult(Messages.KiymetliEvrakMessages.EvrakZatenMevcut);
        }

        private IResult KontrolEvrakNoZatenMevcutMu(string no)
        {
            return Get(b => b.No == no) != null ? new SuccessResult() : new ErrorResult(Messages.KiymetliEvrakMessages.EvrakNoZatenMevcut);
        }

        private IResult KontrolBordroIdMevcutMu(int bordroTediyeId)
        {
            return _kiymetliEvrakBordroService.GetById(bordroTediyeId) != null ? new SuccessResult() : new ErrorResult(Messages.KiymetliEvrakMessages.BordroNumarasiBulunamadi);
        }

        private IResult KontrolEvrakIdMevcutMu(int id)
        {
            return Get(b => b.Id == id) != null ? new SuccessResult() : new ErrorResult(Messages.KiymetliEvrakMessages.EvrakYok);
        }
        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        private BorcCekSenet Get(Expression<Func<BorcCekSenet, bool>> filter)
        {
            return _borcCekSenetDal.Get(filter);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        private List<BorcCekSenet> GetAll(Expression<Func<BorcCekSenet, bool>>? filter = null)
        {
            return _borcCekSenetDal.GetList(filter);
        }

        public IDataResult<BorcCekSenet> GetById(int id)
        {
            return new SuccessDataResult<BorcCekSenet>(Get(b => b.Id == id));
        }

        public IDataResult<BorcCekSenet> GetByNo(string no)
        {
            return new SuccessDataResult<BorcCekSenet>(Get(b => b.No == no));
        }

        public IDataResult<List<BorcCekSenet>> GetListByBordroTediye(int tediyeId)
        {
            return new SuccessDataResult<List<BorcCekSenet>>(GetAll(b => b.BordroTediyeId == tediyeId));
        }

        public IDataResult<List<BorcCekSenet>> GetListByVade(DateTime vade)
        {
            return new SuccessDataResult<List<BorcCekSenet>>(GetAll(b => b.Vade == vade));
        }

        [PerformanceAspect(5)]
        public IDataResult<List<BorcCekSenet>> GetList(Expression<Func<BorcCekSenet, bool>>? filter = null)
        {
            return new SuccessDataResult<List<BorcCekSenet>>(GetAll(filter));
        }

        [SecuredOperation("Add,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IBorcCekSenetService.Get")]
        public IResult Add(BorcCekSenet entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdZatenVarMi(entity.Id),
                                           KontrolBordroIdMevcutMu(entity.BordroTediyeId),
                                           KontrolEvrakNoZatenMevcutMu(entity.No));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _borcCekSenetDal.Add(entity);
            return new SuccessResult(Messages.KiymetliEvrakMessages.BorcCekSenetEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IBorcCekSenetService.Get")]
        public IResult Delete(BorcCekSenet entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdMevcutMu(entity.Id));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _borcCekSenetDal.Delete(entity);
            return new SuccessResult(Messages.KiymetliEvrakMessages.BorcCekSenetSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IBorcCekSenetService.Get")]
        public IResult Update(BorcCekSenet entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdMevcutMu(entity.Id),
                                           KontrolBordroIdMevcutMu(entity.BordroTediyeId));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _borcCekSenetDal.Update(entity);
            return new SuccessResult(Messages.KiymetliEvrakMessages.BorcCekSenetGuncellendi);
        }
    }
}