namespace FightClub_Lipnyagov
{
    partial class LogsForm
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
            this.logsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // logsRichTextBox
            // 
            this.logsRichTextBox.Location = new System.Drawing.Point(-3, -1);
            this.logsRichTextBox.Name = "logsRichTextBox";
            this.logsRichTextBox.Size = new System.Drawing.Size(239, 325);
            this.logsRichTextBox.TabIndex = 5;
            this.logsRichTextBox.Text = "";
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 317);
            this.ControlBox = false;
            this.Controls.Add(this.logsRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox logsRichTextBox;
    }
}