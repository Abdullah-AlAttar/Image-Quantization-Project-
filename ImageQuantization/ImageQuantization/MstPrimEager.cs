using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace ImageQuantization
{
    public struct Edge : IComparable<Edge>
    {
        public int from, to;
        public double cost;
        public Edge(double cost, int f, int t)
        {
            from = f;
            to = t;
            this.cost = cost;
        }
        public int CompareTo(Edge other)
        {
            if (this.cost < other.cost)
                return -1;
            else if (this.cost > other.cost)
                return 1;
            else return 0;
        }
    }
    class MstPrimEager
    {
        public Edge[] edgeTo { set; get; }

       
        private double[] distTo;
        private bool[] visited;
        private IPriorityQueue ipq;
        private int V;// number of vertices in the graph
        
        public MstPrimEager(int GraphNodesCount)
        {
            V = GraphNodesCount;
            edgeTo = new Edge[V];
            distTo = new double[V];
            visited = new bool[V];
            ipq = new IPriorityQueue(V);
            for (int i = 0; i < V; ++i)
            {
                distTo[i] = double.MaxValue;
            }
                
        }
        public void GetMst()
        {
            Visit(0);
           double sum = 0;
            for(int i=0;i<edgeTo.Count();++i)
            {
                sum += edgeTo[i].cost;
            }
            MainForm.mstVal = sum;
        }

        private void Visit(int i)
        {
            distTo[i] = 0;
            ipq.Insert(i, distTo[i]);
            while (!ipq.IsEmpty())
            {
                int j = ipq.DeleteMin();
                Proccess(j);
            }
        }
        private void Proccess(int j)
        {
            visited[j] = true;
            for (int i = 0; i < V; ++i)
            {
                if (visited[i]) continue;
                double edgeCost = Util.CalculateEdgeValue(j, i);
                if (edgeCost < distTo[i])
                {
                    distTo[i] = edgeCost;
                    edgeTo[i] = new Edge(edgeCost, j, i);
                    if (ipq.Contains(i))
                    {
                        ipq.DecreaseKey(i, distTo[i]); 
                    }
                    else ipq.Insert(i, distTo[i]);
                }
            }
        }
    }
}
