using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete.EntityFramework.Contexts;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfOperationClaimDal : EfEntityRepositoryBase<OperationClaim, MVMasterContext>, IOperationClaimDal
    {
        public List<OperationClaim> GetListByUserId(int userId)
        {
            using var context = new MVMasterContext();
            var result = from operationClaim in context.OperationClaims
                         join userOperationClaim in context.UserOperationClaims
                         on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == userId
                         select operationClaim;

            return result.ToList();
        }

        public bool IsInUse(int id)
        {
            using var context = new MVMasterContext();
            var result = from userOperationClaim in context.UserOperationClaims
                         where userOperationClaim.OperationClaimId == id
                         select userOperationClaim;
            return result.Any();
        }
    }
}