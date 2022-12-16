using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IBankaHesapService
    {
        IDataResult<Banka> GetById(int id);
        IDataResult<List<Banka>> GetList(Expression<Func<Banka, bool>>? filter = null);
        IDataResult<Banka> GetByHesapNo(string hesapNo);
        IDataResult<List<Banka>> GetListByBankaAd(string bankaAd);
        IDataResult<List<Banka>> GetListByBankaSubeAd(string bankaSubeAd);
        IDataResult<decimal> GetHesapBakiye(int hesapId);
        IResult Add(Banka bankaHesap);
        IResult Delete(Banka bankaHesap);
        IResult Update(Banka bankaHesap);
    }
}