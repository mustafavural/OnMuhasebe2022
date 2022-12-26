using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStokDal : EfEntityRepositoryBase<Stok, SIRKETLERContext>, IStokDal
    {
        private readonly IStokGrupDal _stokGrupDal;

        public EfStokDal(IStokGrupDal stokGrupDal)
        {
            _stokGrupDal = stokGrupDal;
        }
        public void AddCategoryToStok(StokGrup grup)
        {
            _stokGrupDal.Add(grup);
        }
        public void DeleteCategoryFromStok(StokGrup grup)
        {
            _stokGrupDal.Delete(grup);
        }
        public StokGrup GetStokGrup(int stokId, int stokCategoryId)
        {
            return _stokGrupDal.Get(s => s.StokId == stokId && s.StokCategoryId == stokCategoryId);
        }
        public List<Stok> GetListByCategoryId(int stokCategoryId)
        {
            using var context = new SIRKETLERContext();
            var result = from stoklar in context.Stoklar
                         join gruplar in context.StokGruplar
                         on stoklar.Id equals gruplar.StokId
                         where gruplar.StokCategoryId == stokCategoryId
                         select stoklar;
            return result.ToList();
        }
        public List<StokCategory> GetStokCategoryler(int stokId)
        {
            using var context = new SIRKETLERContext();
            var result = from categoryler in context.StokCategoryler
                         join gruplar in context.StokGruplar
                         on categoryler.Id equals gruplar.StokCategoryId
                         where gruplar.StokId == stokId
                         select categoryler;

            return result.ToList();
        }
        public List<StokHareket> GetStokHareketler(int stokId)
        {
            using var context = new SIRKETLERContext();
            var result = from hareketler in context.StokHareketler
                         where hareketler.StokId == stokId
                         select hareketler;
            return result.ToList();
        }
    }
}