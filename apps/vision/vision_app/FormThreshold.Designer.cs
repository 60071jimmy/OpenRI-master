namespace app
{
    partial class Threshold_Form
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
            this.Threshold_trackBar = new System.Windows.Forms.TrackBar();
            this.Threshold_Label = new System.Windows.Forms.Label();
            this.binary_radio = new System.Windows.Forms.RadioButton();
            this.binaryInv_radio = new System.Windows.Forms.RadioButton();
            this.truncate_radio = new System.Windows.Forms.RadioButton();
            this.toZero_radio = new System.Windows.Forms.RadioButton();
            this.toZeroInv_radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.otsu_button = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold_trackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Threshold_trackBar
            // 
            this.Threshold_trackBar.Location = new System.Drawing.Point(34, 79);
            this.Threshold_trackBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Threshold_trackBar.Maximum = 255;
            this.Threshold_trackBar.Name = "Threshold_trackBar";
            this.Threshold_trackBar.Size = new System.Drawing.Size(864, 90);
            this.Threshold_trackBar.TabIndex = 0;
            this.Threshold_trackBar.Scroll += new System.EventHandler(this.ThresholdValue_trackBar_Scroll);
            // 
            // Threshold_Label
            // 
            this.Threshold_Label.AutoSize = true;
            this.Threshold_Label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Threshold_Label.Location = new System.Drawing.Point(910, 79);
            this.Threshold_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Threshold_Label.Name = "Threshold_Label";
            this.Threshold_Label.Size = new System.Drawing.Size(35, 38);
            this.Threshold_Label.TabIndex = 1;
            this.Threshold_Label.Text = "0";
            // 
            // binary_radio
            // 
            this.binary_radio.AutoSize = true;
            this.binary_radio.Checked = true;
            this.binary_radio.Location = new System.Drawing.Point(48, 44);
            this.binary_radio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.binary_radio.Name = "binary_radio";
            this.binary_radio.Size = new System.Drawing.Size(206, 29);
            this.binary_radio.TabIndex = 2;
            this.binary_radio.TabStop = true;
            this.binary_radio.Text = "Threshold Binary";
            this.binary_radio.UseVisualStyleBackColor = true;
            this.binary_radio.CheckedChanged += new System.EventHandler(this.binary_radioButton_CheckedChanged);
            // 
            // binaryInv_radio
            // 
            this.binaryInv_radio.AutoSize = true;
            this.binaryInv_radio.Location = new System.Drawing.Point(354, 44);
            this.binaryInv_radio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.binaryInv_radio.Name = "binaryInv_radio";
            this.binaryInv_radio.Size = new System.Drawing.Size(295, 29);
            this.binaryInv_radio.TabIndex = 3;
            this.binaryInv_radio.Text = "Threshold Binary, Inverted";
            this.binaryInv_radio.UseVisualStyleBackColor = true;
            this.binaryInv_radio.CheckedChanged += new System.EventHandler(this.binaryInv_radioButton_CheckedChanged);
            // 
            // truncate_radio
            // 
            this.truncate_radio.AutoSize = true;
            this.truncate_radio.Location = new System.Drawing.Point(742, 44);
            this.truncate_radio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.truncate_radio.Name = "truncate_radio";
            this.truncate_radio.Size = new System.Drawing.Size(128, 29);
            this.truncate_radio.TabIndex = 4;
            this.truncate_radio.Text = "Truncate";
            this.truncate_radio.UseVisualStyleBackColor = true;
            this.truncate_radio.CheckedChanged += new System.EventHandler(this.truncate_radio_CheckedChanged);
            // 
            // toZero_radio
            // 
            this.toZero_radio.AutoSize = true;
            this.toZero_radio.Location = new System.Drawing.Point(48, 108);
            this.toZero_radio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.toZero_radio.Name = "toZero_radio";
            this.toZero_radio.Size = new System.Drawing.Size(213, 29);
            this.toZero_radio.TabIndex = 5;
            this.toZero_radio.Text = "Threshold to Zero";
            this.toZero_radio.UseVisualStyleBackColor = true;
            this.toZero_radio.CheckedChanged += new System.EventHandler(this.toZero_radio_CheckedChanged);
            // 
            // toZeroInv_radio
            // 
            this.toZeroInv_radio.AutoSize = true;
            this.toZeroInv_radio.Location = new System.Drawing.Point(354, 108);
            this.toZeroInv_radio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.toZeroInv_radio.Name = "toZeroInv_radio";
            this.toZeroInv_radio.Size = new System.Drawing.Size(302, 29);
            this.toZeroInv_radio.TabIndex = 6;
            this.toZeroInv_radio.Text = "Threshold to Zero, Inverted";
            this.toZeroInv_radio.UseVisualStyleBackColor = true;
            this.toZeroInv_radio.CheckedChanged += new System.EventHandler(this.toZeroInv_radio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.binary_radio);
            this.groupBox1.Controls.Add(this.toZeroInv_radio);
            this.groupBox1.Controls.Add(this.binaryInv_radio);
            this.groupBox1.Controls.Add(this.toZero_radio);
            this.groupBox1.Controls.Add(this.truncate_radio);
            this.groupBox1.Location = new System.Drawing.Point(34, 185);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(912, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threshold Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Threshold_trackBar);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.Threshold_Label);
            this.groupBox2.Location = new System.Drawing.Point(24, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(980, 383);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Normal Threshold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Threshold Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Neighborhood Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Weight";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.hScrollBar2);
            this.groupBox3.Controls.Add(this.hScrollBar1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(24, 565);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(980, 162);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adaptive Threshold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(864, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "3";
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.LargeChange = 5;
            this.hScrollBar2.Location = new System.Drawing.Point(498, 106);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(448, 18);
            this.hScrollBar2.TabIndex = 15;
            this.hScrollBar2.Value = 1;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 5;
            this.hScrollBar1.Location = new System.Drawing.Point(34, 104);
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(424, 18);
            this.hScrollBar1.TabIndex = 14;
            this.hScrollBar1.Value = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.otsu_button);
            this.groupBox4.Location = new System.Drawing.Point(26, 423);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(978, 129);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Otsu Threshold";
            // 
            // otsu_button
            // 
            this.otsu_button.Location = new System.Drawing.Point(32, 44);
            this.otsu_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.otsu_button.Name = "otsu_button";
            this.otsu_button.Size = new System.Drawing.Size(150, 48);
            this.otsu_button.TabIndex = 18;
            this.otsu_button.Text = "Process";
            this.otsu_button.UseVisualStyleBackColor = true;
            this.otsu_button.Click += new System.EventHandler(this.otsu_button_Click);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OK.Location = new System.Drawing.Point(444, 925);
            this.OK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(272, 69);
            this.OK.TabIndex = 18;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Status_Label.Location = new System.Drawing.Point(50, 790);
            this.Status_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(115, 38);
            this.Status_Label.TabIndex = 19;
            this.Status_Label.Text = "Status:";
            // 
            // Reset_Button
            // 
            this.Reset_Button.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Reset_Button.Location = new System.Drawing.Point(732, 925);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(272, 69);
            this.Reset_Button.TabIndex = 20;
            this.Reset_Button.Text = "Cancel";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Threshold_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1040, 781);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Threshold_Form";
            this.Text = "Threshold Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Threshold_Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Threshold_trackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Threshold_trackBar;
        private System.Windows.Forms.Label Threshold_Label;
        private System.Windows.Forms.RadioButton binary_radio;
        private System.Windows.Forms.RadioButton binaryInv_radio;
        private System.Windows.Forms.RadioButton truncate_radio;
        private System.Windows.Forms.RadioButton toZero_radio;
        private System.Windows.Forms.RadioButton toZeroInv_radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button otsu_button;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Button Reset_Button;
    }
}