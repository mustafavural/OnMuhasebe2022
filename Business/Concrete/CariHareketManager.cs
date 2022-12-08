using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CariHareketManager : ICariHareketService
    {
        private readonly ICariHareketDal _cariHareketDal;
        private readonly ICariService _cariService;

        public CariHareketManager(ICariHareketDal cariHareketDal, ICariService cariService)
        {
            _cariHareketDal = cariHareketDal;
            _cariService = cariService;
        }

        private CariHareket Get(Expression<Func<CariHareket, bool>> filter)
        {
            var cariHareket = _cariHareketDal.Get(filter);
            cariHareket.Cari = _cariService.GetById(cariHareket.CariId).Data;
            return cariHareket;
        }

        private List<CariHareket> GetAll(Expression<Func<CariHareket, bool>>? filter = null)
        {
            var cariHareketler = _cariHareketDal.GetList(filter);
            cariHareketler.ForEach(c => c.Cari = _cariService.GetById(c.CariId).Data);
            return cariHareketler;
        }

        public IDataResult<CariHareket> GetById(int id)
        {
            return new SuccessDataResult<CariHareket>(Get(c => c.Id == id));
        }

        public IDataResult<decimal> GetCariBakiye(string cariKod)
        {
            var cariId = _cariService.GetByKod(cariKod).Data.Id;
            return new SuccessDataResult<decimal>(_cariHareketDal.GetList(s => s.CariId == cariId).Sum(s => s.Tutar));
        }

        public IDataResult<List<CariHareket>> GetListByCariId(int cariId)
        {
            return new SuccessDataResult<List<CariHareket>>(GetAll(s => s.CariId == cariId));
        }

        public IDataResult<List<CariHareket>> GetList(Expression<Func<CariHareket, bool>>? filter = null)
        {
            return new SuccessDataResult<List<CariHareket>>(GetAll(filter));
        }

        [ValidationAspect(typeof(CariHareketValidator), Priority = 1)]
        public IResult Add(CariHareket entity)
        {
            _cariHareketDal.Add(entity);
            return new SuccessResult(Messages.CariMessages.HareketEklendi);
        }

        public IResult Delete(CariHareket entity)
        {
            _cariHareketDal.Delete(entity);
            return new SuccessResult(Messages.CariMessages.HareketSilindi);
        }

        [ValidationAspect(typeof(CariHareketValidator), Priority = 1)]
        public IResult Update(CariHareket entity)
        {
            _cariHareketDal.Update(entity);
            return new SuccessResult(Messages.CariMessages.HareketGuncellendi);
        }
    }
}