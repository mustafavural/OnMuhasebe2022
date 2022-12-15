using Core.Entities.Abstract;
using Core.Utilities.Results;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IServiceBase<T> where T : class, IEntity, new()
    {
        IDataResult<T> GetById(int id);
        IDataResult<List<T>> GetList(Expression<Func<T, bool>>? filter = null);
    }
}