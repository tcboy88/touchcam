﻿namespace TouchCam
{
    partial class LocationAndGestureDataCollectionTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationAndGestureDataCollectionTool));
            this.OrientationLabel = new System.Windows.Forms.Label();
            this.FineProbabilityLabel = new System.Windows.Forms.Label();
            this.CoarseProbabilityLabel = new System.Windows.Forms.Label();
            this.FinePredictionLabel = new System.Windows.Forms.Label();
            this.TouchStatusLabel = new System.Windows.Forms.Label();
            this.CoarsePredictionLabel = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrainingLabel = new System.Windows.Forms.Label();
            this.loggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrientationLabel
            // 
            this.OrientationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrientationLabel.Location = new System.Drawing.Point(3, 49);
            this.OrientationLabel.Name = "OrientationLabel";
            this.OrientationLabel.Size = new System.Drawing.Size(181, 36);
            this.OrientationLabel.TabIndex = 19;
            this.OrientationLabel.Text = "Orientation";
            this.OrientationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FineProbabilityLabel
            // 
            this.FineProbabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FineProbabilityLabel.Location = new System.Drawing.Point(762, 49);
            this.FineProbabilityLabel.Name = "FineProbabilityLabel";
            this.FineProbabilityLabel.Size = new System.Drawing.Size(181, 22);
            this.FineProbabilityLabel.TabIndex = 18;
            this.FineProbabilityLabel.Text = "(Fine Probabilities)";
            this.FineProbabilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoarseProbabilityLabel
            // 
            this.CoarseProbabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoarseProbabilityLabel.Location = new System.Drawing.Point(572, 49);
            this.CoarseProbabilityLabel.Name = "CoarseProbabilityLabel";
            this.CoarseProbabilityLabel.Size = new System.Drawing.Size(181, 17);
            this.CoarseProbabilityLabel.TabIndex = 17;
            this.CoarseProbabilityLabel.Text = "(Coarse probabilities)";
            this.CoarseProbabilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinePredictionLabel
            // 
            this.FinePredictionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinePredictionLabel.Location = new System.Drawing.Point(762, 16);
            this.FinePredictionLabel.Name = "FinePredictionLabel";
            this.FinePredictionLabel.Size = new System.Drawing.Size(181, 36);
            this.FinePredictionLabel.TabIndex = 16;
            this.FinePredictionLabel.Text = "Fine Class";
            this.FinePredictionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TouchStatusLabel
            // 
            this.TouchStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TouchStatusLabel.Location = new System.Drawing.Point(8, 16);
            this.TouchStatusLabel.Name = "TouchStatusLabel";
            this.TouchStatusLabel.Size = new System.Drawing.Size(181, 36);
            this.TouchStatusLabel.TabIndex = 12;
            this.TouchStatusLabel.Text = "Touch Down";
            this.TouchStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoarsePredictionLabel
            // 
            this.CoarsePredictionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoarsePredictionLabel.Location = new System.Drawing.Point(572, 16);
            this.CoarsePredictionLabel.Name = "CoarsePredictionLabel";
            this.CoarsePredictionLabel.Size = new System.Drawing.Size(181, 36);
            this.CoarsePredictionLabel.TabIndex = 8;
            this.CoarsePredictionLabel.Text = "Coarse Class";
            this.CoarsePredictionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Display
            // 
            this.Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display.Location = new System.Drawing.Point(0, 24);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(952, 560);
            this.Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Display.TabIndex = 1;
            this.Display.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TouchStatusLabel);
            this.panel1.Controls.Add(this.OrientationLabel);
            this.panel1.Controls.Add(this.FineProbabilityLabel);
            this.panel1.Controls.Add(this.CoarseProbabilityLabel);
            this.panel1.Controls.Add(this.CoarsePredictionLabel);
            this.panel1.Controls.Add(this.FinePredictionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 94);
            this.panel1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.loggingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trainingToolStripMenuItem.Text = "Training";
            this.trainingToolStripMenuItem.Click += new System.EventHandler(this.trainingToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // TrainingLabel
            // 
            this.TrainingLabel.AutoSize = true;
            this.TrainingLabel.Location = new System.Drawing.Point(901, 5);
            this.TrainingLabel.Name = "TrainingLabel";
            this.TrainingLabel.Size = new System.Drawing.Size(45, 13);
            this.TrainingLabel.TabIndex = 8;
            this.TrainingLabel.Text = "Training";
            this.TrainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TrainingLabel.Visible = false;
            // 
            // loggingToolStripMenuItem
            // 
            this.loggingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.loggingToolStripMenuItem.Name = "loggingToolStripMenuItem";
            this.loggingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.loggingToolStripMenuItem.Text = "Logging";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // LocationAndGestureDataCollectionTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 678);
            this.Controls.Add(this.TrainingLabel);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LocationAndGestureDataCollectionTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Location and Gesture Data Collection Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LocalizationTest_FormClosing);
            this.Load += new System.EventHandler(this.LocationAndGestureDataCollectionTool_Load);
            this.Move += new System.EventHandler(this.OnBodyInputDemo_Move);
            this.Resize += new System.EventHandler(this.OnBodyInputDemo_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CoarsePredictionLabel;
        private System.Windows.Forms.PictureBox Display;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label TouchStatusLabel;
        private System.Windows.Forms.Label FinePredictionLabel;
        private System.Windows.Forms.Label FineProbabilityLabel;
        private System.Windows.Forms.Label CoarseProbabilityLabel;
        private System.Windows.Forms.Label OrientationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label TrainingLabel;
        private System.Windows.Forms.ToolStripMenuItem loggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
    }
}