namespace app
{
    partial class FormFFT
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
            this.PictureBox_FFT_0 = new System.Windows.Forms.PictureBox();
            this.PictureBox_FFT_1 = new System.Windows.Forms.PictureBox();
            this.PictureBox_FFT_2 = new System.Windows.Forms.PictureBox();
            this.FFT_Button = new System.Windows.Forms.Button();
            this.Inverse_FFT_Button = new System.Windows.Forms.Button();
            this.radius_trackBar = new System.Windows.Forms.TrackBar();
            this.ideal_radio = new System.Windows.Forms.RadioButton();
            this.butterworth_radio = new System.Windows.Forms.RadioButton();
            this.gaussian_radio = new System.Windows.Forms.RadioButton();
            this.radius_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lowpass_radio = new System.Windows.Forms.RadioButton();
            this.hightpass_radio = new System.Windows.Forms.RadioButton();
            this.n_trackBar = new System.Windows.Forms.TrackBar();
            this.n_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_FFT_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_FFT_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_FFT_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius_trackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_FFT_0
            // 
            this.PictureBox_FFT_0.Location = new System.Drawing.Point(527, 46);
            this.PictureBox_FFT_0.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PictureBox_FFT_0.Name = "PictureBox_FFT_0";
            this.PictureBox_FFT_0.Size = new System.Drawing.Size(650, 600);
            this.PictureBox_FFT_0.TabIndex = 1;
            this.PictureBox_FFT_0.TabStop = false;
            // 
            // PictureBox_FFT_1
            // 
            this.PictureBox_FFT_1.Location = new System.Drawing.Point(1224, 46);
            this.PictureBox_FFT_1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PictureBox_FFT_1.Name = "PictureBox_FFT_1";
            this.PictureBox_FFT_1.Size = new System.Drawing.Size(650, 600);
            this.PictureBox_FFT_1.TabIndex = 2;
            this.PictureBox_FFT_1.TabStop = false;
            // 
            // PictureBox_FFT_2
            // 
            this.PictureBox_FFT_2.Location = new System.Drawing.Point(1924, 46);
            this.PictureBox_FFT_2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PictureBox_FFT_2.Name = "PictureBox_FFT_2";
            this.PictureBox_FFT_2.Size = new System.Drawing.Size(650, 600);
            this.PictureBox_FFT_2.TabIndex = 3;
            this.PictureBox_FFT_2.TabStop = false;
            // 
            // FFT_Button
            // 
            this.FFT_Button.Font = new System.Drawing.Font("新細明體", 14F);
            this.FFT_Button.Location = new System.Drawing.Point(46, 46);
            this.FFT_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.FFT_Button.Name = "FFT_Button";
            this.FFT_Button.Size = new System.Drawing.Size(433, 83);
            this.FFT_Button.TabIndex = 4;
            this.FFT_Button.Text = "See Maganitude";
            this.FFT_Button.UseVisualStyleBackColor = true;
            this.FFT_Button.Click += new System.EventHandler(this.FFT_Button_Click);
            // 
            // Inverse_FFT_Button
            // 
            this.Inverse_FFT_Button.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Inverse_FFT_Button.Location = new System.Drawing.Point(111, 772);
            this.Inverse_FFT_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Inverse_FFT_Button.Name = "Inverse_FFT_Button";
            this.Inverse_FFT_Button.Size = new System.Drawing.Size(269, 68);
            this.Inverse_FFT_Button.TabIndex = 5;
            this.Inverse_FFT_Button.Text = "Inverse FFT";
            this.Inverse_FFT_Button.UseVisualStyleBackColor = true;
            this.Inverse_FFT_Button.Visible = false;
            // 
            // radius_trackBar
            // 
            this.radius_trackBar.LargeChange = 1;
            this.radius_trackBar.Location = new System.Drawing.Point(46, 570);
            this.radius_trackBar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.radius_trackBar.Minimum = 1;
            this.radius_trackBar.Name = "radius_trackBar";
            this.radius_trackBar.Size = new System.Drawing.Size(433, 90);
            this.radius_trackBar.TabIndex = 6;
            this.radius_trackBar.Value = 1;
            this.radius_trackBar.Scroll += new System.EventHandler(this.radius_trackBar_Scroll);
            // 
            // ideal_radio
            // 
            this.ideal_radio.AutoSize = true;
            this.ideal_radio.Checked = true;
            this.ideal_radio.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ideal_radio.Location = new System.Drawing.Point(46, 42);
            this.ideal_radio.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ideal_radio.Name = "ideal_radio";
            this.ideal_radio.Size = new System.Drawing.Size(170, 36);
            this.ideal_radio.TabIndex = 7;
            this.ideal_radio.TabStop = true;
            this.ideal_radio.Text = "Ideal filter";
            this.ideal_radio.UseVisualStyleBackColor = true;
            this.ideal_radio.CheckedChanged += new System.EventHandler(this.ideal_radioButton_CheckedChanged);
            // 
            // butterworth_radio
            // 
            this.butterworth_radio.AutoSize = true;
            this.butterworth_radio.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butterworth_radio.Location = new System.Drawing.Point(46, 94);
            this.butterworth_radio.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.butterworth_radio.Name = "butterworth_radio";
            this.butterworth_radio.Size = new System.Drawing.Size(255, 36);
            this.butterworth_radio.TabIndex = 8;
            this.butterworth_radio.Text = "Butterworth filter";
            this.butterworth_radio.UseVisualStyleBackColor = true;
            this.butterworth_radio.CheckedChanged += new System.EventHandler(this.butterworth_radioButton_CheckedChanged);
            // 
            // gaussian_radio
            // 
            this.gaussian_radio.AutoSize = true;
            this.gaussian_radio.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gaussian_radio.Location = new System.Drawing.Point(46, 146);
            this.gaussian_radio.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gaussian_radio.Name = "gaussian_radio";
            this.gaussian_radio.Size = new System.Drawing.Size(221, 36);
            this.gaussian_radio.TabIndex = 9;
            this.gaussian_radio.Text = "Gaussian filter";
            this.gaussian_radio.UseVisualStyleBackColor = true;
            this.gaussian_radio.CheckedChanged += new System.EventHandler(this.gaussian_radioButton_CheckedChanged);
            // 
            // radius_label
            // 
            this.radius_label.AutoSize = true;
            this.radius_label.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radius_label.Location = new System.Drawing.Point(56, 516);
            this.radius_label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.radius_label.Name = "radius_label";
            this.radius_label.Size = new System.Drawing.Size(117, 38);
            this.radius_label.TabIndex = 10;
            this.radius_label.Text = "Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(327, 516);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 38);
            this.label2.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ideal_radio);
            this.groupBox1.Controls.Add(this.butterworth_radio);
            this.groupBox1.Controls.Add(this.gaussian_radio);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(46, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(433, 200);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lowpass_radio);
            this.groupBox2.Controls.Add(this.hightpass_radio);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(46, 362);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Size = new System.Drawing.Size(433, 148);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Highpass/Lowpass";
            // 
            // lowpass_radio
            // 
            this.lowpass_radio.AutoSize = true;
            this.lowpass_radio.Location = new System.Drawing.Point(215, 52);
            this.lowpass_radio.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lowpass_radio.Name = "lowpass_radio";
            this.lowpass_radio.Size = new System.Drawing.Size(153, 36);
            this.lowpass_radio.TabIndex = 1;
            this.lowpass_radio.Text = "Lowpass";
            this.lowpass_radio.UseVisualStyleBackColor = true;
            this.lowpass_radio.CheckedChanged += new System.EventHandler(this.lowPass_radioButton_CheckedChanged);
            // 
            // hightpass_radio
            // 
            this.hightpass_radio.AutoSize = true;
            this.hightpass_radio.Checked = true;
            this.hightpass_radio.Location = new System.Drawing.Point(20, 52);
            this.hightpass_radio.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.hightpass_radio.Name = "hightpass_radio";
            this.hightpass_radio.Size = new System.Drawing.Size(160, 36);
            this.hightpass_radio.TabIndex = 0;
            this.hightpass_radio.TabStop = true;
            this.hightpass_radio.Text = "HighPass";
            this.hightpass_radio.UseVisualStyleBackColor = true;
            this.hightpass_radio.CheckedChanged += new System.EventHandler(this.hightPass_radioButton_CheckedChanged);
            // 
            // n_trackBar
            // 
            this.n_trackBar.LargeChange = 1;
            this.n_trackBar.Location = new System.Drawing.Point(46, 672);
            this.n_trackBar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.n_trackBar.Minimum = 1;
            this.n_trackBar.Name = "n_trackBar";
            this.n_trackBar.Size = new System.Drawing.Size(433, 90);
            this.n_trackBar.TabIndex = 14;
            this.n_trackBar.Value = 1;
            this.n_trackBar.Visible = false;
            this.n_trackBar.Scroll += new System.EventHandler(this.n_trackBar_Scroll);
            // 
            // n_label
            // 
            this.n_label.AutoSize = true;
            this.n_label.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.n_label.Location = new System.Drawing.Point(56, 628);
            this.n_label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.n_label.Name = "n_label";
            this.n_label.Size = new System.Drawing.Size(43, 38);
            this.n_label.TabIndex = 15;
            this.n_label.Text = "N";
            this.n_label.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(327, 628);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 38);
            this.label4.TabIndex = 16;
            // 
            // Save_Button
            // 
            this.Save_Button.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Save_Button.Location = new System.Drawing.Point(1924, 750);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(288, 90);
            this.Save_Button.TabIndex = 17;
            this.Save_Button.Text = "OK";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Reset_Button.Location = new System.Drawing.Point(2299, 750);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(215, 90);
            this.Reset_Button.TabIndex = 18;
            this.Reset_Button.Text = "Cancel";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // FormFFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2538, 884);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n_label);
            this.Controls.Add(this.n_trackBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radius_label);
            this.Controls.Add(this.radius_trackBar);
            this.Controls.Add(this.Inverse_FFT_Button);
            this.Controls.Add(this.FFT_Button);
            this.Controls.Add(this.PictureBox_FFT_2);
            this.Controls.Add(this.PictureBox_FFT_1);
            this.Controls.Add(this.PictureBox_FFT_0);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormFFT";
            this.Text = "FFT_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFFT_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_FFT_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_FFT_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_FFT_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius_trackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_FFT_0;
        private System.Windows.Forms.PictureBox PictureBox_FFT_1;
        private System.Windows.Forms.PictureBox PictureBox_FFT_2;
        private System.Windows.Forms.Button FFT_Button;
        private System.Windows.Forms.Button Inverse_FFT_Button;
        private System.Windows.Forms.TrackBar radius_trackBar;
        private System.Windows.Forms.RadioButton ideal_radio;
        private System.Windows.Forms.RadioButton butterworth_radio;
        private System.Windows.Forms.RadioButton gaussian_radio;
        private System.Windows.Forms.Label radius_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton lowpass_radio;
        private System.Windows.Forms.RadioButton hightpass_radio;
        private System.Windows.Forms.TrackBar n_trackBar;
        private System.Windows.Forms.Label n_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Reset_Button;
    }
}