namespace app
{
    partial class Basic_Control_Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.ConvertToGray_Button = new System.Windows.Forms.Button();
            this.Resize_GroupBox = new System.Windows.Forms.GroupBox();
            this.Resize_Height_Textbox = new System.Windows.Forms.TextBox();
            this.Resize_Width_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lockRatio = new System.Windows.Forms.CheckBox();
            this.Resize_Button = new System.Windows.Forms.Button();
            this.ColorSpace_GroupBox = new System.Windows.Forms.GroupBox();
            this.YCrCb_Button = new System.Windows.Forms.Button();
            this.LUV_Button = new System.Windows.Forms.Button();
            this.Lab_Button = new System.Windows.Forms.Button();
            this.HLS_Button = new System.Windows.Forms.Button();
            this.XYZ_Button = new System.Windows.Forms.Button();
            this.RGB_Button = new System.Windows.Forms.Button();
            this.HSV_Button = new System.Windows.Forms.Button();
            this.ColorSpace_Var1_Label = new System.Windows.Forms.Label();
            this.ColorSpace_Var2_Label = new System.Windows.Forms.Label();
            this.ColorSpace_Var3_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorSpacePreview3 = new System.Windows.Forms.PictureBox();
            this.ColorSpacePreview2 = new System.Windows.Forms.PictureBox();
            this.ColorSpacePreview1 = new System.Windows.Forms.PictureBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Resize_GroupBox.SuspendLayout();
            this.ColorSpace_GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSpacePreview3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSpacePreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSpacePreview1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Equilzation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Equilzation_Click);
            // 
            // ConvertToGray_Button
            // 
            this.ConvertToGray_Button.Location = new System.Drawing.Point(185, 22);
            this.ConvertToGray_Button.Name = "ConvertToGray_Button";
            this.ConvertToGray_Button.Size = new System.Drawing.Size(115, 23);
            this.ConvertToGray_Button.TabIndex = 1;
            this.ConvertToGray_Button.Text = "Covert To Gray";
            this.ConvertToGray_Button.UseVisualStyleBackColor = true;
            this.ConvertToGray_Button.Click += new System.EventHandler(this.ConvertToGray_Click);
            // 
            // Resize_GroupBox
            // 
            this.Resize_GroupBox.Controls.Add(this.Resize_Height_Textbox);
            this.Resize_GroupBox.Controls.Add(this.Resize_Width_Textbox);
            this.Resize_GroupBox.Controls.Add(this.label2);
            this.Resize_GroupBox.Controls.Add(this.label1);
            this.Resize_GroupBox.Controls.Add(this.lockRatio);
            this.Resize_GroupBox.Controls.Add(this.Resize_Button);
            this.Resize_GroupBox.Location = new System.Drawing.Point(36, 51);
            this.Resize_GroupBox.Name = "Resize_GroupBox";
            this.Resize_GroupBox.Size = new System.Drawing.Size(295, 97);
            this.Resize_GroupBox.TabIndex = 2;
            this.Resize_GroupBox.TabStop = false;
            this.Resize_GroupBox.Text = "Resize";
            this.Resize_GroupBox.Visible = false;
            // 
            // Resize_Height_Textbox
            // 
            this.Resize_Height_Textbox.Location = new System.Drawing.Point(167, 33);
            this.Resize_Height_Textbox.Name = "Resize_Height_Textbox";
            this.Resize_Height_Textbox.ReadOnly = true;
            this.Resize_Height_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Resize_Height_Textbox.TabIndex = 9;
            // 
            // Resize_Width_Textbox
            // 
            this.Resize_Width_Textbox.Location = new System.Drawing.Point(21, 33);
            this.Resize_Width_Textbox.Name = "Resize_Width_Textbox";
            this.Resize_Width_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Resize_Width_Textbox.TabIndex = 8;
            this.Resize_Width_Textbox.TextChanged += new System.EventHandler(this.Resize_Width_Textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Width";
            // 
            // lockRatio
            // 
            this.lockRatio.AutoSize = true;
            this.lockRatio.Checked = true;
            this.lockRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lockRatio.Location = new System.Drawing.Point(36, 65);
            this.lockRatio.Name = "lockRatio";
            this.lockRatio.Size = new System.Drawing.Size(76, 16);
            this.lockRatio.TabIndex = 5;
            this.lockRatio.Text = "Lock Ratio";
            this.lockRatio.UseVisualStyleBackColor = true;
            this.lockRatio.CheckedChanged += new System.EventHandler(this.lockRatio_checkBox_CheckedChanged);
            // 
            // Resize_Button
            // 
            this.Resize_Button.Location = new System.Drawing.Point(157, 61);
            this.Resize_Button.Name = "Resize_Button";
            this.Resize_Button.Size = new System.Drawing.Size(115, 23);
            this.Resize_Button.TabIndex = 4;
            this.Resize_Button.Text = "Resize";
            this.Resize_Button.UseVisualStyleBackColor = true;
            this.Resize_Button.Click += new System.EventHandler(this.Resize_Button_Click);
            // 
            // ColorSpace_GroupBox
            // 
            this.ColorSpace_GroupBox.Controls.Add(this.YCrCb_Button);
            this.ColorSpace_GroupBox.Controls.Add(this.LUV_Button);
            this.ColorSpace_GroupBox.Controls.Add(this.Lab_Button);
            this.ColorSpace_GroupBox.Controls.Add(this.HLS_Button);
            this.ColorSpace_GroupBox.Controls.Add(this.XYZ_Button);
            this.ColorSpace_GroupBox.Controls.Add(this.RGB_Button);
            this.ColorSpace_GroupBox.Controls.Add(this.HSV_Button);
            this.ColorSpace_GroupBox.Location = new System.Drawing.Point(349, 13);
            this.ColorSpace_GroupBox.Name = "ColorSpace_GroupBox";
            this.ColorSpace_GroupBox.Size = new System.Drawing.Size(414, 135);
            this.ColorSpace_GroupBox.TabIndex = 3;
            this.ColorSpace_GroupBox.TabStop = false;
            this.ColorSpace_GroupBox.Text = "Color Space";
            // 
            // YCrCb_Button
            // 
            this.YCrCb_Button.Location = new System.Drawing.Point(20, 100);
            this.YCrCb_Button.Name = "YCrCb_Button";
            this.YCrCb_Button.Size = new System.Drawing.Size(115, 23);
            this.YCrCb_Button.TabIndex = 14;
            this.YCrCb_Button.Text = "YCrCb";
            this.YCrCb_Button.UseVisualStyleBackColor = true;
            this.YCrCb_Button.Click += new System.EventHandler(this.YCrCb_Button_Click);
            // 
            // LUV_Button
            // 
            this.LUV_Button.Location = new System.Drawing.Point(279, 58);
            this.LUV_Button.Name = "LUV_Button";
            this.LUV_Button.Size = new System.Drawing.Size(115, 23);
            this.LUV_Button.TabIndex = 13;
            this.LUV_Button.Text = "LUV";
            this.LUV_Button.UseVisualStyleBackColor = true;
            this.LUV_Button.Click += new System.EventHandler(this.LUV_Button_Click);
            // 
            // Lab_Button
            // 
            this.Lab_Button.Location = new System.Drawing.Point(148, 58);
            this.Lab_Button.Name = "Lab_Button";
            this.Lab_Button.Size = new System.Drawing.Size(115, 23);
            this.Lab_Button.TabIndex = 12;
            this.Lab_Button.Text = "Lab";
            this.Lab_Button.UseVisualStyleBackColor = true;
            this.Lab_Button.Click += new System.EventHandler(this.Lab_Button_Click);
            // 
            // HLS_Button
            // 
            this.HLS_Button.Location = new System.Drawing.Point(20, 58);
            this.HLS_Button.Name = "HLS_Button";
            this.HLS_Button.Size = new System.Drawing.Size(115, 23);
            this.HLS_Button.TabIndex = 11;
            this.HLS_Button.Text = "HLS";
            this.HLS_Button.UseVisualStyleBackColor = true;
            this.HLS_Button.Click += new System.EventHandler(this.HLS_Button_Click);
            // 
            // XYZ_Button
            // 
            this.XYZ_Button.Location = new System.Drawing.Point(279, 21);
            this.XYZ_Button.Name = "XYZ_Button";
            this.XYZ_Button.Size = new System.Drawing.Size(115, 23);
            this.XYZ_Button.TabIndex = 10;
            this.XYZ_Button.Text = "XYZ";
            this.XYZ_Button.UseVisualStyleBackColor = true;
            this.XYZ_Button.Click += new System.EventHandler(this.XYZ_Button_Click);
            // 
            // RGB_Button
            // 
            this.RGB_Button.Location = new System.Drawing.Point(20, 21);
            this.RGB_Button.Name = "RGB_Button";
            this.RGB_Button.Size = new System.Drawing.Size(115, 23);
            this.RGB_Button.TabIndex = 9;
            this.RGB_Button.Text = "RGB";
            this.RGB_Button.UseVisualStyleBackColor = true;
            this.RGB_Button.Click += new System.EventHandler(this.RGB_Button_Click);
            // 
            // HSV_Button
            // 
            this.HSV_Button.Location = new System.Drawing.Point(148, 21);
            this.HSV_Button.Name = "HSV_Button";
            this.HSV_Button.Size = new System.Drawing.Size(115, 23);
            this.HSV_Button.TabIndex = 8;
            this.HSV_Button.Text = "HSV";
            this.HSV_Button.UseVisualStyleBackColor = true;
            this.HSV_Button.Click += new System.EventHandler(this.HSV_Button_Click);
            // 
            // ColorSpace_Var1_Label
            // 
            this.ColorSpace_Var1_Label.AutoSize = true;
            this.ColorSpace_Var1_Label.Location = new System.Drawing.Point(121, 210);
            this.ColorSpace_Var1_Label.Name = "ColorSpace_Var1_Label";
            this.ColorSpace_Var1_Label.Size = new System.Drawing.Size(28, 12);
            this.ColorSpace_Var1_Label.TabIndex = 4;
            this.ColorSpace_Var1_Label.Text = "Var1";
            // 
            // ColorSpace_Var2_Label
            // 
            this.ColorSpace_Var2_Label.AutoSize = true;
            this.ColorSpace_Var2_Label.Location = new System.Drawing.Point(359, 210);
            this.ColorSpace_Var2_Label.Name = "ColorSpace_Var2_Label";
            this.ColorSpace_Var2_Label.Size = new System.Drawing.Size(28, 12);
            this.ColorSpace_Var2_Label.TabIndex = 5;
            this.ColorSpace_Var2_Label.Text = "Var2";
            // 
            // ColorSpace_Var3_Label
            // 
            this.ColorSpace_Var3_Label.AutoSize = true;
            this.ColorSpace_Var3_Label.Location = new System.Drawing.Point(609, 210);
            this.ColorSpace_Var3_Label.Name = "ColorSpace_Var3_Label";
            this.ColorSpace_Var3_Label.Size = new System.Drawing.Size(28, 12);
            this.ColorSpace_Var3_Label.TabIndex = 6;
            this.ColorSpace_Var3_Label.Text = "Var3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColorSpacePreview3);
            this.groupBox1.Controls.Add(this.ColorSpacePreview2);
            this.groupBox1.Controls.Add(this.ColorSpacePreview1);
            this.groupBox1.Controls.Add(this.ColorSpace_Var1_Label);
            this.groupBox1.Controls.Add(this.ColorSpace_Var3_Label);
            this.groupBox1.Controls.Add(this.ColorSpace_Var2_Label);
            this.groupBox1.Location = new System.Drawing.Point(8, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 237);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Space Preview";
            // 
            // ColorSpacePreview3
            // 
            this.ColorSpacePreview3.Location = new System.Drawing.Point(504, 21);
            this.ColorSpacePreview3.Name = "ColorSpacePreview3";
            this.ColorSpacePreview3.Size = new System.Drawing.Size(240, 180);
            this.ColorSpacePreview3.TabIndex = 9;
            this.ColorSpacePreview3.TabStop = false;
            this.ColorSpacePreview3.Click += new System.EventHandler(this.ColorSpacePreview3_Click);
            // 
            // ColorSpacePreview2
            // 
            this.ColorSpacePreview2.Location = new System.Drawing.Point(258, 21);
            this.ColorSpacePreview2.Name = "ColorSpacePreview2";
            this.ColorSpacePreview2.Size = new System.Drawing.Size(240, 180);
            this.ColorSpacePreview2.TabIndex = 8;
            this.ColorSpacePreview2.TabStop = false;
            this.ColorSpacePreview2.Click += new System.EventHandler(this.ColorSpacePreview2_Click);
            // 
            // ColorSpacePreview1
            // 
            this.ColorSpacePreview1.Location = new System.Drawing.Point(12, 21);
            this.ColorSpacePreview1.Name = "ColorSpacePreview1";
            this.ColorSpacePreview1.Size = new System.Drawing.Size(240, 180);
            this.ColorSpacePreview1.TabIndex = 7;
            this.ColorSpacePreview1.TabStop = false;
            this.ColorSpacePreview1.Click += new System.EventHandler(this.ColorSpacePreview1_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Save_Button.Location = new System.Drawing.Point(467, 423);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(134, 33);
            this.Save_Button.TabIndex = 8;
            this.Save_Button.Text = "OK";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Reset_Button.Location = new System.Drawing.Point(628, 423);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(134, 33);
            this.Reset_Button.TabIndex = 9;
            this.Reset_Button.Text = "Cancel";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Basic_Control_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(796, 475);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ColorSpace_GroupBox);
            this.Controls.Add(this.Resize_GroupBox);
            this.Controls.Add(this.ConvertToGray_Button);
            this.Controls.Add(this.button1);
            this.Name = "Basic_Control_Form";
            this.Text = "Basic Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Basic_Control_Form_FormClosed);
            this.Resize_GroupBox.ResumeLayout(false);
            this.Resize_GroupBox.PerformLayout();
            this.ColorSpace_GroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSpacePreview3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSpacePreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSpacePreview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ConvertToGray_Button;
        private System.Windows.Forms.GroupBox Resize_GroupBox;
        private System.Windows.Forms.TextBox Resize_Height_Textbox;
        private System.Windows.Forms.TextBox Resize_Width_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox lockRatio;
        private System.Windows.Forms.Button Resize_Button;
        private System.Windows.Forms.GroupBox ColorSpace_GroupBox;
        private System.Windows.Forms.Button YCrCb_Button;
        private System.Windows.Forms.Button LUV_Button;
        private System.Windows.Forms.Button Lab_Button;
        private System.Windows.Forms.Button HLS_Button;
        private System.Windows.Forms.Button XYZ_Button;
        private System.Windows.Forms.Button RGB_Button;
        private System.Windows.Forms.Button HSV_Button;
        private System.Windows.Forms.Label ColorSpace_Var1_Label;
        private System.Windows.Forms.Label ColorSpace_Var2_Label;
        private System.Windows.Forms.Label ColorSpace_Var3_Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ColorSpacePreview3;
        private System.Windows.Forms.PictureBox ColorSpacePreview2;
        private System.Windows.Forms.PictureBox ColorSpacePreview1;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Reset_Button;

    }
}