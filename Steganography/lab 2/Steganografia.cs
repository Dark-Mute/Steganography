using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Steganografia : Form
    {
        public Steganografia()
        {
            InitializeComponent();
            this.PointToScreen(new Point(0, 0));
            this.CenterToScreen();
        }


        private void decodeTextFromImg_Click(object sender, EventArgs e)
        {
            DekodojImgText dekodojImgText = new DekodojImgText();
            dekodojImgText.Show();
        }

        private void decodeImgFromImg_Click(object sender, EventArgs e)
        {
            DekodojImgImg dekodojImgImg = new DekodojImgImg();
            dekodojImgImg.Show();
        }

        private void decodeTextFromwav_Click(object sender, EventArgs e)
        {
            DekodojWaveText dekodojWaveText = new DekodojWaveText();
            dekodojWaveText.Show();
        }

        private void encodeTextInImg_Click(object sender, EventArgs e)
        {
            EncodeTextInImg encodeTextInImg = new EncodeTextInImg();
            encodeTextInImg.Show();
        }

        private void encodeImgInImg_Click(object sender, EventArgs e)
        {
            EncodeImgInImg encode = new EncodeImgInImg();
            encode.Show();
        }

        private void encodeTextInWav_Click(object sender, EventArgs e)
        {
            EncodeTextInWav encode = new EncodeTextInWav();
            encode.Show();
        }

      
        
        Form old = null;
        private void showAndHideForms(Form form)
        {
            if (old != null)
            {
                old.Close();
            }      
            form.TopLevel = false;
            form.Location = new Point(0, 0);
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(form);
            form.Show();
            old = form;
        }

        private void checkSteganographyInImg_Click(object sender, EventArgs e)
        {
            CheckImageSteganography checkImageSteganography = new CheckImageSteganography();
            showAndHideForms(checkImageSteganography);
        }

        private void checkSteganographyInWav_Click(object sender, EventArgs e)
        {
            CheckAudioSteganography checkAudioSteganography = new CheckAudioSteganography();
            showAndHideForms(checkAudioSteganography);
        }

        private void encodeAnythingInImage_Click(object sender, EventArgs e)
        {
            EncodeAnythingInImg encodeAnythingInImg = new EncodeAnythingInImg();
            showAndHideForms(encodeAnythingInImg);
        }

        private void decodeAnythingFromImage_Click(object sender, EventArgs e)
        {
            DecodeAnythingFromImg decodeAnythingFromImg = new DecodeAnythingFromImg();
            showAndHideForms(decodeAnythingFromImg);
        }
       
        private void encodeAnythingInWav_Click(object sender, EventArgs e)
        {
            EncodeAnythingInWav encodeAnythingInWav1 = new EncodeAnythingInWav();
            showAndHideForms(encodeAnythingInWav1);
        }

        private void decodeAnythingFromWav_Click(object sender, EventArgs e)
        {
            DecodeAnythingFromWav decodeAnythingFromWav1 = new DecodeAnythingFromWav();
            showAndHideForms(decodeAnythingFromWav1);
        }
    }
}
