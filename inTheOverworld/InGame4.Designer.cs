using System.ComponentModel;

namespace inTheOverworld
{
    partial class InGame4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HitBlock1 = new System.Windows.Forms.PictureBox();
            this.Computer1 = new System.Windows.Forms.PictureBox();
            this.Mewo1 = new System.Windows.Forms.PictureBox();
            this.Tissues1 = new System.Windows.Forms.PictureBox();
            this.Book1 = new System.Windows.Forms.PictureBox();
            this.Lamp1 = new System.Windows.Forms.PictureBox();
            this.Door1 = new System.Windows.Forms.PictureBox();
            this.cutsceneTimer = new System.Timers.Timer();
            this.gameTimer = new System.Timers.Timer();
            this.cutscene2Timer = new System.Timers.Timer();
            this.Player1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.HitBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Computer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Mewo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Tissues1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Book1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Lamp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Door1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.cutsceneTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.gameTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.cutscene2Timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player1)).BeginInit();
            this.SuspendLayout();
            // 
            // HitBlock1
            // 
            this.HitBlock1.BackColor = System.Drawing.Color.Transparent;
            this.HitBlock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HitBlock1.Location = new System.Drawing.Point(0, 299);
            this.HitBlock1.Name = "HitBlock1";
            this.HitBlock1.Size = new System.Drawing.Size(916, 64);
            this.HitBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HitBlock1.TabIndex = 1;
            this.HitBlock1.TabStop = false;
            this.HitBlock1.Tag = "hitBlock";
            // 
            // Computer1
            // 
            this.Computer1.BackColor = System.Drawing.Color.Transparent;
            this.Computer1.Image = global::inTheOverworld.Properties.Resources.computer;
            this.Computer1.Location = new System.Drawing.Point(370, 233);
            this.Computer1.Name = "Computer1";
            this.Computer1.Size = new System.Drawing.Size(54, 66);
            this.Computer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Computer1.TabIndex = 13;
            this.Computer1.TabStop = false;
            this.Computer1.Tag = "backBlock";
            // 
            // Mewo1
            // 
            this.Mewo1.BackColor = System.Drawing.Color.Transparent;
            this.Mewo1.Image = global::inTheOverworld.Properties.Resources.mewo;
            this.Mewo1.Location = new System.Drawing.Point(584, 260);
            this.Mewo1.Name = "Mewo1";
            this.Mewo1.Size = new System.Drawing.Size(65, 39);
            this.Mewo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mewo1.TabIndex = 14;
            this.Mewo1.TabStop = false;
            this.Mewo1.Tag = "backBlock";
            // 
            // Tissues1
            // 
            this.Tissues1.BackColor = System.Drawing.Color.Transparent;
            this.Tissues1.Image = global::inTheOverworld.Properties.Resources.tissues;
            this.Tissues1.Location = new System.Drawing.Point(841, 259);
            this.Tissues1.Name = "Tissues1";
            this.Tissues1.Size = new System.Drawing.Size(35, 40);
            this.Tissues1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tissues1.TabIndex = 15;
            this.Tissues1.TabStop = false;
            this.Tissues1.Tag = "backBlock";
            // 
            // Book1
            // 
            this.Book1.BackColor = System.Drawing.Color.Transparent;
            this.Book1.Image = global::inTheOverworld.Properties.Resources.book;
            this.Book1.Location = new System.Drawing.Point(755, 33);
            this.Book1.Name = "Book1";
            this.Book1.Size = new System.Drawing.Size(54, 57);
            this.Book1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Book1.TabIndex = 16;
            this.Book1.TabStop = false;
            this.Book1.Tag = "backBlock";
            // 
            // Lamp1
            // 
            this.Lamp1.BackColor = System.Drawing.Color.Transparent;
            this.Lamp1.Image = global::inTheOverworld.Properties.Resources.lamp_big;
            this.Lamp1.Location = new System.Drawing.Point(405, 0);
            this.Lamp1.Name = "Lamp1";
            this.Lamp1.Size = new System.Drawing.Size(62, 80);
            this.Lamp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lamp1.TabIndex = 17;
            this.Lamp1.TabStop = false;
            this.Lamp1.Tag = "backBlock";
            // 
            // Door1
            // 
            this.Door1.BackColor = System.Drawing.Color.Transparent;
            this.Door1.Image = global::inTheOverworld.Properties.Resources.blocDoor;
            this.Door1.Location = new System.Drawing.Point(163, 134);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(40, 82);
            this.Door1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door1.TabIndex = 34;
            this.Door1.TabStop = false;
            this.Door1.Tag = "backBlock";
            // 
            // cutsceneTimer
            // 
            this.cutsceneTimer.Enabled = true;
            this.cutsceneTimer.Interval = 500D;
            this.cutsceneTimer.SynchronizingObject = this;
            this.cutsceneTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.cutsceneTimer_Elapsed);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20D;
            this.gameTimer.SynchronizingObject = this;
            this.gameTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.gameTimer_Elapsed);
            // 
            // cutscene2Timer
            // 
            this.cutscene2Timer.Interval = 1000D;
            this.cutscene2Timer.SynchronizingObject = this;
            this.cutscene2Timer.Elapsed += new System.Timers.ElapsedEventHandler(this.cutscene2Timer_Elapsed);
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.Image = global::inTheOverworld.Properties.Resources.omoriRight3;
            this.Player1.Location = new System.Drawing.Point(11, 249);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(50, 50);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 35;
            this.Player1.TabStop = false;
            this.Player1.Tag = "player";
            // 
            // InGame4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 616);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Door1);
            this.Controls.Add(this.Lamp1);
            this.Controls.Add(this.Book1);
            this.Controls.Add(this.Tissues1);
            this.Controls.Add(this.Mewo1);
            this.Controls.Add(this.Computer1);
            this.Controls.Add(this.HitBlock1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(916, 616);
            this.MinimumSize = new System.Drawing.Size(916, 616);
            this.Name = "InGame4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nothing better than White space";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InGame4_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InGame4_KeyUp);
            ((System.ComponentModel.ISupportInitialize) (this.HitBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Computer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Mewo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Tissues1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Book1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Lamp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Door1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.cutsceneTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.gameTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.cutscene2Timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox Player1;

        private System.Timers.Timer cutscene2Timer;

        public System.Timers.Timer gameTimer;

        private System.Timers.Timer cutsceneTimer;

        private System.Windows.Forms.PictureBox Door1;

        private System.Windows.Forms.PictureBox Lamp1;

        private System.Windows.Forms.PictureBox Book1;

        private System.Windows.Forms.PictureBox Tissues1;

        private System.Windows.Forms.PictureBox Mewo1;

        private System.Windows.Forms.PictureBox Computer1;

        private System.Windows.Forms.PictureBox HitBlock1;

        #endregion
    }
}