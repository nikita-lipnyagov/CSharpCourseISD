using System;
using System.Windows.Forms;

namespace FightClub_Lipnyagov
{
    public partial class LogsForm : Form
    {

        public LogsForm()
        {
            InitializeComponent();
        }

        public void UpdateLogs(String log)
        {
            logsRichTextBox.Text += log;
        }

        private void LogsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
