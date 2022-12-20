using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IStokCategoryDal : IEntityRepository<StokCategory>
    {
        List<StokGrup>? GetGrupList(int ıd);
        List<StokCategory> GetListByStokId(int stokId);
    }
}