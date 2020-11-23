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
    public partial class CheckAudioSteganography : Form
    {
        public CheckAudioSteganography()
        {
            InitializeComponent();
        }
        AudioManipulation audioManipulation = new AudioManipulation();
        AudioSteganography audioSteganography = new AudioSteganography();
        AudioPlay AudioPlaySteganohraph;
        WaveFille audioSteganohraph = null;
        bool audioSteganohraphIsPalyed = false;

     
        private void playSteganograph_Click(object sender, EventArgs e)
        {
            if (AudioPlaySteganohraph != null)
            {
                if (audioSteganohraphIsPalyed)
                {
                    AudioPlaySteganohraph.Pause();
                    audioSteganohraphIsPalyed = false;
                    playSteganograph.Text = "Play";
                }
                else
                {
                    AudioPlaySteganohraph.Play();
                    audioSteganohraphIsPalyed = true;
                    playSteganograph.Text = "Pause";
                }
            }
        }

        private void pauseSteganograph_Click(object sender, EventArgs e)
        {
            if (AudioPlaySteganohraph != null)
            {
                AudioPlaySteganohraph.Pause();
                audioSteganohraphIsPalyed = false;
            }
        }

        private void loadSteganographWav_Click(object sender, EventArgs e)
        {
            string file = audioManipulation.getFille("(*.wav)|*.wav");
            if (Path.GetExtension(file) == ".wav")
            {
                audioSteganohraph = audioManipulation.getWavFile(file);
                AudioPlaySteganohraph = new AudioPlay(file);
                fille2Label.ForeColor = Color.Black;
                fille2Label.Text = string.Format("Wykożystujesz plik wave: {0}", Path.GetFileName(file));
                fille2Label.Visible = true;
            }
            else
            {
                AudioPlaySteganohraph = null;
                audioSteganohraph = null;
                fille2Label.Text = "Nie wybrałeś pliku wav";
                fille2Label.ForeColor = Color.Red;
                if (audioSteganohraphIsPalyed)
                {
                    AudioPlaySteganohraph.Pause();
                    audioSteganohraphIsPalyed = false;
                    playSteganograph.Text = "Play";
                }
            }
        }

        
        private void checkSteaganography_Click(object sender, EventArgs e)
        {
            isSteganograpny.Text = audioSteganography.CheckWav(audioSteganohraph);
        }

        private void CheckAudioSteganography_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (AudioPlaySteganohraph != null && audioSteganohraphIsPalyed)
            {
                AudioPlaySteganohraph.Pause();
            }
        }
    }
}
