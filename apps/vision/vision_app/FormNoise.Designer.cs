namespace app
{
    partial class FormNoise
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
            this.NormalMean_trackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Mean_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NormalStd_trackBar = new System.Windows.Forms.TrackBar();
            this.Std_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uniformLow_trackBar = new System.Windows.Forms.TrackBar();
            this.LowBound_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uniformHight_trackBar = new System.Windows.Forms.TrackBar();
            this.HightBound_label = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Normal_button = new System.Windows.Forms.Button();
            this.Unifrom_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NormalMean_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalStd_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniformLow_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniformHight_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // NormalMean_trackBar
            // 
            this.NormalMean_trackBar.LargeChange = 3;
            this.NormalMean_trackBar.Location = new System.Drawing.Point(32, 156);
            this.NormalMean_trackBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NormalMean_trackBar.Maximum = 30;
            this.NormalMean_trackBar.Minimum = 1;
            this.NormalMean_trackBar.Name = "NormalMean_trackBar";
            this.NormalMean_trackBar.Size = new System.Drawing.Size(542, 90);
            this.NormalMean_trackBar.TabIndex = 5;
            this.NormalMean_trackBar.Value = 1;
            this.NormalMean_trackBar.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mean";
            // 
            // Mean_label
            // 
            this.Mean_label.AutoSize = true;
            this.Mean_label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Mean_label.Location = new System.Drawing.Point(586, 156);
            this.Mean_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Mean_label.Name = "Mean_label";
            this.Mean_label.Size = new System.Drawing.Size(35, 38);
            this.Mean_label.TabIndex = 9;
            this.Mean_label.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Standard Deviation";
            // 
            // NormalStd_trackBar
            // 
            this.NormalStd_trackBar.LargeChange = 3;
            this.NormalStd_trackBar.Location = new System.Drawing.Point(32, 277);
            this.NormalStd_trackBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NormalStd_trackBar.Maximum = 30;
            this.NormalStd_trackBar.Minimum = 1;
            this.NormalStd_trackBar.Name = "NormalStd_trackBar";
            this.NormalStd_trackBar.Size = new System.Drawing.Size(542, 90);
            this.NormalStd_trackBar.TabIndex = 11;
            this.NormalStd_trackBar.Value = 1;
            this.NormalStd_trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Std_label
            // 
            this.Std_label.AutoSize = true;
            this.Std_label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Std_label.Location = new System.Drawing.Point(586, 277);
            this.Std_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Std_label.Name = "Std_label";
            this.Std_label.Size = new System.Drawing.Size(35, 38);
            this.Std_label.TabIndex = 12;
            this.Std_label.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(24, 456);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 38);
            this.label5.TabIndex = 14;
            this.label5.Text = "Low Bound";
            // 
            // uniformLow_trackBar
            // 
            this.uniformLow_trackBar.LargeChange = 3;
            this.uniformLow_trackBar.Location = new System.Drawing.Point(24, 502);
            this.uniformLow_trackBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uniformLow_trackBar.Maximum = 30;
            this.uniformLow_trackBar.Minimum = 1;
            this.uniformLow_trackBar.Name = "uniformLow_trackBar";
            this.uniformLow_trackBar.Size = new System.Drawing.Size(542, 90);
            this.uniformLow_trackBar.TabIndex = 15;
            this.uniformLow_trackBar.Value = 1;
            this.uniformLow_trackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // LowBound_label
            // 
            this.LowBound_label.AutoSize = true;
            this.LowBound_label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LowBound_label.Location = new System.Drawing.Point(578, 502);
            this.LowBound_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LowBound_label.Name = "LowBound_label";
            this.LowBound_label.Size = new System.Drawing.Size(35, 38);
            this.LowBound_label.TabIndex = 16;
            this.LowBound_label.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(24, 602);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 38);
            this.label7.TabIndex = 17;
            this.label7.Text = "High Bound";
            // 
            // uniformHight_trackBar
            // 
            this.uniformHight_trackBar.LargeChange = 3;
            this.uniformHight_trackBar.Location = new System.Drawing.Point(24, 671);
            this.uniformHight_trackBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uniformHight_trackBar.Maximum = 30;
            this.uniformHight_trackBar.Minimum = 1;
            this.uniformHight_trackBar.Name = "uniformHight_trackBar";
            this.uniformHight_trackBar.Size = new System.Drawing.Size(542, 90);
            this.uniformHight_trackBar.TabIndex = 18;
            this.uniformHight_trackBar.Value = 1;
            this.uniformHight_trackBar.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // HightBound_label
            // 
            this.HightBound_label.AutoSize = true;
            this.HightBound_label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HightBound_label.Location = new System.Drawing.Point(578, 671);
            this.HightBound_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HightBound_label.Name = "HightBound_label";
            this.HightBound_label.Size = new System.Drawing.Size(35, 38);
            this.HightBound_label.TabIndex = 19;
            this.HightBound_label.Text = "1";
            // 
            // Save_Button
            // 
            this.Save_Button.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Save_Button.Location = new System.Drawing.Point(38, 812);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(284, 73);
            this.Save_Button.TabIndex = 20;
            this.Save_Button.Text = "OK";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Reset_Button.Location = new System.Drawing.Point(356, 812);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(258, 73);
            this.Reset_Button.TabIndex = 21;
            this.Reset_Button.Text = "Cancel";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Normal_button
            // 
            this.Normal_button.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Normal_button.ForeColor = System.Drawing.Color.Red;
            this.Normal_button.Location = new System.Drawing.Point(31, 15);
            this.Normal_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Normal_button.Name = "Normal_button";
            this.Normal_button.Size = new System.Drawing.Size(421, 73);
            this.Normal_button.TabIndex = 22;
            this.Normal_button.Text = "Normal Distribution";
            this.Normal_button.UseVisualStyleBackColor = true;
            this.Normal_button.Click += new System.EventHandler(this.Normal_button_Click);
            // 
            // Unifrom_button
            // 
            this.Unifrom_button.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Unifrom_button.Location = new System.Drawing.Point(38, 364);
            this.Unifrom_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Unifrom_button.Name = "Unifrom_button";
            this.Unifrom_button.Size = new System.Drawing.Size(421, 73);
            this.Unifrom_button.TabIndex = 23;
            this.Unifrom_button.Text = "Unifrom Distribution";
            this.Unifrom_button.UseVisualStyleBackColor = true;
            this.Unifrom_button.Click += new System.EventHandler(this.Unifrom_button_Click);
            // 
            // FormNoise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(686, 958);
            this.Controls.Add(this.Unifrom_button);
            this.Controls.Add(this.Normal_button);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.HightBound_label);
            this.Controls.Add(this.uniformHight_trackBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LowBound_label);
            this.Controls.Add(this.uniformLow_trackBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Std_label);
            this.Controls.Add(this.NormalStd_trackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mean_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NormalMean_trackBar);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormNoise";
            this.Text = "Noise";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNoise_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.NormalMean_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalStd_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniformLow_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniformHight_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar NormalMean_trackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mean_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar NormalStd_trackBar;
        private System.Windows.Forms.Label Std_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar uniformLow_trackBar;
        private System.Windows.Forms.Label LowBound_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar uniformHight_trackBar;
        private System.Windows.Forms.Label HightBound_label;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Normal_button;
        private System.Windows.Forms.Button Unifrom_button;
    }
}