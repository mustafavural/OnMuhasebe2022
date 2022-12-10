using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IKiymetliEvrakBordroService
    {
        IDataResult<KiymetliEvrakBordro> GetById(int id);
        IDataResult<KiymetliEvrakBordro> GetByNo(string no);
        IDataResult<KiymetliEvrakBordro> GetByTur(string tur);
        IDataResult<List<KiymetliEvrakBordro>> GetListByCariId(int cariId);
        IDataResult<List<KiymetliEvrakBordro>> GetListByBordroTediye(int tediyeId);
        IDataResult<List<KiymetliEvrakBordro>> GetListBetweenTarihler(DateTime ilk, DateTime son);
        IDataResult<List<KiymetliEvrakBordro>> GetList(Expression<Func<KiymetliEvrakBordro, bool>>? filter = null);
        IResult Add(KiymetliEvrakBordro entity);
        IResult Delete(KiymetliEvrakBordro entity);
        IResult Update(KiymetliEvrakBordro entity);
    }
}