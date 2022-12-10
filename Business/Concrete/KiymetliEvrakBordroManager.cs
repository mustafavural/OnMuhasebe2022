using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class KiymetliEvrakBordroManager : IKiymetliEvrakBordroService
    {
        public IResult Add(KiymetliEvrakBordro entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(KiymetliEvrakBordro entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<KiymetliEvrakBordro> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<KiymetliEvrakBordro> GetByNo(string no)
        {
            throw new NotImplementedException();
        }

        public IDataResult<KiymetliEvrakBordro> GetByTur(string tur)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<KiymetliEvrakBordro>> GetList(Expression<Func<KiymetliEvrakBordro, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<KiymetliEvrakBordro>> GetListBetweenTarihler(DateTime ilk, DateTime son)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<KiymetliEvrakBordro>> GetListByBordroTediye(int tediyeId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<KiymetliEvrakBordro>> GetListByCariId(int cariId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(KiymetliEvrakBordro entity)
        {
            throw new NotImplementedException();
        }
    }
}