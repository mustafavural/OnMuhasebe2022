using Core.Entities.Concrete;

namespace Core.DataAccess.Abstract
{
    public interface ICompanyDal : IEntityRepository<Company>
    {
        void AddUserToCompany(UserCompany userCompany);
        void DeleteUserFromCompany(UserCompany userCompany);
        List<Company> GetListByUserId(int userId);
        List<User> GetUsers(Company company);
        void YearEndTransfer(Company sourceCompany, Company targetNewCompany);
    }
}