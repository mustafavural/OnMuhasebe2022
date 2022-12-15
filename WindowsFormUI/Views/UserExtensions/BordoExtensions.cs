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
            switch (bordroTurleri)
            {
                case BordroTurleri.Tahsilat:
                    return "Tahsilat Bordrosu";
                case BordroTurleri.MusteriTediye:
                    return "Ciro Tediye Bordrosu";
                case BordroTurleri.BorcTediye:
                    return "Borc Tediye Bordrosu";
                case BordroTurleri.Hepsi:
                    return "";
                default:
                    return "";
            }
        }
    }
}