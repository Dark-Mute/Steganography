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
    public partial class DecodeAnythingFromWav : Form
    {
        public DecodeAnythingFromWav()
        {
            InitializeComponent();
        }

        AudioManipulation audioManipulation = new AudioManipulation();
        AudioSteganography audioSteganography = new AudioSteganography();
        TextFileManipulation textFileManipulation = new TextFileManipulation();
        AudioPlay AudioPlay;
        WaveFille audioStrganograph = null;
        string decodedeExtension;
        bool audioIsPlayed = false;

        private void loadFile_Click(object sender, EventArgs e)
        {
            string file = audioManipulation.getFille("(*.wav)|*.wav");
            if ( Path.GetExtension(file) == ".wav")
            {
                audioStrganograph = audioManipulation.getWavFile(file);
                isSteganograph.Text = audioSteganography.CheckWav(audioStrganograph);
                label1.ForeColor = Color.Black;
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
            else
            {
                AudioPlay = null;
                audioStrganograph = null;
                label1.Text = "Nie wybrałeś pliku wav";
                label1.ForeColor = Color.Red;
                if (audioIsPlayed)
                {
                    AudioPlay.Pause();
                    audioIsPlayed = false;
                    Play.Text = "Play";
                }
            }

        }

       
        private void decode_Click(object sender, EventArgs e)
        {
            try
            {
                int bits;
                if (audioStrganograph != null && int.TryParse(comboBox1.Text, out bits) && bits <= audioStrganograph.bitsPerSample && isSteganograph.Text != "Plik wav nie jest steganografem")
                {
                    string text = audioSteganography.DecryptBinaryInWave(audioStrganograph.data, bits, out decodedeExtension);
                    if (audioSteganography.checkExtension(decodedeExtension))
                    {
                        byte[] bytes = audioSteganography.convertBinaryToByteArray(text, false);
                        textFileManipulation.saveFilleContentWithExtension(bytes, decodedeExtension, message);
                        message.Text = "";
                        message.ForeColor = Color.Black;
                    }
                    else
                    {
                        message.Text = "Rozszeżenie pliku zakodowanego w wav jest nie poprawne";
                        message.ForeColor = Color.Red;
                    }
                }
                else
                {
                    message.Text = "Plik wav który podałeś nie może być zdekodowany";
                    message.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                message.Text = "Plik wav który podałeś nie może być zdekodowany";
                message.ForeColor = Color.Red;
            }
        }
        private void Play_Click(object sender, EventArgs e)
        {
            if (AudioPlay != null)
            {
                if (audioIsPlayed)
                {
                    AudioPlay.Pause();
                    audioIsPlayed = false;
                    Play.Text = "Play";
                }
                else
                {
                    AudioPlay.Play();
                    audioIsPlayed = true;
                    Play.Text = "Pause";
                }
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

        private void DecodeAnythingFromWav_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AudioPlay != null && audioIsPlayed)
            {
                AudioPlay.Pause();
            }
        }
    }
}
