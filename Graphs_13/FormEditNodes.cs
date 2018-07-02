using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs_13
{
    public partial class FormEditNodes : Form
    {
        public FormEditNodes()
        {
            InitializeComponent();
        }
        public string Name
        {
            get { return nodeNameTB.Text; }
            set { nodeNameTB.Text = value; }
        }

        private void nodeNameTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okBTN.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cancelBTN.PerformClick();
            }
        }

        private void FormEditNodes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //string q;
            if (nodeNameTB.Text == null && DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Incorrect value!");
                e.Cancel = true;
            }
        }
    }

    
}
