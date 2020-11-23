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
    abstract class FilleManipulations
    {
       
        protected SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        protected OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public string getFille(string fileExtensions)
        {
            try
            {
                openFileDialog1.Filter = fileExtensions;


                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return openFileDialog1.FileName;
                }
                return "none";
            }
            catch(Exception ex)
            {
                return "none";

            }

        }

        public void saveFilleContentWithExtension(byte[] fileData,string fileExtension, Label label)
        {
            try
            {
                Stream stream;
                saveFileDialog1.Filter = string.Format(" (*.{0})|*.{0}", fileExtension);
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = "result."+ fileExtension;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((stream = saveFileDialog1.OpenFile()) != null)
                    {
                        stream.Write(fileData, 0, fileData.Length);
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

        public byte[] getFilleContent(string src)
        {
            byte[] bits = null;
            try
            {
                using (Stream stream = new FileStream(src,FileMode.Open,FileAccess.Read))
                {
                    bits = new byte[stream.Length];
                    stream.Read(bits,0,(int)stream.Length-1);
                }
                return bits;
            }
            catch (Exception ex)
            {
                return bits;
            }
        }

    }
}
