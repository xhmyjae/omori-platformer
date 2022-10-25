using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using System.Linq;
using NAudio.Wave;
using WMPLib;

namespace inTheOverworld
{
    public partial class InGame : Form
    {
        // Player related :
        // private bool _isGoingLeft, _isGoingRight, _isJumping, _isTouchingEnemies, _isOnSpecial, _isOnGround, _hasJam;
        // private int _player1Speed = 5;
        // private int _player1JumpSpeed = 17;
        // private int _force;
        // private int _score;
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

            _player = new Player(false, false, false, false, false, false, false, 5, 17, 0, 0, Player1);
            _enemy1 = new Enemy(2, Bunny1.Top, HitBlock16.Right, Bunny1.Bottom, HitBlock14.Left, true, Bunny1);
            _enemy2 = new Enemy(2, Bunny2.Top, HitBlock7.Right, Bunny2.Bottom, HitBlock5.Left, true, Bunny2);
            _enemy3 = new Enemy(3, 0, Crawler1.Right, Crawler1.Height, Crawler1.Left, true, Crawler1);
        } 
            
        private void InGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            _outBackgroundSound.Stop();
            gameTimer.Enabled = false;
            Form1 menu = new Form1();
            menu.Show();
        }

        private void InGame_Load(object sender, EventArgs e)
        {
            // _backgroundSound.CurrentTime = new TimeSpan(0L);
            // _outBackgroundSound.Play();
            // set game up
        }
        
        private void InGame_KeyDown(object sender, KeyEventArgs e)
        {
            _player.DownKeys(e);
        }
        
        private void InGame_KeyUp(object sender, KeyEventArgs e)
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
                            int[] values =
                            {
                                _player.PlayerBox.Bottom - control.Top,
                                _player.PlayerBox.Right - control.Left,
                                control.Bottom - _player.PlayerBox.Top,
                                control.Right - _player.PlayerBox.Left
                            };

                            int index = values.Min();

                            // Collisions
                            switch (Array.IndexOf(values, index))
                            {
                                case 0:
                                    _player.PlayerBox.Top = control.Top + 2 - _player.PlayerBox.Height;
                                    _player.Force = 0;
                                    _player.IsOnGround = true;
                                    _player.IsJumping = false;
                                    _player.IsOnSpecial = control == MovingBlock2;
                                    break;
                                case 1:
                                    _player.PlayerBox.Left = control.Left - _player.PlayerBox.Width;
                                    break;
                                case 2:
                                    _player.PlayerBox.Top = control.Bottom;
                                    _player.IsJumping = false;
                                    break;
                                case 3:
                                    _player.PlayerBox.Left = control.Right;
                                    break;
                            }
                            break;
                        case "enemies" :
                            if (_player.HasJam)
                            {
                                if (control == _enemy1.EnemyBox)
                                {
                                    _enemy1.DisableEnemy();
                                } else if (control == _enemy2.EnemyBox)
                                {
                                    _enemy2.DisableEnemy();
                                } else
                                {
                                    _enemy3.DisableEnemy();
                                }

                                _player.HasJam = false;
                            }
                            else
                            {
                                _player.Win();
                            }
                            break;
                        case "hectorItem" :
                            this.Controls.Remove(control);
                            _player.Score++;
                            _itemSound.CurrentTime = new TimeSpan(0L);
                            _outItemSound.Play();
                            break;
                        case "jamItem" :
                            this.Controls.Remove(control);
                            _player.HasJam = true;
                            _itemSound.CurrentTime = new TimeSpan(0L);
                            _outItemSound.Play();
                            break;
                    }
                }
            }
            
            // Makes character move
            _player.Move(ClientSize);

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