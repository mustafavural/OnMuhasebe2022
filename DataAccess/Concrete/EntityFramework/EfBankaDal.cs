using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBankaDal : EfEntityRepositoryBase<Banka, SIRKETLERContext>, IBankaDal
    {
        public decimal GetHesapBakiye(int hesapId)
        {
            using (var context = new SIRKETLERContext())
            {
                var result = from hesap in context.BankaHareketler
                             where hesap.BankaId == hesapId
                             select hesap;
                return result.Sum(s => s.GirenCikanMiktar);
            }
        }

        public bool KontrolHesapKullaniliyorMu(int id)
        {
            using (var context = new SIRKETLERContext())
            {
                var result = from hesap in context.BankaHareketler
                             where hesap.BankaId == id
                             select hesap;
                return !result.Any();
            }
        }
    }
}