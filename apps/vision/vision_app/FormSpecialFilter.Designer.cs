using System.Windows.Forms;

namespace app
{
    partial class FormSpecialFilter
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
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Sketch_button = new System.Windows.Forms.Button();
            this.Cartoon_button = new System.Windows.Forms.Button();
            this.Sculpture_button = new System.Windows.Forms.Button();
            this.GroundGlass_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Save_Button.Location = new System.Drawing.Point(44, 347);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(266, 94);
            this.Save_Button.TabIndex = 18;
            this.Save_Button.Text = "OK";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cancel_button.Location = new System.Drawing.Point(366, 347);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(6);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(266, 94);
            this.Cancel_button.TabIndex = 19;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Sketch_button
            // 
            this.Sketch_button.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sketch_button.Location = new System.Drawing.Point(44, 44);
            this.Sketch_button.Margin = new System.Windows.Forms.Padding(6);
            this.Sketch_button.Name = "Sketch_button";
            this.Sketch_button.Size = new System.Drawing.Size(266, 94);
            this.Sketch_button.TabIndex = 20;
            this.Sketch_button.Text = "Sketch";
            this.Sketch_button.UseVisualStyleBackColor = true;
            this.Sketch_button.Click += new System.EventHandler(this.Sketch_button_Click);
            // 
            // Cartoon_button
            // 
            this.Cartoon_button.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cartoon_button.Location = new System.Drawing.Point(380, 44);
            this.Cartoon_button.Margin = new System.Windows.Forms.Padding(6);
            this.Cartoon_button.Name = "Cartoon_button";
            this.Cartoon_button.Size = new System.Drawing.Size(266, 94);
            this.Cartoon_button.TabIndex = 21;
            this.Cartoon_button.Text = "Cartoon";
            this.Cartoon_button.UseVisualStyleBackColor = true;
            this.Cartoon_button.Click += new System.EventHandler(this.Cartoon_button_Click);
            // 
            // Sculpture_button
            // 
            this.Sculpture_button.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sculpture_button.Location = new System.Drawing.Point(44, 174);
            this.Sculpture_button.Margin = new System.Windows.Forms.Padding(6);
            this.Sculpture_button.Name = "Sculpture_button";
            this.Sculpture_button.Size = new System.Drawing.Size(266, 94);
            this.Sculpture_button.TabIndex = 22;
            this.Sculpture_button.Text = "Sculpture";
            this.Sculpture_button.UseVisualStyleBackColor = true;
            this.Sculpture_button.Click += new System.EventHandler(this.Sculpture_button_Click);
            // 
            // GroundGlass_button
            // 
            this.GroundGlass_button.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GroundGlass_button.Location = new System.Drawing.Point(380, 174);
            this.GroundGlass_button.Margin = new System.Windows.Forms.Padding(6);
            this.GroundGlass_button.Name = "GroundGlass_button";
            this.GroundGlass_button.Size = new System.Drawing.Size(266, 94);
            this.GroundGlass_button.TabIndex = 23;
            this.GroundGlass_button.Text = "GroundGlass";
            this.GroundGlass_button.UseVisualStyleBackColor = true;
            this.GroundGlass_button.Click += new System.EventHandler(this.GroundGlass_button_Click);
            // 
            // FormSpecialFilter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(708, 495);
            this.Controls.Add(this.GroundGlass_button);
            this.Controls.Add(this.Sculpture_button);
            this.Controls.Add(this.Cartoon_button);
            this.Controls.Add(this.Sketch_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_Button);
            this.Name = "FormSpecialFilter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSpecialFilter_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Save_Button;
        private Button Sketch_button;
        private Button Cartoon_button;
        private Button Sculpture_button;
        private Button GroundGlass_button;
        private Button Cancel_button;
    }
}