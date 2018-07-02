namespace Task2
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SortPanel = new System.Windows.Forms.GroupBox();
            this.chartOptionsGrBox = new System.Windows.Forms.GroupBox();
            this.DrawChart = new System.Windows.Forms.Button();
            this.SortOptionsPanel = new System.Windows.Forms.Panel();
            this.twoWaysInsertionSortRadio = new System.Windows.Forms.RadioButton();
            this.bubbleSortRadio = new System.Windows.Forms.RadioButton();
            this.SortBtn = new System.Windows.Forms.Button();
            this.SortDemonstateBtn = new System.Windows.Forms.Button();
            this.FillBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ShuffleBtn = new System.Windows.Forms.Button();
            this.InputDataDGV = new System.Windows.Forms.DataGridView();
            this.sortsStatsTabs = new System.Windows.Forms.TabControl();
            this.sortsComparsionTab = new System.Windows.Forms.TabPage();
            this.ComparsionsCountLbl = new System.Windows.Forms.Label();
            this.SwapsCountLbl = new System.Windows.Forms.Label();
            this.SortsComparsion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sortsDemonstationTab = new System.Windows.Forms.TabPage();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.chartOptionsRadio_Swaps = new System.Windows.Forms.RadioButton();
            this.chartOptionsRadio_Comparsions = new System.Windows.Forms.RadioButton();
            this.twoWaysListInsertionSortRadio = new System.Windows.Forms.RadioButton();
            this.SortPanel.SuspendLayout();
            this.chartOptionsGrBox.SuspendLayout();
            this.SortOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputDataDGV)).BeginInit();
            this.sortsStatsTabs.SuspendLayout();
            this.sortsComparsionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SortsComparsion)).BeginInit();
            this.sortsDemonstationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SortPanel
            // 
            this.SortPanel.Controls.Add(this.SortOptionsPanel);
            this.SortPanel.Controls.Add(this.SortBtn);
            this.SortPanel.Controls.Add(this.SortDemonstateBtn);
            this.SortPanel.Location = new System.Drawing.Point(14, 296);
            this.SortPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortPanel.Size = new System.Drawing.Size(186, 328);
            this.SortPanel.TabIndex = 9;
            this.SortPanel.TabStop = false;
            this.SortPanel.Text = "Сортировка";
            // 
            // chartOptionsGrBox
            // 
            this.chartOptionsGrBox.Controls.Add(this.chartOptionsRadio_Swaps);
            this.chartOptionsGrBox.Controls.Add(this.chartOptionsRadio_Comparsions);
            this.chartOptionsGrBox.Location = new System.Drawing.Point(14, 111);
            this.chartOptionsGrBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartOptionsGrBox.Name = "chartOptionsGrBox";
            this.chartOptionsGrBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartOptionsGrBox.Size = new System.Drawing.Size(188, 175);
            this.chartOptionsGrBox.TabIndex = 11;
            this.chartOptionsGrBox.TabStop = false;
            this.chartOptionsGrBox.Text = "Параметры графика";
            // 
            // DrawChart
            // 
            this.DrawChart.Location = new System.Drawing.Point(16, 64);
            this.DrawChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DrawChart.Name = "DrawChart";
            this.DrawChart.Size = new System.Drawing.Size(189, 37);
            this.DrawChart.TabIndex = 9;
            this.DrawChart.Text = "Построить график";
            this.DrawChart.UseVisualStyleBackColor = true;
            this.DrawChart.Click += new System.EventHandler(this.DrawChartBtn_Click);
            // 
            // SortOptionsPanel
            // 
            this.SortOptionsPanel.Controls.Add(this.twoWaysListInsertionSortRadio);
            this.SortOptionsPanel.Controls.Add(this.twoWaysInsertionSortRadio);
            this.SortOptionsPanel.Controls.Add(this.bubbleSortRadio);
            this.SortOptionsPanel.Location = new System.Drawing.Point(9, 29);
            this.SortOptionsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortOptionsPanel.Name = "SortOptionsPanel";
            this.SortOptionsPanel.Size = new System.Drawing.Size(171, 169);
            this.SortOptionsPanel.TabIndex = 8;
            // 
            // twoWaysInsertionSortRadio
            // 
            this.twoWaysInsertionSortRadio.AutoSize = true;
            this.twoWaysInsertionSortRadio.Location = new System.Drawing.Point(4, 40);
            this.twoWaysInsertionSortRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.twoWaysInsertionSortRadio.Name = "twoWaysInsertionSortRadio";
            this.twoWaysInsertionSortRadio.Size = new System.Drawing.Size(143, 44);
            this.twoWaysInsertionSortRadio.TabIndex = 6;
            this.twoWaysInsertionSortRadio.TabStop = true;
            this.twoWaysInsertionSortRadio.Text = "Двухпутевыми\r\nвставками";
            this.twoWaysInsertionSortRadio.UseVisualStyleBackColor = true;
            // 
            // bubbleSortRadio
            // 
            this.bubbleSortRadio.AutoSize = true;
            this.bubbleSortRadio.Checked = true;
            this.bubbleSortRadio.Location = new System.Drawing.Point(4, 5);
            this.bubbleSortRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bubbleSortRadio.Name = "bubbleSortRadio";
            this.bubbleSortRadio.Size = new System.Drawing.Size(134, 24);
            this.bubbleSortRadio.TabIndex = 5;
            this.bubbleSortRadio.TabStop = true;
            this.bubbleSortRadio.Text = "Пузырьковая";
            this.bubbleSortRadio.UseVisualStyleBackColor = true;
            // 
            // SortBtn
            // 
            this.SortBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SortBtn.Location = new System.Drawing.Point(8, 222);
            this.SortBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(169, 37);
            this.SortBtn.TabIndex = 4;
            this.SortBtn.Text = "Сортировать";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // SortDemonstateBtn
            // 
            this.SortDemonstateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SortDemonstateBtn.Location = new System.Drawing.Point(8, 269);
            this.SortDemonstateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortDemonstateBtn.Name = "SortDemonstateBtn";
            this.SortDemonstateBtn.Size = new System.Drawing.Size(169, 37);
            this.SortDemonstateBtn.TabIndex = 2;
            this.SortDemonstateBtn.Text = "Демонстрация";
            this.SortDemonstateBtn.UseVisualStyleBackColor = true;
            this.SortDemonstateBtn.Click += new System.EventHandler(this.SortDemonstateBtn_Click);
            // 
            // FillBtn
            // 
            this.FillBtn.Location = new System.Drawing.Point(13, 14);
            this.FillBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FillBtn.Name = "FillBtn";
            this.FillBtn.Size = new System.Drawing.Size(192, 37);
            this.FillBtn.TabIndex = 4;
            this.FillBtn.Text = "Заполнить";
            this.FillBtn.UseVisualStyleBackColor = true;
            this.FillBtn.Click += new System.EventHandler(this.FillBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(367, 14);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(140, 37);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ShuffleBtn
            // 
            this.ShuffleBtn.Location = new System.Drawing.Point(213, 14);
            this.ShuffleBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShuffleBtn.Name = "ShuffleBtn";
            this.ShuffleBtn.Size = new System.Drawing.Size(146, 37);
            this.ShuffleBtn.TabIndex = 2;
            this.ShuffleBtn.Text = "Перемешать";
            this.ShuffleBtn.UseVisualStyleBackColor = true;
            this.ShuffleBtn.Click += new System.EventHandler(this.ShuffleBtn_Click);
            // 
            // InputDataDGV
            // 
            this.InputDataDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.InputDataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputDataDGV.Location = new System.Drawing.Point(249, 64);
            this.InputDataDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputDataDGV.Name = "InputDataDGV";
            this.InputDataDGV.Size = new System.Drawing.Size(258, 656);
            this.InputDataDGV.TabIndex = 12;
            // 
            // sortsStatsTabs
            // 
            this.sortsStatsTabs.Controls.Add(this.sortsComparsionTab);
            this.sortsStatsTabs.Controls.Add(this.sortsDemonstationTab);
            this.sortsStatsTabs.Location = new System.Drawing.Point(515, 14);
            this.sortsStatsTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortsStatsTabs.Name = "sortsStatsTabs";
            this.sortsStatsTabs.SelectedIndex = 0;
            this.sortsStatsTabs.Size = new System.Drawing.Size(1107, 891);
            this.sortsStatsTabs.TabIndex = 13;
            // 
            // sortsComparsionTab
            // 
            this.sortsComparsionTab.Controls.Add(this.ComparsionsCountLbl);
            this.sortsComparsionTab.Controls.Add(this.SwapsCountLbl);
            this.sortsComparsionTab.Controls.Add(this.SortsComparsion);
            this.sortsComparsionTab.Controls.Add(this.label1);
            this.sortsComparsionTab.Controls.Add(this.label2);
            this.sortsComparsionTab.Location = new System.Drawing.Point(4, 29);
            this.sortsComparsionTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortsComparsionTab.Name = "sortsComparsionTab";
            this.sortsComparsionTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortsComparsionTab.Size = new System.Drawing.Size(1099, 858);
            this.sortsComparsionTab.TabIndex = 0;
            this.sortsComparsionTab.Text = "Сравнение";
            this.sortsComparsionTab.UseVisualStyleBackColor = true;
            // 
            // ComparsionsCountLbl
            // 
            this.ComparsionsCountLbl.AutoSize = true;
            this.ComparsionsCountLbl.Location = new System.Drawing.Point(166, 28);
            this.ComparsionsCountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComparsionsCountLbl.Name = "ComparsionsCountLbl";
            this.ComparsionsCountLbl.Size = new System.Drawing.Size(0, 20);
            this.ComparsionsCountLbl.TabIndex = 3;
            // 
            // SwapsCountLbl
            // 
            this.SwapsCountLbl.AutoSize = true;
            this.SwapsCountLbl.Location = new System.Drawing.Point(158, 63);
            this.SwapsCountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SwapsCountLbl.Name = "SwapsCountLbl";
            this.SwapsCountLbl.Size = new System.Drawing.Size(0, 20);
            this.SwapsCountLbl.TabIndex = 4;
            // 
            // SortsComparsion
            // 
            this.SortsComparsion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.SortsComparsion.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.SortsComparsion.Legends.Add(legend1);
            this.SortsComparsion.Location = new System.Drawing.Point(9, 86);
            this.SortsComparsion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortsComparsion.Name = "SortsComparsion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SortsComparsion.Series.Add(series1);
            this.SortsComparsion.Size = new System.Drawing.Size(728, 435);
            this.SortsComparsion.TabIndex = 0;
            this.SortsComparsion.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число обменов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число сравнений:";
            // 
            // sortsDemonstationTab
            // 
            this.sortsDemonstationTab.Controls.Add(this.CanvasPanel);
            this.sortsDemonstationTab.Location = new System.Drawing.Point(4, 29);
            this.sortsDemonstationTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortsDemonstationTab.Name = "sortsDemonstationTab";
            this.sortsDemonstationTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortsDemonstationTab.Size = new System.Drawing.Size(797, 863);
            this.sortsDemonstationTab.TabIndex = 1;
            this.sortsDemonstationTab.Text = "Демонстрация";
            this.sortsDemonstationTab.UseVisualStyleBackColor = true;
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanvasPanel.Location = new System.Drawing.Point(4, 5);
            this.CanvasPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(789, 853);
            this.CanvasPanel.TabIndex = 10;
            // 
            // chartOptionsRadio_Swaps
            // 
            this.chartOptionsRadio_Swaps.AutoSize = true;
            this.chartOptionsRadio_Swaps.Location = new System.Drawing.Point(13, 106);
            this.chartOptionsRadio_Swaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartOptionsRadio_Swaps.Name = "chartOptionsRadio_Swaps";
            this.chartOptionsRadio_Swaps.Size = new System.Drawing.Size(95, 24);
            this.chartOptionsRadio_Swaps.TabIndex = 12;
            this.chartOptionsRadio_Swaps.TabStop = true;
            this.chartOptionsRadio_Swaps.Text = "Обмены";
            this.chartOptionsRadio_Swaps.UseVisualStyleBackColor = true;
            // 
            // chartOptionsRadio_Comparsions
            // 
            this.chartOptionsRadio_Comparsions.AutoSize = true;
            this.chartOptionsRadio_Comparsions.Checked = true;
            this.chartOptionsRadio_Comparsions.Location = new System.Drawing.Point(13, 71);
            this.chartOptionsRadio_Comparsions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartOptionsRadio_Comparsions.Name = "chartOptionsRadio_Comparsions";
            this.chartOptionsRadio_Comparsions.Size = new System.Drawing.Size(117, 24);
            this.chartOptionsRadio_Comparsions.TabIndex = 11;
            this.chartOptionsRadio_Comparsions.TabStop = true;
            this.chartOptionsRadio_Comparsions.Text = "Сравнения";
            this.chartOptionsRadio_Comparsions.UseVisualStyleBackColor = true;
            // 
            // twoWaysListInsertionSortRadio
            // 
            this.twoWaysListInsertionSortRadio.AutoSize = true;
            this.twoWaysListInsertionSortRadio.Location = new System.Drawing.Point(4, 94);
            this.twoWaysListInsertionSortRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.twoWaysListInsertionSortRadio.Name = "twoWaysListInsertionSortRadio";
            this.twoWaysListInsertionSortRadio.Size = new System.Drawing.Size(143, 64);
            this.twoWaysListInsertionSortRadio.TabIndex = 7;
            this.twoWaysListInsertionSortRadio.TabStop = true;
            this.twoWaysListInsertionSortRadio.Text = "Двухпутевыми\r\nвставками \r\nна списках";
            this.twoWaysListInsertionSortRadio.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.sortsStatsTabs);
            this.Controls.Add(this.InputDataDGV);
            this.Controls.Add(this.chartOptionsGrBox);
            this.Controls.Add(this.DrawChart);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.FillBtn);
            this.Controls.Add(this.ShuffleBtn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Сортировки";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SortPanel.ResumeLayout(false);
            this.chartOptionsGrBox.ResumeLayout(false);
            this.chartOptionsGrBox.PerformLayout();
            this.SortOptionsPanel.ResumeLayout(false);
            this.SortOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputDataDGV)).EndInit();
            this.sortsStatsTabs.ResumeLayout(false);
            this.sortsComparsionTab.ResumeLayout(false);
            this.sortsComparsionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SortsComparsion)).EndInit();
            this.sortsDemonstationTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FillBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ShuffleBtn;
        private System.Windows.Forms.GroupBox SortPanel;
        private System.Windows.Forms.RadioButton bubbleSortRadio;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button SortDemonstateBtn;
        private System.Windows.Forms.Panel SortOptionsPanel;
        private System.Windows.Forms.Button DrawChart;
        private System.Windows.Forms.GroupBox chartOptionsGrBox;
        private System.Windows.Forms.RadioButton twoWaysInsertionSortRadio;
        private System.Windows.Forms.DataGridView InputDataDGV;
        private System.Windows.Forms.TabControl sortsStatsTabs;
        private System.Windows.Forms.TabPage sortsComparsionTab;
        private System.Windows.Forms.Label ComparsionsCountLbl;
        private System.Windows.Forms.Label SwapsCountLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart SortsComparsion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage sortsDemonstationTab;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.RadioButton chartOptionsRadio_Swaps;
        private System.Windows.Forms.RadioButton chartOptionsRadio_Comparsions;
        private System.Windows.Forms.RadioButton twoWaysListInsertionSortRadio;
    }
}

