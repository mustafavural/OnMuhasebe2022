using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class BorcCekSenetManager : IBorcCekSenetService
    {
        public IResult Add(BorcCekSenet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BorcCekSenet entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BorcCekSenet> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BorcCekSenet> GetByNo(string no)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BorcCekSenet>> GetList(Expression<Func<BorcCekSenet, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BorcCekSenet>> GetListByBordroTediye(int tediyeId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BorcCekSenet>> GetListByVade(DateTime vade)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BorcCekSenet entity)
        {
            throw new NotImplementedException();
        }
    }
}