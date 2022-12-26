using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class BankaHareket : IEntity
    {
        public int Id { get; set; }
        public int BankaId { get; set; }
        public string EvrakNo { get; set; }
        public decimal GirenCikanMiktar { get; set; }
        public DateTime Tarih { get; set; }
        public string? Aciklama { get; set; }

        public virtual Banka? Banka { get; set; }
        public virtual CariHareket? CariHareket { get; set; }
    }
}