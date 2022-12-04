using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IMusteriEvrakService : IDegerliEvrakService
    {
        new IDataResult<MusteriEvrak> GetById(int id);
        IDataResult<List<MusteriEvrak>> GetList(Expression<Func<MusteriEvrak, bool>>? filter = null);
        IDataResult<List<MusteriEvrak>> GetListByAlinanCariId(int cariId);
        IDataResult<List<MusteriEvrak>> GetListByAsilBorclu(string name);
        IDataResult<List<MusteriEvrak>> GetListByAlisTarihi(DateTime alinanTarih);
        IResult Add(MusteriEvrak entity);
        IResult Delete(MusteriEvrak entity);
        IResult Update(MusteriEvrak entity);
        IResult MusteridenEvrakAl(List<MusteriEvrak> evraklar);
        IResult MusteriyeEvrakCik(List<MusteriEvrak> evraklar);
    }
}