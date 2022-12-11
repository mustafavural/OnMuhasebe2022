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
    public class MusteriCekSenetManager : IMusteriCekSenetService
    {
        private readonly IMusteriCekSenetDal _borcCekSenetDal;
        private readonly IKiymetliEvrakBordroService _kiymetliEvrakBordroService;

        public MusteriCekSenetManager(IMusteriCekSenetDal borcCekSenetDal, IKiymetliEvrakBordroService kiymetliEvrakBordroService)
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

        private IResult KontrolBordroIdMevcutMu(int bordroId)
        {
            return _kiymetliEvrakBordroService.GetById(bordroId) != null ? new SuccessResult() : new ErrorResult(Messages.KiymetliEvrakMessages.BordroNumarasiBulunamadi);
        }

        private IResult KontrolEvrakIdMevcutMu(int id)
        {
            return Get(b => b.Id == id) != null ? new SuccessResult() : new ErrorResult(Messages.KiymetliEvrakMessages.EvrakYok);
        }
        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        private MusteriCekSenet Get(Expression<Func<MusteriCekSenet, bool>> filter)
        {
            return _borcCekSenetDal.Get(filter);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        private List<MusteriCekSenet> GetAll(Expression<Func<MusteriCekSenet, bool>>? filter = null)
        {
            return _borcCekSenetDal.GetList(filter);
        }

        public IDataResult<MusteriCekSenet> GetById(int id)
        {
            return new SuccessDataResult<MusteriCekSenet>(Get(b => b.Id == id));
        }

        public IDataResult<MusteriCekSenet> GetByNo(string no)
        {
            return new SuccessDataResult<MusteriCekSenet>(Get(b => b.No == no));
        }

        public IDataResult<MusteriCekSenet> GetByAsilBorclu(string asilBorclu)
        {
            return new SuccessDataResult<MusteriCekSenet>(Get(b => b.AsilBorclu == asilBorclu));
        }

        public IDataResult<List<MusteriCekSenet>> GetListByBordroTediye(int tediyeId)
        {
            return new SuccessDataResult<List<MusteriCekSenet>>(GetAll(b => b.BordroTediyeId == tediyeId));
        }

        public IDataResult<List<MusteriCekSenet>> GetListByBordroTahsilat(int tahsilatId)
        {
            return new SuccessDataResult<List<MusteriCekSenet>>(GetAll(b => b.BordroTahsilatId == tahsilatId));
        }

        public IDataResult<List<MusteriCekSenet>> GetListByVade(DateTime vade)
        {
            return new SuccessDataResult<List<MusteriCekSenet>>(GetAll(b => b.Vade == vade));
        }

        [PerformanceAspect(5)]
        public IDataResult<List<MusteriCekSenet>> GetList(Expression<Func<MusteriCekSenet, bool>>? filter = null)
        {
            return new SuccessDataResult<List<MusteriCekSenet>>(GetAll(filter));
        }

        [SecuredOperation("Add,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriCekSenetService.Get")]
        public IResult Add(MusteriCekSenet entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdZatenVarMi(entity.Id),
                                           KontrolBordroIdMevcutMu(entity.BordroTediyeId),
                                           KontrolEvrakNoZatenMevcutMu(entity.No));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _borcCekSenetDal.Add(entity);
            return new SuccessResult(Messages.KiymetliEvrakMessages.MusteriCekSenetEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriCekSenetService.Get")]
        public IResult Delete(MusteriCekSenet entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdMevcutMu(entity.Id));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _borcCekSenetDal.Delete(entity);
            return new SuccessResult(Messages.KiymetliEvrakMessages.MusteriCekSenetSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriCekSenetService.Get")]
        public IResult Update(MusteriCekSenet entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdMevcutMu(entity.Id),
                                           KontrolBordroIdMevcutMu(entity.BordroTediyeId));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _borcCekSenetDal.Update(entity);
            return new SuccessResult(Messages.KiymetliEvrakMessages.MusteriCekSenetGuncellendi);
        }
    }
}