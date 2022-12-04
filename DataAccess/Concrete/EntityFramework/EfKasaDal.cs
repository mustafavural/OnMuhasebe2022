using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKasaDal : EfEntityRepositoryBase<Entities.Concrete.Kasa, SIRKETLERContext>, IKasaDal
    {

    }
}