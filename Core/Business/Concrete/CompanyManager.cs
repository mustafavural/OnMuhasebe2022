using Core.Business.Abstract;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;

namespace Core.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void Add(Company company)
        {
            _companyDal.Add(company);
        }

        public Company GetByName(string name)
        {
            return _companyDal.Get(s => s.Name == name);
        }

        public List<Company> GetList()
        {
            return _companyDal.GetList();
        }

        public List<User> GetUsers(Company company)
        {
            return _companyDal.GetUsers(company);
        }
    }
}
