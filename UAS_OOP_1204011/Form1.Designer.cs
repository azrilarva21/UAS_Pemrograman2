﻿namespace UAS_OOP_1204011
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mahasiswaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prodiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teskoneksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.teskoneksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mahasiswaToolStripMenuItem,
            this.prodiToolStripMenuItem});
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.inputToolStripMenuItem.Text = "Input";
            // 
            // mahasiswaToolStripMenuItem
            // 
            this.mahasiswaToolStripMenuItem.Name = "mahasiswaToolStripMenuItem";
            this.mahasiswaToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.mahasiswaToolStripMenuItem.Text = "Mahasiswa";
            this.mahasiswaToolStripMenuItem.Click += new System.EventHandler(this.mahasiswaToolStripMenuItem_Click);
            // 
            // prodiToolStripMenuItem
            // 
            this.prodiToolStripMenuItem.Name = "prodiToolStripMenuItem";
            this.prodiToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.prodiToolStripMenuItem.Text = "Prodi";
            this.prodiToolStripMenuItem.Click += new System.EventHandler(this.prodiToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mahasiswaToolStripMenuItem1,
            this.prodiToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(159, 29);
            this.viewToolStripMenuItem.Text = "View dan Update";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // mahasiswaToolStripMenuItem1
            // 
            this.mahasiswaToolStripMenuItem1.Name = "mahasiswaToolStripMenuItem1";
            this.mahasiswaToolStripMenuItem1.Size = new System.Drawing.Size(210, 30);
            this.mahasiswaToolStripMenuItem1.Text = "Mahasiswa";
            this.mahasiswaToolStripMenuItem1.Click += new System.EventHandler(this.mahasiswaToolStripMenuItem1_Click);
            // 
            // prodiToolStripMenuItem1
            // 
            this.prodiToolStripMenuItem1.Name = "prodiToolStripMenuItem1";
            this.prodiToolStripMenuItem1.Size = new System.Drawing.Size(210, 30);
            this.prodiToolStripMenuItem1.Text = "Prodi";
            this.prodiToolStripMenuItem1.Click += new System.EventHandler(this.prodiToolStripMenuItem1_Click);
            // 
            // teskoneksiToolStripMenuItem
            // 
            this.teskoneksiToolStripMenuItem.Name = "teskoneksiToolStripMenuItem";
            this.teskoneksiToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.teskoneksiToolStripMenuItem.Text = "teskoneksi";
            this.teskoneksiToolStripMenuItem.Click += new System.EventHandler(this.teskoneksiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 374);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mahasiswaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prodiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teskoneksiToolStripMenuItem;
    }
}

