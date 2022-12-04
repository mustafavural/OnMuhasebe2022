using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IIlceService
    {
        IDataResult<Ilce> GetById(int id);
        IDataResult<List<Ilce>> GetList(Expression<Func<Ilce, bool>>? filter = null);
        IDataResult<Ilce> GetByAd(string ad);
        IDataResult<List<Ilce>> GetListBySehirAd(string sehirAd);
    }
}
