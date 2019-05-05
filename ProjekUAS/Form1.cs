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
    public partial class Form1 : Form
    {
        MDIParent1 parent;
        Bitmap image1, image2;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(MDIParent1 parent, Bitmap image1)
        {
            InitializeComponent();
            this.image1 = image1;
            this.image2 = image1;
            red();
            green();
            blue();
        }

        public void red() 
        {
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
            for (int y = 0; y < image1.Height; y++)
            {
                Color w = image1.GetPixel(x, y);
                int r = w.R;
                Color wr = Color.FromArgb(r, 0, 0);
                image2.SetPixel(x, y, wr);
            }
            pictureBox1.Image = image2;
        }

        public void green()
        {
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int g = w.G;
                    Color wg = Color.FromArgb(0, g, 0);
                    image2.SetPixel(x, y, wg);
                }
            pictureBox2.Image = image2;
        }

        public void blue()
        {
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int b = w.B;
                    Color wb = Color.FromArgb(0, 0, b);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox3.Image = image2;
        }

        public void grayscaleRed()
        {
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = w.R;
                    Color wr = Color.FromArgb(r, r, r);
                    image2.SetPixel(x, y, wr);
                }
            pictureBox1.Image = image2;
        }

        public void grayscaleGreen()
        {
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int g = w.G;
                    Color wg = Color.FromArgb(g, g, g);
                    image2.SetPixel(x, y, wg);
                }
            pictureBox2.Image = image2;
        }

        public void grayscaleBlue()
        {
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int b = w.B;
                    Color wb = Color.FromArgb(b, b, b);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox3.Image = image2;
        }

        private void rGBLayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            red();
            green();
            blue();
        }

        private void rGBGreyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grayscaleRed();
            grayscaleGreen();
            grayscaleBlue();
        }

    }
}
