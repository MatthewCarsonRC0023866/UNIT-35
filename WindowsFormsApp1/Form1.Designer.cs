﻿using System;
using System.ComponentModel;

namespace WindowsFormsApp1
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savePNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rateOfChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.altitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.graphToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveCSVToolStripMenuItem,
            this.savePNGToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveCSVToolStripMenuItem
			// 
			this.saveCSVToolStripMenuItem.Name = "saveCSVToolStripMenuItem";
			this.saveCSVToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.saveCSVToolStripMenuItem.Text = "Save CSV";
			this.saveCSVToolStripMenuItem.Click += new System.EventHandler(this.saveCSVToolStripMenuItem_Click);
			// 
			// savePNGToolStripMenuItem
			// 
			this.savePNGToolStripMenuItem.Name = "savePNGToolStripMenuItem";
			this.savePNGToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.savePNGToolStripMenuItem.Text = "Save PNG";
			this.savePNGToolStripMenuItem.Click += new System.EventHandler(this.savePNGToolStripMenuItem_Click);
			// 
			// graphToolStripMenuItem
			// 
			this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentToolStripMenuItem,
            this.rateOfChangeToolStripMenuItem,
            this.altitudeToolStripMenuItem});
			this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
			this.graphToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.graphToolStripMenuItem.Text = "Graph";
			// 
			// currentToolStripMenuItem
			// 
			this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
			this.currentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.currentToolStripMenuItem.Text = "Velocity";
			this.currentToolStripMenuItem.Click += new System.EventHandler(this.velocityToolStripMenuItem_Click);
			// 
			// rateOfChangeToolStripMenuItem
			// 
			this.rateOfChangeToolStripMenuItem.Name = "rateOfChangeToolStripMenuItem";
			this.rateOfChangeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.rateOfChangeToolStripMenuItem.Text = "Altitude";
			this.rateOfChangeToolStripMenuItem.Click += new System.EventHandler(this.rateOfChangeToolStripMenuItem_Click);
			// 
			// altitudeToolStripMenuItem
			// 
			this.altitudeToolStripMenuItem.Name = "altitudeToolStripMenuItem";
			this.altitudeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.altitudeToolStripMenuItem.Text = "Aceleration";
			this.altitudeToolStripMenuItem.Click += new System.EventHandler(this.altitudeToolStripMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(40, 45);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(562, 377);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
//			throw new NotImplementedException();
		}

		private void chargeToolStripMenuItem_Click(object sender, EventArgs e)
		{
//			throw new NotImplementedException();
		}

		private void chart1_Click(object sender, EventArgs e)
		{
//			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rateOfChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePNGToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.ToolStripMenuItem altitudeToolStripMenuItem;
	}
}

