using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class StokHareket : IEntity
    {
        public int Id { get; set; }
        public int StokId { get; set; }
        public int FaturaId { get; set; }
        public decimal Miktar { get; set; }
        public string Birim { get; set; }
        public decimal Fiyat { get; set; }
        public decimal? BrutTutar { get; set; }
        public int Kdv { get; set; }
        public decimal? NetTutar { get; set; }
        public DateTime Tarih { get; set; }
        public string? Aciklama { get; set; }


        public virtual Stok? Stok { get; set; }
        public virtual Fatura? Fatura { get; set; }
    }
}