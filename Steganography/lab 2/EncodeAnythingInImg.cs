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
    public partial class EncodeAnythingInImg : Form
    {
        public EncodeAnythingInImg()
        {
            InitializeComponent();
        }

        ImageManipulation imageManipulation = new ImageManipulation();
        ImageSteganography imageSteganography = new ImageSteganography();
        TextFileManipulation textFileManipulation = new TextFileManipulation();
        public Bitmap imageBeforeSteganography = null;
        public Bitmap imageAfterteganography = null;
        public string textBytes = null;
        string encodedeExtensionImage;
        string encodedeExtensionAnyFille;
        int maxsize = 0;
        int taken = 0;


        private void calculateFreeMemorySize()
        {
            int R, G, B;
            if (imageBeforeSteganography != null && int.TryParse(comboBox1.Text, out R) && int.TryParse(comboBox2.Text, out G) && int.TryParse(comboBox3.Text, out B))
            {
                maxsize = imageSteganography.calculateFreeSiezOfImage(imageBeforeSteganography.Height, imageBeforeSteganography.Width, R + G + B);
                int maxsizeofimg = imageSteganography.calculateFreeSiezOfImage(imageBeforeSteganography.Height, imageBeforeSteganography.Width, 24);
                imageSteganography.calculateMemoryUsageAndShowInLable(maxsizeofimg, maxSizeOfImg);
                imageSteganography.calculateMemoryUsageAndShowInLable(maxsize, maxsizeLabel);
                progressBar1.Maximum = maxsize;
                calculateMemoryTakenByText();
            }
        }

        private void calculateMemoryTakenByText()
        {
            if (maxsize > 0 && textBytes != null)
            {
                taken = imageSteganography.calculateMaxSiezOfText(textBytes.Length, encodedeExtensionAnyFille);
                if (taken > 0 && taken <= maxsize)
                {
                    progressBar1.Value = taken;
                    label2.Text = Math.Round(((float)taken / maxsize) * 100, 2).ToString() + "%";
                    imageSteganography.calculateMemoryUsageAndShowInLable(taken, takenLabel);
                    message.Text = "";
                }
                else
                {
                    message.Text = "Niestety wielkość plik u który wybrałeś jest\n" +
                                    "za duża na ilość bitów wybranych do kodowania";
                    message.ForeColor = Color.Red;
                    progressBar1.Value = 0;
                    label2.Text = "";
                    takenLabel.Text = "";
                }
            }
        }

        private void encode_Click(object sender, EventArgs e)
        {

            int R, G, B;

            if(imageBeforeSteganography == null)
            {
                encodeLabel.Text = "Nie wybrałeś zdjęcia";
                encodeLabel.ForeColor = Color.Red;
                return;
            }
            if(textBytes == null)
            {
                decodeLabel.Text = "Nie wybrałeś pliku do zakodowania";
                decodeLabel.ForeColor = Color.Red;
                return;
            }

            if (imageBeforeSteganography != null && textBytes != null && int.TryParse(comboBox1.Text, out R) && int.TryParse(comboBox2.Text, out G) && int.TryParse(comboBox3.Text, out B) && taken <= maxsize)
            {
                pictureEncodeAfter.Image = imageAfterteganography = imageSteganography.EncryptBinaryInImage(imageBeforeSteganography, textBytes, encodedeExtensionAnyFille, R, G, B);
                pictureEncodeAfter.SizeMode = PictureBoxSizeMode.StretchImage;
                imageManipulation.saveImgWithExtension(imageAfterteganography, encodedeExtensionImage, message);
            }
            else
            {
                message.Text = "Coś jest nietak z podanymi danymi być może\n plik który chcesz zakodować jest za duży";
                message.ForeColor = Color.Red;
            }

        }

        private void loadFileToBeEncoded_Click(object sender, EventArgs e)
        {
            string file = imageManipulation.getFille("(*.*)|*.*");
            if (file != "none" && Path.GetExtension(file) != "")
            {
                encodedeExtensionAnyFille = Path.GetExtension(file).Substring(1);
                byte[] bits = textFileManipulation.getFilleContent(file);
                textBytes = imageSteganography.convertBytesToString(bits);
                decodeLabel.ForeColor = Color.Black;
                decodeLabel.Text = string.Format("Wykożystujesz plik: {0}", Path.GetFileName(file));
                calculateMemoryTakenByText();
            }
            else
            {
                encodedeExtensionAnyFille = null;
                textBytes = null;
                decodeLabel.Text = "Nie wybrałeś pliku do zakodowania";
                decodeLabel.ForeColor = Color.Red;
                
            }
        }

        private void loadFile_Click(object sender, EventArgs e)
        {

            string file = imageManipulation.getFille("(*.png)|*.png|(*.jpg)|*.jpg|(*.jpge)|*.jpge");
            if (file != "none")
            {
                encodedeExtensionImage = Path.GetExtension(file).Substring(1);
                imageBeforeSteganography = imageManipulation.getImageBitmap(file);
                isSteganograph.Text = imageSteganography.CheckImage(imageBeforeSteganography);
                pictureEncodeBefore.Visible = true;
                pictureEncodeBefore.Image = imageBeforeSteganography;
                pictureEncodeBefore.SizeMode = PictureBoxSizeMode.StretchImage;
                encodeLabel.ForeColor = Color.Black;
                encodeLabel.Text = string.Format("Wykożystujesz zdjęcie: {0}", Path.GetFileName(file));          
                encodeLabel.Visible = true;
                calculateFreeMemorySize();
            }
            else
            {
                imageBeforeSteganography = null;
                encodeLabel.Text = "Nie wybrałeś zdjęcia";
                encodeLabel.ForeColor = Color.Red;
                pictureEncodeBefore.Image = null;
            }
        }

        private void onValueHange(object sender, EventArgs e)
        {
            calculateFreeMemorySize();
            calculateMemoryTakenByText();
        }

        private void pictureEncodeBefore_Click(object sender, EventArgs e)
        {
            string file = imageManipulation.getFille("(*.png)|*.png|(*.jpg)|*.jpg|(*.jpge)|*.jpge");
            if (file != "none")
            {
                encodedeExtensionImage = Path.GetExtension(file).Substring(1);
                imageBeforeSteganography = imageManipulation.getImageBitmap(file);
                isSteganograph.Text = imageSteganography.CheckImage(imageBeforeSteganography);
                pictureEncodeBefore.Visible = true;
                pictureEncodeBefore.Image = imageBeforeSteganography;
                pictureEncodeBefore.SizeMode = PictureBoxSizeMode.StretchImage;
                encodeLabel.ForeColor = Color.Black;
                encodeLabel.Text = string.Format("Wykożystujesz zdjęcie: {0}", Path.GetFileName(file));
                encodeLabel.Visible = true;
                calculateFreeMemorySize();
            }
            else
            {
                imageBeforeSteganography = null;
                encodeLabel.Text = "Nie wybrałeś zdjęcia";
                encodeLabel.ForeColor = Color.Red;
                pictureEncodeBefore.Image = null;
            }
        }
    }
}
