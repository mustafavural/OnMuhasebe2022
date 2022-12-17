using WindowsFormUI.Views.Moduls.Bankalar;

namespace WindowsFormUI.Views.UserExtensions
{
    public static class BankaExtensions
    {
        /// <summary>
        /// Banka Evrak Türleri enum tipi için toString methodu: seçilen verinin adını string formatında döndürür.
        /// </summary>
        /// <param name="bankaIslemTuru">veri tipi</param>
        /// <returns>Enum tipinin seçilen nesnesinin adının baş harfini döndürür (Tahsilat:"T" / Odeme:"O")</returns>
        public static string ToCharString(this BankaIslemTuru bankaIslemTuru)
        {
            return bankaIslemTuru == BankaIslemTuru.Tahsilat ? "T" : "O";
        }
    }
}