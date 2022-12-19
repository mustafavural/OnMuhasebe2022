using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete.EntityFramework.Contexts;
using Core.Entities.Concrete;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfCompanyDal : EfEntityRepositoryBase<Company, MVMasterContext>, ICompanyDal
    {
        public List<User> GetUsers(Company company)
        {
            using var context = new MVMasterContext();
            var result = from user in context.Users
                         join userCompany in context.UserCompanies
                         on user.Id equals userCompany.UserId
                         where userCompany.CompanyId == company.Id
                         select user;

            return result.ToList();
        }

        public List<Company> GetListByUserId(int userId)
        {
            using var context = new MVMasterContext();
            var result = from company in context.Companies
                         join groups in context.UserCompanies
                         on company.Id equals groups.CompanyId
                         where groups.UserId == userId
                         select company;
            return result.ToList();
        }
    }
}