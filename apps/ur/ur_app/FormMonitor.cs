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
    public partial class FormMonitor : Form
    {
        FormMdi formMdi;
        private int UR;
        public FormMonitor(FormMdi parent, int URNO)
        {
            InitializeComponent();
            formMdi = parent;
            UR = URNO;
           
        }

        private void FormMonitor_Load(object sender, EventArgs e)
        {
            
            detailTimer.Start();
        }

        private void detailTimer_Tick(object sender, EventArgs e)
        {
            if (UR == ur.LEFTHAND)
            {

                baseAngle.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.BASE] * 180 / Math.PI).ToString("0.0000") + " °";
                shoulderAngle.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.SHOULDER] * 180 / Math.PI).ToString("0.0000") + " °";
                elbowAngle.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.ELBOW] * 180 / Math.PI).ToString("0.0000") + " °";
                wrist1Angle.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST1] * 180 / Math.PI).ToString("0.0000") + " °";
                wrist2Angle.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST2] * 180 / Math.PI).ToString("0.0000") + " °";
                wrist3Angle.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorAng[ur.WRIST3] * 180 / Math.PI).ToString("0.0000") + " °";

                poseX.Text = (ur.aoiMotorData[ur.LEFTHAND].URPose[ur.POSEX] * 1000).ToString("0.0000") + " mm ";
                poseY.Text = (ur.aoiMotorData[ur.LEFTHAND].URPose[ur.POSEY] * 1000).ToString("0.0000") + " mm ";
                poseZ.Text = (ur.aoiMotorData[ur.LEFTHAND].URPose[ur.POSEZ] * 1000).ToString("0.0000") + " mm ";
                poseRX.Text = (ur.aoiMotorData[ur.LEFTHAND].URPose[ur.POSERX]).ToString("0.0000");
                poseRY.Text = (ur.aoiMotorData[ur.LEFTHAND].URPose[ur.POSERY]).ToString("0.0000");
                poseRZ.Text = (ur.aoiMotorData[ur.LEFTHAND].URPose[ur.POSERZ]).ToString("0.0000");

                voltBase.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorVolt[ur.BASE]).ToString("0.0") + " V ";
                voltShoulder.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorVolt[ur.SHOULDER]).ToString("0.0") + " V ";
                voltElbow.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorVolt[ur.ELBOW]).ToString("0.0") + " V ";
                voltWrist1.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorVolt[ur.WRIST1]).ToString("0.0") + " V ";
                voltWrist2.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorVolt[ur.WRIST2]).ToString("0.0") + " V ";
                voltWrist3.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorVolt[ur.WRIST3]).ToString("0.0") + " V ";

                currentBase.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorCurrent[ur.BASE]).ToString("0.000") + " A ";
                currentShoulder.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorCurrent[ur.SHOULDER]).ToString("0.000") + " A ";
                currentElbow.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorCurrent[ur.ELBOW]).ToString("0.000") + " A ";
                currentWrist1.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorCurrent[ur.WRIST1]).ToString("0.000") + " A ";
                currentWrist2.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorCurrent[ur.WRIST2]).ToString("0.000") + " A ";
                currentWrist3.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorCurrent[ur.WRIST3]).ToString("0.000") + " A ";

                tempBase.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorTemp[ur.BASE]).ToString("0.0") + " ℃ ";
                tempShoulder.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorTemp[ur.SHOULDER]).ToString("0.0") + " ℃ ";
                tempEllbow.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorTemp[ur.ELBOW]).ToString("0.0") + " ℃ ";
                tempWrist1.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorTemp[ur.WRIST1]).ToString("0.0") + " ℃ ";
                tempWrist2.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorTemp[ur.WRIST2]).ToString("0.0") + " ℃ ";
                tempWrist3.Text = (ur.aoiMotorData[ur.LEFTHAND].MotorTemp[ur.WRIST3]).ToString("0.0") + " ℃ ";

                digitalI0.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalInputBits[0]);
                digitalI1.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalInputBits[1]);
                digitalI2.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalInputBits[2]);
                digitalI3.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalInputBits[3]);
                digitalI4.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalInputBits[4]);
                digitalI5.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalInputBits[5]);
                digitalI6.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalInputBits[6]);
                digitalI7.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalInputBits[7]);

                digitalO0.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalOutputBits[0]);
                digitalO1.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalOutputBits[1]);
                digitalO2.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalOutputBits[2]);
                digitalO3.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalOutputBits[3]);
                digitalO4.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalOutputBits[4]);
                digitalO5.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalOutputBits[5]);
                digitalO6.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalOutputBits[6]);
                digitalO7.Checked = Convert.ToBoolean(ur.aoiMotorData[ur.LEFTHAND].digitalOutputBits[7]);

                if (ur.aoiMotorData[ur.LEFTHAND].analogInputUnit[0] == 0)
                {
                    analogI0.Text = (ur.aoiMotorData[ur.LEFTHAND].analogInput[0]).ToString("0.000") + " V ";
                }
                else
                {
                    analogI0.Text = (ur.aoiMotorData[ur.LEFTHAND].analogInput[0] * 1000).ToString("0.000") + " mA ";
                }

                if (ur.aoiMotorData[ur.LEFTHAND].analogInputUnit[1] == 0)
                {
                    analogI0.Text = (ur.aoiMotorData[ur.LEFTHAND].analogInput[1]).ToString("0.000") + " V ";
                }
                else
                {
                    analogI0.Text = (ur.aoiMotorData[ur.LEFTHAND].analogInput[1] * 1000).ToString("0.000") + " mA ";
                }

                if (ur.aoiMotorData[ur.LEFTHAND].analogOutputUnit[0] == 0)
                {
                    analogO0.Text = (ur.aoiMotorData[ur.LEFTHAND].analogOutputUnit[0]).ToString("0.000") + " V ";
                }
                else
                {
                    analogO0.Text = (ur.aoiMotorData[ur.LEFTHAND].analogOutputUnit[0] * 1000).ToString("0.000") + " mA ";
                }

                if (ur.aoiMotorData[ur.LEFTHAND].analogOutputUnit[1] == 0)
                {
                    analogO1.Text = (ur.aoiMotorData[ur.LEFTHAND].analogOutputUnit[1]).ToString("0.000") + " V ";
                }
                else
                {
                    analogO1.Text = (ur.aoiMotorData[ur.LEFTHAND].analogOutputUnit[1] * 1000).ToString("0.000") + " mA ";
                }

                


            }
            else if (UR == ur.RIGHTHAND)
            {

                baseAngle.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorAng[ur.BASE] * 180 / Math.PI).ToString("0.0000") + " °";
                shoulderAngle.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorAng[ur.SHOULDER] * 180 / Math.PI).ToString("0.0000") + " °";
                elbowAngle.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorAng[ur.ELBOW] * 180 / Math.PI).ToString("0.0000") + " °";
                wrist1Angle.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorAng[ur.WRIST1] * 180 / Math.PI).ToString("0.0000") + " °";
                wrist2Angle.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorAng[ur.WRIST2] * 180 / Math.PI).ToString("0.0000") + " °";
                wrist3Angle.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorAng[ur.WRIST3] * 180 / Math.PI).ToString("0.0000") + " °";


                poseX.Text = (ur.aoiMotorData[ur.RIGHTHAND].URPose[ur.POSEX] * 1000).ToString("0.0000") + " mm ";
                poseY.Text = (ur.aoiMotorData[ur.RIGHTHAND].URPose[ur.POSEY] * 1000).ToString("0.0000") + " mm ";
                poseZ.Text = (ur.aoiMotorData[ur.RIGHTHAND].URPose[ur.POSEZ] * 1000).ToString("0.0000") + " mm ";
                poseRX.Text = (ur.aoiMotorData[ur.RIGHTHAND].URPose[ur.POSERX]).ToString("0.0000");
                poseRY.Text = (ur.aoiMotorData[ur.RIGHTHAND].URPose[ur.POSERY]).ToString("0.0000");
                poseRZ.Text = (ur.aoiMotorData[ur.RIGHTHAND].URPose[ur.POSERZ]).ToString("0.0000");

                voltBase.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorVolt[ur.BASE]).ToString("0.0") + " V ";
                voltShoulder.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorVolt[ur.SHOULDER]).ToString("0.0") + " V ";
                voltElbow.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorVolt[ur.ELBOW]).ToString("0.0") + " V ";
                voltWrist1.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorVolt[ur.WRIST1]).ToString("0.0") + " V ";
                voltWrist2.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorVolt[ur.WRIST2]).ToString("0.0") + " V ";
                voltWrist3.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorVolt[ur.WRIST3]).ToString("0.0") + " V ";

                currentBase.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorCurrent[ur.BASE]).ToString("0.000") + " A ";
                currentShoulder.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorCurrent[ur.SHOULDER]).ToString("0.000") + " A ";
                currentElbow.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorCurrent[ur.ELBOW]).ToString("0.000") + " A ";
                currentWrist1.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorCurrent[ur.WRIST1]).ToString("0.000") + " A ";
                currentWrist2.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorCurrent[ur.WRIST2]).ToString("0.000") + " A ";
                currentWrist3.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorCurrent[ur.WRIST3]).ToString("0.000") + " A ";

                tempBase.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorTemp[ur.BASE]).ToString("0.0") + " ℃ ";
                tempShoulder.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorTemp[ur.SHOULDER]).ToString("0.0") + " ℃ ";
                tempEllbow.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorTemp[ur.ELBOW]).ToString("0.0") + " ℃ ";
                tempWrist1.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorTemp[ur.WRIST1]).ToString("0.0") + " ℃ ";
                tempWrist2.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorTemp[ur.WRIST2]).ToString("0.0") + " ℃ ";
                tempWrist3.Text = (ur.aoiMotorData[ur.RIGHTHAND].MotorTemp[ur.WRIST3]).ToString("0.0") + " ℃ ";

                if (ur.aoiMotorData[ur.RIGHTHAND].analogInputUnit[0] == 0)
                {
                    analogI0.Text = (ur.aoiMotorData[ur.RIGHTHAND].analogInput[0]).ToString("0.000") + " V ";
                }
                else
                {
                    analogI0.Text = (ur.aoiMotorData[ur.RIGHTHAND].analogInput[0] * 1000).ToString("0.000") + " mA ";
                }

                if (ur.aoiMotorData[ur.RIGHTHAND].analogInputUnit[1] == 0)
                {
                    analogI0.Text = (ur.aoiMotorData[ur.RIGHTHAND].analogInput[1]).ToString("0.000") + " V ";
                }
                else
                {
                    analogI0.Text = (ur.aoiMotorData[ur.RIGHTHAND].analogInput[1] * 1000).ToString("0.000") + " mA ";
                }

                if (ur.aoiMotorData[ur.RIGHTHAND].analogOutputUnit[0] == 0)
                {
                    analogO0.Text = (ur.aoiMotorData[ur.RIGHTHAND].analogOutputUnit[0]).ToString("0.000") + " V ";
                }
                else
                {
                    analogO0.Text = (ur.aoiMotorData[ur.RIGHTHAND].analogOutputUnit[0] * 1000).ToString("0.000") + " mA ";
                }

                if (ur.aoiMotorData[ur.RIGHTHAND].analogOutputUnit[1] == 0)
                {
                    analogO1.Text = (ur.aoiMotorData[ur.RIGHTHAND].analogOutputUnit[1]).ToString("0.000") + " V ";
                }
                else
                {
                    analogO1.Text = (ur.aoiMotorData[ur.RIGHTHAND].analogOutputUnit[1] * 1000).ToString("0.000") + " mA ";
                }

            }


        }

        private void FormMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            detailTimer.Stop();
        }
    }
}
