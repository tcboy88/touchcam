﻿namespace HandSightOnBodyInteractionGPU
{
    partial class LogViewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OtherCheckbox = new System.Windows.Forms.CheckBox();
            this.MenuCheckbox = new System.Windows.Forms.CheckBox();
            this.UICheckbox = new System.Windows.Forms.CheckBox();
            this.TrainingCheckbox = new System.Windows.Forms.CheckBox();
            this.AudioCheckbox = new System.Windows.Forms.CheckBox();
            this.GestureCheckbox = new System.Windows.Forms.CheckBox();
            this.LocationCheckbox = new System.Windows.Forms.CheckBox();
            this.SensorReadingsCheckbox = new System.Windows.Forms.CheckBox();
            this.EventCountLabel = new System.Windows.Forms.Label();
            this.VideoFramesCheckbox = new System.Windows.Forms.CheckBox();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBox = new System.Windows.Forms.ListBox();
            this.FrameProcessedCheckbox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FrameProcessedCheckbox);
            this.panel1.Controls.Add(this.OtherCheckbox);
            this.panel1.Controls.Add(this.MenuCheckbox);
            this.panel1.Controls.Add(this.UICheckbox);
            this.panel1.Controls.Add(this.TrainingCheckbox);
            this.panel1.Controls.Add(this.AudioCheckbox);
            this.panel1.Controls.Add(this.GestureCheckbox);
            this.panel1.Controls.Add(this.LocationCheckbox);
            this.panel1.Controls.Add(this.SensorReadingsCheckbox);
            this.panel1.Controls.Add(this.EventCountLabel);
            this.panel1.Controls.Add(this.VideoFramesCheckbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(598, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 437);
            this.panel1.TabIndex = 0;
            // 
            // OtherCheckbox
            // 
            this.OtherCheckbox.AutoSize = true;
            this.OtherCheckbox.Location = new System.Drawing.Point(13, 219);
            this.OtherCheckbox.Name = "OtherCheckbox";
            this.OtherCheckbox.Size = new System.Drawing.Size(52, 17);
            this.OtherCheckbox.TabIndex = 9;
            this.OtherCheckbox.Text = "Other";
            this.OtherCheckbox.UseVisualStyleBackColor = true;
            this.OtherCheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // MenuCheckbox
            // 
            this.MenuCheckbox.AutoSize = true;
            this.MenuCheckbox.Location = new System.Drawing.Point(13, 173);
            this.MenuCheckbox.Name = "MenuCheckbox";
            this.MenuCheckbox.Size = new System.Drawing.Size(53, 17);
            this.MenuCheckbox.TabIndex = 8;
            this.MenuCheckbox.Text = "Menu";
            this.MenuCheckbox.UseVisualStyleBackColor = true;
            this.MenuCheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // UICheckbox
            // 
            this.UICheckbox.AutoSize = true;
            this.UICheckbox.Location = new System.Drawing.Point(13, 150);
            this.UICheckbox.Name = "UICheckbox";
            this.UICheckbox.Size = new System.Drawing.Size(37, 17);
            this.UICheckbox.TabIndex = 7;
            this.UICheckbox.Text = "UI";
            this.UICheckbox.UseVisualStyleBackColor = true;
            this.UICheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // TrainingCheckbox
            // 
            this.TrainingCheckbox.AutoSize = true;
            this.TrainingCheckbox.Location = new System.Drawing.Point(13, 127);
            this.TrainingCheckbox.Name = "TrainingCheckbox";
            this.TrainingCheckbox.Size = new System.Drawing.Size(64, 17);
            this.TrainingCheckbox.TabIndex = 6;
            this.TrainingCheckbox.Text = "Training";
            this.TrainingCheckbox.UseVisualStyleBackColor = true;
            this.TrainingCheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // AudioCheckbox
            // 
            this.AudioCheckbox.AutoSize = true;
            this.AudioCheckbox.Location = new System.Drawing.Point(13, 104);
            this.AudioCheckbox.Name = "AudioCheckbox";
            this.AudioCheckbox.Size = new System.Drawing.Size(53, 17);
            this.AudioCheckbox.TabIndex = 5;
            this.AudioCheckbox.Text = "Audio";
            this.AudioCheckbox.UseVisualStyleBackColor = true;
            this.AudioCheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // GestureCheckbox
            // 
            this.GestureCheckbox.AutoSize = true;
            this.GestureCheckbox.Location = new System.Drawing.Point(13, 81);
            this.GestureCheckbox.Name = "GestureCheckbox";
            this.GestureCheckbox.Size = new System.Drawing.Size(63, 17);
            this.GestureCheckbox.TabIndex = 4;
            this.GestureCheckbox.Text = "Gesture";
            this.GestureCheckbox.UseVisualStyleBackColor = true;
            this.GestureCheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // LocationCheckbox
            // 
            this.LocationCheckbox.AutoSize = true;
            this.LocationCheckbox.Location = new System.Drawing.Point(13, 58);
            this.LocationCheckbox.Name = "LocationCheckbox";
            this.LocationCheckbox.Size = new System.Drawing.Size(67, 17);
            this.LocationCheckbox.TabIndex = 3;
            this.LocationCheckbox.Text = "Location";
            this.LocationCheckbox.UseVisualStyleBackColor = true;
            this.LocationCheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // SensorReadingsCheckbox
            // 
            this.SensorReadingsCheckbox.AutoSize = true;
            this.SensorReadingsCheckbox.Location = new System.Drawing.Point(13, 35);
            this.SensorReadingsCheckbox.Name = "SensorReadingsCheckbox";
            this.SensorReadingsCheckbox.Size = new System.Drawing.Size(107, 17);
            this.SensorReadingsCheckbox.TabIndex = 2;
            this.SensorReadingsCheckbox.Text = "Sensor Readings";
            this.SensorReadingsCheckbox.UseVisualStyleBackColor = true;
            this.SensorReadingsCheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // EventCountLabel
            // 
            this.EventCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EventCountLabel.AutoSize = true;
            this.EventCountLabel.Location = new System.Drawing.Point(10, 415);
            this.EventCountLabel.Name = "EventCountLabel";
            this.EventCountLabel.Size = new System.Drawing.Size(102, 13);
            this.EventCountLabel.TabIndex = 1;
            this.EventCountLabel.Text = "##### / #######";
            // 
            // VideoFramesCheckbox
            // 
            this.VideoFramesCheckbox.AutoSize = true;
            this.VideoFramesCheckbox.Location = new System.Drawing.Point(13, 12);
            this.VideoFramesCheckbox.Name = "VideoFramesCheckbox";
            this.VideoFramesCheckbox.Size = new System.Drawing.Size(90, 17);
            this.VideoFramesCheckbox.TabIndex = 0;
            this.VideoFramesCheckbox.Text = "Video Frames";
            this.VideoFramesCheckbox.UseVisualStyleBackColor = true;
            this.VideoFramesCheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Progress
            // 
            this.Progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Progress.Location = new System.Drawing.Point(0, 451);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(598, 10);
            this.Progress.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // DataBox
            // 
            this.DataBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataBox.FormattingEnabled = true;
            this.DataBox.Location = new System.Drawing.Point(0, 24);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(598, 427);
            this.DataBox.TabIndex = 3;
            // 
            // FrameProcessedCheckbox
            // 
            this.FrameProcessedCheckbox.AutoSize = true;
            this.FrameProcessedCheckbox.Location = new System.Drawing.Point(13, 196);
            this.FrameProcessedCheckbox.Name = "FrameProcessedCheckbox";
            this.FrameProcessedCheckbox.Size = new System.Drawing.Size(108, 17);
            this.FrameProcessedCheckbox.TabIndex = 10;
            this.FrameProcessedCheckbox.Text = "Frame Processed";
            this.FrameProcessedCheckbox.UseVisualStyleBackColor = true;
            this.FrameProcessedCheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 461);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogViewer";
            this.Text = "LogViewer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox VideoFramesCheckbox;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label EventCountLabel;
        private System.Windows.Forms.CheckBox SensorReadingsCheckbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.CheckBox LocationCheckbox;
        private System.Windows.Forms.CheckBox AudioCheckbox;
        private System.Windows.Forms.CheckBox GestureCheckbox;
        private System.Windows.Forms.CheckBox TrainingCheckbox;
        private System.Windows.Forms.CheckBox UICheckbox;
        private System.Windows.Forms.CheckBox OtherCheckbox;
        private System.Windows.Forms.CheckBox MenuCheckbox;
        private System.Windows.Forms.ListBox DataBox;
        private System.Windows.Forms.CheckBox FrameProcessedCheckbox;
    }
}