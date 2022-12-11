namespace Business.Constants
{
    public static class Messages
    {
        public static class AdresMessages
        {
            public static string AdresEklendi => "Adres başarıyla eklendi.";
            public static string AdresGuncellendi => "Adres başarıyla güncellendi.";
            public static string AdresSilindi => "Adres başarıyla silindi.";
            public static string EpostaZatenKullanimda => "Girilen E-Posta adresi zaten kullanımda.";
            public static string FaxZatenKullanimda => "Girilen Fax zaten kullanımda.";
            public static string AdresBulunamadi => "Silinecek kayıt bulunamadı.";
            public static string TelefonZatenKullanimda => "Girilen Telefonlardan biri zaten kullanımda.";
            public static string WebZatenKullanimda => "Girilen Web adresi zaten kullanımda.";
        }

        public static class BankaMessages
        {
            public static string HesapEklendi => "Banka hesabı başarıyla eklendi.";
            public static string HesapSilindi => "Banka hesabı başarıyla silindi.";
            public static string HesapGuncellendi => "Banka hesabı başarıyla güncellendi.";
            public static string HesapZatenVar => "Banka hesabı zaten mevcut";
            public static string HesapHareketEklendi => "Hesap hareket başarıyla eklendi.";
            public static string HesapHareketSilindi => "Hesap hareket başarıyla silindi.";
            public static string HesapHareketGuncellendi => "Hesap hareket başarıyla güncellendi.";
            public static string HesapIdBulunamadi => "Silinecek hesap bulunamadi.";
        }

        public static class CariMessages
        {
            public static string CariYok => "Cari Bulunamadi.";
            public static string CategoryeEklendi => "Cariye grup kod başarıyla eklendi.";
            public static string CategorydenSilindi => "Cariden grup kod başarıyla silindi.";
            public static string CariEklendi => "Cari başarıyla eklendi.";
            public static string CariSilindi => "Cari başarıyla silindi.";
            public static string CariGuncellendi => "Cari başarıyla güncellendi.";
            public static string VergiNoZatenMevcut => "Bu vergi no daha önce girilmiş.";
            public static string KodZatenMevcut => "Cari kod zaten mevcut.";
            public static string UnvanZatenMevcut => "Cari unvan zaten mevcut.";
            public static string CategoryIsmiZatenMevcut => "Cari grup kod ismi zaten mevcut.";
            public static string CategoryEklendi => "Cari grup kod başarıyla eklendi.";
            public static string CategorySilindi => "Cari grup kod başarıyla silindi.";
            public static string CategoryGuncellendi => "Cari grup kod başarıyla güncellendi.";
            public static string CategoryYok => "Category bulunamadı.";
            public static string CategoryKullaniliyor => "Category kullanımda silinemez!";
            public static string CariKullaniliyor => "Hareket görmüş cariler silinemez.";
            public static string HareketEklendi => "Cari hareket eklendi";
            public static string HareketSilindi => "Cari hareket silindi";
            public static string HareketGuncellendi => "Cari hareket güncellendi";
            public static string CariVeCategoryZatenEslenik => "Cari ve category eşlemesi zaten yapılmış.";
        }

        public static class StokMessages
        {
            public static string StokYok => "Stok bulunamadi.";
            public static string Eklendi => "Ürün başarıyla eklendi.";
            public static string Silindi => "Ürün başarıyla silindi.";
            public static string Guncellendi => "Ürün başarıyla güncellendi.";
            public static string CategoryEklendi => "StokCategory başarıyla eklendi.";
            public static string CategorySilindi => "StokCategory başarıyla silindi.";
            public static string CategoryGuncellendi => "StokCategory başarıyla güncellendi.";
            public static string IsmiZatenMevcut => "Stok ismi zaten mevcut.";
            public static string BarkodZatenMevcut => "Stok barkod zaten mevcut.";
            public static string KodZatenMevcut => "Stok kod zaten mevcut.";
            public static string KdvGerekli => "KDV oranı boş geçilemez.";
            public static string CategoryeEklendi => "Stoğa grup kod başarıyla eklendi.";
            public static string CategorydenSilindi => "Stok grup kod başarıyla silindi.";
            public static string CategoryIsmiZatenMevcut => "Stok grup kod ismi zaten mevcut.";
            public static string CategoryYok => "Category bulunamadı.";
            public static string StokVeCategoryZatenEslenik => "Stok ve category eşlemesi zaten yapılmış.";
            public static string CategoryKullaniliyor => "Category kullanımda silinemez!";
            public static string BirimVeBirim2AynıOlamaz => "Birimler aynı olmamalı.";
            public static string StokKodGerekli => "Stok kod boş geçilemez.";
            public static string StokKullaniliyor => "Hareket görmüş stoklar silinemez.";
            public static string HareketEklendi => "Stok hareket eklendi";
            public static string HareketSilindi => "Stok hareket silindi";
            public static string HareketGuncellendi => "Stok hareket güncellendi";
            public static string YeterliStokYok => "Yeterli stok kalmadı.";
            public static string HareketBulunamadi => "Stok hareket mevcut değil.";
        }

        public static class FaturaMessages
        {
            public static string KalemEklendi => "Kalem faturaya başarıyla eklendi.";
            public static string KalemlerEklendi => "Kalemler faturaya başarıyla eklendi.";
            public static string KalemSilindi => "Kalem faturadan başarıyla silindi.";
            public static string KalemlerSilindi => "Kalemler faturadan başarıyla silindi.";
            public static string Eklendi => "Fatura başarıyla eklendi.";
            public static string Silindi => "Fatura başarıyla silindi.";
            public static string Guncellendi => "Fatura başarıyla güncellendi.";
            public static string FaturaYok => "Fatura bulunamadı.";
            public static string ZatenMevcut => "Fatura zaten mevcut.";
            public static string BosDegil => "Faturayı silmek için önce kalemleri temizleyin.";
            public static string FaturaKesildi => "Fatura başarıyla kesildi.";
            public static string FaturaNoGerekli => "FaturaNo gereklidir boş geçilemez.";
            public static string FHarfliIleBaslamalidir => "Faturalar F harfi ile başlar.";
            public static string KalemlerGuncellendi => "Fatura kalemleri başarıyla güncellendi.";
            public static string KalemBulunamadi => "Fatura kesmek için kalem(ler) bilgisi gereklidir.";
        }

        public static class KasaMessages
        {
            public static string KasaEklendi => "Yeni kasa başarıyla eklendi.";
            public static string KasaSilindi => "Kasa başarıyla silindi.";
            public static string KasaGuncellendi => "Kasa yeni değerlerle başarıyla güncellendi.";
            public static string TahsilatKaydedildi => "Kasa tahsilat fişi kesildi.";
            public static string TediyeKaydedildi => "Kasa tediye fişi kesildi.";
            public static string HareketSilindi => "Kasa fişi silindi.";
            public static string HareketGuncellendi => "Kasa fişi güncellendi.";
            public static string KasaAdZatenMevcut => "Bu kasa ismi daha önce kullanılmış.";
            public static string KasaZatenMevcut => "Zaten var olan kasayı bir daha ekleyemezsiniz.";
            public static string KasaBulunamadi => "Kasa bulunamadı.";
            public static string EvrakNoHatali => "Girilen hane sayısı 12'yi geçmemelidir.";
            public static string AciklamaBosGecilemez => "Bir açıklama girilmelidir.";
            public static string TarihHatali => "İleri tarihli kasa fişi girilemez.";
            public static string MiktarBosGecilemez => "Miktar alanı boş geçilemez.";
        }

        public static class DegerliEvrakMessages
        {
            public static string CariBulunamadi => "Çıkış yapılacak cari bulunamadi";
            public static string EvrakEklendi => "Değerli evrak başarıyla eklendi.";
            public static string EvrakSilindi => "Değerli evrak başarıyla silindi.";
            public static string EvrakGuncellendi => "Değerli evrak başarıyla güncellendi.";
            public static string EvraklarCariyeIslendi => "Değerli evraklar cariye gönderildi.";
            public static string KodZatenMevcut => "Girilen kod zaten mevcut.";
            public static string EvrakBulunamadi => "Girilen evrak bulunamadı.";
        }

        public static class KiymetliEvrakMessages
        {
            public static string BorcCekSenetEklendi => "Borç çeki/seneti başarıyla eklendi.";
            public static string BorcCekSenetSilindi => "Borç çeki/seneti başarıyla silindi.";
            public static string BorcCekSenetGuncellendi => "Borç çeki/seneti başarıyla güncellendi.";
            public static string MusteriCekSenetEklendi => "Muşteri çeki/seneti başarıyla eklendi.";
            public static string MusteriCekSenetSilindi => "Muşteri çeki/seneti başarıyla silindi.";
            public static string MusteriCekSenetGuncellendi => "Muşteri çeki/seneti başarıyla güncellendi.";
            public static string EvrakZatenMevcut => "Bu evrak daha önce girilmiş.";
            public static string EvrakNoZatenMevcut => "Bu evrak numarası daha önce kullanılmış.";
            public static string BordroNumarasiBulunamadi => "Kiymetli evrak bordro numarası mevcut değil.";
            public static string EvrakYok => "Evrak bulunamadı.";
            public static string BordroCariyeIslendi => "Evrak Bordrosu başarıyla cariye eklendi.";
            public static string BordroGuncellendi => "Bordro başarıyla güncellendi.";
            public static string BordroSilindi => "Bordro başarıyla silindi.";
            public static string BordroZatenVar => "Bu bordro daha önce girilmiş.";
            public static string BordroNoZatenMevcut => "Bu bordro numarası daha önce kullanılmış.";

            public static string BordroKullanimda => "Bordro işlem görmüş silinemez.";
        }

        public static class MusteriEvrakMessages
        {
            public static string CariBulunamadi => "Çıkış yapılacak cari bulunamadi";
            public static string EvrakSilindi => "Değerli evrak başarıyla silindi.";
            public static string EvrakBulunamadi => "Girilen evrak bulunamadı.";
            public static string KodZatenMevcut => "Girilen kod zaten mevcut.";
            public static string EvraklarAlindi => "Müşteriden evraklar başarıyla alındı.";
            public static string EvraklarCariyeIslendi => "Değerli evraklar cariye gönderildi.";

            public static string EvrakGuncellendi => "Değerli evrak başarıyla güncellendi.";
        }
    }
}