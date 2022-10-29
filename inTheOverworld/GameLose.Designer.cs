using System.ComponentModel;

namespace inTheOverworld
{
    partial class GameLose
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
            this.HitBlock2 = new System.Windows.Forms.PictureBox();
            this.Door1 = new System.Windows.Forms.PictureBox();
            this.Lamp1 = new System.Windows.Forms.PictureBox();
            this.Tissues1 = new System.Windows.Forms.PictureBox();
            this.Mewo1 = new System.Windows.Forms.PictureBox();
            this.Book1 = new System.Windows.Forms.PictureBox();
            this.Computer1 = new System.Windows.Forms.PictureBox();
            this.Key1 = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Timers.Timer();
            this.cutsceneTimer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this.HitBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.HitBlock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Door1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Lamp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Tissues1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Mewo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Book1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Computer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Key1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.gameTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.cutsceneTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // HitBlock1
            // 
            this.HitBlock1.BackColor = System.Drawing.Color.Transparent;
            this.HitBlock1.Image = global::inTheOverworld.Properties.Resources.blocSolo21;
            this.HitBlock1.Location = new System.Drawing.Point(0, 299);
            this.HitBlock1.Name = "HitBlock1";
            this.HitBlock1.Size = new System.Drawing.Size(916, 64);
            this.HitBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HitBlock1.TabIndex = 0;
            this.HitBlock1.TabStop = false;
            this.HitBlock1.Tag = "hitBlock";
            // 
            // HitBlock2
            // 
            this.HitBlock2.BackColor = System.Drawing.Color.Transparent;
            this.HitBlock2.Image = global::inTheOverworld.Properties.Resources.blocSolo21;
            this.HitBlock2.Location = new System.Drawing.Point(0, 131);
            this.HitBlock2.Name = "HitBlock2";
            this.HitBlock2.Size = new System.Drawing.Size(64, 64);
            this.HitBlock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HitBlock2.TabIndex = 1;
            this.HitBlock2.TabStop = false;
            this.HitBlock2.Tag = "hitBlock";
            // 
            // Door1
            // 
            this.Door1.BackColor = System.Drawing.Color.Transparent;
            this.Door1.Image = global::inTheOverworld.Properties.Resources.blocDoorReverse;
            this.Door1.Location = new System.Drawing.Point(11, 49);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(40, 82);
            this.Door1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door1.TabIndex = 4;
            this.Door1.TabStop = false;
            this.Door1.Tag = "backBlock";
            // 
            // Lamp1
            // 
            this.Lamp1.BackColor = System.Drawing.Color.Transparent;
            this.Lamp1.Image = global::inTheOverworld.Properties.Resources.lamp_reverse;
            this.Lamp1.Location = new System.Drawing.Point(405, 0);
            this.Lamp1.Name = "Lamp1";
            this.Lamp1.Size = new System.Drawing.Size(62, 80);
            this.Lamp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lamp1.TabIndex = 5;
            this.Lamp1.TabStop = false;
            this.Lamp1.Tag = "backBlock";
            // 
            // Tissues1
            // 
            this.Tissues1.BackColor = System.Drawing.Color.Transparent;
            this.Tissues1.Image = global::inTheOverworld.Properties.Resources.tissues_reverse;
            this.Tissues1.Location = new System.Drawing.Point(841, 259);
            this.Tissues1.Name = "Tissues1";
            this.Tissues1.Size = new System.Drawing.Size(35, 40);
            this.Tissues1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tissues1.TabIndex = 6;
            this.Tissues1.TabStop = false;
            this.Tissues1.Tag = "backBlock";
            // 
            // Mewo1
            // 
            this.Mewo1.BackColor = System.Drawing.Color.Transparent;
            this.Mewo1.Image = global::inTheOverworld.Properties.Resources.mewo_reverse;
            this.Mewo1.Location = new System.Drawing.Point(584, 260);
            this.Mewo1.Name = "Mewo1";
            this.Mewo1.Size = new System.Drawing.Size(65, 39);
            this.Mewo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mewo1.TabIndex = 7;
            this.Mewo1.TabStop = false;
            this.Mewo1.Tag = "backBlock";
            // 
            // Book1
            // 
            this.Book1.BackColor = System.Drawing.Color.Transparent;
            this.Book1.Image = global::inTheOverworld.Properties.Resources.book_reverse;
            this.Book1.Location = new System.Drawing.Point(755, 33);
            this.Book1.Name = "Book1";
            this.Book1.Size = new System.Drawing.Size(54, 57);
            this.Book1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Book1.TabIndex = 8;
            this.Book1.TabStop = false;
            this.Book1.Tag = "backBlock";
            // 
            // Computer1
            // 
            this.Computer1.BackColor = System.Drawing.Color.Transparent;
            this.Computer1.Image = global::inTheOverworld.Properties.Resources.computer_reverse;
            this.Computer1.Location = new System.Drawing.Point(370, 233);
            this.Computer1.Name = "Computer1";
            this.Computer1.Size = new System.Drawing.Size(54, 66);
            this.Computer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Computer1.TabIndex = 9;
            this.Computer1.TabStop = false;
            this.Computer1.Tag = "backBlock";
            // 
            // Key1
            // 
            this.Key1.BackColor = System.Drawing.Color.Transparent;
            this.Key1.Image = global::inTheOverworld.Properties.Resources.key2;
            this.Key1.Location = new System.Drawing.Point(712, 171);
            this.Key1.Name = "Key1";
            this.Key1.Size = new System.Drawing.Size(51, 75);
            this.Key1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Key1.TabIndex = 10;
            this.Key1.TabStop = false;
            this.Key1.Tag = "keyItem";
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.Image = global::inTheOverworld.Properties.Resources.omoriRight3;
            this.Player1.Location = new System.Drawing.Point(11, 249);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(50, 50);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 11;
            this.Player1.TabStop = false;
            this.Player1.Tag = "player";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20D;
            this.gameTimer.SynchronizingObject = this;
            this.gameTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.gameTimer_Elapsed);
            // 
            // cutsceneTimer
            // 
            this.cutsceneTimer.Interval = 1000D;
            this.cutsceneTimer.SynchronizingObject = this;
            this.cutsceneTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.cutsceneTimer_Elapsed);
            // 
            // GameLose
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::inTheOverworld.Properties.Resources._parallax_black;
            this.ClientSize = new System.Drawing.Size(910, 587);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Key1);
            this.Controls.Add(this.Computer1);
            this.Controls.Add(this.Book1);
            this.Controls.Add(this.Mewo1);
            this.Controls.Add(this.Tissues1);
            this.Controls.Add(this.Lamp1);
            this.Controls.Add(this.Door1);
            this.Controls.Add(this.HitBlock2);
            this.Controls.Add(this.HitBlock1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(916, 616);
            this.MinimumSize = new System.Drawing.Size(916, 616);
            this.Name = "GameLose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Are you sure ?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameLose_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameLose_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameLose_KeyUp);
            ((System.ComponentModel.ISupportInitialize) (this.HitBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.HitBlock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Door1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Lamp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Tissues1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Mewo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Book1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Computer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Key1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.gameTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.cutsceneTimer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer cutsceneTimer;

        private System.Timers.Timer gameTimer;

        private System.Windows.Forms.PictureBox Player1;

        private System.Windows.Forms.PictureBox Tissues1;

        private System.Windows.Forms.PictureBox HitBlock2;

        private System.Windows.Forms.PictureBox Mewo1;

        private System.Windows.Forms.PictureBox Key1;

        private System.Windows.Forms.PictureBox Computer1;

        private System.Windows.Forms.PictureBox Book1;

        private System.Windows.Forms.PictureBox Lamp1;

        private System.Windows.Forms.PictureBox Door1;

        private System.Windows.Forms.PictureBox HitBlock1;

        #endregion
    }
}