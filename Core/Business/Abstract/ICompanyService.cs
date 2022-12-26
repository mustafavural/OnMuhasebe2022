using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Linq.Expressions;

namespace Core.Business.Abstract
{
    public interface ICompanyService
    {
        IDataResult<Company> GetById(int id);
        IDataResult<Company> GetByName(string name);
        IDataResult<List<Company>> GetListByUserId(int userId);
        IDataResult<List<Company>> GetList(Expression<Func<Company, bool>>? filter = null);
        IDataResult<List<User>> GetUsers(Company company);
        IResult AddUserToCompany(UserCompany userCompany);
        IResult DeleteUserFromCompany(UserCompany userCompany);
        IResult YearEndTransfer(Company sourceCompany, Company targetNewCompany);
        IResult InsertSQLQuery(string sql);
        IResult Add(Company company);
        IResult Delete(Company company);
        IResult Update(Company company);
    }
}