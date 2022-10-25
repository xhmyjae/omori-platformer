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
            _outBackgroundSound.Stop();
            menuTimer.Enabled = false;
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
    }
}