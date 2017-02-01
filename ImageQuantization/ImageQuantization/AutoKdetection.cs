using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace ImageQuantization
{
    class AutoKdetection
    {

        public List<Edge> currentEdges { set; get; }
        Edge edgeLeadToMax;
        public double mean { set; get; }
        public double stdDev { set; get; }
        public double prevStdDev = 0;
        public double costLeadToMax = 0;
        public int K {set;get;}
        public AutoKdetection() { }
        public AutoKdetection(Edge[] edges)
        { 
            K = 0;
            currentEdges = edges.ToList();
            CalculateMean();
            CalcuateStdDev();
            while (Math.Abs(stdDev - prevStdDev) > .0001)
            {
                currentEdges.Remove(edgeLeadToMax);
                prevStdDev = stdDev;
                CalculateMean();
                CalcuateStdDev();
                ++K;
            }
            MessageBox.Show(K.ToString());
        }
   
        private void CalculateMean()
        {
            double sum = 0;
            foreach (Edge edge in currentEdges)
                sum += edge.cost;

            mean = sum / currentEdges.Count();
        }
        private void CalcuateStdDev()
        {
            double sum = 0;
            foreach (Edge edge in currentEdges)
            {
                if ((edge.cost - mean) * (edge.cost - mean) > costLeadToMax)
                {
                    costLeadToMax = (edge.cost - mean) * (edge.cost - mean);
                    edgeLeadToMax = edge;
                }
                sum += ((edge.cost - mean) * (edge.cost - mean));
            }
            costLeadToMax = 0;
            stdDev = sum / (currentEdges.Count() - 1);
            stdDev = Math.Sqrt(stdDev);
        }

    }
}