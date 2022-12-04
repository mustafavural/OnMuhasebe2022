using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCariDal : EfEntityRepositoryBase<Cari, SIRKETLERContext>, ICariDal
    {
        ICariGrupDal _cariGrupDal;
        public EfCariDal(ICariGrupDal cariGrupDal)
        {
            _cariGrupDal = cariGrupDal;
        }

        public void AddCategoryToCari(CariGrup grup)
        {
            _cariGrupDal.Add(grup);
        }

        public void DeleteCategoryFromCari(CariGrup grup)
        {
            _cariGrupDal.Delete(grup);
        }

        public CariGrup GetCariGrup(int cariId, int cariCategoryId)
        {
            return _cariGrupDal.Get(s => s.CariId == cariId && s.CariCategoryId == cariCategoryId);
        }
        public List<CariCategory> GetCariCategoryler(int cariId)
        {
            using (var context = new SIRKETLERContext())
            {
                var result = from categoryler in context.CariCategoryler
                             join gruplar in context.CariGruplar
                             on categoryler.Id equals gruplar.CariCategoryId
                             where gruplar.CariId == cariId
                             select categoryler;
                return result.ToList();
            }
        }
        public List<CariHareket> GetCariHareketler(int cariId)
        {
            using (var context = new SIRKETLERContext())
            {
                var result = from hareketler in context.CariHareketler
                             where hareketler.Id == cariId
                             select hareketler;
                return result.ToList();
            }
        }
    }
}