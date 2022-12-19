using Core.Entities.Concrete;

namespace Core.DataAccess.Abstract
{
    public interface ICompanyDal : IEntityRepository<Company>
    {
        List<Company> GetListByUserId(int userId);
        List<User> GetUsers(Company company);
    }
}