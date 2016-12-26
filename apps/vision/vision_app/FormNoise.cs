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
    public partial class FormNoise : Form
    {        
        FormMain formMain;
        int type = 1;
        int imagePreviewSn = -1;
        int imageProcessedSn = -1;

        public FormNoise(FormMain parent)
        {
            try
            {
                InitializeComponent();
                formMain = parent;
                imagePreviewSn = Vision.NewImage();
            }
            catch (Exception m)
            {
                Vision.Log("Noise : " + m.Message);
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            try
            {
                Mean_label.Text = NormalMean_trackBar.Value.ToString();
                FormNoise_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Noise (mean of normal distrubution): " + m.Message);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                Std_label.Text = NormalStd_trackBar.Value.ToString();
                FormNoise_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Noise (standard deviation of normal distrubution): " + m.Message);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {          
            try
            {
                LowBound_label.Text = uniformLow_trackBar.Value.ToString();
                FormNoise_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Noise (mean of uniform distrubution): " + m.Message);
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            
            try
            {
                HightBound_label.Text = uniformHight_trackBar.Value.ToString();
                FormNoise_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Noise (standard deviation of uniform distrubution): " + m.Message);
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
                Vision.Log("Noise (save): " + m.Message);
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
                Vision.Log("Noise (reset): " + m.Message);
            }

        }

        private void Normal_button_Click(object sender, EventArgs e)
        {
            type = 1;
            Normal_button.ForeColor = Color.Red;
            Unifrom_button.ForeColor = Color.Black;

            FormNoise_Apply_Preview();
        }

        private void Unifrom_button_Click(object sender, EventArgs e)
        {
            type = 2;
            Normal_button.ForeColor = Color.Black;
            Unifrom_button.ForeColor = Color.Red;

            FormNoise_Apply_Preview();
        }

        private void FormNoise_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(imagePreviewSn);

            if (formMain.formImage != null)
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
        }

        private void FormNoise_Apply_Preview()
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);

            switch (type)
            {
                case 1:
                    Vision.NormalNoise(imagePreviewSn, NormalMean_trackBar.Value, NormalStd_trackBar.Value);
                    break;
                case 2:
                    Vision.UniformNoise(imagePreviewSn, uniformLow_trackBar.Value, uniformHight_trackBar.Value);
                    break;
                default:
                    MessageBox.Show("fail");
                    return;
            }

            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }
    }
    
}
