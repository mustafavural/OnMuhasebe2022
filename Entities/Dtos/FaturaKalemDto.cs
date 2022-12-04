using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class FaturaKalemDto : IDto
    {
        public int Id { get; set; }
        public string StokKodu { get; set; }
        public string FaturaNo { get; set; }
        public string StokAd { get; set; }
        public decimal Miktar { get; set; }
        public string Birim { get; set; }
        public decimal Fiyat { get; set; }
        public decimal BrutTutar { get; set; }
        public int Kdv { get; set; }
        public decimal NetTutar { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}