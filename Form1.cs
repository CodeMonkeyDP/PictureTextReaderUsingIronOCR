using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;

namespace OCR_Using_IronOCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbLanguage.SelectedIndex = 0;
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            btnTransform.Enabled = false;
            
            var Ocr = new IronTesseract();

            // Если выбран русский язык
            switch (cbLanguage.SelectedIndex)
            {
                case 0:
                    Ocr.Language = OcrLanguage.EnglishBest;
                    break;

                case 1:
                    Ocr.Language = OcrLanguage.RussianBest;
                    break;
            }
                
            using (var Input = new OcrInput(pbPic.Image))
            {
                // Если изображение неровное
                if (chbAlign.Checked)
                    Input.Deskew();

                // Очистка шума
                if (chbNoise.Checked)
                    Input.DeNoise();
                var Result = Ocr.Read(Input);

                tbText.Text = Result.Text;
            }

            btnTransform.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (fd.ShowDialog() == DialogResult.OK)
            {
                pbPic.Image = Image.FromFile(fd.FileName);
                btnTransform.Enabled = true;
            }
        }
    }
}
