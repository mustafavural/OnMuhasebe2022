using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Adres : IEntity
    {
        public int Id { get; set; }
        public string? Telefon { get; set; }
        public string? Telefon2 { get; set; }
        public string? Fax { get; set; }
        public string? Web { get; set; }
        public string? Eposta { get; set; }
        public int IlceId { get; set; }
        public string? AcikAdres { get; set; }

        public virtual Ilce? Ilce { get; set; }
    }
}