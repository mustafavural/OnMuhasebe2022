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
    public class AdresManager : IAdresService
    {
        private readonly IAdresDal _adresDal;
        private readonly IIlceService _ilceService;

        public AdresManager(IAdresDal adresDal, IIlceService ilceService)
        {
            _adresDal = adresDal;
            _ilceService = ilceService;
        }

        #region BusinessRules
        private IResult KontrolTelefonZatenVarMi(string? telefon)
        {
            if (telefon == null) return new SuccessResult();
            return _adresDal.Get(s => s.Telefon == telefon) == null ? new SuccessResult() : new ErrorResult(Messages.AdresMessages.TelefonZatenKullanimda);
        }

        private IResult KontrolTelefon2ZatenVarMi(string? telefon2)
        {
            if (telefon2 == null) return new SuccessResult();
            return _adresDal.Get(s => s.Telefon == telefon2) == null ? new SuccessResult() : new ErrorResult(Messages.AdresMessages.TelefonZatenKullanimda);
        }

        private IResult KontrolFaxZatenVarMi(string? fax)
        {
            if (fax == null) return new SuccessResult();
            return _adresDal.Get(s => s.Fax == fax) == null ? new SuccessResult() : new ErrorResult(Messages.AdresMessages.FaxZatenKullanimda);
        }

        private IResult KontrolWebZatenVarMi(string? web)
        {
            if (web == null) return new SuccessResult();
            return _adresDal.Get(s => s.Web == web) == null ? new SuccessResult() : new ErrorResult(Messages.AdresMessages.WebZatenKullanimda);
        }

        private IResult KontrolEpostaZatenVarMi(string? eposta)
        {
            if (eposta == null) return new SuccessResult();
            return _adresDal.Get(s => s.Eposta == eposta) == null ? new SuccessResult() : new ErrorResult(Messages.AdresMessages.EpostaZatenKullanimda);
        }

        private IResult KontrolAdresMevcutMu(int adresId)
        {
            return _adresDal.GetById(adresId) != null ? new SuccessResult() : new ErrorResult(Messages.AdresMessages.AdresBulunamadi);
        }
        #endregion

        public IDataResult<Adres> GetById(int id)
        {
            var iletisim = _adresDal.GetById(id);
            var ilce = _ilceService.GetById(iletisim.IlceId).Data;
            iletisim.Ilce = ilce;
            return new SuccessDataResult<Adres>(iletisim);
        }

        public IDataResult<Adres> GetByTelNo(string telNo)
        {
            var iletisim = _adresDal.Get(s => s.Telefon == telNo || s.Telefon2 == telNo || s.Fax == telNo);
            var ilce = _ilceService.GetById(iletisim.IlceId).Data;
            iletisim.Ilce = ilce;
            return new SuccessDataResult<Adres>(iletisim);
        }

        public IDataResult<Adres> GetByWeb(string web)
        {
            var iletisim = _adresDal.Get(s => s.Web == web);
            var ilce = _ilceService.GetById(iletisim.IlceId).Data;
            iletisim.Ilce = ilce;
            return new SuccessDataResult<Adres>(iletisim);
        }

        public IDataResult<Adres> GetByEposta(string ePosta)
        {
            var iletisim = _adresDal.Get(s => s.Eposta == ePosta);
            var ilce = _ilceService.GetById(iletisim.IlceId).Data;
            iletisim.Ilce = ilce;
            return new SuccessDataResult<Adres>(iletisim);
        }

        [CacheAspect(1)]
        public IDataResult<List<Adres>> GetListByIlce(string ilceAd)
        {
            var adresler = _adresDal.GetList();
            var ilce = _ilceService.GetByAd(ilceAd).Data;
            adresler.ForEach(s => s.Ilce = ilce);
            return new SuccessDataResult<List<Adres>>(adresler);
        }

        [CacheAspect(1)]
        public IDataResult<List<Adres>> GetListBySehir(string sehirAd)
        {
            var adresler = _adresDal.GetList();
            var ilceler = _ilceService.GetListBySehirAd(sehirAd).Data;
            adresler.ForEach(s => s.Ilce = ilceler.Where(b => b.Id == s.IlceId).Single());
            return new SuccessDataResult<List<Adres>>(adresler);
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(1)]
        public IDataResult<List<Adres>> GetList(Expression<Func<Adres, bool>>? filter = null)
        {
            var adresler = _adresDal.GetList(filter);
            var ilceler = _ilceService.GetList(x => adresler.Select(y => y.IlceId).Contains(x.Id)).Data;
            adresler.ForEach(s => s.Ilce = ilceler.Where(b => b.Id == s.IlceId).Single());
            return new SuccessDataResult<List<Adres>>(adresler);
        }

        [SecuredOperation("Add,Admin")]
        [ValidationAspect(typeof(AdresValidator))]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IAdresService.Get")]
        public IResult Add(Adres entity)
        {
            IResult result = BusinessRules.Run(KontrolTelefonZatenVarMi(entity.Telefon),
                                               KontrolTelefon2ZatenVarMi(entity.Telefon2),
                                               KontrolFaxZatenVarMi(entity.Fax),
                                               KontrolWebZatenVarMi(entity.Web),
                                               KontrolEpostaZatenVarMi(entity.Eposta));
            if (!result.IsSuccess)
                return result;

            _adresDal.Add(entity);
            return new SuccessResult(Messages.AdresMessages.AdresEklendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IAdresService.Get")]
        public IResult Delete(Adres entity)
        {
            IResult result = BusinessRules.Run(KontrolAdresMevcutMu(entity.Id));

            if (!result.IsSuccess)
                return result;

            _adresDal.Delete(new Adres { Id = entity.Id });
            return new SuccessResult(Messages.AdresMessages.AdresSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [ValidationAspect(typeof(AdresValidator))]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("IAdresService.Get")]
        public IResult Update(Adres entity)
        {
            //IResult result = BusinessRules.Run(KontrolTelefonZatenVarMi(entity.Telefon),
            //                                   KontrolTelefon2ZatenVarMi(entity.Telefon2),
            //                                   KontrolFaxZatenVarMi(entity.Fax),
            //                                   KontrolWebZatenVarMi(entity.Web),
            //                                   KontrolEpostaZatenVarMi(entity.Eposta));
            //if (!result.IsSuccess)
            //    return result;

            _adresDal.Update(entity);
            return new SuccessResult(Messages.AdresMessages.AdresGuncellendi);
        }
    }
}