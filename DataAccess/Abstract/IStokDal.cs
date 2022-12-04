using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IStokDal : IEntityRepository<Stok>
    {
        void AddCategoryToStok(StokGrup grup);
        void DeleteCategoryFromStok(StokGrup grup);
        List<Stok> GetListByCategoryId(int stokCategoryId);
        List<StokCategory> GetStokCategoryler(int stokId);
        StokGrup GetStokGrup(int stokId, int stokCategoryId);
        List<StokHareket> GetStokHareketler(int stokId);
    }
}