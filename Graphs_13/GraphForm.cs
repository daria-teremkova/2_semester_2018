using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Graphs_13
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            //Graphics gr = CreateGraphics();
            //Graphics GlGr = gr;
            //Graph graph = new Graph();
            ////Global.GlGraph = graph;
            //edgeRB.Checked = false;
            da = new Draws(graph);
        }

        Draws da;
        Graph graph = new Graph();
        string openName, saveName;

        private void GraphForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (graph.DrawEdge)
            {
                Graphics gr = CreateGraphics();
                Pen pen = new Pen(Color.Black, 1);

                gr.DrawEllipse(pen, e.X, e.Y, 1, 1);
                gr.Dispose();
                pen.Dispose();
            }
        }

        private void GraphForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (edgeRB.Checked)
            {
                FormEditEdge fee = new FormEditEdge();
                fee.Weight = 100;
                int dist = -1;
                if (fee.ShowDialog() == DialogResult.OK)
                {
                    dist = fee.Weight;
                    int n = da.FindNode(e.X, e.Y);
                    if (n != -1) graph.AddEdge(graph.nodeIn, n, dist);
                }
                Graphics gr = CreateGraphics();
                Rectangle rec = new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height);
                Color col = DefaultBackColor;
                gr.Clear(col);
                da.ShowGraph(gr, col);
                gr.Dispose();
                graph.DrawEdge = false;
            }
        }

        private void GraphForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (nodeRB.Checked)
            {
                FormEditNodes fen = new FormEditNodes();
                fen.Name = "No name";
                Graphics gr = CreateGraphics();
                //graph.AddNode(e.X, e.Y);
                int len = graph.nodes.Count;
                if (fen.ShowDialog() == DialogResult.OK)
                {
                    //if (fen.nodeNameTB.Text != null)
                    //Graphics gr = CreateGraphics();
                    graph.AddNode(e.X, e.Y);
                    len = graph.nodes.Count;
                    graph.nodes[graph.nodes.Count - 1].city = fen.Name;
                    da.DrawNode(gr, GraphForm.DefaultBackColor, graph.nodes[len - 1]);

                }


                gr.Dispose();
            }
            else 
            if (edgeRB.Checked)
            {
                int n = da.FindNode(e.X, e.Y);
                if (n != -1)
                {
                    graph.DrawEdge = true;
                    graph.nodeIn = n;
                }
            }
            else 
            if (checkNodeRB.Checked)
            {
                Graphics gr = CreateGraphics();
                int n = da.FindNode(e.X, e.Y);
                if (n != -1) // спрятать в класс графа, отделить рисование от выделения
                {
                    //for (int i = 0; i< graph.nodes.Count; i++)
                    //{
                    //    if (graph.nodes[i].chosen)
                    //    {
                    //        graph.nodes[i].chosen = false;
                    //        graph.nodes[i].color = Color.Pink;
                    //        da.DrawNode(gr, DefaultBackColor, graph.nodes[i]);
                    //    }
                    //}
                    //graph.nodes[n].color = Color.Firebrick;
                    //graph.nodes[n].chosen = true;
                    graph.Choose(n, Color.Firebrick);
                    da.ShowGraph(gr, DefaultBackColor);
                    gr.Dispose();
                }

            }
            // добавить удаление узлов, ребер (+ редактирование узлов и ребер??)
        }


        

        private void clearBTN_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            Rectangle rec = new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height);
            Color col = DefaultBackColor;
            gr.Clear(col);
            gr.Dispose();
            graph.Clear();
            //graph = new Graph();
            //Array.Resize(ref Global.GlGraph.nodes, 0);
            graph.DrawEdge = false;
            edgeRB.Checked = false;
            nodeRB.Checked = false;
        }

        private void resultBTN_Click(object sender, EventArgs e)
        {
            if (checkNodeRB.Checked)
            {
                Node node = null;
                for(int i = 0; i < graph.nodes.Count; i++)
                {
                    if (graph.nodes[i].chosen)
                        node = graph.nodes[i];
                }
                if (node != null)
                    graph.GetPeriphery(node, int.Parse(distanceTB.Text));
                else
                    MessageBox.Show("Node not selected!!!");
                Graphics gr = CreateGraphics();
                gr.Clear(DefaultBackColor);
                da.ShowGraph(gr, DefaultBackColor);
            }
            
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            for (int i = 0; i < graph.nodes.Count; i++)
            {
                graph.nodes[i].chosen = false;
                graph.nodes[i].color = Color.Pink;
                da.DrawNode(gr, DefaultBackColor, graph.nodes[i]);
            }
            checkNodeRB.Checked = false;
            edgeRB.Checked = false;
            nodeRB.Checked = false;
        }

        private int removeN = -1;

        private void GraphForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (delNodeRB.Checked)
            {
                //Graphics gr = CreateGraphics();
                int n = da.FindNode(e.X, e.Y);
                //graph.DeleteNode(n);
                Graphics gr = CreateGraphics();
                //int n = Convert.ToInt32(GetN1TB.Text);
                graph.DeleteNode(n);
                gr.Clear(DefaultBackColor);
                da.ShowGraph(gr, DefaultBackColor);

            }
            else if (delEdgeRB.Checked)
            {                
                int n1 = da.FindNode(e.X, e.Y);
                if (removeN == -1)
                {
                    removeN = n1;
                    return;
                }
                //int n2 = da.FindNode(e.X, e.Y);
                Graphics gr = CreateGraphics();
                graph.DeleteEdge(n1, removeN);
                gr.Clear(DefaultBackColor);
                da.ShowGraph(gr, DefaultBackColor);
                removeN = -1;
            }

        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return; /*Если в OpenFileDialog пользователь не выбрал файл, то ничего не делаем.*/
            /*Иначе - пользователь выбрал какой-то файл*/
            saveName = sfd.FileName;
            graph.SaveGraph(saveName);

        }

        private void setPriceBTN_Click(object sender, EventArgs e)
        {
            PriceEditForm pef = new PriceEditForm();
            pef.graph = graph;
            Graphics gr = CreateGraphics();
            gr.Clear(DefaultBackColor);
            if (pef.ShowDialog() == DialogResult.OK)
            {
                graph.priceMatrix = pef.GetMatrix();
                graph.SetEdges(graph.priceMatrix);
            }
            
            //gr.Clear(DefaultBackColor);
            da.ShowGraph(gr, DefaultBackColor);
            //return;
            // метод, чтобы взять у формы активную матрицу и присвоить в priceMatrix графа

        }

        private void buildBTN_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            gr.Clear(DefaultBackColor);

            graph.FindCheepestWays();
            
            da.ShowGraph(gr, Color.Red);
            priceTB.Text = graph.CountMinPrice().ToString();

        }

        private void distanceTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void priceTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void GraphForm_Resize(object sender, EventArgs e)
        {
            if (da != null)
            {
                Graphics gr = CreateGraphics();
                da.ShowGraph(gr, DefaultBackColor);
            }
        }

        private void openBTN_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
                return; /*Если в OpenFileDialog пользователь не выбрал файл, то ничего не делаем.*/
            /*Иначе - пользователь выбрал какой-то файл*/
            openName = ofd.FileName;
            graph.ReadGraph(openName);
            Graphics gr = CreateGraphics();
            da.ShowGraph(gr, DefaultBackColor);
        }
    }
}
