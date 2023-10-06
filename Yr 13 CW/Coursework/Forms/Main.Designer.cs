namespace Coursework.Forms
{
    partial class frmMain
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.lblEasy = new System.Windows.Forms.Label();
            this.lblHard = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.btnFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
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
            this.lblScore.TabIndex = 10;
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
            this.lblHighscore.TabIndex = 27;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(563, 480);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(232, 100);
            this.btnAdmin.TabIndex = 28;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnHard
            // 
            this.btnHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(790, 316);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(232, 100);
            this.btnHard.TabIndex = 29;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(335, 316);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(232, 100);
            this.btnEasy.TabIndex = 30;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // lblEasy
            // 
            this.lblEasy.AutoSize = true;
            this.lblEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEasy.ForeColor = System.Drawing.Color.White;
            this.lblEasy.Location = new System.Drawing.Point(266, 260);
            this.lblEasy.Name = "lblEasy";
            this.lblEasy.Size = new System.Drawing.Size(367, 29);
            this.lblEasy.TabIndex = 31;
            this.lblEasy.Text = "Easy questions will award 1 point";
            // 
            // lblHard
            // 
            this.lblHard.AutoSize = true;
            this.lblHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHard.ForeColor = System.Drawing.Color.White;
            this.lblHard.Location = new System.Drawing.Point(717, 260);
            this.lblHard.Name = "lblHard";
            this.lblHard.Size = new System.Drawing.Size(379, 29);
            this.lblHard.TabIndex = 32;
            this.lblHard.Text = "Hard questions will award 2 points";
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(12, 215);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(152, 54);
            this.btnHelp.TabIndex = 50;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // picHelp
            // 
            this.picHelp.Image = global::Coursework.Properties.Resources.MainHelp;
            this.picHelp.Location = new System.Drawing.Point(170, 3);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(1019, 682);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 51;
            this.picHelp.TabStop = false;
            this.picHelp.Visible = false;
            // 
            // btnFeedback
            // 
            this.btnFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.Location = new System.Drawing.Point(12, 332);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(152, 54);
            this.btnFeedback.TabIndex = 52;
            this.btnFeedback.Text = "Give Feedback Here";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblHard);
            this.Controls.Add(this.lblEasy);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picHelp);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Controls.SetChildIndex(this.picHelp, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.btnAdmin, 0);
            this.Controls.SetChildIndex(this.btnHard, 0);
            this.Controls.SetChildIndex(this.btnEasy, 0);
            this.Controls.SetChildIndex(this.lblEasy, 0);
            this.Controls.SetChildIndex(this.lblHard, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.btnFeedback, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Label lblEasy;
        private System.Windows.Forms.Label lblHard;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Button btnFeedback;
    }
}
