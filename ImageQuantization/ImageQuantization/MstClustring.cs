using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageQuantization
{
    class MstClustring
    { 
        int K;
        Edge[] edgeTo;
        Edge[] costs;
        int[] visited;
        List<List<int>> adj;
    
        public Dictionary<int, RGBPixel> Palette;
        public MstClustring(int K, Edge[] mst)
        {
            this.visited = new int[mst.Length];
            this.K = K;
            this.edgeTo = mst;
            costs = mst;
          //  Array.Sort(costs);
            this.costs = mst.OrderBy(node => node.cost).ToArray();
            adj = new List<List<int>>();
            for (int i = 0; i < edgeTo.Length; i++) adj.Add( new List<int>());
            Palette = new Dictionary<int, RGBPixel>();
            
        }

        public void GetClusters()
        {
            for (int i = 0; i < edgeTo.Length; ++i)
            {
                adj[edgeTo[i].from].Add(edgeTo[i].to );
                adj[edgeTo[i].to].Add(edgeTo[i].from);
            }
     
                for (int i = costs.Length - 1; i >= (costs.Length - (K - 1)); i--)
                {
                    int destination = costs[i].to;
                    edgeTo[destination].cost = -1;
                }
            
            for (int i = 0; i < edgeTo.Length; i++)
            {
                if (visited[i] == 1) continue;
                int red = 0, green = 0, blue = 0 ;
                List<int> ClusterNodes = new List<int>();
                int NumberOfNodes = ColorPalette(i, ref red, ref green, ref blue ,ref ClusterNodes) + 1;
                for (int j = 0; j < ClusterNodes.Count; j++)
                    Palette.Add(ImageQuantizer.distinctColors[ClusterNodes[j]],new RGBPixel((byte)(red / NumberOfNodes), (byte)(green / NumberOfNodes), (byte)(blue / NumberOfNodes)));
            }
        }

        public int ColorPalette(int node, ref int red, ref int green, ref int blue, ref List<int> ClusterNodes)
        {
            RGBPixel RGBValue = Util.GetRGBPixel(ImageQuantizer.distinctColors[node]);
            red += Convert.ToInt32(RGBValue.red);
            green += Convert.ToInt32(RGBValue.green);
            blue += Convert.ToInt32(RGBValue.blue);
            ClusterNodes.Add(node);
            visited[node] = 1;
            int ans = 0;
            for (int i = 0; i < adj[node].Count; i++)
            {
                int v = adj[node][i];

                 if (edgeTo[node].from == v && edgeTo[node].cost == -1 || edgeTo[v].from == node && edgeTo[v].cost == -1) continue;
           
                if (visited[v] == 0)
                {
                    ans += 1 + ColorPalette(adj[node][i], ref red, ref green, ref blue, ref ClusterNodes);
                }
            }
            return ans;
        }
    }
}
