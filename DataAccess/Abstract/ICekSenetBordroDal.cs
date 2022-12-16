using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICekSenetBordroDal : IEntityRepository<CekSenetBordro>
    {
        List<CekSenetBorc> GetBorcTediyeCekSenetListById(int id);
        List<CekSenetMusteri> GetTahsilatCekSenetListById(int id);
        List<CekSenetMusteri> GetCiroTediyeCekSenetListById(int id);
    }
}