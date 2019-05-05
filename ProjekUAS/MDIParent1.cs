using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ProjekUAS
{
    public partial class MDIParent1 : Form
    {
        Bitmap image1, image2;

        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                image1 = new Bitmap(openFileDialog1.FileName);
                image2 = image1;
                pictureBox1.Image = image1;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = saveFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                image2.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flipVertikalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    image2.SetPixel(x, image1.Height - 1 - y, w);
                }
            pictureBox2.Image = image2;
            this.image1 = image2;
        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);

            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    image2.SetPixel(x, y, w);
                }
            pictureBox2.Image = image2;
            this.image1 = image2;
        }

        private void flipHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    image2.SetPixel(image1.Width - 1 - x, y, w);
                }
            pictureBox2.Image = image2;
            this.image1 = image2;
        }

        private void rotate90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            image2.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Image = image2;
            this.image1 = image2;
        }

        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            image2.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox2.Image = image2;
            this.image1 = image2;
        }

        private void copyRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    Color wb = Color.FromArgb(r, g, b);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
            this.image1 = image2;
        }

        private void grayscaleToolStripMenuItem1_Click(object sender, EventArgs e)
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
            pictureBox2.Image = image2;
            this.image1 = image2;
        }

        private void rGBLayersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var layerRGB = new Form1(this,image1);
            layerRGB.Show();
        }

        private void sephiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            for (int x = 0; x < image1.Width; x++)
                for (int y = 0; y < image1.Height; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;

                    int wr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    if (wr > 255)
                    {
                        wr = 255;
                    }
                    int wg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    if (wg > 255)
                    {
                        wg = 255;
                    }
                    int wb = (int)(0.272 * r + 0.534 * g + 0.131 * b);
                    if (wb > 255)
                    {
                        wb = 255;
                    }
                    Color w2 = Color.FromArgb(wr, wg, wb);
                    image2.SetPixel(x, y, w2);
                }
            pictureBox2.Image = image2;
            this.image1 = image2;
        }

        private void quantizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var kuantisasi = new Form2(this, image1);
            kuantisasi.Show();
        }

        public void setImage(Bitmap image2)
        {
            this.image2 = image2;
            pictureBox2.Image = image2;
        }

        private void adjustmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void grayLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var histogram = new Form4(image1);
            histogram.Show();
        }

        private void ekualisasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ekualisasi = new Form5(this, image1);
            ekualisasi.Show();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void noiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var noise = new Form7(this, image1);
            noise.Show();
        }

        private void sharpnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = new Bitmap(image1);
            for (int x = 1; x < image1.Width - 1; x++)
                for (int y = 1; y < image1.Height - 1; y++)
                {
                    Color w = image1.GetPixel(x, y);
                    int xg = w.R;
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
                    int xt1 = (int)((x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9) / 9);
                    int xt2 = (int)(-x1 - 2 * x2 - x3 + x7 + 2 * x8 + x9);
                    int xt3 = (int)(-x1 - 2 * x4 - x7 + x3 + 2 * x6 + x9);
                    int xb = (int)(xt1 + xt2 + xt3);
                    if (xb < 0) xb = -xb;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    image2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = image2;
            this.image1 = image2;
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adjustment = new Form3(this, image1);
            adjustment.Show();
        }

        private void rGBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var berwarna = new Form8(this,image1);
            berwarna.Show();
        }

        private void greyscaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var filtering = new Form6(this, image1);
            filtering.Show();
        }

        private void rGBToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var filterRGB = new Form9(this,image1);
            filterRGB.Show();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            image1 = image2;
            pictureBox1.Image = image1;
        }
    }
}
