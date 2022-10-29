using System;
using System.Linq;
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

        // Cutscene related :
        private PictureBox _cutscene;
        
        public GameLose()
        {
            InitializeComponent();
            
            _cutscene = new PictureBox();
            _cutscene.Size = new Size(this.Width, this.Height);
            _cutscene.Location = new Point(0,0);
            _cutscene.Visible = false;
            _cutscene.BackColor = Color.Black;
            _cutscene.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(_cutscene);

            _backgroundSound = new AudioFileReader(@"../../Resources/Drone-OST.wav");
            _outBackgroundSound = new WaveOut();
            _outBackgroundSound.Init(_backgroundSound);
            _itemSound = new AudioFileReader(@"../../Resources/Sinking-SFX.wav");
            _outItemSound = new WaveOut();
            _outItemSound.Init(_itemSound);
            
            _player = new Player(false, false, false, false, false, false, false, 5, 17, 0, 0, Player1);
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
            foreach (PictureBox control in this.Controls.OfType<PictureBox>())
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
                            Controls.Remove(control);
                            _player.CollisionsItems(control, _itemSound, _outItemSound);
                            break;
                    }
                    if (control.Name == "Door1")
                    {
                        gameTimer.Enabled = false;
                        _outBackgroundSound.Stop();

                        _cutscene.Visible = true;
                        _cutscene.BringToFront();
                        cutsceneTimer.Enabled = true;
                    }
                }
            }
            
            // Makes character move
            _player.Move(ClientSize, this, _outBackgroundSound, gameTimer);
        }

        int _count = 0;
        Image[] _images =
        {
            Properties.Resources.cutscene0_1,
            Properties.Resources.cutscene0_2,
            Properties.Resources.cutscene0_3,
            Properties.Resources.cutscene0_4,
            Properties.Resources.cutscene0_5,
            Properties.Resources.cutscene0_6,
            Properties.Resources.cutscene0_7,
            Properties.Resources.cutscene0_8,
            Properties.Resources.cutscene0_9,
            Properties.Resources.cutscene0_10,
            Properties.Resources.cutscene0_11,
            Properties.Resources.cutscene0_12,
            Properties.Resources.cutscene0_13,
            Properties.Resources.cutscene0_14,
            Properties.Resources.cutscene0_15,
        };
        private void cutsceneTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_count < 15)
            {
                _cutscene.Image = _images[_count];
                _count++;
            } 
            else
            {
                cutsceneTimer.Enabled = false;
                _outBackgroundSound.Stop();
                gameTimer.Enabled = false;
                Form1 menu = new Form1();
                menu.Show();
                Close();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = false;
            _outBackgroundSound.Stop();
            Close();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}