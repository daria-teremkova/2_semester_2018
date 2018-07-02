using System;
using System.Windows.Forms;

namespace Task2
{
    // Класс, облегчающий выполнение различных операций над GridView
    class DGVhelp
    {
        // Заполняет GridView элементами числового массива
        public static void Fill(DataGridView dgv, int[] numbers)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 1;
            dgv.RowCount = numbers.Length;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                dgv.Rows[i].Cells[0].Value = numbers[i];
            }
        }

        // Преобразует GridView в массив
        public static int[] ToArray(DataGridView dgv)
        {
            int[] numbers = new int[dgv.RowCount];

            for (int i = 0; i < dgv.RowCount; i++)
                numbers[i] = (int)Convert.ChangeType(dgv.Rows[i].Cells[0].Value, typeof(int));

            return numbers;
        }

        public static void Clear(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }
    }
}
