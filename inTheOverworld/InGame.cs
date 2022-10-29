using System;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using NAudio.Wave;
using System.Drawing;

namespace inTheOverworld
{
    public partial class InGame : Form
    {
        // Player related :
        private Player _player;
        
        // Enemies related :
        private Enemy _enemy1, _enemy2, _enemy3;

        // Blocks related :
        private int _movingBlock1Speed = 2;
        private int _movingBlock2Speed = 1;
        private int _movingBlock3Speed = 2;
        
        // Musics related :
        private WaveStream _backgroundSound;
        private WaveOut _outBackgroundSound;
        private WaveStream _itemSound;
        private WaveOut _outItemSound;
        private WaveStream _cutscene1Sound;
        private WaveOut _outCutscene1Sound;
        
        // Cutscene related :
        private PictureBox _cutscene;
        
        public InGame()
        {
            InitializeComponent();
            
            _backgroundSound = new AudioFileReader(@"../../Resources/OMORI OST - 012 Trees__mp3.wav");
            _outBackgroundSound = new WaveOut();
            _outBackgroundSound.Init(_backgroundSound);
            _itemSound = new AudioFileReader(@"../../Resources/healSound.wav");
            _outItemSound = new WaveOut();
            _outItemSound.Init(_itemSound);
            _cutscene1Sound = new AudioFileReader(@"../../Resources/cutscene1.wav");
            _outCutscene1Sound = new WaveOut();
            _outCutscene1Sound.Init(_cutscene1Sound);
            
            _cutscene = new PictureBox();
            _cutscene.Size = new Size(this.Width, this.Height);
            _cutscene.Location = new Point(0,0);
            _cutscene.Visible = true;
            _cutscene.BackColor = Color.Black;
            _cutscene.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(_cutscene);
            _cutscene.BringToFront();

            _player = new Player(false, false, false, false, false, false, false, 5, 17, 0, 0, Player1);
            _enemy1 = new Enemy(2, Bunny1.Top, HitBlock16.Right, Bunny1.Bottom, HitBlock14.Left, true, Bunny1);
            _enemy2 = new Enemy(2, Bunny2.Top, HitBlock7.Right, Bunny2.Bottom, HitBlock5.Left, true, Bunny2);
            _enemy3 = new Enemy(3, 0, Crawler1.Right, Crawler1.Height, Crawler1.Left, true, Crawler1);
        } 
            
        private void InGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameTimer.Enabled = false;
            // _outBackgroundSound.Stop();
            // Form1 menu = new Form1();
            // menu.Show();
        }

        private void InGame_KeyDown(object sender, KeyEventArgs e)
        {
            _player.DownKeys(e);
        }
        
        private void InGame_KeyUp(object sender, KeyEventArgs e)
        {
            _player.UpKeys(e);
        }
        
        int _count = 0;
        Image[] _images =
        {
            Properties.Resources.cutscene1_1,
            Properties.Resources.cutscene1_2,
            Properties.Resources.cutscene1_3,
            Properties.Resources.cutscene1_4,
            Properties.Resources.cutscene1_5,
            Properties.Resources.cutscene1_6,
            Properties.Resources.cutscene1_7,
            Properties.Resources.cutscene1_8,
        };
        private void cutsceneTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_count < 8)
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
            
            // Restarts background music
            if (_outBackgroundSound.PlaybackState is PlaybackState.Stopped)
            {
                _backgroundSound.CurrentTime = new TimeSpan(0L);
                _outBackgroundSound.Play();
            }
            
            _player.Jump();

            // Interactions with blocs
            Enemy[] enemies = {_enemy1, _enemy2, _enemy3};
            foreach (PictureBox control in this.Controls.OfType<PictureBox>())
            {
                if (_player.PlayerBox.Bounds.IntersectsWith(control.Bounds))
                {
                    switch (control.Tag)
                    {
                        case "hitBlock" :
                            _player.CollisionsHitBlock(control, MovingBlock2);
                            break;
                        case "enemies" :
                            _player.CollisionsEnemies(control, enemies, this, _outBackgroundSound);
                            break;
                        case "hectorItem" :
                        case "jamItem" :
                            this.Controls.Remove(control);
                            _player.CollisionsItems(control, _itemSound, _outItemSound);
                            break;
                    }
                    if (control.Name == "Door1" && _player.Score == 9)
                    {
                        gameTimer.Enabled = false;
                        _outBackgroundSound.Stop();
                        InGame2 inGame2 = new InGame2();
                        inGame2.Show();
                        Hide();
                    }
                }
            }
            
            // Makes character move
            _player.Move(ClientSize, this, _outBackgroundSound);

            // Makes enemies move
            _enemy1.MoveHorizontal();
            _enemy2.MoveHorizontal();
            _enemy3.MoveVertical();

            // Makes platform move
            MovingBlock1.Top += _movingBlock1Speed;
            if (MovingBlock1.Top <= 140 || MovingBlock1.Bottom >= 335) _movingBlock1Speed = -_movingBlock1Speed;

            MovingBlock3.Top += _movingBlock3Speed;
            if (MovingBlock3.Top <= 280 || MovingBlock3.Bottom >= 422) _movingBlock3Speed = -_movingBlock3Speed;

            if (_player.IsOnSpecial)
            {
                MovingBlock2.Left += _movingBlock2Speed;
                if (MovingBlock2.Left >= 622) _movingBlock2Speed = 0;
            }
            else
            {
                if (MovingBlock2.Left >= 433)
                {
                    MovingBlock2.Left -= _movingBlock2Speed;
                }
            }

        }
    }
}