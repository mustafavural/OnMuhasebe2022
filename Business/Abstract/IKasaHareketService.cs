using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IKasaHareketService
    {
        IDataResult<KasaHareket> GetById(int id);
        IDataResult<List<KasaHareket>> GetList(Expression<Func<KasaHareket, bool>>? filter = null);
        IDataResult<KasaHareket> GetByEvrakNo(string evrakNo);
        IDataResult<List<KasaHareket>> GetListByKasaId(int kasaId);
        IDataResult<List<KasaHareket>> GetListBetweenTarihler(DateTime first, DateTime last);
        IDataResult<List<KasaHareket>> GetListBetweenFiyatlar(decimal min, decimal max);
        IResult Add(KasaHareket tahsilat);
        IResult Delete(KasaHareket tahsilat);
        IResult Update(KasaHareket tahsilat);
        IDataResult<decimal> GetKasaBakiye(int kasaId);
    }
}