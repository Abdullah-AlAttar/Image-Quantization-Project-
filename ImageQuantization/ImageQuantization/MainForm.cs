using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageQuantization
{
    public partial class MainForm : Form
    {
        ImageQuantizer imageQuantizer;
        public static int K;
        public static bool reduceColors;
        public static double mstVal;
        public MainForm()
        {
          
            InitializeComponent();
            // FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            WhiteDistButton.Enabled = false;
            MstQtButton.Enabled = false;
            ClustersNumber.Enabled = false;
        }

        RGBPixel[,] ImageMatrix;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            distColorsBox1.Text = "";
            distinctColorsBox2.Text = "";
            ClustersNumber.Text = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
             
                string OpenedFilePath = openFileDialog1.FileName;
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImageMatrix, pictureBox1);
                WhiteDistButton.Enabled = true;
                MstQtButton.Enabled = true;
                ClustersNumber.Enabled = true;
               
            }
            else
            {
                MessageBox.Show("please open an Image");
                return;
            }
            txtWidth.Text = ImageOperations.GetWidth(ImageMatrix).ToString();
            txtHeight.Text = ImageOperations.GetHeight(ImageMatrix).ToString();

            distColorsBox1.Text = CalculateOriginalDistinctColors(ImageOperations.GetHeight(ImageMatrix), ImageOperations.GetWidth(ImageMatrix)).ToString();
        }
        private int CalculateOriginalDistinctColors(int height,int width)
        {

            HashSet<int> hashDistinctColors = new HashSet<int>();
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    RGBPixel pix = ImageMatrix[i, j];
                    int rgbValue = Util.GetRGBInteger(pix.red, pix.green, pix.blue);
                    if (!hashDistinctColors.Contains(rgbValue))
                        hashDistinctColors.Add(rgbValue);
                }
            }
            return hashDistinctColors.Count;
        }
        private void MstQtButton_Click(object sender, EventArgs e)
        {
            reduceColors = ReduceColorsBox.Checked;
           
            if (ClustersNumber.Text.ToString().Length > 0)
            {
                K = int.Parse(ClustersNumber.Text);
                imageQuantizer = new ImageQuantizer(ImageMatrix);
                imageQuantizer.MstQuantiztion();
                distinctColorsBox2.Text = imageQuantizer.distinctColorsCount.ToString();
                ImageOperations.DisplayImage(imageQuantizer.quantizedImageMatrix, pictureBox2);

                MstBox.Text = mstVal.ToString();
            }
            else
            {
                
                imageQuantizer = new ImageQuantizer(ImageMatrix);
                imageQuantizer.MstQuantiztionWithAutoKdetection();
                distinctColorsBox2.Text = imageQuantizer.distinctColorsCount.ToString();
                ImageOperations.DisplayImage(imageQuantizer.quantizedImageMatrix, pictureBox2);
                MstBox.Text = mstVal.ToString();
                ClustersNumber.Text = K.ToString();
            }
            
        }

        private void WhiteDistButton_Click(object sender, EventArgs e)
        {
            reduceColors = ReduceColorsBox.Checked;
           
            if (ClustersNumber.Text.ToString().Length > 0)
            {
                K = int.Parse(ClustersNumber.Text);
                imageQuantizer = new ImageQuantizer(ImageMatrix);
                imageQuantizer.WhiteDistanceQuantiztion();
                distinctColorsBox2.Text = imageQuantizer.distinctColorsCount.ToString();
                ImageOperations.DisplayImage(imageQuantizer.quantizedImageMatrix, pictureBox2);
            }
            else
            {
                MessageBox.Show("Please enter the required number of clusters.");
            }
            MstBox.Text = "" ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}