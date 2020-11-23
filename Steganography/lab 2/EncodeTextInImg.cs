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
    public partial class EncodeTextInImg : Form
    {
        public EncodeTextInImg()
        {
            InitializeComponent();
        }

        ImageManipulation imageManipulation = new ImageManipulation();
        ImageSteganography imageSteganography = new ImageSteganography();
        TextFileManipulation textFileManipulation = new TextFileManipulation();
        public Bitmap imageBeforeSteganography = null;  
        public Bitmap imageAfterteganography = null;
        public string textBytes = null;


        string encodedeExtension;
        int maxsize = 0;
        int taken = 0;


        private void calculateFreeMemorySize()
        {
            int R, G, B;
            if (imageBeforeSteganography != null && int.TryParse(comboBox1.Text, out R) && int.TryParse(comboBox2.Text, out G) && int.TryParse(comboBox3.Text, out B) )
            {
                maxsize = imageSteganography.calculateFreeSiezOfImage(imageBeforeSteganography.Height, imageBeforeSteganography.Width, R + G + B);
                imageSteganography.calculateMemoryUsageAndShowInLable(maxsize, maxsizeLabel);
                progressBar1.Maximum = maxsize;
                calculateMemoryTakenByText();
            }
        }

        private void calculateMemoryTakenByText()
        {
            if (maxsize > 0 && textBytes != null)
            {
                taken = imageSteganography.calculateMaxSiezOfText(textBytes.Length,"txt");
                if (taken > 0 && taken <= maxsize)
                {
                    progressBar1.Value = taken;
                    label2.Text = Math.Round(((float)taken / maxsize) * 100, 2).ToString() + "%";
                    imageSteganography.calculateMemoryUsageAndShowInLable( taken, takenLabel);
                }
                else
                {
                    message.Text = "Niestety plik który wybrałeś jest za duży";
                    message.ForeColor = Color.Red;
                }
            }
        }


        private void loadFile_Click_1(object sender, EventArgs e)
        {
            string file = imageManipulation.getFille("(*.png)|*.png|(*.jpg)|*.jpg|(*.jpge)|*.jpge");
            if (file != "none")
            {
                encodedeExtension = Path.GetExtension(file).Substring(1);
                imageBeforeSteganography = imageManipulation.getImageBitmap(file);
                isSteganograph.Text = imageSteganography.CheckImage(imageBeforeSteganography);
                pictureEncodeBefore.Visible = true;
                pictureEncodeBefore.Image = imageBeforeSteganography;
                pictureEncodeBefore.SizeMode = PictureBoxSizeMode.StretchImage;
                encodeLabel.Text = string.Format("Wykożystujesz zdjęcie: {0}", Path.GetFileName(file));
                encodeLabel.Visible = true;
                calculateFreeMemorySize();
            }
        }

        private void loadFileToBeEncoded_Click(object sender, EventArgs e)
        {
            string file = imageManipulation.getFille("(*.txt)|*.txt");
            if (Path.GetExtension(file) == ".txt")
            {
                textBytes = imageSteganography.convertBytesToString(textFileManipulation.getTextFileBytes(file));
                decodeLabel.Text = string.Format("Wykożystujesz plik tekstowy: {0}", Path.GetFileName(file));
                calculateMemoryTakenByText();
            }
            
        }

      


        private void encode_Click(object sender, EventArgs e)
        {
            int R, G, B;

            if (imageBeforeSteganography != null && textBytes != null && int.TryParse(comboBox1.Text, out R) && int.TryParse(comboBox2.Text, out G) && int.TryParse(comboBox3.Text, out B) && taken <= maxsize)
            {
                pictureEncodeAfter.Image = imageAfterteganography = imageSteganography.EncryptBinaryInImage(imageBeforeSteganography, textBytes, "txt",R, G, B);
                pictureEncodeAfter.SizeMode = PictureBoxSizeMode.StretchImage;
                imageManipulation.saveImgWithExtension(imageAfterteganography, encodedeExtension, message);
            }
            else
            {
                message.Text = "Coś jest nietak z podanymi danymi";
                message.ForeColor = Color.Red;
            }
        }

        private void onValueHange(object sender, EventArgs e)
        {
            calculateFreeMemorySize();
            calculateMemoryTakenByText();
        }
    }
}
