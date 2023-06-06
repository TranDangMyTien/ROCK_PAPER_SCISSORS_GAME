namespace ROCK_PAPER_SCISSORS_GAME
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.CPU_pic = new System.Windows.Forms.PictureBox();
            this.PLAYER_pic = new System.Windows.Forms.PictureBox();
            this.lbCPUchoice = new System.Windows.Forms.Label();
            this.lbPLAYERchoice = new System.Windows.Forms.Label();
            this.lbPLAYERresult = new System.Windows.Forms.Label();
            this.lbCPUresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.Gold;
            this.btnRock.Location = new System.Drawing.Point(261, 546);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(157, 81);
            this.btnRock.TabIndex = 0;
            this.btnRock.Tag = "R";
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.button_click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.Aqua;
            this.btnPaper.Location = new System.Drawing.Point(508, 546);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(157, 81);
            this.btnPaper.TabIndex = 0;
            this.btnPaper.Tag = "P";
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.button_click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.Orchid;
            this.btnScissors.Location = new System.Drawing.Point(761, 546);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(157, 81);
            this.btnScissors.TabIndex = 0;
            this.btnScissors.Tag = "S";
            this.btnScissors.Text = "Scissors ";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.button_click);
            // 
            // CPU_pic
            // 
            this.CPU_pic.Location = new System.Drawing.Point(497, 98);
            this.CPU_pic.Name = "CPU_pic";
            this.CPU_pic.Size = new System.Drawing.Size(180, 155);
            this.CPU_pic.TabIndex = 1;
            this.CPU_pic.TabStop = false;
            // 
            // PLAYER_pic
            // 
            this.PLAYER_pic.Location = new System.Drawing.Point(497, 292);
            this.PLAYER_pic.Name = "PLAYER_pic";
            this.PLAYER_pic.Size = new System.Drawing.Size(180, 155);
            this.PLAYER_pic.TabIndex = 1;
            this.PLAYER_pic.TabStop = false;
            // 
            // lbCPUchoice
            // 
            this.lbCPUchoice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCPUchoice.Location = new System.Drawing.Point(427, 21);
            this.lbCPUchoice.Name = "lbCPUchoice";
            this.lbCPUchoice.Size = new System.Drawing.Size(376, 64);
            this.lbCPUchoice.TabIndex = 2;
            this.lbCPUchoice.Text = "Computer Choice:";
            this.lbCPUchoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPLAYERchoice
            // 
            this.lbPLAYERchoice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPLAYERchoice.Location = new System.Drawing.Point(427, 450);
            this.lbPLAYERchoice.Name = "lbPLAYERchoice";
            this.lbPLAYERchoice.Size = new System.Drawing.Size(366, 64);
            this.lbPLAYERchoice.TabIndex = 2;
            this.lbPLAYERchoice.Text = "Player Choice:";
            this.lbPLAYERchoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPLAYERresult
            // 
            this.lbPLAYERresult.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPLAYERresult.Location = new System.Drawing.Point(53, 243);
            this.lbPLAYERresult.Name = "lbPLAYERresult";
            this.lbPLAYERresult.Size = new System.Drawing.Size(271, 64);
            this.lbPLAYERresult.TabIndex = 2;
            this.lbPLAYERresult.Text = "Player Result: ";
            this.lbPLAYERresult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCPUresult
            // 
            this.lbCPUresult.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCPUresult.Location = new System.Drawing.Point(761, 243);
            this.lbCPUresult.Name = "lbCPUresult";
            this.lbCPUresult.Size = new System.Drawing.Size(277, 64);
            this.lbCPUresult.TabIndex = 2;
            this.lbCPUresult.Text = "Computer Result:  ";
            this.lbCPUresult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1109, 684);
            this.Controls.Add(this.lbCPUresult);
            this.Controls.Add(this.lbPLAYERresult);
            this.Controls.Add(this.lbPLAYERchoice);
            this.Controls.Add(this.lbCPUchoice);
            this.Controls.Add(this.PLAYER_pic);
            this.Controls.Add(this.CPU_pic);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock paper scissors game";
            ((System.ComponentModel.ISupportInitialize)(this.CPU_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private PictureBox CPU_pic;
        private PictureBox PLAYER_pic;
        private Label lbCPUchoice;
        private Label lbPLAYERchoice;
        private Label lbPLAYERresult;
        private Label lbCPUresult;
    }
}