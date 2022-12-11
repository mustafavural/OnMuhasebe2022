using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IKiymetliEvrakBordroDal : IEntityRepository<KiymetliEvrakBordro>
    {
        List<BorcCekSenet> GetBorcCekSenetListById(int id);
        List<MusteriCekSenet> GetMusteriTahsilatCekSenetListById(int id);
        List<MusteriCekSenet> GetMusteriTediyeCekSenetListById(int id);
    }
}