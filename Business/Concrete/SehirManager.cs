using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class SehirManager : ISehirService
    {
        private readonly ISehirDal _sehirDal;
        public SehirManager(ISehirDal sehirDal)
        {
            _sehirDal = sehirDal;
        }
        public IDataResult<Sehir> GetById(int id)
        {
            return new SuccessDataResult<Sehir>(_sehirDal.GetById(id));
        }

        public IDataResult<Sehir> GetByAd(string ad)
        {
            return new SuccessDataResult<Sehir>(_sehirDal.Get(s => s.Ad == ad));
        }

        public IDataResult<List<Sehir>> GetList(Expression<Func<Sehir, bool>>? filter = null)
        {
            var result = _sehirDal.GetList(filter);
            return new SuccessDataResult<List<Sehir>>(result);
        }
    }
}