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
    public partial class Form2 : Form
    {
        MDIParent1 parent;
        Bitmap image1, image2;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(MDIParent1 parent, Bitmap image1)
        {
            InitializeComponent();
            this.parent = parent;
            this.image1 = image1;
            this.image2 = image1;
            pictureBox1.Image = image1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void blackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    int xbw = 0;
                    if (xg >= 128) xbw = 255;
                    Color wb = Color.FromArgb(xbw, xbw, xbw);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void oKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            int kuantisasi;
            if (toolStripTextBox1.Text.Equals("")) kuantisasi = 0;
            else kuantisasi = int.Parse(toolStripTextBox1.Text);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    Color wb = Color.FromArgb(xg, xg, xg);
                    if (kuantisasi != 0)
                    {
                        int xk = kuantisasi * (int)(xg / kuantisasi);
                        wb = Color.FromArgb(xk, xk, xk);
                    }
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
        }

        private void oKToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            int threshold;
            if (toolStripTextBox2.Text.Equals("")) threshold = 0;
            else threshold = int.Parse(toolStripTextBox2.Text);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    int xbw = 0;
                    if (xg >= threshold) xbw = 255;
                    Color wb = Color.FromArgb(xbw, xbw, xbw);
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
