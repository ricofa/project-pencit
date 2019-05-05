namespace ProjekUAS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.oKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.oKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(13, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(363, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 333);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyscaleToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.inversToolStripMenuItem,
            this.autoLevelToolStripMenuItem});
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.oKToolStripMenuItem});
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // oKToolStripMenuItem
            // 
            this.oKToolStripMenuItem.Name = "oKToolStripMenuItem";
            this.oKToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.oKToolStripMenuItem.Text = "OK";
            this.oKToolStripMenuItem.Click += new System.EventHandler(this.oKToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.oKToolStripMenuItem1});
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.contrastToolStripMenuItem.Text = "Contrast";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // oKToolStripMenuItem1
            // 
            this.oKToolStripMenuItem1.Name = "oKToolStripMenuItem1";
            this.oKToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.oKToolStripMenuItem1.Text = "OK";
            this.oKToolStripMenuItem1.Click += new System.EventHandler(this.oKToolStripMenuItem1_Click);
            // 
            // inversToolStripMenuItem
            // 
            this.inversToolStripMenuItem.Name = "inversToolStripMenuItem";
            this.inversToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.inversToolStripMenuItem.Text = "Invers";
            this.inversToolStripMenuItem.Click += new System.EventHandler(this.inversToolStripMenuItem_Click);
            // 
            // autoLevelToolStripMenuItem
            // 
            this.autoLevelToolStripMenuItem.Name = "autoLevelToolStripMenuItem";
            this.autoLevelToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.autoLevelToolStripMenuItem.Text = "Auto Level";
            this.autoLevelToolStripMenuItem.Click += new System.EventHandler(this.autoLevelToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robertToolStripMenuItem,
            this.prewittToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.laplacianToolStripMenuItem});
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            // 
            // robertToolStripMenuItem
            // 
            this.robertToolStripMenuItem.Name = "robertToolStripMenuItem";
            this.robertToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.robertToolStripMenuItem.Text = "Robert";
            this.robertToolStripMenuItem.Click += new System.EventHandler(this.robertToolStripMenuItem_Click);
            // 
            // prewittToolStripMenuItem
            // 
            this.prewittToolStripMenuItem.Name = "prewittToolStripMenuItem";
            this.prewittToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.prewittToolStripMenuItem.Text = "Prewitt";
            this.prewittToolStripMenuItem.Click += new System.EventHandler(this.prewittToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(701, 458);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewittToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}