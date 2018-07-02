namespace Graphs_13
{
    partial class GraphForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.edgeRB = new System.Windows.Forms.RadioButton();
            this.nodeRB = new System.Windows.Forms.RadioButton();
            this.distanceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delEdgeRB = new System.Windows.Forms.RadioButton();
            this.delNodeRB = new System.Windows.Forms.RadioButton();
            this.checkNodeRB = new System.Windows.Forms.RadioButton();
            this.resetBTN = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.openBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.setPriceBTN = new System.Windows.Forms.Button();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buildBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edgeRB
            // 
            this.edgeRB.AutoSize = true;
            this.edgeRB.Location = new System.Drawing.Point(3, 33);
            this.edgeRB.Name = "edgeRB";
            this.edgeRB.Size = new System.Drawing.Size(108, 24);
            this.edgeRB.TabIndex = 1;
            this.edgeRB.Text = "draw edge";
            this.edgeRB.UseVisualStyleBackColor = true;
            // 
            // nodeRB
            // 
            this.nodeRB.AutoSize = true;
            this.nodeRB.Checked = true;
            this.nodeRB.Location = new System.Drawing.Point(3, 3);
            this.nodeRB.Name = "nodeRB";
            this.nodeRB.Size = new System.Drawing.Size(108, 24);
            this.nodeRB.TabIndex = 0;
            this.nodeRB.TabStop = true;
            this.nodeRB.Text = "draw node";
            this.nodeRB.UseVisualStyleBackColor = true;
            // 
            // distanceTB
            // 
            this.distanceTB.Location = new System.Drawing.Point(235, 39);
            this.distanceTB.Name = "distanceTB";
            this.distanceTB.Size = new System.Drawing.Size(100, 26);
            this.distanceTB.TabIndex = 1;
            this.distanceTB.TextChanged += new System.EventHandler(this.distanceTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distance:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultBTN
            // 
            this.resultBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.resultBTN.Location = new System.Drawing.Point(385, 13);
            this.resultBTN.Name = "resultBTN";
            this.resultBTN.Size = new System.Drawing.Size(113, 100);
            this.resultBTN.TabIndex = 3;
            this.resultBTN.Text = "Find periphery";
            this.resultBTN.UseVisualStyleBackColor = false;
            this.resultBTN.Click += new System.EventHandler(this.resultBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clearBTN.Location = new System.Drawing.Point(640, 36);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(111, 55);
            this.clearBTN.TabIndex = 4;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delEdgeRB);
            this.panel1.Controls.Add(this.delNodeRB);
            this.panel1.Controls.Add(this.checkNodeRB);
            this.panel1.Controls.Add(this.nodeRB);
            this.panel1.Controls.Add(this.edgeRB);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 151);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // delEdgeRB
            // 
            this.delEdgeRB.AutoSize = true;
            this.delEdgeRB.Location = new System.Drawing.Point(3, 123);
            this.delEdgeRB.Name = "delEdgeRB";
            this.delEdgeRB.Size = new System.Drawing.Size(118, 24);
            this.delEdgeRB.TabIndex = 4;
            this.delEdgeRB.Text = "delete edge";
            this.delEdgeRB.UseVisualStyleBackColor = true;
            // 
            // delNodeRB
            // 
            this.delNodeRB.AutoSize = true;
            this.delNodeRB.Location = new System.Drawing.Point(3, 93);
            this.delNodeRB.Name = "delNodeRB";
            this.delNodeRB.Size = new System.Drawing.Size(118, 24);
            this.delNodeRB.TabIndex = 3;
            this.delNodeRB.Text = "delete node";
            this.delNodeRB.UseVisualStyleBackColor = true;
            // 
            // checkNodeRB
            // 
            this.checkNodeRB.AutoSize = true;
            this.checkNodeRB.Location = new System.Drawing.Point(3, 63);
            this.checkNodeRB.Name = "checkNodeRB";
            this.checkNodeRB.Size = new System.Drawing.Size(126, 24);
            this.checkNodeRB.TabIndex = 2;
            this.checkNodeRB.Text = "choose node";
            this.checkNodeRB.UseVisualStyleBackColor = true;
            // 
            // resetBTN
            // 
            this.resetBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.resetBTN.Location = new System.Drawing.Point(523, 36);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(111, 55);
            this.resetBTN.TabIndex = 6;
            this.resetBTN.Text = "Reset";
            this.resetBTN.UseVisualStyleBackColor = false;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // openBTN
            // 
            this.openBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.openBTN.Location = new System.Drawing.Point(781, 16);
            this.openBTN.Name = "openBTN";
            this.openBTN.Size = new System.Drawing.Size(75, 49);
            this.openBTN.TabIndex = 7;
            this.openBTN.Text = "Open";
            this.openBTN.UseVisualStyleBackColor = false;
            this.openBTN.Click += new System.EventHandler(this.openBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveBTN.Location = new System.Drawing.Point(781, 62);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 52);
            this.saveBTN.TabIndex = 8;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = false;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // setPriceBTN
            // 
            this.setPriceBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.setPriceBTN.Location = new System.Drawing.Point(872, 16);
            this.setPriceBTN.Name = "setPriceBTN";
            this.setPriceBTN.Size = new System.Drawing.Size(107, 49);
            this.setPriceBTN.TabIndex = 9;
            this.setPriceBTN.Text = "Set price";
            this.setPriceBTN.UseVisualStyleBackColor = false;
            this.setPriceBTN.Click += new System.EventHandler(this.setPriceBTN_Click);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(872, 91);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(107, 26);
            this.priceTB.TabIndex = 10;
            this.priceTB.TextChanged += new System.EventHandler(this.priceTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(868, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Min price:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buildBTN
            // 
            this.buildBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buildBTN.Location = new System.Drawing.Point(985, 17);
            this.buildBTN.Name = "buildBTN";
            this.buildBTN.Size = new System.Drawing.Size(113, 100);
            this.buildBTN.TabIndex = 12;
            this.buildBTN.Text = "Find best roads to build";
            this.buildBTN.UseVisualStyleBackColor = false;
            this.buildBTN.Click += new System.EventHandler(this.buildBTN_Click);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1344, 659);
            this.Controls.Add(this.buildBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.setPriceBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.openBTN);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.resultBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distanceTB);
            this.Name = "GraphForm";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseUp);
            this.Resize += new System.EventHandler(this.GraphForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton edgeRB;
        private System.Windows.Forms.RadioButton nodeRB;
        private System.Windows.Forms.TextBox distanceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resultBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton checkNodeRB;
        private System.Windows.Forms.Button resetBTN;
        private System.Windows.Forms.RadioButton delNodeRB;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button openBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.RadioButton delEdgeRB;
        private System.Windows.Forms.Button setPriceBTN;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buildBTN;
    }
}

