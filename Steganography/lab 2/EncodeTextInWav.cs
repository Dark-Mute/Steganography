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
    public partial class EncodeTextInWav : Form
    {
        public EncodeTextInWav()
        {
            InitializeComponent();
           
        }

        AudioManipulation audioManipulation = new AudioManipulation();
        AudioSteganography audioSteganography = new AudioSteganography();
        TextFileManipulation textFileManipulation = new TextFileManipulation();
        AudioPlay AudioPlayOrginal = null;
        AudioPlay AudioPlaySteganography = null;
        public WaveFille audioBeforeSteganography = null;
        public WaveFille audioAfterSteganography = null;
        bool audioIsOginalPlayed = false;
        bool audioIsSteganographPlayed = false;
        public string textBytes = null;
        int maxsize = 0;
        int taken = 0;

        private void calculateFreeMemorySize()
        {
            int Bits;
            if (audioBeforeSteganography != null && int.TryParse(comboBox1.Text, out Bits) )
            {
                maxsize = audioSteganography.calculateMaxSiezOfWave(audioBeforeSteganography.totalSamples, Bits) ;
                audioSteganography.calculateMemoryUsageAndShowInLable(maxsize, maxsizeLabel);
                progressBar1.Maximum = maxsize;
                calculateMemoryTakenByText();
            }
        }

        private void calculateMemoryTakenByText()
        {
            if (maxsize > 0 && textBytes != null)
            {
                taken = audioSteganography.calculateMaxSiezOfText(textBytes.Length,"txt");
                if (taken > 0 && taken <= maxsize)
                {
                    progressBar1.Value = taken;
                    label2.Text = Math.Round(((float)taken / maxsize) * 100, 2).ToString() + "%";
                    audioSteganography.calculateMemoryUsageAndShowInLable( taken, takenLabel);
                }
                else
                {
                    message.Text = "Niestety plik który wybrałeś jest za duży";
                    message.ForeColor = Color.Red;
                }
            }
        }

        private void encode_Click(object sender, EventArgs e)
        {
            int bity;
            if (audioBeforeSteganography != null && textBytes != null && int.TryParse(comboBox1.Text, out bity) && taken <= maxsize)
            {
                audioAfterSteganography = audioSteganography.EncryptBinaryInWave(audioBeforeSteganography.data, textBytes, bity,"txt");
                string file = audioManipulation.saveWav(audioBeforeSteganography, message);
                if (Path.GetExtension(file) == ".wav")
                {
                    AudioPlaySteganography = new AudioPlay(file);
                }
            }
            else
            {
                message.Text = "Coś jest nietak z podanymi danymi";
                message.ForeColor = Color.Red;
            }
        }

        private void loadFileToBeEncoded_Click(object sender, EventArgs e)
        {
            string file = audioManipulation.getFille("(*.txt)|*.txt");
            if (Path.GetExtension(file) == ".txt")
            {
                textBytes = audioSteganography.convertBytesToString(textFileManipulation.getTextFileBytes(file));
                decodeLabel.Text = string.Format("Wykożystujesz plik tekstowy: {0}", Path.GetFileName(file));
                calculateMemoryTakenByText();
            }
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            string file = audioManipulation.getFille("(*.wav)|*.wav");
            if (Path.GetExtension(file) == ".wav")
            {
                audioBeforeSteganography = audioManipulation.getWavFile(file);
                isSteganograph.Text = audioSteganography.CheckWav(audioBeforeSteganography);
                AudioPlayOrginal = new AudioPlay(file);
                var bitsToEncode = new BindingList<KeyValuePair<int, int>>();
                for(int i = 1;i<= audioBeforeSteganography.bitsPerSample;i++)
                    bitsToEncode.Add(new KeyValuePair<int, int>(i, i));
                comboBox1.Visible = true;
                comboBox1.DataSource = bitsToEncode;
                comboBox1.ValueMember = "Key";
                comboBox1.DisplayMember = "Value";
                comboBox1.SelectedIndex = 0;
                label1.Visible = true; ;
                encodeLabel.Text = string.Format("Wykożystujesz plik wave: {0}", Path.GetFileName(file));
                encodeLabel.Visible = true;
                calculateFreeMemorySize();
            }
            
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (AudioPlayOrginal != null)
            {
                AudioPlayOrginal.Play();
                audioIsOginalPlayed = true;
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (AudioPlayOrginal != null)
            {
                AudioPlayOrginal.Pause();
                audioIsOginalPlayed = false;
            }
        }

        private void onValueHange(object sender, EventArgs e)
        {
            calculateFreeMemorySize();
            calculateMemoryTakenByText();
        }

        private void EncodeTextInWav_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AudioPlayOrginal != null && audioIsOginalPlayed)
            {
                AudioPlayOrginal.Pause();
            }
            if (AudioPlaySteganography != null && audioIsSteganographPlayed)
            {
                AudioPlaySteganography.Pause();
            }
        }

        private void playSteganograph_Click(object sender, EventArgs e)
        {
            if (AudioPlaySteganography != null)
            {
                AudioPlaySteganography.Play();
                audioIsSteganographPlayed = true;
            }
        }

        private void pauseSteganograph_Click(object sender, EventArgs e)
        {
            if (AudioPlaySteganography != null)
            {
                AudioPlaySteganography.Pause();
                audioIsSteganographPlayed = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mesaage_Click(object sender, EventArgs e)
        {

        }
    }
}
