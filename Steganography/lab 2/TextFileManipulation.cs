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
    class TextFileManipulation : FilleManipulations
    {
        
        public byte[] getTextFileBytes(string src)
        {
            if(src!=null)
                return Encoding.ASCII.GetBytes(File.ReadAllText(src));
            return null;
        }


        public void saveText(string text, Label Lable)
        {
            try
            {
                saveFileDialog1.Filter = string.Format(" (*.txt)|*.txt");
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = "result.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, text);
                }
                Lable.Text = "Plik został zapisany";
                Lable.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {

                Lable.Text = "Nieudało śię zapisać pliku zprubój ponownie z inną nazwą";
                Lable.ForeColor = Color.Red;

            }




        }
    }
}
