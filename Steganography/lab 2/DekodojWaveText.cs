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
    public partial class DekodojWaveText : Form
    {
        public DekodojWaveText()
        {
            InitializeComponent();
        }
        AudioManipulation audioManipulation = new AudioManipulation();
        AudioSteganography audioSteganography = new AudioSteganography();
        TextFileManipulation textFileManipulation = new TextFileManipulation();
        AudioPlay AudioPlay;
        WaveFille audioStrganograph = null;
        bool audioIsPlayed = false;
        private void decode_Click(object sender, EventArgs e)
        {
           
            int bits;
            if (audioStrganograph != null && int.TryParse(comboBox1.Text, out bits) && bits <= audioStrganograph.bitsPerSample)
            {
                try
                {
                    string decodedeExtension;
                    string text = audioSteganography.DecryptBinaryInWave(audioStrganograph.data, bits, out decodedeExtension);
                    textFileManipulation.saveText(audioSteganography.convertBinaryToString(text, false), message);

                }
                catch(Exception ex)
                {
                    message.Text = "Plik który podałeś nie może być zdekodowany";
                    message.ForeColor = Color.Red;
                }
            }
            

        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            string file = audioManipulation.getFille("(*.wav)|*.wav");
            if (file != "none" && Path.GetExtension(file) == ".wav")
            {
                audioStrganograph = audioManipulation.getWavFile(file);
                isSteganograph.Text = audioSteganography.CheckWav(audioStrganograph);
                label1.Text = string.Format("Używasz pliku wave: {0}", Path.GetFileName(file));
                var bitsToEncode = new BindingList<KeyValuePair<int, int>>();
                for (int i = 1; i <= audioStrganograph.bitsPerSample; i++)
                    bitsToEncode.Add(new KeyValuePair<int, int>(i, i));
                comboBox1.Visible = true;
                comboBox1.DataSource = bitsToEncode;
                comboBox1.ValueMember = "Key";
                comboBox1.DisplayMember = "Value";
                comboBox1.SelectedIndex = 0;
                AudioPlay = new AudioPlay(file);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (AudioPlay != null)
            {
                AudioPlay.Play();
                audioIsPlayed = true;
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (AudioPlay != null)
            {
                AudioPlay.Pause();
                audioIsPlayed = false;
            }
        }

        private void DekodojWaveText_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AudioPlay != null && audioIsPlayed)
            {
                AudioPlay.Pause();
            }
        }
    }
}
