namespace WindowsFormUI.Views.UserExtensions
{
    public static class ModulExtensions
    {
        private static bool IsFormattedNoString(string value, byte length, char noCode)
        {
            return value.Length == length && value.StartsWith(noCode);
        }

        public static string FormatNoString(string value, byte length, char noCode)
        {
            string txt = "";
            if (!IsFormattedNoString(value, length, noCode))
            {
                txt = value;
                value = noCode.ToString();
                do
                    value += "0";
                while (!IsFormattedNoString(value + txt, length, noCode));
            }
            return value += txt;
        }
    }
}