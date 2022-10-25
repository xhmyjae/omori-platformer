using System.Windows.Forms;
using NAudio.Wave;
using System;

namespace inTheOverworld
{
    public class Enemy
    {
        private WaveStream _toastSound;
        private WaveOut _outToastSound;
        
        public int EnemySpeed {get;set;}
        public int MaxTop{get;set;}
        public int MaxRight{get;set;}
        public int MaxBottom{get;set;}
        public int MaxLeft{get;set;}
        public bool IsAlive {get;set;}
        public PictureBox EnemyBox {get; set;}

        public Enemy(int enemySpeed, int maxTop, int maxRight, int maxBottom, int maxLeft, bool isAlive, PictureBox enemyBox)
        {
            EnemySpeed = enemySpeed;
            MaxTop = maxTop;
            MaxRight = maxRight;
            MaxBottom = maxBottom;
            MaxLeft = maxLeft;
            IsAlive = isAlive;
            EnemyBox = enemyBox;
        }
        
        public void MoveHorizontal()
        {
            if (IsAlive)
            {
                EnemyBox.Left += EnemySpeed;
                if (EnemyBox.Left <= MaxLeft)
                {
                    EnemySpeed = -EnemySpeed;
                    EnemyBox.Image = Properties.Resources.bunnyRight;
                }
                if (EnemyBox.Right >= MaxRight)
                {
                    EnemySpeed = -EnemySpeed;
                    EnemyBox.Image = Properties.Resources.bunnyLeft;
                }
            }
        }
        
        public void MoveVertical()
        {
            if (IsAlive)
            {
                EnemyBox.Top += EnemySpeed;
                if (EnemyBox.Bottom <= MaxTop)
                {
                    EnemySpeed = -EnemySpeed;
                }
                if (EnemyBox.Bottom >= MaxBottom)
                {
                    EnemySpeed = -EnemySpeed;
                }
            }
        }
        
        public void DisableEnemy()
        {
            _toastSound = new AudioFileReader(@"../../Resources/toastSound.wav");
            _outToastSound = new WaveOut();
            _outToastSound.Init(_toastSound);
            _toastSound.CurrentTime = new TimeSpan(0L);
            _outToastSound.Play();
            
            IsAlive = false;
            EnemyBox.Enabled = false;
            EnemyBox.Image = Properties.Resources.bread;
            EnemyBox.Height = 40;
            EnemyBox.Width = 40;
        }
    }
}