namespace ur_app
{
    partial class FormTeach
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
            this.TeachList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeachList
            // 
            this.TeachList.FormattingEnabled = true;
            this.TeachList.ItemHeight = 12;
            this.TeachList.Location = new System.Drawing.Point(20, 28);
            this.TeachList.Name = "TeachList";
            this.TeachList.Size = new System.Drawing.Size(152, 316);
            this.TeachList.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(199, 33);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 38);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FormTeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 390);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TeachList);
            this.Name = "FormTeach";
            this.Text = "FormTeach";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TeachList;
        private System.Windows.Forms.Button AddButton;
    }
}