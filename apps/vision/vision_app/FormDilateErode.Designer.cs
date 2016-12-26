namespace app
{
    partial class FormDilateErode
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
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.button_dilate = new System.Windows.Forms.Button();
            this.button_erode = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ellipse_radio = new System.Windows.Forms.RadioButton();
            this.cross_radio = new System.Windows.Forms.RadioButton();
            this.rectangle_radio = new System.Windows.Forms.RadioButton();
            this.Weight_label = new System.Windows.Forms.Label();
            this.Height_label = new System.Windows.Forms.Label();
            this.Weight_trackBar = new System.Windows.Forms.TrackBar();
            this.element = new System.Windows.Forms.Button();
            this.Height_trackBar = new System.Windows.Forms.TrackBar();
            this.button_Weight = new System.Windows.Forms.Button();
            this.button_height = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(646, 658);
            this.button_save.Margin = new System.Windows.Forms.Padding(6);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(270, 79);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "OK";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.button_dilate);
            this.groupBox1.Controls.Add(this.button_erode);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1190, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(902, 44);
            this.button_close.Margin = new System.Windows.Forms.Padding(6);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(240, 83);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_open.Location = new System.Drawing.Point(622, 44);
            this.button_open.Margin = new System.Windows.Forms.Padding(6);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(240, 83);
            this.button_open.TabIndex = 2;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_dilate
            // 
            this.button_dilate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dilate.ForeColor = System.Drawing.Color.Red;
            this.button_dilate.Location = new System.Drawing.Point(52, 44);
            this.button_dilate.Margin = new System.Windows.Forms.Padding(6);
            this.button_dilate.Name = "button_dilate";
            this.button_dilate.Size = new System.Drawing.Size(240, 83);
            this.button_dilate.TabIndex = 0;
            this.button_dilate.Text = "Dilate";
            this.button_dilate.UseVisualStyleBackColor = true;
            this.button_dilate.Click += new System.EventHandler(this.button_dilate_Click);
            // 
            // button_erode
            // 
            this.button_erode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_erode.Location = new System.Drawing.Point(330, 44);
            this.button_erode.Margin = new System.Windows.Forms.Padding(6);
            this.button_erode.Name = "button_erode";
            this.button_erode.Size = new System.Drawing.Size(240, 83);
            this.button_erode.TabIndex = 1;
            this.button_erode.Text = "Erode";
            this.button_erode.UseVisualStyleBackColor = true;
            this.button_erode.Click += new System.EventHandler(this.button_erode_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ellipse_radio);
            this.groupBox2.Controls.Add(this.cross_radio);
            this.groupBox2.Controls.Add(this.rectangle_radio);
            this.groupBox2.Controls.Add(this.Weight_label);
            this.groupBox2.Controls.Add(this.Height_label);
            this.groupBox2.Controls.Add(this.Weight_trackBar);
            this.groupBox2.Controls.Add(this.element);
            this.groupBox2.Controls.Add(this.Height_trackBar);
            this.groupBox2.Controls.Add(this.button_Weight);
            this.groupBox2.Controls.Add(this.button_height);
            this.groupBox2.Location = new System.Drawing.Point(24, 202);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1190, 421);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // ellipse_radio
            // 
            this.ellipse_radio.AutoSize = true;
            this.ellipse_radio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ellipse_radio.Location = new System.Drawing.Point(830, 75);
            this.ellipse_radio.Margin = new System.Windows.Forms.Padding(6);
            this.ellipse_radio.Name = "ellipse_radio";
            this.ellipse_radio.Size = new System.Drawing.Size(131, 43);
            this.ellipse_radio.TabIndex = 11;
            this.ellipse_radio.TabStop = true;
            this.ellipse_radio.Text = "Ellipse";
            this.ellipse_radio.UseVisualStyleBackColor = true;
            this.ellipse_radio.CheckedChanged += new System.EventHandler(this.ellipse_radio_CheckedChanged);
            // 
            // cross_radio
            // 
            this.cross_radio.AutoSize = true;
            this.cross_radio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cross_radio.Location = new System.Drawing.Point(622, 75);
            this.cross_radio.Margin = new System.Windows.Forms.Padding(6);
            this.cross_radio.Name = "cross_radio";
            this.cross_radio.Size = new System.Drawing.Size(118, 43);
            this.cross_radio.TabIndex = 10;
            this.cross_radio.TabStop = true;
            this.cross_radio.Text = "Cross";
            this.cross_radio.UseVisualStyleBackColor = true;
            this.cross_radio.CheckedChanged += new System.EventHandler(this.cross_radio_CheckedChanged);
            // 
            // rectangle_radio
            // 
            this.rectangle_radio.AutoSize = true;
            this.rectangle_radio.Checked = true;
            this.rectangle_radio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectangle_radio.Location = new System.Drawing.Point(360, 75);
            this.rectangle_radio.Margin = new System.Windows.Forms.Padding(6);
            this.rectangle_radio.Name = "rectangle_radio";
            this.rectangle_radio.Size = new System.Drawing.Size(175, 43);
            this.rectangle_radio.TabIndex = 9;
            this.rectangle_radio.TabStop = true;
            this.rectangle_radio.Text = "Rectangle";
            this.rectangle_radio.UseVisualStyleBackColor = true;
            this.rectangle_radio.CheckedChanged += new System.EventHandler(this.rectangle_radio_CheckedChanged);
            // 
            // Weight_label
            // 
            this.Weight_label.AutoSize = true;
            this.Weight_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight_label.Location = new System.Drawing.Point(1076, 323);
            this.Weight_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Weight_label.Name = "Weight_label";
            this.Weight_label.Size = new System.Drawing.Size(43, 51);
            this.Weight_label.TabIndex = 8;
            this.Weight_label.Text = "3";
            // 
            // Height_label
            // 
            this.Height_label.AutoSize = true;
            this.Height_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height_label.Location = new System.Drawing.Point(1076, 194);
            this.Height_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Height_label.Name = "Height_label";
            this.Height_label.Size = new System.Drawing.Size(43, 51);
            this.Height_label.TabIndex = 7;
            this.Height_label.Text = "3";
            // 
            // Weight_trackBar
            // 
            this.Weight_trackBar.LargeChange = 3;
            this.Weight_trackBar.Location = new System.Drawing.Point(330, 323);
            this.Weight_trackBar.Margin = new System.Windows.Forms.Padding(6);
            this.Weight_trackBar.Maximum = 30;
            this.Weight_trackBar.Minimum = 1;
            this.Weight_trackBar.Name = "Weight_trackBar";
            this.Weight_trackBar.Size = new System.Drawing.Size(692, 90);
            this.Weight_trackBar.TabIndex = 5;
            this.Weight_trackBar.Value = 1;
            this.Weight_trackBar.Scroll += new System.EventHandler(this.Weight_trackBar_Scroll);
            // 
            // element
            // 
            this.element.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.element.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.element.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.element.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.element.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.element.Location = new System.Drawing.Point(26, 44);
            this.element.Margin = new System.Windows.Forms.Padding(6);
            this.element.Name = "element";
            this.element.Size = new System.Drawing.Size(266, 106);
            this.element.TabIndex = 2;
            this.element.Text = "Element";
            this.element.UseVisualStyleBackColor = true;
            // 
            // Height_trackBar
            // 
            this.Height_trackBar.LargeChange = 3;
            this.Height_trackBar.Location = new System.Drawing.Point(330, 194);
            this.Height_trackBar.Margin = new System.Windows.Forms.Padding(6);
            this.Height_trackBar.Maximum = 30;
            this.Height_trackBar.Minimum = 1;
            this.Height_trackBar.Name = "Height_trackBar";
            this.Height_trackBar.Size = new System.Drawing.Size(692, 90);
            this.Height_trackBar.TabIndex = 4;
            this.Height_trackBar.Value = 1;
            this.Height_trackBar.Scroll += new System.EventHandler(this.Height_trackBar_Scroll);
            // 
            // button_Weight
            // 
            this.button_Weight.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Weight.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_Weight.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Weight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Weight.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Weight.Location = new System.Drawing.Point(38, 310);
            this.button_Weight.Margin = new System.Windows.Forms.Padding(6);
            this.button_Weight.Name = "button_Weight";
            this.button_Weight.Size = new System.Drawing.Size(240, 83);
            this.button_Weight.TabIndex = 1;
            this.button_Weight.Text = "Weight";
            this.button_Weight.UseVisualStyleBackColor = true;
            // 
            // button_height
            // 
            this.button_height.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_height.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_height.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_height.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_height.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_height.Location = new System.Drawing.Point(38, 181);
            this.button_height.Margin = new System.Windows.Forms.Padding(6);
            this.button_height.Name = "button_height";
            this.button_height.Size = new System.Drawing.Size(240, 83);
            this.button_height.TabIndex = 0;
            this.button_height.Text = "Height";
            this.button_height.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(944, 658);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(6);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(270, 79);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // FormDilateErode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1244, 790);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_save);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDilateErode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dilate_Erode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDilateErode_FormClosed);
            this.Load += new System.EventHandler(this.Dilate_Erode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar Weight_trackBar;
        private System.Windows.Forms.TrackBar Height_trackBar;
        private System.Windows.Forms.Label Weight_label;
        private System.Windows.Forms.Label Height_label;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_dilate;
        private System.Windows.Forms.Button button_erode;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.RadioButton ellipse_radio;
        private System.Windows.Forms.RadioButton cross_radio;
        private System.Windows.Forms.RadioButton rectangle_radio;
        private System.Windows.Forms.Button element;
        private System.Windows.Forms.Button button_Weight;
        private System.Windows.Forms.Button button_height;
    }
}