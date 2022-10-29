using System;
using System.Timers;
using System.Windows.Forms;
using NAudio.Wave;

namespace inTheOverworld
{
    public partial class Form1 : Form
    {
        private WaveStream _backgroundSound;
        private WaveOut _outBackgroundSound;

        public Form1()
        {
            InitializeComponent();
            _backgroundSound = new AudioFileReader(@"../../Resources/OMORI OST - 001 Title.wav");
            _outBackgroundSound = new WaveOut();
            _outBackgroundSound.Init(_backgroundSound);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            menuTimer.Enabled = false;
            _outBackgroundSound.Stop();
            InGame inGame = new InGame();
            inGame.Show();
            Hide();
        }

        private void menuTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_outBackgroundSound.PlaybackState is PlaybackState.Stopped)
            {
                _backgroundSound.CurrentTime = new TimeSpan(0L);
                _outBackgroundSound.Play();
            }
        }
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            menuTimer.Enabled = false;
            _outBackgroundSound.Stop();
            Help help = new Help();
            help.Show();
            Hide();
        }
    }
}