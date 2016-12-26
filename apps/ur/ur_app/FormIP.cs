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
    public partial class FormIP : Form
    {
        FormMdi formMdi;
        public FormIP(FormMdi parent)
        {
            InitializeComponent();
            formMdi = parent;
        }

        private void SaveIPButton_Click(object sender, EventArgs e)
        {
            ur.IP[ur.LEFTHAND] = lefthandIP1.Text + "." + lefthandIP2.Text + "." + lefthandIP3.Text + "." + lefthandIP4.Text;
            ur.IP[ur.RIGHTHAND] = righthandIP1.Text + "." + righthandIP2.Text + "." + righthandIP3.Text + "." + righthandIP4.Text;
            string[] IPs={ur.IP[ur.LEFTHAND], ur.IP[ur.RIGHTHAND]};
            System.IO.File.WriteAllLines(System.IO.Directory.GetCurrentDirectory() + @"\IP.txt", IPs);
        }

    }
}
