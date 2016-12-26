namespace app
{
    partial class FormBrightnessContrast
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
            this.Contrast_trackbar = new System.Windows.Forms.TrackBar();
            this.Contrast = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contrast_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brightness_trackbar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Brightness_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // Contrast_trackbar
            // 
            this.Contrast_trackbar.Location = new System.Drawing.Point(162, 62);
            this.Contrast_trackbar.Margin = new System.Windows.Forms.Padding(6);
            this.Contrast_trackbar.Maximum = 3;
            this.Contrast_trackbar.Minimum = 1;
            this.Contrast_trackbar.Name = "Contrast_trackbar";
            this.Contrast_trackbar.Size = new System.Drawing.Size(536, 90);
            this.Contrast_trackbar.TabIndex = 4;
            this.Contrast_trackbar.TickFrequency = 5;
            this.Contrast_trackbar.Value = 1;
            this.Contrast_trackbar.Scroll += new System.EventHandler(this.Contrastbar_Scroll);
            // 
            // Contrast
            // 
            this.Contrast.AutoSize = true;
            this.Contrast.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.Contrast.Location = new System.Drawing.Point(30, 62);
            this.Contrast.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(116, 32);
            this.Contrast.TabIndex = 5;
            this.Contrast.Text = "Contrast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.label1.Location = new System.Drawing.Point(156, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.label2.Location = new System.Drawing.Point(642, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "3.0";
            // 
            // Contrast_label
            // 
            this.Contrast_label.AutoSize = true;
            this.Contrast_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrast_label.Location = new System.Drawing.Point(710, 62);
            this.Contrast_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Contrast_label.Name = "Contrast_label";
            this.Contrast_label.Size = new System.Drawing.Size(43, 51);
            this.Contrast_label.TabIndex = 8;
            this.Contrast_label.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.label4.Location = new System.Drawing.Point(2, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Brightness";
            // 
            // brightness_trackbar
            // 
            this.brightness_trackbar.Location = new System.Drawing.Point(162, 242);
            this.brightness_trackbar.Margin = new System.Windows.Forms.Padding(6);
            this.brightness_trackbar.Maximum = 100;
            this.brightness_trackbar.Name = "brightness_trackbar";
            this.brightness_trackbar.Size = new System.Drawing.Size(536, 90);
            this.brightness_trackbar.TabIndex = 10;
            this.brightness_trackbar.TickFrequency = 5;
            this.brightness_trackbar.Scroll += new System.EventHandler(this.Brigntness_trackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.label5.Location = new System.Drawing.Point(156, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.label6.Location = new System.Drawing.Point(642, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "100";
            // 
            // Brightness_label
            // 
            this.Brightness_label.AutoSize = true;
            this.Brightness_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brightness_label.Location = new System.Drawing.Point(710, 248);
            this.Brightness_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Brightness_label.Name = "Brightness_label";
            this.Brightness_label.Size = new System.Drawing.Size(43, 51);
            this.Brightness_label.TabIndex = 13;
            this.Brightness_label.Text = "0";
            // 
            // ok_button
            // 
            this.ok_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(376, 385);
            this.ok_button.Margin = new System.Windows.Forms.Padding(6);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(184, 62);
            this.ok_button.TabIndex = 14;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.Location = new System.Drawing.Point(572, 385);
            this.reset_button.Margin = new System.Windows.Forms.Padding(6);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(184, 62);
            this.reset_button.TabIndex = 15;
            this.reset_button.Text = "Cancel";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // FormBrightnessContrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(818, 473);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.Brightness_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brightness_trackbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Contrast_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contrast);
            this.Controls.Add(this.Contrast_trackbar);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormBrightnessContrast";
            this.Text = "Brightness_contrast";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBrightnessContrast_FormClosed);
            this.Load += new System.EventHandler(this.Brightness_contrast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Contrast_trackbar;
        private System.Windows.Forms.Label Contrast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Contrast_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar brightness_trackbar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Brightness_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button reset_button;
    }
}