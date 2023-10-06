namespace Coursework.Forms
{
    partial class frmBonusGame
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
            this.components = new System.ComponentModel.Container();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblUserPoints = new System.Windows.Forms.Label();
            this.lblCpuPoints = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.ForeColor = System.Drawing.Color.White;
            this.lblHighscore.Location = new System.Drawing.Point(987, 64);
            this.lblHighscore.MinimumSize = new System.Drawing.Size(10, 20);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(10, 31);
            this.lblHighscore.TabIndex = 47;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(661, 64);
            this.lblScore.MinimumSize = new System.Drawing.Size(10, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(10, 31);
            this.lblScore.TabIndex = 48;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 54);
            this.btnBack.TabIndex = 49;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblUserPoints
            // 
            this.lblUserPoints.AutoSize = true;
            this.lblUserPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblUserPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPoints.ForeColor = System.Drawing.Color.White;
            this.lblUserPoints.Location = new System.Drawing.Point(465, 164);
            this.lblUserPoints.Name = "lblUserPoints";
            this.lblUserPoints.Size = new System.Drawing.Size(44, 31);
            this.lblUserPoints.TabIndex = 50;
            this.lblUserPoints.Text = "00";
            // 
            // lblCpuPoints
            // 
            this.lblCpuPoints.AutoSize = true;
            this.lblCpuPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCpuPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuPoints.ForeColor = System.Drawing.Color.White;
            this.lblCpuPoints.Location = new System.Drawing.Point(848, 164);
            this.lblCpuPoints.Name = "lblCpuPoints";
            this.lblCpuPoints.Size = new System.Drawing.Size(44, 31);
            this.lblCpuPoints.TabIndex = 51;
            this.lblCpuPoints.Text = "00";
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(664, 405);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 52;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cpu.Location = new System.Drawing.Point(1102, 332);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(31, 171);
            this.cpu.TabIndex = 53;
            this.cpu.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.player.Location = new System.Drawing.Point(235, 332);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(31, 171);
            this.player.TabIndex = 55;
            this.player.TabStop = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(596, 361);
            this.lblEnd.MinimumSize = new System.Drawing.Size(10, 20);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(10, 25);
            this.lblEnd.TabIndex = 56;
            // 
            // btnReplay
            // 
            this.btnReplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.Location = new System.Drawing.Point(601, 519);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(163, 54);
            this.btnReplay.TabIndex = 57;
            this.btnReplay.Text = "Replay";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBonusGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.lblCpuPoints);
            this.Controls.Add(this.lblUserPoints);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblHighscore);
            this.Name = "frmBonusGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.lblUserPoints, 0);
            this.Controls.SetChildIndex(this.lblCpuPoints, 0);
            this.Controls.SetChildIndex(this.ball, 0);
            this.Controls.SetChildIndex(this.cpu, 0);
            this.Controls.SetChildIndex(this.player, 0);
            this.Controls.SetChildIndex(this.lblEnd, 0);
            this.Controls.SetChildIndex(this.btnReplay, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblUserPoints;
        private System.Windows.Forms.Label lblCpuPoints;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnReplay;
    }
}
