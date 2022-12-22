using Core.Entities.Concrete;

namespace Core.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<User> GetListByCompanyId(int companyId);
        List<OperationClaim> GetClaims(User user);
        UserCompany GetUserCompany(int userId, int companyId);
        UserOperationClaim GetUserOperationClaim(int userId, int operationClaimId);
        void DeleteClaimFromUser(UserOperationClaim userOperationClaim);
        void AddClaimToUser(UserOperationClaim userOperationClaim);
        bool IsinUse(int id);
    }
}