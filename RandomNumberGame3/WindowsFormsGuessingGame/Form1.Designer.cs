namespace WindowsFormsGuessingGame
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
            this.submitName = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.TextBox();
            this.enterNameLbl = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.GroupBox();
            this.score = new System.Windows.Forms.TextBox();
            this.previousGuessesLbl = new System.Windows.Forms.Label();
            this.submitGuess = new System.Windows.Forms.Button();
            this.guess = new System.Windows.Forms.TextBox();
            this.makeGuessLbl = new System.Windows.Forms.Label();
            this.difficultyLevelBox = new System.Windows.Forms.GroupBox();
            this.hardLevel = new System.Windows.Forms.RadioButton();
            this.mediumLevel = new System.Windows.Forms.RadioButton();
            this.easyLevel = new System.Windows.Forms.RadioButton();
            this.gameTitle = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.testing = new System.Windows.Forms.Label();
            this.scoreBox.SuspendLayout();
            this.difficultyLevelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitName
            // 
            this.submitName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitName.Location = new System.Drawing.Point(322, 309);
            this.submitName.Margin = new System.Windows.Forms.Padding(2);
            this.submitName.MinimumSize = new System.Drawing.Size(80, 32);
            this.submitName.Name = "submitName";
            this.submitName.Size = new System.Drawing.Size(221, 50);
            this.submitName.TabIndex = 21;
            this.submitName.Text = "Submit";
            this.submitName.UseVisualStyleBackColor = true;
            // 
            // playerName
            // 
            this.playerName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(322, 255);
            this.playerName.Margin = new System.Windows.Forms.Padding(2);
            this.playerName.MinimumSize = new System.Drawing.Size(4, 50);
            this.playerName.Multiline = true;
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(221, 50);
            this.playerName.TabIndex = 20;
            // 
            // enterNameLbl
            // 
            this.enterNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLbl.Location = new System.Drawing.Point(364, 209);
            this.enterNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterNameLbl.Name = "enterNameLbl";
            this.enterNameLbl.Size = new System.Drawing.Size(146, 39);
            this.enterNameLbl.TabIndex = 19;
            this.enterNameLbl.Text = "Enter player name\r\n(5 characters max)";
            // 
            // scoreBox
            // 
            this.scoreBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scoreBox.Controls.Add(this.score);
            this.scoreBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBox.Location = new System.Drawing.Point(322, 72);
            this.scoreBox.Margin = new System.Windows.Forms.Padding(2);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Padding = new System.Windows.Forms.Padding(2);
            this.scoreBox.Size = new System.Drawing.Size(221, 113);
            this.scoreBox.TabIndex = 18;
            this.scoreBox.TabStop = false;
            this.scoreBox.Text = "Score";
            // 
            // score
            // 
            this.score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.score.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(26, 23);
            this.score.Margin = new System.Windows.Forms.Padding(2);
            this.score.MinimumSize = new System.Drawing.Size(121, 4);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(171, 80);
            this.score.TabIndex = 0;
            // 
            // previousGuessesLbl
            // 
            this.previousGuessesLbl.AutoSize = true;
            this.previousGuessesLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousGuessesLbl.Location = new System.Drawing.Point(222, 423);
            this.previousGuessesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previousGuessesLbl.Name = "previousGuessesLbl";
            this.previousGuessesLbl.Size = new System.Drawing.Size(120, 18);
            this.previousGuessesLbl.TabIndex = 16;
            this.previousGuessesLbl.Text = "Previous guesses";
            // 
            // submitGuess
            // 
            this.submitGuess.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitGuess.Location = new System.Drawing.Point(27, 309);
            this.submitGuess.Margin = new System.Windows.Forms.Padding(2);
            this.submitGuess.MinimumSize = new System.Drawing.Size(80, 32);
            this.submitGuess.Name = "submitGuess";
            this.submitGuess.Size = new System.Drawing.Size(221, 50);
            this.submitGuess.TabIndex = 15;
            this.submitGuess.Text = "Submit";
            this.submitGuess.UseVisualStyleBackColor = true;
            this.submitGuess.Click += new System.EventHandler(this.SubmitGuess_Click);
            // 
            // guess
            // 
            this.guess.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess.Location = new System.Drawing.Point(27, 255);
            this.guess.Margin = new System.Windows.Forms.Padding(2);
            this.guess.MinimumSize = new System.Drawing.Size(81, 50);
            this.guess.Multiline = true;
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(221, 50);
            this.guess.TabIndex = 14;
            this.guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // makeGuessLbl
            // 
            this.makeGuessLbl.AutoSize = true;
            this.makeGuessLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeGuessLbl.Location = new System.Drawing.Point(80, 219);
            this.makeGuessLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.makeGuessLbl.Name = "makeGuessLbl";
            this.makeGuessLbl.Size = new System.Drawing.Size(120, 18);
            this.makeGuessLbl.TabIndex = 13;
            this.makeGuessLbl.Text = "Make your guess";
            // 
            // difficultyLevelBox
            // 
            this.difficultyLevelBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.difficultyLevelBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.difficultyLevelBox.Controls.Add(this.hardLevel);
            this.difficultyLevelBox.Controls.Add(this.mediumLevel);
            this.difficultyLevelBox.Controls.Add(this.easyLevel);
            this.difficultyLevelBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLevelBox.Location = new System.Drawing.Point(27, 72);
            this.difficultyLevelBox.Margin = new System.Windows.Forms.Padding(2);
            this.difficultyLevelBox.Name = "difficultyLevelBox";
            this.difficultyLevelBox.Padding = new System.Windows.Forms.Padding(2);
            this.difficultyLevelBox.Size = new System.Drawing.Size(221, 113);
            this.difficultyLevelBox.TabIndex = 12;
            this.difficultyLevelBox.TabStop = false;
            this.difficultyLevelBox.Text = "Choose difficulty level";
            // 
            // hardLevel
            // 
            this.hardLevel.AutoSize = true;
            this.hardLevel.Location = new System.Drawing.Point(29, 79);
            this.hardLevel.Margin = new System.Windows.Forms.Padding(2);
            this.hardLevel.Name = "hardLevel";
            this.hardLevel.Size = new System.Drawing.Size(60, 22);
            this.hardLevel.TabIndex = 2;
            this.hardLevel.Text = "Hard";
            this.hardLevel.UseVisualStyleBackColor = true;
            // 
            // mediumLevel
            // 
            this.mediumLevel.AutoSize = true;
            this.mediumLevel.Location = new System.Drawing.Point(29, 54);
            this.mediumLevel.Margin = new System.Windows.Forms.Padding(2);
            this.mediumLevel.Name = "mediumLevel";
            this.mediumLevel.Size = new System.Drawing.Size(80, 22);
            this.mediumLevel.TabIndex = 1;
            this.mediumLevel.Text = "Medium";
            this.mediumLevel.UseVisualStyleBackColor = true;
            // 
            // easyLevel
            // 
            this.easyLevel.AutoSize = true;
            this.easyLevel.Checked = true;
            this.easyLevel.Location = new System.Drawing.Point(29, 29);
            this.easyLevel.Margin = new System.Windows.Forms.Padding(2);
            this.easyLevel.Name = "easyLevel";
            this.easyLevel.Size = new System.Drawing.Size(60, 22);
            this.easyLevel.TabIndex = 0;
            this.easyLevel.TabStop = true;
            this.easyLevel.Text = "Easy";
            this.easyLevel.UseVisualStyleBackColor = true;
            // 
            // gameTitle
            // 
            this.gameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameTitle.Font = new System.Drawing.Font("Tahoma", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameTitle.Location = new System.Drawing.Point(11, 6);
            this.gameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(553, 47);
            this.gameTitle.TabIndex = 11;
            this.gameTitle.Text = "RANDOM NUMBER GAME";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 444);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(516, 148);
            this.listBox1.TabIndex = 22;
            // 
            // testing
            // 
            this.testing.AutoSize = true;
            this.testing.Location = new System.Drawing.Point(263, 377);
            this.testing.Name = "testing";
            this.testing.Size = new System.Drawing.Size(55, 17);
            this.testing.TabIndex = 23;
            this.testing.Text = "Testing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 610);
            this.Controls.Add(this.testing);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.submitName);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.enterNameLbl);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.previousGuessesLbl);
            this.Controls.Add(this.submitGuess);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.makeGuessLbl);
            this.Controls.Add(this.difficultyLevelBox);
            this.Controls.Add(this.gameTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.scoreBox.ResumeLayout(false);
            this.scoreBox.PerformLayout();
            this.difficultyLevelBox.ResumeLayout(false);
            this.difficultyLevelBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitName;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Label enterNameLbl;
        private System.Windows.Forms.GroupBox scoreBox;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.Label previousGuessesLbl;
        private System.Windows.Forms.Button submitGuess;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Label makeGuessLbl;
        private System.Windows.Forms.GroupBox difficultyLevelBox;
        private System.Windows.Forms.RadioButton hardLevel;
        private System.Windows.Forms.RadioButton mediumLevel;
        private System.Windows.Forms.RadioButton easyLevel;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label testing;
    }
}

