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
    public class KasaHareketManager : IKasaHareketService
    {
        private readonly IKasaHareketDal _kasaHareketDal;
        private readonly ICariHareketService _cariHareketService;
        private readonly IKasaService _kasaService;

        public KasaHareketManager(IKasaHareketDal kasaHareketDal, ICariHareketService cariHareketService, IKasaService kasaService)
        {
            _kasaHareketDal = kasaHareketDal;
            _cariHareketService = cariHareketService;
            _kasaService = kasaService;
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<KasaHareket> GetById(int id)
        {
            var kasaHareket = _kasaHareketDal.GetById(id);
            kasaHareket.Kasa = _kasaService.GetById(kasaHareket.KasaId).Data;
            kasaHareket.CariHareket = _cariHareketService.GetById(kasaHareket.Id).Data;
            return new SuccessDataResult<KasaHareket>(kasaHareket);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<KasaHareket> GetByEvrakNo(string evrakNo)
        {
            var kasaHareket = _kasaHareketDal.Get(s => s.EvrakNo == evrakNo);
            kasaHareket.Kasa = _kasaService.GetById(kasaHareket.KasaId).Data;
            kasaHareket.CariHareket = _cariHareketService.GetById(kasaHareket.Id).Data;
            return new SuccessDataResult<KasaHareket>(kasaHareket);
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(duration: 1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<KasaHareket>> GetListByCariId(int cariId)
        {
            var cariHareketIdler = _cariHareketService.GetListByCariId(cariId).Data;
            var kasaHareketler = _kasaHareketDal.GetList(k => cariHareketIdler.Select(c => c.Id).Contains(k.Id));
            foreach (var hareket in kasaHareketler)
            {
                hareket.CariHareket = _cariHareketService.GetById(hareket.Id).Data;
                hareket.Kasa = _kasaService.GetById(hareket.KasaId).Data;
            }
            return new SuccessDataResult<List<KasaHareket>>(kasaHareketler);
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(duration: 1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<KasaHareket>> GetListByKasaId(int kasaId)
        {
            var kasaHareketler = _kasaHareketDal.GetList(k => k.KasaId == kasaId);
            foreach (var hareket in kasaHareketler)
            {
                hareket.CariHareket = _cariHareketService.GetById(hareket.Id).Data;
                hareket.Kasa = _kasaService.GetById(hareket.KasaId).Data;
            }
            return new SuccessDataResult<List<KasaHareket>>(kasaHareketler);
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(duration: 1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<KasaHareket>> GetListBetweenTarihler(DateTime first, DateTime last)
        {
            var kasaHareketler = _kasaHareketDal.GetList(s => first <= s.Tarih && s.Tarih >= last);
            foreach (var hareket in kasaHareketler)
            {
                hareket.CariHareket = _cariHareketService.GetById(hareket.Id).Data;
                hareket.Kasa = _kasaService.GetById(hareket.KasaId).Data;
            }
            return new SuccessDataResult<List<KasaHareket>>(kasaHareketler);
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(duration: 1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<KasaHareket>> GetListBetweenFiyatlar(decimal min, decimal max)
        {
            var kasaHareketler = _kasaHareketDal.GetList(s => min <= s.GirenCikanMiktar && s.GirenCikanMiktar >= max);
            foreach (var hareket in kasaHareketler)
            {
                hareket.CariHareket = _cariHareketService.GetById(hareket.Id).Data;
                hareket.Kasa = _kasaService.GetById(hareket.KasaId).Data;
            }
            return new SuccessDataResult<List<KasaHareket>>(kasaHareketler);
        }

        public IDataResult<List<KasaHareket>> GetList(Expression<Func<KasaHareket, bool>>? filter = null)
        {
            var kasaHareketler = _kasaHareketDal.GetList(filter);
            foreach (var hareket in kasaHareketler)
            {
                hareket.CariHareket = _cariHareketService.GetById(hareket.Id).Data;
                hareket.Kasa = _kasaService.GetById(hareket.KasaId).Data;
            }
            return new SuccessDataResult<List<KasaHareket>>(kasaHareketler);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<decimal> GetKasaBakiye(int kasaId)
        {
            return new SuccessDataResult<decimal>(_kasaHareketDal.GetList(s => s.KasaId == kasaId).Sum(s => s.GirenCikanMiktar));
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(KasaHareketValidator), Priority = 1)]
        [CacheRemoveAspect("IKasaService.Get")]
        [CacheRemoveAspect("IKasaHareketService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Add(KasaHareket hareket)
        {
            string evrakTur = hareket.EvrakNo.StartsWith("T") ? "tahsilat" : "tediye";
            var cariHareket = new CariHareket
            {
                CariId = hareket.CariId,
                Tarih = hareket.Tarih,
                Tutar = evrakTur == "tahsilat" ? hareket.GirenCikanMiktar : hareket.GirenCikanMiktar * -1,
                Aciklama = $"{hareket.EvrakNo} nolu kasa {evrakTur}."
            };
            _cariHareketService.Add(cariHareket);
            hareket.Id = cariHareket.Id;
            hareket.GirenCikanMiktar = evrakTur == "tahsilat" ? hareket.GirenCikanMiktar : hareket.GirenCikanMiktar * -1;
            _kasaHareketDal.Add(hareket);
            return new SuccessResult(evrakTur == "tahsilat" ? Messages.KasaMessages.TahsilatKaydedildi : Messages.KasaMessages.TediyeKaydedildi);
        }

        [SecuredOperation("Delete,Admin")]
        [CacheRemoveAspect("IKasaService.Get")]
        [CacheRemoveAspect("IKasaHareketService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(KasaHareket hareket)
        {
            var cariHareket = _cariHareketService.GetById(hareket.Id).Data;
            _kasaHareketDal.Delete(hareket);
            _cariHareketService.Delete(cariHareket);
            return new SuccessResult(Messages.KasaMessages.HareketSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [ValidationAspect(typeof(KasaHareketValidator), Priority = 1)]
        [CacheRemoveAspect("IKasaService.Get")]
        [CacheRemoveAspect("IKasaHareketService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(KasaHareket hareket)
        {
            string evrakTur = hareket.EvrakNo.StartsWith("T") ? "tahsilat" : "tediye";
            var cariHareket = _cariHareketService.GetById(hareket.Id).Data;
            hareket.GirenCikanMiktar = evrakTur == "tahsilat" ? hareket.GirenCikanMiktar : hareket.GirenCikanMiktar * -1;
            _kasaHareketDal.Update(hareket);
            cariHareket.CariId = hareket.CariId;
            cariHareket.Tarih = hareket.Tarih;
            cariHareket.Tutar = evrakTur == "tahsilat" ? hareket.GirenCikanMiktar : hareket.GirenCikanMiktar * -1;
            cariHareket.Aciklama = $"{hareket.EvrakNo} nolu kasa {evrakTur}.";
            _cariHareketService.Update(cariHareket);
            return new SuccessResult(Messages.KasaMessages.HareketGuncellendi);
        }
    }
}