namespace Interpreter_17._4
{
    partial class InterpreterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.expressionTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.parseBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an expression:";
            // 
            // expressionTB
            // 
            this.expressionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expressionTB.Location = new System.Drawing.Point(13, 38);
            this.expressionTB.Name = "expressionTB";
            this.expressionTB.Size = new System.Drawing.Size(557, 26);
            this.expressionTB.TabIndex = 1;
            this.expressionTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.expressionTB_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result:";
            // 
            // resultTB
            // 
            this.resultTB.Location = new System.Drawing.Point(12, 192);
            this.resultTB.Name = "resultTB";
            this.resultTB.Size = new System.Drawing.Size(100, 26);
            this.resultTB.TabIndex = 3;
            // 
            // parseBTN
            // 
            this.parseBTN.Location = new System.Drawing.Point(17, 84);
            this.parseBTN.Name = "parseBTN";
            this.parseBTN.Size = new System.Drawing.Size(155, 66);
            this.parseBTN.TabIndex = 4;
            this.parseBTN.Text = "Parse expression and count ";
            this.parseBTN.UseVisualStyleBackColor = true;
            this.parseBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // InterpreterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 323);
            this.Controls.Add(this.parseBTN);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expressionTB);
            this.Controls.Add(this.label1);
            this.Name = "InterpreterForm";
            this.Text = "Interpreter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expressionTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTB;
        private System.Windows.Forms.Button parseBTN;
    }
}

