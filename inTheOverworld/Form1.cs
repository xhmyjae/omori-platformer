using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace inTheOverworld
{
    public partial class Form1 : Form
    {
        SoundPlayer _st = new SoundPlayer(@"../../Resources/OMORI OST - 001 Title.wav");

        public Form1()
        {
            InitializeComponent();
            _st.PlayLooping();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            _st.Stop();
            InGame inGame = new InGame();
            inGame.Show();
            Hide();
        }
    }
}