namespace ProjekUAS
{
    partial class Form7
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.oKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speckleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.oKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saltAndPepperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.oKToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyscaleToolStripMenuItem,
            this.gaussianToolStripMenuItem,
            this.reductionToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);
            // 
            // gaussianToolStripMenuItem
            // 
            this.gaussianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussianToolStripMenuItem1,
            this.speckleToolStripMenuItem,
            this.saltAndPepperToolStripMenuItem});
            this.gaussianToolStripMenuItem.Name = "gaussianToolStripMenuItem";
            this.gaussianToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.gaussianToolStripMenuItem.Text = "Noise";
            // 
            // gaussianToolStripMenuItem1
            // 
            this.gaussianToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.oKToolStripMenuItem});
            this.gaussianToolStripMenuItem1.Name = "gaussianToolStripMenuItem1";
            this.gaussianToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.gaussianToolStripMenuItem1.Text = "Gaussian";
            this.gaussianToolStripMenuItem1.Click += new System.EventHandler(this.gaussianToolStripMenuItem1_Click);
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
            // speckleToolStripMenuItem
            // 
            this.speckleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.oKToolStripMenuItem1});
            this.speckleToolStripMenuItem.Name = "speckleToolStripMenuItem";
            this.speckleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.speckleToolStripMenuItem.Text = "Speckle";
            this.speckleToolStripMenuItem.Click += new System.EventHandler(this.speckleToolStripMenuItem_Click);
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
            // saltAndPepperToolStripMenuItem
            // 
            this.saltAndPepperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3,
            this.oKToolStripMenuItem2});
            this.saltAndPepperToolStripMenuItem.Name = "saltAndPepperToolStripMenuItem";
            this.saltAndPepperToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saltAndPepperToolStripMenuItem.Text = "Salt and Pepper";
            this.saltAndPepperToolStripMenuItem.Click += new System.EventHandler(this.saltAndPepperToolStripMenuItem_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            // 
            // oKToolStripMenuItem2
            // 
            this.oKToolStripMenuItem2.Name = "oKToolStripMenuItem2";
            this.oKToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.oKToolStripMenuItem2.Text = "OK";
            this.oKToolStripMenuItem2.Click += new System.EventHandler(this.oKToolStripMenuItem2_Click);
            // 
            // reductionToolStripMenuItem
            // 
            this.reductionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageFilterToolStripMenuItem,
            this.gaussianFilterToolStripMenuItem,
            this.medianFilterToolStripMenuItem});
            this.reductionToolStripMenuItem.Name = "reductionToolStripMenuItem";
            this.reductionToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.reductionToolStripMenuItem.Text = "Reduction";
            // 
            // averageFilterToolStripMenuItem
            // 
            this.averageFilterToolStripMenuItem.Name = "averageFilterToolStripMenuItem";
            this.averageFilterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.averageFilterToolStripMenuItem.Text = "Average Filter";
            this.averageFilterToolStripMenuItem.Click += new System.EventHandler(this.averageFilterToolStripMenuItem_Click);
            // 
            // gaussianFilterToolStripMenuItem
            // 
            this.gaussianFilterToolStripMenuItem.Name = "gaussianFilterToolStripMenuItem";
            this.gaussianFilterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gaussianFilterToolStripMenuItem.Text = "Gaussian Filter";
            this.gaussianFilterToolStripMenuItem.Click += new System.EventHandler(this.gaussianFilterToolStripMenuItem_Click);
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.medianFilterToolStripMenuItem.Text = "Median Filter";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(338, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 294);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(641, 381);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gaussianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem speckleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saltAndPepperToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem reductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}