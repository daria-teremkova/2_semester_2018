namespace Graphs_13
{
    partial class FormEditEdge
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
            this.EdgeDistTB = new System.Windows.Forms.TextBox();
            this.OkBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.textLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EdgeDistTB
            // 
            this.EdgeDistTB.Location = new System.Drawing.Point(146, 34);
            this.EdgeDistTB.Name = "EdgeDistTB";
            this.EdgeDistTB.Size = new System.Drawing.Size(192, 26);
            this.EdgeDistTB.TabIndex = 0;
            this.EdgeDistTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EdgeDistTB_KeyUp);
            // 
            // OkBTN
            // 
            this.OkBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBTN.ImageKey = "(отсутствует)";
            this.OkBTN.Location = new System.Drawing.Point(27, 104);
            this.OkBTN.Name = "OkBTN";
            this.OkBTN.Size = new System.Drawing.Size(89, 35);
            this.OkBTN.TabIndex = 1;
            this.OkBTN.Text = "Ok";
            this.OkBTN.UseVisualStyleBackColor = true;
            // 
            // CancelBTN
            // 
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Location = new System.Drawing.Point(212, 105);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(111, 35);
            this.CancelBTN.TabIndex = 2;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            // 
            // textLBL
            // 
            this.textLBL.AutoSize = true;
            this.textLBL.Location = new System.Drawing.Point(23, 40);
            this.textLBL.Name = "textLBL";
            this.textLBL.Size = new System.Drawing.Size(83, 20);
            this.textLBL.TabIndex = 3;
            this.textLBL.Text = "Edit Edge:";
            // 
            // FormEditEdge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 152);
            this.Controls.Add(this.textLBL);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.OkBTN);
            this.Controls.Add(this.EdgeDistTB);
            this.Name = "FormEditEdge";
            this.Text = "FormEditEdge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditEdge_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OkBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Label textLBL;
        private System.Windows.Forms.TextBox EdgeDistTB;
    }
}