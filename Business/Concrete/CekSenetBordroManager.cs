using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Security;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Extensions;
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
        private readonly ICekSenetBorcService _cekSenetBorcService;
        private readonly ICekSenetMusteriService _cekSenetMusteriService;

        public CekSenetBordroManager(ICekSenetBordroDal kiymetliEvrakBordroDal,
                                     ICariService cariService,
                                     ICariHareketService cariHareketService,
                                     ICekSenetBorcService cekSenetBorcService,
                                     ICekSenetMusteriService cekSenetMusteriService)
        {
            _cekSenetBordroDal = kiymetliEvrakBordroDal;
            _cariService = cariService;
            _cariHareketService = cariHareketService;
            _cekSenetBorcService = cekSenetBorcService;
            _cekSenetMusteriService = cekSenetMusteriService;
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

        private IResult KontrolBordroBosMu(CekSenetBordro entity)
        {
            return entity.CekSenetMusteriler.Count > 0 || entity.CekSenetBorclar.Count > 0 ? new SuccessResult() : new ErrorResult(Messages.CekSenetMessages.BordroBos);
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
                bordro.CekSenetMusteriler = GetMusteriTahsilatCekSenetListById(bordro.Id).Data;
                bordro.CekSenetBorclar = GetBorcCekSenetListById(bordro.Id).Data;
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
                bordrolar.ForEach(k => k.CekSenetBorclar = GetBorcCekSenetListById(k.Id).Data);
                bordrolar.ForEach(k => k.CekSenetMusteriler = GetMusteriTahsilatCekSenetListById(k.Id).Data);
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

        public IDataResult<int> GetLastRowIndex()
        {
            var evrak = GetAll().MaxBy(s => s.Id);
            return new SuccessDataResult<int>(evrak == null ? 1 : evrak.No[1..].Trim('0').ToInt() + 1);
        }

        public IDataResult<List<CekSenetBordro>> GetListByTur(string tur)
        {
            return new SuccessDataResult<List<CekSenetBordro>>(GetAll(k => k.Tur == tur));
        }

        public IDataResult<List<CekSenetBordro>> GetListByCariId(int cariId)
        {
            return new SuccessDataResult<List<CekSenetBordro>>(GetAll(k => k.CariId == cariId));
        }

        public IDataResult<List<CekSenetBordro>> GetListBetweenTarihler(DateTime ilk, DateTime son)
        {
            return new SuccessDataResult<List<CekSenetBordro>>(GetAll(k => k.Tarih >= ilk && k.Tarih <= son));
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

        [PerformanceAspect(5)]
        public IDataResult<List<CekSenetBordro>> GetList(Expression<Func<CekSenetBordro, bool>>? filter = null)
        {
            return new SuccessDataResult<List<CekSenetBordro>>(GetAll(filter));
        }

        /*
            if (entity.CekSenetBorclar.Count > 0)
            {
                foreach (var evrak in entity.CekSenetBorclar)
                {
                    evrak.BordroTediyeId = entity.Id;
                    _cekSenetBorcService.Add(evrak);
                }
            }
            if (entity.CekSenetMusteriler.Count > 0)
            {
                foreach (var evrak in entity.CekSenetMusteriler)
                {
                    evrak.BordroTediyeId = evrak.BordroTediyeId == 0 ? entity.Id : 0;
                    _cekSenetMusteriService.Add(evrak);
                }
            }*/

        [SecuredOperation("Add,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("ICekSenetBordroService.Get")]
        public IResult Add(CekSenetBordro entity)
        {
            var result = BusinessRules.Run(KontrolBordroIdZatenVarMi(entity.Id),
                                           KontrolCariIdMevcutMu(entity.CariId),
                                           KontrolBordroNoZatenVarMi(entity.No),
                                           KontrolBordroBosMu(entity));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _cariHareketService.Add(entity.CariHareket);
            _cekSenetBordroDal.Add(entity);
            switch (entity.Tur)
            {
                case "Tahsilat":
                    {
                        foreach (var evrak in entity.CekSenetMusteriler)
                        {
                            evrak.BordroTahsilatId = entity.Id;
                            _cekSenetMusteriService.Add(evrak);
                        }
                        break;
                    }
                case "Tediye":
                    {
                        foreach (var evrak in entity.CekSenetMusteriler)
                        {
                            evrak.BordroTediyeId = entity.Id;
                            _cekSenetMusteriService.Update(evrak);
                        }
                        foreach (var evrak in entity.CekSenetBorclar)
                        {
                            evrak.BordroTediyeId = entity.Id;
                            _cekSenetBorcService.Add(evrak);
                        }
                        break;
                    }
            }
            return new SuccessResult(Messages.CekSenetMessages.BordroCariyeIslendi);
        }

        [SecuredOperation("Delete,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("ICekSenetBordroService.Get")]
        public IResult Delete(CekSenetBordro entity)
        {
            var result = BusinessRules.Run(KontrolBordroIdMevcutMu(entity.Id),
                                           KontrolBordroBosMu(entity.Id));
            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _cekSenetBordroDal.Delete(new() { Id = entity.Id });
            _cariHareketService.Delete(new() { Id = entity.CariHareket.Id });
            return new SuccessResult(Messages.CekSenetMessages.BordroSilindi);
        }

        [SecuredOperation("Update,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [CacheRemoveAspect("ICekSenetBordroService.Get")]
        public IResult Update(CekSenetBordro entity)
        {
            var result = BusinessRules.Run(KontrolCariIdMevcutMu(entity.CariId));

            if (!result.IsSuccess)
                return new ErrorResult(result.Message);

            _cekSenetBordroDal.Update(entity);
            _cariHareketService.Update(entity.CariHareket);
            return new SuccessResult(Messages.CekSenetMessages.BordroGuncellendi);
        }
    }
}