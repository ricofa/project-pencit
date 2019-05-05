using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjekUAS
{
    public partial class Form5 : Form
    {
        MDIParent1 parent;
        Bitmap image1, image2;

        public Form5()
        {
            InitializeComponent();
        }

        public Form5(MDIParent1 parent, Bitmap image1)
        {
            InitializeComponent();
            this.parent = parent;
            this.image1 = image1;
            this.image2 = image1;
            setDefaultImage();
        }

        public void setDefaultImage()
        {
            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    Color wb = Color.FromArgb(xg, xg, xg);
                    image1.SetPixel(x, y, wb);
                }
            pictureBox1.Image = image1;

            float[] h = new float[256];
            int i;
            for (i = 0; i < 256; i++) h[i] = 0;
            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
                    h[xg] = h[xg] + 1;
                }
            for (i = 0; i < 256; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, h[i]);
            }
        }

        private void equalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            float[] h = new float[256];
            float[] c = new float[256];
            int i;

            for (i = 0; i < 256; i++) h[i] = 0;
            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
                    h[xg] = h[xg] + 1;
                }
            c[0] = h[0];
            for (i = 1; i < 256; i++) c[i] = c[i - 1] + h[i];
            int nx = image1.Width;
            int ny = image1.Height;
            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(255 * c[xg] / nx / ny);
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;

            float[] j = new float[256];
            int k;
            for (k = 0; k < 256; k++) j[k] = 0;
            for (int p = 0; p < image2.Width; p++)
                for (int q = 0; q < image2.Height; q++)
                {
                    Color w = image2.GetPixel(p, q);
                    int xg = w.R;
                    j[xg] = j[xg] + 1;
                }
            for (k = 0; k < 256; k++)
            {
                chart2.Series["Series1"].Points.AddXY(k, j[k]);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.setImage(image2);
            this.Close();
        }
    }
}
