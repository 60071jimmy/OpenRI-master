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
    public partial class FormSmooth : Form
    {
        int type = 1;
        FormMain formMain;
        int imagePreviewSn = -1;
        int imageProcessedSn = -1;

        public FormSmooth(FormMain parent)
        {
            try
            {
                InitializeComponent();
                formMain = parent;
                imagePreviewSn = Vision.NewImage();
            }
            catch (Exception m)
            {
                Vision.Log("Smooth : " + m.Message);
            }
        }


        private void Smooth_Load(object sender, EventArgs e)
        {           
            try
            {
            }
            catch (Exception m)
            {
                Vision.Log("Smooth : " + m.Message);
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
                Vision.Log("Smooth (save): " + m.Message);
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception m)
            {
                Vision.Log("Smooth (reset): " + m.Message);
            }
        }

        private void blur_Click(object sender, EventArgs e)
        {
            try
            {
                type = 1;
                blur_button.ForeColor = System.Drawing.Color.Red;
                gaussian_button.ForeColor = System.Drawing.Color.Black;
                median_button.ForeColor = System.Drawing.Color.Black;
                bilateral_button.ForeColor = System.Drawing.Color.Black;

                FormSmooth_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Smooth (blur): " + m.Message);
            }
        }

        private void gaussian_Click(object sender, EventArgs e)
        {
            try
            {
                type = 2;
                blur_button.ForeColor = System.Drawing.Color.Black;
                gaussian_button.ForeColor = System.Drawing.Color.Red;
                median_button.ForeColor = System.Drawing.Color.Black;
                bilateral_button.ForeColor = System.Drawing.Color.Black;

                FormSmooth_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Smooth (gaussian): " + m.Message);
            }
        }

        private void median_Click(object sender, EventArgs e)
        {
            try
            {
                type = 3;
                blur_button.ForeColor = System.Drawing.Color.Black;
                gaussian_button.ForeColor = System.Drawing.Color.Black;
                median_button.ForeColor = System.Drawing.Color.Red;
                bilateral_button.ForeColor = System.Drawing.Color.Black;

                FormSmooth_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Smooth (median): " + m.Message);
            }
        }

        private void bilateral_Click(object sender, EventArgs e)
        {
            try
            {
                type = 4;
                blur_button.ForeColor = System.Drawing.Color.Black;
                gaussian_button.ForeColor = System.Drawing.Color.Black;
                median_button.ForeColor = System.Drawing.Color.Black;
                bilateral_button.ForeColor = System.Drawing.Color.Red;

                FormSmooth_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Smooth (bilateral): " + m.Message);
            }
        }

        private void ksize_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                ksize_label.Text = (2 * ksize_trackBar.Value + 1).ToString();

                FormSmooth_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Smooth (kernel size): " + m.Message);
            }
        }

        private void FormSmooth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(imagePreviewSn);

            if (formMain.formImage != null)
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
        }

        private void FormSmooth_Apply_Preview()
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);

            switch (type)
            {
                case 1:
                    Vision.SmoothBlur(imagePreviewSn, ksize_trackBar.Value);
                    break;
                case 2:
                    Vision.SmoothGaussian(imagePreviewSn, ksize_trackBar.Value);
                    break;
                case 3:
                    Vision.SmoothMedian(imagePreviewSn, ksize_trackBar.Value);
                    break;
                case 4:
                    Vision.SmoothBilateral(imagePreviewSn, ksize_trackBar.Value);
                    break;
                default:
                    MessageBox.Show("fail");
                    return;
            }

            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }
    }
}
