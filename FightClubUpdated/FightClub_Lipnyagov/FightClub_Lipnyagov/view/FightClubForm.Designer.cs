namespace FightClub_Lipnyagov
{
    partial class FightClubForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightClubForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bodyRadioButtonBlock = new System.Windows.Forms.RadioButton();
            this.headRadioButtonBlock = new System.Windows.Forms.RadioButton();
            this.feetRadioButtonBlock = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bodyRadioButton = new System.Windows.Forms.RadioButton();
            this.headRadioButton = new System.Windows.Forms.RadioButton();
            this.feetRadioButton = new System.Windows.Forms.RadioButton();
            this.startFightButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showLogsButton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(573, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "You";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bodyRadioButtonBlock);
            this.groupBox3.Controls.Add(this.headRadioButtonBlock);
            this.groupBox3.Controls.Add(this.feetRadioButtonBlock);
            this.groupBox3.Location = new System.Drawing.Point(215, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(88, 120);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // bodyRadioButtonBlock
            // 
            this.bodyRadioButtonBlock.AutoSize = true;
            this.bodyRadioButtonBlock.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bodyRadioButtonBlock.Image = ((System.Drawing.Image)(resources.GetObject("bodyRadioButtonBlock.Image")));
            this.bodyRadioButtonBlock.Location = new System.Drawing.Point(11, 46);
            this.bodyRadioButtonBlock.Name = "bodyRadioButtonBlock";
            this.bodyRadioButtonBlock.Size = new System.Drawing.Size(59, 33);
            this.bodyRadioButtonBlock.TabIndex = 5;
            this.bodyRadioButtonBlock.TabStop = true;
            this.bodyRadioButtonBlock.UseVisualStyleBackColor = true;
            // 
            // headRadioButtonBlock
            // 
            this.headRadioButtonBlock.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headRadioButtonBlock.Image = ((System.Drawing.Image)(resources.GetObject("headRadioButtonBlock.Image")));
            this.headRadioButtonBlock.Location = new System.Drawing.Point(11, 2);
            this.headRadioButtonBlock.Name = "headRadioButtonBlock";
            this.headRadioButtonBlock.Size = new System.Drawing.Size(59, 38);
            this.headRadioButtonBlock.TabIndex = 4;
            this.headRadioButtonBlock.TabStop = true;
            this.headRadioButtonBlock.UseVisualStyleBackColor = true;
            // 
            // feetRadioButtonBlock
            // 
            this.feetRadioButtonBlock.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feetRadioButtonBlock.Image = ((System.Drawing.Image)(resources.GetObject("feetRadioButtonBlock.Image")));
            this.feetRadioButtonBlock.Location = new System.Drawing.Point(11, 85);
            this.feetRadioButtonBlock.Name = "feetRadioButtonBlock";
            this.feetRadioButtonBlock.Size = new System.Drawing.Size(66, 54);
            this.feetRadioButtonBlock.TabIndex = 6;
            this.feetRadioButtonBlock.TabStop = true;
            this.feetRadioButtonBlock.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bodyRadioButton);
            this.groupBox2.Controls.Add(this.headRadioButton);
            this.groupBox2.Controls.Add(this.feetRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(81, 132);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // bodyRadioButton
            // 
            this.bodyRadioButton.AutoSize = true;
            this.bodyRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bodyRadioButton.Image = ((System.Drawing.Image)(resources.GetObject("bodyRadioButton.Image")));
            this.bodyRadioButton.Location = new System.Drawing.Point(5, 49);
            this.bodyRadioButton.Name = "bodyRadioButton";
            this.bodyRadioButton.Size = new System.Drawing.Size(59, 33);
            this.bodyRadioButton.TabIndex = 1;
            this.bodyRadioButton.TabStop = true;
            this.bodyRadioButton.UseVisualStyleBackColor = true;
            // 
            // headRadioButton
            // 
            this.headRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headRadioButton.Image = ((System.Drawing.Image)(resources.GetObject("headRadioButton.Image")));
            this.headRadioButton.Location = new System.Drawing.Point(5, 5);
            this.headRadioButton.Name = "headRadioButton";
            this.headRadioButton.Size = new System.Drawing.Size(59, 38);
            this.headRadioButton.TabIndex = 0;
            this.headRadioButton.TabStop = true;
            this.headRadioButton.UseVisualStyleBackColor = true;
            // 
            // feetRadioButton
            // 
            this.feetRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feetRadioButton.Image = ((System.Drawing.Image)(resources.GetObject("feetRadioButton.Image")));
            this.feetRadioButton.Location = new System.Drawing.Point(7, 85);
            this.feetRadioButton.Name = "feetRadioButton";
            this.feetRadioButton.Size = new System.Drawing.Size(57, 46);
            this.feetRadioButton.TabIndex = 2;
            this.feetRadioButton.TabStop = true;
            this.feetRadioButton.UseVisualStyleBackColor = true;
            // 
            // startFightButton
            // 
            this.startFightButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startFightButton.Location = new System.Drawing.Point(10, 219);
            this.startFightButton.Name = "startFightButton";
            this.startFightButton.Size = new System.Drawing.Size(183, 52);
            this.startFightButton.TabIndex = 3;
            this.startFightButton.Text = "Start fight";
            this.startFightButton.UseVisualStyleBackColor = true;
            this.startFightButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Where to kick?";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(211, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "What to block?";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.showLogsButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.startFightButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(196, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 290);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // showLogsButton
            // 
            this.showLogsButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showLogsButton.Location = new System.Drawing.Point(199, 219);
            this.showLogsButton.Name = "showLogsButton";
            this.showLogsButton.Size = new System.Drawing.Size(120, 52);
            this.showLogsButton.TabIndex = 7;
            this.showLogsButton.Text = "Show current logs";
            this.showLogsButton.UseVisualStyleBackColor = true;
            this.showLogsButton.Click += new System.EventHandler(this.showLogsButton_Click);
            // 
            // FightClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FightClubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight Club";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FightClubForm_FormClosed);
            this.Load += new System.EventHandler(this.FightClubForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton bodyRadioButtonBlock;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton bodyRadioButton;
        public System.Windows.Forms.RadioButton headRadioButton;
        public System.Windows.Forms.RadioButton feetRadioButton;
        public System.Windows.Forms.Button startFightButton;
        public System.Windows.Forms.RadioButton headRadioButtonBlock;
        public System.Windows.Forms.RadioButton feetRadioButtonBlock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showLogsButton;
    }
}

