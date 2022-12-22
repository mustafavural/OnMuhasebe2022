using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Security;
using Core.Aspects.Autofac.Validation;
using Core.Business.Abstract;
using Core.Business.Constants;
using Core.Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
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
        private readonly IOperationClaimDal _operationClaimDal;

        public UserManager(IUserDal userDal, IOperationClaimDal operationClaimDal)
        {
            _userDal = userDal;
            _operationClaimDal = operationClaimDal;
        }

        #region BusinessRules
        private IResult KontrolYetkiZatenAtanmisMi(UserOperationClaim userOperationClaim)
        {
            return _userDal.GetUserOperationClaim(userOperationClaim.UserId, userOperationClaim.OperationClaimId) == null
                ? new SuccessResult() : new ErrorResult(CoreMessages.ClaimMessages.ClaimAlreadyAddedToUser);
        }
        private IResult KontrolYetkiZatenVarMi(string name)
        {
            return _operationClaimDal.Get(s => s.Name == name) == null ? new SuccessResult() : new ErrorResult(CoreMessages.ClaimMessages.AlreadyExist);
        }
        private IResult KontrolYetkiKullaniliyorMu(int id)
        {
            return !_operationClaimDal.IsInUse(id) ? new SuccessResult() : new ErrorResult(CoreMessages.ClaimMessages.InUse);
        }
        private IResult KontrolKullaniciKullaniliyorMu(int id)
        {
            return !_userDal.IsinUse(id) ? new SuccessResult() : new ErrorResult(CoreMessages.UserMessages.InUse);
        }
        #endregion


        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<User>> GetListByCompanyId(int companyId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetListByCompanyId(companyId));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<User>> GetList(Expression<Func<User, bool>>? filter = null)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetList());
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<OperationClaim>> GetClaimList(Expression<Func<OperationClaim, bool>>? filter = null)
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationClaimDal.GetList(filter));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<UserCompany> GetUserCompany(int userId, int companyId)
        {
            return new SuccessDataResult<UserCompany>(_userDal.GetUserCompany(userId, companyId));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<UserOperationClaim> GetUserOperationClaim(int userId, int operationClaimId)
        {
            return new SuccessDataResult<UserOperationClaim>(_userDal.GetUserOperationClaim(userId, operationClaimId));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult AddClaim(OperationClaim secilenClaim)
        {
            var result = BusinessRules.Run(KontrolYetkiZatenVarMi(secilenClaim.Name));
            if (!result.IsSuccess)
                return result;

            _operationClaimDal.Add(secilenClaim);
            return new SuccessResult(CoreMessages.ClaimMessages.OperationClaimAdded);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult DeleteClaim(OperationClaim secilenClaim)
        {
            var result = BusinessRules.Run(KontrolYetkiKullaniliyorMu(secilenClaim.Id));
            if (!result.IsSuccess)
                return result;

            _operationClaimDal.Delete(secilenClaim);
            return new SuccessResult(CoreMessages.ClaimMessages.OperationClaimDeleted);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult UpdateClaim(OperationClaim secilenClaim)
        {
            _operationClaimDal.Update(secilenClaim);
            return new SuccessResult(CoreMessages.ClaimMessages.OperationClaimUpdated);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult AddClaimToUser(UserOperationClaim userOperationClaim)
        {
            var result = BusinessRules.Run(KontrolYetkiZatenAtanmisMi(userOperationClaim));
            if (!result.IsSuccess)
                return result;

            _userDal.AddClaimToUser(userOperationClaim);
            return new SuccessResult(CoreMessages.ClaimMessages.ClaimAddedToUser);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult DeleteClaimFromUser(UserOperationClaim userOperationClaim)
        {
            _userDal.DeleteClaimFromUser(userOperationClaim);
            return new SuccessResult(CoreMessages.ClaimMessages.ClaimDeletedFromUser);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        [ValidationAspect(typeof(UserRegisterValidator))]
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(CoreMessages.UserMessages.UserAdded);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(User user)
        {
            var result = BusinessRules.Run(KontrolKullaniciKullaniliyorMu(user.Id));
            if (!result.IsSuccess)
                return result;

            _userDal.Delete(user);
            return new SuccessResult(CoreMessages.UserMessages.UserDeleted);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(CoreMessages.UserMessages.UserUpdated);
        }
    }
}