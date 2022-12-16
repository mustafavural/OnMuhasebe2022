using Core.Entities.Abstract;
using System.Collections.Generic;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WindowsFormUI.Views.UserExtensions
{
    public static class ModulExtensions
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
        /// List generik yapısındaki veri tablolarına FindIndex yordamı için extension overload method.
        /// </summary>
        /// <typeparam name="T">Veri tabanı objesi (tablo/entity), IEntity interfaceini implement etmiş olması gerekir.</typeparam>
        /// <param name="entities">listenin kendisi</param>
        /// <param name="entity">hangi verinin index araması yapılacağını belirler. Id sütununa göre arama yapar.</param>
        public static int FindIndex<T>(this List<T> entities, T entity) where T : class, IEntity, new()
        {
            return entities.FindIndex(s => s.Id == entity.Id);
        }

        private static bool IsFormattedNoString(string value, byte length, char noCode)
        {
            return value.Length == length && value.StartsWith(noCode);
        }

        /// <summary>
        /// Modüllerde kullanılan No değeri için özel format belirler.
        /// </summary>
        /// <param name="value">formatlanacak veri string tipinde olması önemli...</param>
        /// <param name="length">finalde kaç karakter olacağını belirler</param>
        /// <param name="noCode">No nun önüne hangi kod harfini yazılacağını belirler.</param>
        /// <returns>string tipinde dönüş yapar. örnek olarak (value:123,length:10,noCode:A) için "A000000123"</returns>
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

        /// <summary>
        /// DataGridView üzerinde, verilen sütun adında, verilen değer ile arama yaparak bulunan sonucun indexini döndürür.
        /// </summary>
        /// <param name="dataGridView">arama yapılacak datagridview</param>
        /// <param name="columnName">üzerinde arama yapıalcak sütun ismi</param>
        /// <param name="value">arama değeri</param>
        /// <returns>aranan değer bulunursa değerin index i, bulunmazsa -1 döner.</returns>
        public static int FindRowIndexWithColumnValue(this DataGridView dataGridView, string columnName, string value)
        {
            foreach (DataGridViewRow item in dataGridView.Rows)
                if (item.Cells[columnName].Value.ToString() == value)
                    return item.Index;
            return -1;
        }
    }
}