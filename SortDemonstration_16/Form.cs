using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization;
using Utils;
using DataStructures;

namespace Task2
{
    public partial class MainWindow : Form
    {
        Random _rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик события загрузки формы
        // Внутри выполняется настройка некоторых элементов интерфейса
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Инициализируем GridView для ввода данных
            DataGridViewUtils.InitGridForArr(InputDataDGV, 60, false, true, false, true, false);
            InputDataDGV.RowCount = 1;

            // Инициализация графиков
            Demonstrator.InitializeChart(SortsComparsion);
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int count = int.Parse(MessagesUtils.Prompt("Укажите число элементов", "Заполнение массива"));

                DGVhelp.Fill(InputDataDGV, GenerateRandomArr(count));
            }
            catch (Exception ex)
            {
                MessagesUtils.ShowError("Укажите корректное число элементов");
            }
        }

        private void ShuffleBtn_Click(object sender, EventArgs e)
        {
            int[] arr = DGVhelp.ToArray(InputDataDGV);
            
            for (int i = 0; i < arr.Length - 1; i++)
            {

                int index = _rnd.Next(i + 1, arr.Length - 1);

                int t = arr[i];
                arr[i] = arr[index];
                arr[index] = t;
            }

            DGVhelp.Fill(InputDataDGV, arr);
        }

        private int[] GenerateRandomArr(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
                arr[i] = _rnd.Next(-100, 100);

            return arr;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DGVhelp.Clear(InputDataDGV);
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SortArr(DGVhelp.ToArray(InputDataDGV));
            }
            catch (Exception ex)
            {
                MessagesUtils.ShowError("Произошла ошибка. Проверьте корректность ваших данных");
            }
        }

        private void SortDemonstateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arr = DGVhelp.ToArray(InputDataDGV);

                if (arr.Length > 15)
                    throw new Exception("Укажите массив размером до 15 элементов");

                sortsStatsTabs.SelectedTab = sortsDemonstationTab;
                SortArr(arr, true);
            }
            catch (Exception ex)
            {
                MessagesUtils.ShowError("Произошла ошибка. Проверьте корректность ваших данных");
            }
        }

        private void SortArr(int[] arr, bool visualize = false, int swapInterval = 100)
        {
            if (visualize)
                Sorter.DemonstrationControl = CanvasPanel;

            if (bubbleSortRadio.Checked)
                Sorter.BubbleSort(arr, 0, arr.Length - 1);
            else if (twoWaysInsertionSortRadio.Checked)
                Sorter.TwoWaysInsertionSort(arr, 0, arr.Length - 1);
            else
            {
                DoubleLinkedList list = new DoubleLinkedList(arr);
                Sorter.TwoWaysListInsertionSort(ref list);
                arr = list.ToArray();
            }

            ComparsionsCountLbl.Text = Sorter.ComparsionsCount.ToString();
            SwapsCountLbl.Text = Sorter.SwapsCount.ToString();

            DGVhelp.Fill(InputDataDGV, arr);

            Sorter.DemonstrationControl = null;

            if (visualize)
                MessageBox.Show("Демонстрация завершена");
        }

        private void DrawChartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sortsStatsTabs.SelectedTab = sortsComparsionTab;

                    int count = int.Parse(MessagesUtils.Prompt("Укажите число элементов", "Размер массива"));
                    int[] testArr = GenerateRandomArr(count);

                Demonstrator.ChartType chartType = (chartOptionsRadio_Comparsions.Checked) ?
                    Demonstrator.ChartType.Comparsions : Demonstrator.ChartType.Swaps;

                Demonstrator.DrawChart(SortsComparsion, testArr, chartType);
            }
            catch (Exception ex)
            {
                MessagesUtils.ShowError("Произошла ошибка. Проверьте корректность ваших данных");
            } 
        }
    }
}
