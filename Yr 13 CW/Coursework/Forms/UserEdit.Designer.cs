namespace Coursework.Forms
{
    partial class frmUserEdit
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
            this.cbAdmin = new System.Windows.Forms.ComboBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtHighscore = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblIssue = new System.Windows.Forms.Label();
            this.pbIcon3 = new System.Windows.Forms.PictureBox();
            this.pbIconCurrent = new System.Windows.Forms.PictureBox();
            this.pbIcon1 = new System.Windows.Forms.PictureBox();
            this.pbIcon2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMasterAdmin = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.picHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAdmin
            // 
            this.cbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdmin.FormattingEnabled = true;
            this.cbAdmin.Location = new System.Drawing.Point(213, 392);
            this.cbAdmin.MaxDropDownItems = 2;
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(222, 32);
            this.cbAdmin.TabIndex = 4;
            this.cbAdmin.SelectedIndexChanged += new System.EventHandler(this.cbAdmin_SelectedIndexChanged);
            this.cbAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAdmin_KeyPress);
            // 
            // cbUser
            // 
            this.cbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(213, 251);
            this.cbUser.MaxDropDownItems = 100;
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(222, 32);
            this.cbUser.TabIndex = 5;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            this.cbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUser_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(502, 207);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(253, 29);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // txtHighscore
            // 
            this.txtHighscore.Enabled = false;
            this.txtHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighscore.Location = new System.Drawing.Point(500, 456);
            this.txtHighscore.MaxLength = 3;
            this.txtHighscore.Name = "txtHighscore";
            this.txtHighscore.Size = new System.Drawing.Size(255, 29);
            this.txtHighscore.TabIndex = 10;
            this.txtHighscore.TextChanged += new System.EventHandler(this.txtHighscore_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(500, 334);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(255, 29);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(208, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Admin Privileges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(497, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(497, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Highscore";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(497, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 54);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(230, 531);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(216, 100);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(911, 531);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 100);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssue.ForeColor = System.Drawing.Color.White;
            this.lblIssue.Location = new System.Drawing.Point(452, 531);
            this.lblIssue.MinimumSize = new System.Drawing.Size(10, 20);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(10, 24);
            this.lblIssue.TabIndex = 19;
            // 
            // pbIcon3
            // 
            this.pbIcon3.BackColor = System.Drawing.SystemColors.Control;
            this.pbIcon3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIcon3.Image = global::Coursework.Properties.Resources.Icon3;
            this.pbIcon3.Location = new System.Drawing.Point(1003, 218);
            this.pbIcon3.Name = "pbIcon3";
            this.pbIcon3.Size = new System.Drawing.Size(126, 121);
            this.pbIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon3.TabIndex = 23;
            this.pbIcon3.TabStop = false;
            this.pbIcon3.Click += new System.EventHandler(this.pbIcon3_Click);
            // 
            // pbIconCurrent
            // 
            this.pbIconCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbIconCurrent.Location = new System.Drawing.Point(1015, 392);
            this.pbIconCurrent.Name = "pbIconCurrent";
            this.pbIconCurrent.Size = new System.Drawing.Size(102, 93);
            this.pbIconCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconCurrent.TabIndex = 24;
            this.pbIconCurrent.TabStop = false;
            // 
            // pbIcon1
            // 
            this.pbIcon1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIcon1.Image = global::Coursework.Properties.Resources.Icon1;
            this.pbIcon1.InitialImage = null;
            this.pbIcon1.Location = new System.Drawing.Point(839, 361);
            this.pbIcon1.Name = "pbIcon1";
            this.pbIcon1.Size = new System.Drawing.Size(126, 121);
            this.pbIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon1.TabIndex = 25;
            this.pbIcon1.TabStop = false;
            this.pbIcon1.Click += new System.EventHandler(this.pbIcon1_Click);
            // 
            // pbIcon2
            // 
            this.pbIcon2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIcon2.Image = global::Coursework.Properties.Resources.Icon2;
            this.pbIcon2.Location = new System.Drawing.Point(839, 218);
            this.pbIcon2.Name = "pbIcon2";
            this.pbIcon2.Size = new System.Drawing.Size(126, 121);
            this.pbIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon2.TabIndex = 26;
            this.pbIcon2.TabStop = false;
            this.pbIcon2.Click += new System.EventHandler(this.pbIcon2_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox7.Location = new System.Drawing.Point(811, 197);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(346, 306);
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(811, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Icon Select";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1006, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Selected Icon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(209, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Master admin:";
            // 
            // lblMasterAdmin
            // 
            this.lblMasterAdmin.AutoSize = true;
            this.lblMasterAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblMasterAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterAdmin.ForeColor = System.Drawing.Color.White;
            this.lblMasterAdmin.Location = new System.Drawing.Point(209, 456);
            this.lblMasterAdmin.Name = "lblMasterAdmin";
            this.lblMasterAdmin.Size = new System.Drawing.Size(95, 20);
            this.lblMasterAdmin.TabIndex = 31;
            this.lblMasterAdmin.Text = "ethanAdmin";
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(12, 214);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(152, 55);
            this.btnHelp.TabIndex = 50;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // picHelp
            // 
            this.picHelp.Image = global::Coursework.Properties.Resources.UserEditHelp;
            this.picHelp.Location = new System.Drawing.Point(170, -3);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(1017, 688);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 51;
            this.picHelp.TabStop = false;
            this.picHelp.Visible = false;
            // 
            // frmUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblMasterAdmin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbIcon1);
            this.Controls.Add(this.pbIconCurrent);
            this.Controls.Add(this.pbIcon3);
            this.Controls.Add(this.pbIcon2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtHighscore);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.cbAdmin);
            this.Name = "frmUserEdit";
            this.Text = "Edit users";
            this.Controls.SetChildIndex(this.cbAdmin, 0);
            this.Controls.SetChildIndex(this.cbUser, 0);
            this.Controls.SetChildIndex(this.txtUsername, 0);
            this.Controls.SetChildIndex(this.txtHighscore, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.lblIssue, 0);
            this.Controls.SetChildIndex(this.pictureBox7, 0);
            this.Controls.SetChildIndex(this.pbIcon2, 0);
            this.Controls.SetChildIndex(this.pbIcon3, 0);
            this.Controls.SetChildIndex(this.pbIconCurrent, 0);
            this.Controls.SetChildIndex(this.pbIcon1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.lblMasterAdmin, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.picHelp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAdmin;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtHighscore;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.PictureBox pbIcon3;
        private System.Windows.Forms.PictureBox pbIconCurrent;
        private System.Windows.Forms.PictureBox pbIcon1;
        private System.Windows.Forms.PictureBox pbIcon2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMasterAdmin;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox picHelp;
    }
}
