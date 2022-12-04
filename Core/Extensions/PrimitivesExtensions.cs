namespace Core.Extensions
{
    public static class PrimitivesExtensions
    {
        public static decimal ToDecimal(this string value, byte minOrMax = 0)
        {
            try
            {
                return Convert.ToDecimal(value);
            }
            catch (FormatException)
            { return minOrMax == 0 ? decimal.MinValue : decimal.MaxValue; }
        }

        public static int ToInt(this string value)
        {
            return Convert.ToInt32(value);
        }

        public static DateTime ToDateTime(this string value)
        {
            return Convert.ToDateTime(value);
        }
    }
}