using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBorcCekSenetDal : EfEntityRepositoryBase<BorcCekSenet, SIRKETLERContext>, IBorcCekSenetDal
    {

    }
}