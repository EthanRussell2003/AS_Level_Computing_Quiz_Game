namespace Coursework.Forms
{
    partial class frmQuestionTextEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.picAnswer1Wrong = new System.Windows.Forms.PictureBox();
            this.picAnswer1Correct = new System.Windows.Forms.PictureBox();
            this.picAnswer2Wrong = new System.Windows.Forms.PictureBox();
            this.picAnswer3Wrong = new System.Windows.Forms.PictureBox();
            this.picAnswer4Wrong = new System.Windows.Forms.PictureBox();
            this.picAnswer4Correct = new System.Windows.Forms.PictureBox();
            this.picAnswer3Correct = new System.Windows.Forms.PictureBox();
            this.picAnswer2Correct = new System.Windows.Forms.PictureBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer4Wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer4Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(323, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "What is another name for a processor?\r\n(E.g. CPU, GPU, PSU)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(378, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "What is the full name for RAM?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(423, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "How many bits in a byte?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(388, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "What type of file is a .png file?\r\n (E.g. Video, Image, Text)";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(242, 566);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(171, 79);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer4.Location = new System.Drawing.Point(653, 489);
            this.txtAnswer4.MaxLength = 10;
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.Size = new System.Drawing.Size(246, 26);
            this.txtAnswer4.TabIndex = 15;
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer3.Location = new System.Drawing.Point(653, 416);
            this.txtAnswer3.MaxLength = 10;
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(246, 26);
            this.txtAnswer3.TabIndex = 14;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.Location = new System.Drawing.Point(653, 340);
            this.txtAnswer2.MaxLength = 26;
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(246, 26);
            this.txtAnswer2.TabIndex = 13;
            this.txtAnswer2.TextChanged += new System.EventHandler(this.txtAnswer2_TextChanged);
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(653, 261);
            this.txtAnswer1.MaxLength = 10;
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(246, 26);
            this.txtAnswer1.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 331);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 55);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picAnswer1Wrong
            // 
            this.picAnswer1Wrong.BackColor = System.Drawing.Color.Red;
            this.picAnswer1Wrong.Image = global::Coursework.Properties.Resources.RedX;
            this.picAnswer1Wrong.Location = new System.Drawing.Point(993, 261);
            this.picAnswer1Wrong.Name = "picAnswer1Wrong";
            this.picAnswer1Wrong.Size = new System.Drawing.Size(45, 45);
            this.picAnswer1Wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer1Wrong.TabIndex = 14;
            this.picAnswer1Wrong.TabStop = false;
            this.picAnswer1Wrong.Visible = false;
            // 
            // picAnswer1Correct
            // 
            this.picAnswer1Correct.BackColor = System.Drawing.Color.Lime;
            this.picAnswer1Correct.Image = global::Coursework.Properties.Resources.GreenTick2;
            this.picAnswer1Correct.Location = new System.Drawing.Point(993, 261);
            this.picAnswer1Correct.Name = "picAnswer1Correct";
            this.picAnswer1Correct.Size = new System.Drawing.Size(45, 45);
            this.picAnswer1Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer1Correct.TabIndex = 19;
            this.picAnswer1Correct.TabStop = false;
            this.picAnswer1Correct.Visible = false;
            // 
            // picAnswer2Wrong
            // 
            this.picAnswer2Wrong.BackColor = System.Drawing.Color.Red;
            this.picAnswer2Wrong.Image = global::Coursework.Properties.Resources.RedX;
            this.picAnswer2Wrong.Location = new System.Drawing.Point(993, 340);
            this.picAnswer2Wrong.Name = "picAnswer2Wrong";
            this.picAnswer2Wrong.Size = new System.Drawing.Size(45, 45);
            this.picAnswer2Wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer2Wrong.TabIndex = 20;
            this.picAnswer2Wrong.TabStop = false;
            this.picAnswer2Wrong.Visible = false;
            // 
            // picAnswer3Wrong
            // 
            this.picAnswer3Wrong.BackColor = System.Drawing.Color.Red;
            this.picAnswer3Wrong.Image = global::Coursework.Properties.Resources.RedX;
            this.picAnswer3Wrong.Location = new System.Drawing.Point(993, 416);
            this.picAnswer3Wrong.Name = "picAnswer3Wrong";
            this.picAnswer3Wrong.Size = new System.Drawing.Size(45, 45);
            this.picAnswer3Wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer3Wrong.TabIndex = 21;
            this.picAnswer3Wrong.TabStop = false;
            this.picAnswer3Wrong.Visible = false;
            // 
            // picAnswer4Wrong
            // 
            this.picAnswer4Wrong.BackColor = System.Drawing.Color.Red;
            this.picAnswer4Wrong.Image = global::Coursework.Properties.Resources.RedX;
            this.picAnswer4Wrong.Location = new System.Drawing.Point(993, 489);
            this.picAnswer4Wrong.Name = "picAnswer4Wrong";
            this.picAnswer4Wrong.Size = new System.Drawing.Size(45, 45);
            this.picAnswer4Wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer4Wrong.TabIndex = 22;
            this.picAnswer4Wrong.TabStop = false;
            this.picAnswer4Wrong.Visible = false;
            // 
            // picAnswer4Correct
            // 
            this.picAnswer4Correct.BackColor = System.Drawing.Color.Lime;
            this.picAnswer4Correct.Image = global::Coursework.Properties.Resources.GreenTick2;
            this.picAnswer4Correct.Location = new System.Drawing.Point(993, 489);
            this.picAnswer4Correct.Name = "picAnswer4Correct";
            this.picAnswer4Correct.Size = new System.Drawing.Size(45, 45);
            this.picAnswer4Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer4Correct.TabIndex = 23;
            this.picAnswer4Correct.TabStop = false;
            this.picAnswer4Correct.Visible = false;
            this.picAnswer4Correct.Click += new System.EventHandler(this.picAnswer4Correct_Click);
            // 
            // picAnswer3Correct
            // 
            this.picAnswer3Correct.BackColor = System.Drawing.Color.Lime;
            this.picAnswer3Correct.Image = global::Coursework.Properties.Resources.GreenTick2;
            this.picAnswer3Correct.Location = new System.Drawing.Point(993, 416);
            this.picAnswer3Correct.Name = "picAnswer3Correct";
            this.picAnswer3Correct.Size = new System.Drawing.Size(45, 45);
            this.picAnswer3Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer3Correct.TabIndex = 24;
            this.picAnswer3Correct.TabStop = false;
            this.picAnswer3Correct.Visible = false;
            // 
            // picAnswer2Correct
            // 
            this.picAnswer2Correct.BackColor = System.Drawing.Color.Lime;
            this.picAnswer2Correct.Image = global::Coursework.Properties.Resources.GreenTick2;
            this.picAnswer2Correct.Location = new System.Drawing.Point(993, 340);
            this.picAnswer2Correct.Name = "picAnswer2Correct";
            this.picAnswer2Correct.Size = new System.Drawing.Size(45, 45);
            this.picAnswer2Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer2Correct.TabIndex = 25;
            this.picAnswer2Correct.TabStop = false;
            this.picAnswer2Correct.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(944, 566);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(171, 79);
            this.btnContinue.TabIndex = 35;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.ForeColor = System.Drawing.Color.White;
            this.lblDirections.Location = new System.Drawing.Point(185, 164);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(474, 25);
            this.lblDirections.TabIndex = 36;
            this.lblDirections.Text = "Type in the correct answer to each question";
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
            this.lblScore.TabIndex = 37;
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
            this.lblHighscore.TabIndex = 38;
            // 
            // picHelp
            // 
            this.picHelp.Image = global::Coursework.Properties.Resources.EasyTextBoxHelp;
            this.picHelp.Location = new System.Drawing.Point(185, -9);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(1002, 695);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 39;
            this.picHelp.TabStop = false;
            this.picHelp.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(12, 213);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(152, 55);
            this.btnHelp.TabIndex = 40;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmQuestionTextEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.picAnswer2Correct);
            this.Controls.Add(this.picAnswer3Correct);
            this.Controls.Add(this.picAnswer4Correct);
            this.Controls.Add(this.picAnswer4Wrong);
            this.Controls.Add(this.picAnswer3Wrong);
            this.Controls.Add(this.picAnswer2Wrong);
            this.Controls.Add(this.picAnswer1Correct);
            this.Controls.Add(this.picAnswer1Wrong);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHelp);
            this.Name = "frmQuestionTextEntry";
            this.Text = "Text box";
            this.Controls.SetChildIndex(this.picHelp, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.txtAnswer4, 0);
            this.Controls.SetChildIndex(this.txtAnswer3, 0);
            this.Controls.SetChildIndex(this.txtAnswer2, 0);
            this.Controls.SetChildIndex(this.txtAnswer1, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.picAnswer1Wrong, 0);
            this.Controls.SetChildIndex(this.picAnswer1Correct, 0);
            this.Controls.SetChildIndex(this.picAnswer2Wrong, 0);
            this.Controls.SetChildIndex(this.picAnswer3Wrong, 0);
            this.Controls.SetChildIndex(this.picAnswer4Wrong, 0);
            this.Controls.SetChildIndex(this.picAnswer4Correct, 0);
            this.Controls.SetChildIndex(this.picAnswer3Correct, 0);
            this.Controls.SetChildIndex(this.picAnswer2Correct, 0);
            this.Controls.SetChildIndex(this.btnContinue, 0);
            this.Controls.SetChildIndex(this.lblDirections, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer4Wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer4Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picAnswer1Wrong;
        private System.Windows.Forms.PictureBox picAnswer1Correct;
        private System.Windows.Forms.PictureBox picAnswer2Wrong;
        private System.Windows.Forms.PictureBox picAnswer3Wrong;
        private System.Windows.Forms.PictureBox picAnswer4Wrong;
        private System.Windows.Forms.PictureBox picAnswer4Correct;
        private System.Windows.Forms.PictureBox picAnswer3Correct;
        private System.Windows.Forms.PictureBox picAnswer2Correct;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Button btnHelp;
    }
}
