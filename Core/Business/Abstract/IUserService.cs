using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Linq.Expressions;

namespace Core.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetById(int id);
        IDataResult<User> GetByMail(string mail);
        IDataResult<List<User>> GetListByCompanyId(int companyId);
        IDataResult<List<User>> GetList(Expression<Func<User, bool>>? filter = null);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<List<OperationClaim>> GetClaimList(Expression<Func<OperationClaim, bool>>? filter = null);
        IDataResult<UserCompany> GetUserCompany(int userId, int companyId);
        IDataResult<UserOperationClaim> GetUserOperationClaim(int userId, int operationClaimId);
        IResult AddClaim(OperationClaim secilenClaim);
        IResult UpdateClaim(OperationClaim secilenClaim);
        IResult DeleteClaim(OperationClaim secilenClaim);
        IResult AddClaimToUser(UserOperationClaim userOperationClaim);
        IResult DeleteClaimFromUser(UserOperationClaim userOperationClaim);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}