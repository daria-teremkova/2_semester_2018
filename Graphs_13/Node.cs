using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Graphs_13
{
    public class Node
    {
        public class Edge
        {
            public int A { get; set; }
            public int NumNode { get; set; }
            public int PrevNode { get; set; }
            public Color color { get; set; }
            public int length { get; set; }
            public int value { get; set; }
            public Node Neighbour { get; set; }
            public bool build { get; set; }

            public bool visited = false;

        }

        public int Distance { get; set; } // для кратчайшего расстояния
        public string name { get; set; }
        public string city { get; set; }
        public List<Edge> edge;
        public int numVisit { get; set; }
        public bool visit { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Color color = Color.Pink;
        public bool chosen { get; set; }
        //public bool periphery { get; set; }

        public Node(int ex, int ey, string number)
        {
            name = number.ToString();
            x = ex; y = ey;
            edge = new List<Edge>();
        }
    }
}
