using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Banka : IEntity
    {
        public int Id { get; set; }
        public string BankaAd { get; set; }
        public string BankaSubeAd { get; set; }
        public string HesapNo { get; set; }
        public string IBAN { get; set; }
    }
}