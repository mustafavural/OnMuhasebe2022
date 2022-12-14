using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class KasaHareket : IEntity
    {
        public int Id { get; set; }
        public int KasaId { get; set; }
        public string EvrakNo { get; set; }
        public decimal GirenCikanMiktar { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }




        public virtual Kasa? Kasa { get; set; }
        public virtual CariHareket? CariHareket { get; set; }
    }
}