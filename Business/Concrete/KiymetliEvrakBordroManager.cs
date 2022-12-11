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
    public class KiymetliEvrakBordroManager : IKiymetliEvrakBordroService
    {
        private readonly IKiymetliEvrakBordroDal _kiymetliEvrakBordroDal;
        private readonly ICariService _cariService;
        private readonly ICariHareketService _cariHareketService;

        public KiymetliEvrakBordroManager(IKiymetliEvrakBordroDal kiymetliEvrakBordroDal, ICariService cariService, ICariHareketService cariHareketService)
        {
            _kiymetliEvrakBordroDal = kiymetliEvrakBordroDal;
            _cariService = cariService;
            _cariHareketService = cariHareketService;
        }

        #region BusinessRules

        private IResult KontrolBordroIdZatenVarMi(int id)
        {
            return Get(k => k.Id == id) == null ? new SuccessResult() : new ErrorResult(Messages.KiymetliEvrakMessages.BordroZatenVar);
        }

        private IResult KontrolCariIdMevcutMu(int cariId)
        {
            return _cariService.GetById(cariId).Data != null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.CariYok);
        }

        private IResult KontrolBordroNoZatenVarMi(string no)
        {
            return Get(k => k.No == no) == null ? new SuccessResult() : new ErrorResult(Messages.KiymetliEvrakMessages.BordroNoZatenMevcut);
        }

        private IResult KontrolBordroBosMu(int id)
        {
            return _kiymetliEvrakBordroDal.GetBorcCekSenetListById(id) == null &&
                _kiymetliEvrakBordroDal.GetMusteriTahsilatCekSenetListById(id) == null &&
                _kiymetliEvrakBordroDal.GetMusteriTediyeCekSenetListById(id) == null ? new SuccessResult() : new ErrorResult(Messages.KiymetliEvrakMessages.BordroKullanimda);
        }

        private IResult KontrolBordroIdMevcutMu(int id)
        {
            return _kiymetliEvrakBordroDal.GetById(id) != null ? new SuccessResult() : new ErrorResult(Messages.KiymetliEvrakMessages.EvrakYok);
        }
        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        private KiymetliEvrakBordro Get(Expression<Func<KiymetliEvrakBordro, bool>> filter)
        {
            var bordro = _kiymetliEvrakBordroDal.Get(filter);
            bordro.CariHareket = _cariHareketService.GetById(bordro.Id).Data;
            bordro.Cari = bordro.CariHareket.Cari;
            return bordro;
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        private List<KiymetliEvrakBordro> GetAll(Expression<Func<KiymetliEvrakBordro, bool>>? filter = null)
        {
            var bordrolar=_kiymetliEvrakBordroDal.GetList(filter);
            bordrolar.ForEach(k => k.CariHareket = _cariHareketService.GetById(k.Id).Data);
            bordrolar.ForEach(k => k.Cari = k.CariHareket.Cari);
            return bordrolar;
        }

        public IDataResult<KiymetliEvrakBordro> GetById(int id)
        {
            return new SuccessDataResult<KiymetliEvrakBordro>(Get(k=>k.Id== id));
        }

        public IDataResult<KiymetliEvrakBordro> GetByNo(string no)
        {
            return new SuccessDataResult<KiymetliEvrakBordro>(Get(k => k.No == no));
        }

        public IDataResult<List<KiymetliEvrakBordro>> GetListByTur(string tur)
        {
            return new SuccessDataResult<List<KiymetliEvrakBordro>>(GetAll(k => k.Tur == tur));
        }

        public IDataResult<List<KiymetliEvrakBordro>> GetListByCariId(int cariId)
        {
            return new SuccessDataResult<List<KiymetliEvrakBordro>>(GetAll(k => k.CariId == cariId));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<BorcCekSenet>> GetBorcCekSenetListById(int id)
        {
            return new SuccessDataResult<List<BorcCekSenet>>(_kiymetliEvrakBordroDal.GetBorcCekSenetListById(id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<MusteriCekSenet>> GetMusteriTahsilatCekSenetListById(int id)
        {
            return new SuccessDataResult<List<MusteriCekSenet>>(_kiymetliEvrakBordroDal.GetMusteriTahsilatCekSenetListById(id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<MusteriCekSenet>> GetMusteriTediyeCekSenetListById(int id)
        {
            return new SuccessDataResult<List<MusteriCekSenet>>(_kiymetliEvrakBordroDal.GetMusteriTediyeCekSenetListById(id));
        }

        public IDataResult<List<KiymetliEvrakBordro>> GetListBetweenTarihler(DateTime ilk, DateTime son)
        {
            return new SuccessDataResult<List<KiymetliEvrakBordro>>(GetAll(k => k.Tarih >= ilk && k.Tarih <= son));
        }

        [PerformanceAspect(5)]
        public IDataResult<List<KiymetliEvrakBordro>> GetList(Expression<Func<KiymetliEvrakBordro, bool>>? filter = null)
        {
            return new SuccessDataResult<List<KiymetliEvrakBordro>>(GetAll(filter));
        }

        [SecuredOperation("Add,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IKiymetliEvrakBordroService.Get")]
        public IResult Add(KiymetliEvrakBordro entity)
        {
            var result = BusinessRules.Run(KontrolBordroIdZatenVarMi(entity.Id),
                                           KontrolCariIdMevcutMu(entity.CariId),
                                           KontrolBordroNoZatenVarMi(entity.No));
            if(!result.IsSuccess)
                return new ErrorResult(result.Message);
            
            _kiymetliEvrakBordroDal.Add(entity);
            return new SuccessResult(Messages.KiymetliEvrakMessages.BordroCariyeIslendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IKiymetliEvrakBordroService.Get")]
        public IResult Delete(KiymetliEvrakBordro entity)
        {
            var result = BusinessRules.Run(KontrolBordroIdMevcutMu(entity.Id),
                                           KontrolBordroBosMu(entity.Id));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);
            
            _kiymetliEvrakBordroDal.Delete(entity);
            return new SuccessResult(Messages.KiymetliEvrakMessages.BordroSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IKiymetliEvrakBordroService.Get")]
        public IResult Update(KiymetliEvrakBordro entity)
        {
            var result = BusinessRules.Run(KontrolCariIdMevcutMu(entity.CariId));

            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _kiymetliEvrakBordroDal.Update(entity);
            return new SuccessResult(Messages.KiymetliEvrakMessages.BordroGuncellendi);
        }
    }
}