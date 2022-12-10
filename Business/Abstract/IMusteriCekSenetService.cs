using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IMusteriCekSenetService
    {
        IDataResult<MusteriCekSenet> GetById(int id);
        IDataResult<MusteriCekSenet> GetByNo(string no);
        IDataResult<MusteriCekSenet> GetByAsilBorclu(string asilBorclu);
        IDataResult<List<MusteriCekSenet>> GetListByBordroTahsilat(int tahsilatId);
        IDataResult<List<MusteriCekSenet>> GetListByBordroTediye(int tediyeId);
        IDataResult<List<MusteriCekSenet>> GetListByVade(DateTime vade);
        IDataResult<List<MusteriCekSenet>> GetList(Expression<Func<MusteriCekSenet, bool>>? filter = null);
        IResult Add(MusteriCekSenet entity);
        IResult Delete(MusteriCekSenet entity);
        IResult Update(MusteriCekSenet entity);
    }
}