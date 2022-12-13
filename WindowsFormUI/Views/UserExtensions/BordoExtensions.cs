using WindowsFormUI.Views.Moduls.CekSenetler;
using WindowsFormUI.Views.Moduls.Faturalar;

namespace WindowsFormUI.Views.UserExtensions
{
    public static class BordoExtensions
    {

        /// <summary>
        /// Bordro Türleri enum tipi için toString methodu: seçilen verinin adını string formatında döndürür.
        /// </summary>
        /// <param name="bordroTurleri">veri tipi</param>
        /// <returns>Enum tipinin seçilen nesnesinin adını döndürür</returns>
        public static string ToText(this BordroTurleri bordroTurleri)
        {
            if (bordroTurleri == BordroTurleri.Hepsi)
                return string.Empty;
            else
                return bordroTurleri == BordroTurleri.Tahsilat ? "Tahsilat Bordrosu" : "Tediye Bordrosu";
        }
    }
}
