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
    public partial class Form6 : Form
    {
        MDIParent1 parent;
        Bitmap image1, image2;

        public Form6()
        {
            InitializeComponent();
        }

        public Form6(MDIParent1 parent, Bitmap image1)
        {
            InitializeComponent();
            this.parent = parent;
            this.image1 = image1;
            this.image2 = image1;
            pictureBox1.Image = image1;
        }

        private void nodesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            float[] a = new float[5];
            a[1] = (float)0.2;
            a[2] = (float)0.2;
            a[3] = (float)0.2;
            a[4] = (float)0.2;
            a[0] = (float)0.2;
            image2 = new Bitmap(image1);

            for (int x = 1; x < image1.Width - 1; x++)
                for (int y = 1; y < image1.Height - 1; y++)
                {
                    Color w1 = image1.GetPixel(x - 1, y);
                    Color w2 = image1.GetPixel(x + 1, y);
                    Color w3 = image1.GetPixel(x, y - 1);
                    Color w4 = image1.GetPixel(x, y + 1);
                    Color w = image1.GetPixel(x, y);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int xg = w.R;
                    int xb = (int)(a[0] * xg);
                    xb = (int)(xb + a[1] * x1 + a[2] * x2 + a[3] * x3 + a[3] * x4);
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void nodesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            float[] a = new float[10];
            a[1] = (float)0.1;
            a[2] = (float)0.1;
            a[3] = (float)0.1;
            a[4] = (float)0.1;
            a[5] = (float)0.2;
            a[6] = (float)0.1;
            a[7] = (float)0.1;
            a[8] = (float)0.1;
            a[9] = (float)0.1;
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
                    int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
                    xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
                    xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void nodesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.setImage(image2);
            this.Close();
        }
    }
}
