namespace Graphs_13
{
    partial class PriceEditForm
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.okBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.randomBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 63);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(606, 418);
            this.DGV.TabIndex = 0;
            this.DGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellEndEdit);
            this.DGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseDoubleClick);
            // 
            // okBTN
            // 
            this.okBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBTN.Location = new System.Drawing.Point(424, 11);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(92, 44);
            this.okBTN.TabIndex = 2;
            this.okBTN.Text = "Ok";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBTN.Location = new System.Drawing.Point(522, 11);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(92, 44);
            this.cancelBTN.TabIndex = 3;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            // 
            // randomBTN
            // 
            this.randomBTN.Location = new System.Drawing.Point(12, 11);
            this.randomBTN.Name = "randomBTN";
            this.randomBTN.Size = new System.Drawing.Size(92, 44);
            this.randomBTN.TabIndex = 4;
            this.randomBTN.Text = "Random";
            this.randomBTN.UseVisualStyleBackColor = true;
            this.randomBTN.Click += new System.EventHandler(this.randomBTN_Click);
            // 
            // PriceEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 493);
            this.Controls.Add(this.randomBTN);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.okBTN);
            this.Controls.Add(this.DGV);
            this.Name = "PriceEditForm";
            this.Text = "PriceEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button randomBTN;
    }
}