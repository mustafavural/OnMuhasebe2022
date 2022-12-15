using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICekSenetBorcService
    {
        IDataResult<CekSenetBorc> GetById(int id);
        IDataResult<CekSenetBorc> GetByNo(string no);
        IDataResult<int> GetLastRowIndex();
        IDataResult<List<CekSenetBorc>> GetListByBordroTediye(int tediyeId);
        IDataResult<List<CekSenetBorc>> GetListByVade(DateTime vade);
        IDataResult<List<CekSenetBorc>> GetList(Expression<Func<CekSenetBorc, bool>>? filter = null);
        IResult Add(CekSenetBorc entity);
        IResult Delete(CekSenetBorc entity);
        IResult Update(CekSenetBorc entity);
    }
}