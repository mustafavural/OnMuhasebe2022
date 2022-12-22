using Core.Aspects.Autofac.Security;
using Core.Business.Abstract;
using Core.Business.Constants;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using System.Linq.Expressions;

namespace Core.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        #region BusinessRules
        private IResult KontrolClaimZatenAtanmisMi(UserOperationClaim userOperationClaim)
        {
            return _userDal.GetUserOperationClaim(userOperationClaim.UserId, userOperationClaim.OperationClaimId) == null
                ? new SuccessResult() : new ErrorResult(CoreMessages.Authorization.ClaimAlreadyAddedToUser);
        }
        #endregion

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetById(int id)
        {
            return _userDal.Get(u => u.Id == id);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
        public List<OperationClaim> GetClaimList()
        {
            return _userDal.GetClaimList();
        }

        public IResult AddClaim(OperationClaim secilenClaim)
        {
            _userDal.AddClaim(secilenClaim);
            return new SuccessResult(CoreMessages.Authorization.ClaimAdded);
        }

        public IResult DeleteClaim(OperationClaim secilenClaim)
        {
            _userDal.DeleteClaim(secilenClaim);
            return new SuccessResult(CoreMessages.Authorization.ClaimDeleted);
        }

        public IResult UpdateClaim(OperationClaim secilenClaim)
        {
            _userDal.UpdateClaim(secilenClaim);
            return new SuccessResult(CoreMessages.Authorization.ClaimModified);
        }

        public UserOperationClaim GetUserOperationClaim(int userId, int operationClaimId)
        {
            return _userDal.GetUserOperationClaim(userId, operationClaimId);
        }

        public IResult AddClaimToUser(UserOperationClaim userOperationClaim)
        {
            var result = BusinessRules.Run(KontrolClaimZatenAtanmisMi(userOperationClaim));
            if (!result.IsSuccess)
                return result;

            _userDal.AddClaimToUser(userOperationClaim);
            return new SuccessResult(CoreMessages.Authorization.ClaimAddedToUser);
        }

        public IResult DeleteClaimFromUser(UserOperationClaim userOperationClaim)
        {
            _userDal.DeleteClaimFromUser(userOperationClaim);
            return new SuccessResult(CoreMessages.Authorization.ClaimDeletedFromUser);
        }

        public List<User> GetList(Expression<Func<User, bool>>? filter = null)
        {
            return _userDal.GetList();
        }

        public UserCompany GetUserCompany(int userId, int companyId)
        {
            return _userDal.GetUserCompany(userId, companyId);
        }
    }
}