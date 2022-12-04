using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICariService
    {
        IDataResult<Cari> GetById(int id);
        IDataResult<List<Cari>> GetList(Expression<Func<Cari, bool>>? filter = null);
        IDataResult<Cari> GetByKod(string cariKod);
        IDataResult<Cari> GetByVergiNo(string vergiNo);
        IDataResult<CariGrup> GetCariGrup(int cariId, int cariCategoryId);
        IResult AddCategoryToCari(CariGrup grup);
        IResult DeleteCategoryFromCari(CariGrup grup);
        IResult Add(Cari entity);
        IResult Delete(Cari entity);
        IResult Update(Cari entity);
        IDataResult<Cari> GetByTelNo(string telNo);
        IDataResult<Cari> GetByWeb(string web);
        IDataResult<Cari> GetByEposta(string ePosta);
        IDataResult<List<Cari>> GetListByIlce(string ilceAd);
        IDataResult<List<Cari>> GetListBySehir(string sehirAd);
    }
}