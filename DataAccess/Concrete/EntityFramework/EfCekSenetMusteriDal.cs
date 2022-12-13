using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCekSenetMusteriDal : EfEntityRepositoryBase<CekSenetMusteri, SIRKETLERContext>, ICekSenetMusteriDal
    {

    }
}