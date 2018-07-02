using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    // Класс для выполнения некоторых преобразований
    // между типами данных
    public class DataConverter
    {
        // Конвертирует строку в значение типа T
        public static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

        // Конвертирует строку в массив элементов типа T
        public static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }

        // Конвертирует массив элементов типа T в строку
        public static string ArrayToStr<T>(T[] arr, string separator = ", ")
        {
            return arr == null ? "null" : String.Join(separator, arr);
        }
    }
}
