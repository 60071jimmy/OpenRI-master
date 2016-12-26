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

    public partial class Threshold_Form : Form
    {
        int type = 0;
        int threshold_Type = 1;
        FormMain formMain;
        int imagePreviewSn = -1;
        int imageProcessedSn = -1;

        public Threshold_Form(FormMain parent)
        {
            try
            {
                InitializeComponent();
                formMain = parent;
                imagePreviewSn = Vision.NewImage();
            }
            catch (Exception m)
            {
                Vision.Log("Threshold : " + m.Message);
            }
        }

        String TypeToLabel(int Threshold, int Threshold_Type, int type, int variables_1, int variables_2)
        {
            String Final_String = "Status: ";
            if (Threshold_Type == 1)
            {
                threshold_Type = 1;
                switch (type)
                {
                    case 0:
                        Final_String += "Threshold Binary";
                        break;
                    case 1:
                        Final_String += "Threshold Binary, Inverted";
                        break;
                    case 2:
                        Final_String += "Truncate";
                        break;
                    case 3:
                        Final_String += "Threshold to Zero";
                        break;
                    case 4:
                        Final_String += "Threshold to Zero, Inverted";
                        break;
                }
                Final_String = Final_String + ", Value=" + Threshold.ToString();
            }
            else if (Threshold_Type == 2)
            {
                threshold_Type = 2;
                Final_String += "Otsu Threshold";
            }
            else if (Threshold_Type == 3)
            {
                threshold_Type = 3;
                Final_String += "Adaptive Threshold, Block Size=" + variables_1.ToString() + ",C=" + variables_2.ToString();
            }

            return Final_String;
        }

        private void ThresholdValue_trackBar_Scroll(object sender, EventArgs e)
        {
            if (formMain.formImage == null)
            {
                return;
            }

            try
            {
                Threshold_Label.Text = Threshold_trackBar.Value.ToString();
                Status_Label.Text = TypeToLabel(Threshold_trackBar.Value, 1, type, hScrollBar1.Value * 2 + 1, hScrollBar2.Value);

                Threshold_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Threshold(Threshold_trackBar_Scroll) : " + m.Message);
            }
        }

        private void binary_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        type = 0;
                        Status_Label.Text = TypeToLabel(Threshold_trackBar.Value, 1, type, hScrollBar1.Value * 2 + 1, hScrollBar2.Value);
                        Threshold_Apply_Preview();
                    }
                }
            }
            catch (Exception m)
            {
                Vision.Log("Threshold(Threshold Binary) : " + m.Message);
            }
        }

        private void binaryInv_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        type = 1;
                        Status_Label.Text = TypeToLabel(Threshold_trackBar.Value, 1, type, hScrollBar1.Value * 2 + 1, hScrollBar2.Value);
                        Threshold_Apply_Preview();
                    }
                }
            }
            catch (Exception m)
            {
                Vision.Log("Threshold(Threshold Binary, Inverted): " + m.Message);
            }
        }

        private void truncate_radio_CheckedChanged(object sender, EventArgs e)
        {

            try
            {

                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        type = 2;
                        Status_Label.Text = TypeToLabel(Threshold_trackBar.Value, 1, type, hScrollBar1.Value * 2 + 1, hScrollBar2.Value);
                        Threshold_Apply_Preview();
                    }
                }
            }
            catch (Exception m)
            {
                Vision.Log("Threshold(Truncate) : " + m.Message);
            }
        }

        private void toZero_radio_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        type = 3;
                        Status_Label.Text = TypeToLabel(Threshold_trackBar.Value, 1, type, hScrollBar1.Value * 2 + 1, hScrollBar2.Value);
                        Threshold_Apply_Preview();
                    }
                }
            }
            catch (Exception m)
            {
                Vision.Log("Threshold(Threshold to Zero) : " + m.Message);
            }
        }

        private void toZeroInv_radio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        type = 4;
                        Status_Label.Text = TypeToLabel(Threshold_trackBar.Value, 1, type, hScrollBar1.Value * 2 + 1, hScrollBar2.Value);
                        Threshold_Apply_Preview();
                    }
                }
            }
            catch (Exception m)
            {
                Vision.Log("Threshold(Threshold to Zero, Inverted) : " + m.Message);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            try
            {
                label4.Text = (hScrollBar1.Value * 2 + 1).ToString();
                Status_Label.Text = TypeToLabel(Threshold_trackBar.Value, 3, type, hScrollBar1.Value * 2 + 1, hScrollBar2.Value);
                Threshold_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Threshold(neighbor area) : " + m.Message);
            }
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

            try
            {
                label5.Text = hScrollBar2.Value.ToString();
                Status_Label.Text = TypeToLabel(Threshold_trackBar.Value, 3, type, hScrollBar1.Value * 2 + 1, hScrollBar2.Value);
                Threshold_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Threshold(weight) : " + m.Message);
            }
        }

        private void otsu_button_Click(object sender, EventArgs e)
        {
            try
            {
                Status_Label.Text = TypeToLabel(Threshold_trackBar.Value, 2, type, hScrollBar1.Value * 2 + 1, hScrollBar2.Value);
                Threshold_Apply_Preview();
            }
            catch (Exception m)
            {
                Vision.Log("Threshold (Ostu Threshold): " + m.Message);
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
                Vision.Log("Threshold (OK): " + m.Message);
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
                Vision.Log("Threshold (Reset): " + m.Message);
            }
        }

        private void Threshold_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(imagePreviewSn);

            if (formMain.formImage != null)
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
        }

        private void Threshold_Apply_Preview()
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
            Vision.Threshold(imagePreviewSn, Threshold_trackBar.Value, threshold_Type, type, hScrollBar1.Value * 2 + 1, hScrollBar2.Value);
            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }
    }
}