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

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<DegerliEvrak> GetById(int id)
        {
            return new SuccessDataResult<DegerliEvrak>(_degerliEvrakDal.Get(s => s.Id == id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<DegerliEvrak>> GetList(Expression<Func<DegerliEvrak, bool>>? filter = null)
        {
            return new SuccessDataResult<List<DegerliEvrak>>(_degerliEvrakDal.GetList(filter));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<DegerliEvrak> GetByKod(string kod)
        {
            return new SuccessDataResult<DegerliEvrak>(_degerliEvrakDal.Get(s => s.Kod == kod));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<DegerliEvrak>> GetListByVerilenCariId(int verilenCariId)
        {
            return new SuccessDataResult<List<DegerliEvrak>>(_degerliEvrakDal.GetList(s => s.VerilenCariId == verilenCariId));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<DegerliEvrak>> GetListByVade(DateTime vade)
        {
            return new SuccessDataResult<List<DegerliEvrak>>(_degerliEvrakDal.GetList(s => s.Vade == vade));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<DegerliEvrak>> GetListByCikisTarihi(DateTime cikisTarihi)
        {
            return new SuccessDataResult<List<DegerliEvrak>>(_degerliEvrakDal.GetList(s => s.CikisTarihi == cikisTarihi));
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(DegerliEvrakValidator))]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IDegerliEvrakService.Get")]
        public IResult Add(DegerliEvrak entity)
        {
            var result = BusinessRules.Run(KontrolCariIdMevcutMu(entity.VerilenCariId ?? 0),
                                           KontrolKodZatenVarMi(entity.Kod));

            if (!result.IsSuccess)
                return result;

            entity.VerilenCariHareket = new CariHareket
            {
                Aciklama = entity.Aciklama,
                CariId = entity.VerilenCariId ?? 0,
                Tarih = entity.CikisTarihi,
                Tutar = entity.Tutar
            };
            _cariHareketService.Add(entity.VerilenCariHareket);
            entity.Id = entity.VerilenCariHareket.Id;
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
            _cariHareketService.Delete(new CariHareket { Id = entity.Id });
            return new SuccessResult(Messages.DegerliEvrakMessages.EvrakSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IDegerliEvrakService.Get")]
        public IResult Update(DegerliEvrak entity)
        {
            var result = BusinessRules.Run(KontrolCariIdMevcutMu(entity.VerilenCariId ?? 0),
                                           KontrolEvrakIdMevcutMu(entity.Id));

            if (!result.IsSuccess)
                return result;

            entity.VerilenCariHareket = new CariHareket
            {
                Aciklama = entity.Aciklama,
                CariId = entity.VerilenCariId ?? 0,
                Tarih = entity.CikisTarihi,
                Tutar = entity.Tutar,
                Id = entity.Id
            };
            _degerliEvrakDal.Update(entity);
            _cariHareketService.Update(entity.VerilenCariHareket);
            return new SuccessResult(Messages.DegerliEvrakMessages.EvrakGuncellendi);
        }
    }
}