using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IBankaHesapService
    {
        IDataResult<BankaHesap> GetById(int id);
        IDataResult<List<BankaHesap>> GetList(Expression<Func<BankaHesap, bool>>? filter = null);
        IDataResult<BankaHesap> GetByHesapNo(string hesapNo);
        IDataResult<List<BankaHesap>> GetListByBankaAd(string bankaAd);
        IDataResult<List<BankaHesap>> GetListByBankaSubeAd(string bankaSubeAd);
        IDataResult<decimal> GetHesapBakiye(int hesapId);
        IResult Add(BankaHesap bankaHesap);
        IResult Delete(BankaHesap bankaHesap);
        IResult Update(BankaHesap bankaHesap);
    }
}