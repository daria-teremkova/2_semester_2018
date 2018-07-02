using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpreter_17._4
{
    public partial class InterpreterForm : Form
    {
        public InterpreterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs ev)
        {
            CalculateExpression(expressionTB.Text);
        }

        private void expressionTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                parseBTN.PerformClick();
        }

        private void CalculateExpression(string expression)
        {
            try
            {
                ExpressionNode expressionTreeRoot = Interprete.ParseExpression(expression);

                resultTB.Text = expressionTreeRoot.Calculate().ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Укажите корректное выражение", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
