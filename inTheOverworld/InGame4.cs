using System;
using System.Linq;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using NAudio.Wave;


namespace inTheOverworld
{
    public partial class InGame4 : Form
    {
        // Player related :
        private Player _player;

        // Musics related :
        private WaveStream _backgroundSound;
        private WaveOut _outBackgroundSound;

        // Cutscene related :
        private PictureBox _cutscene;
        private PictureBox _cutscene2;

        public InGame4()
        {
            InitializeComponent();
            
            _cutscene = new PictureBox();
            _cutscene.Size = new Size(this.Width, this.Height);
            _cutscene.Location = new Point(0,0);
            _cutscene.Visible = true;
            _cutscene.BackColor = Color.Black;
            _cutscene.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(_cutscene);
            _cutscene.BringToFront();

            _cutscene2 = new PictureBox();
            _cutscene2.Size = new Size(this.Width, this.Height);
            _cutscene2.Location = new Point(0,0);
            _cutscene2.Visible = false;
            _cutscene2.BackColor = Color.Black;
            _cutscene2.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(_cutscene2);

            _backgroundSound = new AudioFileReader(@"../../Resources/Whitespace-OST.wav");
            _outBackgroundSound = new WaveOut();
            _outBackgroundSound.Init(_backgroundSound);
            
            _player = new Player(false, false, false, false, false, false, false, 5, 17, 0, 0, Player1);
        }

        private void InGame4_KeyDown(object sender, KeyEventArgs e)
        {
            _player.DownKeys(e);
        }

        private void InGame4_KeyUp(object sender, KeyEventArgs e)
        {
            _player.UpKeys(e);
        }

        int _count = 0;
        Image[] _images =
        {
            Properties.Resources.cutscene4_1,
            Properties.Resources.cutscene4_2,
            Properties.Resources.cutscene4_3,
            Properties.Resources.cutscene4_4,
            Properties.Resources.cutscene4_5,
            Properties.Resources.cutscene4_6,
            Properties.Resources.cutscene4_7,
            Properties.Resources.cutscene4_8,
            Properties.Resources.cutscene4_9,
            Properties.Resources.cutscene4_10,
            Properties.Resources.cutscene4_11,
        };
        private void cutsceneTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_count < 11)
            {
                _cutscene.Image = _images[_count];
                _count++;
            } 
            else
            {
                gameTimer.Enabled = true;
                Controls.Remove(_cutscene);
                cutsceneTimer.Enabled = false;
            }
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
                    }
                    if (control.Name == "Door1")
                    {
                        gameTimer.Enabled = false;
                        _outBackgroundSound.Stop();

                        _cutscene2.Visible = true;
                        _cutscene2.BringToFront();
                        cutscene2Timer.Enabled = true;
                    }
                }
            }
            
            // Makes character move
            _player.Move(ClientSize, this, _outBackgroundSound, gameTimer);
        }
        
        int _count2 = 0;
        Image[] _images2 =
        {
            Properties.Resources.cutscene5_1,
            Properties.Resources.cutscene5_2,
            Properties.Resources.cutscene5_3,
            Properties.Resources.cutscene5_4,
            Properties.Resources.cutscene5_5,
            Properties.Resources.cutscene5_6,
            Properties.Resources.cutscene5_7,
            Properties.Resources.cutscene5_8,
            Properties.Resources.cutscene5_9,
            Properties.Resources.cutscene5_10,
            Properties.Resources.cutscene5_11,
            Properties.Resources.cutscene5_12,
            Properties.Resources.cutscene5_13,
            Properties.Resources.cutscene5_13,
        };
        private void cutscene2Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_count2 < 14)
            {
                _cutscene2.Image = _images2[_count2];
                _count2++;
            } 
            else
            {
                cutscene2Timer.Enabled = false;
                _outBackgroundSound.Stop();
                gameTimer.Enabled = false;
                Form1 menu = new Form1();
                menu.Show();
                Close();
            }
        }
    }
}