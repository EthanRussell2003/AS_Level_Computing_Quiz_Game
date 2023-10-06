namespace Coursework.Forms
{
    partial class frmQuestionDragDrop
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
            this.picGPU = new System.Windows.Forms.PictureBox();
            this.picAnswer3 = new System.Windows.Forms.PictureBox();
            this.picAnswer2 = new System.Windows.Forms.PictureBox();
            this.picAnswer1 = new System.Windows.Forms.PictureBox();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.picPSU = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPSU = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblDirections = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.picAnswer1Wrong = new System.Windows.Forms.PictureBox();
            this.picAnswer2Correct = new System.Windows.Forms.PictureBox();
            this.picAnswer3Correct = new System.Windows.Forms.PictureBox();
            this.picAnswer2Wrong = new System.Windows.Forms.PictureBox();
            this.picAnswer3Wrong = new System.Windows.Forms.PictureBox();
            this.picAnswer1Correct = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.picHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPSU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // picGPU
            // 
            this.picGPU.BackColor = System.Drawing.Color.Transparent;
            this.picGPU.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picGPU.Image = global::Coursework.Properties.Resources.GPU_TEST;
            this.picGPU.Location = new System.Drawing.Point(586, 383);
            this.picGPU.Name = "picGPU";
            this.picGPU.Size = new System.Drawing.Size(160, 160);
            this.picGPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGPU.TabIndex = 5;
            this.picGPU.TabStop = false;
            this.picGPU.Tag = "GPU";
            this.picGPU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picGPU_MouseDown);
            // 
            // picAnswer3
            // 
            this.picAnswer3.BackColor = System.Drawing.SystemColors.Control;
            this.picAnswer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAnswer3.Location = new System.Drawing.Point(916, 201);
            this.picAnswer3.Name = "picAnswer3";
            this.picAnswer3.Size = new System.Drawing.Size(160, 160);
            this.picAnswer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer3.TabIndex = 6;
            this.picAnswer3.TabStop = false;
            this.picAnswer3.Tag = "PSU";
            this.picAnswer3.DragDrop += new System.Windows.Forms.DragEventHandler(this.picAnswer3_DragDrop);
            this.picAnswer3.DragEnter += new System.Windows.Forms.DragEventHandler(this.picAnswer3_DragEnter);
            // 
            // picAnswer2
            // 
            this.picAnswer2.BackColor = System.Drawing.SystemColors.Control;
            this.picAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAnswer2.Location = new System.Drawing.Point(586, 201);
            this.picAnswer2.Name = "picAnswer2";
            this.picAnswer2.Size = new System.Drawing.Size(160, 160);
            this.picAnswer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer2.TabIndex = 7;
            this.picAnswer2.TabStop = false;
            this.picAnswer2.Tag = "CPU";
            this.picAnswer2.DragDrop += new System.Windows.Forms.DragEventHandler(this.picAnswer2_DragDrop);
            this.picAnswer2.DragEnter += new System.Windows.Forms.DragEventHandler(this.picAnswer2_DragEnter);
            // 
            // picAnswer1
            // 
            this.picAnswer1.BackColor = System.Drawing.SystemColors.Control;
            this.picAnswer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAnswer1.Location = new System.Drawing.Point(242, 201);
            this.picAnswer1.Name = "picAnswer1";
            this.picAnswer1.Size = new System.Drawing.Size(160, 160);
            this.picAnswer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer1.TabIndex = 8;
            this.picAnswer1.TabStop = false;
            this.picAnswer1.Tag = "GPU";
            this.picAnswer1.DragDrop += new System.Windows.Forms.DragEventHandler(this.picAnswer1_DragDrop);
            this.picAnswer1.DragEnter += new System.Windows.Forms.DragEventHandler(this.picAnswer1_DragEnter);
            // 
            // picCPU
            // 
            this.picCPU.BackColor = System.Drawing.Color.Transparent;
            this.picCPU.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picCPU.Image = global::Coursework.Properties.Resources.CPU_TEST1;
            this.picCPU.Location = new System.Drawing.Point(242, 383);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(160, 160);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPU.TabIndex = 9;
            this.picCPU.TabStop = false;
            this.picCPU.Tag = "CPU";
            this.picCPU.Click += new System.EventHandler(this.picCPU_Click);
            this.picCPU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCPU_MouseDown);
            // 
            // picPSU
            // 
            this.picPSU.BackColor = System.Drawing.Color.Transparent;
            this.picPSU.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picPSU.Image = global::Coursework.Properties.Resources.PSU_TEST;
            this.picPSU.Location = new System.Drawing.Point(916, 383);
            this.picPSU.Name = "picPSU";
            this.picPSU.Size = new System.Drawing.Size(160, 160);
            this.picPSU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPSU.TabIndex = 10;
            this.picPSU.TabStop = false;
            this.picPSU.Tag = "PSU";
            this.picPSU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPSU_MouseDown);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 54);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPSU
            // 
            this.lblPSU.AutoSize = true;
            this.lblPSU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPSU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSU.ForeColor = System.Drawing.Color.White;
            this.lblPSU.Location = new System.Drawing.Point(1098, 201);
            this.lblPSU.Name = "lblPSU";
            this.lblPSU.Size = new System.Drawing.Size(44, 22);
            this.lblPSU.TabIndex = 12;
            this.lblPSU.Text = "PSU";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.White;
            this.lblCPU.Location = new System.Drawing.Point(768, 201);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(44, 22);
            this.lblCPU.TabIndex = 13;
            this.lblCPU.Text = "CPU";
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblGPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU.ForeColor = System.Drawing.Color.White;
            this.lblGPU.Location = new System.Drawing.Point(424, 201);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(46, 22);
            this.lblGPU.TabIndex = 14;
            this.lblGPU.Text = "GPU";
            // 
            // btnContinue
            // 
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(910, 566);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(171, 79);
            this.btnContinue.TabIndex = 21;
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
            this.lblDirections.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDirections.Size = new System.Drawing.Size(544, 25);
            this.lblDirections.TabIndex = 22;
            this.lblDirections.Text = "Drag and drop the correct image to the correct box";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(580, 566);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(171, 79);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(236, 566);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(171, 79);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.lblScore.TabIndex = 25;
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
            this.lblHighscore.TabIndex = 26;
            // 
            // picAnswer1Wrong
            // 
            this.picAnswer1Wrong.BackColor = System.Drawing.Color.Red;
            this.picAnswer1Wrong.Image = global::Coursework.Properties.Resources.RedX;
            this.picAnswer1Wrong.InitialImage = global::Coursework.Properties.Resources.RedX;
            this.picAnswer1Wrong.Location = new System.Drawing.Point(424, 244);
            this.picAnswer1Wrong.Name = "picAnswer1Wrong";
            this.picAnswer1Wrong.Size = new System.Drawing.Size(40, 40);
            this.picAnswer1Wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer1Wrong.TabIndex = 54;
            this.picAnswer1Wrong.TabStop = false;
            this.picAnswer1Wrong.Visible = false;
            this.picAnswer1Wrong.Click += new System.EventHandler(this.picAnswer1Wrong_Click);
            // 
            // picAnswer2Correct
            // 
            this.picAnswer2Correct.BackColor = System.Drawing.Color.Lime;
            this.picAnswer2Correct.Image = global::Coursework.Properties.Resources.GreenTick2;
            this.picAnswer2Correct.Location = new System.Drawing.Point(768, 244);
            this.picAnswer2Correct.Name = "picAnswer2Correct";
            this.picAnswer2Correct.Size = new System.Drawing.Size(40, 40);
            this.picAnswer2Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer2Correct.TabIndex = 56;
            this.picAnswer2Correct.TabStop = false;
            this.picAnswer2Correct.Visible = false;
            // 
            // picAnswer3Correct
            // 
            this.picAnswer3Correct.BackColor = System.Drawing.Color.Lime;
            this.picAnswer3Correct.Image = global::Coursework.Properties.Resources.GreenTick2;
            this.picAnswer3Correct.Location = new System.Drawing.Point(1098, 244);
            this.picAnswer3Correct.Name = "picAnswer3Correct";
            this.picAnswer3Correct.Size = new System.Drawing.Size(40, 40);
            this.picAnswer3Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer3Correct.TabIndex = 57;
            this.picAnswer3Correct.TabStop = false;
            this.picAnswer3Correct.Visible = false;
            // 
            // picAnswer2Wrong
            // 
            this.picAnswer2Wrong.BackColor = System.Drawing.Color.Red;
            this.picAnswer2Wrong.Image = global::Coursework.Properties.Resources.RedX;
            this.picAnswer2Wrong.Location = new System.Drawing.Point(768, 244);
            this.picAnswer2Wrong.Name = "picAnswer2Wrong";
            this.picAnswer2Wrong.Size = new System.Drawing.Size(40, 40);
            this.picAnswer2Wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer2Wrong.TabIndex = 58;
            this.picAnswer2Wrong.TabStop = false;
            this.picAnswer2Wrong.Visible = false;
            // 
            // picAnswer3Wrong
            // 
            this.picAnswer3Wrong.BackColor = System.Drawing.Color.Red;
            this.picAnswer3Wrong.Image = global::Coursework.Properties.Resources.RedX;
            this.picAnswer3Wrong.Location = new System.Drawing.Point(1098, 244);
            this.picAnswer3Wrong.Name = "picAnswer3Wrong";
            this.picAnswer3Wrong.Size = new System.Drawing.Size(40, 40);
            this.picAnswer3Wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer3Wrong.TabIndex = 59;
            this.picAnswer3Wrong.TabStop = false;
            this.picAnswer3Wrong.Visible = false;
            // 
            // picAnswer1Correct
            // 
            this.picAnswer1Correct.BackColor = System.Drawing.Color.Lime;
            this.picAnswer1Correct.Image = global::Coursework.Properties.Resources.GreenTick2;
            this.picAnswer1Correct.Location = new System.Drawing.Point(424, 244);
            this.picAnswer1Correct.Name = "picAnswer1Correct";
            this.picAnswer1Correct.Size = new System.Drawing.Size(40, 40);
            this.picAnswer1Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer1Correct.TabIndex = 60;
            this.picAnswer1Correct.TabStop = false;
            this.picAnswer1Correct.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(12, 215);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(152, 54);
            this.btnHelp.TabIndex = 61;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // picHelp
            // 
            this.picHelp.Image = global::Coursework.Properties.Resources.EasyDragDropHelp;
            this.picHelp.Location = new System.Drawing.Point(176, 5);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(1012, 678);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 62;
            this.picHelp.TabStop = false;
            this.picHelp.Visible = false;
            this.picHelp.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmQuestionDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.BackgroundImage = global::Coursework.Properties.Resources.Transparent_background;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.picAnswer1Correct);
            this.Controls.Add(this.picAnswer3Wrong);
            this.Controls.Add(this.picAnswer2Wrong);
            this.Controls.Add(this.picAnswer3Correct);
            this.Controls.Add(this.picAnswer2Correct);
            this.Controls.Add(this.picAnswer1Wrong);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblPSU);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picPSU);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.picAnswer1);
            this.Controls.Add(this.picAnswer2);
            this.Controls.Add(this.picAnswer3);
            this.Controls.Add(this.picGPU);
            this.Controls.Add(this.picHelp);
            this.Name = "frmQuestionDragDrop";
            this.Text = "Drag and drop";
            this.Load += new System.EventHandler(this.frmQuestionDragDrop_Load_1);
            this.Controls.SetChildIndex(this.picHelp, 0);
            this.Controls.SetChildIndex(this.picGPU, 0);
            this.Controls.SetChildIndex(this.picAnswer3, 0);
            this.Controls.SetChildIndex(this.picAnswer2, 0);
            this.Controls.SetChildIndex(this.picAnswer1, 0);
            this.Controls.SetChildIndex(this.picCPU, 0);
            this.Controls.SetChildIndex(this.picPSU, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.lblPSU, 0);
            this.Controls.SetChildIndex(this.lblCPU, 0);
            this.Controls.SetChildIndex(this.lblGPU, 0);
            this.Controls.SetChildIndex(this.btnContinue, 0);
            this.Controls.SetChildIndex(this.lblDirections, 0);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.picAnswer1Wrong, 0);
            this.Controls.SetChildIndex(this.picAnswer2Correct, 0);
            this.Controls.SetChildIndex(this.picAnswer3Correct, 0);
            this.Controls.SetChildIndex(this.picAnswer2Wrong, 0);
            this.Controls.SetChildIndex(this.picAnswer3Wrong, 0);
            this.Controls.SetChildIndex(this.picAnswer1Correct, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picGPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPSU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer2Wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer3Wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer1Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGPU;
        private System.Windows.Forms.PictureBox picAnswer3;
        private System.Windows.Forms.PictureBox picAnswer2;
        private System.Windows.Forms.PictureBox picAnswer1;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.PictureBox picPSU;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPSU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.PictureBox picAnswer1Wrong;
        private System.Windows.Forms.PictureBox picAnswer2Correct;
        private System.Windows.Forms.PictureBox picAnswer3Correct;
        private System.Windows.Forms.PictureBox picAnswer2Wrong;
        private System.Windows.Forms.PictureBox picAnswer3Wrong;
        private System.Windows.Forms.PictureBox picAnswer1Correct;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox picHelp;
    }
}
