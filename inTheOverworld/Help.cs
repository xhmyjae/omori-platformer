using System;
using System.Windows.Forms;

namespace inTheOverworld
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void GoLeftPanel_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Make the player go left when pressing on of those keys.";
        }

        private void GoLeftPanel_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void GoRightPanel_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Make the player go right when pressing on of those keys.";
        }

        private void GoRightPanel_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void GoUp1Panel_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Make the player jump when pressing on of those keys.";
        }

        private void GoUp1Panel_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}