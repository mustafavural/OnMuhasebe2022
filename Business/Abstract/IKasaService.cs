using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IKasaService
    {
        IDataResult<Kasa> GetById(int id);
        IDataResult<List<Kasa>> GetList(Expression<Func<Kasa, bool>>? filter = null);
        IDataResult<Kasa> GetByAd(string kasaAd);
        IResult Add(Kasa kasa);
        IResult Delete(Kasa kasa);
        IResult Update(Kasa kasa);
    }
}