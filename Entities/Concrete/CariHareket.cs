using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class CariHareket : IEntity
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }
        public string? Aciklama { get; set; }


        public virtual Cari? Cari { get; set; }
    }
}