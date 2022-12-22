using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Security;
using Core.Business.Abstract;
using Core.Business.Constants;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Linq.Expressions;

namespace Core.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Company> GetById(int id)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(s => s.Id == id));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Company> GetByName(string name)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(s => s.Name == name));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Company>> GetListByUserId(int userId)
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetListByUserId(userId));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Company>> GetList(Expression<Func<Company, bool>>? filter = null)
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetList(filter));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<User>> GetUsers(Company company)
        {
            return new SuccessDataResult<List<User>>(_companyDal.GetUsers(company));
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult AddUserToCompany(UserCompany userCompany)
        {
            _companyDal.AddUserToCompany(userCompany);
            return new SuccessResult(CoreMessages.CompanyMessages.UserAddedToCompany);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult DeleteUserFromCompany(UserCompany userCompany)
        {
            _companyDal.DeleteUserFromCompany(userCompany);
            return new SuccessResult(CoreMessages.CompanyMessages.UserDeletedFromCompany);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult YearEndTransfer(Company sourceCompany, Company targetNewCompany)
        {
            _companyDal.YearEndTransfer(sourceCompany, targetNewCompany);
            return new SuccessResult(CoreMessages.CompanyMessages.YearEndTransferCompletedSuccessfully);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Add(Company company)
        {
            _companyDal.Add(company);
            return new SuccessResult(CoreMessages.CompanyMessages.CompanyAdded);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(Company company)
        {
            _companyDal.Delete(company);
            return new SuccessResult(CoreMessages.CompanyMessages.CompanyDeleted);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(Company company)
        {
            _companyDal.Update(company);
            return new SuccessResult(CoreMessages.CompanyMessages.CompanyModified);
        }
    }
}