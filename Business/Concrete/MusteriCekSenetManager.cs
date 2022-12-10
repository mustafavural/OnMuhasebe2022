using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class MusteriCekSenetManager : IMusteriCekSenetService
    {
        public IResult Add(MusteriCekSenet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(MusteriCekSenet entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<MusteriCekSenet> GetByAsilBorclu(string asilBorclu)
        {
            throw new NotImplementedException();
        }

        public IDataResult<MusteriCekSenet> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<MusteriCekSenet> GetByNo(string no)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriCekSenet>> GetList(Expression<Func<MusteriCekSenet, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriCekSenet>> GetListByBordroTahsilat(int tahsilatId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriCekSenet>> GetListByBordroTediye(int tediyeId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriCekSenet>> GetListByVade(DateTime vade)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MusteriCekSenet entity)
        {
            throw new NotImplementedException();
        }
    }
}