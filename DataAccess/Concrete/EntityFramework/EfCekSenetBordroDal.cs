using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCekSenetBordroDal : EfEntityRepositoryBase<CekSenetBordro, SIRKETLERContext>, ICekSenetBordroDal
    {
        private readonly ICekSenetMusteriDal _musteriCekSenetDal;
        private readonly ICekSenetBorcDal _borcCekSenetDal;

        public EfCekSenetBordroDal(ICekSenetMusteriDal musteriCekSenetDal, ICekSenetBorcDal borcCekSenetDal)
        {
            _musteriCekSenetDal = musteriCekSenetDal;
            _borcCekSenetDal = borcCekSenetDal;
        }

        public List<CekSenetBorc> GetBorcCekSenetListById(int id)
        {
            return _borcCekSenetDal.GetList(b => b.BordroTediyeId == id);
        }

        public List<CekSenetMusteri> GetMusteriTahsilatCekSenetListById(int id)
        {
            return _musteriCekSenetDal.GetList(m => m.BordroTahsilatId == id);
        }

        public List<CekSenetMusteri> GetMusteriTediyeCekSenetListById(int id)
        {
            return _musteriCekSenetDal.GetList(m => m.BordroTediyeId == id);
        }
    }
}