using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Linq.Expressions;

namespace Core.Business.Abstract
{
    public interface ICompanyService
    {
        IDataResult<Company> GetById(int id);
        IDataResult<Company> GetByName(string name);
        IDataResult<List<User>> GetUsers(Company company);
        IDataResult<List<Company>> GetListByUserId(int userId);
        IDataResult<List<Company>> GetList(Expression<Func<Company, bool>>? filter = null);
        IResult Add(Company company);
        IResult Delete(Company company);
        IResult Update(Company company);
        IResult YearEndTransfer(Company sourceCompany, Company targetNewCompany);
        void DeleteUserFromCompany(UserCompany userCompany);
        void AddUserToCompany(UserCompany userCompany);
    }
}