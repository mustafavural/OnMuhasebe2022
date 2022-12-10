using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class MusteriCekSenet : IEntity
    {
        public int Id { get; set; }
        public string No { get; set; }
        public int BordroTahsilatId { get; set; }
        public int BordroTediyeId { get; set; }
        public string AsilBorclu { get; set; }
        public DateTime Vade { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }

        public virtual KiymetliEvrakBordro BordroTahsilat { get; set; }
        public virtual KiymetliEvrakBordro BordroTediye { get; set; }
    }
}