using System;
using System.Windows.Forms;

namespace FightClub_Lipnyagov
{
    class GameController
    {
        private GameParticipant human, computer;
        private FightClubForm form;
        private LogsForm logsForm;
        private PlayerForm userForm;
        private PlayerForm computerForm;
        private const short HIT_HP = 10;
        private Random random = new Random();

        public GameController(FightClubForm form, LogsForm logsForm, PlayerForm userForm, PlayerForm computerForm, GameParticipant human, GameParticipant computer)
        {
            this.userForm = userForm;
            this.computerForm = computerForm;
            this.logsForm = logsForm;
            this.form = form;
            this.human = human;
            this.computer = computer;
        }

        public void StartGameRound()
        {
            // 1 step: user attack
            computer.SetBlock(GenerateComputerChoice());
            computer.GetGit(AnalyseHumanChoice(form.headRadioButton, form.bodyRadioButton, form.feetRadioButton));

            // 2 step: check if computer is alive
            computer = computer.Death();

            // 3 step: computer attack
            human.SetBlock(AnalyseHumanChoice(form.headRadioButtonBlock, form.bodyRadioButtonBlock, form.feetRadioButtonBlock));
            human.GetGit(GenerateComputerChoice());

            // 4 step: check if human is alive
            human = human.Death();
        }

        private GameParticipant DeathHandler(GameParticipant user)
        {
            logsForm.UpdateLogs(user.name + " was dead... \r");
            form.startFightButton.Enabled = false;
            return user;
        }

        private GameParticipant WoundHandler(GameParticipant user)
        {
            logsForm.UpdateLogs(user.name + " got damage 10hp \r");
            user.health -= HIT_HP; // one hit equals 10hp

            if (user.name == human.name)
            {
                userForm.UpdateHealth(user.health);
            }
            else
            {
                computerForm.UpdateHealth(user.health);
            }

            return user;
        }

        private GameParticipant BlockHandler(GameParticipant user, PartOfBody blockedPart)
        {
            logsForm.UpdateLogs(user.name + " blocked the attack, " + blockedPart + " kick blocked \r");
            return user;
        }

        private PartOfBody GenerateComputerChoice()
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    return PartOfBody.head;
                case 2:
                    return PartOfBody.body;
                case 3:
                    return PartOfBody.feet;
                default:
                    return PartOfBody.body;
            }
        }

        private PartOfBody AnalyseHumanChoice(RadioButton rb1, RadioButton rb2, RadioButton rb3)
        {
            if (rb1.Checked)
            {
                return PartOfBody.head;
            }
            else if (rb2.Checked)
            {
                return PartOfBody.body;
            }
            else
            {
                return PartOfBody.feet;
            }
        }
    }
}
