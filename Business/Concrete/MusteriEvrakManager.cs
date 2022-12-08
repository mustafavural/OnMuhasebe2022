using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Security;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class MusteriEvrakManager : IMusteriEvrakService
    {
        private readonly IMusteriEvrakDal _musteriEvrakDal;
        private readonly ICariHareketService _cariHareketService;

        public MusteriEvrakManager(IMusteriEvrakDal musteriEvrakDal,
                                   ICariHareketService cariHareketService)
        {
            _musteriEvrakDal = musteriEvrakDal;
            _cariHareketService = cariHareketService;
        }

        private MusteriEvrak Get(Expression<Func<MusteriEvrak, bool>> filter)
        {
            var musteriEvrak = _musteriEvrakDal.Get(filter);
            if (musteriEvrak != null)
            {
                musteriEvrak.AlinanCariHareket = _cariHareketService.GetById(musteriEvrak.AlinanCariHareketId).Data;
                musteriEvrak.VerilenCariHareket = _cariHareketService.GetById(musteriEvrak.VerilenCariHareketId ?? 0).Data;
            }
            return musteriEvrak;
        }

        private List<MusteriEvrak> GetAll(Expression<Func<MusteriEvrak, bool>>? filter = null)
        {
            var musteriEvrakList = _musteriEvrakDal.GetList(filter);
            if (musteriEvrakList.Count > 0)
            {
                musteriEvrakList.ForEach(m => m.AlinanCariHareket = _cariHareketService.GetById(m.AlinanCariHareketId).Data);
                musteriEvrakList.ForEach(m => m.VerilenCariHareket = _cariHareketService.GetById(m.VerilenCariHareketId ?? 0).Data);
            }
            return musteriEvrakList;
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public new IDataResult<MusteriEvrak> GetById(int id)
        {
            return new SuccessDataResult<MusteriEvrak>(Get(s => s.Id == id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<MusteriEvrak>> GetListByAlinanCariHareketId(int alinanCariHareketId)
        {
            return new SuccessDataResult<List<MusteriEvrak>>(GetAll(s => s.AlinanCariHareketId == alinanCariHareketId));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<MusteriEvrak>> GetListByAlisTarihi(DateTime alisTarih)
        {
            return new SuccessDataResult<List<MusteriEvrak>>(GetAll(s => s.AlisTarihi == alisTarih));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<MusteriEvrak>> GetListByAsilBorclu(string name)
        {
            return new SuccessDataResult<List<MusteriEvrak>>(GetAll(s => s.AsilBorclu == name));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<MusteriEvrak> GetByVade(DateTime vade)
        {
            return new SuccessDataResult<MusteriEvrak>(Get(s => s.Vade == vade));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<MusteriEvrak> GetByTutar(decimal tutar)
        {
            return new SuccessDataResult<MusteriEvrak>(Get(s => s.Tutar == tutar));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<MusteriEvrak>> GetListByVerilenCariHareketId(int verilenCariHareketId)
        {
            return new SuccessDataResult<List<MusteriEvrak>>(GetAll(s => s.VerilenCariHareketId == verilenCariHareketId));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<MusteriEvrak>> GetListByCikisTarihi(DateTime cikisTarih)
        {
            return new SuccessDataResult<List<MusteriEvrak>>(GetAll(s => s.CikisTarihi == cikisTarih));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<MusteriEvrak>> GetList(Expression<Func<MusteriEvrak, bool>>? filter = null)
        {
            return new SuccessDataResult<List<MusteriEvrak>>(GetAll(filter));
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(MusteriEvrakValidator))]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriEvrakService.Get")]
        public IResult MusteridenEvraklarAl(List<MusteriEvrak> evraklar)
        {
            foreach (var entity in evraklar)
            {
                _cariHareketService.Add(entity.AlinanCariHareket);
                entity.AlinanCariHareketId = entity.AlinanCariHareket.Id;
                _musteriEvrakDal.Add(entity);
            }
            return new SuccessResult(Messages.DegerliEvrakMessages.EvrakEklendi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriEvrakService.Get")]
        public IResult MusteriyeEvraklarCik(List<MusteriEvrak> evraklar)
        {
            foreach (var entity in evraklar)
            {
                _cariHareketService.Add(entity.VerilenCariHareket);
                entity.VerilenCariHareketId = entity.VerilenCariHareket.Id;
                this.Update(entity);
            }
            return new SuccessResult(Messages.DegerliEvrakMessages.EvraklarCariyeIslendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriEvrakService.Get")]
        public IResult Delete(MusteriEvrak entity)
        {
            _musteriEvrakDal.Delete(new MusteriEvrak { Id = entity.Id });
            _cariHareketService.Delete(new CariHareket { Id = entity.Id });
            return new SuccessResult(Messages.DegerliEvrakMessages.EvrakSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriEvrakService.Get")]
        public IResult Update(MusteriEvrak entity)
        {
            _musteriEvrakDal.Update(entity);
            _cariHareketService.Update(entity.AlinanCariHareket);
            return new SuccessResult(Messages.DegerliEvrakMessages.EvrakGuncellendi);
        }

        public IDataResult<List<MusteriEvrak>> GetListByAlinanCariId(int cariId)
        {
            throw new NotImplementedException();
        }
    }
}