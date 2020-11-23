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
    class AudioManipulation : FilleManipulations
    {

        public WaveFille getWavFile(string src)
        {
            byte[] bytes = File.ReadAllBytes(src);
            return new WaveFille(bytes);
        }


        public string saveWav(WaveFille wave, Label label)
        {
            try
            {
                Stream stream;
                saveFileDialog1.Filter = string.Format(" (*.wav)|*.wav");
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = "wave.wav";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((stream = saveFileDialog1.OpenFile()) != null)
                    {
                        stream.Write(wave.data, 0, wave.data.Length);
                        stream.Flush();
                        stream.Close();
                        label.Text = "Plik został zapisany";
                        label.ForeColor = Color.Green;
                        return saveFileDialog1.FileName;
                    }
                    label.Text = "Nie zapisano pliku";
                    label.ForeColor = Color.Red;
                    return "none";
                }
                label.Text = "Nie zapisano pliku";
                label.ForeColor = Color.Red;
                return "none";
            }
            catch (Exception ex)
            {
                label.Text = "Nieudało śię zapisać pliku zprubój ponownie z inną nazwą";
                label.ForeColor = Color.Red;
                return "none";

            }
        }
    }
}
