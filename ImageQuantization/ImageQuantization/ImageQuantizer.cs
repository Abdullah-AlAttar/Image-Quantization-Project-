using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace ImageQuantization
{

    /// <summary>
    /// Controls the flow of the program,,everything happens here
    /// </summary>
    class ImageQuantizer
    {
        public int distinctColorsCount { set;  get; }
        HashSet<int> hashDistinctColors;
        public RGBPixel[,] quantizedImageMatrix;
        List<List<KeyValuePair<int, double>>> MstGraph;
        public static List<int> distinctColors;
        private List<KeyValuePair<int, int>> distanceFromWhite;
        int height, width;
        public ImageQuantizer(RGBPixel[,] imageMatrix)
        {
            hashDistinctColors = new HashSet<int>();
            distanceFromWhite = new List<KeyValuePair<int, int>>();
            MstGraph = new List<List<KeyValuePair<int, double>>>();
            distinctColors = new List<int>();
            height = ImageOperations.GetHeight(imageMatrix);
            width = ImageOperations.GetWidth(imageMatrix);
            quantizedImageMatrix = new RGBPixel[height, width];
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    RGBPixel pix = imageMatrix[i, j];
                    quantizedImageMatrix[i, j] = new RGBPixel(pix.red, pix.green, pix.blue);
                }
            }

        }
        private void MapColorsIntoListWithSorting()
        {
            foreach (var color in hashDistinctColors)
            {
                distanceFromWhite.Add(new KeyValuePair<int, int>(Util.CalculateDistanceFromWhiteColor(color), color));
            }
            distanceFromWhite.Sort((x, y) => x.Key.CompareTo(y.Key));
            for (int i = 0; i < distanceFromWhite.Count; ++i)
            {
                distinctColors.Add(distanceFromWhite[i].Value);
            }
           
        }
        private void MapColorsIntoList()
        {
            foreach (var color in hashDistinctColors)
            {
                distinctColors.Add(color);
            }
        }
        private void CalcDistColorsWithApproximation()
        {
            
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if (MainForm.reduceColors)
                    {
                        quantizedImageMatrix[i, j].red /= 10;
                        quantizedImageMatrix[i, j].red *= 10;
                        quantizedImageMatrix[i, j].red += 5;
                        quantizedImageMatrix[i, j].blue /= 10;
                        quantizedImageMatrix[i, j].blue *= 10;
                        quantizedImageMatrix[i, j].blue += 5;
                        quantizedImageMatrix[i, j].green /= 10;
                        quantizedImageMatrix[i, j].green *= 10;
                        quantizedImageMatrix[i, j].green += 5;
                    }
                    RGBPixel pix = quantizedImageMatrix[i, j];
                    int rgbValue = Util.GetRGBInteger(pix.red, pix.green, pix.blue);
                    if (!hashDistinctColors.Contains(rgbValue))
                        hashDistinctColors.Add(rgbValue);
                }
            }
            ImageOperations.SaveImage(quantizedImageMatrix);
        }
        public void MstQuantiztion()
        {
            CalcDistColorsWithApproximation();
            MapColorsIntoList();
            distinctColorsCount = distinctColors.Count;
            MstPrimEager mstPrim = new MstPrimEager(distinctColors.Count);
            mstPrim.GetMst();
            if(MainForm.K>mstPrim.edgeTo.Count())
            {
                MessageBox.Show("The K you provided is too high please choose a lower one");
                return;
            }
            MstClustring Clusters = new MstClustring(MainForm.K, mstPrim.edgeTo);
            Clusters.GetClusters();

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    quantizedImageMatrix[i, j] = Clusters.Palette[Util.GetRGBInteger(quantizedImageMatrix[i, j].red, quantizedImageMatrix[i, j].green, quantizedImageMatrix[i, j].blue)];
                }
            }
        }
        public void MstQuantiztionWithAutoKdetection()
        {
            CalcDistColorsWithApproximation();
            MapColorsIntoList();
            distinctColorsCount = distinctColors.Count;
            MstPrimEager mstPrim = new MstPrimEager(distinctColors.Count);
            mstPrim.GetMst();

            AutoKdetection autoKdetection = new AutoKdetection(mstPrim.edgeTo);
            MstClustring Clusters = new MstClustring(autoKdetection.K, mstPrim.edgeTo);
            Clusters.GetClusters();
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    quantizedImageMatrix[i, j] = Clusters.Palette[Util.GetRGBInteger(quantizedImageMatrix[i, j].red, quantizedImageMatrix[i, j].green, quantizedImageMatrix[i, j].blue)];
                }
            }
            MainForm.K = autoKdetection.K;
        }
        public void WhiteDistanceQuantiztion()
        {
            CalcDistColorsWithApproximation();
            MapColorsIntoListWithSorting();
            distinctColorsCount = distinctColors.Count;
            if (MainForm.K >distinctColorsCount)
            {
                MessageBox.Show("The K you provided is too high please choose a lower one");
                return;
            }
            SortedColorsClustring Clusters = new SortedColorsClustring(MainForm.K, distinctColors.Count);
            Clusters.GetClustsers();
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    quantizedImageMatrix[i, j] = Clusters.Palette[Util.GetRGBInteger(quantizedImageMatrix[i, j].red, quantizedImageMatrix[i, j].green, quantizedImageMatrix[i, j].blue)];
                }
            }
        }
    
    }
}
