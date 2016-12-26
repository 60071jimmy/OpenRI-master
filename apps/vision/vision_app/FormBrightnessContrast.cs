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
    public partial class FormBrightnessContrast : Form
    {
        FormMain formMain;
        int imagePreviewSn = -1;
        int imageProcessedSn = -1;

        public FormBrightnessContrast(FormMain parent)
        {
            try
            {
                InitializeComponent();
                formMain = parent;
                imagePreviewSn = Vision.NewImage();
            }
            catch (Exception m)
            {
                Vision.Log("BrightnessContras : " + m.Message);
            }
        }

        private void Brightness_contrast_Load(object sender, EventArgs e)
        {            

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception m)
            {
                Vision.Log("BrightnessContras (reset): " + m.Message);
            }
           
        }

        private void ok_button_Click(object sender, EventArgs e)
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
                Vision.Log("BrightnessContras (save): " + m.Message);
            }
        }

        private void FormBrightnessContrast_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(imagePreviewSn);

            if (formMain.formImage != null)
            {
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
            }
        }

        private void FormBrightnessContrast_Apply_Preview()
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);

            Vision.BrightnessContrast(imagePreviewSn, Contrast_trackbar.Value, brightness_trackbar.Value);

            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }

        private void Brigntness_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                Brightness_label.Text = brightness_trackbar.Value.ToString();
                FormBrightnessContrast_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("BrightnessContras (brightness): " + m.Message);
            }
        }

        private void Contrastbar_Scroll(object sender, EventArgs e)
        {
            try
            {
                Contrast_label.Text = Contrast_trackbar.Value.ToString();
                FormBrightnessContrast_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("BrightnessContras (Contrast): " + m.Message);
            }
        }
    }
}
