using Core.Entities.Abstract;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class CekSenetMusteri : IEntity
    {
        public int Id { get; set; }
        public string No { get; set; }
        public int BordroTahsilatId { get; set; }
        public DateTime Vade { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }
        public int BordroTediyeId { get; set; }
        public string AsilBorclu { get; set; }

        public virtual CekSenetBordro BordroTahsilat { get; set; }
        public virtual CekSenetBordro BordroTediye { get; set; }
    }
}