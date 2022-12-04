using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class StokHareketManager : IStokHareketService
    {
        private readonly IStokHareketDal _stokHareketDal;
        private readonly IStokService _stokService;

        public StokHareketManager(IStokHareketDal stokHareketDal, IStokService stokService)
        {
            _stokHareketDal = stokHareketDal;
            _stokService = stokService;
        }

        #region BusinessRules
        private IResult KontrolYeterliStokVarMi(StokHareket cikan)
        {
            if (cikan.Miktar > 0) return new SuccessResult();
            return _stokHareketDal.GetList(s => s.StokId == cikan.StokId).Sum(c => c.Miktar) > cikan.Miktar ? new SuccessResult() : new ErrorResult(Messages.StokMessages.YeterliStokYok);
        }
        private IResult KontrolStokHareketMevcutMu(StokHareket entity)
        {
            return _stokHareketDal.GetById(entity.Id) != null ? new SuccessResult() : new ErrorResult(Messages.StokMessages.HareketBulunamadi);
        }
        #endregion

        public IDataResult<decimal> GetStokBakiye(string stokKod)
        {
            var stokId = _stokService.GetByKod(stokKod).Data.Id;
            return new SuccessDataResult<decimal>(_stokHareketDal.GetList(s => s.StokId == stokId).Sum(s => s.Miktar));
        }

        public IDataResult<StokHareket> GetById(int id)
        {
            var stokHareket = _stokHareketDal.GetById(id);
            var stok = _stokService.GetById(stokHareket.StokId).Data;
            stokHareket.Stok = stok;
            return new SuccessDataResult<StokHareket>(stokHareket);
        }

        public IDataResult<List<StokHareket>> GetListByFaturaId(int faturaId)
        {
            var stokHareketler = _stokHareketDal.GetList(s => s.FaturaId == faturaId);
            var stoklar = _stokService.GetList(s => stokHareketler.Select(shar => shar.StokId).Contains(s.Id)).Data;
            var result = stokHareketler.Join(
                stoklar,
                shar => shar.StokId,
                s => s.Id,
                (hareket, stok) => new StokHareket
                {
                    Aciklama = hareket.Aciklama,
                    FaturaId = hareket.FaturaId,
                    StokId = hareket.StokId,
                    Tarih = hareket.Tarih,
                    NetTutar = hareket.NetTutar,
                    Miktar = hareket.Miktar,
                    Kdv = hareket.Kdv,
                    Id = hareket.Id,
                    BrutTutar = hareket.BrutTutar,
                    Birim = hareket.Birim,
                    Fiyat = hareket.Fiyat,
                    Stok = stok
                });
            return new SuccessDataResult<List<StokHareket>>(result.ToList());
        }

        public IDataResult<List<StokHareket>> GetListByStokId(int stokId)
        {
            var stokHareketler = _stokHareketDal.GetList(s => s.StokId == stokId);
            var stok = _stokService.GetById(stokId).Data;
            foreach (var hareket in stokHareketler)
            {
                hareket.Stok = stok;
            }
            return new SuccessDataResult<List<StokHareket>>(stokHareketler);
        }

        public IDataResult<List<StokHareket>> GetList(Expression<Func<StokHareket, bool>>? filter = null)
        {
            var stokHareketler = _stokHareketDal.GetList(filter);
            var stoklar = _stokService.GetList(s => stokHareketler.Select(shar => shar.StokId).Contains(s.Id)).Data;
            var result = stokHareketler.Join(
                stoklar,
                shar => shar.StokId,
                s => s.Id,
                (hareket, stok) => new StokHareket
                {
                    Aciklama = hareket.Aciklama,
                    FaturaId = hareket.FaturaId,
                    StokId = hareket.StokId,
                    Tarih = hareket.Tarih,
                    NetTutar = hareket.NetTutar,
                    Miktar = hareket.Miktar,
                    Kdv = hareket.Kdv,
                    Id = hareket.Id,
                    BrutTutar = hareket.BrutTutar,
                    Birim = hareket.Birim,
                    Fiyat = hareket.Fiyat,
                    Stok = stok
                });
            return new SuccessDataResult<List<StokHareket>>(result.ToList());
        }

        [ValidationAspect(typeof(StokHareketValidator), Priority = 1)]
        public IResult Add(StokHareket entity)
        {
            IResult result = BusinessRules.Run(KontrolYeterliStokVarMi(entity));
            if (!result.IsSuccess)
                return result;

            _stokHareketDal.Add(entity);
            return new SuccessResult(Messages.StokMessages.HareketEklendi);
        }

        public IResult Delete(StokHareket entity)
        {
            IResult result = BusinessRules.Run(KontrolStokHareketMevcutMu(entity));
            if (!result.IsSuccess)
                return result;

            _stokHareketDal.Delete(entity);
            return new SuccessResult(Messages.StokMessages.HareketSilindi);
        }

        [ValidationAspect(typeof(StokHareketValidator), Priority = 1)]
        public IResult Update(StokHareket entity)
        {
            _stokHareketDal.Update(entity);
            return new SuccessResult(Messages.StokMessages.HareketGuncellendi);
        }
    }
}