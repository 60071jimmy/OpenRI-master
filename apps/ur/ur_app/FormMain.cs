/*
 Copyright (c) LEADERG INC. All rights reserved.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ur_app
{
    public partial class FormMain : Form
    {
        
        public FormMdi formMdi;
        private bool first = true;
        public FormMain()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            ur.Init();
            if (File.Exists(System.IO.Directory.GetCurrentDirectory() + @"\IP.txt"))
            {
                ur.IP = System.IO.File.ReadAllLines(System.IO.Directory.GetCurrentDirectory() + @"\IP.txt");
                
            }
        }

        private void receiveTimer_Tick(object sender, EventArgs e)
        {

            if (first) {             
                int ret = ur.ReceiveByte(0);
                ret = ur.ReceiveByte(1);
                first = false; 
            }          
          
            ur.GetMotorData(ref ur.aoiMotorData[ur.LEFTHAND], ur.LEFTHAND);
            ur.GetMotorData(ref ur.aoiMotorData[ur.RIGHTHAND], ur.RIGHTHAND);             
            
        }


        private void connectToLeftHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void connectToRightHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void disconnectToBothHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ur.DisConnect(ur.LEFTHAND);
            ur.DisConnect(ur.RIGHTHAND);
            receiveTimer.Stop();
            first = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "stopj(1)\n";
            int ret = ur.Send(ur.LEFTHAND, message, message.Length);
            if (ret <= 0)
            {
                MessageBox.Show("failed to stop left-hand");
            }
            if (ur.connectAnotherUR)
            {
                ret = ur.Send(ur.RIGHTHAND, message, message.Length);
                if (ret <= 0)
                {
                    MessageBox.Show("failed to stop right-hand");
                }

            }
        }

        private void moveSquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* Form mdiChild = Application.OpenForms["FormMoveSquare"];
            if (mdiChild == null)
            {
                FormMoveSquare moveSquareForm = new FormMoveSquare(formMdi);
                moveSquareForm.MdiParent = this;
                moveSquareForm.Show();
            }
            else
            {
                mdiChild.BringToFront(); 
            }*/

           

        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mdiChild = Application.OpenForms["FormMove"];
            if (mdiChild == null)
            {
                FormMove moveForm = new FormMove(formMdi);
                moveForm.MdiParent = this;
                moveForm.Show();
            }
            else
            {
                mdiChild.BringToFront();
            }

        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mdiChild = Application.OpenForms["FormMonitor"];
            if (mdiChild == null)
            {
                FormMonitor monitorForm1 = new FormMonitor(formMdi, ur.LEFTHAND);
                FormMonitor monitorForm2 = new FormMonitor(formMdi, ur.RIGHTHAND);
                monitorForm1.Text = ur.IP[ur.LEFTHAND];
                monitorForm2.Text = ur.IP[ur.RIGHTHAND];
                monitorForm1.MdiParent = this;
                monitorForm2.MdiParent = this;
                monitorForm1.Show();
                monitorForm2.Show();
            }
            else
            {
                mdiChild.BringToFront();
            }
        }

        private void emergenctStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "powerdown()\n";
            int ret = ur.Send(ur.LEFTHAND,message, message.Length);
            if (ret <= 0)
            {
                MessageBox.Show("failed to shutdown left-hand");
            }

            if (ur.connectAnotherUR)
            {
                ret = ur.Send(ur.RIGHTHAND, message, message.Length);
                if (ret <= 0)
                {
                    MessageBox.Show("failed to shutdown right-hand");
                }

            }
        }

        private void iPSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mdiChild = Application.OpenForms["FormIP"];
            if (mdiChild == null)
            {                FormIP IPForm = new FormIP(formMdi);
                IPForm.MdiParent = this;
                IPForm.Show();
            }
            else
            {
                mdiChild.BringToFront();
            }
        }


        private void connectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //int ret = ur.Init();


            int ret = ur.Connect(ur.LEFTHAND, ur.IP[ur.LEFTHAND]);
            int retR = ur.Connect(ur.RIGHTHAND, ur.IP[ur.RIGHTHAND]);

            if (ret == 1 && retR == 1)
            {
                MessageBox.Show("connection to both hand is well");
                receiveTimer.Start();
            }
            else if (ret == 1 && retR != 1)
            {
                MessageBox.Show("connection to left-hand is well, but connection to right-hand is failed");
                receiveTimer.Start();
            }
            else if (ret != 1 && retR == 1)
            {
                MessageBox.Show("connection to right-hand is well, but connection to left-hand is failed");
                receiveTimer.Start();
            }
            else
            {
                MessageBox.Show("connection to both hand is failed");
            }
        
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ur.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mdiChild = Application.OpenForms["FormUR"];
            if (mdiChild == null)
            {
                FormUR urForm = new FormUR(formMdi);
                urForm.MdiParent = this;
                urForm.Show();
            }
            else
            {
                mdiChild.BringToFront();
            }
        }

        private void teachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mdiChild = Application.OpenForms["FormTeach"];
            if (mdiChild == null)
            {
                FormTeach teachForm = new FormTeach(formMdi);
                teachForm.MdiParent = this;
                teachForm.Show();
            }
            else
            {
                mdiChild.BringToFront();
            }
        }


    }
}
