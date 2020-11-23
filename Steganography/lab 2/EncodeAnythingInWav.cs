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
    public partial class EncodeAnythingInWav : Form
    {
        public EncodeAnythingInWav()
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
        string encodedeExtensionAnyFille;
        int maxsize = 0;
        int taken = 0;

        private void calculateFreeMemorySize()
        {
            int Bits;
            if (audioBeforeSteganography != null && int.TryParse(comboBox1.Text, out Bits))
            {
                
                audioSteganography.calculateMemoryUsageAndShowInLable((int)(audioBeforeSteganography.totalSamples* audioBeforeSteganography.bitsPerSample), maxSizeOfWav);
                maxsize = audioSteganography.calculateMaxSiezOfWave(audioBeforeSteganography.totalSamples, Bits);
                audioSteganography.calculateMemoryUsageAndShowInLable(maxsize, maxsizeLabel);
                progressBar1.Maximum = maxsize;
                calculateMemoryTakenByText();
            }
        }

        private void calculateMemoryTakenByText()
        {
            if (maxsize > 0 && textBytes != null)
            {
                taken = audioSteganography.calculateMaxSiezOfText(textBytes.Length, encodedeExtensionAnyFille);
                if (taken > 0 && taken <= maxsize)
                {
                    progressBar1.Value = taken;
                    label2.Text = Math.Round(((float)taken / maxsize) * 100, 2).ToString() + "%";
                    audioSteganography.calculateMemoryUsageAndShowInLable(taken, takenLabel);
                    message.Text = "";
                }
                else
                {
                    message.Text = "Niestety wielkość plik u który wybrałeś jest\n" +
                                   "za duża na ilość bitów wybranych do kodowania";
                    message.ForeColor = Color.Red;
                    progressBar1.Value = 0;
                    label2.Text = "";
                    takenLabel.Text = "";
                }
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
                for (int i = 1; i <= audioBeforeSteganography.bitsPerSample; i++)
                    bitsToEncode.Add(new KeyValuePair<int, int>(i, i));
                comboBox1.Visible = true;
                comboBox1.DataSource = bitsToEncode;
                comboBox1.ValueMember = "Key";
                comboBox1.DisplayMember = "Value";
                comboBox1.SelectedIndex = 0;
                label1.Visible = true; ;
                encodeLabel.ForeColor = Color.Black;
                encodeLabel.Text = string.Format("Wykożystujesz plik wave: {0}", Path.GetFileName(file));
                encodeLabel.Visible = true;
                calculateFreeMemorySize();
            }
            else
            {
                AudioPlayOrginal = null;
                audioBeforeSteganography = null;
                encodeLabel.Text = "Nie wybrałeś pliku wav";
                encodeLabel.ForeColor = Color.Red;
                if (audioIsOginalPlayed)
                {
                    AudioPlayOrginal.Pause();
                    audioIsOginalPlayed = false;
                    Play.Text = "Play";
                }
            }
        }

        private void loadFileToBeEncoded_Click(object sender, EventArgs e)
        {
            string file = audioManipulation.getFille("(*.*)|*.*");
            if (file != "none" && Path.GetExtension(file) != "")
            {
                encodedeExtensionAnyFille = Path.GetExtension(file).Substring(1);
                textBytes = audioSteganography.convertBytesToString(textFileManipulation.getFilleContent(file));
                decodeLabel.ForeColor = Color.Black;
                decodeLabel.Text = string.Format("Wykożystujesz plik tekstowy: {0}", Path.GetFileName(file));
                calculateMemoryTakenByText();
            }
            else
            {
                textBytes = null;
                encodedeExtensionAnyFille = null;
                decodeLabel.Text = "Nie wybrałeś pliku do zakodowania";
                decodeLabel.ForeColor = Color.Red; 
            }
        }


        private void encode_Click(object sender, EventArgs e)
        {
            int bity;
            if(audioBeforeSteganography == null)
            {
                encodeLabel.Text = "Nie wybrałeś pliku wav";
                encodeLabel.ForeColor = Color.Red;
                return;
            }
            if(textBytes == null)
            {
                decodeLabel.Text = "Nie wybrałeś pliku do zakodowania";
                decodeLabel.ForeColor = Color.Red;
                return;
            }

            if (audioBeforeSteganography != null && textBytes != null && int.TryParse(comboBox1.Text, out bity) && taken <= maxsize)
            {
                audioAfterSteganography = audioSteganography.EncryptBinaryInWave(audioBeforeSteganography.data, textBytes, bity, encodedeExtensionAnyFille);
                string file = audioManipulation.saveWav(audioBeforeSteganography, message);
                if (Path.GetExtension(file) == ".wav")
                {
                    AudioPlaySteganography = new AudioPlay(file);
                }
                playSteganograph.Visible = true;
                label5.Visible = true;
            }
            else
            {
                message.Text = "Coś jest nietak z podanymi danymi być może plik który chcesz zakodować jest za duży";
                message.ForeColor = Color.Red;
                playSteganograph.Visible = false;
                label5.Visible = false;
            }
        }


        private void Play_Click(object sender, EventArgs e)
        {
            if (AudioPlayOrginal != null)
            {  
                if (audioIsOginalPlayed)
                {
                    AudioPlayOrginal.Pause();
                    audioIsOginalPlayed = false;
                    Play.Text = "Play";
                }
                else
                {
                    AudioPlayOrginal.Play();
                    audioIsOginalPlayed = true;
                    Play.Text = "Pause";
                }
            }
        }

        private void playSteganograph_Click(object sender, EventArgs e)
        {
            if (AudioPlaySteganography != null)
            {

                if (audioIsSteganographPlayed)
                {
                    AudioPlaySteganography.Pause();
                    audioIsSteganographPlayed = false;
                    playSteganograph.Text = "Play";
                }
                else
                {
                    AudioPlaySteganography.Play();
                    audioIsSteganographPlayed = true;
                    playSteganograph.Text = "Pause";
                }
            }
        }

        private void onValueHange(object sender, EventArgs e)
        {
            calculateFreeMemorySize();
            calculateMemoryTakenByText();
        }

        private void EncodeAnythingInWav_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
