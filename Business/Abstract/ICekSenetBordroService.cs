using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICekSenetBordroService
    {
        IDataResult<CekSenetBordro> GetById(int id);
        IDataResult<CekSenetBordro> GetByNo(string no);
        IDataResult<int> GetLastRowIndex();
        IDataResult<List<CekSenetBordro>> GetListByTur(string tur);
        IDataResult<List<CekSenetBordro>> GetListByCariId(int cariId);
        IDataResult<List<CekSenetMusteri>> GetTahsilatCekSenetListById(int id);
        IDataResult<List<CekSenetBorc>> GetBorcTediyeCekSenetListById(int id);
        IDataResult<List<CekSenetMusteri>> GetCiroTediyeCekSenetListById(int id);
        IDataResult<List<CekSenetBordro>> GetListBetweenTarihler(DateTime ilk, DateTime son);
        IDataResult<List<CekSenetBordro>> GetList(Expression<Func<CekSenetBordro, bool>>? filter = null);
        IResult Add(CekSenetBordro entity);
        IResult Delete(CekSenetBordro entity);
        IResult Update(CekSenetBordro entity);
    }
}