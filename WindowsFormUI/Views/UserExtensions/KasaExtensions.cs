using WindowsFormUI.Views.Moduls.Kasalar;

namespace WindowsFormUI.Views.UserExtensions
{
    public static class KasaExtensions
    {
        public static string ToCharString(this KasaIslemTuru kasaIslemTuru)
        {
            if (kasaIslemTuru == KasaIslemTuru.Tahsilat)
                return "T";
            else
                return "O";
        }
    }
}