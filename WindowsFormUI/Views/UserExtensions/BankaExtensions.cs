using WindowsFormUI.Views.Moduls.Bankalar;

namespace WindowsFormUI.Views.UserExtensions
{
    public static class BankaExtensions
    {
        /// <summary>
        /// Banka Evrak Türleri enum tipi için toString methodu: seçilen verinin adını string formatında döndürür.
        /// </summary>
        /// <param name="bankaIslemTuru">veri tipi</param>
        /// <returns>Enum tipinin seçilen nesnesinin adının baş harfini döndürür (Tahsilat:(Alınan)"A" / Ödeme:(Gönderilen)"G")</returns>
        public static char ToChar(this BankaIslemTurleri bankaIslemTuru)
        {
            return bankaIslemTuru == BankaIslemTurleri.Tahsilat ? 'A' : 'G';
        }

        /// <summary>
        /// BankaIslemTurleri enum tipi için toString methodu: seçilen verinin adını string formatında döndürür.
        /// </summary>
        /// <param name="tur">Banka İşlem Türü</param>
        /// <returns>Tahsilat ya da Tediye ise string tipinde veri döndürür, değilse boş string döndürür.</returns>
        public static string ToText(this BankaIslemTurleri tur)
        {
            switch (tur)
            {
                case BankaIslemTurleri.Hepsi:
                    return string.Empty;
                case BankaIslemTurleri.Tahsilat:
                    return "Gelen Havale/EFT";
                case BankaIslemTurleri.Tediye:
                    return "Gönderilen Havale/EFT";
                default:
                    return string.Empty;
            }
        }
    }
}