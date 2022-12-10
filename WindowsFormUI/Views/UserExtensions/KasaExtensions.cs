using WindowsFormUI.Views.Moduls.Kasalar;

namespace WindowsFormUI.Views.UserExtensions
{
    public static class KasaExtensions
    {
        /// <summary>
        /// Kasa Evrak Türleri enum tipi için toString methodu: seçilen verinin adını string formatında döndürür.
        /// </summary>
        /// <param name="kasaIslemTuru">veri tipi</param>
        /// <returns>Enum tipinin seçilen nesnesinin adının baş harfini döndürür (Tahsilat:"T" / Odeme:"O")</returns>
        public static string ToCharString(this KasaIslemTuru kasaIslemTuru)
        {
            return kasaIslemTuru == KasaIslemTuru.Tahsilat ? "T" : "O";
        }
    }
}