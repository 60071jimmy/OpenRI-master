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
    public partial class FormSpecialFilter : Form
    {
        FormMain formMain;
        int imagePreviewSn = -1;
        int imageProcessedSn = -1;

        public FormSpecialFilter(FormMain parent)
        {
            InitializeComponent();

            formMain = parent;
            imagePreviewSn = Vision.NewImage();

        }

        private void Sketch_button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);

            Vision.Sketch(imagePreviewSn);

            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }

        private void Cartoon_button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);

            Vision.Cartoon(imagePreviewSn);

            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }

        private void Sculpture_button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);

            Vision.MaskSharpen(imagePreviewSn);

            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }

        private void GroundGlass_button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage == null) return;

            imageProcessedSn = formMain.formImage.imageSn;
            Vision.CloneImage(formMain.formImage.imageSn, imagePreviewSn);

            Vision.GroundGlass(imagePreviewSn);

            formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(imagePreviewSn);
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (formMain.formImage != null)
            {
                if (imageProcessedSn == formMain.formImage.imageSn)
                    Vision.CloneImage(imagePreviewSn, formMain.formImage.imageSn);
            }
            this.Close();
        }

        private void FormSpecialFilter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vision.FreeImage(imagePreviewSn);

            if (formMain.formImage != null)
                formMain.formImage.pictureBoxImage.Image = Vision.GetBitmap(formMain.formImage.imageSn);
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
