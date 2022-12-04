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
    public class MusteriEvrakManager : DegerliEvrakManager, IMusteriEvrakService
    {
        private readonly IMusteriEvrakDal _musteriEvrakDal;
        private readonly ICariHareketService _cariHareketService;

        public MusteriEvrakManager(IMusteriEvrakDal musteriEvrakDal,
                                   IDegerliEvrakDal degerliEvrakDal,
                                   ICariHareketService cariHareketService) : base(degerliEvrakDal, cariHareketService)
        {
            _musteriEvrakDal = musteriEvrakDal;
            _cariHareketService = cariHareketService;
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public new IDataResult<MusteriEvrak> GetById(int id)
        {
            return new SuccessDataResult<MusteriEvrak>(_musteriEvrakDal.Get(s => s.Id == id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<MusteriEvrak>> GetList(Expression<Func<MusteriEvrak, bool>>? filter = null)
        {
            return new SuccessDataResult<List<MusteriEvrak>>(_musteriEvrakDal.GetList(filter));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<MusteriEvrak>> GetListByAlinanCariId(int cariId)
        {
            var musterievraklar = _musteriEvrakDal.GetList(s => s.Id == cariId);
            foreach (var item in musterievraklar)
            {
                item.DegerliEvrak = base.GetById(item.Id).Data;
            }
            return new SuccessDataResult<List<MusteriEvrak>>(musterievraklar);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<MusteriEvrak>> GetListByAsilBorclu(string name)
        {
            var musterievraklar = _musteriEvrakDal.GetList(s => s.AsilBorclu == name);
            foreach (var item in musterievraklar)
            {
                item.DegerliEvrak = base.GetById(item.Id).Data;
            }
            return new SuccessDataResult<List<MusteriEvrak>>(musterievraklar);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration: 1)]
        public IDataResult<List<MusteriEvrak>> GetListByAlisTarihi(DateTime alisTarih)
        {
            var musterievraklar = _musteriEvrakDal.GetList(s => s.AlisTarihi == alisTarih);
            foreach (var item in musterievraklar)
            {
                item.DegerliEvrak = base.GetById(item.Id).Data;
            }
            return new SuccessDataResult<List<MusteriEvrak>>(musterievraklar);
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(MusteriEvrakValidator))]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriEvrakService.Get")]
        public IResult Add(MusteriEvrak entity)
        {
            entity.AlinanCariHareket = new CariHareket
            {
                CariId = entity.Id,
                Aciklama = entity.DegerliEvrak.Aciklama,
                Tarih = entity.AlisTarihi,
                Tutar = entity.DegerliEvrak.Tutar
            };
            _cariHareketService.Add(entity.AlinanCariHareket);
            _musteriEvrakDal.Add(entity);
            return new SuccessResult(Messages.DegerliEvrakMessages.EvrakEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriEvrakService.Get")]
        public IResult Delete(MusteriEvrak entity)
        {
            _musteriEvrakDal.Delete(new MusteriEvrak { Id = entity.Id });
            _cariHareketService.Delete(new CariHareket { Id = entity.Id });
            return new SuccessResult(Messages.DegerliEvrakMessages.EvrakEklendi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriEvrakService.Get")]
        public IResult Update(MusteriEvrak entity)
        {

            entity.AlinanCariHareket = new CariHareket
            {
                Aciklama = entity.DegerliEvrak.Aciklama,
                CariId = entity.AlinanCariId,
                Tarih = entity.AlisTarihi,
                Tutar = entity.DegerliEvrak.Tutar,
                Id = entity.Id
            };
            _musteriEvrakDal.Update(entity);
            _cariHareketService.Update(entity.AlinanCariHareket);
            return new SuccessResult(Messages.DegerliEvrakMessages.EvrakEklendi);
        }

        [SecuredOperation("Add,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriEvrakService.Get")]
        public IResult MusteridenEvrakAl(List<MusteriEvrak> evraklar)
        {
            foreach (var entity in evraklar)
            {
                base.Add(entity.DegerliEvrak);
                this.Add(entity);
                _cariHareketService.Add(entity.AlinanCariHareket);
            }
            return new SuccessResult(Messages.DegerliEvrakMessages.EvraklarCariyeIslendi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IMusteriEvrakService.Get")]
        public IResult MusteriyeEvrakCik(List<MusteriEvrak> evraklar)
        {
            foreach (var entity in evraklar)
            {
                base.Update(entity.DegerliEvrak);
                this.Update(entity);
                _cariHareketService.Add(entity.DegerliEvrak.VerilenCariHareket);
            }
            return new SuccessResult(Messages.DegerliEvrakMessages.EvraklarCariyeIslendi);
        }
    }
}