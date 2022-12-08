using System.Collections.Generic;
using WindowsFormUI.Views.Moduls.Faturalar;

namespace WindowsFormUI.Views.UserExtensions
{
    public static class FaturaExtensions
    {
        public static void Update<T>(this List<T> entities, int index, T newT) where T : class, new()
        {
            entities[index] = newT;
        }

        public static string ToText(this FaturaTurleri faturaTurleri)
        {
            if (faturaTurleri == FaturaTurleri.Hepsi)
                return null;
            else
                return faturaTurleri == FaturaTurleri.Alis ? "Alış Faturası" : "Satış Faturası";
        }
    }
}