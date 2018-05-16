namespace AndrewParkinsonAssgt
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btn1Player = new System.Windows.Forms.Button();
            this.btn2PlayerCPU = new System.Windows.Forms.Button();
            this.btn2PlayerVS = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbP1Name = new System.Windows.Forms.GroupBox();
            this.txbP1Name = new System.Windows.Forms.TextBox();
            this.gbP2Name = new System.Windows.Forms.GroupBox();
            this.txbP2Name = new System.Windows.Forms.TextBox();
            this.gbP1Name.SuspendLayout();
            this.gbP2Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1Player
            // 
            this.btn1Player.Location = new System.Drawing.Point(46, 137);
            this.btn1Player.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn1Player.Name = "btn1Player";
            this.btn1Player.Size = new System.Drawing.Size(150, 44);
            this.btn1Player.TabIndex = 0;
            this.btn1Player.Text = "Solo Play";
            this.btn1Player.UseVisualStyleBackColor = true;
            this.btn1Player.Click += new System.EventHandler(this.btn1Player_Click);
            // 
            // btn2PlayerCPU
            // 
            this.btn2PlayerCPU.Location = new System.Drawing.Point(46, 218);
            this.btn2PlayerCPU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn2PlayerCPU.Name = "btn2PlayerCPU";
            this.btn2PlayerCPU.Size = new System.Drawing.Size(150, 44);
            this.btn2PlayerCPU.TabIndex = 0;
            this.btn2PlayerCPU.Text = "Player VS CPU";
            this.btn2PlayerCPU.UseVisualStyleBackColor = true;
            this.btn2PlayerCPU.Click += new System.EventHandler(this.btn2PlayerCPU_Click);
            // 
            // btn2PlayerVS
            // 
            this.btn2PlayerVS.Location = new System.Drawing.Point(46, 299);
            this.btn2PlayerVS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn2PlayerVS.Name = "btn2PlayerVS";
            this.btn2PlayerVS.Size = new System.Drawing.Size(150, 44);
            this.btn2PlayerVS.TabIndex = 0;
            this.btn2PlayerVS.Text = "Player VS Player";
            this.btn2PlayerVS.UseVisualStyleBackColor = true;
            this.btn2PlayerVS.Click += new System.EventHandler(this.btn2PlayerVS_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 78F);
            this.lblTitle.Location = new System.Drawing.Point(85, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 118);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Lurgit";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(21, 379);
            this.lblCredits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(255, 13);
            this.lblCredits.TabIndex = 2;
            this.lblCredits.Text = "By Andrew Parkinson - c3128094 - INFT2012 - 2018";
            this.lblCredits.Click += new System.EventHandler(this.lblCredits_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(380, 377);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbP1Name
            // 
            this.gbP1Name.Controls.Add(this.txbP1Name);
            this.gbP1Name.Location = new System.Drawing.Point(238, 139);
            this.gbP1Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbP1Name.Name = "gbP1Name";
            this.gbP1Name.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbP1Name.Size = new System.Drawing.Size(198, 81);
            this.gbP1Name.TabIndex = 4;
            this.gbP1Name.TabStop = false;
            this.gbP1Name.Text = "Player 1 Name";
            // 
            // txbP1Name
            // 
            this.txbP1Name.Location = new System.Drawing.Point(12, 39);
            this.txbP1Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbP1Name.Name = "txbP1Name";
            this.txbP1Name.Size = new System.Drawing.Size(175, 20);
            this.txbP1Name.TabIndex = 0;
            // 
            // gbP2Name
            // 
            this.gbP2Name.Controls.Add(this.txbP2Name);
            this.gbP2Name.Location = new System.Drawing.Point(238, 256);
            this.gbP2Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbP2Name.Name = "gbP2Name";
            this.gbP2Name.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbP2Name.Size = new System.Drawing.Size(198, 81);
            this.gbP2Name.TabIndex = 4;
            this.gbP2Name.TabStop = false;
            this.gbP2Name.Text = "Player 2 Name";
            // 
            // txbP2Name
            // 
            this.txbP2Name.Location = new System.Drawing.Point(12, 39);
            this.txbP2Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbP2Name.Name = "txbP2Name";
            this.txbP2Name.Size = new System.Drawing.Size(175, 20);
            this.txbP2Name.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 411);
            this.Controls.Add(this.gbP2Name);
            this.Controls.Add(this.gbP1Name);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn2PlayerVS);
            this.Controls.Add(this.btn2PlayerCPU);
            this.Controls.Add(this.btn1Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(484, 450);
            this.MinimumSize = new System.Drawing.Size(484, 450);
            this.Name = "frmMenu";
            this.Text = "Lurgit - Main Menu";
            this.gbP1Name.ResumeLayout(false);
            this.gbP1Name.PerformLayout();
            this.gbP2Name.ResumeLayout(false);
            this.gbP2Name.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Player;
        private System.Windows.Forms.Button btn2PlayerCPU;
        private System.Windows.Forms.Button btn2PlayerVS;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbP1Name;
        private System.Windows.Forms.TextBox txbP1Name;
        private System.Windows.Forms.GroupBox gbP2Name;
        private System.Windows.Forms.TextBox txbP2Name;
    }
}

