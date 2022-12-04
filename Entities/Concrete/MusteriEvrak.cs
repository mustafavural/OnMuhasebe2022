using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class MusteriEvrak : IEntity
    {
        public int Id { get; set; }
        public int AlinanCariId { get; set; }
        public string AsilBorclu { get; set; }
        public DateTime AlisTarihi { get; set; }



        public virtual Cari? AlinanCari { get; set; }
        public virtual CariHareket? AlinanCariHareket { get; set; }
        public virtual DegerliEvrak DegerliEvrak { get; set; }
    }
}