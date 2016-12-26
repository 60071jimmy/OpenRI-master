namespace app
{
    partial class FormEdgeDetector
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.laplace_button = new System.Windows.Forms.Button();
            this.scale_label = new System.Windows.Forms.Label();
            this.sobel_button = new System.Windows.Forms.Button();
            this.ksize_label = new System.Windows.Forms.Label();
            this.scale_textbox = new System.Windows.Forms.TextBox();
            this.canny_button = new System.Windows.Forms.Button();
            this.ksize_textbox = new System.Windows.Forms.TextBox();
            this.scale_trackBar = new System.Windows.Forms.TrackBar();
            this.ksize_trackBar = new System.Windows.Forms.TrackBar();
            this.ok_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scale_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksize_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.laplace_button);
            this.groupBox1.Controls.Add(this.scale_label);
            this.groupBox1.Controls.Add(this.sobel_button);
            this.groupBox1.Controls.Add(this.ksize_label);
            this.groupBox1.Controls.Add(this.scale_textbox);
            this.groupBox1.Controls.Add(this.canny_button);
            this.groupBox1.Controls.Add(this.ksize_textbox);
            this.groupBox1.Controls.Add(this.scale_trackBar);
            this.groupBox1.Controls.Add(this.ksize_trackBar);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1398, 543);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // laplace_button
            // 
            this.laplace_button.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplace_button.Location = new System.Drawing.Point(982, 91);
            this.laplace_button.Margin = new System.Windows.Forms.Padding(6);
            this.laplace_button.Name = "laplace_button";
            this.laplace_button.Size = new System.Drawing.Size(240, 83);
            this.laplace_button.TabIndex = 2;
            this.laplace_button.Text = "Laplace";
            this.laplace_button.UseVisualStyleBackColor = true;
            this.laplace_button.Click += new System.EventHandler(this.laplace_button_Click);
            // 
            // scale_label
            // 
            this.scale_label.AutoSize = true;
            this.scale_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scale_label.Location = new System.Drawing.Point(1131, 425);
            this.scale_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.scale_label.Name = "scale_label";
            this.scale_label.Size = new System.Drawing.Size(58, 46);
            this.scale_label.TabIndex = 6;
            this.scale_label.Text = "10";
            // 
            // sobel_button
            // 
            this.sobel_button.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobel_button.Location = new System.Drawing.Point(576, 91);
            this.sobel_button.Margin = new System.Windows.Forms.Padding(6);
            this.sobel_button.Name = "sobel_button";
            this.sobel_button.Size = new System.Drawing.Size(240, 83);
            this.sobel_button.TabIndex = 1;
            this.sobel_button.Text = "Sobel";
            this.sobel_button.UseVisualStyleBackColor = true;
            this.sobel_button.Click += new System.EventHandler(this.sobel_button_Click);
            // 
            // ksize_label
            // 
            this.ksize_label.AutoSize = true;
            this.ksize_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ksize_label.Location = new System.Drawing.Point(1131, 315);
            this.ksize_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ksize_label.Name = "ksize_label";
            this.ksize_label.Size = new System.Drawing.Size(39, 46);
            this.ksize_label.TabIndex = 5;
            this.ksize_label.Text = "3";
            // 
            // scale_textbox
            // 
            this.scale_textbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.scale_textbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scale_textbox.Location = new System.Drawing.Point(171, 425);
            this.scale_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.scale_textbox.Name = "scale_textbox";
            this.scale_textbox.ReadOnly = true;
            this.scale_textbox.Size = new System.Drawing.Size(202, 47);
            this.scale_textbox.TabIndex = 4;
            this.scale_textbox.Text = "Theshold";
            this.scale_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // canny_button
            // 
            this.canny_button.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canny_button.ForeColor = System.Drawing.Color.Red;
            this.canny_button.Location = new System.Drawing.Point(154, 91);
            this.canny_button.Margin = new System.Windows.Forms.Padding(6);
            this.canny_button.Name = "canny_button";
            this.canny_button.Size = new System.Drawing.Size(240, 83);
            this.canny_button.TabIndex = 0;
            this.canny_button.Text = "Canny";
            this.canny_button.UseVisualStyleBackColor = true;
            this.canny_button.Click += new System.EventHandler(this.canny_button_Click);
            // 
            // ksize_textbox
            // 
            this.ksize_textbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ksize_textbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ksize_textbox.Location = new System.Drawing.Point(171, 315);
            this.ksize_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.ksize_textbox.Name = "ksize_textbox";
            this.ksize_textbox.ReadOnly = true;
            this.ksize_textbox.Size = new System.Drawing.Size(202, 47);
            this.ksize_textbox.TabIndex = 3;
            this.ksize_textbox.Text = " Kernal Size";
            this.ksize_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scale_trackBar
            // 
            this.scale_trackBar.Location = new System.Drawing.Point(389, 425);
            this.scale_trackBar.Margin = new System.Windows.Forms.Padding(6);
            this.scale_trackBar.Maximum = 254;
            this.scale_trackBar.Minimum = 10;
            this.scale_trackBar.Name = "scale_trackBar";
            this.scale_trackBar.Size = new System.Drawing.Size(730, 90);
            this.scale_trackBar.TabIndex = 2;
            this.scale_trackBar.Value = 10;
            this.scale_trackBar.Scroll += new System.EventHandler(this.scale_trackBar_Scroll);
            // 
            // ksize_trackBar
            // 
            this.ksize_trackBar.LargeChange = 1;
            this.ksize_trackBar.Location = new System.Drawing.Point(389, 315);
            this.ksize_trackBar.Margin = new System.Windows.Forms.Padding(6);
            this.ksize_trackBar.Maximum = 7;
            this.ksize_trackBar.Minimum = 1;
            this.ksize_trackBar.Name = "ksize_trackBar";
            this.ksize_trackBar.Size = new System.Drawing.Size(730, 90);
            this.ksize_trackBar.TabIndex = 1;
            this.ksize_trackBar.Value = 1;
            this.ksize_trackBar.Scroll += new System.EventHandler(this.ksize_trackBar_Scroll);
            // 
            // ok_button
            // 
            this.ok_button.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(859, 639);
            this.ok_button.Margin = new System.Windows.Forms.Padding(6);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(236, 77);
            this.ok_button.TabIndex = 6;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.Location = new System.Drawing.Point(1141, 639);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(6);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(236, 77);
            this.Cancel_button.TabIndex = 7;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // FormEdgeDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1450, 777);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEdgeDetector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edge_Detector";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEdgeDetector_FormClosed);
            this.Load += new System.EventHandler(this.Edge_Detector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scale_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksize_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label scale_label;
        private System.Windows.Forms.Label ksize_label;
        private System.Windows.Forms.TextBox scale_textbox;
        private System.Windows.Forms.TextBox ksize_textbox;
        private System.Windows.Forms.TrackBar scale_trackBar;
        private System.Windows.Forms.TrackBar ksize_trackBar;
        private System.Windows.Forms.Button canny_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button laplace_button;
        private System.Windows.Forms.Button sobel_button;
    }
}