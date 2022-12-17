using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Security;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class FaturaManager : IFaturaService
    {
        private readonly IFaturaDal _faturaDal;
        private readonly ICariService _cariService;
        private readonly ICariHareketService _cariHareketService;
        private readonly IStokHareketService _stokHareketService;

        public FaturaManager(IFaturaDal faturaDal, ICariHareketService cariHareketService, IStokHareketService stokHareketService, ICariService cariService)
        {
            _faturaDal = faturaDal;
            _cariService = cariService;
            _cariHareketService = cariHareketService;
            _stokHareketService = stokHareketService;
        }

        #region BusinessRules
        private IResult KontrolFaturaIdMevcutMu(int id)
        {
            return _faturaDal.Get(s => s.Id == id) != null ? new SuccessResult() : new ErrorResult(Messages.FaturaMessages.FaturaYok);
        }
        private IResult KontrolFaturaNoZatenVarMi(string no)
        {
            return _faturaDal.Get(f => f.No == no) == null ? new SuccessResult() : new ErrorResult(Messages.FaturaMessages.ZatenMevcut);
        }
        private IResult KontrolFaturaBosMu(string no)
        {
            var faturaId = _faturaDal.Get(f => f.No == no).Id;
            return _stokHareketService.GetListByFaturaId(faturaId).Data == null ? new SuccessResult() : new ErrorResult(Messages.FaturaMessages.BosDegil);
        }
        private IResult KontrolCariIdMevcutMu(int cariId)
        {
            return _cariService.GetById(cariId).Data != null ? new SuccessResult() : new ErrorResult(Messages.CariMessages.CariYok);
        }
        private IResult KontrolKalemlerBosMu(List<StokHareket>? stokHareketler)
        {
            if (stokHareketler == null || stokHareketler.Count == 0)
                return new ErrorResult(Messages.FaturaMessages.KalemBulunamadi);
            else
                return new SuccessResult();
        }
        #endregion

        private Cari GetFaturaCari(string no)
        {
            int cariId = _faturaDal.Get(s => s.No == no).CariId;
            return _cariService.GetById(cariId).Data;
        }

        private List<StokHareket> GetFaturaKalemler(string no)
        {
            int faturaId = _faturaDal.Get(s => s.No == no).Id;
            return new List<StokHareket>(_stokHareketService.GetListByFaturaId(faturaId).Data);
        }

        private Fatura Get(Expression<Func<Fatura, bool>> filter)
        {
            var fatura = _faturaDal.Get(filter);
            if (fatura != null)
            {
                fatura.StokHareketler = GetFaturaKalemler(fatura.No);
                fatura.Cari = GetFaturaCari(fatura.No);
            }
            return fatura;
        }

        private List<Fatura> GetAll(Expression<Func<Fatura, bool>>? filter = null)
        {
            var faturalar = _faturaDal.GetList(filter);
            if (faturalar.Count > 0)
            {
                faturalar.ForEach(s => s.StokHareketler = GetFaturaKalemler(s.No));
                faturalar.ForEach(s => s.Cari = GetFaturaCari(s.No));
            }
            return faturalar;
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Fatura> GetById(int id)
        {
            return new SuccessDataResult<Fatura>(Get(f => f.Id == id));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Fatura> GetByNo(string no)
        {
            return new SuccessDataResult<Fatura>(Get(s => s.No == no));
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(duration: 1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Fatura>> GetListByTur(string tur)
        {
            return new SuccessDataResult<List<Fatura>>(GetAll(f => f.Tur == tur));
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(duration: 1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Fatura>> GetListByCariKod(string cariKod)
        {
            var cariId = _cariService.GetByKod(cariKod).Data.Id;
            return new SuccessDataResult<List<Fatura>>(GetAll(s => s.CariId == cariId));
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(duration: 1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Fatura>> GetListBetweenTarihler(DateTime ilk, DateTime son)
        {
            return new SuccessDataResult<List<Fatura>>(GetAll(f => f.Tarih >= ilk && f.Tarih <= son));
        }

        [SecuredOperation("List,Admin")]
        [CacheAspect(duration: 1)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Fatura>> GetListBetweenKayitTarihler(DateTime ilk, DateTime son)
        {
            return new SuccessDataResult<List<Fatura>>(GetAll(f => f.KayitTarihi >= ilk && f.KayitTarihi <= son));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Fatura>> GetList(Expression<Func<Fatura, bool>>? filter = null)
        {
            return new SuccessDataResult<List<Fatura>>(GetAll(filter));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<int>> GetFaturaKdvler(string no)
        {
            return new SuccessDataResult<List<int>>(GetFaturaKalemler(no).Select(s => s.Kdv).Distinct().ToList());
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<decimal?> GetBrutToplam(string no)
        {
            return new SuccessDataResult<decimal?>(GetFaturaKalemler(no).Sum(s => s.BrutTutar));
        }

        [SecuredOperation("List,Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<decimal?> GetNetToplam(string no)
        {
            return new SuccessDataResult<decimal?>(GetFaturaKalemler(no).Sum(s => s.NetTutar));
        }

        [SecuredOperation("Add,Admin")]
        [CacheRemoveAspect("IFaturaService.Get")]
        [ValidationAspect(typeof(FaturaValidator), Priority = 1)]
        [LogAspect(typeof(DatabaseLogger))]
        [TransactionScopeAspect()]
        public IResult Add(Fatura fatura)
        {
            var result = BusinessRules.Run(KontrolFaturaNoZatenVarMi(fatura.No),
                                           KontrolCariIdMevcutMu(fatura.CariId),
                                           KontrolKalemlerBosMu(fatura.StokHareketler));
            if (!result.IsSuccess)
                return result;

            //fatura tür

            foreach (var item in fatura.StokHareketler)
            {
                item.Miktar *= fatura.Tur == "Satış Faturası" ? -1 : 1;
                item.Tarih = fatura.KayitTarihi;
                item.Aciklama = $"{fatura.No} nolu {fatura.Tur}.";
            }

            //Alt Bilgiler
            fatura.CariHareket = new CariHareket
            {
                CariId = fatura.CariId,
                Tutar = (fatura.StokHareketler.Sum(s => s.NetTutar) ?? 0) * (fatura.Tur == "Satış Faturası" ? 1 : -1),
                Tarih = fatura.Tarih,
                Aciklama = $"{fatura.No} nolu {fatura.Tur}."
            };
            _cariHareketService.Add(fatura.CariHareket);

            ////Fatura üst bilgileri
            fatura.Id = fatura.CariHareket.Id;
            _faturaDal.Add(fatura);

            //Kalem bilgileri
            foreach (var item in fatura.StokHareketler)
            {
                item.FaturaId = fatura.Id;
                _stokHareketService.Add(item);
            }

            return new SuccessResult(Messages.FaturaMessages.FaturaKesildi);
        }

        [SecuredOperation("Delete,Admin")]
        [CacheRemoveAspect("IFaturaService.Get")]
        [LogAspect(typeof(DatabaseLogger))]
        [TransactionScopeAspect()]
        public IResult Delete(Fatura fatura)
        {
            var result = BusinessRules.Run(KontrolFaturaIdMevcutMu(fatura.Id),
                                           KontrolFaturaBosMu(fatura.No));
            if (!result.IsSuccess)
                return result;

            foreach (var stokHareket in fatura.StokHareketler)
            {
                _stokHareketService.Delete(stokHareket);
            }
            _faturaDal.Delete(fatura);
            _cariHareketService.Delete(_cariHareketService.GetById(fatura.Id).Data);
            return new SuccessResult(Messages.FaturaMessages.Silindi);
        }

        [SecuredOperation("Update,Admin")]
        [CacheRemoveAspect("IFaturaService.Get")]
        [ValidationAspect(typeof(FaturaValidator), Priority = 1)]
        [LogAspect(typeof(DatabaseLogger))]
        [TransactionScopeAspect()]
        public IResult Update(Fatura fatura)
        {
            var result = BusinessRules.Run(KontrolFaturaIdMevcutMu(fatura.Id),
                                           KontrolKalemlerBosMu(fatura.StokHareketler));
            if (!result.IsSuccess)
                return result;

            //Kalem bilgileri
            var eskiler = _stokHareketService.GetListByFaturaId(fatura.Id).Data;
            foreach (var hareket in eskiler)
            {
                _stokHareketService.Delete(hareket);
            }

            foreach (var hareket in fatura.StokHareketler)
            {
                hareket.FaturaId = fatura.Id;
                hareket.Miktar *= fatura.Tur == "Satış Faturası" ? -1 : 1;
                hareket.BrutTutar = hareket.Miktar * hareket.Fiyat;
                hareket.NetTutar = hareket.BrutTutar * (hareket.Kdv / 100 + 1);
                hareket.Tarih = fatura.KayitTarihi;
                hareket.Aciklama = $"{fatura.No} nolu {fatura.Tur}.";
                _stokHareketService.Add(hareket);
            }

            //Alt Bilgiler
            fatura.CariHareket.CariId = fatura.CariId;
            fatura.CariHareket.Tutar = (fatura.StokHareketler.Sum(s => s.NetTutar) ?? 0) * (fatura.Tur == "Satış Faturası" ? -1 : 1) * -1;
            fatura.CariHareket.Tarih = fatura.Tarih;
            fatura.CariHareket.Aciklama = fatura.Aciklama;
            _cariHareketService.Update(fatura.CariHareket);

            //Fatura üst bilgileri
            _faturaDal.Update(fatura);

            return new SuccessResult(Messages.FaturaMessages.Guncellendi);
        }
    }
}