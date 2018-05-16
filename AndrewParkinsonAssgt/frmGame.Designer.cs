namespace AndrewParkinsonAssgt
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.pbxDice3 = new System.Windows.Forms.PictureBox();
            this.pbxDice2 = new System.Windows.Forms.PictureBox();
            this.pbxDice1 = new System.Windows.Forms.PictureBox();
            this.btnForfeit = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnHoldP1D3 = new System.Windows.Forms.Button();
            this.btnHoldP1D2 = new System.Windows.Forms.Button();
            this.btnHoldP1D1 = new System.Windows.Forms.Button();
            this.lblP2Score = new System.Windows.Forms.Label();
            this.lblP2ScoreLabel = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblRoundNo = new System.Windows.Forms.Label();
            this.lblRollTotal = new System.Windows.Forms.Label();
            this.lblRoundTotal = new System.Windows.Forms.Label();
            this.lblP1ScoreLabel = new System.Windows.Forms.Label();
            this.lblP1Score = new System.Windows.Forms.Label();
            this.lblP2Name = new System.Windows.Forms.Label();
            this.lblP1Name = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.gbPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.pbxDice3);
            this.gbPlayer.Controls.Add(this.lblRoll);
            this.gbPlayer.Controls.Add(this.lblRollTotal);
            this.gbPlayer.Controls.Add(this.pbxDice2);
            this.gbPlayer.Controls.Add(this.lblRollNo);
            this.gbPlayer.Controls.Add(this.pbxDice1);
            this.gbPlayer.Controls.Add(this.btnForfeit);
            this.gbPlayer.Controls.Add(this.btnEndTurn);
            this.gbPlayer.Controls.Add(this.btnRoll);
            this.gbPlayer.Controls.Add(this.btnHoldP1D3);
            this.gbPlayer.Controls.Add(this.btnHoldP1D2);
            this.gbPlayer.Controls.Add(this.lblCurrentPlayer);
            this.gbPlayer.Controls.Add(this.btnHoldP1D1);
            this.gbPlayer.Location = new System.Drawing.Point(8, 8);
            this.gbPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Padding = new System.Windows.Forms.Padding(2);
            this.gbPlayer.Size = new System.Drawing.Size(350, 320);
            this.gbPlayer.TabIndex = 0;
            this.gbPlayer.TabStop = false;
            // 
            // pbxDice3
            // 
            this.pbxDice3.Location = new System.Drawing.Point(235, 56);
            this.pbxDice3.Name = "pbxDice3";
            this.pbxDice3.Size = new System.Drawing.Size(100, 100);
            this.pbxDice3.TabIndex = 6;
            this.pbxDice3.TabStop = false;
            // 
            // pbxDice2
            // 
            this.pbxDice2.Location = new System.Drawing.Point(125, 56);
            this.pbxDice2.Name = "pbxDice2";
            this.pbxDice2.Size = new System.Drawing.Size(100, 100);
            this.pbxDice2.TabIndex = 6;
            this.pbxDice2.TabStop = false;
            // 
            // pbxDice1
            // 
            this.pbxDice1.Location = new System.Drawing.Point(15, 56);
            this.pbxDice1.Name = "pbxDice1";
            this.pbxDice1.Size = new System.Drawing.Size(100, 100);
            this.pbxDice1.TabIndex = 6;
            this.pbxDice1.TabStop = false;
            // 
            // btnForfeit
            // 
            this.btnForfeit.Location = new System.Drawing.Point(280, 16);
            this.btnForfeit.Margin = new System.Windows.Forms.Padding(2);
            this.btnForfeit.Name = "btnForfeit";
            this.btnForfeit.Size = new System.Drawing.Size(56, 19);
            this.btnForfeit.TabIndex = 2;
            this.btnForfeit.Text = "Forfeit";
            this.btnForfeit.UseVisualStyleBackColor = true;
            this.btnForfeit.Click += new System.EventHandler(this.BtnForfeit_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(184, 208);
            this.btnEndTurn.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(136, 80);
            this.btnEndTurn.TabIndex = 4;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(32, 208);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(136, 80);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // btnHoldP1D3
            // 
            this.btnHoldP1D3.Location = new System.Drawing.Point(260, 160);
            this.btnHoldP1D3.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoldP1D3.Name = "btnHoldP1D3";
            this.btnHoldP1D3.Size = new System.Drawing.Size(50, 19);
            this.btnHoldP1D3.TabIndex = 1;
            this.btnHoldP1D3.Text = "Hold";
            this.btnHoldP1D3.UseVisualStyleBackColor = true;
            this.btnHoldP1D3.Click += new System.EventHandler(this.BtnHoldD3_Click);
            // 
            // btnHoldP1D2
            // 
            this.btnHoldP1D2.Location = new System.Drawing.Point(150, 160);
            this.btnHoldP1D2.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoldP1D2.Name = "btnHoldP1D2";
            this.btnHoldP1D2.Size = new System.Drawing.Size(50, 19);
            this.btnHoldP1D2.TabIndex = 1;
            this.btnHoldP1D2.Text = "Hold";
            this.btnHoldP1D2.UseVisualStyleBackColor = true;
            this.btnHoldP1D2.Click += new System.EventHandler(this.BtnHoldD2_Click);
            // 
            // btnHoldP1D1
            // 
            this.btnHoldP1D1.Location = new System.Drawing.Point(40, 160);
            this.btnHoldP1D1.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoldP1D1.Name = "btnHoldP1D1";
            this.btnHoldP1D1.Size = new System.Drawing.Size(50, 19);
            this.btnHoldP1D1.TabIndex = 1;
            this.btnHoldP1D1.Text = "Hold";
            this.btnHoldP1D1.UseVisualStyleBackColor = true;
            this.btnHoldP1D1.Click += new System.EventHandler(this.BtnHoldD1_Click);
            // 
            // lblP2Score
            // 
            this.lblP2Score.AutoSize = true;
            this.lblP2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblP2Score.Location = new System.Drawing.Point(208, 368);
            this.lblP2Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP2Score.Name = "lblP2Score";
            this.lblP2Score.Size = new System.Drawing.Size(23, 25);
            this.lblP2Score.TabIndex = 3;
            this.lblP2Score.Text = "0";
            // 
            // lblP2ScoreLabel
            // 
            this.lblP2ScoreLabel.AutoSize = true;
            this.lblP2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblP2ScoreLabel.Location = new System.Drawing.Point(136, 368);
            this.lblP2ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP2ScoreLabel.Name = "lblP2ScoreLabel";
            this.lblP2ScoreLabel.Size = new System.Drawing.Size(70, 25);
            this.lblP2ScoreLabel.TabIndex = 3;
            this.lblP2ScoreLabel.Text = "Score:";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRound.Location = new System.Drawing.Point(391, 336);
            this.lblRound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(75, 25);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round:";
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRollNo.Location = new System.Drawing.Point(216, 16);
            this.lblRollNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(0, 25);
            this.lblRollNo.TabIndex = 1;
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.HorizontalScrollbar = true;
            this.lbLog.Location = new System.Drawing.Point(377, 11);
            this.lbLog.Margin = new System.Windows.Forms.Padding(2);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(196, 316);
            this.lbLog.TabIndex = 2;
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRoll.Location = new System.Drawing.Point(168, 16);
            this.lblRoll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(50, 25);
            this.lblRoll.TabIndex = 1;
            this.lblRoll.Text = "Roll:";
            // 
            // lblRoundNo
            // 
            this.lblRoundNo.AutoSize = true;
            this.lblRoundNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRoundNo.Location = new System.Drawing.Point(490, 336);
            this.lblRoundNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoundNo.Name = "lblRoundNo";
            this.lblRoundNo.Size = new System.Drawing.Size(0, 25);
            this.lblRoundNo.TabIndex = 1;
            // 
            // lblRollTotal
            // 
            this.lblRollTotal.AutoSize = true;
            this.lblRollTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRollTotal.Location = new System.Drawing.Point(243, 16);
            this.lblRollTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRollTotal.Name = "lblRollTotal";
            this.lblRollTotal.Size = new System.Drawing.Size(0, 25);
            this.lblRollTotal.TabIndex = 1;
            // 
            // lblRoundTotal
            // 
            this.lblRoundTotal.AutoSize = true;
            this.lblRoundTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRoundTotal.Location = new System.Drawing.Point(520, 336);
            this.lblRoundTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoundTotal.Name = "lblRoundTotal";
            this.lblRoundTotal.Size = new System.Drawing.Size(0, 25);
            this.lblRoundTotal.TabIndex = 1;
            // 
            // lblP1ScoreLabel
            // 
            this.lblP1ScoreLabel.AutoSize = true;
            this.lblP1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblP1ScoreLabel.Location = new System.Drawing.Point(136, 336);
            this.lblP1ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP1ScoreLabel.Name = "lblP1ScoreLabel";
            this.lblP1ScoreLabel.Size = new System.Drawing.Size(70, 25);
            this.lblP1ScoreLabel.TabIndex = 3;
            this.lblP1ScoreLabel.Text = "Score:";
            // 
            // lblP1Score
            // 
            this.lblP1Score.AutoSize = true;
            this.lblP1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblP1Score.Location = new System.Drawing.Point(208, 336);
            this.lblP1Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP1Score.Name = "lblP1Score";
            this.lblP1Score.Size = new System.Drawing.Size(23, 25);
            this.lblP1Score.TabIndex = 3;
            this.lblP1Score.Text = "0";
            // 
            // lblP2Name
            // 
            this.lblP2Name.AutoSize = true;
            this.lblP2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblP2Name.Location = new System.Drawing.Point(8, 368);
            this.lblP2Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP2Name.Name = "lblP2Name";
            this.lblP2Name.Size = new System.Drawing.Size(83, 25);
            this.lblP2Name.TabIndex = 3;
            this.lblP2Name.Text = "Player 2";
            // 
            // lblP1Name
            // 
            this.lblP1Name.AutoSize = true;
            this.lblP1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblP1Name.Location = new System.Drawing.Point(8, 336);
            this.lblP1Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP1Name.Name = "lblP1Name";
            this.lblP1Name.Size = new System.Drawing.Size(83, 25);
            this.lblP1Name.TabIndex = 3;
            this.lblP1Name.Text = "Player 1";
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCurrentPlayer.Location = new System.Drawing.Point(10, 16);
            this.lblCurrentPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(83, 25);
            this.lblCurrentPlayer.TabIndex = 3;
            this.lblCurrentPlayer.Text = "Player 1";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 410);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.lblRoundTotal);
            this.Controls.Add(this.lblP1Score);
            this.Controls.Add(this.lblP2Score);
            this.Controls.Add(this.lblRoundNo);
            this.Controls.Add(this.lblP1Name);
            this.Controls.Add(this.lblP2Name);
            this.Controls.Add(this.lblP1ScoreLabel);
            this.Controls.Add(this.lblP2ScoreLabel);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.gbPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(600, 449);
            this.MinimumSize = new System.Drawing.Size(600, 449);
            this.Name = "frmGame";
            this.Text = "Lurgit";
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.Button btnHoldP1D3;
        private System.Windows.Forms.Button btnHoldP1D2;
        private System.Windows.Forms.Button btnHoldP1D1;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblP2ScoreLabel;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Button btnForfeit;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblRoundNo;
        private System.Windows.Forms.Label lblRollTotal;
        private System.Windows.Forms.Label lblRoundTotal;
        private System.Windows.Forms.Label lblP2Score;
        private System.Windows.Forms.PictureBox pbxDice3;
        private System.Windows.Forms.PictureBox pbxDice2;
        private System.Windows.Forms.PictureBox pbxDice1;
        private System.Windows.Forms.Label lblP1ScoreLabel;
        private System.Windows.Forms.Label lblP1Score;
        private System.Windows.Forms.Label lblP2Name;
        private System.Windows.Forms.Label lblP1Name;
        private System.Windows.Forms.Label lblCurrentPlayer;
    }
}