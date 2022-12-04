using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ISehirService
    {
        IDataResult<Sehir> GetById(int id);
        IDataResult<List<Sehir>> GetList(Expression<Func<Sehir, bool>>? filter = null);
        IDataResult<Sehir> GetByAd(string ad);
    }
}
