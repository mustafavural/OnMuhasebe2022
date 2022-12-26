using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Security;
using Core.Business.Abstract;
using Core.Business.Constants;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using Core.Extensions;
using Core.Utilities.Business;
using Core.Utilities.Results;
using System.Linq.Expressions;
using System.Media;

namespace Core.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        #region BusinessRules

        private IResult KontrolSirketYiliGuncelMi(string year)
        {
            return DateTime.Today.Year <= year.ToInt() ? new SuccessResult() : new ErrorResult(CoreMessages.CompanyMessages.YearOuOfDate);
        }

        private IResult KontrolSirketZatenVarMi(string name)
        {
            return _companyDal.Get(s => s.Name == name) == null ? new SuccessResult() : new ErrorResult(CoreMessages.CompanyMessages.CompanyAlreadyExist);
        }

        private IResult KontrolSirketMevcutMu(int id)
        {
            return _companyDal.Get(s => s.Id == id) != null ? new SuccessResult() : new ErrorResult(CoreMessages.CompanyMessages.CompanyNotFound);
        }
        #endregion

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
        public IResult InsertSQLQuery(string sql)
        {
            var result = _companyDal.ExecuteSQLQuery(sql);
            return new SuccessResult(result + CoreMessages.CompanyMessages.CompanyTableCreatedSuccessfully);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Add(Company company)
        {
            var result = BusinessRules.Run(KontrolSirketZatenVarMi(company.Name),
                                           KontrolSirketYiliGuncelMi(company.Year));
            if (!result.IsSuccess)
                return result;

            _companyDal.Add(company);
            return new SuccessResult(CoreMessages.CompanyMessages.CompanyAdded);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(Company company)
        {
            var result = BusinessRules.Run(KontrolSirketMevcutMu(company.Id));
            if (!result.IsSuccess)
                return result;

            _companyDal.Delete(company);
            return new SuccessResult(CoreMessages.CompanyMessages.CompanyDeleted);
        }

        [SecuredOperation("Admin")]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(Company company)
        {
            var result = BusinessRules.Run(KontrolSirketMevcutMu(company.Id),
                                           KontrolSirketYiliGuncelMi(company.Year));
            if (!result.IsSuccess)
                return result;

            _companyDal.Update(company);
            return new SuccessResult(CoreMessages.CompanyMessages.CompanyModified);
        }
    }
}