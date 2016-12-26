namespace ur_app
{
    partial class FormUR
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
            this.components = new System.ComponentModel.Container();
            this.ModelTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ModelTimer
            // 
            this.ModelTimer.Tick += new System.EventHandler(this.ModelTimer_Tick);
            // 
            // FormUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 605);
            this.Name = "FormUR";
            this.Text = "FormUR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUR_FormClosed);
            this.Load += new System.EventHandler(this.FormUR_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ModelTimer;
    }
}

