using System;
using System.Windows.Forms;

namespace FightClub_Lipnyagov
{
    public partial class PlayerForm : Form
    {
        private String playerName;

        public PlayerForm(String playerName)
        {
           
            this.playerName = playerName;
            InitializeComponent();
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            userName.Text = playerName;
            playerProgressBar.Value = 100;
        }

        public void UpdateHealth(int health)
        {
            playerProgressBar.Value = health;
        }
    }
}
