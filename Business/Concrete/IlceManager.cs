using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class IlceManager : IIlceService
    {
        private readonly IIlceDal _ilceDal;
        private readonly ISehirService _sehirService;

        public IlceManager(IIlceDal ilceDal, ISehirService sehirService)
        {
            _ilceDal = ilceDal;
            _sehirService = sehirService;
        }

        public IDataResult<Ilce> GetById(int id)
        {
            var ilce = _ilceDal.GetById(id);
            if (ilce != null)
            {
                var sehir = _sehirService.GetById(ilce.SehirId).Data;
                ilce.Sehir = sehir;
                ilce.SehirId = sehir.Id;
            }
            return new SuccessDataResult<Ilce>(ilce);
        }

        public IDataResult<Ilce> GetByAd(string ad)
        {
            var ilce = _ilceDal.Get(s => s.Ad == ad);
            if (ilce != null)
            {
                var sehir = _sehirService.GetById(ilce.SehirId).Data;
                ilce.Sehir = sehir;
                ilce.SehirId = sehir.Id;
            }
            return new SuccessDataResult<Ilce>(ilce);
        }

        public IDataResult<List<Ilce>> GetListBySehirAd(string sehirAd)
        {
            List<Ilce> result = new List<Ilce>();
            var sehir = _sehirService.GetByAd(sehirAd).Data;
            if (sehir != null)
            {
                result = _ilceDal.GetList(s => s.SehirId == sehir.Id);
                result.ForEach(s => s.Sehir = sehir);
                result.ForEach(s => s.SehirId = sehir.Id);
            }
            return new SuccessDataResult<List<Ilce>>(result);
        }

        public IDataResult<List<Ilce>> GetList(Expression<Func<Ilce, bool>>? filter = null)
        {
            var ilceler = _ilceDal.GetList(filter);
            var sehirler = _sehirService.GetList(x => ilceler.Select(y => y.SehirId).Contains(x.Id)).Data;
            ilceler.ForEach(s => s.Sehir = sehirler.Where(a => a.Id == s.SehirId).Single());
            ilceler.ForEach(s => s.SehirId = sehirler.Where(a => a.Id == s.SehirId).Single().Id);
            return new SuccessDataResult<List<Ilce>>(ilceler.ToList());
        }
    }
}