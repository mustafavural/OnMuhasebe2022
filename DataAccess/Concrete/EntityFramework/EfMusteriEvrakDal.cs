using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMusteriEvrakDal : EfEntityRepositoryBase<Entities.Concrete.MusteriEvrak, SIRKETLERContext>, IMusteriEvrakDal
    {

    }
}
