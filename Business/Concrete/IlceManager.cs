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

        private Ilce Get(Expression<Func<Ilce, bool>> filter)
        {
            var ilce = _ilceDal.Get(filter);
            if (ilce != null)
            {
                var sehir = _sehirService.GetById(ilce.SehirId).Data;
                ilce.Sehir = sehir;
                ilce.SehirId = sehir.Id;
            }
            return ilce;
        }

        public IDataResult<List<Ilce>> GetList(Expression<Func<Ilce, bool>>? filter = null)
        {
            var ilceler = _ilceDal.GetList(filter);
            var sehirler = _sehirService.GetList(x => ilceler.Select(y => y.SehirId).Contains(x.Id)).Data;
            ilceler.ForEach(s => s.Sehir = sehirler.Where(a => a.Id == s.SehirId).Single());
            return new SuccessDataResult<List<Ilce>>(ilceler.ToList());
        }

        public IDataResult<Ilce> GetById(int id)
        {
            return new SuccessDataResult<Ilce>(Get(i => i.Id == id));
        }

        public IDataResult<Ilce> GetByAd(string ad)
        {
            return new SuccessDataResult<Ilce>(Get(i => i.Ad == ad));
        }

        public IDataResult<List<Ilce>> GetListBySehirAd(string sehirAd)
        {
            var sehir = _sehirService.GetByAd(sehirAd).Data;
            return new SuccessDataResult<List<Ilce>>(_ilceDal.GetList(s => s.SehirId == sehir.Id));
        }
    }
}