using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub_Lipnyagov
{
    public partial class Form1 : Form
    {
        private User human, computer;
        private const short HIT_HP = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            human = new User("You");
            computer = new User("Computer");

            human.Block += BlockHandler;
            human.TakeWound += WoundHandler;
            human.Die += DeathHandler;

            computer.Block += BlockHandler;
            computer.TakeWound += WoundHandler;
            computer.Die += DeathHandler;

            LogsRichTextBox.Text = "You, please, start attack...\r";

            player1ProgressBar.Value = 100;
            player2ProgressBar.Value = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1 step: user attack
            computer.SetBlock(GenerateComputerChoice());
            computer.GetGit(AnalyseHumanChoice(headRadioButton, bodyRadioButton, feetRadioButton));

            // 2 step: check if computer is alive
            computer = computer.Death();

            // 3 step: computer attack
            human.SetBlock(AnalyseHumanChoice(headRadioButtonBlock, bodyRadioButtonBlock, feetRadioButtonBlock));
            human.GetGit(GenerateComputerChoice());

            // 4 step: check if human is alive
            human = human.Death();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private User DeathHandler(User user)
        {
            LogsRichTextBox.Text += user.name + " was dead... \r";
            startFightButton.Enabled = false;
            return user;
        }
        
        private User WoundHandler(User user)
        {
            LogsRichTextBox.Text += user.name + " got damage 10hp \r";
            user.health -= HIT_HP; // one hit equals 10hp

            if(user.name == human.name)
            {
                player1ProgressBar.Value = user.health;
            }
            else
            {
                player2ProgressBar.Value = user.health;
            }

            return user;
        }

        private User BlockHandler(User user, PartOfBody blockedPart)
        {
            LogsRichTextBox.Text += user.name + " blocked the attack, " + blockedPart + " kick blocked \r";
            return user;
        }

        private PartOfBody GenerateComputerChoice()
        {
            switch (new Random().Next(1, 4))
            {
                case 1:
                    return PartOfBody.Head;
                case 2:
                    return PartOfBody.Body;
                case 3:
                    return PartOfBody.Feet;
                default:
                    return PartOfBody.Body;
            }
        }

        private PartOfBody AnalyseHumanChoice(RadioButton rb1, RadioButton rb2, RadioButton rb3)
        {
            if (rb1.Checked)
            {
                return PartOfBody.Head;
            }
            else if (rb2.Checked)
            {
                return PartOfBody.Body;
            }
            else
            {
                return PartOfBody.Feet;
            }
        }
    }
}
