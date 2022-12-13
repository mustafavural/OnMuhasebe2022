using Core.Entities.Abstract;
using Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class CekSenetBorc : IEntity
    {
        public int Id { get; set; }
        public string No { get; set; }
        public int BordroTediyeId { get; set; }
        public DateTime Vade { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }

        [NotMapped]
        public virtual CekSenetBordro BordroTediye { get; set; }
    }
}