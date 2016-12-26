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

namespace app
{
    public partial class FormDilateErode : Form
    {
        int type = 1;
        int elementType = 0;
        FormMain formMain;
        int imagePreviewSn = -1;
        int imageProcessedSn = -1;

        public FormDilateErode(FormMain parent)
        {
            try
            {
                InitializeComponent();
                formMain = parent;
                imagePreviewSn = Vision.NewImage();
            }
            catch (Exception m)
            {
                Vision.Log("DilateErode : " + m.Message);
            }
        }

        private void Dilate_Erode_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception m)
            {
                Vision.Log("DilateErode : " + m.Message);
            }
        }

        private void button_erode_Click(object sender, EventArgs e)
        {
            try
            {
                type = 1;
                button_erode.ForeColor = System.Drawing.Color.Red;
                button_dilate.ForeColor = System.Drawing.Color.Black;
                button_close.ForeColor = System.Drawing.Color.Black;
                button_open.ForeColor = System.Drawing.Color.Black;

                FormDilateErode_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("DilateErode (erode): " + m.Message);
            }
        }

        private void button_dilate_Click(object sender, EventArgs e)
        {
            try
            {
                type = 2;
                button_erode.ForeColor = System.Drawing.Color.Black;
                button_dilate.ForeColor = System.Drawing.Color.Red;
                button_close.ForeColor = System.Drawing.Color.Black;
                button_open.ForeColor = System.Drawing.Color.Black;

                FormDilateErode_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("DilateErode (dilate): " + m.Message);
            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                type = 3;
                button_erode.ForeColor = System.Drawing.Color.Black;
                button_dilate.ForeColor = System.Drawing.Color.Black;
                button_close.ForeColor = System.Drawing.Color.Black;
                button_open.ForeColor = System.Drawing.Color.Red;

                FormDilateErode_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("DilateErode (open): " + m.Message);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            try
            {
                type = 4;
                button_erode.ForeColor = System.Drawing.Color.Black;
                button_dilate.ForeColor = System.Drawing.Color.Black;
                button_close.ForeColor = System.Drawing.Color.Red;
                button_open.ForeColor = System.Drawing.Color.Black;

                FormDilateErode_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("DilateErode (close): " + m.Message);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (formMain.formImage != null)
                {
                    if (imageProcessedSn == formMain.formImage.imageSn)
                        Vision.CloneImage(imagePreviewSn, formMain.formImage.imageSn);
                }
                this.Close();
            }
            catch (Exception m)
            {
                Vision.Log("DilateErode (save): " + m.Message);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception m)
            {
                Vision.Log("DilateErode (cancel): " + m.Message);
            }
        }

        private void Height_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                Height_label.Text = (2 * Height_trackBar.Value + 1).ToString();
                FormDilateErode_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("DilateErode (Height): " + m.Message);
            }
        }

        private void Weight_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                Weight_label.Text = (2 * Weight_trackBar.Value + 1).ToString();
                FormDilateErode_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("DilateErode (Weight): " + m.Message);
            }
        }

        private void rectangle_radio_CheckedChanged(object sender, EventArgs e)
        {
            elementType = 0;
            FormDilateErode_Apply_Preview();
        }

        private void cross_radio_CheckedChanged(object sender, EventArgs e)
        {
            elementType = 1;
            FormDilateErode_Apply_Preview();
        }

        private void ellipse_radio_CheckedChanged(object sender, EventArgs e)
        {
            elementType = 2;
            FormDilateErode_Apply_Preview();
        }

        private void FormDilateErode_Apply_Preview()
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
            switch (type)
            {
                case 1:
                    Vision.EntryErode(imagePreviewSn, elementType, Height_trackBar.Value, Weight_trackBar.Value);
                    break;
                case 2:
                    Vision.EntryDilate(imagePreviewSn, elementType, Height_trackBar.Value, Weight_trackBar.Value);
                    break;
                case 3:
                    Vision.EntryOpen(imagePreviewSn, elementType, Height_trackBar.Value, Weight_trackBar.Value);
                    break;
                case 4:
                    Vision.EntryClose(imagePreviewSn, elementType, Height_trackBar.Value, Weight_trackBar.Value);
                    break;
                default:
                    MessageBox.Show("Fail");
                    return;
            }
            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }

        private void FormDilateErode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(imagePreviewSn);

            if (formMain.formImage != null)
            {
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
            }
        }
    }
}
