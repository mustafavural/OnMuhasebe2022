using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

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
        [NotMapped]
        public virtual CariHareket CariHareket { get; set; }

        public List<MusteriCekSenet> MusteriCekSenetler { get; set; }
        public List<BorcCekSenet> BorcCekSenetler { get; set; }

        public KiymetliEvrakBordro()
        {
            MusteriCekSenetler = new();
            BorcCekSenetler = new();
        }
    }
}