using Core.Entities.Concrete;

namespace Core.DataAccess.Abstract
{
    public interface ICompanyDal : IEntityRepository<Company>
    {
        List<User> GetUsers(Company company);
    }
}