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
    public partial class FormEditEdge : Form
    {
        public FormEditEdge()
        {
            InitializeComponent();
        }

        private void EdgeDistTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OkBTN.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                CancelBTN.PerformClick();
            }
        }

        public int Weight
        {
            get { return int.Parse(EdgeDistTB.Text); }
            set { EdgeDistTB.Text = value.ToString(); }
        }

        private void FormEditEdge_FormClosing(object sender, FormClosingEventArgs e)
        {
            int q;
            if (!int.TryParse(EdgeDistTB.Text, out q) && DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Incorrect value!");
                e.Cancel = true;
            }
        }
    }
}
