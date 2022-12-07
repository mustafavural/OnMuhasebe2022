using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete.EntityFramework.Contexts;
using Core.Entities.Concrete;

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
    }
}