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
            var sehir = _sehirService.GetById(ilce.SehirId).Data;
            ilce.Sehir = sehir;
            return new SuccessDataResult<Ilce>(ilce);
        }

        public IDataResult<Ilce> GetByAd(string ad)
        {
            var ilce = _ilceDal.Get(s => s.Ad == ad);
            var sehir = _sehirService.GetById(ilce.SehirId).Data;
            ilce.Sehir = sehir;
            return new SuccessDataResult<Ilce>(ilce);
        }

        public IDataResult<List<Ilce>> GetListBySehirAd(string sehirAd)
        {
            var sehir = _sehirService.GetByAd(sehirAd).Data;
            var ilceler = _ilceDal.GetList(s => s.SehirId == sehir.Id);

            foreach (var ilce in ilceler)
            {
                ilce.Sehir = sehir;
            }

            return new SuccessDataResult<List<Ilce>>(ilceler);
        }

        public IDataResult<List<Ilce>> GetList(Expression<Func<Ilce, bool>>? filter = null)
        {
            var ilceler = _ilceDal.GetList(filter);
            var sehirler = _sehirService.GetList(x => ilceler.Select(y => y.SehirId).Contains(x.Id)).Data;
            var result = ilceler.Join(
                sehirler,
                ilce => ilce.SehirId,
                sehir => sehir.Id,
                (i, s) => new Ilce
                {
                    Id = i.Id,
                    Ad = i.Ad,
                    SehirId = i.SehirId,
                    Sehir = s
                });
            return new SuccessDataResult<List<Ilce>>(result.ToList());
        }
    }
}