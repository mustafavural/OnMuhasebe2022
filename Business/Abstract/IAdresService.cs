using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IAdresService
    {
        IDataResult<Adres> GetById(int id);
        IDataResult<List<Adres>> GetList(Expression<Func<Adres, bool>>? filter = null);
        IDataResult<Adres> GetByTelNo(string telNo);
        IDataResult<Adres> GetByWeb(string web);
        IDataResult<Adres> GetByEposta(string ePosta);
        IDataResult<List<Adres>> GetListByIlce(string ilceAd);
        IDataResult<List<Adres>> GetListBySehir(string sehirAd);
        IResult Add(Adres entity);
        IResult Delete(Adres entity);
        IResult Update(Adres entity);
    }
}