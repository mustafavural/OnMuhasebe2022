using System.Collections.Generic;

namespace WindowsFormUI.Views.UserExtensions
{
    public static class FaturaExtensions
    {
        public static void Update<T>(this List<T> entities, int index, T newT) where T : class, new()
        {
            entities[index] = newT;
        }
    }
}