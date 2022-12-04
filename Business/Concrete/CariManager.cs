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
        protected IResult KontrolCariIdVarMi(int Id)
        {
            return _cariDal.Get(c => c.Id == Id) != null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.KodYok);
        }
        protected IResult KontrolCariKodVarMi(string kod)
        {
            return _cariDal.Get(c => c.Kod == kod) == null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.KodZatenMevcut);
        }
        protected IResult KontrolCariUnvanVarMi(string unvan)
        {
            return _cariDal.Get(c => c.Unvan == unvan) == null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.UnvanZatenMevcut);
        }
        #endregion

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Cari> GetById(int id)
        {
            var cari = _cariDal.GetById(id);
            if (cari != null)
            {
                var adres = _adresService.GetById(cari.Id).Data;
                cari.Adres = adres;
                cari.CariCategoryler = _cariDal.GetCariCategoryler(cari.Id);
            }
            return new SuccessDataResult<Cari>(cari);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Cari> GetByKod(string kod)
        {
            var cari = _cariDal.Get(s => s.Kod == kod);
            if (cari != null)
            {
                var adres = _adresService.GetById(cari.Id).Data;
                cari.Adres = adres;
                cari.CariCategoryler = _cariDal.GetCariCategoryler(cari.Id);
            }
            return new SuccessDataResult<Cari>(cari);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Cari> GetByVergiNo(string vergiNo)
        {
            var cari = _cariDal.Get(s => s.VergiNo == vergiNo);
            if (cari != null)
            {
                var adres = _adresService.GetById(cari.Id).Data;
                cari.Adres = adres;
                cari.CariCategoryler = _cariDal.GetCariCategoryler(cari.Id);
            }
            return new SuccessDataResult<Cari>(cari);
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
                var cari = _cariDal.Get(s => s.Id == adres.Id);
                if (cari != null)
                {
                    cari.Adres = adres;
                    cari.CariCategoryler = _cariDal.GetCariCategoryler(cari.Id);
                    return new SuccessDataResult<Cari>(cari);
                }
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
                var cari = _cariDal.Get(s => s.Id == adres.Id);
                if (cari != null)
                {
                    cari.Adres = adres;
                    cari.CariCategoryler = _cariDal.GetCariCategoryler(cari.Id);
                    return new SuccessDataResult<Cari>(cari);
                }
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
                var cari = _cariDal.Get(s => s.Id == adres.Id);
                if (cari != null)
                {
                    cari.Adres = adres;
                    cari.CariCategoryler = _cariDal.GetCariCategoryler(cari.Id);
                    return new SuccessDataResult<Cari>(cari);
                }
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
                var result = _cariDal.GetList(c => adresler.Select(a => a.Id).Contains(c.Id)).Join(
                adresler,
                cari => cari.Id,
                adres => adres.Id,
                (cari, adres) => new Cari
                {
                    Id = cari.Id,
                    Kod = cari.Kod,
                    Unvan = cari.Unvan,
                    VergiDairesi = cari.VergiDairesi,
                    VergiNo = cari.VergiNo,
                    Adres = adres
                }).ToList();

                if (result.Count != 0)
                {
                    result.ForEach(s => s.CariCategoryler = _cariDal.GetCariCategoryler(s.Id));
                    return new SuccessDataResult<List<Cari>>(result);
                }
            }
            return new SuccessDataResult<List<Cari>>();
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<Cari>> GetListBySehir(string sehirAd)
        {
            List<Cari> result = null;
            var adresler = _adresService.GetListBySehir(sehirAd).Data;
            if (adresler.Count != 0)
            {
                result = _cariDal.GetList(c => adresler.Select(a => a.Id).Contains(c.Id));
                result.ForEach(s => s.Adres = adresler.Where(a => a.Id == s.Id).Single());
                result.ForEach(s => s.CariCategoryler = _cariDal.GetCariCategoryler(s.Id));
            }
            return new SuccessDataResult<List<Cari>>(result);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        [PerformanceAspect(5)]
        public IDataResult<List<Cari>> GetList(Expression<Func<Cari, bool>>? filter = null)
        {
            var cariler = _cariDal.GetList(filter);
            cariler.ForEach(s => s.CariCategoryler = _cariDal.GetCariCategoryler(s.Id));
            cariler.ForEach(x => x.Adres = _adresService.GetById(x.Id).Data);
            return new SuccessDataResult<List<Cari>>(cariler);
        }

        [SecuredOperation("Add,Admin")]
        [CacheRemoveAspect("ICariService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult AddCategoryToCari(CariGrup cariGrup)
        {
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
        [CacheRemoveAspect("ICariService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Add(Cari entity)
        {
            IResult result = BusinessRules.Run(KontrolCariUnvanVarMi(entity.Unvan),
                                               KontrolCariKodVarMi(entity.Kod));
            if (!result.IsSuccess)
                return result;

            _adresService.Add(entity.Adres);
            _cariDal.Add(entity);
            return new SuccessResult(Messages.CariMessages.KurumsalEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [CacheRemoveAspect("ICariService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(Cari entity)
        {
            IResult result = BusinessRules.Run(KontrolCariIdVarMi(entity.Id));
            if (!result.IsSuccess)
                return result;

            _cariDal.Delete(entity);
            return new SuccessResult(Messages.CariMessages.Silindi);
        }

        [SecuredOperation("Update,Admin")]
        [CacheRemoveAspect("ICariService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(Cari entity)
        {
            IResult result = BusinessRules.Run(KontrolCariIdVarMi(entity.Id));
            if (!result.IsSuccess)
                return result;

            _cariDal.Update(entity);
            return new SuccessResult(Messages.CariMessages.Guncellendi);
        }
    }
}