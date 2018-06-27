using System;
using System.Windows.Forms;

namespace FightClub_Lipnyagov
{
    public partial class FightClubForm : Form
    {
        private GameParticipant human, computer;
        private GameController controller;
        private const short HIT_HP = 10;
        private LogsForm logsForm = new LogsForm();
        private PlayerForm userForm = new PlayerForm("YOU");
        private PlayerForm computerForm = new PlayerForm("COMPUTER");

        public FightClubForm()
        {
            InitializeComponent();
        }

        private void FightClubForm_Load(object sender, EventArgs e)
        {
            human = new GameParticipant("You");
            computer = new GameParticipant("Computer");
            controller = new GameController(this, logsForm, userForm, computerForm, human, computer);

            human.Block += BlockHandler;
            human.TakeWound += WoundHandler;
            human.Die += DeathHandler;

            computer.Block += BlockHandler;
            computer.TakeWound += WoundHandler;
            computer.Die += DeathHandler;

            logsForm.UpdateLogs("You, please, start attack...\r"); 

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userForm.Show();
            computerForm.Show();
            controller.StartGameRound();
        }

        private void FightClubForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private GameParticipant DeathHandler(GameParticipant user)
        {
            logsForm.UpdateLogs(user.name + " was dead... \r");
            startFightButton.Enabled = false;
            return user;
        }

        private GameParticipant WoundHandler(GameParticipant user)
        {
            logsForm.UpdateLogs(user.name + " got damage 10hp \r");
            user.health -= HIT_HP; // one hit equals 10hp

            if (user.name == human.name)
            {
                //player1ProgressBar.Value = user.health;
                userForm.UpdateHealth(user.health);
            }
            else
            {
                computerForm.UpdateHealth(user.health);
                //player2ProgressBar.Value = user.health;
            }

            return user;
        }

        private void showLogsButton_Click(object sender, EventArgs e)
        {            
            logsForm.Show();
        }

        private GameParticipant BlockHandler(GameParticipant user, PartOfBody blockedPart)
        {
            logsForm.UpdateLogs(user.name + " blocked the attack, " + blockedPart + " kick blocked \r");
            return user;
        }
       
    }
}
