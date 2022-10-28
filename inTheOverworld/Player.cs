using System.Drawing;
using System.Windows.Forms;
using System;
using System.Linq;
using NAudio.Wave;
using System.Runtime.InteropServices;

namespace inTheOverworld
{
    public class Player
    {
        public bool IsGoingLeft { get; set; }
        public bool IsGoingRight { get; set; }
        public bool IsJumping { get; set; }
        public bool IsTouchingEnemies { get; set; }
        public bool IsOnSpecial { get; set; }
        public bool IsOnGround { get; set; }
        public bool HasJam { get; set; }
        public int PlayerSpeed { get; set; }
        public int PlayerJumpSpeed { get; set; }
        public int Force { get; set; }
        public int Score { get; set; }
        public PictureBox PlayerBox { get; set; }

        public Player(bool isGoingLeft, bool isGoingRight, bool isJumping, bool isTouchingEnemies, bool isOnSpecial,
            bool isOnGround, bool hasJam, int playerSpeed, int playerJumpSpeed, int force, int score,
            PictureBox playerBox)
        {
            IsGoingLeft = isGoingLeft;
            IsGoingRight = isGoingRight;
            IsJumping = isJumping;
            IsTouchingEnemies = isTouchingEnemies;
            IsOnSpecial = isOnSpecial;
            IsOnGround = isOnGround;
            HasJam = hasJam;
            PlayerSpeed = playerSpeed;
            PlayerJumpSpeed = playerJumpSpeed;
            Force = force;
            Score = score;
            PlayerBox = playerBox;
        }

        public void DownKeys(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D :
                case Keys.Right :
                    IsGoingRight = true;
                    PlayerBox.Image = Properties.Resources.omoriGoingRight;
                    break;
                case Keys.A :
                case Keys.Left :
                    IsGoingLeft = true;
                    PlayerBox.Image = Properties.Resources.omoriGoingLeft;
                    break;
                case Keys.Space :
                case Keys.Up :
                    if (!IsJumping && IsOnGround)
                    {
                        IsJumping = true;
                        IsOnGround = false;
                        Force = PlayerJumpSpeed;
                    }
                    break;
            }
        }

        public void UpKeys(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D :
                case Keys.Right :
                    IsGoingRight = false;
                    PlayerBox.Image = Properties.Resources.omoriRight3;
                    break;
                case Keys.A :
                case Keys.Left :
                    IsGoingLeft = false;
                    PlayerBox.Image = Properties.Resources.omoriLeft3;
                    break;
            }
        }

        public void Jump()
        {
            if (IsJumping)
            {
                PlayerBox.Top -= Force;
                Force--;
            }
        }

        public void Move(Size clientSize, Form form)
        {
            if (!IsOnGround) PlayerBox.Top += PlayerSpeed;

            if (IsGoingLeft && PlayerBox.Left > 0) PlayerBox.Left -= PlayerSpeed;

            if (IsGoingRight && PlayerBox.Right < clientSize.Width) PlayerBox.Left += PlayerSpeed;
            
            if (PlayerBox.Bottom >= clientSize.Height) Lose(form);
        }

        public void CollisionsHitBlock(Control control, [ Optional ] PictureBox specialBlock)
        {
            int[] values =
            {
                PlayerBox.Bottom - control.Top,
                PlayerBox.Right - control.Left,
                control.Bottom - PlayerBox.Top,
                control.Right - PlayerBox.Left
            };

            int index = values.Min();

            // Collisions
            switch (Array.IndexOf(values, index))
            {
                case 0:
                    PlayerBox.Top = control.Top + 2 - PlayerBox.Height;
                    Force = 0;
                    IsOnGround = true;
                    IsJumping = false;
                    IsOnSpecial = control == specialBlock;
                    break;
                case 1:
                    PlayerBox.Left = control.Left - PlayerBox.Width;
                    break;
                case 2:
                    PlayerBox.Top = control.Bottom;
                    IsJumping = false;
                    break;
                case 3:
                    PlayerBox.Left = control.Right;
                    break;
            }
        }

        public void CollisionsEnemies(PictureBox control, Enemy[] enemies, Form form)
        {
            if (HasJam)
            {
                foreach (Enemy enemy in enemies)
                {
                    if (control == enemy.EnemyBox)
                    {
                        enemy.DisableEnemy();
                    }
                }
                HasJam = false;
            }
            else
            {
                Lose(form);
            }
        }

        public void CollisionsItems(PictureBox control, WaveStream waveStream, WaveOut waveOut)
        {
            switch (control.Tag)
            {
                case "hectorItem" : 
                    Score++;
                    break;
                case "jamItem" :
                    HasJam = true;
                    break;
            }
            waveStream.CurrentTime = new TimeSpan(0L);
            waveOut.Play();
        }
        
        public void Win()
        {
            // gameTimer.Enabled = false;
            // _outBackgroundSound.Stop();
            // PictureBox cutscene = new PictureBox();
            // cutscene.Size = new Size(ClientSize.Width, ClientSize.Height);
            // cutscene.Location = new Point(0, 0);
            // cutscene.ImageLocation = @"../../Resources/cutscene1.gif";
            // cutscene.SizeMode = PictureBoxSizeMode.StretchImage;
            // Controls.Add(cutscene);
            // _cutscene1Sound.CurrentTime = new TimeSpan(0L);
            // _outCutscene1Sound.Play();
            // cutscene.BringToFront();
        }
        
        public void Lose(Form form)
        {
            // show gameLose form
            form.Close();
            GameLose loseScreen = new GameLose();
            loseScreen.Show();
            
            //loseTimer += 10;
            // Label loseLabel = new Label();
            // loseLabel.Text = "Maybe you should have stayed in White Space today ?";
            // loseLabel.Size = new Size(ClientSize.Width, ClientSize.Height);
            // loseLabel.BackgroundImage = Properties.Resources._parallax_black;
            // gameTimer.Enabled = false;
            // loseLabel.BringToFront();
        }
        
        public void End(Form form)
        {
            // show gif, get back to menu
            form.Close();
        }
        
    }
}