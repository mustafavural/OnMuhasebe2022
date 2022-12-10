using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKiymetliEvrakBordroDal : EfEntityRepositoryBase<KiymetliEvrakBordro, SIRKETLERContext>, IKiymetliEvrakBordroDal
    {

    }
}