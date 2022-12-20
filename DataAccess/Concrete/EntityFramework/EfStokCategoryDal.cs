using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStokCategoryDal : EfEntityRepositoryBase<StokCategory, SIRKETLERContext>, IStokCategoryDal
    {
        public List<StokGrup>? GetGrupList(int id)
        {
            using (var context = new SIRKETLERContext())
            {
                var result = from stokgrup in context.StokGruplar
                             where stokgrup.StokCategoryId == id
                             select stokgrup;
                return result.ToList();
            }
        }

        public List<StokCategory> GetListByStokId(int stokId)
        {
            using(var context = new SIRKETLERContext())
            {
                var result = from category in context.StokCategoryler
                             join grup in context.StokGruplar
                             on category.Id equals grup.StokCategoryId
                             where grup.StokId == stokId
                             select category;
                return result.ToList();
            }
        }
    }
}