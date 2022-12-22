using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete.EntityFramework.Contexts;
using Core.Entities.Abstract;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, MVMasterContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using var context = new MVMasterContext();
            var result = from operationClaim in context.OperationClaims
                         join userOperationClaim in context.UserOperationClaims
                         on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.Id
                         select operationClaim;

            return result.ToList();
        }

        public void AddClaimToUser(UserOperationClaim userOperationClaim)
        {
            using var context = new MVMasterContext();
            var addedEntity = context.Entry(userOperationClaim);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void DeleteClaimFromUser(UserOperationClaim userOperationClaim)
        {
            using var context = new MVMasterContext();
            var addedEntity = context.Entry(userOperationClaim);
            addedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public UserOperationClaim GetUserOperationClaim(int userId, int operationClaimId)
        {
            using var context = new MVMasterContext();
            var result = from userOperationClaim in context.UserOperationClaims
                         where userOperationClaim.UserId == userId && userOperationClaim.OperationClaimId == operationClaimId
                         select userOperationClaim;

            return result.SingleOrDefault();
        }

        public UserCompany GetUserCompany(int userId, int companyId)
        {
            using var context = new MVMasterContext();
            var result = from UserCompany in context.UserCompanies
                         where UserCompany.UserId == userId && UserCompany.CompanyId == companyId
                         select UserCompany;

            return result.SingleOrDefault();
        }

        public List<User> GetListByCompanyId(int companyId)
        {
            using var context = new MVMasterContext();
            var result = from user in context.Users
                         join userCompany in context.UserCompanies
                         on user.Id equals userCompany.UserId
                         where userCompany.CompanyId == companyId
                         select user;

            return result.ToList();
        }

        public bool IsinUse(int id)
        {
            using var context = new MVMasterContext();
            var resultClaim = from user in context.UserOperationClaims
                         where user.UserId == id
                         select user;
            var resultCompany = from user in context.UserCompanies
                         where user.UserId == id
                         select user;
            return resultClaim.Any() || resultCompany.Any();
        }
    }
}