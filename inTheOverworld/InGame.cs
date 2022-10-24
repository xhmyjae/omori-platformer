using System;
using System.Windows.Forms;

namespace inTheOverworld
{
    public partial class InGame : Form
    {
        // Player related :
        private bool _isGoingLeft, _isGoingRight, _isJumping, _isTouchingEnemies, _isOnSpecial, _isOnGround;
        private int _player1Speed = 5;
        private int _player1JumpSpeed = 17;
        private int _force;
        private int _score;
        
        // Enemies related :
        private int _enemy1Speed = 2;
        private int _enemy2Speed = 2;
        private int _enemy3Speed = 4;
        
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
                    _isGoingRight = true;
                    Player1.Image = Properties.Resources.omoriGoingRight;
                    break;
                case Keys.A :
                    _isGoingLeft = true;
                    Player1.Image = Properties.Resources.omoriGoingLeft;
                    break;
                case Keys.Space :
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
                    _isGoingRight = false;
                    Player1.Image = Properties.Resources.omoriRight3;
                    break;
                case Keys.A :
                    _isGoingLeft = false;
                    Player1.Image = Properties.Resources.omoriLeft3;
                    break;
            }
        }
    }
}