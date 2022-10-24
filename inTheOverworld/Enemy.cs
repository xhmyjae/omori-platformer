using System.Windows.Forms;

namespace inTheOverworld
{
    public class Enemy
    {
        public int EnemySpeed {get;set;}
        /*public int EnemyLeft {get;set;}
        public int EnemyRight {get;set;}
        public int EnemyTop {get;set;}
        public int EnemyBottom {get;set;}*/
        public int MaxTop{get;set;}
        public int MaxRight{get;set;}
        public int MaxBottom{get;set;}
        public int MaxLeft{get;set;}
        public bool IsAlive {get;set;}
        public PictureBox EnemyBox {get; set;}

        public Enemy(int enemySpeed, int maxTop, int maxRight, int maxBottom, int maxLeft, bool isAlive, PictureBox enemyBox)
        {
            EnemySpeed = enemySpeed;
            /*EnemyTop = enemyTop;
            EnemyRight = enemyRight;
            EnemyBottom = enemyBottom;
            EnemyLeft = enemyLeft;*/
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
            IsAlive = false;
            EnemyBox.Enabled = false;
            EnemyBox.Image = Properties.Resources.jam;
            EnemyBox.Height = 40;
            EnemyBox.Width = 40;
        }
    }
}