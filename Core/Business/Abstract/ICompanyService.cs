using Core.Entities.Concrete;

namespace Core.Business.Abstract
{
    public interface ICompanyService
    {
        void Add(Company company);
        List<User> GetUsers(Company company);
        Company GetByName(string name);
        List<Company> GetList();
    }
}