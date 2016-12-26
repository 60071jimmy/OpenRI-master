/*
Copyright 2016 Open Robot Club

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Drawing.Imaging;

namespace app
{
    public partial class FormImage : Form
    {
        public FormMain formMain;

        public String imageFileName = null;
        //public Bitmap bmpImage_Ori;
        //public Bitmap bmpImage_Undo;
        //public Bitmap bmpImage;
        //public Bitmap bmpImage_Reset;
        public PictureBox pictureBoxImage;
        public int imageSn;

        public FormImage()
        {
            InitializeComponent();
        }

        private void FormImage_Load(object sender, EventArgs e)
        {
            int ret;

            imageSn = Vision.NewImage();
            if (imageSn < 0)
            {
                MessageBox.Show("Error : imageSn = ?");
                return;
            }

            ret = Vision.LoadImage(imageSn, imageFileName);
            if (ret <= 0)
            {
                Vision.FreeImage(imageSn);
                MessageBox.Show("Error : Fail to load image");
                return;
            }

            Vision.GetBitmap(imageSn);
            pictureBoxImage.Image = Vision.GetBitmap(imageSn);
            //pictureBoxImage.Refresh();
        }

        private void FormImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(imageSn);

            if (formMain.formImage == this)
            {
                formMain.formImage = null;
            }
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {

        }

        private void FormImage_Activated(object sender, EventArgs e)
        {
            formMain.formImage = this;
        }

        private void FormImage_Deactivate(object sender, EventArgs e)
        {
            //formMain.formImage = null;
        }
    }
}
