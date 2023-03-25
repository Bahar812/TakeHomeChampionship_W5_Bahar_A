namespace TakeHomeChampionship
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
            this.label_Soccer = new System.Windows.Forms.Label();
            this.label_TeamCountry = new System.Windows.Forms.Label();
            this.label_ChooseTeam = new System.Windows.Forms.Label();
            this.txtBoxTeamName = new System.Windows.Forms.TextBox();
            this.comboBoxChooseCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseTeam = new System.Windows.Forms.ComboBox();
            this.label_nambahTeam = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelTeamCountry = new System.Windows.Forms.Label();
            this.labelTeamCity = new System.Windows.Forms.Label();
            this.textBoxTeamCountry = new System.Windows.Forms.TextBox();
            this.textBoxTeamCity = new System.Windows.Forms.TextBox();
            this.labelAddPlayer = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelPlayerNumber = new System.Windows.Forms.Label();
            this.textBox_PlayerName = new System.Windows.Forms.TextBox();
            this.textBox_PlayerNumber = new System.Windows.Forms.TextBox();
            this.labelPlayerPositition = new System.Windows.Forms.Label();
            this.comboBox_PlayerPosition = new System.Windows.Forms.ComboBox();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.listBox_Player = new System.Windows.Forms.ListBox();
            this.buttonRemovePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Soccer
            // 
            this.label_Soccer.AutoSize = true;
            this.label_Soccer.Location = new System.Drawing.Point(42, 52);
            this.label_Soccer.Name = "label_Soccer";
            this.label_Soccer.Size = new System.Drawing.Size(60, 13);
            this.label_Soccer.TabIndex = 0;
            this.label_Soccer.Text = "Soccer List";
            // 
            // label_TeamCountry
            // 
            this.label_TeamCountry.AutoSize = true;
            this.label_TeamCountry.Location = new System.Drawing.Point(42, 90);
            this.label_TeamCountry.Name = "label_TeamCountry";
            this.label_TeamCountry.Size = new System.Drawing.Size(82, 13);
            this.label_TeamCountry.TabIndex = 1;
            this.label_TeamCountry.Text = "Choose Country";
            // 
            // label_ChooseTeam
            // 
            this.label_ChooseTeam.AutoSize = true;
            this.label_ChooseTeam.Location = new System.Drawing.Point(42, 126);
            this.label_ChooseTeam.Name = "label_ChooseTeam";
            this.label_ChooseTeam.Size = new System.Drawing.Size(73, 13);
            this.label_ChooseTeam.TabIndex = 2;
            this.label_ChooseTeam.Text = "Choose Team";
            // 
            // txtBoxTeamName
            // 
            this.txtBoxTeamName.Location = new System.Drawing.Point(395, 86);
            this.txtBoxTeamName.Name = "txtBoxTeamName";
            this.txtBoxTeamName.Size = new System.Drawing.Size(125, 20);
            this.txtBoxTeamName.TabIndex = 3;
            // 
            // comboBoxChooseCountry
            // 
            this.comboBoxChooseCountry.FormattingEnabled = true;
            this.comboBoxChooseCountry.Location = new System.Drawing.Point(130, 87);
            this.comboBoxChooseCountry.Name = "comboBoxChooseCountry";
            this.comboBoxChooseCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseCountry.TabIndex = 4;
            this.comboBoxChooseCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseCountry_SelectedIndexChanged);
            this.comboBoxChooseCountry.SelectionChangeCommitted += new System.EventHandler(this.comboBoxChooseCountry_SelectionChangeCommitted);
            // 
            // comboBoxChooseTeam
            // 
            this.comboBoxChooseTeam.FormattingEnabled = true;
            this.comboBoxChooseTeam.Location = new System.Drawing.Point(130, 122);
            this.comboBoxChooseTeam.Name = "comboBoxChooseTeam";
            this.comboBoxChooseTeam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseTeam.TabIndex = 5;
            this.comboBoxChooseTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseTeam_SelectedIndexChanged);
            // 
            // label_nambahTeam
            // 
            this.label_nambahTeam.AutoSize = true;
            this.label_nambahTeam.Location = new System.Drawing.Point(366, 52);
            this.label_nambahTeam.Name = "label_nambahTeam";
            this.label_nambahTeam.Size = new System.Drawing.Size(70, 13);
            this.label_nambahTeam.TabIndex = 6;
            this.label_nambahTeam.Text = "Adding Team";
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(314, 89);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(65, 13);
            this.labelTeamName.TabIndex = 7;
            this.labelTeamName.Text = "Team Name";
            // 
            // labelTeamCountry
            // 
            this.labelTeamCountry.AutoSize = true;
            this.labelTeamCountry.Location = new System.Drawing.Point(314, 126);
            this.labelTeamCountry.Name = "labelTeamCountry";
            this.labelTeamCountry.Size = new System.Drawing.Size(73, 13);
            this.labelTeamCountry.TabIndex = 8;
            this.labelTeamCountry.Text = "Team Country";
            // 
            // labelTeamCity
            // 
            this.labelTeamCity.AutoSize = true;
            this.labelTeamCity.Location = new System.Drawing.Point(314, 158);
            this.labelTeamCity.Name = "labelTeamCity";
            this.labelTeamCity.Size = new System.Drawing.Size(54, 13);
            this.labelTeamCity.TabIndex = 9;
            this.labelTeamCity.Text = "Team City";
            // 
            // textBoxTeamCountry
            // 
            this.textBoxTeamCountry.Location = new System.Drawing.Point(395, 123);
            this.textBoxTeamCountry.Name = "textBoxTeamCountry";
            this.textBoxTeamCountry.Size = new System.Drawing.Size(125, 20);
            this.textBoxTeamCountry.TabIndex = 10;
            // 
            // textBoxTeamCity
            // 
            this.textBoxTeamCity.Location = new System.Drawing.Point(395, 155);
            this.textBoxTeamCity.Name = "textBoxTeamCity";
            this.textBoxTeamCity.Size = new System.Drawing.Size(125, 20);
            this.textBoxTeamCity.TabIndex = 11;
            // 
            // labelAddPlayer
            // 
            this.labelAddPlayer.AutoSize = true;
            this.labelAddPlayer.Location = new System.Drawing.Point(648, 51);
            this.labelAddPlayer.Name = "labelAddPlayer";
            this.labelAddPlayer.Size = new System.Drawing.Size(72, 13);
            this.labelAddPlayer.TabIndex = 12;
            this.labelAddPlayer.Text = "Adding Player";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(572, 89);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(67, 13);
            this.labelPlayerName.TabIndex = 13;
            this.labelPlayerName.Text = "Player Name";
            // 
            // labelPlayerNumber
            // 
            this.labelPlayerNumber.AutoSize = true;
            this.labelPlayerNumber.Location = new System.Drawing.Point(572, 126);
            this.labelPlayerNumber.Name = "labelPlayerNumber";
            this.labelPlayerNumber.Size = new System.Drawing.Size(76, 13);
            this.labelPlayerNumber.TabIndex = 14;
            this.labelPlayerNumber.Text = "Player Number";
            // 
            // textBox_PlayerName
            // 
            this.textBox_PlayerName.Location = new System.Drawing.Point(651, 83);
            this.textBox_PlayerName.Name = "textBox_PlayerName";
            this.textBox_PlayerName.Size = new System.Drawing.Size(124, 20);
            this.textBox_PlayerName.TabIndex = 15;
            // 
            // textBox_PlayerNumber
            // 
            this.textBox_PlayerNumber.Location = new System.Drawing.Point(651, 123);
            this.textBox_PlayerNumber.Name = "textBox_PlayerNumber";
            this.textBox_PlayerNumber.Size = new System.Drawing.Size(124, 20);
            this.textBox_PlayerNumber.TabIndex = 16;
            // 
            // labelPlayerPositition
            // 
            this.labelPlayerPositition.AutoSize = true;
            this.labelPlayerPositition.Location = new System.Drawing.Point(572, 162);
            this.labelPlayerPositition.Name = "labelPlayerPositition";
            this.labelPlayerPositition.Size = new System.Drawing.Size(76, 13);
            this.labelPlayerPositition.TabIndex = 17;
            this.labelPlayerPositition.Text = "Player Position";
            // 
            // comboBox_PlayerPosition
            // 
            this.comboBox_PlayerPosition.FormattingEnabled = true;
            this.comboBox_PlayerPosition.Location = new System.Drawing.Point(651, 158);
            this.comboBox_PlayerPosition.Name = "comboBox_PlayerPosition";
            this.comboBox_PlayerPosition.Size = new System.Drawing.Size(124, 21);
            this.comboBox_PlayerPosition.TabIndex = 18;
            this.comboBox_PlayerPosition.SelectedIndexChanged += new System.EventHandler(this.comboBox_PlayerPosition_SelectedIndexChanged);
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(395, 198);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTeam.TabIndex = 19;
            this.buttonAddTeam.Text = "Add";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(651, 198);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlayer.TabIndex = 20;
            this.buttonAddPlayer.Text = "Add";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // listBox_Player
            // 
            this.listBox_Player.FormattingEnabled = true;
            this.listBox_Player.Location = new System.Drawing.Point(45, 188);
            this.listBox_Player.Name = "listBox_Player";
            this.listBox_Player.Size = new System.Drawing.Size(206, 160);
            this.listBox_Player.TabIndex = 21;
            // 
            // buttonRemovePlayer
            // 
            this.buttonRemovePlayer.Location = new System.Drawing.Point(49, 366);
            this.buttonRemovePlayer.Name = "buttonRemovePlayer";
            this.buttonRemovePlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonRemovePlayer.TabIndex = 22;
            this.buttonRemovePlayer.Text = "Remove";
            this.buttonRemovePlayer.UseVisualStyleBackColor = true;
            this.buttonRemovePlayer.Click += new System.EventHandler(this.buttonRemovePlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemovePlayer);
            this.Controls.Add(this.listBox_Player);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.comboBox_PlayerPosition);
            this.Controls.Add(this.labelPlayerPositition);
            this.Controls.Add(this.textBox_PlayerNumber);
            this.Controls.Add(this.textBox_PlayerName);
            this.Controls.Add(this.labelPlayerNumber);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.labelAddPlayer);
            this.Controls.Add(this.textBoxTeamCity);
            this.Controls.Add(this.textBoxTeamCountry);
            this.Controls.Add(this.labelTeamCity);
            this.Controls.Add(this.labelTeamCountry);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.label_nambahTeam);
            this.Controls.Add(this.comboBoxChooseTeam);
            this.Controls.Add(this.comboBoxChooseCountry);
            this.Controls.Add(this.txtBoxTeamName);
            this.Controls.Add(this.label_ChooseTeam);
            this.Controls.Add(this.label_TeamCountry);
            this.Controls.Add(this.label_Soccer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Soccer;
        private System.Windows.Forms.Label label_TeamCountry;
        private System.Windows.Forms.Label label_ChooseTeam;
        private System.Windows.Forms.TextBox txtBoxTeamName;
        private System.Windows.Forms.ComboBox comboBoxChooseCountry;
        private System.Windows.Forms.ComboBox comboBoxChooseTeam;
        private System.Windows.Forms.Label label_nambahTeam;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelTeamCountry;
        private System.Windows.Forms.Label labelTeamCity;
        private System.Windows.Forms.TextBox textBoxTeamCountry;
        private System.Windows.Forms.TextBox textBoxTeamCity;
        private System.Windows.Forms.Label labelAddPlayer;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelPlayerNumber;
        private System.Windows.Forms.TextBox textBox_PlayerName;
        private System.Windows.Forms.TextBox textBox_PlayerNumber;
        private System.Windows.Forms.Label labelPlayerPositition;
        private System.Windows.Forms.ComboBox comboBox_PlayerPosition;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.ListBox listBox_Player;
        private System.Windows.Forms.Button buttonRemovePlayer;
    }
}

