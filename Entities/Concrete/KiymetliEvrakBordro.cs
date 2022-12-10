using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class KiymetliEvrakBordro : IEntity
    {
        public int Id { get; set; }
        public string No { get; set; }
        public string Tur { get; set; }
        public int CariId { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }

        public virtual Cari Cari { get; set; }
        public virtual CariHareket CariHareket { get; set; }
    }
}