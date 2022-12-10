using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IBorcCekSenetService
    {
        IDataResult<BorcCekSenet> GetById(int id);
        IDataResult<BorcCekSenet> GetByNo(string no);
        IDataResult<List<BorcCekSenet>> GetListByBordroTediye(int tediyeId);
        IDataResult<List<BorcCekSenet>> GetListByVade(DateTime vade);
        IDataResult<List<BorcCekSenet>> GetList(Expression<Func<BorcCekSenet, bool>>? filter = null);
        IResult Add(BorcCekSenet entity);
        IResult Delete(BorcCekSenet entity);
        IResult Update(BorcCekSenet entity);
    }
}