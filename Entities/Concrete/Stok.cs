using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Stok : IEntity
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Barkod { get; set; }
        public string Ad { get; set; }
        public int Kdv { get; set; }
        public string Birim { get; set; }


        [NotMapped]
        public virtual List<StokCategory>? StokCategoryler { get; set; }
        public virtual List<StokGrup>? StokGruplar { get; set; }
        public virtual List<StokHareket> StokHareketler { get; set; }

        public Stok()
        {
            StokGruplar = new();
            StokCategoryler = new();
            StokHareketler = new();
        }
    }
}