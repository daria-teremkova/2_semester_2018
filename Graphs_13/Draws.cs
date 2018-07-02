using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Graphs_13
{
    class Draws
    {
        private Graph graph;

        public Draws(Graph gr)
        {
            graph = gr;
        }

        public int[] dist { get; set; }
        public List<Node> nodes
        {
            get
            {
                return graph.nodes;
            }
        }
        const int radius = 17;

        public int FindNode(int aX, int aY) // передаёт номер узла
        {
            int result = -1;
            for (int i = 0; i < nodes.Count; i++)
            {
                int nx = nodes[i].x;
                int ny = nodes[i].y;
                if ((nx - aX) * (nx - aX) + (ny - aY) * (ny - aY) < 2700)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }



        public void ShowGraph(Graphics gr, Color col)
        {
            gr.Clear(SystemColors.Control);

            Font font = new Font("Arial", 10, FontStyle.Regular);
            int NumNodes = nodes.Count;
            for (int i = 0; i < NumNodes; i++)
            {
                int numE = nodes[i].edge.Count;
                int curX = nodes[i].x;
                int curY = nodes[i].y;

                for (int j = 0; j < numE; j++) // рисуем рёбра
                {
                    int toX = nodes[nodes[i].edge[j].NumNode].x;
                    int toY = nodes[nodes[i].edge[j].NumNode].y;
                    Color cl = nodes[i].edge[j].color;
                    Pen pen1 = new Pen(Color.Black, 1);
                    Pen pen2 = new Pen(col, 3);
                    if (nodes[i].edge[j].build)
                        gr.DrawLine(pen2, curX + 21, curY + 11, toX + 21, toY + 11);
                    else
                        gr.DrawLine(pen1, curX + 21, curY + 11, toX + 21, toY + 11);
                    string dist = Convert.ToString(nodes[i].edge[j].value);
                    int captionX = (curX + toX) / 2;
                    int captionY = (curY + toY) / 2;
                    Rectangle rec = new Rectangle(captionX, captionY, 50, 21);
                    gr.DrawString(dist, font, Brushes.Black, rec);
                }
            }//  рёбра всех узлов

            for (int i = 0; i < NumNodes; i++)
                DrawNode(gr, col, nodes[i]); // рисуем узлы
        }
        public void DrawNode(Graphics gr, Color col, Node graph)
        {
            Pen pen = new Pen(graph.color, 2);
            Font font = new Font("Arial", 12, FontStyle.Regular);
            SolidBrush br = new SolidBrush(Color.Pink);
            SolidBrush br1 = new SolidBrush(col);
            gr.FillEllipse(br, graph.x, graph.y, 3 * radius, 3 * radius);

            gr.DrawEllipse(pen, graph.x, graph.y, 3 * radius, 3 * radius);
            gr.DrawString(graph.name, font, Brushes.Black, graph.x + radius, graph.y + radius);
            gr.DrawString(graph.city, font, Brushes.Black, graph.x + radius, graph.y - 6);

            gr.DrawString(graph.Distance.ToString(), font, Brushes.Black, graph.x + radius, graph.y + 50);
        } // DrawNode
    }
}
