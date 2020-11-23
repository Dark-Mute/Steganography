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
    public partial class CheckImageSteganography : Form
    {
        public CheckImageSteganography()
        {
            InitializeComponent();
        }
        ImageManipulation imageManipulation = new ImageManipulation();
        ImageSteganography imageSteganography = new ImageSteganography();
        public Bitmap imageSteganograph = null;

        private void loadFileSteganograph_Click(object sender, EventArgs e)
        {
            string file = imageManipulation.getFille("(*.png)|*.png|(*.jpg)|*.jpg|(*.jpge)|*.jpge");
            if (file != "none")
            {
                imageSteganograph = imageManipulation.getImageBitmap(file);
                pictureEncodeBefore2.Visible = true;
                pictureEncodeBefore2.Image = imageSteganograph;
                pictureEncodeBefore2.SizeMode = PictureBoxSizeMode.StretchImage;
                decodeLabel.Text = string.Format("Wykożystujesz zdjęcie: {0}", Path.GetFileName(file));
                decodeLabel.Visible = true;
            }
            else
            {
                imageSteganograph = null;
                decodeLabel.Text = "Nie wybrałeś zdjęcia";
                decodeLabel.ForeColor = Color.Red;
                pictureEncodeBefore2.Image = null;
                decodeLabel.Text = "";
            }
        }

        private void checkSteaganography_Click(object sender, EventArgs e)
        {
            if (imageSteganograph != null)
            {
                isSteganograpny.Text = imageSteganography.CheckImage(imageSteganograph);
                isSteganograpny.ForeColor = Color.Black;
            }
            else
            {
                isSteganograpny.Text = "Nie podałeś zdjęcia";
                isSteganograpny.ForeColor = Color.Red;
            }

        }

        private void pictureEncodeBefore2_Click(object sender, EventArgs e)
        {
            string file = imageManipulation.getFille("(*.png)|*.png|(*.jpg)|*.jpg|(*.jpge)|*.jpge");
            if (file != "none")
            {
                imageSteganograph = imageManipulation.getImageBitmap(file);
                pictureEncodeBefore2.Visible = true;
                pictureEncodeBefore2.Image = imageSteganograph;
                pictureEncodeBefore2.SizeMode = PictureBoxSizeMode.StretchImage;
                decodeLabel.Text = string.Format("Wykożystujesz zdjęcie: {0}", Path.GetFileName(file));
                decodeLabel.ForeColor = Color.Black;
                decodeLabel.Visible = true;
            }
            else
            {
                imageSteganograph = null;
                decodeLabel.Text = "Nie wybrałeś zdjęcia";
                decodeLabel.ForeColor = Color.Red;
                pictureEncodeBefore2.Image = null;
                decodeLabel.Text = "";
            }
        }
    }
}
