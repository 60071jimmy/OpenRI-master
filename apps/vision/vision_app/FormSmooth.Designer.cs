namespace app
{
    partial class FormSmooth
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
            this.blur_button = new System.Windows.Forms.Button();
            this.bilateral_button = new System.Windows.Forms.Button();
            this.gaussian_button = new System.Windows.Forms.Button();
            this.median_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ksize_trackBar = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ksize_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksize_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // blur_button
            // 
            this.blur_button.ForeColor = System.Drawing.Color.Red;
            this.blur_button.Location = new System.Drawing.Point(87, 72);
            this.blur_button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.blur_button.Name = "blur_button";
            this.blur_button.Size = new System.Drawing.Size(273, 76);
            this.blur_button.TabIndex = 0;
            this.blur_button.Text = "Blur";
            this.blur_button.UseVisualStyleBackColor = true;
            this.blur_button.Click += new System.EventHandler(this.blur_Click);
            // 
            // bilateral_button
            // 
            this.bilateral_button.Location = new System.Drawing.Point(529, 196);
            this.bilateral_button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bilateral_button.Name = "bilateral_button";
            this.bilateral_button.Size = new System.Drawing.Size(273, 76);
            this.bilateral_button.TabIndex = 1;
            this.bilateral_button.Text = "Bilateral Blur";
            this.bilateral_button.UseVisualStyleBackColor = true;
            this.bilateral_button.Click += new System.EventHandler(this.bilateral_Click);
            // 
            // gaussian_button
            // 
            this.gaussian_button.Location = new System.Drawing.Point(529, 72);
            this.gaussian_button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gaussian_button.Name = "gaussian_button";
            this.gaussian_button.Size = new System.Drawing.Size(273, 76);
            this.gaussian_button.TabIndex = 2;
            this.gaussian_button.Text = "Gaussian Blur";
            this.gaussian_button.UseVisualStyleBackColor = true;
            this.gaussian_button.Click += new System.EventHandler(this.gaussian_Click);
            // 
            // median_button
            // 
            this.median_button.Location = new System.Drawing.Point(87, 196);
            this.median_button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.median_button.Name = "median_button";
            this.median_button.Size = new System.Drawing.Size(273, 76);
            this.median_button.TabIndex = 3;
            this.median_button.Text = "Median Blur";
            this.median_button.UseVisualStyleBackColor = true;
            this.median_button.Click += new System.EventHandler(this.median_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ksize_trackBar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ksize_label);
            this.groupBox1.Controls.Add(this.blur_button);
            this.groupBox1.Controls.Add(this.median_button);
            this.groupBox1.Controls.Add(this.bilateral_button);
            this.groupBox1.Controls.Add(this.gaussian_button);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(884, 506);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ksize_trackBar
            // 
            this.ksize_trackBar.LargeChange = 2;
            this.ksize_trackBar.Location = new System.Drawing.Point(288, 380);
            this.ksize_trackBar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ksize_trackBar.Maximum = 15;
            this.ksize_trackBar.Name = "ksize_trackBar";
            this.ksize_trackBar.Size = new System.Drawing.Size(468, 90);
            this.ksize_trackBar.TabIndex = 6;
            this.ksize_trackBar.Scroll += new System.EventHandler(this.ksize_trackBar_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(87, 380);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(184, 47);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Kernal Size";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ksize_label
            // 
            this.ksize_label.AutoSize = true;
            this.ksize_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ksize_label.Location = new System.Drawing.Point(793, 380);
            this.ksize_label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ksize_label.Name = "ksize_label";
            this.ksize_label.Size = new System.Drawing.Size(39, 46);
            this.ksize_label.TabIndex = 4;
            this.ksize_label.Text = "1";
            // 
            // ok_button
            // 
            this.ok_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(507, 566);
            this.ok_button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(182, 68);
            this.ok_button.TabIndex = 5;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(728, 566);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(182, 68);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // FormSmooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(938, 658);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormSmooth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smooth";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSmooth_FormClosed);
            this.Load += new System.EventHandler(this.Smooth_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksize_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button blur_button;
        private System.Windows.Forms.Button bilateral_button;
        private System.Windows.Forms.Button gaussian_button;
        private System.Windows.Forms.Button median_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar ksize_trackBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ksize_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
    }
}