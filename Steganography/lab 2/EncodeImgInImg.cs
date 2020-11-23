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
    public partial class EncodeImgInImg : Form
    {
        public EncodeImgInImg()
        {
            InitializeComponent();
        }

        ImageManipulation imageManipulation = new ImageManipulation();
        ImageSteganography imageSteganography = new ImageSteganography();
        public Bitmap imageBeforeSteganography1 = null;
        public Bitmap imageBeforeSteganography2 = null;
        public Bitmap imageAfterSteganography = null;


        int maxsize = 0;
        int taken = 0;
        private void calculateFreeMemorySize()
        {
            
            int R, G, B;
            if (imageBeforeSteganography1 != null && int.TryParse(comboBox1.Text, out R) && int.TryParse(comboBox2.Text, out G) && int.TryParse(comboBox3.Text, out B))
            {
                maxsize = imageSteganography.calculateFreeSiezOfImage(imageBeforeSteganography1.Height, imageBeforeSteganography1.Width, R + G + B);
                imageSteganography.calculateMemoryUsageAndShowInLable(maxsize, maxsizeLabel);
                progressBar1.Maximum = maxsize;
                calculateMemoryTakenByImg();
            }
            
        }

        private void calculateMemoryTakenByImg()
        {
            int R, G, B;
            if (maxsize > 0 && imageBeforeSteganography2 != null && int.TryParse(comboBox1.Text, out R) && int.TryParse(comboBox2.Text, out G) && int.TryParse(comboBox3.Text, out B))
            {
                taken = imageSteganography.calculateFreeSiezOfImage(imageBeforeSteganography2.Height, imageBeforeSteganography2.Width, R + G + B);
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

        private void loadFile_Click(object sender, EventArgs e)
        {
            string file = imageManipulation.getFille("(*.png)|*.png|(*.jpg)|*.jpg|(*.jpge)|*.jpge");
            if (file != "none")
            {
                imageBeforeSteganography1 = imageManipulation.getImageBitmap(file);
                isSteganograph.Text = imageSteganography.CheckImage(imageBeforeSteganography1);
                calculateFreeMemorySize();
                pictureEncodeBefore.Visible = true;
                pictureEncodeBefore.Image = imageBeforeSteganography1;
                pictureEncodeBefore.SizeMode = PictureBoxSizeMode.StretchImage;
                encodeLabel.Text = string.Format("Wykożystujesz zdjęcie: {0}", Path.GetFileName(file));
                encodeLabel.Visible = true;
            }
        }

        private void loadFileToBeEncoded_Click(object sender, EventArgs e)
        {
            string file = imageManipulation.getFille("(*.png)|*.png|(*.jpg)|*.jpg|(*.jpge)|*.jpge");
            if (file != "none")
            {
                imageBeforeSteganography2 = imageManipulation.getImageBitmap(file);
                calculateMemoryTakenByImg();
                pictureEncodeBefore2.Visible = true;
                pictureEncodeBefore2.Image = imageBeforeSteganography1;
                pictureEncodeBefore2.SizeMode = PictureBoxSizeMode.StretchImage;
                decodeLabel.Text = string.Format("Wykożystujesz zdjęcie: {0}", Path.GetFileName(file));
                encodeLabel.Visible = true;
            }   
        }

        private void encode_Click(object sender, EventArgs e)
        {
            int R, G, B;
            if (imageBeforeSteganography1 != null && imageBeforeSteganography2 != null && int.TryParse(comboBox1.Text, out R) && int.TryParse(comboBox2.Text, out G) && int.TryParse(comboBox3.Text, out B) && taken <= maxsize)
            {
                decodeLabel.Text = string.Format("2");
                pictureEncodeAfter.Image = imageAfterSteganography = imageSteganography.EncryptImageInImage(imageBeforeSteganography1, imageBeforeSteganography2, R, G, B);
                pictureEncodeAfter.SizeMode = PictureBoxSizeMode.StretchImage;
                imageManipulation.saveImgWithExtension(imageAfterSteganography,"png", message);
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
            calculateMemoryTakenByImg();
        }
    }
}
