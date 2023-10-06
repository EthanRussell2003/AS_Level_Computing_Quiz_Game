namespace Coursework.Forms
{
    partial class frmQuestionEdit
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
            this.btnShowAdd = new System.Windows.Forms.Button();
            this.cbQuestion = new System.Windows.Forms.ComboBox();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.cbCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.btnShowEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblHard = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblEditIssue = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.txtAddAnswer3 = new System.Windows.Forms.TextBox();
            this.txtAddAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAddQuestion = new System.Windows.Forms.TextBox();
            this.cbAddCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.txtAddAnswer1 = new System.Windows.Forms.TextBox();
            this.lblAddQuestion = new System.Windows.Forms.Label();
            this.lblAddDifficulty = new System.Windows.Forms.Label();
            this.lblAddCorrectAnswer = new System.Windows.Forms.Label();
            this.lblAddAnswer3 = new System.Windows.Forms.Label();
            this.lblAddAnswer2 = new System.Windows.Forms.Label();
            this.lblAddAnswer1 = new System.Windows.Forms.Label();
            this.cbAddDifficulty = new System.Windows.Forms.ComboBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lblAddIssue = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.picHelp1 = new System.Windows.Forms.PictureBox();
            this.picHelp2 = new System.Windows.Forms.PictureBox();
            this.picHelp3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAdd
            // 
            this.btnShowAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAdd.Location = new System.Drawing.Point(512, 167);
            this.btnShowAdd.Name = "btnShowAdd";
            this.btnShowAdd.Size = new System.Drawing.Size(152, 54);
            this.btnShowAdd.TabIndex = 5;
            this.btnShowAdd.Text = "Show Add Question";
            this.btnShowAdd.UseVisualStyleBackColor = true;
            this.btnShowAdd.Click += new System.EventHandler(this.btnShowAdd_Click);
            // 
            // cbQuestion
            // 
            this.cbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuestion.FormattingEnabled = true;
            this.cbQuestion.Location = new System.Drawing.Point(215, 276);
            this.cbQuestion.MaxDropDownItems = 100;
            this.cbQuestion.Name = "cbQuestion";
            this.cbQuestion.Size = new System.Drawing.Size(350, 32);
            this.cbQuestion.TabIndex = 6;
            this.cbQuestion.Visible = false;
            this.cbQuestion.SelectedIndexChanged += new System.EventHandler(this.cbQuestion_SelectedIndexChanged);
            this.cbQuestion.TextChanged += new System.EventHandler(this.cbQuestion_TextChanged);
            this.cbQuestion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbQuestion_KeyPress);
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Location = new System.Drawing.Point(215, 360);
            this.cbDifficulty.MaxDropDownItems = 2;
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(257, 32);
            this.cbDifficulty.TabIndex = 7;
            this.cbDifficulty.Visible = false;
            this.cbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cbDifficulty_SelectedIndexChanged);
            this.cbDifficulty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDifficulty_KeyPress);
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(859, 325);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(255, 29);
            this.txtAnswer1.TabIndex = 8;
            this.txtAnswer1.Visible = false;
            this.txtAnswer1.TextChanged += new System.EventHandler(this.txtAnswer1_TextChanged);
            this.txtAnswer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer1_KeyPress);
            this.txtAnswer1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAnswer1_KeyUp);
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.Location = new System.Drawing.Point(859, 398);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(255, 29);
            this.txtAnswer2.TabIndex = 9;
            this.txtAnswer2.Visible = false;
            this.txtAnswer2.TextChanged += new System.EventHandler(this.txtAnswer2_TextChanged);
            this.txtAnswer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer2_KeyPress);
            this.txtAnswer2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAnswer2_KeyUp);
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer3.Location = new System.Drawing.Point(859, 479);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(255, 29);
            this.txtAnswer3.TabIndex = 10;
            this.txtAnswer3.Visible = false;
            this.txtAnswer3.TextChanged += new System.EventHandler(this.txtAnswer3_TextChanged);
            this.txtAnswer3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer3_KeyPress);
            this.txtAnswer3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAnswer3_KeyUp);
            // 
            // cbCorrectAnswer
            // 
            this.cbCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCorrectAnswer.FormattingEnabled = true;
            this.cbCorrectAnswer.Location = new System.Drawing.Point(215, 444);
            this.cbCorrectAnswer.MaxDropDownItems = 3;
            this.cbCorrectAnswer.Name = "cbCorrectAnswer";
            this.cbCorrectAnswer.Size = new System.Drawing.Size(257, 32);
            this.cbCorrectAnswer.TabIndex = 11;
            this.cbCorrectAnswer.Visible = false;
            this.cbCorrectAnswer.SelectedIndexChanged += new System.EventHandler(this.cbCorrectAnswer_SelectedIndexChanged);
            this.cbCorrectAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCorrectAnswer_KeyPress);
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Enabled = false;
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAnswer.Location = new System.Drawing.Point(857, 252);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(257, 29);
            this.txtCorrectAnswer.TabIndex = 12;
            this.txtCorrectAnswer.Visible = false;
            this.txtCorrectAnswer.TextChanged += new System.EventHandler(this.txtCorrectAnswer_TextChanged);
            // 
            // btnShowEdit
            // 
            this.btnShowEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEdit.Location = new System.Drawing.Point(670, 167);
            this.btnShowEdit.Name = "btnShowEdit";
            this.btnShowEdit.Size = new System.Drawing.Size(152, 54);
            this.btnShowEdit.TabIndex = 13;
            this.btnShowEdit.Text = "Show Edit Question";
            this.btnShowEdit.UseVisualStyleBackColor = true;
            this.btnShowEdit.Click += new System.EventHandler(this.btnShowEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 54);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(210, 531);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(216, 100);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete Question";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(898, 531);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 100);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save Question";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.White;
            this.lblSelect.Location = new System.Drawing.Point(210, 248);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(179, 25);
            this.lblSelect.TabIndex = 20;
            this.lblSelect.Text = "Select Question";
            this.lblSelect.Visible = false;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.ForeColor = System.Drawing.Color.White;
            this.lblAnswer2.Location = new System.Drawing.Point(850, 370);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(109, 25);
            this.lblAnswer2.TabIndex = 21;
            this.lblAnswer2.Text = "Answer 2";
            this.lblAnswer2.Visible = false;
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.ForeColor = System.Drawing.Color.White;
            this.lblAnswer1.Location = new System.Drawing.Point(852, 297);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(109, 25);
            this.lblAnswer1.TabIndex = 22;
            this.lblAnswer1.Text = "Answer 1";
            this.lblAnswer1.Visible = false;
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginal.ForeColor = System.Drawing.Color.White;
            this.lblOriginal.Location = new System.Drawing.Point(852, 224);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(262, 25);
            this.lblOriginal.TabIndex = 23;
            this.lblOriginal.Text = "Original Correct Answer";
            this.lblOriginal.Visible = false;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.White;
            this.lblCorrect.Location = new System.Drawing.Point(215, 416);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(173, 25);
            this.lblCorrect.TabIndex = 24;
            this.lblCorrect.Text = "Correct Answer";
            this.lblCorrect.Visible = false;
            // 
            // lblHard
            // 
            this.lblHard.AutoSize = true;
            this.lblHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHard.ForeColor = System.Drawing.Color.White;
            this.lblHard.Location = new System.Drawing.Point(212, 332);
            this.lblHard.Name = "lblHard";
            this.lblHard.Size = new System.Drawing.Size(234, 25);
            this.lblHard.TabIndex = 25;
            this.lblHard.Text = "Is it a hard question?";
            this.lblHard.Visible = false;
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.ForeColor = System.Drawing.Color.White;
            this.lblAnswer3.Location = new System.Drawing.Point(852, 451);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(109, 25);
            this.lblAnswer3.TabIndex = 26;
            this.lblAnswer3.Text = "Answer 3";
            this.lblAnswer3.Visible = false;
            // 
            // lblEditIssue
            // 
            this.lblEditIssue.AutoSize = true;
            this.lblEditIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblEditIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditIssue.ForeColor = System.Drawing.Color.White;
            this.lblEditIssue.Location = new System.Drawing.Point(452, 531);
            this.lblEditIssue.MinimumSize = new System.Drawing.Size(10, 20);
            this.lblEditIssue.Name = "lblEditIssue";
            this.lblEditIssue.Size = new System.Drawing.Size(10, 29);
            this.lblEditIssue.TabIndex = 27;
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pbBackground.Location = new System.Drawing.Point(170, 214);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(994, 417);
            this.pbBackground.TabIndex = 28;
            this.pbBackground.TabStop = false;
            this.pbBackground.Visible = false;
            this.pbBackground.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // txtAddAnswer3
            // 
            this.txtAddAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAnswer3.Location = new System.Drawing.Point(859, 479);
            this.txtAddAnswer3.Name = "txtAddAnswer3";
            this.txtAddAnswer3.Size = new System.Drawing.Size(255, 29);
            this.txtAddAnswer3.TabIndex = 35;
            this.txtAddAnswer3.Visible = false;
            this.txtAddAnswer3.TextChanged += new System.EventHandler(this.txtAddAnswer3_TextChanged);
            this.txtAddAnswer3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddAnswer3_KeyUp);
            // 
            // txtAddAnswer2
            // 
            this.txtAddAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAnswer2.Location = new System.Drawing.Point(859, 398);
            this.txtAddAnswer2.Name = "txtAddAnswer2";
            this.txtAddAnswer2.Size = new System.Drawing.Size(255, 29);
            this.txtAddAnswer2.TabIndex = 34;
            this.txtAddAnswer2.Visible = false;
            this.txtAddAnswer2.TextChanged += new System.EventHandler(this.txtAddAnswer2_TextChanged);
            this.txtAddAnswer2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddAnswer2_KeyUp);
            // 
            // txtAddQuestion
            // 
            this.txtAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQuestion.Location = new System.Drawing.Point(210, 316);
            this.txtAddQuestion.Name = "txtAddQuestion";
            this.txtAddQuestion.Size = new System.Drawing.Size(255, 29);
            this.txtAddQuestion.TabIndex = 32;
            this.txtAddQuestion.Visible = false;
            this.txtAddQuestion.TextChanged += new System.EventHandler(this.txtAddQuestion_TextChanged);
            // 
            // cbAddCorrectAnswer
            // 
            this.cbAddCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddCorrectAnswer.FormattingEnabled = true;
            this.cbAddCorrectAnswer.Location = new System.Drawing.Point(210, 422);
            this.cbAddCorrectAnswer.Name = "cbAddCorrectAnswer";
            this.cbAddCorrectAnswer.Size = new System.Drawing.Size(255, 32);
            this.cbAddCorrectAnswer.TabIndex = 36;
            this.cbAddCorrectAnswer.Visible = false;
            this.cbAddCorrectAnswer.SelectedIndexChanged += new System.EventHandler(this.cbAddCorrectAnswer_SelectedIndexChanged);
            // 
            // txtAddAnswer1
            // 
            this.txtAddAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAnswer1.Location = new System.Drawing.Point(859, 325);
            this.txtAddAnswer1.Name = "txtAddAnswer1";
            this.txtAddAnswer1.Size = new System.Drawing.Size(255, 29);
            this.txtAddAnswer1.TabIndex = 33;
            this.txtAddAnswer1.Visible = false;
            this.txtAddAnswer1.TextChanged += new System.EventHandler(this.txtAddAnswer1_TextChanged);
            this.txtAddAnswer1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddAnswer1_KeyUp);
            // 
            // lblAddQuestion
            // 
            this.lblAddQuestion.AutoSize = true;
            this.lblAddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddQuestion.ForeColor = System.Drawing.Color.White;
            this.lblAddQuestion.Location = new System.Drawing.Point(205, 288);
            this.lblAddQuestion.Name = "lblAddQuestion";
            this.lblAddQuestion.Size = new System.Drawing.Size(106, 25);
            this.lblAddQuestion.TabIndex = 35;
            this.lblAddQuestion.Text = "Question";
            this.lblAddQuestion.Visible = false;
            this.lblAddQuestion.Click += new System.EventHandler(this.lblAddQuestion_Click);
            // 
            // lblAddDifficulty
            // 
            this.lblAddDifficulty.AutoSize = true;
            this.lblAddDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblAddDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDifficulty.ForeColor = System.Drawing.Color.White;
            this.lblAddDifficulty.Location = new System.Drawing.Point(205, 503);
            this.lblAddDifficulty.Name = "lblAddDifficulty";
            this.lblAddDifficulty.Size = new System.Drawing.Size(104, 25);
            this.lblAddDifficulty.TabIndex = 36;
            this.lblAddDifficulty.Text = "Difficulty";
            this.lblAddDifficulty.Visible = false;
            this.lblAddDifficulty.Click += new System.EventHandler(this.lblAddDifficulty_Click);
            // 
            // lblAddCorrectAnswer
            // 
            this.lblAddCorrectAnswer.AutoSize = true;
            this.lblAddCorrectAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblAddCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCorrectAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAddCorrectAnswer.Location = new System.Drawing.Point(205, 394);
            this.lblAddCorrectAnswer.Name = "lblAddCorrectAnswer";
            this.lblAddCorrectAnswer.Size = new System.Drawing.Size(173, 25);
            this.lblAddCorrectAnswer.TabIndex = 37;
            this.lblAddCorrectAnswer.Text = "Correct Answer";
            this.lblAddCorrectAnswer.Visible = false;
            this.lblAddCorrectAnswer.Click += new System.EventHandler(this.lblAddCorrectAnswer_Click);
            // 
            // lblAddAnswer3
            // 
            this.lblAddAnswer3.AutoSize = true;
            this.lblAddAnswer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAddAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAnswer3.ForeColor = System.Drawing.Color.White;
            this.lblAddAnswer3.Location = new System.Drawing.Point(854, 451);
            this.lblAddAnswer3.Name = "lblAddAnswer3";
            this.lblAddAnswer3.Size = new System.Drawing.Size(109, 25);
            this.lblAddAnswer3.TabIndex = 38;
            this.lblAddAnswer3.Text = "Answer 3";
            this.lblAddAnswer3.Visible = false;
            // 
            // lblAddAnswer2
            // 
            this.lblAddAnswer2.AutoSize = true;
            this.lblAddAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAddAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAnswer2.ForeColor = System.Drawing.Color.White;
            this.lblAddAnswer2.Location = new System.Drawing.Point(854, 370);
            this.lblAddAnswer2.Name = "lblAddAnswer2";
            this.lblAddAnswer2.Size = new System.Drawing.Size(109, 25);
            this.lblAddAnswer2.TabIndex = 39;
            this.lblAddAnswer2.Text = "Answer 2";
            this.lblAddAnswer2.Visible = false;
            // 
            // lblAddAnswer1
            // 
            this.lblAddAnswer1.AutoSize = true;
            this.lblAddAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAddAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAnswer1.ForeColor = System.Drawing.Color.White;
            this.lblAddAnswer1.Location = new System.Drawing.Point(850, 297);
            this.lblAddAnswer1.Name = "lblAddAnswer1";
            this.lblAddAnswer1.Size = new System.Drawing.Size(109, 25);
            this.lblAddAnswer1.TabIndex = 40;
            this.lblAddAnswer1.Text = "Answer 1";
            this.lblAddAnswer1.Visible = false;
            // 
            // cbAddDifficulty
            // 
            this.cbAddDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddDifficulty.FormattingEnabled = true;
            this.cbAddDifficulty.Location = new System.Drawing.Point(210, 532);
            this.cbAddDifficulty.Name = "cbAddDifficulty";
            this.cbAddDifficulty.Size = new System.Drawing.Size(199, 32);
            this.cbAddDifficulty.TabIndex = 37;
            this.cbAddDifficulty.Visible = false;
            this.cbAddDifficulty.SelectedIndexChanged += new System.EventHandler(this.cbAddDifficulty_SelectedIndexChanged);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuestion.Enabled = false;
            this.btnAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(898, 531);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(216, 100);
            this.btnAddQuestion.TabIndex = 38;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Visible = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // lblAddIssue
            // 
            this.lblAddIssue.AutoSize = true;
            this.lblAddIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lblAddIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddIssue.ForeColor = System.Drawing.Color.White;
            this.lblAddIssue.Location = new System.Drawing.Point(225, 602);
            this.lblAddIssue.MinimumSize = new System.Drawing.Size(10, 20);
            this.lblAddIssue.Name = "lblAddIssue";
            this.lblAddIssue.Size = new System.Drawing.Size(10, 29);
            this.lblAddIssue.TabIndex = 43;
            this.lblAddIssue.Visible = false;
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
            // picHelp1
            // 
            this.picHelp1.Image = global::Coursework.Properties.Resources.QuestionEditHelp1;
            this.picHelp1.Location = new System.Drawing.Point(170, -3);
            this.picHelp1.Name = "picHelp1";
            this.picHelp1.Size = new System.Drawing.Size(1018, 687);
            this.picHelp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp1.TabIndex = 51;
            this.picHelp1.TabStop = false;
            this.picHelp1.Visible = false;
            // 
            // picHelp2
            // 
            this.picHelp2.Image = global::Coursework.Properties.Resources.QuestionEditHelp2;
            this.picHelp2.Location = new System.Drawing.Point(167, -3);
            this.picHelp2.Name = "picHelp2";
            this.picHelp2.Size = new System.Drawing.Size(1021, 687);
            this.picHelp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp2.TabIndex = 52;
            this.picHelp2.TabStop = false;
            this.picHelp2.Visible = false;
            // 
            // picHelp3
            // 
            this.picHelp3.Image = global::Coursework.Properties.Resources.QuestionEditHelp3;
            this.picHelp3.Location = new System.Drawing.Point(167, -9);
            this.picHelp3.Name = "picHelp3";
            this.picHelp3.Size = new System.Drawing.Size(1021, 693);
            this.picHelp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp3.TabIndex = 53;
            this.picHelp3.TabStop = false;
            this.picHelp3.Visible = false;
            // 
            // frmQuestionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::Coursework.Properties.Resources.Transparent_background;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.picHelp3);
            this.Controls.Add(this.picHelp2);
            this.Controls.Add(this.picHelp1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblAddIssue);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.cbAddDifficulty);
            this.Controls.Add(this.lblAddAnswer1);
            this.Controls.Add(this.lblAddAnswer2);
            this.Controls.Add(this.lblAddAnswer3);
            this.Controls.Add(this.lblAddCorrectAnswer);
            this.Controls.Add(this.lblAddDifficulty);
            this.Controls.Add(this.lblAddQuestion);
            this.Controls.Add(this.cbAddCorrectAnswer);
            this.Controls.Add(this.txtAddAnswer3);
            this.Controls.Add(this.txtAddAnswer2);
            this.Controls.Add(this.txtAddAnswer1);
            this.Controls.Add(this.txtAddQuestion);
            this.Controls.Add(this.pbBackground);
            this.Controls.Add(this.lblEditIssue);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblHard);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShowEdit);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.cbCorrectAnswer);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.cbQuestion);
            this.Controls.Add(this.btnShowAdd);
            this.Name = "frmQuestionEdit";
            this.Text = "Edit questions";
            this.Controls.SetChildIndex(this.btnShowAdd, 0);
            this.Controls.SetChildIndex(this.cbQuestion, 0);
            this.Controls.SetChildIndex(this.cbDifficulty, 0);
            this.Controls.SetChildIndex(this.txtAnswer1, 0);
            this.Controls.SetChildIndex(this.txtAnswer2, 0);
            this.Controls.SetChildIndex(this.txtAnswer3, 0);
            this.Controls.SetChildIndex(this.cbCorrectAnswer, 0);
            this.Controls.SetChildIndex(this.txtCorrectAnswer, 0);
            this.Controls.SetChildIndex(this.btnShowEdit, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.lblSelect, 0);
            this.Controls.SetChildIndex(this.lblAnswer2, 0);
            this.Controls.SetChildIndex(this.lblAnswer1, 0);
            this.Controls.SetChildIndex(this.lblOriginal, 0);
            this.Controls.SetChildIndex(this.lblCorrect, 0);
            this.Controls.SetChildIndex(this.lblHard, 0);
            this.Controls.SetChildIndex(this.lblAnswer3, 0);
            this.Controls.SetChildIndex(this.lblEditIssue, 0);
            this.Controls.SetChildIndex(this.pbBackground, 0);
            this.Controls.SetChildIndex(this.txtAddQuestion, 0);
            this.Controls.SetChildIndex(this.txtAddAnswer1, 0);
            this.Controls.SetChildIndex(this.txtAddAnswer2, 0);
            this.Controls.SetChildIndex(this.txtAddAnswer3, 0);
            this.Controls.SetChildIndex(this.cbAddCorrectAnswer, 0);
            this.Controls.SetChildIndex(this.lblAddQuestion, 0);
            this.Controls.SetChildIndex(this.lblAddDifficulty, 0);
            this.Controls.SetChildIndex(this.lblAddCorrectAnswer, 0);
            this.Controls.SetChildIndex(this.lblAddAnswer3, 0);
            this.Controls.SetChildIndex(this.lblAddAnswer2, 0);
            this.Controls.SetChildIndex(this.lblAddAnswer1, 0);
            this.Controls.SetChildIndex(this.cbAddDifficulty, 0);
            this.Controls.SetChildIndex(this.btnAddQuestion, 0);
            this.Controls.SetChildIndex(this.lblAddIssue, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.picHelp1, 0);
            this.Controls.SetChildIndex(this.picHelp2, 0);
            this.Controls.SetChildIndex(this.picHelp3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowAdd;
        private System.Windows.Forms.ComboBox cbQuestion;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.ComboBox cbCorrectAnswer;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.Button btnShowEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblHard;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblEditIssue;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.TextBox txtAddAnswer3;
        private System.Windows.Forms.TextBox txtAddAnswer2;
        private System.Windows.Forms.TextBox txtAddQuestion;
        private System.Windows.Forms.ComboBox cbAddCorrectAnswer;
        private System.Windows.Forms.TextBox txtAddAnswer1;
        private System.Windows.Forms.Label lblAddQuestion;
        private System.Windows.Forms.Label lblAddDifficulty;
        private System.Windows.Forms.Label lblAddCorrectAnswer;
        private System.Windows.Forms.Label lblAddAnswer3;
        private System.Windows.Forms.Label lblAddAnswer2;
        private System.Windows.Forms.Label lblAddAnswer1;
        private System.Windows.Forms.ComboBox cbAddDifficulty;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblAddIssue;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox picHelp1;
        private System.Windows.Forms.PictureBox picHelp2;
        private System.Windows.Forms.PictureBox picHelp3;
    }
}
