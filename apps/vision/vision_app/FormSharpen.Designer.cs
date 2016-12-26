namespace app
{
    partial class FormSharpen
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
            this.sharpen_trackBar = new System.Windows.Forms.TrackBar();
            this.contrast_trackBar = new System.Windows.Forms.TrackBar();
            this.ksize_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sharpen_label = new System.Windows.Forms.Label();
            this.contrast_label = new System.Windows.Forms.Label();
            this.ksize_label = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sharpen_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrast_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksize_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // sharpen_trackBar
            // 
            this.sharpen_trackBar.Location = new System.Drawing.Point(86, 58);
            this.sharpen_trackBar.Margin = new System.Windows.Forms.Padding(6);
            this.sharpen_trackBar.Maximum = 1000;
            this.sharpen_trackBar.Minimum = 100;
            this.sharpen_trackBar.Name = "sharpen_trackBar";
            this.sharpen_trackBar.Size = new System.Drawing.Size(496, 90);
            this.sharpen_trackBar.TabIndex = 0;
            this.sharpen_trackBar.Value = 100;
            this.sharpen_trackBar.Scroll += new System.EventHandler(this.Sharpen_trackBar_Scroll);
            // 
            // contrast_trackBar
            // 
            this.contrast_trackBar.Location = new System.Drawing.Point(86, 210);
            this.contrast_trackBar.Margin = new System.Windows.Forms.Padding(6);
            this.contrast_trackBar.Maximum = 1000;
            this.contrast_trackBar.Name = "contrast_trackBar";
            this.contrast_trackBar.Size = new System.Drawing.Size(496, 90);
            this.contrast_trackBar.TabIndex = 1;
            this.contrast_trackBar.Scroll += new System.EventHandler(this.Contrast_trackBar_Scroll);
            // 
            // ksize_trackBar
            // 
            this.ksize_trackBar.LargeChange = 1;
            this.ksize_trackBar.Location = new System.Drawing.Point(86, 379);
            this.ksize_trackBar.Margin = new System.Windows.Forms.Padding(6);
            this.ksize_trackBar.Maximum = 5;
            this.ksize_trackBar.Minimum = 1;
            this.ksize_trackBar.Name = "ksize_trackBar";
            this.ksize_trackBar.Size = new System.Drawing.Size(496, 90);
            this.ksize_trackBar.TabIndex = 2;
            this.ksize_trackBar.Value = 1;
            this.ksize_trackBar.Scroll += new System.EventHandler(this.Ksize_trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(100, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sharpen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(100, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contrast";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(98, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kernel size";
            // 
            // sharpen_label
            // 
            this.sharpen_label.AutoSize = true;
            this.sharpen_label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sharpen_label.Location = new System.Drawing.Point(642, 58);
            this.sharpen_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sharpen_label.Name = "sharpen_label";
            this.sharpen_label.Size = new System.Drawing.Size(35, 38);
            this.sharpen_label.TabIndex = 6;
            this.sharpen_label.Text = "1";
            // 
            // contrast_label
            // 
            this.contrast_label.AutoSize = true;
            this.contrast_label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.contrast_label.Location = new System.Drawing.Point(642, 210);
            this.contrast_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.contrast_label.Name = "contrast_label";
            this.contrast_label.Size = new System.Drawing.Size(35, 38);
            this.contrast_label.TabIndex = 7;
            this.contrast_label.Text = "0";
            // 
            // ksize_label
            // 
            this.ksize_label.AutoSize = true;
            this.ksize_label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ksize_label.Location = new System.Drawing.Point(642, 379);
            this.ksize_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ksize_label.Name = "ksize_label";
            this.ksize_label.Size = new System.Drawing.Size(35, 38);
            this.ksize_label.TabIndex = 8;
            this.ksize_label.Text = "3";
            // 
            // Save_Button
            // 
            this.Save_Button.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Save_Button.Location = new System.Drawing.Point(332, 681);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(250, 60);
            this.Save_Button.TabIndex = 9;
            this.Save_Button.Text = "OK";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Reset_Button.Location = new System.Drawing.Point(594, 681);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(250, 60);
            this.Reset_Button.TabIndex = 10;
            this.Reset_Button.Text = "Cancel";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(86, 552);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 73);
            this.button1.TabIndex = 11;
            this.button1.Text = "3*3Mask Sharpen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MaskSharpen_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(80, 477);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Or";
            // 
            // FormSharpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(866, 817);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.ksize_label);
            this.Controls.Add(this.contrast_label);
            this.Controls.Add(this.sharpen_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ksize_trackBar);
            this.Controls.Add(this.contrast_trackBar);
            this.Controls.Add(this.sharpen_trackBar);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormSharpen";
            this.Text = "Sharpen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSharpen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.sharpen_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrast_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksize_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sharpen_trackBar;
        private System.Windows.Forms.TrackBar contrast_trackBar;
        private System.Windows.Forms.TrackBar ksize_trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sharpen_label;
        private System.Windows.Forms.Label contrast_label;
        private System.Windows.Forms.Label ksize_label;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}