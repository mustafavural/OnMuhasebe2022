using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICariHareketService
    {
        IDataResult<CariHareket> GetById(int id);
        IDataResult<List<CariHareket>> GetList(Expression<Func<CariHareket, bool>>? filter = null);
        IResult Add(CariHareket entity);
        IResult Delete(CariHareket entity);
        IDataResult<decimal> GetCariBakiye(string cariKod);
        IDataResult<List<CariHareket>> GetListByCariId(int cariId);
        IResult Update(CariHareket entity);
    }
}