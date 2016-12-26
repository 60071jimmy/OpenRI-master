namespace app
{
    partial class FormWavelet
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
            this.Haar_Wavelet_Button = new System.Windows.Forms.Button();
            this.Inverse_Haar_Wavelet_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Wavelet_Track_Bar = new System.Windows.Forms.TrackBar();
            this.Wavelet_Label = new System.Windows.Forms.Label();
            this.Haar_Button = new System.Windows.Forms.RadioButton();
            this.SYM_Button = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Low_Filter_trackBar = new System.Windows.Forms.TrackBar();
            this.High_Filter_trackBar = new System.Windows.Forms.TrackBar();
            this.lowPass_label = new System.Windows.Forms.Label();
            this.hightPass_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Wavelet_Track_Bar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Low_Filter_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.High_Filter_trackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Haar_Wavelet_Button
            // 
            this.Haar_Wavelet_Button.Location = new System.Drawing.Point(63, 42);
            this.Haar_Wavelet_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Haar_Wavelet_Button.Name = "Haar_Wavelet_Button";
            this.Haar_Wavelet_Button.Size = new System.Drawing.Size(267, 46);
            this.Haar_Wavelet_Button.TabIndex = 0;
            this.Haar_Wavelet_Button.Text = "Haar Wavelet";
            this.Haar_Wavelet_Button.UseVisualStyleBackColor = true;
            this.Haar_Wavelet_Button.Click += new System.EventHandler(this.Haar_Wavelet_Button_Click);
            // 
            // Inverse_Haar_Wavelet_Button
            // 
            this.Inverse_Haar_Wavelet_Button.Location = new System.Drawing.Point(59, 84);
            this.Inverse_Haar_Wavelet_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Inverse_Haar_Wavelet_Button.Name = "Inverse_Haar_Wavelet_Button";
            this.Inverse_Haar_Wavelet_Button.Size = new System.Drawing.Size(267, 46);
            this.Inverse_Haar_Wavelet_Button.TabIndex = 1;
            this.Inverse_Haar_Wavelet_Button.Text = "Wavelet Filtering";
            this.Inverse_Haar_Wavelet_Button.UseVisualStyleBackColor = true;
            this.Inverse_Haar_Wavelet_Button.Click += new System.EventHandler(this.Inverse_Haar_Wavelet_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(988, 406);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(267, 46);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.Text = "OK";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(988, 464);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(267, 46);
            this.Reset_Button.TabIndex = 8;
            this.Reset_Button.Text = "Cancel";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Wavelet_Track_Bar
            // 
            this.Wavelet_Track_Bar.LargeChange = 1;
            this.Wavelet_Track_Bar.Location = new System.Drawing.Point(41, 156);
            this.Wavelet_Track_Bar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Wavelet_Track_Bar.Maximum = 5;
            this.Wavelet_Track_Bar.Minimum = 1;
            this.Wavelet_Track_Bar.Name = "Wavelet_Track_Bar";
            this.Wavelet_Track_Bar.Size = new System.Drawing.Size(267, 90);
            this.Wavelet_Track_Bar.TabIndex = 9;
            this.Wavelet_Track_Bar.Value = 1;
            this.Wavelet_Track_Bar.Scroll += new System.EventHandler(this.Wavelet_Track_Bar_Scroll);
            // 
            // Wavelet_Label
            // 
            this.Wavelet_Label.AutoSize = true;
            this.Wavelet_Label.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Wavelet_Label.Location = new System.Drawing.Point(319, 156);
            this.Wavelet_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Wavelet_Label.Name = "Wavelet_Label";
            this.Wavelet_Label.Size = new System.Drawing.Size(35, 38);
            this.Wavelet_Label.TabIndex = 10;
            this.Wavelet_Label.Text = "1";
            // 
            // Haar_Button
            // 
            this.Haar_Button.AutoSize = true;
            this.Haar_Button.Checked = true;
            this.Haar_Button.Location = new System.Drawing.Point(63, 112);
            this.Haar_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Haar_Button.Name = "Haar_Button";
            this.Haar_Button.Size = new System.Drawing.Size(85, 28);
            this.Haar_Button.TabIndex = 11;
            this.Haar_Button.TabStop = true;
            this.Haar_Button.Text = "Haar";
            this.Haar_Button.UseVisualStyleBackColor = true;
            this.Haar_Button.CheckedChanged += new System.EventHandler(this.Haar_Button_CheckedChanged);
            // 
            // SYM_Button
            // 
            this.SYM_Button.AutoSize = true;
            this.SYM_Button.Location = new System.Drawing.Point(228, 112);
            this.SYM_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SYM_Button.Name = "SYM_Button";
            this.SYM_Button.Size = new System.Drawing.Size(90, 28);
            this.SYM_Button.TabIndex = 12;
            this.SYM_Button.TabStop = true;
            this.SYM_Button.Text = "SYM";
            this.SYM_Button.UseVisualStyleBackColor = true;
            this.SYM_Button.CheckedChanged += new System.EventHandler(this.SYM_Button_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Wavelet_Track_Bar);
            this.groupBox1.Controls.Add(this.SYM_Button);
            this.groupBox1.Controls.Add(this.Haar_Wavelet_Button);
            this.groupBox1.Controls.Add(this.Haar_Button);
            this.groupBox1.Controls.Add(this.Wavelet_Label);
            this.groupBox1.Location = new System.Drawing.Point(52, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(386, 296);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transform";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Inverse_Haar_Wavelet_Button);
            this.groupBox2.Location = new System.Drawing.Point(882, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Size = new System.Drawing.Size(373, 296);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtering";
            // 
            // Low_Filter_trackBar
            // 
            this.Low_Filter_trackBar.LargeChange = 1;
            this.Low_Filter_trackBar.Location = new System.Drawing.Point(52, 84);
            this.Low_Filter_trackBar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Low_Filter_trackBar.Maximum = 100;
            this.Low_Filter_trackBar.Minimum = 2;
            this.Low_Filter_trackBar.Name = "Low_Filter_trackBar";
            this.Low_Filter_trackBar.Size = new System.Drawing.Size(225, 90);
            this.Low_Filter_trackBar.TabIndex = 15;
            this.Low_Filter_trackBar.Value = 2;
            this.Low_Filter_trackBar.Scroll += new System.EventHandler(this.Low_Filter_trackBar_Scroll);
            // 
            // High_Filter_trackBar
            // 
            this.High_Filter_trackBar.LargeChange = 1;
            this.High_Filter_trackBar.Location = new System.Drawing.Point(52, 192);
            this.High_Filter_trackBar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.High_Filter_trackBar.Maximum = 100;
            this.High_Filter_trackBar.Minimum = 2;
            this.High_Filter_trackBar.Name = "High_Filter_trackBar";
            this.High_Filter_trackBar.Size = new System.Drawing.Size(225, 90);
            this.High_Filter_trackBar.TabIndex = 16;
            this.High_Filter_trackBar.Value = 2;
            this.High_Filter_trackBar.Scroll += new System.EventHandler(this.High_Filter_trackBar_Scroll);
            // 
            // lowPass_label
            // 
            this.lowPass_label.AutoSize = true;
            this.lowPass_label.Location = new System.Drawing.Point(290, 88);
            this.lowPass_label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lowPass_label.Name = "lowPass_label";
            this.lowPass_label.Size = new System.Drawing.Size(21, 24);
            this.lowPass_label.TabIndex = 17;
            this.lowPass_label.Text = "2";
            // 
            // hightPass_label
            // 
            this.hightPass_label.AutoSize = true;
            this.hightPass_label.Location = new System.Drawing.Point(290, 198);
            this.hightPass_label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.hightPass_label.Name = "hightPass_label";
            this.hightPass_label.Size = new System.Drawing.Size(21, 24);
            this.hightPass_label.TabIndex = 18;
            this.hightPass_label.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Low Pass Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "High Pass Filter";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.High_Filter_trackBar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Low_Filter_trackBar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lowPass_label);
            this.groupBox3.Controls.Add(this.hightPass_label);
            this.groupBox3.Location = new System.Drawing.Point(490, 76);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox3.Size = new System.Drawing.Size(355, 296);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wavelet Filter";
            // 
            // FormWavelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1281, 544);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Save_Button);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormWavelet";
            this.Text = "Wavelet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWavelet_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Wavelet_Track_Bar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Low_Filter_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.High_Filter_trackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Haar_Wavelet_Button;
        private System.Windows.Forms.Button Inverse_Haar_Wavelet_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.TrackBar Wavelet_Track_Bar;
        private System.Windows.Forms.Label Wavelet_Label;
        private System.Windows.Forms.RadioButton Haar_Button;
        private System.Windows.Forms.RadioButton SYM_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar Low_Filter_trackBar;
        private System.Windows.Forms.TrackBar High_Filter_trackBar;
        private System.Windows.Forms.Label lowPass_label;
        private System.Windows.Forms.Label hightPass_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}