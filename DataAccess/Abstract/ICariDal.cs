using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICariDal : IEntityRepository<Cari>
    {
        void AddCategoryToCari(CariGrup grup);
        void DeleteCategoryFromCari(CariGrup grup);
        List<CariCategory> GetCariCategoryler(int cariId);
        CariGrup GetCariGrup(int cariId, int cariCategoryId);
        List<CariHareket> GetCariHareketler(int cariId);
    }
}