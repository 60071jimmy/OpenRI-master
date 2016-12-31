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

using System;																			//  引入System函式庫
using System.Collections.Generic;                                                       //	引入System.Collections.Generic函式庫
using System.ComponentModel;                                                            //	引入System.ComponentModel函式庫
using System.Data;                                                                      //	引入System.Data函式庫
using System.Drawing;                                                                   //	引入System.Drawing函式庫
using System.Linq;                                                                      //	引入System.Linq函式庫
using System.Text;                                                                      //	引入System.Text函式庫
using System.Windows.Forms;                                                             //	引入System.Windows.Forms函式庫

namespace app
{
    public partial class Basic_Control_Form : Form
    {
        bool isApply = false;
        int imageProcessedSn = -1;
        int type = -1;
        int var1 = -1;
        int var2 = -1;
        int selectedChannel = 0;
        FormMain formMain;
        int imagePreviewSn = -1;

        public Basic_Control_Form(FormMain parent)
        {
            InitializeComponent();
            try
            {
                formMain = parent;
                imagePreviewSn = Vision.NewImage();

                ColorSpacePreview1.SizeMode = PictureBoxSizeMode.Zoom;
                ColorSpacePreview2.SizeMode = PictureBoxSizeMode.Zoom;
                ColorSpacePreview3.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception e)
            {
                Vision.Log("Basic process : " + e.Message);
            }
            
        }

        private void Equilzation_Click(object sender, EventArgs e)
        {
            
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            type = 1;
            var1 = 0;
            var2 = 0;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
            if (Vision.BasicProcess(imagePreviewSn, type, var1, var2) < 0)
            {
                MessageBox.Show("fail");
            }
            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }

        private void ConvertToGray_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            type = 2;
            var1 = 0;
            var2 = 0;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
            if (Vision.BasicProcess(imagePreviewSn, type, var1, var2) < 0)
            {
                MessageBox.Show("fail");
            }
            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }

        private void lockRatio_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lockRatio.Checked)
                Resize_Height_Textbox.ReadOnly = true;
            else if (!this.lockRatio.Checked)
                Resize_Height_Textbox.ReadOnly = false;
        }

        private void Resize_Button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            try
            {
                int width = 0;
                int height = 0;


                // Resize 無作用！要抓問題！！

                if (Int32.TryParse(Resize_Width_Textbox.Text, out width) && Int32.TryParse(Resize_Height_Textbox.Text, out height))
                {
                    type = 3;
                    var1 = width;
                    var2 = height;

                    Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
                    if (Vision.BasicProcess(imagePreviewSn, type, var1, var2) < 0)
                    {
                        MessageBox.Show("fail");
                    }
                    formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
                    formMain.formImage.Width = width;
                    formMain.formImage.Height = height;
                    formMain.formImage.Refresh();
                }
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(Resize) : " + m.Message);
            }
        }

        private void Resize_Width_Textbox_TextChanged(object sender, EventArgs e)
        {
            int width = 0;
            if (Int32.TryParse(Resize_Width_Textbox.Text, out width) && this.lockRatio.Checked)
            {
                //Resize_Height_Textbox.Text = ((int) (width * formImage.bmpImage_Ori.Height / formImage.bmpImage_Ori.Width)).ToString();
            }
                
        }

        private void RGB_Button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            try
            {
                imageProcessedSn = formMain.formImage.imageSn;
                type = 4;
                var1 = 1;
                var2 = 0;
                Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
                if (Vision.BasicProcess(imagePreviewSn, type, var1, var2) < 0)
                {
                    MessageBox.Show("fail");
                }
                ColorSpacePreview1.Image = Vision.GetBitmap(imagePreviewSn, 0);
                ColorSpacePreview2.Image = Vision.GetBitmap(imagePreviewSn, 1);
                ColorSpacePreview3.Image = Vision.GetBitmap(imagePreviewSn, 2);

                ColorSpace_Var1_Label.Text = "R";
                ColorSpace_Var2_Label.Text = "G";
                ColorSpace_Var3_Label.Text = "B";
 
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(RGB) : " + m.Message);
            }
        }

        private void HSV_Button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            try
            {
                //1.CV_BGR2RGB
                //2.CV_BGR2HSV
                //3.CV_BGR2XYZ
                //4.CV_BGR2HLS
                //5.CV_BGR2Lab
                //6.CV_BGR2Luv
                //7.CV_BGR2YCrCb
                imageProcessedSn = formMain.formImage.imageSn;
                type = 4;
                var1 = 2;
                var2 = 0;
                Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
                if (Vision.BasicProcess(imagePreviewSn, type, var1, var2) < 0)
                {
                    MessageBox.Show("fail");
                }
                ColorSpacePreview1.Image = Vision.GetBitmap(imagePreviewSn, 0);
                ColorSpacePreview2.Image = Vision.GetBitmap(imagePreviewSn, 1);
                ColorSpacePreview3.Image = Vision.GetBitmap(imagePreviewSn, 2);

                ColorSpace_Var1_Label.Text = "H";
                ColorSpace_Var2_Label.Text = "S";
                ColorSpace_Var3_Label.Text = "V";
 
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(HSV) : " + m.Message);
            }
        }

        private void XYZ_Button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            try 
            {
                imageProcessedSn = formMain.formImage.imageSn;
                type = 4;
                var1 = 3;
                var2 = 0;
                Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
                if (Vision.BasicProcess(imagePreviewSn, type, var1, var2) < 0)
                {
                    MessageBox.Show("fail");
                }
                ColorSpacePreview1.Image = Vision.GetBitmap(imagePreviewSn, 0);
                ColorSpacePreview2.Image = Vision.GetBitmap(imagePreviewSn, 1);
                ColorSpacePreview3.Image = Vision.GetBitmap(imagePreviewSn, 2);

                ColorSpace_Var1_Label.Text = "X";
                ColorSpace_Var2_Label.Text = "Y";
                ColorSpace_Var3_Label.Text = "Z";
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(XYZ) : " + m.Message);
            }

        }

        private void HLS_Button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            try
            {
                imageProcessedSn = formMain.formImage.imageSn;
                type = 4;
                var1 = 4;
                var2 = 0;
                Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
                if (Vision.BasicProcess(imagePreviewSn, type, var1, var2) < 0)
                {
                    MessageBox.Show("fail");
                }
                ColorSpacePreview1.Image = Vision.GetBitmap(imagePreviewSn, 0);
                ColorSpacePreview2.Image = Vision.GetBitmap(imagePreviewSn, 1);
                ColorSpacePreview3.Image = Vision.GetBitmap(imagePreviewSn, 2);

                ColorSpace_Var1_Label.Text = "H";
                ColorSpace_Var2_Label.Text = "L";
                ColorSpace_Var3_Label.Text = "S";
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(HLS) : " + m.Message);
            }
        }

        private void Lab_Button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            try
            {
                imageProcessedSn = formMain.formImage.imageSn;
                type = 4;
                var1 = 5;
                var2 = 0;
                Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
                if (Vision.BasicProcess(imagePreviewSn, type, var1, var2) < 0)
                {
                    MessageBox.Show("fail");
                }
                ColorSpacePreview1.Image = Vision.GetBitmap(imagePreviewSn, 0);
                ColorSpacePreview2.Image = Vision.GetBitmap(imagePreviewSn, 1);
                ColorSpacePreview3.Image = Vision.GetBitmap(imagePreviewSn, 2);

                ColorSpace_Var1_Label.Text = "L";
                ColorSpace_Var2_Label.Text = "a";
                ColorSpace_Var3_Label.Text = "b";
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(Lab) : " + m.Message);
            }
        }

        private void LUV_Button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            try
            {
                imageProcessedSn = formMain.formImage.imageSn;
                type = 4;
                var1 = 6;
                var2 = 0;
                Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
                if (Vision.BasicProcess(imagePreviewSn, type, var1, var2) < 0)
                {
                    MessageBox.Show("fail");
                }
                ColorSpacePreview1.Image = Vision.GetBitmap(imagePreviewSn, 0);
                ColorSpacePreview2.Image = Vision.GetBitmap(imagePreviewSn, 1);
                ColorSpacePreview3.Image = Vision.GetBitmap(imagePreviewSn, 2);

                ColorSpace_Var1_Label.Text = "L";
                ColorSpace_Var2_Label.Text = "U";
                ColorSpace_Var3_Label.Text = "V";
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(LUV) : " + m.Message);
            }
        }

        private void YCrCb_Button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null)
            {
                MessageBox.Show("未載入圖檔");
                return;
            }
                

            try
            {
                imageProcessedSn = formMain.formImage.imageSn;
                type = 4;
                var1 = 7;
                var2 = 0;
                Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);
                if (Vision.BasicProcess(imagePreviewSn, type, var1, var2) < 0)
                {
                    MessageBox.Show("fail");
                }
                ColorSpacePreview1.Image = Vision.GetBitmap(imagePreviewSn, 0);
                ColorSpacePreview2.Image = Vision.GetBitmap(imagePreviewSn, 1);
                ColorSpacePreview3.Image = Vision.GetBitmap(imagePreviewSn, 2);

                ColorSpace_Var1_Label.Text = "Y";
                ColorSpace_Var2_Label.Text = "Cr";
                ColorSpace_Var3_Label.Text = "Cb";
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(YCrCb) : " + m.Message);
            }
        }

        private void ColorSpacePreview1_Click(object sender, EventArgs e)
        {           
            try
            {
                selectedChannel = 0;
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn, selectedChannel);
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(YCrCb) : " + m.Message);
            }
        }

        private void ColorSpacePreview2_Click(object sender, EventArgs e)
        {
            
            try
            {
                selectedChannel = 1;
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn, selectedChannel);
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(YCrCb) : " + m.Message);
            }
        }

        private void ColorSpacePreview3_Click(object sender, EventArgs e)
        {
            try
            {
                selectedChannel = 2;
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn, selectedChannel);
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(YCrCb) : " + m.Message);
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == -1 || type > 4 || formMain.formImage == null)
                {
                    isApply = false;
                    this.Close();
                }
                else
                {
                    if (imageProcessedSn == formMain.formImage.imageSn)
                    {
                        isApply = true;
                        Vision.CloneImage(imagePreviewSn, formMain.formImage.imageSn);
                    }
                    this.Close();
                }
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(YCrCb) : " + m.Message);
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            try
            {
                isApply = false;
                this.Close();
            }
            catch (Exception m)
            {
                Vision.Log("Basic process(YCrCb) : " + m.Message);
            }
        }

        private void Basic_Control_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(imagePreviewSn);

            if (formMain.formImage != null)
            {
                if (isApply == true)
                {
                    if (type < 4)
                    {
                        formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
                    }
                    else if (type == 4)
                    {
                        formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn, selectedChannel);
                    }
                }
                else
                {
                    formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
                }
            }
        }
    }
}