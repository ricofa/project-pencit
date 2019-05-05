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
    public partial class Form3 : Form
    {
        MDIParent1 parent;
        Bitmap image1, image2;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(MDIParent1 parent, Bitmap image1)
        {
            InitializeComponent();
            this.parent = parent;
            this.image1 = image1;
            this.image2 = image1;
            pictureBox1.Image = image1;
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            int a;
            if (toolStripTextBox1.Text.Equals("")) a = 0;
            else  a = int.Parse(toolStripTextBox1.Text);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
                    int xb = xg + a;
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void oKToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            float c;
            if (toolStripTextBox2.Text.Equals("")) c = 0;
            else c = float.Parse(toolStripTextBox2.Text);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(c * xg);
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void inversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(255 - xg);
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void autoLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            //Mencari nilai maksimum dan minimum
            int xgmax = 0;
            int xgmin = 255;

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
                    if (xg < xgmin) xgmin = xg;
                    if (xg > xgmax) xgmax = xg;
                }
            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(255 * (xg - xgmin) / (xgmax - xgmin));
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void robertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            for (int x = 1; x < image1.Width; x++)
                for (int y = 1; y < image1.Height; y++)
                {
                    Color w1 = image1.GetPixel(x - 1, y);
                    Color w2 = image1.GetPixel(x, y);
                    Color w3 = image1.GetPixel(x, y - 1);
                    Color w4 = image1.GetPixel(x, y);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int xb = (int)((x2 - x1) + (x4 - x3));
                    if (xb < 0) xb = -xb;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void prewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            for (int x = 1; x < image1.Width-1; x++)
                for (int y = 1; y < image1.Height-1; y++)
                {
                    Color w1 = image1.GetPixel(x - 1, y-1);
                    Color w2 = image1.GetPixel(x - 1, y);
                    Color w3 = image1.GetPixel(x - 1, y + 1);
                    Color w4 = image1.GetPixel(x, y - 1);
                    Color w5 = image1.GetPixel(x, y);
                    Color w6 = image1.GetPixel(x, y + 1);
                    Color w7 = image1.GetPixel(x + 1, y - 1);
                    Color w8 = image1.GetPixel(x + 1, y);
                    Color w9 = image1.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R; 
                    int xh = (int)(-x1 - x4 - x7 + x3 + x6 + x9);
                    int xv = (int)(-x1 - x2 - x3 + x7 + x8 + x9);
                    int xb = (int)(xh + xv);
                    if (xb < 0) xb = -xb;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            for (int x = 1; x < image1.Width - 1; x++)
                for (int y = 1; y < image1.Height - 1; y++)
                {
                    Color w1 = image1.GetPixel(x - 1, y - 1);
                    Color w2 = image1.GetPixel(x - 1, y);
                    Color w3 = image1.GetPixel(x - 1, y + 1);
                    Color w4 = image1.GetPixel(x, y - 1);
                    Color w5 = image1.GetPixel(x, y);
                    Color w6 = image1.GetPixel(x, y + 1);
                    Color w7 = image1.GetPixel(x + 1, y - 1);
                    Color w8 = image1.GetPixel(x + 1, y);
                    Color w9 = image1.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xh = (int)(-x1 - 2 * x4 - x7 + x3 + 2 * x6 + x9);
                    int xv = (int)(-x1 - 2 * x2 - x3 + x7 + 2 * x8 + x9);
                    int xb = (int)(xh + xv);
                    if (xb < 0) xb = -xb;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            for (int x = 1; x < image1.Width - 1; x++)
                for (int y = 1; y < image1.Height - 1; y++)
                {
                    Color w1 = image1.GetPixel(x - 1, y - 1);
                    Color w2 = image1.GetPixel(x - 1, y);
                    Color w3 = image1.GetPixel(x - 1, y + 1);
                    Color w4 = image1.GetPixel(x, y - 1);
                    Color w5 = image1.GetPixel(x, y);
                    Color w6 = image1.GetPixel(x, y + 1);
                    Color w7 = image1.GetPixel(x + 1, y - 1);
                    Color w8 = image1.GetPixel(x + 1, y);
                    Color w9 = image1.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xb = (int)(x1 - 2 * x2 + x3 - 2 * x4 + 4 * x5 - 2 * x6 + x7 - 2 * x8 + x9);
                    if (xb < 0) xb = -xb;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.setImage(image2);
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
