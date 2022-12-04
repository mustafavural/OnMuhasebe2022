using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSehirDal : EfEntityRepositoryBase<Entities.Concrete.Sehir, SIRKETLERContext>, ISehirDal
    {

    }
}