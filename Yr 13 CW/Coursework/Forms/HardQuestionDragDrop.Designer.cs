namespace Coursework.Forms
{
    partial class frmHardQuestionDragDrop
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
            this.picRingAdvantage = new System.Windows.Forms.PictureBox();
            this.picBus = new System.Windows.Forms.PictureBox();
            this.picStar = new System.Windows.Forms.PictureBox();
            this.picRing = new System.Windows.Forms.PictureBox();
            this.picStarAdvantage = new System.Windows.Forms.PictureBox();
            this.picBusAdvantage = new System.Windows.Forms.PictureBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.picAnswer3 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.picAnswer2 = new System.Windows.Forms.PictureBox();
            this.picAnswer1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.picAnswer1Correct = new System.Windows.Forms.PictureBox();
            this.picAnswer2Correct = new System.Windows.Forms.PictureBox();
            this.picAnswer3Correct = new System.Windows.Forms.PictureBox();
            this.picAnswer2Wrong = new System.Windows.Forms.PictureBox();
            this.picAnswer1Wrong = new System.Windows.Forms.PictureBox();
            this.picAnswer3Wrong = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.picHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRingAdvantage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStarAdvantage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBusAdvantage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // picRingAdvantage
            // 
            this.picRingAdvantage.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picRingAdvantage.Image = global::Coursework.Properties.Resources.RingTopologyAdvantage;
            this.picRingAdvantage.Location = new System.Drawing.Point(227, 474);
            this.picRingAdvantage.Name = "picRingAdvantage";
            this.picRingAdvantage.Size = new System.Drawing.Size(199, 28);
            this.picRingAdvantage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRingAdvantage.TabIndex = 4;
            this.picRingAdvantage.TabStop = false;
            this.picRingAdvantage.Tag = "Ring";
            this.picRingAdvantage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picRingAdvantage_MouseDown);
            // 
            // picBus
            // 
            this.picBus.Image = global::Coursework.Properties.Resources.BusTopology;
            this.picBus.Location = new System.Drawing.Point(248, 213);
            this.picBus.Name = "picBus";
            this.picBus.Size = new System.Drawing.Size(160, 160);
            this.picBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBus.TabIndex = 5;
            this.picBus.TabStop = false;
            this.picBus.Tag = "Bus";
            this.picBus.DragDrop += new System.Windows.Forms.DragEventHandler(this.picBus_DragDrop);
            this.picBus.DragEnter += new System.Windows.Forms.DragEventHandler(this.picBus_DragEnter);
            // 
            // picStar
            // 
            this.picStar.Image = global::Coursework.Properties.Resources.StarTopology;
            this.picStar.Location = new System.Drawing.Point(948, 213);
            this.picStar.Name = "picStar";
            this.picStar.Size = new System.Drawing.Size(160, 160);
            this.picStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar.TabIndex = 6;
            this.picStar.TabStop = false;
            this.picStar.Tag = "Star";
            this.picStar.DragDrop += new System.Windows.Forms.DragEventHandler(this.picStar_DragDrop);
            this.picStar.DragEnter += new System.Windows.Forms.DragEventHandler(this.picStar_DragEnter);
            // 
            // picRing
            // 
            this.picRing.Image = global::Coursework.Properties.Resources.RingTopology;
            this.picRing.Location = new System.Drawing.Point(598, 213);
            this.picRing.Name = "picRing";
            this.picRing.Size = new System.Drawing.Size(160, 160);
            this.picRing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRing.TabIndex = 7;
            this.picRing.TabStop = false;
            this.picRing.Tag = "Ring";
            this.picRing.DragDrop += new System.Windows.Forms.DragEventHandler(this.picRing_DragDrop);
            this.picRing.DragEnter += new System.Windows.Forms.DragEventHandler(this.picRing_DragEnter);
            // 
            // picStarAdvantage
            // 
            this.picStarAdvantage.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picStarAdvantage.Image = global::Coursework.Properties.Resources.StarTopologyAdvantage;
            this.picStarAdvantage.Location = new System.Drawing.Point(928, 475);
            this.picStarAdvantage.Name = "picStarAdvantage";
            this.picStarAdvantage.Size = new System.Drawing.Size(199, 28);
            this.picStarAdvantage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStarAdvantage.TabIndex = 8;
            this.picStarAdvantage.TabStop = false;
            this.picStarAdvantage.Tag = "Star";
            this.picStarAdvantage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picStarAdvantage_MouseDown);
            // 
            // picBusAdvantage
            // 
            this.picBusAdvantage.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picBusAdvantage.Image = global::Coursework.Properties.Resources.BusTopologyAdvantage;
            this.picBusAdvantage.Location = new System.Drawing.Point(577, 474);
            this.picBusAdvantage.Name = "picBusAdvantage";
            this.picBusAdvantage.Size = new System.Drawing.Size(199, 29);
            this.picBusAdvantage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBusAdvantage.TabIndex = 9;
            this.picBusAdvantage.TabStop = false;
            this.picBusAdvantage.Tag = "Bus";
            this.picBusAdvantage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBusAdvantage_MouseDown);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.ForeColor = System.Drawing.Color.White;
            this.lblDirections.Location = new System.Drawing.Point(185, 164);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDirections.Size = new System.Drawing.Size(544, 25);
            this.lblDirections.TabIndex = 23;
            this.lblDirections.Text = "Drag and drop the correct image to the correct box";
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
            this.lblScore.TabIndex = 26;
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
            // picAnswer3
            // 
            this.picAnswer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.picAnswer3.Location = new System.Drawing.Point(928, 379);
            this.picAnswer3.Name = "picAnswer3";
            this.picAnswer3.Size = new System.Drawing.Size(199, 28);
            this.picAnswer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer3.TabIndex = 31;
            this.picAnswer3.TabStop = false;
            this.picAnswer3.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(242, 566);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(171, 79);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(944, 566);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(171, 79);
            this.btnContinue.TabIndex = 37;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(593, 568);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(171, 79);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picAnswer2
            // 
            this.picAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.picAnswer2.Location = new System.Drawing.Point(577, 379);
            this.picAnswer2.Name = "picAnswer2";
            this.picAnswer2.Size = new System.Drawing.Size(199, 28);
            this.picAnswer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer2.TabIndex = 39;
            this.picAnswer2.TabStop = false;
            this.picAnswer2.Visible = false;
            // 
            // picAnswer1
            // 
            this.picAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.picAnswer1.Location = new System.Drawing.Point(227, 379);
            this.picAnswer1.Name = "picAnswer1";
            this.picAnswer1.Size = new System.Drawing.Size(199, 28);
            this.picAnswer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer1.TabIndex = 40;
            this.picAnswer1.TabStop = false;
            this.picAnswer1.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 54);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picAnswer1Correct
            // 
            this.picAnswer1Correct.BackColor = System.Drawing.Color.Lime;
            this.picAnswer1Correct.Image = global::Coursework.Properties.Resources.GreenTick2;
            this.picAnswer1Correct.Location = new System.Drawing.Point(307, 413);
            this.picAnswer1Correct.Name = "picAnswer1Correct";
            this.picAnswer1Correct.Size = new System.Drawing.Size(40, 40);
            this.picAnswer1Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer1Correct.TabIndex = 49;
            this.picAnswer1Correct.TabStop = false;
            this.picAnswer1Correct.Visible = false;
            // 
            // picAnswer2Correct
            // 
            this.picAnswer2Correct.BackColor = System.Drawing.Color.Lime;
            this.picAnswer2Correct.Image = global::Coursework.Properties.Resources.GreenTick2;
            this.picAnswer2Correct.Location = new System.Drawing.Point(657, 413);
            this.picAnswer2Correct.Name = "picAnswer2Correct";
            this.picAnswer2Correct.Size = new System.Drawing.Size(40, 40);
            this.picAnswer2Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer2Correct.TabIndex = 50;
            this.picAnswer2Correct.TabStop = false;
            this.picAnswer2Correct.Visible = false;
            // 
            // picAnswer3Correct
            // 
            this.picAnswer3Correct.BackColor = System.Drawing.Color.Lime;
            this.picAnswer3Correct.Image = global::Coursework.Properties.Resources.GreenTick2;
            this.picAnswer3Correct.Location = new System.Drawing.Point(1008, 413);
            this.picAnswer3Correct.Name = "picAnswer3Correct";
            this.picAnswer3Correct.Size = new System.Drawing.Size(40, 40);
            this.picAnswer3Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer3Correct.TabIndex = 51;
            this.picAnswer3Correct.TabStop = false;
            this.picAnswer3Correct.Visible = false;
            // 
            // picAnswer2Wrong
            // 
            this.picAnswer2Wrong.BackColor = System.Drawing.Color.Red;
            this.picAnswer2Wrong.Image = global::Coursework.Properties.Resources.RedX;
            this.picAnswer2Wrong.Location = new System.Drawing.Point(657, 413);
            this.picAnswer2Wrong.Name = "picAnswer2Wrong";
            this.picAnswer2Wrong.Size = new System.Drawing.Size(40, 40);
            this.picAnswer2Wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer2Wrong.TabIndex = 52;
            this.picAnswer2Wrong.TabStop = false;
            this.picAnswer2Wrong.Visible = false;
            // 
            // picAnswer1Wrong
            // 
            this.picAnswer1Wrong.BackColor = System.Drawing.Color.Red;
            this.picAnswer1Wrong.Image = global::Coursework.Properties.Resources.RedX;
            this.picAnswer1Wrong.Location = new System.Drawing.Point(307, 413);
            this.picAnswer1Wrong.Name = "picAnswer1Wrong";
            this.picAnswer1Wrong.Size = new System.Drawing.Size(40, 40);
            this.picAnswer1Wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer1Wrong.TabIndex = 53;
            this.picAnswer1Wrong.TabStop = false;
            this.picAnswer1Wrong.Visible = false;
            // 
            // picAnswer3Wrong
            // 
            this.picAnswer3Wrong.BackColor = System.Drawing.Color.Red;
            this.picAnswer3Wrong.Image = global::Coursework.Properties.Resources.RedX;
            this.picAnswer3Wrong.Location = new System.Drawing.Point(1008, 413);
            this.picAnswer3Wrong.Name = "picAnswer3Wrong";
            this.picAnswer3Wrong.Size = new System.Drawing.Size(40, 40);
            this.picAnswer3Wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer3Wrong.TabIndex = 54;
            this.picAnswer3Wrong.TabStop = false;
            this.picAnswer3Wrong.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(12, 214);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(152, 55);
            this.btnHelp.TabIndex = 55;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // picHelp
            // 
            this.picHelp.Image = global::Coursework.Properties.Resources.HardDragDropHelp;
            this.picHelp.Location = new System.Drawing.Point(167, -3);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(1019, 686);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 56;
            this.picHelp.TabStop = false;
            this.picHelp.Visible = false;
            // 
            // frmHardQuestionDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.picAnswer3Wrong);
            this.Controls.Add(this.picAnswer1Wrong);
            this.Controls.Add(this.picAnswer2Wrong);
            this.Controls.Add(this.picAnswer3Correct);
            this.Controls.Add(this.picAnswer2Correct);
            this.Controls.Add(this.picAnswer1Correct);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picAnswer1);
            this.Controls.Add(this.picAnswer2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.picAnswer3);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.picBusAdvantage);
            this.Controls.Add(this.picStarAdvantage);
            this.Controls.Add(this.picRing);
            this.Controls.Add(this.picStar);
            this.Controls.Add(this.picBus);
            this.Controls.Add(this.picRingAdvantage);
            this.Name = "frmHardQuestionDragDrop";
            this.Text = "Hard drag and drop";
            this.Controls.SetChildIndex(this.picRingAdvantage, 0);
            this.Controls.SetChildIndex(this.picBus, 0);
            this.Controls.SetChildIndex(this.picStar, 0);
            this.Controls.SetChildIndex(this.picRing, 0);
            this.Controls.SetChildIndex(this.picStarAdvantage, 0);
            this.Controls.SetChildIndex(this.picBusAdvantage, 0);
            this.Controls.SetChildIndex(this.lblDirections, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.picAnswer3, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.btnContinue, 0);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.picAnswer2, 0);
            this.Controls.SetChildIndex(this.picAnswer1, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.picAnswer1Correct, 0);
            this.Controls.SetChildIndex(this.picAnswer2Correct, 0);
            this.Controls.SetChildIndex(this.picAnswer3Correct, 0);
            this.Controls.SetChildIndex(this.picAnswer2Wrong, 0);
            this.Controls.SetChildIndex(this.picAnswer1Wrong, 0);
            this.Controls.SetChildIndex(this.picAnswer3Wrong, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.picHelp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picRingAdvantage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStarAdvantage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBusAdvantage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRingAdvantage;
        private System.Windows.Forms.PictureBox picBus;
        private System.Windows.Forms.PictureBox picStar;
        private System.Windows.Forms.PictureBox picRing;
        private System.Windows.Forms.PictureBox picStarAdvantage;
        private System.Windows.Forms.PictureBox picBusAdvantage;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.PictureBox picAnswer3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picAnswer2;
        private System.Windows.Forms.PictureBox picAnswer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picAnswer1Correct;
        private System.Windows.Forms.PictureBox picAnswer2Correct;
        private System.Windows.Forms.PictureBox picAnswer3Correct;
        private System.Windows.Forms.PictureBox picAnswer2Wrong;
        private System.Windows.Forms.PictureBox picAnswer1Wrong;
        private System.Windows.Forms.PictureBox picAnswer3Wrong;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox picHelp;
    }
}
