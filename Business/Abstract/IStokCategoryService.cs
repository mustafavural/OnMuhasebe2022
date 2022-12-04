using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IStokCategoryService
    {
        IDataResult<StokCategory> GetById(int id);
        IDataResult<List<StokCategory>> GetList(Expression<Func<StokCategory, bool>>? filter = null);
        IResult Add(StokCategory entity);
        IResult Delete(StokCategory entity);
        IResult Update(StokCategory entity);
    }
}
