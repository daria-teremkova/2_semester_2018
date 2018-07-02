using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Graphs_13
{
    public class Graph
    {
        public List<Node> nodes;
        public int[,] adjacencyMatrix { get; set; } // матрица смежности
        public int[,] frameMatrix { get; set; }

        public int[,] priceMatrix { get; set; }
        public int[] dist { get; set; }
        public int Num { get; set; }
        public int nodeIn { get; set; }
        public bool DrawEdge = false;
        public List<Node.Edge> neededEdges = new List<Node.Edge>();
        public List<Node> visitedNodes = new List<Node>();


        public Graph()
        {
            nodes = new List<Node>();
        }

        public void Clear()
        {
            nodes.Clear();
        }

        public void Choose(int n, Color color)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].chosen)
                {
                    nodes[i].chosen = false;
                    nodes[i].color = Color.Pink;
                }
            }
            nodes[n].color = color/*Firebrick*/;
            nodes[n].chosen = true;
        }

        //public void AddNode(int x, int y)           // ??????
        //{
        //    int len = nodes.Count; len++;
        //    nodes.Add(new Node(x, y, len));
        //    //Array.Resize(ref nodes, len);
        //    //nodes[len - 1] = new Node(x, y, len);

        //}
        public void AddNode(int x, int y)
        {
            string len = "0";// len++;
            //int len = GetIndexByName(nodes.Count.ToString()); len+=2;
            for (int i = 1; i < nodes.Count + 2; i++)
            {
                len = i.ToString();
                if (GetIndexByName(len) == -1)
                {
                    break;
                }
            }
            nodes.Add(new Node(x, y, len));
        }

        //public void DeleteNode(/*int x, int y, */int n)
        //{

        //    int L = nodes[n].edge.Count;
        //    for (int i = 0; i < L; i++)
        //    {
        //        DeleteEdge(n, nodes[n].edge[0].NumNode);
        //    }
        //    nodes.Remove(nodes[n]);
        //}
        public void DeleteNode(int n)
        {
            if (nodes[n].edge != null)
            {
                int L = nodes[n].edge.Count;
                for (int i = 1; i < L + 1; i++)
                {
                    DeleteEdge(n, GetNodeIndex(nodes[n].edge[0].Neighbour));
                }
            }
            nodes.Remove(nodes[n]);

            foreach (Node node in nodes)
                foreach (Node.Edge edge in node.edge)
                {
                    if (edge.NumNode > n)
                        edge.NumNode--;

                    if (edge.PrevNode > n)
                        edge.PrevNode--;
                }
        }

        public void DeleteEdge(int n1, int n2)
        {
            if (TestEdge(n1, n2))
            {
                int L = nodes[n1].edge.Count;
                int L1 = nodes[n2].edge.Count;
                int t = 0;

                for (int i = 0; i < L; i++)
                {
                    if (nodes[n1].edge[i].NumNode == n2)
                    {
                        t = i;
                        //for (int j = t; j < L - 2; i++)
                        //{
                        //    nodes[n1].edge[j] = nodes[n1].edge[j + 1];
                        //}
                        break;
                    }
                }
                nodes[n1].edge.RemoveAt(t);


                for (int i = 0; i < L1; i++)
                {
                    if (nodes[n2].edge[i].NumNode == n1)
                    {
                        t = i;
                        //for (int j = t; j < L1 - 2; i++)
                        //{
                        //    nodes[n2].edge[j] = nodes[n2].edge[j + 1];
                        //}
                        break;
                    }
                }
                nodes[n2].edge.RemoveAt(t);

                //Array.Resize(ref nodes[n1].edge, L - 1);
                //Array.Resize(ref nodes[n2].edge, L1 - 1);
            }
        }

        public void SaveGraph(string fname)
        {
            StreamWriter sw = new StreamWriter(fname);
            sw.WriteLine(nodes.Count);
            for (int i = 0; i < nodes.Count; i++)
            {
                sw.WriteLine(nodes[i].name);
                sw.WriteLine(nodes[i].city);
                sw.WriteLine(nodes[i].x + " " + nodes[i].y);
                
            }
            int[,] matr = CreateWayMatrix();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    sw.Write(matr[i, j].ToString() + ' ');

                }
                sw.WriteLine();
            }
            sw.Close();
        }

        public void ReadGraph(string fname)
        {
            StreamReader sr = new StreamReader(fname);
            nodes = new List<Node>();
            int cnt = int.Parse(sr.ReadLine());
            string name, city; int x, y;
            for (int m = 0; m < cnt; m++)
            {
                
                name = sr.ReadLine();
                city = sr.ReadLine();
                string[] xxxx = sr.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                x = int.Parse(xxxx[0]);
                y = int.Parse(xxxx[1]);
                Node node = new Node(x, y, name);
                nodes.Add(node);

            }

            int[,] matr = new int[cnt, cnt];
            string[] line = new string[cnt];
            for (int i = 0; i < cnt; i++)
            {
                line = sr.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cnt; j++)
                {
                    matr[i, j] = int.Parse(line[j]);
                }

            }

            SetEdges(matr);

            sr.Close();
        }

        public void SetEdges(int[,] matr)
        {
            //adjacencyMatrix = matr;

            foreach (Node node in nodes)
                node.edge.Clear();

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] != 0)
                    {
                        //nodes[i].edge.Resize(ref nodes[i].edge, 0);
                        Node.Edge edge = new Node.Edge();
                        //edge.length = matr[i,j];
                        edge.NumNode = j;
                        edge.color = Color.Black;
                        edge.value = matr[i, j];
                        

                        if (i != j)
                        {
                            nodes[i].edge.Add(edge);

                            edge = new Node.Edge();
                            edge.NumNode = i;
                            edge.PrevNode = j;
                            edge.color = Color.Black;
                            edge.value = matr[i, j];
                            //edge.value = distance;

                            nodes[j].edge.Add(edge);
                        }
                        //else if (i == j)
                        //    nodes[i].edge.Add(edge);
                    }

                }
            }
        }

        bool TestEdge(int n1, int n2)  
        {
            int len = nodes[n1].edge.Count;
            for (int i = 0; i < len; i++)
            {
                if ((nodes[n1].edge[i].NumNode == n2))
                { return true; }
            }
            return false;
        }



        public void AddEdge(int n1, int n2, int distance)
        {
            if (!TestEdge(n1, n2))
            {
                int dx = nodes[n2].x - nodes[n1].x;
                int dy = nodes[n2].y - nodes[n1].y;
                double x = dx * dx + dy * dy;
                x = Math.Pow(x, 0.5);
                int dist = Convert.ToInt32(x);  
                int len = nodes[n1].edge.Count;
                if (distance == -1) distance = dist;
                //Array.Resize(ref nodes[n1].edge, len + 1);
                Node.Edge edge = new Node.Edge();

                edge.length = dist;
                edge.NumNode = n2;
                edge.color = Color.Black;
                edge.value = distance;
                edge.PrevNode = n1;
                nodes[n1].edge.Add(edge);

                len = nodes[n2].edge.Count;
                //Array.Resize(ref nodes[n2].edge, len + 1);
                edge = new Node.Edge();

                edge.length = dist;
                edge.NumNode = n1;
                edge.color = Color.Black;
                edge.value = distance;
                edge.PrevNode = n2;
                nodes[n2].edge.Add(edge);
            }
        }

        public void VisitTrue(int n)//метод отметки посещенных вершин. На вход подается сам узел.
        {
            Num++;//увеличивается количество посещённых вершин
            nodes[n].visit = true; //n-ой вершине ставится метка посещённости
            nodes[n].numVisit = Num;
        }

        public int GetNodeIndex(Node node)         // ????
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i] == node)
                    return i;
            }
            return -1;
        }

        public int GetIndexByName(string name)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (name == nodes[i].name)
                    return i;
            }
            return -1;
        }

        public void FindDepth(int n, ref int count) //функция поиска в глубину
        {
            VisitTrue(n);
            count++;
            int LL = 0; // кол-во нодов
            if (nodes[n].edge != null)
            {
                LL = nodes[n].edge.Count;
                int i = -1;
                while (i < LL - 1)
                {
                    int m = nodes[n].edge[++i].NumNode;
                    if (!nodes[m].visit)
                    {
                        FindDepth(m, ref count);
                    }
                }
            }
        }

        public bool CheckConnect()
        {
            //bool connect = false;
            int count = 0;
            FindDepth(0, ref count);

            if (count == nodes.Count)
                return true;
            else return false;
        }

        public void FindCheepestWays()
        {
            visitedNodes.Clear();
            neededEdges.Clear();

            foreach (Node node in nodes)
            {
                foreach (Node.Edge edge in node.edge)
                {
                    edge.visited = false;
                    edge.build = false;
                }

                node.visit = false;
            }
            
            List<Node.Edge> allEdges = new List<Node.Edge>();
            FindCheepestWays1(nodes[0], allEdges);
        }

        private void FindCheepestWays1(Node node, List<Node.Edge> allEdges)     // алгоритм Прима для поиска 
        {
            int visitedNodesCount = 0;

            foreach (Node tempNode in nodes)
                if (tempNode.visit)
                    visitedNodesCount++;

            if (visitedNodesCount == nodes.Count)
                return;

            node.visit = true;

            foreach (Node.Edge edge in node.edge)
                if (!edge.visited)
                    allEdges.Add(edge);

            visitedNodes.Add(node);

            if (allEdges.Count == 0)
                return;

            Node.Edge minEdge = allEdges[0];

            for (int i = 1; i < allEdges.Count; i++)
                if (allEdges[i].value < minEdge.value)
                    minEdge = allEdges[i];

            if (!nodes[minEdge.NumNode].visit)
                minEdge.build = true;

            List<Node.Edge> removedEdges = new List<Node.Edge>();
            foreach (Node.Edge edge in allEdges)
                if (edge == minEdge)
                    removedEdges.Add(edge);

            foreach (Node.Edge edge in removedEdges)
                allEdges.Remove(edge);

            allEdges.Remove(minEdge);
           
            minEdge.visited = true;
            FindCheepestWays1(nodes[minEdge.NumNode], allEdges);
        }
        
        public int CountMinPrice()
        {
            int summ = 0;
            for (int n = 0; n < nodes.Count; n++)
            {
                for (int e = 0; e < nodes[n].edge.Count; e++)
                {
                    if (nodes[n].edge[e].build == true)
                        summ += nodes[n].edge[e].value;
                }
            }
            //summ = summ / 2;

            return summ;
        }

        private int MinKey(int[] key, bool[] set)
        {
            int min = int.MaxValue, minIndex = 0;

            for (int v = 0; v < nodes.Count; ++v)
                if (set[v] == false && key[v] < min)
                {
                    min = key[v];
                    minIndex = v;
                }

            return minIndex;
        }

        public int[,] CreateWayMatrix() //создание матрицы смежности для сохранения расстояний
        {
            int n = nodes.Count;
            adjacencyMatrix = new int[n, n];

            //for (int i = 0; i < n; i++) 
            // for (int j = 0; j < n; j++) 
            // A[i, j] = 1; 
            //матрица достижимости 

            for (int i = 0; i < n; i++)
            {
                adjacencyMatrix[i, i] = 0;
                int eL = 0;
                if (nodes[i].edge != null)
                {
                    eL = nodes[i].edge.Count;
                    for (int j = 0; j < eL; j++)
                    {
                        adjacencyMatrix[i, nodes[i].edge[j].NumNode] = nodes[i].edge[j].value;
                    }
                }
            }
            return adjacencyMatrix;
        }
        Random rnd = new Random();
        //public void 

        public void GetPeriphery(Node node, int n)
        {
            FindShortestWay1(node);
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Distance > n)
                {
                    //nodes[i].chosen = true;
                    //Choose(i, Color.BlueViolet);
                    nodes[i].color = Color.DarkRed;
                }
                else nodes[i].color = Color.Pink;
            }

        }

        public void FindShortestWay1(Node node)
        {
            for (int i = 0; i < nodes.Count; i++)
                nodes[i].Distance = 100000;

            node.Distance = 0;
            
            FindShortestWay(node);
        }

        private void FindShortestWay(Node node)
        {
            if (node.edge == null)
                return;
            else
            {
               // node.visit = true;
                for (int i = 0; i < node.edge.Count; i++)
                {
                    
                    if (nodes[node.edge[i].NumNode].Distance > node.Distance + node.edge[i].value)
                    {
                        nodes[node.edge[i].NumNode].Distance = node.Distance + node.edge[i].value;
                        FindShortestWay(nodes[node.edge[i].NumNode]);
                    }
                }
            }
        }

        //void SetMatr()
        //{
        //    int N = nodes.Count;
        //    adjacencyMatrix = new int[N, N];
        //    for (int i = 0; i <= N - 1; i++)
        //        for (int j = 0; j <= N - 1; j++)
        //            adjacencyMatrix[i, j] = 0xFFFFF; // int.MaxValue; 
        //    for (int i = 0; i <= N - 1; i++)
        //    {
        //        adjacencyMatrix[i, i] = 0;
        //        int LL = 0;
        //        if (nodes[i].edge != null)
        //        {
        //            LL = nodes[i].edge.Count;
        //            for (int j = 0; j <= LL - 1; j++)
        //                adjacencyMatrix[i, nodes[i].edge[j].NumNode] = nodes[i].edge[j].A;
        //        }
        //    }
        //}



        public void ClearVisit() //метод снятия посещенности
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                nodes[i].visit = false;
            }
        }

        
    }
}
