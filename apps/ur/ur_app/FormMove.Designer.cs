namespace ur_app
{
    partial class FormMove
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
            this.groupPoseMove = new System.Windows.Forms.GroupBox();
            this.currentPoseCheckBox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RZPose = new System.Windows.Forms.TextBox();
            this.Zpose = new System.Windows.Forms.TextBox();
            this.RYPose = new System.Windows.Forms.TextBox();
            this.Ypose = new System.Windows.Forms.TextBox();
            this.RXPose = new System.Windows.Forms.TextBox();
            this.Xpose = new System.Windows.Forms.TextBox();
            this.poseMoveButton = new System.Windows.Forms.Button();
            this.groupJointMove = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wrist3RightButton = new System.Windows.Forms.Button();
            this.wrist3LeftButton = new System.Windows.Forms.Button();
            this.wrist2RightButton = new System.Windows.Forms.Button();
            this.wrist2LeftButton = new System.Windows.Forms.Button();
            this.wrist1RightButton = new System.Windows.Forms.Button();
            this.wrist1LeftButton = new System.Windows.Forms.Button();
            this.elbowRightButton = new System.Windows.Forms.Button();
            this.elbowLeftButton = new System.Windows.Forms.Button();
            this.shoulderRightButton = new System.Windows.Forms.Button();
            this.shoulderLeftButton = new System.Windows.Forms.Button();
            this.baseRightButton = new System.Windows.Forms.Button();
            this.baseLeftButton = new System.Windows.Forms.Button();
            this.groupPoseMove.SuspendLayout();
            this.groupJointMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPoseMove
            // 
            this.groupPoseMove.Controls.Add(this.currentPoseCheckBox);
            this.groupPoseMove.Controls.Add(this.label15);
            this.groupPoseMove.Controls.Add(this.label14);
            this.groupPoseMove.Controls.Add(this.label13);
            this.groupPoseMove.Controls.Add(this.label10);
            this.groupPoseMove.Controls.Add(this.label11);
            this.groupPoseMove.Controls.Add(this.label12);
            this.groupPoseMove.Controls.Add(this.label9);
            this.groupPoseMove.Controls.Add(this.label8);
            this.groupPoseMove.Controls.Add(this.label7);
            this.groupPoseMove.Controls.Add(this.RZPose);
            this.groupPoseMove.Controls.Add(this.Zpose);
            this.groupPoseMove.Controls.Add(this.RYPose);
            this.groupPoseMove.Controls.Add(this.Ypose);
            this.groupPoseMove.Controls.Add(this.RXPose);
            this.groupPoseMove.Controls.Add(this.Xpose);
            this.groupPoseMove.Controls.Add(this.poseMoveButton);
            this.groupPoseMove.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupPoseMove.Location = new System.Drawing.Point(15, 13);
            this.groupPoseMove.Name = "groupPoseMove";
            this.groupPoseMove.Size = new System.Drawing.Size(241, 334);
            this.groupPoseMove.TabIndex = 0;
            this.groupPoseMove.TabStop = false;
            this.groupPoseMove.Text = "Pose Move";
            // 
            // currentPoseCheckBox
            // 
            this.currentPoseCheckBox.AutoSize = true;
            this.currentPoseCheckBox.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.currentPoseCheckBox.Location = new System.Drawing.Point(14, 311);
            this.currentPoseCheckBox.Name = "currentPoseCheckBox";
            this.currentPoseCheckBox.Size = new System.Drawing.Size(220, 17);
            this.currentPoseCheckBox.TabIndex = 16;
            this.currentPoseCheckBox.Text = "Use the current value of RX, RY and RZ";
            this.currentPoseCheckBox.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(131, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 19);
            this.label15.TabIndex = 15;
            this.label15.Text = "mm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 19);
            this.label14.TabIndex = 14;
            this.label14.Text = "mm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "RZ :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "RY :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 19);
            this.label12.TabIndex = 10;
            this.label12.Text = "RX :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Z :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Y :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "X :";
            // 
            // RZPose
            // 
            this.RZPose.Location = new System.Drawing.Point(54, 268);
            this.RZPose.Name = "RZPose";
            this.RZPose.Size = new System.Drawing.Size(71, 30);
            this.RZPose.TabIndex = 6;
            // 
            // Zpose
            // 
            this.Zpose.Location = new System.Drawing.Point(54, 160);
            this.Zpose.Name = "Zpose";
            this.Zpose.Size = new System.Drawing.Size(71, 30);
            this.Zpose.TabIndex = 5;
            // 
            // RYPose
            // 
            this.RYPose.Location = new System.Drawing.Point(54, 232);
            this.RYPose.Name = "RYPose";
            this.RYPose.Size = new System.Drawing.Size(71, 30);
            this.RYPose.TabIndex = 4;
            // 
            // Ypose
            // 
            this.Ypose.Location = new System.Drawing.Point(54, 124);
            this.Ypose.Name = "Ypose";
            this.Ypose.Size = new System.Drawing.Size(71, 30);
            this.Ypose.TabIndex = 3;
            // 
            // RXPose
            // 
            this.RXPose.Location = new System.Drawing.Point(54, 196);
            this.RXPose.Name = "RXPose";
            this.RXPose.Size = new System.Drawing.Size(71, 30);
            this.RXPose.TabIndex = 2;
            // 
            // Xpose
            // 
            this.Xpose.Location = new System.Drawing.Point(54, 88);
            this.Xpose.Name = "Xpose";
            this.Xpose.Size = new System.Drawing.Size(71, 30);
            this.Xpose.TabIndex = 1;
            // 
            // poseMoveButton
            // 
            this.poseMoveButton.Location = new System.Drawing.Point(46, 41);
            this.poseMoveButton.Name = "poseMoveButton";
            this.poseMoveButton.Size = new System.Drawing.Size(159, 35);
            this.poseMoveButton.TabIndex = 0;
            this.poseMoveButton.Text = "Move To";
            this.poseMoveButton.UseVisualStyleBackColor = true;
            this.poseMoveButton.Click += new System.EventHandler(this.poseMoveButton_Click);
            // 
            // groupJointMove
            // 
            this.groupJointMove.Controls.Add(this.label6);
            this.groupJointMove.Controls.Add(this.label5);
            this.groupJointMove.Controls.Add(this.label4);
            this.groupJointMove.Controls.Add(this.label3);
            this.groupJointMove.Controls.Add(this.label2);
            this.groupJointMove.Controls.Add(this.label1);
            this.groupJointMove.Controls.Add(this.wrist3RightButton);
            this.groupJointMove.Controls.Add(this.wrist3LeftButton);
            this.groupJointMove.Controls.Add(this.wrist2RightButton);
            this.groupJointMove.Controls.Add(this.wrist2LeftButton);
            this.groupJointMove.Controls.Add(this.wrist1RightButton);
            this.groupJointMove.Controls.Add(this.wrist1LeftButton);
            this.groupJointMove.Controls.Add(this.elbowRightButton);
            this.groupJointMove.Controls.Add(this.elbowLeftButton);
            this.groupJointMove.Controls.Add(this.shoulderRightButton);
            this.groupJointMove.Controls.Add(this.shoulderLeftButton);
            this.groupJointMove.Controls.Add(this.baseRightButton);
            this.groupJointMove.Controls.Add(this.baseLeftButton);
            this.groupJointMove.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupJointMove.Location = new System.Drawing.Point(280, 13);
            this.groupJointMove.Name = "groupJointMove";
            this.groupJointMove.Size = new System.Drawing.Size(259, 334);
            this.groupJointMove.TabIndex = 1;
            this.groupJointMove.TabStop = false;
            this.groupJointMove.Text = "Joint Move";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Wrist3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wrist2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Wrist1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Elbow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Shoulder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Base";
            // 
            // wrist3RightButton
            // 
            this.wrist3RightButton.Location = new System.Drawing.Point(172, 284);
            this.wrist3RightButton.Name = "wrist3RightButton";
            this.wrist3RightButton.Size = new System.Drawing.Size(67, 38);
            this.wrist3RightButton.TabIndex = 11;
            this.wrist3RightButton.Text = ">>";
            this.wrist3RightButton.UseVisualStyleBackColor = true;
            this.wrist3RightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wrist3RightButton_MouseDown);
            this.wrist3RightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wrist3RightButton_MouseUp);
            // 
            // wrist3LeftButton
            // 
            this.wrist3LeftButton.Location = new System.Drawing.Point(99, 284);
            this.wrist3LeftButton.Name = "wrist3LeftButton";
            this.wrist3LeftButton.Size = new System.Drawing.Size(67, 38);
            this.wrist3LeftButton.TabIndex = 10;
            this.wrist3LeftButton.Text = "<<";
            this.wrist3LeftButton.UseVisualStyleBackColor = true;
            this.wrist3LeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wrist3LeftButton_MouseDown);
            this.wrist3LeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wrist3LeftButton_MouseUp);
            // 
            // wrist2RightButton
            // 
            this.wrist2RightButton.Location = new System.Drawing.Point(172, 238);
            this.wrist2RightButton.Name = "wrist2RightButton";
            this.wrist2RightButton.Size = new System.Drawing.Size(67, 38);
            this.wrist2RightButton.TabIndex = 9;
            this.wrist2RightButton.Text = ">>";
            this.wrist2RightButton.UseVisualStyleBackColor = true;
            this.wrist2RightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wrist2RightButton_MouseDown);
            this.wrist2RightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wrist2RightButton_MouseUp);
            // 
            // wrist2LeftButton
            // 
            this.wrist2LeftButton.Location = new System.Drawing.Point(99, 238);
            this.wrist2LeftButton.Name = "wrist2LeftButton";
            this.wrist2LeftButton.Size = new System.Drawing.Size(67, 38);
            this.wrist2LeftButton.TabIndex = 8;
            this.wrist2LeftButton.Text = "<<";
            this.wrist2LeftButton.UseVisualStyleBackColor = true;
            this.wrist2LeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wrist2LeftButton_MouseDown);
            this.wrist2LeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wrist2LeftButton_MouseUp);
            // 
            // wrist1RightButton
            // 
            this.wrist1RightButton.Location = new System.Drawing.Point(172, 189);
            this.wrist1RightButton.Name = "wrist1RightButton";
            this.wrist1RightButton.Size = new System.Drawing.Size(67, 38);
            this.wrist1RightButton.TabIndex = 7;
            this.wrist1RightButton.Text = ">>";
            this.wrist1RightButton.UseVisualStyleBackColor = true;
            this.wrist1RightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wrist1RightButton_MouseDown);
            this.wrist1RightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wrist1RightButton_MouseUp);
            // 
            // wrist1LeftButton
            // 
            this.wrist1LeftButton.Location = new System.Drawing.Point(99, 189);
            this.wrist1LeftButton.Name = "wrist1LeftButton";
            this.wrist1LeftButton.Size = new System.Drawing.Size(67, 38);
            this.wrist1LeftButton.TabIndex = 6;
            this.wrist1LeftButton.Text = "<<";
            this.wrist1LeftButton.UseVisualStyleBackColor = true;
            this.wrist1LeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wrist1LeftButton_MouseDown);
            this.wrist1LeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wrist1LeftButton_MouseUp);
            // 
            // elbowRightButton
            // 
            this.elbowRightButton.Location = new System.Drawing.Point(172, 140);
            this.elbowRightButton.Name = "elbowRightButton";
            this.elbowRightButton.Size = new System.Drawing.Size(67, 38);
            this.elbowRightButton.TabIndex = 5;
            this.elbowRightButton.Text = ">>";
            this.elbowRightButton.UseVisualStyleBackColor = true;
            this.elbowRightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.elbowRightButton_MouseDown);
            this.elbowRightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.elbowRightButton_MouseUp);
            // 
            // elbowLeftButton
            // 
            this.elbowLeftButton.Location = new System.Drawing.Point(99, 140);
            this.elbowLeftButton.Name = "elbowLeftButton";
            this.elbowLeftButton.Size = new System.Drawing.Size(67, 38);
            this.elbowLeftButton.TabIndex = 4;
            this.elbowLeftButton.Text = "<<";
            this.elbowLeftButton.UseVisualStyleBackColor = true;
            this.elbowLeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.elbowLeftButton_MouseDown);
            this.elbowLeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.elbowLeftButton_MouseUp);
            // 
            // shoulderRightButton
            // 
            this.shoulderRightButton.Location = new System.Drawing.Point(172, 91);
            this.shoulderRightButton.Name = "shoulderRightButton";
            this.shoulderRightButton.Size = new System.Drawing.Size(67, 38);
            this.shoulderRightButton.TabIndex = 3;
            this.shoulderRightButton.Text = ">>";
            this.shoulderRightButton.UseVisualStyleBackColor = true;
            this.shoulderRightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shoulderRightButton_MouseDown);
            this.shoulderRightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.shoulderRightButton_MouseUp);
            // 
            // shoulderLeftButton
            // 
            this.shoulderLeftButton.Location = new System.Drawing.Point(99, 91);
            this.shoulderLeftButton.Name = "shoulderLeftButton";
            this.shoulderLeftButton.Size = new System.Drawing.Size(67, 38);
            this.shoulderLeftButton.TabIndex = 2;
            this.shoulderLeftButton.Text = "<<";
            this.shoulderLeftButton.UseVisualStyleBackColor = true;
            this.shoulderLeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shoulderLeftButton_MouseDown);
            this.shoulderLeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.shoulderLeftButton_MouseUp);
            // 
            // baseRightButton
            // 
            this.baseRightButton.Location = new System.Drawing.Point(172, 42);
            this.baseRightButton.Name = "baseRightButton";
            this.baseRightButton.Size = new System.Drawing.Size(67, 38);
            this.baseRightButton.TabIndex = 1;
            this.baseRightButton.Text = ">>";
            this.baseRightButton.UseVisualStyleBackColor = true;
            this.baseRightButton.Click += new System.EventHandler(this.baseRightButton_Click);
            this.baseRightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.baseRightButton_MouseDown);
            this.baseRightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.baseRightButton_MouseUp);
            // 
            // baseLeftButton
            // 
            this.baseLeftButton.Location = new System.Drawing.Point(99, 42);
            this.baseLeftButton.Name = "baseLeftButton";
            this.baseLeftButton.Size = new System.Drawing.Size(67, 38);
            this.baseLeftButton.TabIndex = 0;
            this.baseLeftButton.Text = "<<";
            this.baseLeftButton.UseVisualStyleBackColor = true;
            this.baseLeftButton.Click += new System.EventHandler(this.baseLeftButton_Click_1);
            this.baseLeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.baseLeftButton_MouseDown);
            this.baseLeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.baseLeftButton_MouseUp);
            // 
            // FormMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 385);
            this.Controls.Add(this.groupJointMove);
            this.Controls.Add(this.groupPoseMove);
            this.Name = "FormMove";
            this.Text = "FormRelativeMove";
            this.groupPoseMove.ResumeLayout(false);
            this.groupPoseMove.PerformLayout();
            this.groupJointMove.ResumeLayout(false);
            this.groupJointMove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPoseMove;
        private System.Windows.Forms.GroupBox groupJointMove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wrist3RightButton;
        private System.Windows.Forms.Button wrist3LeftButton;
        private System.Windows.Forms.Button wrist2RightButton;
        private System.Windows.Forms.Button wrist2LeftButton;
        private System.Windows.Forms.Button wrist1RightButton;
        private System.Windows.Forms.Button wrist1LeftButton;
        private System.Windows.Forms.Button elbowRightButton;
        private System.Windows.Forms.Button elbowLeftButton;
        private System.Windows.Forms.Button shoulderRightButton;
        private System.Windows.Forms.Button shoulderLeftButton;
        private System.Windows.Forms.Button baseRightButton;
        private System.Windows.Forms.Button baseLeftButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RZPose;
        private System.Windows.Forms.TextBox Zpose;
        private System.Windows.Forms.TextBox RYPose;
        private System.Windows.Forms.TextBox Ypose;
        private System.Windows.Forms.TextBox RXPose;
        private System.Windows.Forms.TextBox Xpose;
        private System.Windows.Forms.Button poseMoveButton;
        private System.Windows.Forms.CheckBox currentPoseCheckBox;
    }
}