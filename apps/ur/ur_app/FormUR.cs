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
    public partial class FormUR : Form
    {
        FormMdi formMdi;
        private string URcmd = "";
        public FormUR(FormMdi parent)
        {
            InitializeComponent();
            formMdi = parent;
            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);
            this.UpdateStyles();//這行我測試沒設定似乎也可以,但MSDN上有此行
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            ur.urModel(this.Handle);
            ModelTimer.Start();            
        }

        private void FormUR_Load(object sender, EventArgs e)
        {
        }

        private void ModelTimer_Tick(object sender, EventArgs e)
        {
            int ret = 0;
            ret = ur.DrawUr();
            if (ret != 1)
            {
                ur.urModel(this.Handle);
            }

        }

        private void FormUR_FormClosed(object sender, FormClosedEventArgs e)
        {
            ModelTimer.Stop();
        }
    }
}
