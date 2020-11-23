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
    public partial class DekodojImgImg : Form
    {
        public DekodojImgImg()
        {
            InitializeComponent();
        }

        ImageManipulation imageManipulation = new ImageManipulation();
        ImageSteganography imageSteganography = new ImageSteganography();
        Bitmap image = null;
        string fileextension = null;

        private void decode_Click(object sender, EventArgs e)
        {
            try
            {

                int R, G, B;
                if (image != null && fileextension != null && int.TryParse(comboBox1.Text, out R) && int.TryParse(comboBox2.Text, out G) && int.TryParse(comboBox3.Text, out B))
                {
                    Bitmap image22 = imageSteganography.DecryptImageInImage(image, R, G, B);
                    imageManipulation.saveImgWithExtension(image22, fileextension, message);
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
                label1.Text = string.Format("Wykożystujesz zdjęcie: {0}", Path.GetFileName(file));
                fileextension = Path.GetExtension(file).Substring(1);
                image = imageManipulation.getImageBitmap(file);
                isSteganograph.Text = imageSteganography.CheckImage(image);
                pictureEncodeBefore.Image = image;
                pictureEncodeBefore.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
