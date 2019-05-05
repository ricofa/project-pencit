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
    public partial class Form9 : Form
    {
        MDIParent1 parent;
        Bitmap image1, image2;

        public Form9()
        {
            InitializeComponent();
        }

        public Form9(MDIParent1 parent, Bitmap image1)
        {
            InitializeComponent();
            this.parent = parent;
            this.image1 = image1;
            this.image2 = image1;
            pictureBox1.Image = image1;
        }

        private void noiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            Random r = new Random();
            Color wb;

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    int p = r.Next(0, 100);
                    Color w = image1.GetPixel(x, y);
                    wb = w;
                    if (p < 20)
                    {
                        int nr = r.Next(0, 200);
                        int rb = w.R + nr - 100;
                        if (rb < 0) rb = 0;
                        if (rb > 255) rb = 255;
                        int gb = w.G + nr - 100;
                        if (gb < 0) gb = 0;
                        if (gb > 255) gb = 255;
                        int bb = w.B + nr - 100;
                        if (bb < 0) bb = 0;
                        if (bb > 255) bb = 255;
                        wb = Color.FromArgb(rb, gb, bb);
                    }
                    image2.SetPixel(x, y, wb);
                }
            pictureBox1.Image = image2;
        }

        private void averageFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            
            for (int x = 1; x < image1.Width-1; x++)
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
                    int r = (int)((w1.R + w2.R + w3.R + w4.R + w5.R + w6.R + w7.R + w8.R + w9.R) / 9);
                    int g = (int)((w1.G + w2.G + w3.G + w4.G + w5.G + w6.G + w7.G + w8.G + w9.G) / 9);
                    int b = (int)((w1.B + w2.B + w3.B + w4.B + w5.B + w6.B + w7.B + w8.B + w9.B) / 9);
                    Color wb = Color.FromArgb(r, g, b);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void edgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
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
                    int rh = (int)(-w1.R - w4.R - w7.R + w3.R + w6.R + w9.R);
                    int gh = (int)(-w1.G - w4.G - w7.G + w3.G + w6.G + w9.G);
                    int bh = (int)(-w1.B - w4.B - w7.B + w3.B + w6.B + w9.B);
                    int rv = (int)(-w1.R - w2.R - w3.R + w7.R + w8.R + w9.R);
                    int gv = (int)(-w1.G - w2.G - w3.G + w7.G + w8.G + w9.G);
                    int bv = (int)(-w1.B - w2.B - w3.B + w7.B + w8.B + w9.B);
                    int r = (int)(rh + rv);
                    if (r < 0) r = -r;
                    if (r > 255) r = 255;
                    int g = (int)(gh + gv);
                    if (g < 0) g = -g;
                    if (g > 255) g = 255;
                    int b = (int)(bh + bv);
                    if (b < 0) b = -b;
                    if (b > 255) b = 255;
                    Color wb = Color.FromArgb(r, g, b);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void sharpnessToolStripMenuItem_Click(object sender, EventArgs e)
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
                    int rh = (int)(-w1.R - w4.R - w7.R + w3.R + w6.R + w9.R);
                    int gh = (int)(-w1.G - w4.G - w7.G + w3.G + w6.G + w9.G);
                    int bh = (int)(-w1.B - w4.B - w7.B + w3.B + w6.B + w9.B);
                    int rv = (int)(-w1.R - w2.R - w3.R + w7.R + w8.R + w9.R);
                    int gv = (int)(-w1.G - w2.G - w3.G + w7.G + w8.G + w9.G);
                    int bv = (int)(-w1.B - w2.B - w3.B + w7.B + w8.B + w9.B);
                    int rr = (int)((w1.R + w2.R + w3.R + w4.R + w5.R + w6.R + w7.R + w8.R + w9.R) / 9);
                    int gr = (int)((w1.G + w2.G + w3.G + w4.G + w5.G + w6.G + w7.G + w8.G + w9.G) / 9);
                    int br = (int)((w1.B + w2.B + w3.B + w4.B + w5.B + w6.B + w7.B + w8.B + w9.B) / 9);
                    int r = (int)(rr + rh + rv);
                    if (r < 0) r = -r;
                    if (r > 255) r = 255;
                    int g = (int)(gr + gh + gv);
                    if (g < 0) g = -g;
                    if (g > 255) g = 255;
                    int b = (int)(br + bh + bv);
                    if (b < 0) b = -b;
                    if (b > 255) b = 255;
                    Color wb = Color.FromArgb(r, g, b);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.setImage(image2);
            this.Close();
        }
    }
}
