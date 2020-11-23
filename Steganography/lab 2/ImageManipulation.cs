using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    class ImageManipulation : FilleManipulations
    {
        

        public Bitmap getImageBitmap(string src)
        {
            try
            {
                if (src != null)
                {
                    Image image = Image.FromFile(src);

                    Bitmap newBmp = new Bitmap(image.Width, image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    using (Graphics gfx = Graphics.FromImage(newBmp))
                    {
                        gfx.DrawImage(image, 0, 0);
                    }

                    return newBmp;
                }
                return null;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public void saveImgWithExtension(Bitmap bmp, string decodedeExtension, Label label)
        {
            try
            {
                Stream stream;
                saveFileDialog1.Filter = string.Format(" (*.{0})|*.{0}", decodedeExtension);
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = "img." + decodedeExtension;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    /*bmp.Save(saveFileDialog1.FileName);
                    label.Text = "Plik został zapisany";
                    label.ForeColor = Color.Green;
                    return;*/
                    if ((stream = saveFileDialog1.OpenFile()) != null)
                    {
                        ImageConverter imageConverter = new ImageConverter();
                        byte[] image = (byte[])imageConverter.ConvertTo(bmp, typeof(byte[]));
                        stream.Write(image, 0, image.Length);
                        stream.Flush();
                        stream.Close();
                        label.Text = "Plik został zapisany";
                        label.ForeColor = Color.Green;
                        return;
                    }
                    label.Text = "Nie zapisano pliku";
                    label.ForeColor = Color.Red;
                    return;
                }
             
                label.Text = "Nie zapisano pliku";
                label.ForeColor = Color.Red;
                return;
            }
            catch (Exception ex)
            {
                label.Text = "Nieudało śię zapisać pliku zprubój ponownie z inną nazwą";
                label.ForeColor = Color.Red;
            }


        }
    }
}
