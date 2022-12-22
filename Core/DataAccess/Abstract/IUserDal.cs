using Core.Entities.Concrete;

namespace Core.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
        List<OperationClaim> GetClaimList();
        void AddClaim(OperationClaim secilenClaim);
        void DeleteClaim(OperationClaim secilenClaim);
        void AddClaimToUser(UserOperationClaim userOperationClaim);
        void DeleteClaimFromUser(UserOperationClaim userOperationClaim);
        UserOperationClaim GetUserOperationClaim(int userId, int operationClaimId);
        void UpdateClaim(OperationClaim secilenClaim);
        UserCompany GetUserCompany(int userId, int companyId);
    }
}