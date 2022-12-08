using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
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
    public class CariManager : ICariService
    {
        private readonly ICariDal _cariDal;
        private readonly IAdresService _adresService;

        public CariManager(ICariDal cariDal, IAdresService adresService)
        {
            _cariDal = cariDal;
            _adresService = adresService;
        }

        #region BusinessRules
        private IResult KontrolCariIdMevcutMu(int Id)
        {
            return _cariDal.Get(c => c.Id == Id) != null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.KodYok);
        }

        private IResult KontrolCariKodZatenVarMi(string kod)
        {
            return _cariDal.Get(c => c.Kod == kod) == null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.KodZatenMevcut);
        }

        private IResult KontrolCariUnvanZatenVarMi(string unvan)
        {
            return _cariDal.Get(c => c.Unvan == unvan) == null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.UnvanZatenMevcut);
        }

        private IResult KontrolCariGrupZatenVarMi(CariGrup cariGrup)
        {
            return _cariDal.GetCariGrup(cariGrup.CariId, cariGrup.CariCategoryId) == null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.CariVeCategoryZatenEslenik);
        }

        private IResult KontrolVergiNoZatenVarMi(string vergiNo)
        {
            return _cariDal.Get(c=>c.VergiNo == vergiNo) == null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.VergiNoZatenMevcut);
        }

        private IResult KontrolCariHareketGormusMu(int id)
        {
            return _cariDal.GetCariHareketler(id) == null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.CariKullaniliyor);
        }
        #endregion

        private Cari Get(Expression<Func<Cari,bool>> filter)
        {
            var cari = _cariDal.Get(filter);
            if (cari != null)
            {
                var adres = _adresService.GetById(cari.Id).Data;
                cari.Adres = adres;
                cari.CariCategoryler = _cariDal.GetCariCategoryler(cari.Id);
            }
            return cari;
        }

        private List<Cari> GetAll(Expression<Func<Cari, bool>>? filter = null)
        {
            var cariler = _cariDal.GetList(filter);
            cariler.ForEach(s => s.CariCategoryler = _cariDal.GetCariCategoryler(s.Id));
            cariler.ForEach(x => x.Adres = _adresService.GetById(x.Id).Data);
            return cariler;
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Cari> GetById(int id)
        {
            return new SuccessDataResult<Cari>(Get(c=>c.Id==id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Cari> GetByKod(string kod)
        {
            return new SuccessDataResult<Cari>(Get(s => s.Kod == kod));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Cari> GetByVergiNo(string vergiNo)
        {
            return new SuccessDataResult<Cari>(Get(s => s.VergiNo == vergiNo));
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(duration: 1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<CariGrup> GetCariGrup(int cariId, int cariCategoryId)
        {
            return new SuccessDataResult<CariGrup>(_cariDal.GetCariGrup(cariId, cariCategoryId));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Cari> GetByTelNo(string telNo)
        {
            var adres = _adresService.GetByTelNo(telNo).Data;
            if (adres != null)
            {
                return new SuccessDataResult<Cari>(Get(s => s.Id == adres.Id));
            }
            return new SuccessDataResult<Cari>();
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Cari> GetByWeb(string web)
        {
            var adres = _adresService.GetByWeb(web).Data;
            if (adres != null)
            {
                return new SuccessDataResult<Cari>(Get(s => s.Id == adres.Id));
            }
            return new SuccessDataResult<Cari>();
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Cari> GetByEposta(string ePosta)
        {
            var adres = _adresService.GetByEposta(ePosta).Data;
            if (adres != null)
            {
                return new SuccessDataResult<Cari>(Get(s => s.Id == adres.Id));
            }
            return new SuccessDataResult<Cari>();
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<Cari>> GetListByIlce(string ilceAd)
        {
            var adresler = _adresService.GetListByIlce(ilceAd).Data;
            if (adresler.Count != 0)
            {
                return new SuccessDataResult<List<Cari>>(GetAll(c => adresler.Select(a => a.Id).Contains(c.Id)));
            }
            return new SuccessDataResult<List<Cari>>();
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<Cari>> GetListBySehir(string sehirAd)
        {
            var adresler = _adresService.GetListBySehir(sehirAd).Data;
            if (adresler.Count != 0)
            {
                return new SuccessDataResult<List<Cari>>(GetAll(c => adresler.Select(a => a.Id).Contains(c.Id)));
            }
            return new SuccessDataResult<List<Cari>>();
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        [PerformanceAspect(5)]
        public IDataResult<List<Cari>> GetList(Expression<Func<Cari, bool>>? filter = null)
        {
            return new SuccessDataResult<List<Cari>>(GetAll(filter));
        }

        [SecuredOperation("Add,Admin")]
        [CacheRemoveAspect("ICariService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult AddCategoryToCari(CariGrup cariGrup)
        {
            IResult result = BusinessRules.Run(KontrolCariGrupZatenVarMi(cariGrup));
            if (!result.IsSuccess)
                return result;

            _cariDal.AddCategoryToCari(cariGrup);
            return new SuccessResult(Messages.CariMessages.CategoryeEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [CacheRemoveAspect("ICariService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult DeleteCategoryFromCari(CariGrup cariGrup)
        {
            _cariDal.DeleteCategoryFromCari(cariGrup);
            return new SuccessResult(Messages.CariMessages.CategorydenSilindi);
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(CariValidator), Priority = 1)]
        [CacheRemoveAspect("ICariService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Add(Cari entity)
        {
            IResult result = BusinessRules.Run(KontrolCariUnvanZatenVarMi(entity.Unvan),
                                               KontrolCariKodZatenVarMi(entity.Kod),
                                               KontrolVergiNoZatenVarMi(entity.VergiNo));
            if (!result.IsSuccess)
                return result;

            _adresService.Add(entity.Adres);
            entity.Id = entity.Adres.Id;
            _cariDal.Add(entity);
            return new SuccessResult(Messages.CariMessages.CariEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [CacheRemoveAspect("ICariService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(Cari entity)
        {
            IResult result = BusinessRules.Run(KontrolCariIdMevcutMu(entity.Id),
                                               KontrolCariHareketGormusMu(entity.Id));
            if (!result.IsSuccess)
                return result;

            _cariDal.Delete(new Cari { Id = entity.Id });
            _adresService.Delete(new Adres { Id = entity.Id });
            return new SuccessResult(Messages.CariMessages.CariSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [ValidationAspect(typeof(CariValidator), Priority = 1)]
        [CacheRemoveAspect("ICariService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(Cari entity)
        {
            IResult result = BusinessRules.Run(KontrolCariIdMevcutMu(entity.Id));
            if (!result.IsSuccess)
                return result;

            _cariDal.Update(entity);
            _adresService.Update(entity.Adres);
            return new SuccessResult(Messages.CariMessages.CariGuncellendi);
        }
    }
}