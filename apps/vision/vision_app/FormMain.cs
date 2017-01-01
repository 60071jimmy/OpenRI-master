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
using System.Collections.Generic;														//  引入System.Collections.Generic函式庫
using System.ComponentModel;															//  引入System.ComponentModel函式庫
using System.Data;																		//  引入System.Data函式庫
using System.Linq;																		//  引入System.Linq函式庫
using System.Text;																		//  引入System.Text函式庫
using System.Windows.Forms;																//  引入System.Windows.Forms函式庫
using System.Threading;																	//  引入System.Threading函式庫
using System.Globalization;																//  引入System.Globalization函式庫
using System.Resources;																	//  引入System.Resources函式庫
using System.IO;																		//  引入System.IO函式庫
using System.IO.Ports;																	//  引入System.IO.Ports函式庫
using System.Drawing;																	//  引入System.Drawing函式庫
using System.Runtime.InteropServices;													//  引入System.Runtime.InteropServices函式庫
using System.Windows;																	//  引入System.Windows函式庫

namespace app																			//  命名空間app
{																						//  進入app命名空間
    //public delegate bool CallBack(int hwnd, int lParam);								//  
    public partial class FormMain : Form												//  FormMain類別
	{																					//	進入FormMain類別
		//public static int hwndR1;


        private OpenFileDialog openImageDialog;											//	宣告openImageDialog為OpenFileDialog物件
		public SaveFileDialog saveImageDialog;											//	宣告saveImageDialog為SaveFileDialog物件
		public FormImage formImage = null;

        public FormMain()																//	FormMain副程式
		{																				//	進入FormMain副程式
			InitializeComponent();														//	初始化UI元件
			ErrorCodeClass.ErrorCode = 0;												//	初始化ErrorCode為0
		}																				//	結束FormMain副程式

		private void FormMain_Load(object sender, EventArgs e)							//	FormMain_Load副程式
		{																				//	進入FormMain_Load副程式
			int ret = Vision.InitLib();

            Vision.EnableDbg();
            
            Vision.OpenLog("log.txt");

            openImageDialog = new OpenFileDialog();
            openImageDialog.Title = "Open Image";
            openImageDialog.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.png;";

            saveImageDialog = new SaveFileDialog();
            saveImageDialog.Title = "Save Image As";
            saveImageDialog.Filter = "Image files|*.png;";

            this.Text = "OpenRI - Vision";												//	設定視窗名稱為"OpenRI - Vision"
		}																				//	結束FormMain_Load副程式

		private void openToolStripMenuItem_Click(object sender, EventArgs e)			//	openToolStripMenuItem_Click副程式
		{																				//	進入openToolStripMenuItem_Click副程式
			if (openImageDialog.ShowDialog() == DialogResult.OK)                        //	若openImageDialog視窗點選OK
			{																			//	進入if敘述
                formImage = new FormImage();											//	建立新影像視窗
                formImage.formMain = this;                                              //	設定父視窗為FormMain
				formImage.AutoSize = true;												//	設定影像視窗自動大小
                formImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;					//	設定AutoSizeMode
				formImage.MdiParent = this;
                formImage.imageFileName = openImageDialog.FileName;
                formImage.Show();

                //test
                /*
                Vision.LoadImage(0, openImageDialog.FileName);
                formImageDll = new FormImageDll();
                formImageDll.Show();
                formImageDll.DrawImage();
                //
                formImage.bmpImage_Ori = formImage.bmpImage;
                formImage.bmpImage_Undo = formImage.bmpImage;
                Bitmap img = new Bitmap(openImageDialog.FileName);
                Vision.Log("=====================================");
                Vision.Log("File open : " + openImageDialog.FileName);
                */

            }																			//	結束if敘述
		}																				//	結束openToolStripMenuItem_Click副程式

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)			//	SaveAsToolStripMenuItem_Click副程式
		{																				//	進入SaveAsToolStripMenuItem_Click副程式
			if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                //Vision.SaveImage(imageSn, saveImageDialog.FileName);
                //formImage.bmpImage.Save(saveImageDialog.FileName);
            }
		}																				//	結束SaveAsToolStripMenuItem_Click副程式

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.Log("FormMain_FormClosed ++");
            Vision.StopWebCam();
            //Vision.RiCom_Close();
            Vision.Log("FormMain_FormClosed --");
            Vision.CloseLog();
            Vision.CloseLib();
        }

        private void basucProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Basic_Control_Form BasicControldForm = new Basic_Control_Form(this);
            BasicControldForm.MdiParent = this;
            BasicControldForm.Show();
        }

        private void thresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Threshold_Form ThresholdForm = new Threshold_Form(this);
            ThresholdForm.MdiParent = this;
            ThresholdForm.Show();
        }

        private void findEdgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEdgeDetector find_edge = new FormEdgeDetector(this);
            find_edge.MdiParent = this;
            find_edge.Show();
        }

        private void dilateErodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDilateErode dilate_erode = new FormDilateErode(this);
            dilate_erode.MdiParent = this;
            dilate_erode.Show();
        }

        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSmooth smooth = new FormSmooth(this);
            smooth.MdiParent = this;
            smooth.Show();
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSharpen sharpen_form = new FormSharpen(this);
            sharpen_form.MdiParent = this;
            sharpen_form.Show();
        }

        private void noiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNoise noise_form = new FormNoise(this);
            noise_form.MdiParent = this;
            noise_form.Show();
        }

        private void fFTDFTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFFT FFT_form = new FormFFT(this);
            FFT_form.MdiParent = this;
            FFT_form.Show();
        }

        private void harrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWavelet wavelet_form = new FormWavelet(this);
            wavelet_form.MdiParent = this;
            wavelet_form.Show();
        }

        private void brightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBrightnessContrast brightness_form = new FormBrightnessContrast(this);
            brightness_form.MdiParent = this;
            brightness_form.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (saveImageDialog.ShowDialog() == DialogResult.OK)
                {
                //    formImage.bmpImage.Save(saveImageDialog.FileName);
                }
            }
            catch (Exception m)
            {
                Vision.Log(" saveAs : " + m.Message);
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void imageTest1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Vision.Test1();
        }

        private void imageTest2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormOpenGL openGL = new FormOpenGL(formImage);
            //openGL.MdiParent = this;
            //openGL.Show();
        }

        private void imageTest3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string fileName = "測試Image_Test3.txt";
            //UTF8Encoding utf8 = new UTF8Encoding();
            //Byte[] encodedBytes = utf8.GetBytes(fileName);
            //string str = utf8.GetString(encodedBytes);
            //Vision.Test3(fileName, fileName.Length);
        }

        private void imageTest4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string fileContent = "測試測試測試測試";
            //int a = Vision.Test4(fileContent, fileContent.Length);

        }

        private void webCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWebCam formWebCam = new FormWebCam();
            formWebCam.MdiParent = this;
            formWebCam.Show();
        }

        private void spectialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpecialFilter formSpecialFilter = new FormSpecialFilter(this);
            formSpecialFilter.MdiParent = this;
            formSpecialFilter.Show();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                formImage.pictureBoxImage.Image = formImage.bmpImage_Undo;
            }
            catch (Exception m)
            {
                Vision.Log("undo : " + m.Message);
            }
            */
        }
	}																					//	結束FormMain類別
}
