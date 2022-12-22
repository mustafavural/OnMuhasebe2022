using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete.EntityFramework.Contexts;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

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

        public void YearEndTransfer(Company sourceCompany, Company targetNewCompany)
        {
            throw new NotImplementedException();
        }

        public void AddUserToCompany(UserCompany userCompanyny)
        {
            using var context = new MVMasterContext();
            var addedEntity = context.Entry(userCompanyny);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void DeleteUserFromCompany(UserCompany userCompanyny)
        {
            using var context = new MVMasterContext();
            var addedEntity = context.Entry(userCompanyny);
            addedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}