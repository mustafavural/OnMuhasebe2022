using Core.Entities.Concrete;
using System.Linq.Expressions;

namespace Core.Business.Abstract
{
    public interface ICompanyService
    {
        void Add(Company company);
        List<User> GetUsers(Company company);
        Company GetByName(string name);
        List<Company> GetList(Expression<Func<Company, bool>>? filter = null);
        List<Company> GetListByUserId(int userId);
    }
}