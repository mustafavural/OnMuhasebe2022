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
    public class CekSenetBordroManager : ICekSenetBordroService
    {
        private readonly ICekSenetBordroDal _cekSenetBordroDal;
        private readonly ICariService _cariService;
        private readonly ICariHareketService _cariHareketService;

        public CekSenetBordroManager(ICekSenetBordroDal kiymetliEvrakBordroDal, ICariService cariService, ICariHareketService cariHareketService)
        {
            _cekSenetBordroDal = kiymetliEvrakBordroDal;
            _cariService = cariService;
            _cariHareketService = cariHareketService;
        }

        #region BusinessRules

        private IResult KontrolBordroIdZatenVarMi(int id)
        {
            return Get(k => k.Id == id) == null ? new SuccessResult() : new ErrorResult(Messages.CekSenetMessages.BordroZatenVar);
        }

        private IResult KontrolCariIdMevcutMu(int cariId)
        {
            return _cariService.GetById(cariId).Data != null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.CariYok);
        }

        private IResult KontrolBordroNoZatenVarMi(string no)
        {
            return Get(k => k.No == no) == null ? new SuccessResult() : new ErrorResult(Messages.CekSenetMessages.BordroNoZatenMevcut);
        }

        private IResult KontrolBordroBosMu(int id)
        {
            return _cekSenetBordroDal.GetBorcCekSenetListById(id) == null &&
                _cekSenetBordroDal.GetMusteriTahsilatCekSenetListById(id) == null &&
                _cekSenetBordroDal.GetMusteriTediyeCekSenetListById(id) == null ? new SuccessResult() : new ErrorResult(Messages.CekSenetMessages.BordroKullanimda);
        }

        private IResult KontrolBordroIdMevcutMu(int id)
        {
            return _cekSenetBordroDal.GetById(id) != null ? new SuccessResult() : new ErrorResult(Messages.CekSenetMessages.EvrakYok);
        }
        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        private CekSenetBordro Get(Expression<Func<CekSenetBordro, bool>> filter)
        {
            var bordro = _cekSenetBordroDal.Get(filter);
            if (bordro != null)
            {
                bordro.CariHareket = _cariHareketService.GetById(bordro.Id).Data;
                bordro.Cari = bordro.CariHareket.Cari;
            }
            return bordro;
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        private List<CekSenetBordro> GetAll(Expression<Func<CekSenetBordro, bool>>? filter = null)
        {
            var bordrolar = _cekSenetBordroDal.GetList(filter);
            if (bordrolar.Count > 0)
            {
                bordrolar.ForEach(k => k.CariHareket = _cariHareketService.GetById(k.Id).Data);
                bordrolar.ForEach(k => k.Cari = k.CariHareket.Cari);
            }
            return bordrolar;
        }

        public IDataResult<CekSenetBordro> GetById(int id)
        {
            return new SuccessDataResult<CekSenetBordro>(Get(k=>k.Id== id));
        }

        public IDataResult<CekSenetBordro> GetByNo(string no)
        {
            return new SuccessDataResult<CekSenetBordro>(Get(k => k.No == no));
        }

        public IDataResult<List<CekSenetBordro>> GetListByTur(string tur)
        {
            return new SuccessDataResult<List<CekSenetBordro>>(GetAll(k => k.Tur == tur));
        }

        public IDataResult<List<CekSenetBordro>> GetListByCariId(int cariId)
        {
            return new SuccessDataResult<List<CekSenetBordro>>(GetAll(k => k.CariId == cariId));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<CekSenetBorc>> GetBorcCekSenetListById(int id)
        {
            return new SuccessDataResult<List<CekSenetBorc>>(_cekSenetBordroDal.GetBorcCekSenetListById(id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<CekSenetMusteri>> GetMusteriTahsilatCekSenetListById(int id)
        {
            return new SuccessDataResult<List<CekSenetMusteri>>(_cekSenetBordroDal.GetMusteriTahsilatCekSenetListById(id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<CekSenetMusteri>> GetMusteriTediyeCekSenetListById(int id)
        {
            return new SuccessDataResult<List<CekSenetMusteri>>(_cekSenetBordroDal.GetMusteriTediyeCekSenetListById(id));
        }

        public IDataResult<List<CekSenetBordro>> GetListBetweenTarihler(DateTime ilk, DateTime son)
        {
            return new SuccessDataResult<List<CekSenetBordro>>(GetAll(k => k.Tarih >= ilk && k.Tarih <= son));
        }

        [PerformanceAspect(5)]
        public IDataResult<List<CekSenetBordro>> GetList(Expression<Func<CekSenetBordro, bool>>? filter = null)
        {
            return new SuccessDataResult<List<CekSenetBordro>>(GetAll(filter));
        }

        [SecuredOperation("Add,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IKiymetliEvrakBordroService.Get")]
        public IResult Add(CekSenetBordro entity)
        {
            var result = BusinessRules.Run(KontrolBordroIdZatenVarMi(entity.Id),
                                           KontrolCariIdMevcutMu(entity.CariId),
                                           KontrolBordroNoZatenVarMi(entity.No));
            if(!result.IsSuccess)
                return new ErrorResult(result.Message);
            
            _cekSenetBordroDal.Add(entity);
            return new SuccessResult(Messages.CekSenetMessages.BordroCariyeIslendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IKiymetliEvrakBordroService.Get")]
        public IResult Delete(CekSenetBordro entity)
        {
            var result = BusinessRules.Run(KontrolBordroIdMevcutMu(entity.Id),
                                           KontrolBordroBosMu(entity.Id));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);
            
            _cekSenetBordroDal.Delete(entity);
            return new SuccessResult(Messages.CekSenetMessages.BordroSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IKiymetliEvrakBordroService.Get")]
        public IResult Update(CekSenetBordro entity)
        {
            var result = BusinessRules.Run(KontrolCariIdMevcutMu(entity.CariId));

            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _cekSenetBordroDal.Update(entity);
            return new SuccessResult(Messages.CekSenetMessages.BordroGuncellendi);
        }
    }
}