using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class MusteriEvrakDto : IDto
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public int AlinanCariHareketId { get; set; }
        public DateTime Vade { get; set; }
        public decimal Tutar { get; set; }
        public DateTime AlisTarihi { get; set; }
        public string AsilBorclu { get; set; }
        public int VerilenCariHareketId { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string Aciklama { get; set; }
    }
}