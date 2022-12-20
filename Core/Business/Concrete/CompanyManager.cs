using Core.Aspects.Autofac.Security;
using Core.Business.Abstract;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
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
        public void Add(Company company)
        {
            _companyDal.Add(company);
        }

        [SecuredOperation("Admin")]
        public void Delete(Company company)
        {
            _companyDal.Delete(company);
        }

        [SecuredOperation("Admin")]
        public Company GetByName(string name)
        {
            return _companyDal.Get(s => s.Name == name);
        }

        [SecuredOperation("Admin")]
        public List<Company> GetList(Expression<Func<Company, bool>>? filter = null)
        {
            return _companyDal.GetList(filter);
        }

        [SecuredOperation("Admin")]
        public List<Company> GetListByUserId(int userId)
        {
            return _companyDal.GetListByUserId(userId);
        }

        [SecuredOperation("Admin")]
        public List<User> GetUsers(Company company)
        {
            return _companyDal.GetUsers(company);
        }
    }
}
