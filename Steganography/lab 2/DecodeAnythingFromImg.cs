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
    public partial class DecodeAnythingFromImg : Form
    {
        public DecodeAnythingFromImg()
        {
            InitializeComponent();
        }

        ImageManipulation imageManipulation = new ImageManipulation();
        ImageSteganography imageSteganography = new ImageSteganography();
        TextFileManipulation textFileManipulation = new TextFileManipulation();
        Bitmap image = null;
        string decodedeExtension;

        private void loadFile_Click(object sender, EventArgs e)
        {
            string file = imageManipulation.getFille("(*.png)|*.png|(*.jpg)|*.jpg|(*.jpge)|*.jpge");

            if (file != "")
            {
                label1.ForeColor = Color.Black;
                label1.Text = string.Format("Wykożystujesz zdjęcie: {0}", Path.GetFileName(file));
                image = imageManipulation.getImageBitmap(file);
                isSteganograph.Text = imageSteganography.CheckImage(image);
                pictureEncodeBefore.Image = image;
                pictureEncodeBefore.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                image = null;
                label1.Text = "Nie wybrałeś zdjęcia";
                label1.ForeColor = Color.Red;
                pictureEncodeBefore.Image = null;
            }
        }

        private void decode_Click(object sender, EventArgs e)
        {
            try
            {
                string text = "";
                int R, G, B;

              
                if (image != null && int.TryParse(comboBox1.Text, out R) && int.TryParse(comboBox2.Text, out G) && int.TryParse(comboBox3.Text, out B) && isSteganograph.Text != "Zdjęcie nie jest steganografem")
                {
                    text = imageSteganography.DecryptBinaryInImage(image, R, G, B, out decodedeExtension);
                    if (imageSteganography.checkExtension(decodedeExtension))
                    {
                        byte[] bytes = imageSteganography.convertBinaryToByteArray(text, false);
                        textFileManipulation.saveFilleContentWithExtension(bytes, decodedeExtension, message);
                        message.Text = "";
                        message.ForeColor = Color.Black;
                    }
                    else
                    {
                        message.Text = "Rozszeżenie pliku zakodowanego w zdjęciu jest nie poprawne";
                        message.ForeColor = Color.Red;
                    }
                }
                else
                {
                    message.Text = "Zdjęcie które podałeś nie może być zdekodowane";
                    message.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                message.Text = "Zdjęcie które podałeś nie może być zdekodowane";
                message.ForeColor = Color.Red;
            }
        }

        private void pictureEncodeBefore_Click(object sender, EventArgs e)
        {
            string file = imageManipulation.getFille("(*.png)|*.png|(*.jpg)|*.jpg|(*.jpge)|*.jpge");

            if (file != "")
            {
                label1.ForeColor = Color.Black;
                label1.Text = string.Format("Wykożystujesz zdjęcie: {0}", Path.GetFileName(file));
                image = imageManipulation.getImageBitmap(file);
                isSteganograph.Text = imageSteganography.CheckImage(image);
                pictureEncodeBefore.Image = image;
                pictureEncodeBefore.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                image = null;
                label1.Text = "Nie wybrałeś zdjęcia";
                label1.ForeColor = Color.Red;
                pictureEncodeBefore.Image = null;
            }
        }
    }
}
