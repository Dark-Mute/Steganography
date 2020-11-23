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
    public partial class DekodojImgText : Form
    {
        public DekodojImgText()
        {
            InitializeComponent();
        }

        ImageManipulation imageManipulation = new ImageManipulation();
        ImageSteganography imageSteganography = new ImageSteganography();
        TextFileManipulation textFileManipulation = new TextFileManipulation();
        Bitmap image = null;
        private void decode_Click(object sender, EventArgs e)
        {
            try
            {
                string text = "";
                int R, G, B;

                string decodedeExtension;
                if (image != null && int.TryParse(comboBox1.Text, out R) && int.TryParse(comboBox2.Text, out G) && int.TryParse(comboBox3.Text, out B))
                {
                    text = imageSteganography.DecryptBinaryInImage(image, R, G, B, out decodedeExtension);
                    textFileManipulation.saveText(imageSteganography.convertBinaryToString(text, false), message);
                }
            }
            catch (Exception ex)
            {
                message.Text = "Plik który podałeś nie może być zdekodowany";
                message.ForeColor = Color.Red;
            }


        }

       

        private void loadFile_Click(object sender, EventArgs e)
        {
            string file = imageManipulation.getFille("(*.png)|*.png|(*.jpg)|*.jpg|(*.jpge)|*.jpge");

            if (file != "none")
            {
                label1.Text= string.Format("Wykożystujesz zdjęcie: {0}", Path.GetFileName(file));
                image = imageManipulation.getImageBitmap(file);
                isSteganograph.Text = imageSteganography.CheckImage(image);
                pictureEncodeBefore.Image = image;
                pictureEncodeBefore.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }
    }
}
