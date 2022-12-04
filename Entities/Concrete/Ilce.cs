using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Ilce : IEntity
    {
        public int Id { get; set; }
        public int SehirId { get; set; }
        public string Ad { get; set; }

        public virtual Sehir Sehir { get; set; }
        public virtual List<Adres> Adresler { get; set; }

        public Ilce()
        {
            Adresler = new();
        }
    }
}