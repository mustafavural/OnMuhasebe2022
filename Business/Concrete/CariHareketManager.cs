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

        public IDataResult<CariHareket> GetById(int id)
        {
            var cariHareket = _cariHareketDal.GetById(id);
            var cari = _cariService.GetById(cariHareket.CariId).Data;
            cariHareket.Cari = cari;
            return new SuccessDataResult<CariHareket>(cariHareket);
        }

        public IDataResult<decimal> GetCariBakiye(string cariKod)
        {
            var cariId = _cariService.GetByKod(cariKod).Data.Id;
            return new SuccessDataResult<decimal>(_cariHareketDal.GetList(s => s.CariId == cariId).Sum(s => s.Tutar));
        }

        public IDataResult<List<CariHareket>> GetListByCariId(int cariId)
        {
            var cariHareketler = _cariHareketDal.GetList(s => s.CariId == cariId);
            foreach (var hareket in cariHareketler)
            {
                hareket.Cari = _cariService.GetById(cariId).Data;
            }
            return new SuccessDataResult<List<CariHareket>>(cariHareketler);
        }

        public IDataResult<List<CariHareket>> GetList(Expression<Func<CariHareket, bool>>? filter = null)
        {
            var cariHareketler = _cariHareketDal.GetList(filter);
            foreach (var hareket in cariHareketler)
            {
                hareket.Cari = _cariService.GetById(hareket.CariId).Data;
            }
            return new SuccessDataResult<List<CariHareket>>(cariHareketler);
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