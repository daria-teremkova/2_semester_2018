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
    public partial class PriceEditForm : Form
    {
        public PriceEditForm()
        {
            InitializeComponent();
        }
        private Graph g;
        public Graph graph
        {
            set { g = value; FillDGV(DGV, g); }
        }

        private void FillDGV(DataGridView dgv, Graph g)
        {
            dgv.ColumnCount = dgv.RowCount = g.nodes.Count;
            g.CreateWayMatrix();
            for (int i = 0; i < DGV.ColumnCount; i++)
            {
                for (int j = i; j < DGV.RowCount; j++)
                {
                    if (i == j)
                        DGV[i, j].Value = "x";
                    else
                        DGV[j, i].Value = DGV.Rows[j].Cells[i].Value = g.adjacencyMatrix[i, j];
                }
            }
            for (int k = 0; k < g.nodes.Count; k++)
            {
                dgv.Rows[k].HeaderCell.Value = dgv.Columns[k].HeaderText = g.nodes[k].city;
                dgv[k, k].Value = "x";
                dgv[k, k].ReadOnly = true;
            }
        }

        public int[,] GetMatrix()
        {
            int[,] matrix = new int[DGV.RowCount, DGV.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (DGV[j, i].Value.ToString() == "x")
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = int.Parse(DGV[j, i].Value.ToString());
            }

            return matrix;
        }

        private void SetRandomMatrix()
        {
            Random rnd = new Random();
            for (int i = 0; i < DGV.ColumnCount; i++)
            {
                for (int j = i; j < DGV.RowCount; j++)
                {
                    if (i == j)
                        DGV[i, j].Value = "x";
                    else
                        DGV[j, i].Value = DGV.Rows[j].Cells[i].Value = rnd.Next(30, 100).ToString();
                }
            }
        }

        private void randomBTN_Click(object sender, EventArgs e)
        {
            SetRandomMatrix();
        }

        private void DGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGV[e.RowIndex, e.ColumnIndex].ReadOnly = DGV[e.ColumnIndex, e.RowIndex].ReadOnly = !DGV[e.ColumnIndex, e.RowIndex].ReadOnly;
            if (DGV[e.ColumnIndex, e.RowIndex].ReadOnly)
            {
                DGV[e.ColumnIndex, e.RowIndex].Value = "x";
                DGV[e.RowIndex, e.ColumnIndex].Value = "x";
            }                
            else
            {
                DGV[e.ColumnIndex, e.RowIndex].Value = 0;
                DGV[e.RowIndex, e.ColumnIndex].Value = 0;
            }
        }

        private void DGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DGV[e.RowIndex, e.ColumnIndex].Value = DGV[e.ColumnIndex, e.RowIndex].Value;
        }

        private void okBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
