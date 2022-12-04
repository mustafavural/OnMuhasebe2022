using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICariCategoryService
    {
        IDataResult<CariCategory> GetById(int id);
        IDataResult<List<CariCategory>> GetList(Expression<Func<CariCategory, bool>>? filter = null);
        IResult Add(CariCategory entity);
        IResult Delete(CariCategory entity);
        IResult Update(CariCategory entity);
    }
}