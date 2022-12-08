using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IMusteriEvrakService
    {
        IDataResult<MusteriEvrak> GetById(int id);
        IDataResult<List<MusteriEvrak>> GetList(Expression<Func<MusteriEvrak, bool>>? filter = null);
        IDataResult<List<MusteriEvrak>> GetListByAlinanCariId(int cariId);
        IDataResult<List<MusteriEvrak>> GetListByAsilBorclu(string name);
        IDataResult<List<MusteriEvrak>> GetListByAlisTarihi(DateTime alinanTarih);
        IResult Delete(MusteriEvrak entity);
        IResult Update(MusteriEvrak entity);
        IResult MusteridenEvraklarAl(List<MusteriEvrak> evraklar);
        IResult MusteriyeEvraklarCik(List<MusteriEvrak> evraklar);
    }
}