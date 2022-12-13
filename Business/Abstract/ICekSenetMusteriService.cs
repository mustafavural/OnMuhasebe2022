using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICekSenetMusteriService
    {
        IDataResult<CekSenetMusteri> GetById(int id);
        IDataResult<CekSenetMusteri> GetByNo(string no);
        IDataResult<CekSenetMusteri> GetByAsilBorclu(string asilBorclu);
        IDataResult<List<CekSenetMusteri>> GetListByBordroTahsilat(int tahsilatId);
        IDataResult<List<CekSenetMusteri>> GetListByBordroTediye(int tediyeId);
        IDataResult<List<CekSenetMusteri>> GetListByVade(DateTime vade);
        IDataResult<List<CekSenetMusteri>> GetList(Expression<Func<CekSenetMusteri, bool>>? filter = null);
        IResult Add(CekSenetMusteri entity);
        IResult Delete(CekSenetMusteri entity);
        IResult Update(CekSenetMusteri entity);
    }
}