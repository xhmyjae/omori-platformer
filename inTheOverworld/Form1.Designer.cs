namespace inTheOverworld
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Title1Menu = new System.Windows.Forms.PictureBox();
            this.OmoriNPCMenu = new System.Windows.Forms.PictureBox();
            this.Title2Menu = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuTimer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.Title1Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OmoriNPCMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // Title1Menu
            // 
            this.Title1Menu.BackColor = System.Drawing.Color.Transparent;
            this.Title1Menu.Image = global::inTheOverworld.Properties.Resources.OMORI_logo;
            this.Title1Menu.Location = new System.Drawing.Point(286, 99);
            this.Title1Menu.Name = "Title1Menu";
            this.Title1Menu.Size = new System.Drawing.Size(306, 125);
            this.Title1Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Title1Menu.TabIndex = 0;
            this.Title1Menu.TabStop = false;
            // 
            // OmoriNPCMenu
            // 
            this.OmoriNPCMenu.BackColor = System.Drawing.Color.Transparent;
            this.OmoriNPCMenu.Image = global::inTheOverworld.Properties.Resources.omoriGoingRight;
            this.OmoriNPCMenu.Location = new System.Drawing.Point(418, 308);
            this.OmoriNPCMenu.Name = "OmoriNPCMenu";
            this.OmoriNPCMenu.Size = new System.Drawing.Size(64, 64);
            this.OmoriNPCMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OmoriNPCMenu.TabIndex = 1;
            this.OmoriNPCMenu.TabStop = false;
            // 
            // Title2Menu
            // 
            this.Title2Menu.BackColor = System.Drawing.Color.Transparent;
            this.Title2Menu.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2Menu.Location = new System.Drawing.Point(541, 227);
            this.Title2Menu.Name = "Title2Menu";
            this.Title2Menu.Size = new System.Drawing.Size(245, 38);
            this.Title2Menu.TabIndex = 2;
            this.Title2Menu.Text = "in the overworld...";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Black;
            this.PlayButton.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(66, 473);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(130, 44);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.Black;
            this.HelpButton.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.ForeColor = System.Drawing.Color.White;
            this.HelpButton.Location = new System.Drawing.Point(390, 473);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(130, 44);
            this.HelpButton.TabIndex = 4;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(706, 473);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 44);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // menuTimer
            // 
            this.menuTimer.Enabled = true;
            this.menuTimer.Interval = 20D;
            this.menuTimer.SynchronizingObject = this;
            this.menuTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.menuTimer_Elapsed);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::inTheOverworld.Properties.Resources._polaroidBG_FA_day;
            this.ClientSize = new System.Drawing.Size(910, 581);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Title2Menu);
            this.Controls.Add(this.OmoriNPCMenu);
            this.Controls.Add(this.Title1Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(916, 616);
            this.MinimumSize = new System.Drawing.Size(916, 616);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A day in the overworld";
            ((System.ComponentModel.ISupportInitialize)(this.Title1Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OmoriNPCMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuTimer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer menuTimer;

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button HelpButton;

        private System.Windows.Forms.Button ExitButton;

        private System.Windows.Forms.PictureBox OmoriNPCMenu;
        private System.Windows.Forms.Label Title2Menu;

        private System.Windows.Forms.PictureBox Title1Menu;

        #endregion
    }
}