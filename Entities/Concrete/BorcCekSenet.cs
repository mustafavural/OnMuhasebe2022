using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class BorcCekSenet : IEntity
    {
        public int Id { get; set; }
        public string No { get; set; }
        public int BordroTediyeId { get; set; }
        public DateTime Vade { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }

        public virtual KiymetliEvrakBordro BordroTediye { get; set; }
    }
}