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
    public partial class FormFFT : Form
    {
        int[] channels = new int[3];
        int filterType = 1; // 1:ideal 2:butterworth 3:gaussian
        int passType = 1; // 1:highpass 2:lowpass
        int radius = 1;
        int n = 1;
        FormMain formMain;
        int imagePreviewSn = -1;
        int imageProcessedSn = -1;

        public FormFFT(FormMain parent)
        {
            try
            {
                InitializeComponent();

                formMain = parent;
                imagePreviewSn = Vision.NewImage();

                channels[0] = Vision.NewImage();
                channels[1] = Vision.NewImage();
                channels[2] = Vision.NewImage();

                PictureBox_FFT_0.SizeMode = PictureBoxSizeMode.Zoom;
                PictureBox_FFT_1.SizeMode = PictureBoxSizeMode.Zoom;
                PictureBox_FFT_2.SizeMode = PictureBoxSizeMode.Zoom;
                //trackBar1.Maximum = (formImage.bmpImage.Width > formImage.bmpImage.Height) ? formImage.bmpImage.Height / 2 : formImage.bmpImage.Width / 2;
            }
            catch (Exception m)
            {
                Vision.Log("FFT : " + m.Message);
            }
            
        }


        private void FFT_Button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            try
            {
                Vision.FFT(formMain.formImage.imageSn, channels[0], 0);
                Vision.FFT(formMain.formImage.imageSn, channels[1], 1);
                Vision.FFT(formMain.formImage.imageSn, channels[2], 2);

                PictureBox_FFT_0.Image = Vision.GetBitmap(channels[0]);
                PictureBox_FFT_1.Image = Vision.GetBitmap(channels[1]);
                PictureBox_FFT_2.Image = Vision.GetBitmap(channels[2]);

                PictureBox_FFT_0.Refresh();
                PictureBox_FFT_1.Refresh();
                PictureBox_FFT_2.Refresh();
            }
            catch (Exception m)
            {
                Vision.Log("FFT(FFT) : " + m.Message);
            }
        }

        private void ideal_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        filterType = 1;
                        radius_label.Text = "Radius"; ;
                        n_trackBar.Visible = false;
                        n_label.Visible = false;
                        label4.Visible = false;

                        ForemFFT_Apply_Preview();
                    }
                }
            }
            catch (Exception m)
            {
                Vision.Log("FFT(ideal filter) : " + m.Message);
            }
          
        }

        private void butterworth_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        filterType = 2;
                        radius_label.Text = "Radius";
                        n_trackBar.Visible = true;
                        n_label.Visible = true;
                        label4.Visible = true;

                        ForemFFT_Apply_Preview();
                    }
                }
            }
            catch (Exception m)
            {
                Vision.Log("FFT(butterworth filter) : " + m.Message);
            }
        }

        private void gaussian_radioButton_CheckedChanged(object sender, EventArgs e)
        {            
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        filterType = 3;
                        radius_label.Text = "Std"; ;
                        n_trackBar.Visible = false;
                        n_label.Visible = false;
                        label4.Visible = false;

                        ForemFFT_Apply_Preview();
                    }
                }
            }
            catch (Exception m)
            {
                Vision.Log("FFT(gaussian filter) : " + m.Message);
            }
        }

        private void hightPass_radioButton_CheckedChanged(object sender, EventArgs e)
        {          
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        passType = 1;

                        ForemFFT_Apply_Preview();
                    }
                }
            }
            catch (Exception m)
            {
                Vision.Log("FFT(HighPass filter) : " + m.Message);
            }
        }

        private void lowPass_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        passType = 2;

                        ForemFFT_Apply_Preview();
                    }
                }
            }
            catch (Exception m)
            {
                Vision.Log("FFT(LowPass filter) : " + m.Message);
            }
        }

        private void radius_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                radius = radius_trackBar.Value;
                label2.Text = radius_trackBar.Value.ToString();

                ForemFFT_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("FFT(Radius) : " + m.Message);
            }
        }

        private void n_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                n = n_trackBar.Value;
                label4.Text = n_trackBar.Value.ToString();

                ForemFFT_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("FFT(n) : " + m.Message);
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
                Vision.Log("FFT(save) : " + m.Message);
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
                Vision.Log("FFT(reset) : " + m.Message);
            }
        }

        private void FormFFT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(channels[0]);
            Vision.FreeImage(channels[1]);
            Vision.FreeImage(channels[2]);

            Vision.FreeImage(imagePreviewSn);

            if (formMain.formImage != null)
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
        }

        private void ForemFFT_Apply_Preview()
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);

            Vision.IFFT(imagePreviewSn, 0, filterType, passType, radius, n);

            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }
    }
}