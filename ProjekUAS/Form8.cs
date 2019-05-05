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
    public partial class Form8 : Form
    {
        MDIParent1 parent;
        Bitmap image1, image2;

        public Form8()
        {
            InitializeComponent();
        }

        public Form8(MDIParent1 parent, Bitmap image1)
        {
            InitializeComponent();
            this.parent = parent;
            this.image1 = image1;
            this.image2 = image1;
            pictureBox1.Image = image1;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float brightness = 0;
            trackBar1.SetRange(-100, 100);
            brightness = (trackBar1.Value);
            textBox1.Text = brightness.ToString();
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = (int)(w.R + brightness);
                    int g = (int)(w.G + brightness);
                    int b = (int)(w.B + brightness);
                    if (r < 0) r = 0;
                    if (r > 255) r = 255;
                    if (g < 0) g = 0;
                    if (g > 255) g = 255;
                    if (b < 0) b = 0;
                    if (b > 255) b = 255;
                    Color wb = Color.FromArgb(r, g, b);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            float contrast = 0;
            trackBar2.SetRange(10, 200);
            contrast = (trackBar2.Value) / 10;
            textBox2.Text = contrast.ToString();
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = (int)(contrast * (float)w.R);
                    int g = (int)(contrast * (float)w.G);
                    int b = (int)(contrast * (float)w.B);
                    if (r < 0) r = 0;
                    if (r > 255) r = 255;
                    if (g < 0) g = 0;
                    if (g > 255) g = 255;
                    if (b < 0) b = 0;
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

        private void inversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = (int)(255 - w.R);
                    int g = (int)(255 - w.G);
                    int b = (int)(255 - w.B);
                    Color wb = Color.FromArgb(r, g, b);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void autoLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            int rmin = 255;
            int gmin = 255;
            int bmin = 255;
            int rmax = 0;
            int gmax = 0;
            int bmax = 0;

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    if (r < rmin) rmin = r;
                    if (r > rmax) rmax = r;
                    if (g < gmin) gmin = g;
                    if (g > gmax) gmax = g;
                    if (b < bmin) bmin = b;
                    if (b > bmax) bmax = b;
                }
            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int rbaru = (int)(255 * (r - rmin) / (rmax -
                    rmin));
                    int gbaru = (int)(255 * (g - gmin) / (gmax -
                    gmin));
                    int bbaru = (int)(255 * (b - bmin) / (bmax -
                    bmin));
                    Color wb = Color.FromArgb(rbaru, gbaru, bbaru);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }
    }
}
