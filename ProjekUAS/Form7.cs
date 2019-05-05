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
    public partial class Form7 : Form
    {
        MDIParent1 parent;
        Bitmap image1, image2;
        int noise;

        public Form7()
        {
            InitializeComponent();
        }

        public Form7(MDIParent1 parent, Bitmap image1)
        {
            InitializeComponent();
            this.parent = parent;
            this.image1 = image1;
            this.image2 = image1;
            pictureBox1.Image = image1;
        }

        private void gaussianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void speckleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saltAndPepperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void averageFilterToolStripMenuItem_Click(object sender, EventArgs e)
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
                    int xb = (int)((x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9) / 9);
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void gaussianFilterToolStripMenuItem_Click(object sender, EventArgs e)
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
                    int xb = (int)((x1 + x2 + x3 + x4 + 4 * x5 + x6
                    + x7 + x8 + x9) / 13);
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] xt = new int[10];
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
                    xt[1] = w1.R;
                    xt[2] = w2.R;
                    xt[3] = w3.R;
                    xt[4] = w4.R;
                    xt[5] = w5.R;
                    xt[6] = w6.R;
                    xt[7] = w7.R;
                    xt[8] = w8.R;
                    xt[9] = w9.R;
                    for (int i = 1; i < 9; i++)
                        for (int j = 1; j < 9; j++)
                        {
                            if (xt[j] > xt[j + 1])
                            {
                                int a = xt[j];
                                xt[j] = xt[j + 1];
                                xt[j + 1] = a;
                            }
                        }
                    int xb = xt[5];
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int rata2 = (r + g + b) / 3;
                    Color wr = Color.FromArgb(rata2, rata2, rata2);
                    image2.SetPixel(x, y, wr);
                }
            pictureBox1.Image = image2;
        }

        private void oKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Equals("")) noise = 20;
            else noise = int.Parse(toolStripTextBox1.Text);
            image2 = new Bitmap(image1);
            Random r = new Random();

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
                    int xb = xg;
                    int nr = r.Next(0, 100);
                    if (nr < noise)
                    {
                        int ns = r.Next(0, 256) - 128;
                        xb = (int)(xg + ns);
                        if (xb < 0) xb = -xb;
                        if (xb > 255) xb = 255;
                    }
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox1.Image = image2;
        }

        private void oKToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text.Equals("")) noise = 20;
            else noise = int.Parse(toolStripTextBox2.Text);
            image2 = new Bitmap(image1);
            Random r = new Random();

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
                    int xb = xg;
                    int nr = r.Next(0, 100);
                    if (nr < noise) xb = 0;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox1.Image = image2;
        }

        private void oKToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox3.Text.Equals("")) noise = 20;
            else noise = int.Parse(toolStripTextBox3.Text);
            image2 = new Bitmap(image1);
            Random r = new Random();

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
                    int xb = xg;
                    int nr = r.Next(0, 100);
                    if (nr < noise) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox1.Image = image2;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.setImage(image2);
            this.Close();
        }
    }
}
