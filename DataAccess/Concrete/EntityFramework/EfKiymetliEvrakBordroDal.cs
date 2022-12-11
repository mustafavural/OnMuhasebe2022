using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKiymetliEvrakBordroDal : EfEntityRepositoryBase<KiymetliEvrakBordro, SIRKETLERContext>, IKiymetliEvrakBordroDal
    {
        private readonly IMusteriCekSenetDal _musteriCekSenetDal;
        private readonly IBorcCekSenetDal _borcCekSenetDal;

        public EfKiymetliEvrakBordroDal(IMusteriCekSenetDal musteriCekSenetDal, IBorcCekSenetDal borcCekSenetDal)
        {
            _musteriCekSenetDal = musteriCekSenetDal;
            _borcCekSenetDal = borcCekSenetDal;
        }

        public List<BorcCekSenet> GetBorcCekSenetListById(int id)
        {
            return _borcCekSenetDal.GetList(b => b.BordroTediyeId == id);
        }

        public List<MusteriCekSenet> GetMusteriTahsilatCekSenetListById(int id)
        {
            return _musteriCekSenetDal.GetList(m => m.BordroTahsilatId == id);
        }

        public List<MusteriCekSenet> GetMusteriTediyeCekSenetListById(int id)
        {
            return _musteriCekSenetDal.GetList(m => m.BordroTediyeId == id);
        }
    }
}