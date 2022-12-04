using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IDegerliEvrakService
    {
        IDataResult<DegerliEvrak> GetById(int id);
        IDataResult<List<DegerliEvrak>> GetList(Expression<Func<DegerliEvrak, bool>>? filter = null);
        IDataResult<DegerliEvrak> GetByKod(string kod);
        IDataResult<List<DegerliEvrak>> GetListByVerilenCariId(int verilenCariId);
        IDataResult<List<DegerliEvrak>> GetListByVade(DateTime vade);
        IDataResult<List<DegerliEvrak>> GetListByCikisTarihi(DateTime cikisTarihi);
        IResult Add(DegerliEvrak entity);
        IResult Delete(DegerliEvrak entity);
        IResult Update(DegerliEvrak entity);
    }
}