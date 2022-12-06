using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Fatura : IEntity
    {
        public int Id { get; set; }
        public string No { get; set; }
        public string Tur { get; set; }
        public int CariId { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string? Aciklama { get; set; }



        public virtual Cari? Cari { get; set; }
        [NotMapped]
        public virtual CariHareket? CariHareket { get; set; }
        public virtual List<StokHareket>? StokHareketler { get; set; }

        public Fatura()
        {
            StokHareketler = new List<StokHareket>();
        }
    }
}