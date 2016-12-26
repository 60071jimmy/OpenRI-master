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
    public struct TeachItem
    {
        public string itemName;
        //public double[] motorAng = new double[6];
        //public double[] urPose = new double[6];
        public double acceleration;
        public double velocity;
        //  public TeachItem() { };

        public TeachItem(string itemName, double acceleration, double velocity)
        {
            this.itemName = itemName;
            this.acceleration = acceleration;
            this.velocity = velocity;
        }

        public override string ToString()
        {
            return itemName;
        }
    }
    public partial class FormTeach : Form
    {
        FormMdi formMdi;
        public List<TeachItem> listTeachItem = new List<TeachItem>();
        public FormTeach(FormMdi parent)
        {
            InitializeComponent();
            formMdi = parent;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TeachItem item = new TeachItem();
           // TeachList.Items.Add(new TeachItem("Position" + TeachList.Items.Count.ToString(), 1, 1));
            if (TeachList.SelectedIndex < 0)
            {
                item.velocity = 1;
                item.acceleration = 1;
                item.itemName = "Position" + (TeachList.Items.Count + 1).ToString();
                TeachList.Items.Add(item);
            }
            else
            {
                item.velocity = 2;
                item.acceleration = 2;
                item.itemName = "Position" + (TeachList.SelectedIndex + 1 +1).ToString();
                TeachList.Items.Insert(TeachList.SelectedIndex + 1, item);
                
            }
    

        }
    }

}
