using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text;
using DataStructures;

namespace Task2
{
    public class Demonstrator
    {
        public enum SelectionType
        {
            Comparsion, Swap
        }

        public enum ChartType
        {
            Comparsions,
            Swaps
        }

        private static int INNER_RADIUS = 20;
        private static int SPACE_RADIUS = 10;
        private static int SELECTED_BORDER_RADIUS = 5;

        public static int DEMOSTRATION_STEP_TIME = 500;

        public static void InitializeChart(Chart chart)
        {
            chart.Series.Clear();

            var twoWaysInsertions = chart.Series.Add("Двухпутевыми вставками");
            twoWaysInsertions.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            var twoWaysInsertionsList = chart.Series.Add("Двухпутевыми вставками на списках");
            twoWaysInsertionsList.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            var bubbleSort = chart.Series.Add("Пузырьковая");
            bubbleSort.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart.ChartAreas[0].CursorX.AutoScroll = true;
            chart.ChartAreas[0].CursorY.AutoScroll = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
        }

        public static void DrawChart(Chart chart, 
            int[] testArr, 
            ChartType type = ChartType.Comparsions)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 100,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Построение графика",
                StartPosition = FormStartPosition.CenterScreen
            };

            ProgressBar progressBar = new ProgressBar() {
                Left = 10, Width = 450, Top = 20, Height = 20 };
            progressBar.Value = 0;
            prompt.Controls.Add(progressBar);

            prompt.Show();

            var twoWaysInsertions = chart.Series[0];
            twoWaysInsertions.Points.Clear();

            var twoWaysInsertionsList = chart.Series[1];
            twoWaysInsertionsList.Points.Clear();

            var bubbleSort = chart.Series[2];
            bubbleSort.Points.Clear();

            int[] arr = (int[])testArr.Clone();

            progressBar.Minimum = 0;
            progressBar.Maximum = (testArr.Length * 3);

            for (int i = 1; i < testArr.Length; i++)
            {
                arr = (int[])testArr.Clone();
                Sorter.TwoWaysInsertionSort(arr, 0, i);
                twoWaysInsertions.Points.AddXY(i, 
                    (type == ChartType.Comparsions) ? Sorter.ComparsionsCount : Sorter.SwapsCount);

                progressBar.Value++;

                arr = new int[i + 1];
                Array.Copy(testArr, 0, arr, 0, i);

                DoubleLinkedList list = new DoubleLinkedList(arr);
                Sorter.TwoWaysListInsertionSort(ref list);
                twoWaysInsertionsList.Points.AddXY(i,
                    (type == ChartType.Comparsions) ? Sorter.ComparsionsCount : Sorter.SwapsCount);

                progressBar.Value++;

                arr = (int[])testArr.Clone();
                Sorter.BubbleSort(arr, 0, i);
                bubbleSort.Points.AddXY(i,
                    (type == ChartType.Comparsions) ? Sorter.ComparsionsCount : Sorter.SwapsCount);

                progressBar.Value++;
            }

            prompt.Close();
        }

        public static void VisualizeArray(Control destination, 
            int[] arr, int[] selectedIndices = null,
            SelectionType selection = SelectionType.Comparsion)
        {
            Graphics g = destination.CreateGraphics();

            Bitmap map = new Bitmap(destination.Width, destination.Height);
            Graphics mapGraphics = Graphics.FromImage(map);
            mapGraphics.Clear(Color.White);

            StringFormat format = new StringFormat() {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Brush selectedFillColor, selectedBorderColor;

            if (selection == SelectionType.Comparsion)
            {
                selectedFillColor = Brushes.LightBlue;
                selectedBorderColor = Brushes.LightSeaGreen;
            }
            else
            {
                selectedFillColor = Brushes.LightYellow;
                selectedBorderColor = Brushes.Salmon;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                bool selected = IsSelected(selectedIndices, i);

                Point position = CalcElementPosition(destination, i);

                Rectangle rectangle = new Rectangle(position.X - INNER_RADIUS, 
                    position.Y - INNER_RADIUS, 
                    INNER_RADIUS * 2, 
                    INNER_RADIUS * 2);

                if (selected)
                    mapGraphics.FillEllipse(
                        selectedBorderColor,
                        rectangle.Left - SELECTED_BORDER_RADIUS,
                        rectangle.Top - SELECTED_BORDER_RADIUS,
                        rectangle.Width + 2 * SELECTED_BORDER_RADIUS,
                        rectangle.Height + 2 * SELECTED_BORDER_RADIUS
                        );

                Brush color = (selected) ? selectedFillColor : Brushes.LightPink;

                mapGraphics.FillEllipse(color, rectangle);

                mapGraphics.DrawString(arr[i].ToString(), 
                    SystemFonts.DefaultFont, 
                    Brushes.Black,
                    rectangle,
                    format);
            }

            g.DrawImage(map, 0, 0);
        }

        private static Point CalcElementPosition(Control destination, int index)
        {
            int elementSpace = (INNER_RADIUS + SPACE_RADIUS);
            int elementsInRow = destination.Width / (2 * elementSpace);

            int x = (2 * (index % elementsInRow) + 1) * elementSpace;
            int y = (2 * (index / elementsInRow) + 1) * elementSpace;

            return new Point(x, y);
        } 

        private static bool IsSelected(int[] selected, int index)
        {
            if (selected == null)
                return false;

            for (int i = 0; i < selected.Length; i++)
                if (selected[i] == index)
                    return true;

            return false;
        }
    }
}
