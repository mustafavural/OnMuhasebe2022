using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IBankaHareketService
    {
        IDataResult<BankaHareket> GetById(int id);
        IDataResult<List<BankaHareket>> GetList(Expression<Func<BankaHareket, bool>>? filter = null);
        IDataResult<BankaHareket> GetByEvrakNo(string evrakNo);
        IDataResult<List<BankaHareket>> GetListByBankaHesapId(int bankaHesapId);
        IDataResult<List<BankaHareket>> GetListByCariId(int cariId);
        IDataResult<List<BankaHareket>> GetListBetweenTarihler(DateTime first, DateTime last);
        IDataResult<List<BankaHareket>> GetListBetweenFiyatlar(decimal min, decimal max);
        IResult Add(BankaHareket bankaHareket);
        IResult Delete(BankaHareket bankaHareket);
        IResult Update(BankaHareket bankaHareket);
    }
}