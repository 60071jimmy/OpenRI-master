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
    public partial class FormWavelet : Form
    {
        int type = 1;
        float HP = 2;
        float LP = 2;
        FormMain formMain;
        int imagePreviewSn = -1;
        int imageProcessedSn = -1;

        public FormWavelet(FormMain parent)
        {           
            try
            {
                InitializeComponent();
                formMain = parent;
                imagePreviewSn = Vision.NewImage();
            }
            catch (Exception m)
            {
                Vision.Log("Wavelet : " + m.Message);
                
            }
        }

        private void Haar_Wavelet_Button_Click(object sender, EventArgs e)
        {
            try
            {
                FormWavelet_Transform_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Wavelet ( Haar_Wavelet): " + m.Message);
            }
        }

        private void Inverse_Haar_Wavelet_Button_Click(object sender, EventArgs e)
        {
            try
            {
                FormWavelet_Filtering_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Wavelet ( Inverse_Haar_Wavelet): " + m.Message);
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
                Vision.Log("Wavelet ( save): " + m.Message);
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
                Vision.Log("Wavelet ( reset): " + m.Message);
            }
        }

        private void Wavelet_Track_Bar_Scroll(object sender, EventArgs e)
        {           
            try
            {
                Wavelet_Label.Text = Wavelet_Track_Bar.Value.ToString();
                FormWavelet_Transform_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Wavelet ( reset): " + m.Message);
            }
        }

        private void Haar_Button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                type = 1;
                FormWavelet_Transform_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Wavelet ( haar ): " + m.Message);
            }
            
        }

        private void SYM_Button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                type = 2;
                FormWavelet_Transform_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Wavelet ( SYM ): " + m.Message);
            }
        }

        private void Low_Filter_trackBar_Scroll(object sender, EventArgs e)
        {           
            try
            {
                lowPass_label.Text = Low_Filter_trackBar.Value.ToString();
                LP = Low_Filter_trackBar.Value;
                FormWavelet_Filtering_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Wavelet ( LP Filter ): " + m.Message);
            }
        }

        private void High_Filter_trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                hightPass_label.Text = High_Filter_trackBar.Value.ToString();
                HP = Low_Filter_trackBar.Value;
                FormWavelet_Filtering_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Wavelet ( HP Filter ): " + m.Message);
            }
        }

        private void FormWavelet_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(imagePreviewSn);

            if (formMain.formImage != null)
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
        }

        private void FormWavelet_Transform_Preview()
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;

            Vision.CvHaarWavelet(formMain.formImage.imageSn, imagePreviewSn, type, Wavelet_Track_Bar.Value, HP, LP);
            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }

        private void FormWavelet_Filtering_Preview()
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;

            Vision.CvInvHaarWavelet(formMain.formImage.imageSn, imagePreviewSn, type, Wavelet_Track_Bar.Value, HP, LP);
            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }
    }
}
