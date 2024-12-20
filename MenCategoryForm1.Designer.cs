﻿using System.Drawing;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    partial class MenCategoryForm1
    {
        private System.ComponentModel.IContainer components = null;

        private FlowLayoutPanel mainFlowLayoutPanel;
        private Label titleLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.AutoScroll = true;
            this.mainFlowLayoutPanel.Controls.Add(this.titleLabel);
            this.mainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(1024, 768);
            this.mainFlowLayoutPanel.TabIndex = 1;
            this.mainFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainFlowLayoutPanel_Paint);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.titleLabel.Location = new System.Drawing.Point(23, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(800, 76);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Men\'s Category";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenCategoryForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.MaximizeBox = false;
            this.Name = "MenCategoryForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Men\'s Category";
            this.mainFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
