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
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.btnP1Forfeit = new System.Windows.Forms.Button();
            this.btnP1EndTurn = new System.Windows.Forms.Button();
            this.lblP1Score = new System.Windows.Forms.Label();
            this.btnP1Roll = new System.Windows.Forms.Button();
            this.btnHoldP1D3 = new System.Windows.Forms.Button();
            this.btnHoldP1D2 = new System.Windows.Forms.Button();
            this.btnHoldP1D1 = new System.Windows.Forms.Button();
            this.dP1D3 = new System.Windows.Forms.Label();
            this.lblP1D3 = new System.Windows.Forms.Label();
            this.dP1D2 = new System.Windows.Forms.Label();
            this.lblP1D2 = new System.Windows.Forms.Label();
            this.dP1D1 = new System.Windows.Forms.Label();
            this.lblP1D1 = new System.Windows.Forms.Label();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.btnP2Forfeit = new System.Windows.Forms.Button();
            this.btnP2EndTurn = new System.Windows.Forms.Button();
            this.lblP2Score = new System.Windows.Forms.Label();
            this.btnP2Roll = new System.Windows.Forms.Button();
            this.btnHoldP2D3 = new System.Windows.Forms.Button();
            this.dP2D3 = new System.Windows.Forms.Label();
            this.lblP2D3 = new System.Windows.Forms.Label();
            this.btnHoldP2D2 = new System.Windows.Forms.Button();
            this.dP2D1 = new System.Windows.Forms.Label();
            this.lblP2D1 = new System.Windows.Forms.Label();
            this.dP2D2 = new System.Windows.Forms.Label();
            this.btnHoldP2D1 = new System.Windows.Forms.Button();
            this.lblP2D2 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.lblP1Name = new System.Windows.Forms.Label();
            this.lblP2Name = new System.Windows.Forms.Label();
            this.gbPlayer1.SuspendLayout();
            this.gbPlayer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.Controls.Add(this.lblP1Name);
            this.gbPlayer1.Controls.Add(this.btnP1Forfeit);
            this.gbPlayer1.Controls.Add(this.btnP1EndTurn);
            this.gbPlayer1.Controls.Add(this.lblP1Score);
            this.gbPlayer1.Controls.Add(this.btnP1Roll);
            this.gbPlayer1.Controls.Add(this.btnHoldP1D3);
            this.gbPlayer1.Controls.Add(this.btnHoldP1D2);
            this.gbPlayer1.Controls.Add(this.btnHoldP1D1);
            this.gbPlayer1.Controls.Add(this.dP1D3);
            this.gbPlayer1.Controls.Add(this.lblP1D3);
            this.gbPlayer1.Controls.Add(this.dP1D2);
            this.gbPlayer1.Controls.Add(this.lblP1D2);
            this.gbPlayer1.Controls.Add(this.dP1D1);
            this.gbPlayer1.Controls.Add(this.lblP1D1);
            this.gbPlayer1.Location = new System.Drawing.Point(8, 8);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(376, 488);
            this.gbPlayer1.TabIndex = 0;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player 1";
            // 
            // btnP1Forfeit
            // 
            this.btnP1Forfeit.Location = new System.Drawing.Point(24, 432);
            this.btnP1Forfeit.Name = "btnP1Forfeit";
            this.btnP1Forfeit.Size = new System.Drawing.Size(75, 23);
            this.btnP1Forfeit.TabIndex = 2;
            this.btnP1Forfeit.Text = "Forfeit";
            this.btnP1Forfeit.UseVisualStyleBackColor = true;
            this.btnP1Forfeit.Click += new System.EventHandler(this.btnP1Forfeit_Click);
            // 
            // btnP1EndTurn
            // 
            this.btnP1EndTurn.Location = new System.Drawing.Point(264, 432);
            this.btnP1EndTurn.Name = "btnP1EndTurn";
            this.btnP1EndTurn.Size = new System.Drawing.Size(75, 23);
            this.btnP1EndTurn.TabIndex = 4;
            this.btnP1EndTurn.Text = "End Turn";
            this.btnP1EndTurn.UseVisualStyleBackColor = true;
            // 
            // lblP1Score
            // 
            this.lblP1Score.AutoSize = true;
            this.lblP1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblP1Score.Location = new System.Drawing.Point(128, 344);
            this.lblP1Score.Name = "lblP1Score";
            this.lblP1Score.Size = new System.Drawing.Size(109, 29);
            this.lblP1Score.TabIndex = 3;
            this.lblP1Score.Text = "Score: --";
            // 
            // btnP1Roll
            // 
            this.btnP1Roll.Location = new System.Drawing.Point(120, 400);
            this.btnP1Roll.Name = "btnP1Roll";
            this.btnP1Roll.Size = new System.Drawing.Size(120, 56);
            this.btnP1Roll.TabIndex = 2;
            this.btnP1Roll.Text = "Roll";
            this.btnP1Roll.UseVisualStyleBackColor = true;
            this.btnP1Roll.Click += new System.EventHandler(this.btnP1Roll_Click);
            // 
            // btnHoldP1D3
            // 
            this.btnHoldP1D3.Location = new System.Drawing.Point(264, 272);
            this.btnHoldP1D3.Name = "btnHoldP1D3";
            this.btnHoldP1D3.Size = new System.Drawing.Size(75, 23);
            this.btnHoldP1D3.TabIndex = 1;
            this.btnHoldP1D3.Text = "Hold";
            this.btnHoldP1D3.UseVisualStyleBackColor = true;
            this.btnHoldP1D3.Click += new System.EventHandler(this.btnHoldP1D3_Click);
            // 
            // btnHoldP1D2
            // 
            this.btnHoldP1D2.Location = new System.Drawing.Point(144, 272);
            this.btnHoldP1D2.Name = "btnHoldP1D2";
            this.btnHoldP1D2.Size = new System.Drawing.Size(75, 23);
            this.btnHoldP1D2.TabIndex = 1;
            this.btnHoldP1D2.Text = "Hold";
            this.btnHoldP1D2.UseVisualStyleBackColor = true;
            this.btnHoldP1D2.Click += new System.EventHandler(this.btnHoldP1D2_Click);
            // 
            // btnHoldP1D1
            // 
            this.btnHoldP1D1.Location = new System.Drawing.Point(24, 272);
            this.btnHoldP1D1.Name = "btnHoldP1D1";
            this.btnHoldP1D1.Size = new System.Drawing.Size(75, 23);
            this.btnHoldP1D1.TabIndex = 1;
            this.btnHoldP1D1.Text = "Hold";
            this.btnHoldP1D1.UseVisualStyleBackColor = true;
            this.btnHoldP1D1.Click += new System.EventHandler(this.btnHoldP1D1_Click);
            // 
            // dP1D3
            // 
            this.dP1D3.AutoSize = true;
            this.dP1D3.Location = new System.Drawing.Point(288, 200);
            this.dP1D3.Name = "dP1D3";
            this.dP1D3.Size = new System.Drawing.Size(26, 17);
            this.dP1D3.TabIndex = 0;
            this.dP1D3.Text = "D3";
            // 
            // lblP1D3
            // 
            this.lblP1D3.AutoSize = true;
            this.lblP1D3.Location = new System.Drawing.Point(288, 112);
            this.lblP1D3.Name = "lblP1D3";
            this.lblP1D3.Size = new System.Drawing.Size(26, 17);
            this.lblP1D3.TabIndex = 0;
            this.lblP1D3.Text = "D3";
            // 
            // dP1D2
            // 
            this.dP1D2.AutoSize = true;
            this.dP1D2.Location = new System.Drawing.Point(168, 200);
            this.dP1D2.Name = "dP1D2";
            this.dP1D2.Size = new System.Drawing.Size(26, 17);
            this.dP1D2.TabIndex = 0;
            this.dP1D2.Text = "D2";
            // 
            // lblP1D2
            // 
            this.lblP1D2.AutoSize = true;
            this.lblP1D2.Location = new System.Drawing.Point(168, 112);
            this.lblP1D2.Name = "lblP1D2";
            this.lblP1D2.Size = new System.Drawing.Size(26, 17);
            this.lblP1D2.TabIndex = 0;
            this.lblP1D2.Text = "D2";
            // 
            // dP1D1
            // 
            this.dP1D1.AutoSize = true;
            this.dP1D1.Location = new System.Drawing.Point(48, 200);
            this.dP1D1.Name = "dP1D1";
            this.dP1D1.Size = new System.Drawing.Size(26, 17);
            this.dP1D1.TabIndex = 0;
            this.dP1D1.Text = "D1";
            // 
            // lblP1D1
            // 
            this.lblP1D1.AutoSize = true;
            this.lblP1D1.Location = new System.Drawing.Point(48, 112);
            this.lblP1D1.Name = "lblP1D1";
            this.lblP1D1.Size = new System.Drawing.Size(26, 17);
            this.lblP1D1.TabIndex = 0;
            this.lblP1D1.Text = "D1";
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.Controls.Add(this.lblP2Name);
            this.gbPlayer2.Controls.Add(this.btnP2Forfeit);
            this.gbPlayer2.Controls.Add(this.btnP2EndTurn);
            this.gbPlayer2.Controls.Add(this.lblP2Score);
            this.gbPlayer2.Controls.Add(this.btnP2Roll);
            this.gbPlayer2.Controls.Add(this.btnHoldP2D3);
            this.gbPlayer2.Controls.Add(this.dP2D3);
            this.gbPlayer2.Controls.Add(this.lblP2D3);
            this.gbPlayer2.Controls.Add(this.btnHoldP2D2);
            this.gbPlayer2.Controls.Add(this.dP2D1);
            this.gbPlayer2.Controls.Add(this.lblP2D1);
            this.gbPlayer2.Controls.Add(this.dP2D2);
            this.gbPlayer2.Controls.Add(this.btnHoldP2D1);
            this.gbPlayer2.Controls.Add(this.lblP2D2);
            this.gbPlayer2.Location = new System.Drawing.Point(392, 8);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(376, 488);
            this.gbPlayer2.TabIndex = 0;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player 2";
            // 
            // btnP2Forfeit
            // 
            this.btnP2Forfeit.Location = new System.Drawing.Point(24, 432);
            this.btnP2Forfeit.Name = "btnP2Forfeit";
            this.btnP2Forfeit.Size = new System.Drawing.Size(75, 23);
            this.btnP2Forfeit.TabIndex = 2;
            this.btnP2Forfeit.Text = "Forfeit";
            this.btnP2Forfeit.UseVisualStyleBackColor = true;
            this.btnP2Forfeit.Click += new System.EventHandler(this.btnP2Forfeit_Click);
            // 
            // btnP2EndTurn
            // 
            this.btnP2EndTurn.Location = new System.Drawing.Point(264, 432);
            this.btnP2EndTurn.Name = "btnP2EndTurn";
            this.btnP2EndTurn.Size = new System.Drawing.Size(75, 23);
            this.btnP2EndTurn.TabIndex = 4;
            this.btnP2EndTurn.Text = "End Turn";
            this.btnP2EndTurn.UseVisualStyleBackColor = true;
            // 
            // lblP2Score
            // 
            this.lblP2Score.AutoSize = true;
            this.lblP2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblP2Score.Location = new System.Drawing.Point(128, 344);
            this.lblP2Score.Name = "lblP2Score";
            this.lblP2Score.Size = new System.Drawing.Size(109, 29);
            this.lblP2Score.TabIndex = 3;
            this.lblP2Score.Text = "Score: --";
            // 
            // btnP2Roll
            // 
            this.btnP2Roll.Location = new System.Drawing.Point(120, 400);
            this.btnP2Roll.Name = "btnP2Roll";
            this.btnP2Roll.Size = new System.Drawing.Size(120, 56);
            this.btnP2Roll.TabIndex = 2;
            this.btnP2Roll.Text = "Roll";
            this.btnP2Roll.UseVisualStyleBackColor = true;
            this.btnP2Roll.Click += new System.EventHandler(this.btnP2Roll_Click);
            // 
            // btnHoldP2D3
            // 
            this.btnHoldP2D3.Location = new System.Drawing.Point(264, 272);
            this.btnHoldP2D3.Name = "btnHoldP2D3";
            this.btnHoldP2D3.Size = new System.Drawing.Size(75, 23);
            this.btnHoldP2D3.TabIndex = 1;
            this.btnHoldP2D3.Text = "Hold";
            this.btnHoldP2D3.UseVisualStyleBackColor = true;
            this.btnHoldP2D3.Click += new System.EventHandler(this.btnHoldP2D3_Click);
            // 
            // dP2D3
            // 
            this.dP2D3.AutoSize = true;
            this.dP2D3.Location = new System.Drawing.Point(288, 200);
            this.dP2D3.Name = "dP2D3";
            this.dP2D3.Size = new System.Drawing.Size(26, 17);
            this.dP2D3.TabIndex = 0;
            this.dP2D3.Text = "D3";
            // 
            // lblP2D3
            // 
            this.lblP2D3.AutoSize = true;
            this.lblP2D3.Location = new System.Drawing.Point(288, 112);
            this.lblP2D3.Name = "lblP2D3";
            this.lblP2D3.Size = new System.Drawing.Size(26, 17);
            this.lblP2D3.TabIndex = 0;
            this.lblP2D3.Text = "D3";
            // 
            // btnHoldP2D2
            // 
            this.btnHoldP2D2.Location = new System.Drawing.Point(144, 272);
            this.btnHoldP2D2.Name = "btnHoldP2D2";
            this.btnHoldP2D2.Size = new System.Drawing.Size(75, 23);
            this.btnHoldP2D2.TabIndex = 1;
            this.btnHoldP2D2.Text = "Hold";
            this.btnHoldP2D2.UseVisualStyleBackColor = true;
            this.btnHoldP2D2.Click += new System.EventHandler(this.btnHoldP2D2_Click);
            // 
            // dP2D1
            // 
            this.dP2D1.AutoSize = true;
            this.dP2D1.Location = new System.Drawing.Point(48, 200);
            this.dP2D1.Name = "dP2D1";
            this.dP2D1.Size = new System.Drawing.Size(26, 17);
            this.dP2D1.TabIndex = 0;
            this.dP2D1.Text = "D1";
            // 
            // lblP2D1
            // 
            this.lblP2D1.AutoSize = true;
            this.lblP2D1.Location = new System.Drawing.Point(48, 112);
            this.lblP2D1.Name = "lblP2D1";
            this.lblP2D1.Size = new System.Drawing.Size(26, 17);
            this.lblP2D1.TabIndex = 0;
            this.lblP2D1.Text = "D1";
            // 
            // dP2D2
            // 
            this.dP2D2.AutoSize = true;
            this.dP2D2.Location = new System.Drawing.Point(168, 200);
            this.dP2D2.Name = "dP2D2";
            this.dP2D2.Size = new System.Drawing.Size(26, 17);
            this.dP2D2.TabIndex = 0;
            this.dP2D2.Text = "D2";
            // 
            // btnHoldP2D1
            // 
            this.btnHoldP2D1.Location = new System.Drawing.Point(24, 272);
            this.btnHoldP2D1.Name = "btnHoldP2D1";
            this.btnHoldP2D1.Size = new System.Drawing.Size(75, 23);
            this.btnHoldP2D1.TabIndex = 1;
            this.btnHoldP2D1.Text = "Hold";
            this.btnHoldP2D1.UseVisualStyleBackColor = true;
            this.btnHoldP2D1.Click += new System.EventHandler(this.btnHoldP2D1_Click);
            // 
            // lblP2D2
            // 
            this.lblP2D2.AutoSize = true;
            this.lblP2D2.Location = new System.Drawing.Point(168, 112);
            this.lblP2D2.Name = "lblP2D2";
            this.lblP2D2.Size = new System.Drawing.Size(26, 17);
            this.lblP2D2.TabIndex = 0;
            this.lblP2D2.Text = "D2";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRound.Location = new System.Drawing.Point(416, 512);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(138, 29);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round: --/6";
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRollNo.Location = new System.Drawing.Point(264, 512);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(108, 29);
            this.lblRollNo.TabIndex = 1;
            this.lblRollNo.Text = "Roll: --/3";
            // 
            // lblP1Name
            // 
            this.lblP1Name.AutoSize = true;
            this.lblP1Name.Location = new System.Drawing.Point(16, 32);
            this.lblP1Name.Name = "lblP1Name";
            this.lblP1Name.Size = new System.Drawing.Size(76, 17);
            this.lblP1Name.TabIndex = 5;
            this.lblP1Name.Text = "lblP1Name";
            // 
            // lblP2Name
            // 
            this.lblP2Name.AutoSize = true;
            this.lblP2Name.Location = new System.Drawing.Point(16, 32);
            this.lblP2Name.Name = "lblP2Name";
            this.lblP2Name.Size = new System.Drawing.Size(76, 17);
            this.lblP2Name.TabIndex = 5;
            this.lblP2Name.Text = "lblP2Name";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmGame";
            this.Text = "Lurgit";
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.Button btnHoldP1D3;
        private System.Windows.Forms.Button btnHoldP1D2;
        private System.Windows.Forms.Button btnHoldP1D1;
        private System.Windows.Forms.Label lblP1D3;
        private System.Windows.Forms.Label lblP1D2;
        private System.Windows.Forms.Label lblP1D1;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.Button btnHoldP2D3;
        private System.Windows.Forms.Label lblP2D3;
        private System.Windows.Forms.Button btnHoldP2D2;
        private System.Windows.Forms.Label lblP2D1;
        private System.Windows.Forms.Button btnHoldP2D1;
        private System.Windows.Forms.Label lblP2D2;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label dP1D3;
        private System.Windows.Forms.Label dP1D2;
        private System.Windows.Forms.Label dP1D1;
        private System.Windows.Forms.Label dP2D3;
        private System.Windows.Forms.Label dP2D1;
        private System.Windows.Forms.Label dP2D2;
        private System.Windows.Forms.Label lblP1Score;
        private System.Windows.Forms.Button btnP1Roll;
        private System.Windows.Forms.Label lblP2Score;
        private System.Windows.Forms.Button btnP2Roll;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Button btnP2Forfeit;
        private System.Windows.Forms.Button btnP1Forfeit;
        private System.Windows.Forms.Button btnP1EndTurn;
        private System.Windows.Forms.Button btnP2EndTurn;
        private System.Windows.Forms.Label lblP1Name;
        private System.Windows.Forms.Label lblP2Name;
    }
}