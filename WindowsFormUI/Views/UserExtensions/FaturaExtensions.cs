using System.Collections.Generic;
using WindowsFormUI.Views.Moduls.Faturalar;

namespace WindowsFormUI.Views.UserExtensions
{
    public static class FaturaExtensions
    {
        /// <summary>
        /// List generik yapısındaki veri tablolarına Update işlemini gerçekleyen ilave method.
        /// </summary>
        /// <typeparam name="T">Dönüş tipini belirler "Veri tabanı objesi (tablo/entity)"</typeparam>
        /// <param name="entities">listenin kendisi</param>
        /// <param name="index">hangi index nolu kaydın güncelleneceğini belirler</param>
        /// <param name="newT">hengi veriyle güncelleneceğini belirler</param>
        public static void Update<T>(this List<T> entities, int index, T newT) where T : class, new()
        {
            entities[index] = newT;
        }

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