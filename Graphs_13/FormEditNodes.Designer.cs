namespace Graphs_13
{
    partial class FormEditNodes
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
            this.label1 = new System.Windows.Forms.Label();
            this.nodeNameTB = new System.Windows.Forms.TextBox();
            this.okBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gine node a name:";
            // 
            // nodeNameTB
            // 
            this.nodeNameTB.Location = new System.Drawing.Point(163, 36);
            this.nodeNameTB.Name = "nodeNameTB";
            this.nodeNameTB.Size = new System.Drawing.Size(175, 26);
            this.nodeNameTB.TabIndex = 1;
            this.nodeNameTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nodeNameTB_KeyUp);
            // 
            // okBTN
            // 
            this.okBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBTN.Location = new System.Drawing.Point(42, 108);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(92, 31);
            this.okBTN.TabIndex = 2;
            this.okBTN.Text = "Ok";
            this.okBTN.UseVisualStyleBackColor = true;
            // 
            // cancelBTN
            // 
            this.cancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBTN.Location = new System.Drawing.Point(213, 108);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(92, 31);
            this.cancelBTN.TabIndex = 3;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            // 
            // FormEditNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 151);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.okBTN);
            this.Controls.Add(this.nodeNameTB);
            this.Controls.Add(this.label1);
            this.Name = "FormEditNodes";
            this.Text = "FormEditNodes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditNodes_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.TextBox nodeNameTB;
    }
}