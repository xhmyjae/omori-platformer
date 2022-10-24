using System;
using System.Timers;
using System.Windows.Forms;
using System.Linq;

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
        private int _enemy1Speed = 2;
        private int _enemy2Speed = 2;
        private int _enemy3Speed = 3;
        
        // Blocks related :
        private int _movingBlock1Speed = 2;
        private int _movingBlock2Speed = 1;
        private int _movingBlock3Speed = 2;

        public InGame()
        {
            InitializeComponent();
        }

        private void InGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }

        private void InGame_Load(object sender, EventArgs e)
        {
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

            // Makes player jump
            if (_isJumping && Player1.Top > 0)
            {
                Player1.Top -= _force;
                _force--;
            }

            // Interactions with blocs
            foreach (Control control in this.Controls)
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

                        switch (Array.IndexOf(values, index))
                        {
                            case 0:
                                Player1.Top = control.Top +2 - Player1.Height;
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
                            control.Enabled = false;
                            // change image og this control to bread
                        }
                        else
                        {
                            // Lose
                        }
                    }
                    
                    if (control.Tag == "hectorItem")
                    {
                        this.Controls.Remove(control);
                        _score++;
                    }

                    if (control.Tag == "jamItem")
                    {
                        this.Controls.Remove(control);
                        _hasJam = true;
                    }
                }
            }
            
            // Makes character move
            if (!_isOnGround) Player1.Top += _player1Speed;

            if (_isGoingLeft && Player1.Left > 0)
            {
                Player1.Left -= _player1Speed;
            }

            if (_isGoingRight && Player1.Right < ClientSize.Width)
            {
                Player1.Left += _player1Speed;
            }

            // Makes enemies move
            Bunny1.Left += _enemy1Speed;
            if (Bunny1.Left <= HitBlock14.Left)
            {
                _enemy1Speed = -_enemy1Speed;
                Bunny1.Image = Properties.Resources.bunnyRight;
            }
            if (Bunny1.Right >= HitBlock16.Right)
            {
                _enemy1Speed = -_enemy1Speed;
                Bunny1.Image = Properties.Resources.bunnyLeft;
            }
            
            Bunny2.Left += _enemy2Speed;
            if (Bunny2.Left <= HitBlock5.Left)
            {
                _enemy2Speed = -_enemy2Speed;
                Bunny2.Image = Properties.Resources.bunnyRight;
            }
            if (Bunny2.Right >= HitBlock7.Right)
            {
                _enemy2Speed = -_enemy2Speed;
                Bunny2.Image = Properties.Resources.bunnyLeft;
            }

            Crawler1.Top += _enemy3Speed;
            if (Crawler1.Bottom <= 0)
            {
                _enemy3Speed = -_enemy3Speed;
            }
            if (Crawler1.Bottom >= Crawler1.Height)
            {
                _enemy3Speed = -_enemy3Speed;
            }

        }

    }
}