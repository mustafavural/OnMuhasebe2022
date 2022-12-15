using System.Collections.Generic;
using WindowsFormUI.Views.Moduls.Faturalar;

namespace WindowsFormUI.Views.UserExtensions
{
    public static class FaturaExtensions
    {
        /// <summary>
        /// Fatura Türleri enum tipi için toString methodu: seçilen verinin adını string formatında döndürür.
        /// </summary>
        /// <param name="faturaTurleri">veri tipi</param>
        /// <returns>Enum tipinin seçilen nesnesinin adını döndürür</returns>
        public static string ToText(this FaturaTurleri faturaTurleri)
        {
            if (faturaTurleri == FaturaTurleri.Hepsi)
                return string.Empty;
            else
                return faturaTurleri == FaturaTurleri.Alis ? "Alış Faturası" : "Satış Faturası";
        }

        /// <summary>
        /// Fatura Türleri enum tipi için toString methodu: seçilen verinin adını string formatında döndürür.
        /// </summary>
        /// <param name="faturaTurleri">veri tipi</param>
        /// <returns>Enum tipinin seçilen nesnesinin adının baş harfini döndürür</returns>
        public static string ToCharString(this FaturaTurleri faturaTurleri)
        {
            if (faturaTurleri == FaturaTurleri.Hepsi)
                return string.Empty;
            else
                return faturaTurleri == FaturaTurleri.Alis ? "A" : "S";
        }
    }
}