using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using NAudio.Wave;

namespace inTheOverworld
{
    public partial class GameLose : Form
    {
        // Player related :
        private Player _player;

        // Musics related :
        private WaveStream _backgroundSound;
        private WaveOut _outBackgroundSound;
        private WaveStream _itemSound;
        private WaveOut _outItemSound;
        //private WaveStream _cutscene1Sound;
        //private WaveOut _outCutscene1Sound;
        
        public GameLose()
        {
            InitializeComponent();

            _backgroundSound = new AudioFileReader(@"../../Resources/Drone-OST.wav");
            _outBackgroundSound = new WaveOut();
            _outBackgroundSound.Init(_backgroundSound);
            _itemSound = new AudioFileReader(@"../../Resources/Sinking-SFX.wav");
            _outItemSound = new WaveOut();
            _outItemSound.Init(_itemSound);
            
            _player = new Player(false, false, false, false, false, false, false, 5, 17, 0, 0, Player1);
        }

        private void GameLose_FormClosing(object sender, FormClosingEventArgs e)
        {
            _outBackgroundSound.Stop();
            gameTimer.Enabled = false;
            Form1 menu = new Form1();
            menu.Show();
        }

        private void GameLose_KeyDown(object sender, KeyEventArgs e)
        {
            _player.DownKeys(e);
        }

        private void GameLose_KeyUp(object sender, KeyEventArgs e)
        {
            _player.UpKeys(e);
        }

        private void gameTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _player.IsOnGround = false;
            if (_outBackgroundSound.PlaybackState is PlaybackState.Stopped)
            {
                _backgroundSound.CurrentTime = new TimeSpan(0L);
                _outBackgroundSound.Play();
            }
            
            _player.Jump();

            // Interactions with blocs
            foreach (PictureBox control in this.Controls)
            {
                if (_player.PlayerBox.Bounds.IntersectsWith(control.Bounds))
                {
                    switch (control.Tag)
                    {
                        case "hitBlock" :
                            _player.CollisionsHitBlock(control);
                            break;
                        case "keyItem" :
                            PictureBox HitBlock3 = new PictureBox();
                            HitBlock3.Image = Properties.Resources.blocSolo21;
                            HitBlock3.SizeMode = PictureBoxSizeMode.StretchImage;
                            HitBlock3.Size = new Size(64, 64);
                            HitBlock3.Location = new Point(64, 182);
                            HitBlock3.Tag = "hitBlock";
                            Controls.Add(HitBlock3);
                            PictureBox HitBlock4 = new PictureBox();
                            HitBlock4.Image = Properties.Resources.blocSolo21;
                            HitBlock4.SizeMode = PictureBoxSizeMode.StretchImage;
                            HitBlock4.Size = new Size(64, 64);
                            HitBlock4.Location = new Point(128, 235);
                            HitBlock4.Tag = "hitBlock";
                            Controls.Add(HitBlock4);
                            this.Controls.Remove(control);
                            _player.CollisionsItems(control, _itemSound, _outItemSound);
                            break;
                    }
                    if (control.Name == "Door1")
                    {
                        _player.End(this);
                    }
                }
            }
            
            // Makes character move
            _player.Move(ClientSize, this);
        }
    }
}