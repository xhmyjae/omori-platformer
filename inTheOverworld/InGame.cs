using System;
using System.Diagnostics;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
// using System.Media;
using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace inTheOverworld
{
    public partial class InGame : Form
    {
        // Player related :
        private bool _isGoingLeft, _isGoingRight, _isJumping, _isTouchingEnemies, _isOnSpecial, _isOnGround, _hasJam;
        private int _player1Speed = 5;
        private int _player1JumpSpeed = 17;
        private int _force;
        private int _score;
        
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
        
        // private SoundPlayer _st = new SoundPlayer(@"../../Resources/OMORI OST - 012 Trees__mp3.wav");
        // private SoundPlayer _itemsSound = new SoundPlayer(@"../../Resources/itemSound.wav");
        
        // WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        // WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();     
        // string play_string = "be.mp3";
        // wplayer.URL = @"SOUND/" + play_string;
        // wplayer.controls.play();
        // string play_string2 = "ba.mp3";
        // wplayer2.URL = @"SOUND/" + play_string2;
        // wplayer2.controls.play();

        public InGame()
        {
            InitializeComponent();
            // _st.PlayLooping();
            _backgroundSound = new AudioFileReader(@"../../Resources/OMORI OST - 012 Trees__mp3.wav");
            _outBackgroundSound = new WaveOut();
            _outBackgroundSound.Init(_backgroundSound);
            _itemSound = new AudioFileReader(@"../../Resources/healSound.wav");
            _outItemSound = new WaveOut();
            _outItemSound.Init(_itemSound);

            _enemy1 = new Enemy(2, Bunny1.Top, HitBlock16.Right, Bunny1.Bottom, HitBlock14.Left, true, Bunny1);
            _enemy2 = new Enemy(2, Bunny2.Top, HitBlock7.Right, Bunny2.Bottom, HitBlock5.Left, true, Bunny2);
            _enemy3 = new Enemy(3, 0, Crawler1.Right, Crawler1.Height, Crawler1.Left, true, Crawler1);
        } 
            
        private void InGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            // _st.Stop();
            _outBackgroundSound.Stop();
            gameTimer.Enabled = false;
            Form1 menu = new Form1();
            menu.Show();
        }

        private void InGame_Load(object sender, EventArgs e)
        {
            _backgroundSound.CurrentTime = new TimeSpan(0L);
            _outBackgroundSound.Play();
            // set game up
        }
        
        private void InGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D :
                case Keys.Right :
                    _isGoingRight = true;
                    Player1.Image = Properties.Resources.omoriGoingRight;
                    break;
                case Keys.A :
                case Keys.Left :
                    _isGoingLeft = true;
                    Player1.Image = Properties.Resources.omoriGoingLeft;
                    break;
                case Keys.Space :
                case Keys.Up :
                    if (!_isJumping && _isOnGround)
                    {
                        _isJumping = true;
                        _isOnGround = false;
                        _force = _player1JumpSpeed;
                    }
                    break;
            }
        }
        
        private void InGame_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D :
                case Keys.Right :
                    _isGoingRight = false;
                    Player1.Image = Properties.Resources.omoriRight3;
                    break;
                case Keys.A :
                case Keys.Left :
                    _isGoingLeft = false;
                    Player1.Image = Properties.Resources.omoriLeft3;
                    break;
            }
        }

        private void gameTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _isOnGround = false;
            if (_outBackgroundSound.PlaybackState is PlaybackState.Stopped)
            {
                _backgroundSound.CurrentTime = new TimeSpan(0L);
                _outBackgroundSound.Play();
            }
            
            // Makes player jump
            if (_isJumping)
            {
                Player1.Top -= _force;
                _force--;
            }

            // Interactions with blocs
            foreach (PictureBox control in this.Controls)
            {
                if (Player1.Bounds.IntersectsWith(control.Bounds))
                {
                    if (control.Tag == "hitBlock")
                    {
                        int[] values =
                        {
                            Player1.Bottom - control.Top,
                            Player1.Right - control.Left,
                            control.Bottom - Player1.Top,
                            control.Right - Player1.Left
                        };

                        int index = values.Min();

                        // Collisions
                        switch (Array.IndexOf(values, index))
                        {
                            case 0:
                                Player1.Top = control.Top + 2 - Player1.Height;
                                _force = 0;
                                _isOnGround = true;
                                _isJumping = false;
                                _isOnSpecial = control == MovingBlock2;
                                break;
                            case 1:
                                Player1.Left = control.Left - Player1.Width;
                                break;
                            case 2:
                                Player1.Top = control.Bottom;
                                _isJumping = false;
                                break;
                            case 3:
                                Player1.Left = control.Right;
                                break;
                        }
                    }
                    
                    if (control.Tag == "enemies")
                    {
                        if (_hasJam)
                        {
                           // change enemy is alive a false
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

                           _hasJam = false;
                        }
                        else
                        {
                            lose();
                        }
                    }
                    
                    if (control.Tag == "hectorItem")
                    {
                        this.Controls.Remove(control);
                        _score++;
                        _itemSound.CurrentTime = new TimeSpan(0L);
                        _outItemSound.Play();
                    }

                    if (control.Tag == "jamItem")
                    {
                        this.Controls.Remove(control);
                        _hasJam = true;
                        _itemSound.CurrentTime = new TimeSpan(0L);
                        _outItemSound.Play();
                    }
                }
            }
            
            // Makes character move
            if (!_isOnGround) Player1.Top += _player1Speed;

            if (_isGoingLeft && Player1.Left > 0) Player1.Left -= _player1Speed;

            if (_isGoingRight && Player1.Right < ClientSize.Width) Player1.Left += _player1Speed;

                if (Player1.Bottom >= ClientSize.Height) lose();

            // Makes enemies move
            _enemy1.MoveHorizontal();
            _enemy2.MoveHorizontal();
            _enemy3.MoveVertical();

            // Makes platform move
            MovingBlock1.Top += _movingBlock1Speed;
            if (MovingBlock1.Top <= 140 || MovingBlock1.Bottom >= 335) _movingBlock1Speed = -_movingBlock1Speed;

            MovingBlock3.Top += _movingBlock3Speed;
            if (MovingBlock3.Top <= 280 || MovingBlock3.Bottom >= 422) _movingBlock3Speed = -_movingBlock3Speed;

            if (_isOnSpecial)
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

        private void lose()
        {
            //loseTimer += 10;
            // Label loseLabel = new Label();
            // loseLabel.Text = "Maybe you should have stayed in White Space today ?";
            // loseLabel.Size = new Size(ClientSize.Width, ClientSize.Height);
            // loseLabel.BackgroundImage = Properties.Resources._parallax_black;
            // gameTimer.Enabled = false;
            // loseLabel.BringToFront();
        }
        
    }
}