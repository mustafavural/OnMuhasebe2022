using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IStokService
    {
        IDataResult<Stok> GetById(int id);
        IDataResult<List<Stok>> GetList(Expression<Func<Stok, bool>>? filter = null);
        IDataResult<Stok> GetByKod(string stokKod);
        IDataResult<StokGrup> GetStokGrup(int stokId, int stokCategoryId);
        IResult AddCategoryToStok(StokGrup grup);
        IResult DeleteCategoryFromStok(StokGrup grup);
        IResult Add(Stok entity);
        IResult Delete(Stok entity);
        IResult Update(Stok entity);
        IDataResult<List<Stok>> GetListByCategoryId(int categoryId);
    }
}