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
    public class DegerliEvrakManager : IDegerliEvrakService
    {
        private readonly IDegerliEvrakDal _degerliEvrakDal;
        private readonly ICariHareketService _cariHareketService;

        public DegerliEvrakManager(IDegerliEvrakDal degerliEvrakDal, ICariHareketService cariHareketService)
        {
            _degerliEvrakDal = degerliEvrakDal;
            _cariHareketService = cariHareketService;
        }

        #region BusinessRules
        private IResult KontrolKodZatenVarMi(string kod)
        {
            return _degerliEvrakDal.Get(s => s.Kod == kod) == null ? new SuccessResult() : new ErrorResult(Messages.DegerliEvrakMessages.KodZatenMevcut);
        }

        private IResult KontrolEvrakIdMevcutMu(int id)
        {
            return _degerliEvrakDal.GetById(id) == null ? new SuccessResult() : new ErrorResult(Messages.DegerliEvrakMessages.EvrakBulunamadi);
        }

        private IResult KontrolCariIdMevcutMu(int verilenCariId)
        {
            return _cariHareketService.GetById(verilenCariId).Data != null ? new SuccessResult() : new ErrorResult(Messages.DegerliEvrakMessages.CariBulunamadi);
        }
        #endregion

        private DegerliEvrak Get(Expression<Func<DegerliEvrak, bool>> filter)
        {
            var degerliEvrak = _degerliEvrakDal.Get(filter);
            if (degerliEvrak != null)
            {
                degerliEvrak.VerilenCariHareket = _cariHareketService.GetById(degerliEvrak.VerilenCariHareketId).Data;
            }
            return degerliEvrak;
        }

        private List<DegerliEvrak> GetAll(Expression<Func<DegerliEvrak, bool>>? filter = null)
        {
            var degerliEvraklar = _degerliEvrakDal.GetList(filter);
            if (degerliEvraklar.Count > 0)
            {
                degerliEvraklar.ForEach(d => d.VerilenCariHareket = _cariHareketService.GetById(d.VerilenCariHareketId).Data);
            }
            return degerliEvraklar;
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<DegerliEvrak> GetById(int id)
        {
            return new SuccessDataResult<DegerliEvrak>(Get(s => s.Id == id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<DegerliEvrak>> GetList(Expression<Func<DegerliEvrak, bool>>? filter = null)
        {
            return new SuccessDataResult<List<DegerliEvrak>>(GetAll(filter));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<DegerliEvrak> GetByKod(string kod)
        {
            return new SuccessDataResult<DegerliEvrak>(Get(s => s.Kod == kod));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<DegerliEvrak>> GetListByVerilenCariHareketId(int verilenCariHareketId)
        {
            return new SuccessDataResult<List<DegerliEvrak>>(GetAll(s => s.VerilenCariHareketId == verilenCariHareketId));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<DegerliEvrak>> GetListByVade(DateTime vade)
        {
            return new SuccessDataResult<List<DegerliEvrak>>(GetAll(s => s.Vade == vade));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<DegerliEvrak>> GetListByCikisTarihi(DateTime cikisTarihi)
        {
            return new SuccessDataResult<List<DegerliEvrak>>(GetAll(s => s.CikisTarihi == cikisTarihi));
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(DegerliEvrakValidator))]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IDegerliEvrakService.Get")]
        public IResult Add(DegerliEvrak entity)
        {
            var result = BusinessRules.Run(KontrolCariIdMevcutMu(entity.VerilenCariHareket.CariId),
                                           KontrolKodZatenVarMi(entity.Kod));

            if (!result.IsSuccess)
                return result;

            _cariHareketService.Add(entity.VerilenCariHareket);
            entity.VerilenCariHareketId = entity.VerilenCariHareket.Id;
            _degerliEvrakDal.Add(entity);
            return new SuccessResult(Messages.DegerliEvrakMessages.EvrakEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IDegerliEvrakService.Get")]
        public IResult Delete(DegerliEvrak entity)
        {
            var result = BusinessRules.Run(KontrolEvrakIdMevcutMu(entity.Id));

            if (!result.IsSuccess)
                return result;

            _degerliEvrakDal.Delete(new DegerliEvrak { Id = entity.Id });
            _cariHareketService.Delete(new CariHareket { Id = entity.VerilenCariHareketId });
            return new SuccessResult(Messages.DegerliEvrakMessages.EvrakSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IDegerliEvrakService.Get")]
        public IResult Update(DegerliEvrak entity)
        {
            var result = BusinessRules.Run(KontrolCariIdMevcutMu(entity.VerilenCariHareket.CariId),
                                           KontrolEvrakIdMevcutMu(entity.Id));

            if (!result.IsSuccess)
                return result;

            _degerliEvrakDal.Update(entity);
            _cariHareketService.Update(entity.VerilenCariHareket);
            return new SuccessResult(Messages.DegerliEvrakMessages.EvrakGuncellendi);
        }
    }
}