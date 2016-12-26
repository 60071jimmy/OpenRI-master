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
    public partial class FormSharpen : Form
    {
        float sharpen = 1;
        float contrast = 0;
        int kernel_size = 3;
        int imagePreviewSn = -1;
        int imageProcessedSn = -1;
        FormMain formMain;
        public FormSharpen(FormMain parent)
        {
            try
            {
                InitializeComponent();
                formMain = parent;
                imagePreviewSn = Vision.NewImage();
            }
            catch (Exception m)
            {
                Vision.Log("Sharpen : " + m.Message);
            }
        }

        private void Sharpen_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                sharpen_label.Text = ((float)sharpen_trackBar.Value / 100).ToString();
                sharpen = (float)sharpen_trackBar.Value / 100;
                FormSharpen_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Sharpen (sharpen): " + m.Message);
            }

        }

        private void Contrast_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                contrast_label.Text = "-" + ((float)contrast_trackBar.Value / 100).ToString();
                contrast = -1 * ((float)contrast_trackBar.Value / 100);
                FormSharpen_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Sharpen (contrast): " + m.Message);
            }
        } 

        private void Ksize_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                ksize_label.Text = (ksize_trackBar.Value * 2 + 1).ToString();
                kernel_size = (ksize_trackBar.Value * 2 + 1);
                FormSharpen_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Sharpen (kernel): " + m.Message);
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
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
                Vision.Log("Sharpen (save): " + m.Message);
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception m)
            {
                Vision.Log("Sharpen (reset): " + m.Message);
            }
        }

        private void MaskSharpen_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (formMain.formImage == null) return;

                imageProcessedSn = formMain.formImage.imageSn;
                Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);

                Vision.MaskSharpen(imagePreviewSn);

                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
            }
            catch (Exception m)
            {
                Vision.Log("Sharpen (mask): " + m.Message);
            } 
        }

        private void FormSharpen_Apply_Preview()
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);

            Vision.Sharpen(imagePreviewSn, sharpen, contrast, kernel_size);

            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }

        private void FormSharpen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(imagePreviewSn);

            if (formMain.formImage != null)
            {
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
            }
        }
    }
}
