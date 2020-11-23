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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void checkSteganographyInImg_Click(object sender, EventArgs e)
        {
            CheckImageSteganography checkImageSteganography = new CheckImageSteganography();
            checkImageSteganography.Show();
        }

        private void checkSteganographyInWav_Click(object sender, EventArgs e)
        {
            CheckAudioSteganography checkAudioSteganography = new CheckAudioSteganography();
            checkAudioSteganography.Show();
        }

        private void encodeAnythingInImage_Click(object sender, EventArgs e)
        {
            EncodeAnythingInImg encodeAnythingInImg = new EncodeAnythingInImg();
            encodeAnythingInImg.Show();
        }

        private void decodeAnythingFromImage_Click(object sender, EventArgs e)
        {
            DecodeAnythingFromImg decodeAnythingFromImg = new DecodeAnythingFromImg();
            decodeAnythingFromImg.Show();
        }

        private void encodeAnythingInWav_Click(object sender, EventArgs e)
        {
            EncodeAnythingInWav encodeAnythingInWav = new EncodeAnythingInWav();
            encodeAnythingInWav.Show();
        }

        private void decodeAnythingFromWav_Click(object sender, EventArgs e)
        {
            DecodeAnythingFromWav decodeAnythingFromWav = new DecodeAnythingFromWav();
            decodeAnythingFromWav.Show();
        }
    }
}
