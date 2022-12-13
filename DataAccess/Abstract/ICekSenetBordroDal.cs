using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICekSenetBordroDal : IEntityRepository<CekSenetBordro>
    {
        List<CekSenetBorc> GetBorcCekSenetListById(int id);
        List<CekSenetMusteri> GetMusteriTahsilatCekSenetListById(int id);
        List<CekSenetMusteri> GetMusteriTediyeCekSenetListById(int id);
    }
}