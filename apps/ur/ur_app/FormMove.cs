using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ur_app
{
    public partial class FormMove : Form
    {
        FormMdi formMdi;
        private string URcmd = "";
        public FormMove(FormMdi parent)
        {
            InitializeComponent();
            formMdi = parent;
        }

        private void baseLeftButton_Click(object sender, EventArgs e)
        {

        }

        private void baseLeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void baseLeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + Math.PI * 2 + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.ELBOW] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST1] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST2] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST3] + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void baseRightButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + (-1) * Math.PI * 2 + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.ELBOW] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST1] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST2] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST3] + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void baseRightButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void shoulderLeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.BASE] + "," + Math.PI * 2 + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.ELBOW] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST1] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST2] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST3] + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void shoulderLeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void shoulderRightButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.BASE] + "," + (-1) * Math.PI * 2 + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.ELBOW] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST1] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST2] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST3] + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void shoulderRightButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void elbowLeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.BASE] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + Math.PI * 2 + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST1] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST2] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST3] + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void elbowLeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void elbowRightButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.BASE] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + (-1) * Math.PI * 2 + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST1] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST2] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST3] + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void elbowRightButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void wrist1LeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.BASE] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + Math.PI * 2 + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST2] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST3] + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void wrist1LeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void wrist1RightButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.BASE] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + (-1) * Math.PI * 2 + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST2] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST3] + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void wrist1RightButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void wrist2LeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.BASE] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST1] + "," + Math.PI * 2 + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST3] + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void wrist2LeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void wrist2RightButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.BASE] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST1] + "," + (-1) * Math.PI * 2 + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST3] + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void wrist2RightButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void wrist3LeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.BASE] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST1] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST2] + "," + Math.PI * 2 + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void wrist3LeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void wrist3RightButton_MouseDown(object sender, MouseEventArgs e)
        {
            URcmd = "movej([" + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.BASE] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST1] + "," + ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST2] + "," + (-1) * Math.PI * 2 + "], a=0.5, v=0.5)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }
        private void wrist3RightButton_MouseUp(object sender, MouseEventArgs e)
        {
            URcmd = "stopj(1)\n";
            ur.sendCmd(ur.LEFTHAND, URcmd);
        }

        private void baseLeftButton_Click_1(object sender, EventArgs e)
        {

        }

        private void baseRightButton_Click(object sender, EventArgs e)
        {

        }

        private void poseMoveButton_Click(object sender, EventArgs e)
        {
            string URcmd = "";
            if (currentPoseCheckBox.Checked)
            {
                URcmd = "movep(p[" + Convert.ToDouble(Xpose.Text) / 1000 + "," + Convert.ToDouble(Ypose.Text) / 1000 + "," + Convert.ToDouble(Zpose.Text) / 1000 + "," +
                    ur.aoiMotorData[ur.LEFTHAND].URPose[ur.POSERX] + "," + ur.aoiMotorData[ur.LEFTHAND].URPose[ur.POSERY] + "," + ur.aoiMotorData[ur.LEFTHAND].URPose[ur.POSERZ] + "], a=0.1, v=0.1, r=0)\n";
            }
            else
            {
                URcmd = "movep(p[" + Convert.ToDouble(Xpose.Text) / 1000 + "," + Convert.ToDouble(Ypose.Text) / 1000 + "," + Convert.ToDouble(Zpose.Text) / 1000 + "," +
                    RXPose + "," + RYPose + "," + RZPose + "], a=0.1, v=0.1, r=0)\n";
            }

            ur.sendCmd(ur.LEFTHAND, URcmd);
        }
    }
}
