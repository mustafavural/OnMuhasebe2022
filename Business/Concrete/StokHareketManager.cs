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

        private StokHareket Get(Expression<Func<StokHareket,bool>> filter)
        {
            var stokHareket = _stokHareketDal.Get(filter);
            stokHareket.Stok = _stokService.GetById(stokHareket.StokId).Data;
            return stokHareket;
        }

        private List<StokHareket> GetList(Expression<Func<StokHareket, bool>>? filter = null)
        {
            var stokHareketler = _stokHareketDal.GetList(filter);
            stokHareketler.ForEach(s => s.Stok = _stokService.GetById(s.StokId).Data);
            return stokHareketler;
        }

        public IDataResult<StokHareket> GetById(int id)
        {
            return new SuccessDataResult<StokHareket>(Get(s => s.Id == id));
        }

        public IDataResult<List<StokHareket>> GetListByFaturaId(int faturaId)
        {
            return new SuccessDataResult<List<StokHareket>>(GetList(s => s.FaturaId == faturaId));
        }

        public IDataResult<List<StokHareket>> GetListByStokId(int stokId)
        {
            return new SuccessDataResult<List<StokHareket>>(GetList(s => s.StokId == stokId));
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