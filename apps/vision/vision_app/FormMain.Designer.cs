namespace app
{
    partial class FormMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basucProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findEdgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilateErodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fFTDFTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spectialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realTimeVisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTest1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTest2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTest3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTest4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.processToolStripMenuItem,
            this.realTimeVisionToolStripMenuItem,
            this.imageTestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opeToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // opeToolStripMenuItem
            // 
            this.opeToolStripMenuItem.Name = "opeToolStripMenuItem";
            this.opeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opeToolStripMenuItem.Text = "Open";
            this.opeToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click_1);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basucProcessToolStripMenuItem,
            this.thresholdToolStripMenuItem,
            this.findEdgeToolStripMenuItem,
            this.dilateErodeToolStripMenuItem,
            this.smoothToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.noiseToolStripMenuItem,
            this.fFTDFTToolStripMenuItem,
            this.harrToolStripMenuItem,
            this.brightnessContrastToolStripMenuItem,
            this.spectialToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // basucProcessToolStripMenuItem
            // 
            this.basucProcessToolStripMenuItem.Name = "basucProcessToolStripMenuItem";
            this.basucProcessToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.basucProcessToolStripMenuItem.Text = "Basic Process";
            this.basucProcessToolStripMenuItem.Click += new System.EventHandler(this.basucProcessToolStripMenuItem_Click);
            // 
            // thresholdToolStripMenuItem
            // 
            this.thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem";
            this.thresholdToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.thresholdToolStripMenuItem.Text = "Threshold";
            this.thresholdToolStripMenuItem.Click += new System.EventHandler(this.thresholdToolStripMenuItem_Click);
            // 
            // findEdgeToolStripMenuItem
            // 
            this.findEdgeToolStripMenuItem.Name = "findEdgeToolStripMenuItem";
            this.findEdgeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.findEdgeToolStripMenuItem.Text = "Find Edge";
            this.findEdgeToolStripMenuItem.Click += new System.EventHandler(this.findEdgeToolStripMenuItem_Click);
            // 
            // dilateErodeToolStripMenuItem
            // 
            this.dilateErodeToolStripMenuItem.Name = "dilateErodeToolStripMenuItem";
            this.dilateErodeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.dilateErodeToolStripMenuItem.Text = "Dilate/Erode";
            this.dilateErodeToolStripMenuItem.Click += new System.EventHandler(this.dilateErodeToolStripMenuItem_Click);
            // 
            // smoothToolStripMenuItem
            // 
            this.smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            this.smoothToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.smoothToolStripMenuItem.Text = "Smooth";
            this.smoothToolStripMenuItem.Click += new System.EventHandler(this.smoothToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // noiseToolStripMenuItem
            // 
            this.noiseToolStripMenuItem.Name = "noiseToolStripMenuItem";
            this.noiseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.noiseToolStripMenuItem.Text = "Noise";
            this.noiseToolStripMenuItem.Click += new System.EventHandler(this.noiseToolStripMenuItem_Click);
            // 
            // fFTDFTToolStripMenuItem
            // 
            this.fFTDFTToolStripMenuItem.Name = "fFTDFTToolStripMenuItem";
            this.fFTDFTToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.fFTDFTToolStripMenuItem.Text = "Fourier Filtering";
            this.fFTDFTToolStripMenuItem.Click += new System.EventHandler(this.fFTDFTToolStripMenuItem_Click);
            // 
            // harrToolStripMenuItem
            // 
            this.harrToolStripMenuItem.Name = "harrToolStripMenuItem";
            this.harrToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.harrToolStripMenuItem.Text = "Wavelet Filtering";
            this.harrToolStripMenuItem.Click += new System.EventHandler(this.harrToolStripMenuItem_Click);
            // 
            // brightnessContrastToolStripMenuItem
            // 
            this.brightnessContrastToolStripMenuItem.Name = "brightnessContrastToolStripMenuItem";
            this.brightnessContrastToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.brightnessContrastToolStripMenuItem.Text = "Brightness/Contrast";
            this.brightnessContrastToolStripMenuItem.Click += new System.EventHandler(this.brightnessContrastToolStripMenuItem_Click);
            // 
            // spectialToolStripMenuItem
            // 
            this.spectialToolStripMenuItem.Name = "spectialToolStripMenuItem";
            this.spectialToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.spectialToolStripMenuItem.Text = "Special Filter";
            this.spectialToolStripMenuItem.Click += new System.EventHandler(this.spectialToolStripMenuItem_Click);
            // 
            // realTimeVisionToolStripMenuItem
            // 
            this.realTimeVisionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webCamToolStripMenuItem});
            this.realTimeVisionToolStripMenuItem.Name = "realTimeVisionToolStripMenuItem";
            this.realTimeVisionToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.realTimeVisionToolStripMenuItem.Text = "RealTime Vision";
            // 
            // webCamToolStripMenuItem
            // 
            this.webCamToolStripMenuItem.Name = "webCamToolStripMenuItem";
            this.webCamToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.webCamToolStripMenuItem.Text = "WebCam";
            this.webCamToolStripMenuItem.Click += new System.EventHandler(this.webCamToolStripMenuItem_Click);
            // 
            // imageTestToolStripMenuItem
            // 
            this.imageTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageTest1ToolStripMenuItem,
            this.imageTest2ToolStripMenuItem,
            this.imageTest3ToolStripMenuItem,
            this.imageTest4ToolStripMenuItem});
            this.imageTestToolStripMenuItem.Name = "imageTestToolStripMenuItem";
            this.imageTestToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.imageTestToolStripMenuItem.Text = "Test";
            // 
            // imageTest1ToolStripMenuItem
            // 
            this.imageTest1ToolStripMenuItem.Name = "imageTest1ToolStripMenuItem";
            this.imageTest1ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.imageTest1ToolStripMenuItem.Text = "Image_Test1";
            this.imageTest1ToolStripMenuItem.Click += new System.EventHandler(this.imageTest1ToolStripMenuItem_Click);
            // 
            // imageTest2ToolStripMenuItem
            // 
            this.imageTest2ToolStripMenuItem.Name = "imageTest2ToolStripMenuItem";
            this.imageTest2ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.imageTest2ToolStripMenuItem.Text = "Image_Test2";
            this.imageTest2ToolStripMenuItem.Click += new System.EventHandler(this.imageTest2ToolStripMenuItem_Click);
            // 
            // imageTest3ToolStripMenuItem
            // 
            this.imageTest3ToolStripMenuItem.Name = "imageTest3ToolStripMenuItem";
            this.imageTest3ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.imageTest3ToolStripMenuItem.Text = "Image_Test3";
            this.imageTest3ToolStripMenuItem.Click += new System.EventHandler(this.imageTest3ToolStripMenuItem_Click);
            // 
            // imageTest4ToolStripMenuItem
            // 
            this.imageTest4ToolStripMenuItem.Name = "imageTest4ToolStripMenuItem";
            this.imageTest4ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.imageTest4ToolStripMenuItem.Text = "Image_Test4";
            this.imageTest4ToolStripMenuItem.Click += new System.EventHandler(this.imageTest4ToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem1.Text = "Undo";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(714, 415);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basucProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findEdgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilateErodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fFTDFTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageTest1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageTest2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageTest3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageTest4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realTimeVisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spectialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
    }
}