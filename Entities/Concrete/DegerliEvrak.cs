using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class DegerliEvrak : IEntity
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public int? VerilenCariId { get; set; }
        public DateTime Vade { get; set; }
        public decimal Tutar { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string? Aciklama { get; set; }



        public virtual Cari? VerilenCari { get; set; }
        public virtual CariHareket? VerilenCariHareket { get; set; }

    }
}