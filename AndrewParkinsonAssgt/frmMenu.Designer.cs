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
            this.SuspendLayout();
            // 
            // btn1Player
            // 
            this.btn1Player.Location = new System.Drawing.Point(300, 189);
            this.btn1Player.Name = "btn1Player";
            this.btn1Player.Size = new System.Drawing.Size(200, 54);
            this.btn1Player.TabIndex = 0;
            this.btn1Player.Text = " ";
            this.btn1Player.UseVisualStyleBackColor = true;
            this.btn1Player.Click += new System.EventHandler(this.btn1Player_Click);
            // 
            // btn2PlayerCPU
            // 
            this.btn2PlayerCPU.Location = new System.Drawing.Point(300, 289);
            this.btn2PlayerCPU.Name = "btn2PlayerCPU";
            this.btn2PlayerCPU.Size = new System.Drawing.Size(200, 54);
            this.btn2PlayerCPU.TabIndex = 0;
            this.btn2PlayerCPU.Text = "Player VS CPU";
            this.btn2PlayerCPU.UseVisualStyleBackColor = true;
            this.btn2PlayerCPU.Click += new System.EventHandler(this.btn2PlayerCPU_Click);
            // 
            // btn2PlayerVS
            // 
            this.btn2PlayerVS.Location = new System.Drawing.Point(300, 389);
            this.btn2PlayerVS.Name = "btn2PlayerVS";
            this.btn2PlayerVS.Size = new System.Drawing.Size(200, 54);
            this.btn2PlayerVS.TabIndex = 0;
            this.btn2PlayerVS.Text = "Player VS Player";
            this.btn2PlayerVS.UseVisualStyleBackColor = true;
            this.btn2PlayerVS.Click += new System.EventHandler(this.btn2PlayerVS_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 78F);
            this.lblTitle.Location = new System.Drawing.Point(216, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(387, 148);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Lurgit";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(32, 512);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(338, 17);
            this.lblCredits.TabIndex = 2;
            this.lblCredits.Text = "By Andrew Parkinson - c3128094 - INFT2012 - 2018";
            this.lblCredits.Click += new System.EventHandler(this.lblCredits_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(688, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn2PlayerVS);
            this.Controls.Add(this.btn2PlayerCPU);
            this.Controls.Add(this.btn1Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMenu";
            this.Text = "Lurgit - Main Menu";
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
    }
}

