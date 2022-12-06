using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IFaturaService
    {
        IDataResult<Fatura> GetById(int id);
        IDataResult<List<Fatura>> GetList(Expression<Func<Fatura, bool>>? filter = null);
        IDataResult<Fatura> GetByNo(string no);
        IDataResult<List<Fatura>> GetListByTur(string tur);
        IDataResult<List<Fatura>> GetListByCariKod(string cariKod);
        IDataResult<List<Fatura>> GetListBetweenTarihler(DateTime ilk, DateTime son);
        IDataResult<List<Fatura>> GetListBetweenKayitTarihler(DateTime ilk, DateTime son);
        IDataResult<List<int>> GetFaturaKdvler(string no);
        IDataResult<decimal?> GetBrutToplam(string no);
        IDataResult<decimal?> GetNetToplam(string no);
        IResult Add(Fatura fatura);
        IResult Delete(Fatura fatura);
        IResult Update(Fatura fatura);
    }
}