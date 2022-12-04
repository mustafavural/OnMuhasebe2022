using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Cari : IEntity
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Unvan { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }

        [NotMapped]
        public virtual Adres Adres { get; set; }
        [NotMapped]
        public virtual List<CariCategory> CariCategoryler { get; set; }
        public virtual List<CariGrup> CariGruplar { get; set; }
        public virtual List<CariHareket> CariHareketer { get; set; }

        public Cari()
        {
            CariCategoryler = new();
            CariGruplar = new();
            CariHareketer= new();
        }
    }
}