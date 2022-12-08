using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IStokHareketService
    {
        IDataResult<StokHareket> GetById(int id);
        IDataResult<List<StokHareket>> GetListByFaturaId(int faturaId);
        IDataResult<List<StokHareket>> GetListByStokId(int stokId);
        IDataResult<decimal> GetStokBakiye(string stokKod);
        IResult Add(StokHareket entity);
        IResult Delete(StokHareket entity);
        IResult Update(StokHareket entity);
    }
}