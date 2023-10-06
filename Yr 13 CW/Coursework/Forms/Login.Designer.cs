namespace Coursework
{
    partial class frmLogin
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
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLoginExit = new System.Windows.Forms.Button();
            this.lblQuizName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComplexities = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblUsername2 = new System.Windows.Forms.Label();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.lblUsernameReq = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordReq = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtRegisterConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirmReq = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblIssue = new System.Windows.Forms.Label();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.cbShowRegisterPassword = new System.Windows.Forms.CheckBox();
            this.lblLoginIssue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPasswordReq2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbChosenIcon = new System.Windows.Forms.PictureBox();
            this.pbIcon3 = new System.Windows.Forms.PictureBox();
            this.pbIcon2 = new System.Windows.Forms.PictureBox();
            this.pbIcon1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsername.ForeColor = System.Drawing.Color.White;
            this.lblLoginUsername.Location = new System.Drawing.Point(253, 279);
            this.lblLoginUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(150, 36);
            this.lblLoginUsername.TabIndex = 0;
            this.lblLoginUsername.Text = "Username";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.ForeColor = System.Drawing.Color.White;
            this.lblLoginPassword.Location = new System.Drawing.Point(253, 430);
            this.lblLoginPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(147, 36);
            this.lblLoginPassword.TabIndex = 1;
            this.lblLoginPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(224, 686);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(222, 78);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsername.Location = new System.Drawing.Point(146, 338);
            this.txtLoginUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginUsername.MaxLength = 20;
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(380, 34);
            this.txtLoginUsername.TabIndex = 5;
            this.txtLoginUsername.TextChanged += new System.EventHandler(this.txtLoginUsername_TextChanged);
            this.txtLoginUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginUsername_KeyPress);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.Location = new System.Drawing.Point(146, 490);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginPassword.MaxLength = 16;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(380, 34);
            this.txtLoginPassword.TabIndex = 6;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            this.txtLoginPassword.TextChanged += new System.EventHandler(this.txtLoginPassword_TextChanged);
            // 
            // btnLoginExit
            // 
            this.btnLoginExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginExit.Location = new System.Drawing.Point(1330, 18);
            this.btnLoginExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoginExit.Name = "btnLoginExit";
            this.btnLoginExit.Size = new System.Drawing.Size(226, 86);
            this.btnLoginExit.TabIndex = 7;
            this.btnLoginExit.Text = "Exit";
            this.btnLoginExit.UseVisualStyleBackColor = true;
            this.btnLoginExit.Click += new System.EventHandler(this.btnLoginExit_Click);
            // 
            // lblQuizName
            // 
            this.lblQuizName.AutoSize = true;
            this.lblQuizName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblQuizName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizName.ForeColor = System.Drawing.Color.White;
            this.lblQuizName.Location = new System.Drawing.Point(25, 14);
            this.lblQuizName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuizName.Name = "lblQuizName";
            this.lblQuizName.Size = new System.Drawing.Size(607, 91);
            this.lblQuizName.TabIndex = 10;
            this.lblQuizName.Text = "Computing Quiz";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.btnComplexities);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnLoginExit);
            this.panel1.Controls.Add(this.lblQuizName);
            this.panel1.Location = new System.Drawing.Point(-9, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1607, 140);
            this.panel1.TabIndex = 11;
            // 
            // btnComplexities
            // 
            this.btnComplexities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplexities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplexities.Location = new System.Drawing.Point(811, 18);
            this.btnComplexities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComplexities.Name = "btnComplexities";
            this.btnComplexities.Size = new System.Drawing.Size(226, 86);
            this.btnComplexities.TabIndex = 12;
            this.btnComplexities.Text = "Code Complexities (For attention of the examiner)";
            this.btnComplexities.UseVisualStyleBackColor = true;
            this.btnComplexities.Click += new System.EventHandler(this.btnComplexities_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(1070, 18);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(226, 86);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblUsername2
            // 
            this.lblUsername2.AutoSize = true;
            this.lblUsername2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblUsername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername2.ForeColor = System.Drawing.Color.White;
            this.lblUsername2.Location = new System.Drawing.Point(904, 242);
            this.lblUsername2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername2.Name = "lblUsername2";
            this.lblUsername2.Size = new System.Drawing.Size(150, 36);
            this.lblUsername2.TabIndex = 12;
            this.lblUsername2.Text = "Username";
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.Location = new System.Drawing.Point(796, 281);
            this.txtRegisterUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisterUsername.MaxLength = 20;
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(380, 34);
            this.txtRegisterUsername.TabIndex = 13;
            this.txtRegisterUsername.TextChanged += new System.EventHandler(this.txtRegisterUsername_TextChanged);
            // 
            // lblUsernameReq
            // 
            this.lblUsernameReq.AutoSize = true;
            this.lblUsernameReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblUsernameReq.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameReq.Location = new System.Drawing.Point(792, 324);
            this.lblUsernameReq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameReq.Name = "lblUsernameReq";
            this.lblUsernameReq.Size = new System.Drawing.Size(172, 17);
            this.lblUsernameReq.TabIndex = 15;
            this.lblUsernameReq.Text = "*Minimum of 5 characters*";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2.ForeColor = System.Drawing.Color.White;
            this.lblPassword2.Location = new System.Drawing.Point(907, 393);
            this.lblPassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(147, 36);
            this.lblPassword2.TabIndex = 16;
            this.lblPassword2.Text = "Password";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(796, 432);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisterPassword.MaxLength = 16;
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(380, 34);
            this.txtRegisterPassword.TabIndex = 14;
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            this.txtRegisterPassword.TextChanged += new System.EventHandler(this.txtRegisterPassword_TextChanged);
            // 
            // lblPasswordReq
            // 
            this.lblPasswordReq.AutoSize = true;
            this.lblPasswordReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblPasswordReq.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordReq.Location = new System.Drawing.Point(792, 475);
            this.lblPasswordReq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordReq.Name = "lblPasswordReq";
            this.lblPasswordReq.Size = new System.Drawing.Size(172, 17);
            this.lblPasswordReq.TabIndex = 18;
            this.lblPasswordReq.Text = "*Minimum of 5 characters*";
            this.lblPasswordReq.Click += new System.EventHandler(this.lblPasswordReq_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(846, 544);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(258, 36);
            this.lblConfirmPassword.TabIndex = 19;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtRegisterConfirm
            // 
            this.txtRegisterConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterConfirm.Location = new System.Drawing.Point(796, 583);
            this.txtRegisterConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisterConfirm.MaxLength = 16;
            this.txtRegisterConfirm.Name = "txtRegisterConfirm";
            this.txtRegisterConfirm.Size = new System.Drawing.Size(380, 34);
            this.txtRegisterConfirm.TabIndex = 15;
            this.txtRegisterConfirm.UseSystemPasswordChar = true;
            this.txtRegisterConfirm.TextChanged += new System.EventHandler(this.txtRegisterConfirm_TextChanged);
            // 
            // lblConfirmReq
            // 
            this.lblConfirmReq.AutoSize = true;
            this.lblConfirmReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblConfirmReq.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmReq.Location = new System.Drawing.Point(792, 626);
            this.lblConfirmReq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmReq.Name = "lblConfirmReq";
            this.lblConfirmReq.Size = new System.Drawing.Size(155, 17);
            this.lblConfirmReq.TabIndex = 21;
            this.lblConfirmReq.Text = "*Password must match*";
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(866, 686);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(222, 78);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssue.ForeColor = System.Drawing.Color.White;
            this.lblIssue.Location = new System.Drawing.Point(792, 778);
            this.lblIssue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssue.MinimumSize = new System.Drawing.Size(13, 25);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(13, 25);
            this.lblIssue.TabIndex = 28;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.cbShowPassword.ForeColor = System.Drawing.Color.White;
            this.cbShowPassword.Location = new System.Drawing.Point(267, 548);
            this.cbShowPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(129, 21);
            this.cbShowPassword.TabIndex = 31;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = false;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // cbShowRegisterPassword
            // 
            this.cbShowRegisterPassword.AutoSize = true;
            this.cbShowRegisterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.cbShowRegisterPassword.ForeColor = System.Drawing.Color.White;
            this.cbShowRegisterPassword.Location = new System.Drawing.Point(796, 650);
            this.cbShowRegisterPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbShowRegisterPassword.Name = "cbShowRegisterPassword";
            this.cbShowRegisterPassword.Size = new System.Drawing.Size(136, 21);
            this.cbShowRegisterPassword.TabIndex = 32;
            this.cbShowRegisterPassword.Text = "Show Passwords";
            this.cbShowRegisterPassword.UseVisualStyleBackColor = false;
            this.cbShowRegisterPassword.CheckedChanged += new System.EventHandler(this.cbShowRegisterPassword_CheckedChanged);
            // 
            // lblLoginIssue
            // 
            this.lblLoginIssue.AutoSize = true;
            this.lblLoginIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblLoginIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginIssue.ForeColor = System.Drawing.Color.White;
            this.lblLoginIssue.Location = new System.Drawing.Point(141, 603);
            this.lblLoginIssue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginIssue.MinimumSize = new System.Drawing.Size(13, 25);
            this.lblLoginIssue.Name = "lblLoginIssue";
            this.lblLoginIssue.Size = new System.Drawing.Size(13, 25);
            this.lblLoginIssue.TabIndex = 33;
            this.lblLoginIssue.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 69);
            this.label2.TabIndex = 35;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(845, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 69);
            this.label3.TabIndex = 36;
            this.label3.Text = "Register";
            // 
            // lblPasswordReq2
            // 
            this.lblPasswordReq2.AutoSize = true;
            this.lblPasswordReq2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblPasswordReq2.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordReq2.Location = new System.Drawing.Point(792, 503);
            this.lblPasswordReq2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordReq2.Name = "lblPasswordReq2";
            this.lblPasswordReq2.Size = new System.Drawing.Size(162, 17);
            this.lblPasswordReq2.TabIndex = 38;
            this.lblPasswordReq2.Text = "*Must contain a number*";
            this.lblPasswordReq2.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1271, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 36);
            this.label4.TabIndex = 39;
            this.label4.Text = "Select an icon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1271, 582);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 36);
            this.label5.TabIndex = 40;
            this.label5.Text = "Selected icon";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(693, 137);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 686);
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pbChosenIcon
            // 
            this.pbChosenIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbChosenIcon.Location = new System.Drawing.Point(1320, 646);
            this.pbChosenIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbChosenIcon.Name = "pbChosenIcon";
            this.pbChosenIcon.Size = new System.Drawing.Size(123, 107);
            this.pbChosenIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChosenIcon.TabIndex = 26;
            this.pbChosenIcon.TabStop = false;
            // 
            // pbIcon3
            // 
            this.pbIcon3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIcon3.Image = global::Coursework.Properties.Resources.Icon3;
            this.pbIcon3.InitialImage = global::Coursework.Properties.Resources.Icon3;
            this.pbIcon3.Location = new System.Drawing.Point(1224, 302);
            this.pbIcon3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbIcon3.Name = "pbIcon3";
            this.pbIcon3.Size = new System.Drawing.Size(123, 108);
            this.pbIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon3.TabIndex = 25;
            this.pbIcon3.TabStop = false;
            this.pbIcon3.Click += new System.EventHandler(this.Icon3_Click);
            // 
            // pbIcon2
            // 
            this.pbIcon2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIcon2.Image = global::Coursework.Properties.Resources.Icon2;
            this.pbIcon2.InitialImage = global::Coursework.Properties.Resources.Icon2;
            this.pbIcon2.Location = new System.Drawing.Point(1421, 302);
            this.pbIcon2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbIcon2.Name = "pbIcon2";
            this.pbIcon2.Size = new System.Drawing.Size(123, 108);
            this.pbIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon2.TabIndex = 24;
            this.pbIcon2.TabStop = false;
            this.pbIcon2.Click += new System.EventHandler(this.Icon2_Click);
            // 
            // pbIcon1
            // 
            this.pbIcon1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIcon1.Image = global::Coursework.Properties.Resources.Icon1;
            this.pbIcon1.InitialImage = global::Coursework.Properties.Resources.Icon1;
            this.pbIcon1.Location = new System.Drawing.Point(1320, 441);
            this.pbIcon1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbIcon1.Name = "pbIcon1";
            this.pbIcon1.Size = new System.Drawing.Size(123, 108);
            this.pbIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon1.TabIndex = 23;
            this.pbIcon1.TabStop = false;
            this.pbIcon1.Click += new System.EventHandler(this.Icon1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework.Properties.Resources.Background41;
            this.pictureBox1.Location = new System.Drawing.Point(-13, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1607, 736);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // picHelp
            // 
            this.picHelp.Image = global::Coursework.Properties.Resources.LoginHelp1;
            this.picHelp.Location = new System.Drawing.Point(0, 117);
            this.picHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(1593, 722);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 41;
            this.picHelp.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 838);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPasswordReq2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.pbChosenIcon);
            this.Controls.Add(this.pbIcon3);
            this.Controls.Add(this.pbIcon2);
            this.Controls.Add(this.pbIcon1);
            this.Controls.Add(this.lblLoginIssue);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbShowRegisterPassword);
            this.Controls.Add(this.lblConfirmReq);
            this.Controls.Add(this.txtRegisterConfirm);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPasswordReq);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblUsernameReq);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.lblUsername2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.txtLoginUsername);
            this.Controls.Add(this.lblLoginUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLoginExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuizName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername2;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Label lblUsernameReq;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label lblPasswordReq;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtRegisterConfirm;
        private System.Windows.Forms.Label lblConfirmReq;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pbIcon1;
        private System.Windows.Forms.PictureBox pbIcon2;
        private System.Windows.Forms.PictureBox pbIcon3;
        private System.Windows.Forms.PictureBox pbChosenIcon;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.CheckBox cbShowRegisterPassword;
        private System.Windows.Forms.Label lblLoginIssue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblPasswordReq2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnComplexities;
    }
}