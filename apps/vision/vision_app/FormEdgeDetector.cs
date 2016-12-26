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
    public partial class FormEdgeDetector : Form
    {
        FormMain formMain;
        int type = 1;
        int ksize = 3;
        int imagePreviewSn = -1;
        int imageProcessedSn = -1;

        public FormEdgeDetector(FormMain parent)
        {           
            try
            {
                InitializeComponent();
                formMain = parent;
                imagePreviewSn = Vision.NewImage();

            }
            catch (Exception m)
            {
                Vision.Log("EdgeDetector : " + m.Message);
            }
        }

        private void Edge_Detector_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception m)
            {
                Vision.Log("EdgeDetector : " + m.Message);
            }
        }

        private void ksize_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                ksize = 2 * ksize_trackBar.Value + 1;
                ksize_label.Text = ksize.ToString();
                FormEdgeDetector_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("EdgeDetector(Canny Kernel size) : " + m.Message);
            }
        }

        private void scale_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                scale_label.Text = scale_trackBar.Value.ToString();
                FormEdgeDetector_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("EdgeDetector(Canny Threshold) : " + m.Message);
            }
        }

        private void canny_button_Click(object sender, EventArgs e)
        {
            try
            {
                type = 1;
                canny_button.ForeColor = System.Drawing.Color.Red;
                sobel_button.ForeColor = System.Drawing.Color.Black;
                laplace_button.ForeColor = System.Drawing.Color.Black;
                scale_textbox.Text = "Threshold";
                scale_trackBar.SetRange(10, 254);
                scale_label.Text = scale_trackBar.Value.ToString();
                ksize = 2 * ksize_trackBar.Value + 1;
                ksize_label.Text = ksize.ToString();
                FormEdgeDetector_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("EdgeDetector(Canny) : " + m.Message);
            }
        }

        private void sobel_button_Click(object sender, EventArgs e)
        {
            try
            {
                type = 2;
                canny_button.ForeColor = System.Drawing.Color.Black;
                sobel_button.ForeColor = System.Drawing.Color.Red;
                laplace_button.ForeColor = System.Drawing.Color.Black;
                scale_textbox.Text = "Scale";
                scale_trackBar.SetRange(1, 10);
                scale_label.Text = scale_trackBar.Value.ToString();
                ksize = 2 * ksize_trackBar.Value + 1;
                ksize_label.Text = ksize.ToString();
                FormEdgeDetector_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("EdgeDetector(sobel) : " + m.Message);
            }
        }

        private void laplace_button_Click(object sender, EventArgs e)
        {
            try
            {
                type = 3;
                canny_button.ForeColor = System.Drawing.Color.Black;
                sobel_button.ForeColor = System.Drawing.Color.Black;
                laplace_button.ForeColor = System.Drawing.Color.Red;
                scale_textbox.Text = "Threshold";
                scale_trackBar.SetRange(1, 10);
                scale_label.Text = scale_trackBar.Value.ToString();
                ksize = 2 * ksize_trackBar.Value + 1;
                ksize_label.Text = ksize.ToString();
                FormEdgeDetector_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("EdgeDetector(laplace) : " + m.Message);
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage != null)
            {
                if (imageProcessedSn == formMain.formImage.imageSn)
                    Vision.CloneImage(imagePreviewSn, formMain.formImage.imageSn);
            }
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEdgeDetector_Apply_Preview()
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
            switch (type)
            {
                case 1:
                    Vision.EdgeCanny(imagePreviewSn, ksize, scale_trackBar.Value);
                    break;
                case 2:
                    Vision.EdgeSobel(imagePreviewSn, ksize, scale_trackBar.Value);
                    break;
                case 3:
                    Vision.EdgeLaplace(imagePreviewSn, ksize, scale_trackBar.Value);
                    break;
                default:
                    MessageBox.Show("fail");
                    return;
            }
            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }

        private void FormEdgeDetector_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(imagePreviewSn);

            if (formMain.formImage != null)
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
        }
    }
}
