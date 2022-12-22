using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Linq.Expressions;

namespace Core.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        User GetById(int id);
        User GetByMail(string mail);
        List<OperationClaim> GetClaimList();
        IResult DeleteClaim(OperationClaim secilenClaim);
        IResult UpdateClaim(OperationClaim secilenClaim);
        IResult AddClaim(OperationClaim secilenClaim);
        UserOperationClaim GetUserOperationClaim(int userId, int operationClaimId);
        UserCompany GetUserCompany(int userId, int companyId);
        IResult AddClaimToUser(UserOperationClaim userOperationClaim);
        IResult DeleteClaimFromUser(UserOperationClaim userOperationClaim);
        void Add(User user);
        List<User> GetList(Expression<Func<User, bool>>? filter = null);
    }
}