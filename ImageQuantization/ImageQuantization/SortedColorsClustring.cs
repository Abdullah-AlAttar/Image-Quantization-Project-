using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageQuantization
{
    class SortedColorsClustring
    {
        int K, V;
        Edge[] edgeTo;
        Edge[] costs;
        public Dictionary<int, RGBPixel> Palette;
        public SortedColorsClustring(int K,int V)
        {
            this.K = K;
            this.V = V;
            CalculateEdges();
            this.costs = edgeTo.OrderBy(node => node.cost).ToArray();
            Palette = new Dictionary<int, RGBPixel>();
        }
        private void CalculateEdges()
        {
            edgeTo = new Edge[V];
            edgeTo[0] = new Edge(0, 0, 0);
            for (int i = 1; i < V; ++i)
            {
                double edgeCost = Util.CalculateEdgeValue(i - 1, i);
                edgeTo[i] = new Edge(edgeCost, i - 1, i);
            }
            double sum = 0;
            for (int i = 0; i < V; ++i)
            {
                sum += edgeTo[i].cost;
            }
  
        }
        public void GetClustsers()
        {

            for (int i = costs.Length - 1; i >= (costs.Length - (K - 1)); i--)
            {
                int destination = costs[i].to;
                edgeTo[destination].cost = -1;
            }
            for (int i = 0; i < edgeTo.Length; i++)
            {
                int start = i, end = i;
                int red = 0;
                int green = 0;
                int blue = 0;
                int NumberOfNodes = 1;
                do
                {
                    RGBPixel RGBValue = Util.GetRGBPixel(ImageQuantizer.distinctColors[i]);
                    red += Convert.ToInt32(RGBValue.red);
                    green += Convert.ToInt32(RGBValue.green);
                    blue += Convert.ToInt32(RGBValue.blue);
                    i++;
                    NumberOfNodes++;
                    end++;
                } while (i < edgeTo.Length && edgeTo[i].cost != -1);
                i--;
                NumberOfNodes--;
                end--;
                for (int j = start; j <= end; j++)
                    Palette.Add(ImageQuantizer.distinctColors[j], new RGBPixel((byte)(red / NumberOfNodes), (byte)(green / NumberOfNodes), (byte)(blue / NumberOfNodes)));
            }
        }
    }
}

