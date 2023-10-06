using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Coursework.Forms
{
    public partial class frmQuestionEdit : Coursework.Template
    {
        User thisUser;
        Questions addQuestion = new Questions();
        Questions thisQuestion = new Questions();
        List<Questions> questions = new List<Questions>();
        bool showEdit = false, showAdd = false, canSave = false, isHard = false, questionTaken = true, alreadySelected = false, help = false;
        int[] easyDummyArray;
        int[] hardDummyArray;
        string currentQuestion;

        public frmQuestionEdit(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray) : base(ThisUser)
        {
            InitializeComponent();
            thisUser = ThisUser;
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            readQuestionToList();
            cbAddCorrectAnswer.Items.Add(" ");
            cbAddCorrectAnswer.Items.Add(" ");
            cbAddCorrectAnswer.Items.Add(" ");
            cbAddDifficulty.Items.Add("Easy");
            cbAddDifficulty.Items.Add("Hard");
            txtAnswer1.Enabled = false;
            txtAnswer2.Enabled = false;
            txtAnswer3.Enabled = false;
            foreach (Questions question in questions) //Populates the question select combo box with each question
            {
                cbQuestion.Items.Add(question.Question);
            }
        }

        private void readQuestionToList() //Writes the questions in the questions bin file to a list
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                sr = File.OpenRead("Questions.bin");
                questions = (List<Questions>)bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cbDifficulty_KeyPress(object sender, KeyPressEventArgs e) //Stops user from typing in the combo box
        {
            e.Handled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdmin(thisUser, easyDummyArray, hardDummyArray).Show();
        }

        private void cbQuestion_SelectedIndexChanged(object sender, EventArgs e) //Will populate each corresponding field with the correct information from the question selected
        {
            btnDelete.Enabled = true;
            readQuestionToList();
            foreach (Questions question in questions)
            {
                if (cbQuestion.Text == question.Question)
                {
                    if (alreadySelected == true)
                    {
                        currentQuestion = cbQuestion.Text;
                        thisQuestion = question;
                        txtAnswer1.Text = question.Answer1;
                        txtAnswer2.Text = question.Answer2;
                        txtAnswer3.Text = question.Answer3;
                        txtCorrectAnswer.Text = question.CorrectAnswer;
                        cbCorrectAnswer.Items.RemoveAt(0);
                        cbCorrectAnswer.Items.RemoveAt(0);
                        cbCorrectAnswer.Items.RemoveAt(0);
                        cbCorrectAnswer.Items.Add(question.Answer1);
                        cbCorrectAnswer.Items.Add(question.Answer2);
                        cbCorrectAnswer.Items.Add(question.Answer3);
                        cbCorrectAnswer.Text = question.CorrectAnswer;
                        cbDifficulty.Items.RemoveAt(0);
                        cbDifficulty.Items.RemoveAt(0);
                        cbDifficulty.Text = Convert.ToString(question.Hard);
                        cbDifficulty.Items.Add(true);
                        cbDifficulty.Items.Add(false);
                        txtAnswer1.Enabled = true;
                        txtAnswer2.Enabled = true;
                        txtAnswer3.Enabled = true;
                        alreadySelected = true;
                    }
                    else
                    {
                        currentQuestion = cbQuestion.Text;
                        thisQuestion = question;
                        txtAnswer1.Text = question.Answer1;
                        txtAnswer2.Text = question.Answer2;
                        txtAnswer3.Text = question.Answer3;
                        txtCorrectAnswer.Text = question.CorrectAnswer;
                        cbCorrectAnswer.Text = question.CorrectAnswer;
                        cbCorrectAnswer.Items.Add(question.Answer1);
                        cbCorrectAnswer.Items.Add(question.Answer2);
                        cbCorrectAnswer.Items.Add(question.Answer3);
                        cbDifficulty.Text = Convert.ToString(question.Hard);
                        cbDifficulty.Items.Add(true);
                        cbDifficulty.Items.Add(false);
                        txtAnswer1.Enabled = true;
                        txtAnswer2.Enabled = true;
                        txtAnswer3.Enabled = true;
                        alreadySelected = true;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) //Confirmation message to confirm if a user wants to delete a question
        {
            string message = "Are you sure you want to delete this question?";
            string title = "Delete Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                questions.Remove(thisQuestion);
                Stream sw;
                BinaryFormatter cf = new BinaryFormatter();
                try
                {
                    sw = File.OpenWrite("Questions.bin");
                    cf.Serialize(sw, questions);
                    sw.Close();
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
                new frmQuestionEdit(thisUser, easyDummyArray, hardDummyArray).Show();
            }
        }

        private void cbCorrectAnswer_KeyPress(object sender, KeyPressEventArgs e) //Stops user from typing in the combo box
        {
            e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e) //Confirms each field is filled correctly and saves the question
        {
            canSave = false;
            if (txtAnswer1.Text != "")
            {
                if (txtAnswer2.Text != "")
                {
                    if (txtAnswer3.Text != "")
                    {
                        if (cbQuestion.Text != "")
                        {
                            foreach (Questions question in questions)
                            {
                                if (question.Question == cbQuestion.Text && cbQuestion.Text != currentQuestion)
                                {
                                    lblEditIssue.Text = "Question already exists";
                                    canSave = false;
                                    break;
                                }
                                else
                                {
                                    canSave = true;
                                }
                            }
                        }
                        else
                        {
                            lblEditIssue.Text = "Define the question";
                        }
                    }
                    else
                    {
                        lblEditIssue.Text = "Define answer 3";
                    }
                }
                else
                {
                    lblEditIssue.Text = "Define answer 2";
                }
            }
            else
            {
                lblEditIssue.Text = "Define answer 1";
            }

            if (canSave == true) //Checks to see if a question can be saved
            {
                questions.Remove(thisQuestion);
                Stream st;
                BinaryFormatter ct = new BinaryFormatter();
                try
                {
                    st = File.OpenWrite("Questions.bin");
                    ct.Serialize(st, questions);
                    st.Close();
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                readQuestionToList();
                thisQuestion.Question = cbQuestion.Text;
                thisQuestion.Answer1 = txtAnswer1.Text;
                thisQuestion.Answer2 = txtAnswer2.Text;
                thisQuestion.Answer3 = txtAnswer3.Text;
                thisQuestion.CorrectAnswer = cbCorrectAnswer.Text;
                thisQuestion.Hard = Convert.ToBoolean(cbDifficulty.Text);
                questions.Add(thisQuestion);
                Stream se;
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    se = File.OpenWrite("Questions.bin");
                    bf.Serialize(se, questions);
                    se.Close();
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                readQuestionToList();
                this.Close();
                new frmQuestionEdit(thisUser, easyDummyArray, hardDummyArray).Show();
            }
        }

        private void txtAnswer1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAnswer2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAnswer3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAnswer1_KeyUp(object sender, KeyEventArgs e) //Updates the corresponding element in the correct answer combo box to have the text in this text box
        {
            cbCorrectAnswer.Items.RemoveAt(0);
            cbCorrectAnswer.Items.Insert(0, txtAnswer1.Text);
        }

        private void txtAnswer2_KeyUp(object sender, KeyEventArgs e) //Updates the corresponding element in the correct answer combo box to have the text in this text box
        {
            cbCorrectAnswer.Items.RemoveAt(1);
            cbCorrectAnswer.Items.Insert(1, txtAnswer2.Text);
        }

        private void txtAnswer3_KeyUp(object sender, KeyEventArgs e) //Updates the corresponding element in the correct answer combo box to have the text in this text box
        {
            cbCorrectAnswer.Items.RemoveAt(2);
            cbCorrectAnswer.Items.Insert(2, txtAnswer3.Text);
        }

        private void txtAddAnswer1_KeyUp(object sender, KeyEventArgs e) //Updates the corresponding element in the correct answer combo box to have the text in this text box
        {
            cbAddCorrectAnswer.Items.RemoveAt(0);
            cbAddCorrectAnswer.Items.Insert(0, txtAddAnswer1.Text);
        }

        private void txtAddAnswer2_KeyUp(object sender, KeyEventArgs e) //Updates the corresponding element in the correct answer combo box to have the text in this text box
        {
            cbAddCorrectAnswer.Items.RemoveAt(1);
            cbAddCorrectAnswer.Items.Insert(1, txtAddAnswer2.Text);
        }

        private void txtAddAnswer3_KeyUp(object sender, KeyEventArgs e) //Updates the corresponding element in the correct answer combo box to have the text in this text box
        {
            cbAddCorrectAnswer.Items.RemoveAt(2);
            cbAddCorrectAnswer.Items.Insert(2, txtAddAnswer3.Text);
        }

        private void lblAddQuestion_Click(object sender, EventArgs e)
        {

        }

        private void txtAddQuestion_TextChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be added
        {
            if (cbAddCorrectAnswer.Text != "" && cbAddDifficulty.Text != "" && txtAddAnswer1.Text != "" && txtAddAnswer2.Text != "" && txtAddAnswer3.Text != "")
            {
                btnAddQuestion.Enabled = true;
            }
            else
            {
                btnAddQuestion.Enabled = false;
            }
        }

        private void lblAddCorrectAnswer_Click(object sender, EventArgs e)
        {

        }

        private void cbAddCorrectAnswer_SelectedIndexChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be added
        {
            if (cbAddCorrectAnswer.Text != "" && cbAddDifficulty.Text != "" && txtAddAnswer1.Text != "" && txtAddAnswer2.Text != "" && txtAddAnswer3.Text != "")
            {
                btnAddQuestion.Enabled = true;
            }
            else
            {
                btnAddQuestion.Enabled = false;
            }
        }

        private void lblAddDifficulty_Click(object sender, EventArgs e)
        {

        }

        private void txtCorrectAnswer_TextChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be saved
        {
            if(cbQuestion.Text != null && cbDifficulty.Text != null && cbCorrectAnswer.Text != null && txtCorrectAnswer.Text != null && txtAnswer1.Text != null && txtAnswer3.Text != null)
            {
                btnSave.Enabled = true;
            }
        }

        private void txtAddAnswer1_TextChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be added
        {
            if (cbAddCorrectAnswer.Text != "" && cbAddDifficulty.Text != "" && txtAddAnswer1.Text != "" && txtAddAnswer2.Text != "" && txtAddAnswer3.Text != "")
            {
                btnAddQuestion.Enabled = true;
            }
            else
            {
                btnAddQuestion.Enabled = false;
            }
        }

        private void txtAddAnswer2_TextChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be added
        {
            if (cbAddCorrectAnswer.Text != "" && cbAddDifficulty.Text != "" && txtAddAnswer1.Text != "" && txtAddAnswer2.Text != "" && txtAddAnswer3.Text != "")
            {
                btnAddQuestion.Enabled = true;
            }
            else
            {
                btnAddQuestion.Enabled = false;
            }
        }

        private void txtAddAnswer3_TextChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be added
        {
            if (cbAddCorrectAnswer.Text != "" && cbAddDifficulty.Text != "" && txtAddAnswer1.Text != "" && txtAddAnswer2.Text != "" && txtAddAnswer3.Text != "")
            {
                btnAddQuestion.Enabled = true;
            }
            else
            {
                btnAddQuestion.Enabled = false;
            }
        }

        private void cbQuestion_TextChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be saved
        {
            if(cbQuestion.Text != "" && cbDifficulty.Text != "" && cbCorrectAnswer.Text != "" && txtCorrectAnswer.Text != "" && txtAnswer1.Text != "" && txtAnswer2.Text != "" && txtAnswer3.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void cbDifficulty_SelectedIndexChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be saved
        {
            if (cbQuestion.Text != "" && cbDifficulty.Text != "" && cbCorrectAnswer.Text != "" && txtCorrectAnswer.Text != "" && txtAnswer1.Text != "" && txtAnswer2.Text != "" && txtAnswer3.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void cbCorrectAnswer_SelectedIndexChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be saved
        {
            if (cbQuestion.Text != "" && cbDifficulty.Text != "" && cbCorrectAnswer.Text != "" && txtCorrectAnswer.Text != "" && txtAnswer1.Text != "" && txtAnswer2.Text != "" && txtAnswer3.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtAnswer1_TextChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be saved
        {
            if (cbQuestion.Text != "" && cbDifficulty.Text != "" && cbCorrectAnswer.Text != "" && txtCorrectAnswer.Text != "" && txtAnswer1.Text != "" && txtAnswer2.Text != "" && txtAnswer3.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be saved
        {
            if (cbQuestion.Text != "" && cbDifficulty.Text != "" && cbCorrectAnswer.Text != "" && txtCorrectAnswer.Text != "" && txtAnswer1.Text != "" && txtAnswer2.Text != "" && txtAnswer3.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtAnswer3_TextChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be saved
        {
            if (cbQuestion.Text != "" && cbDifficulty.Text != "" && cbCorrectAnswer.Text != "" && txtCorrectAnswer.Text != "" && txtAnswer1.Text != "" && txtAnswer2.Text != "" && txtAnswer3.Text != "")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e) //Help form changes based on which form is being shown
        {
            if (help == false)
            {
                if (showEdit == false && showAdd == false)
                {
                    picHelp1.BringToFront();
                    picHelp1.Visible = true;
                    btnHelp.Text = ("Back to Select");
                    help = true;
                }
                else if(showEdit == false && showAdd == true)
                {
                    picHelp2.BringToFront();
                    picHelp2.Visible = true;
                    btnHelp.Text = ("Back to Add");
                    help = true;
                }
                else if (showEdit == true && showAdd == false)
                {
                    picHelp3.BringToFront();
                    picHelp3.Visible = true;
                    btnHelp.Text = ("Back to Edit");
                    help = true;
                }
            }
            else
            {
                picHelp1.SendToBack();
                picHelp1.Visible = false;
                picHelp2.SendToBack();
                picHelp2.Visible = false;
                picHelp3.SendToBack();
                picHelp3.Visible = false;
                btnHelp.Text = ("Help");
                help = false;
            }
        }

        private void cbAddDifficulty_SelectedIndexChanged(object sender, EventArgs e) //Confirms that each field is filled so a question can be added
        {
            if (cbAddCorrectAnswer.Text != "" && cbAddDifficulty.Text != "" && txtAddAnswer1.Text != "" && txtAddAnswer2.Text != "" && txtAddAnswer3.Text != "")
            {
                btnAddQuestion.Enabled = true;
            }
            else
            {
                btnAddQuestion.Enabled = false;
            }
        }

        private void pbBackground_Click(object sender, EventArgs e)
        {

        }

        private void btnAddQuestion_Click(object sender, EventArgs e) //Confirms that each field is filled and will add the question
        {
            if(cbAddDifficulty.Text == "Hard")
            {
                isHard = true;
            }
            foreach (Questions question in questions)
            {
                if(txtAddQuestion.Text.ToLower().Replace(" ", "") == question.Question.ToLower().Replace("[ ?!.]", ""))
                {
                    questionTaken = true;
                }
                else
                {
                    questionTaken = false;
                }
            }
            try
            {
                if (txtAddQuestion.Text != "")
                {
                    foreach (Questions question in questions)
                    {
                        if (txtAddQuestion.Text == question.Question)
                        {
                            lblAddIssue.Text = "Question already exists";
                        }
                        else
                        {
                            if (questionTaken == false)
                            {
                                if (txtAddAnswer1.Text != "")
                                {
                                    if (txtAddAnswer2.Text != "")
                                    {
                                        if (txtAddAnswer3.Text != "")
                                        {
                                            if (cbAddCorrectAnswer.Text != "")
                                            {
                                                if (cbAddDifficulty.Text != "")
                                                {
                                                    addQuestion.Question = txtAddQuestion.Text;
                                                    addQuestion.Answer1 = txtAddAnswer1.Text;
                                                    addQuestion.Answer2 = txtAddAnswer2.Text;
                                                    addQuestion.Answer3 = txtAddAnswer3.Text;
                                                    addQuestion.CorrectAnswer = cbAddCorrectAnswer.Text;
                                                    addQuestion.Hard = isHard;
                                                    questions.Add(addQuestion);
                                                    Stream sw;
                                                    BinaryFormatter bf = new BinaryFormatter();
                                                    try
                                                    {
                                                        sw = File.OpenWrite("Questions.bin");
                                                        bf.Serialize(sw, questions);
                                                        sw.Close();
                                                        lblAddIssue.Text = ("Question Added!");
                                                    }
                                                    catch (Exception)
                                                    {
                                                    }
                                                    readQuestionToList();
                                                    this.Close();
                                                    new frmQuestionEdit(thisUser, easyDummyArray, hardDummyArray).Show();
                                                }
                                                else
                                                {
                                                    lblAddIssue.Text = ("Select a difficulty");
                                                }
                                            }
                                            else
                                            {
                                                lblAddIssue.Text = ("Select a correct answer");
                                            }
                                        }
                                        else
                                        {
                                            lblAddIssue.Text = ("Please enter a valid answer 3");
                                        }
                                    }
                                    else
                                    {
                                        lblAddIssue.Text = ("Please enter a valid answer 2");
                                    }
                                }
                                else
                                {
                                    lblAddIssue.Text = ("Please enter a valid answer 1");
                                }
                            }
                            else
                            {
                                lblAddIssue.Text = ("Question already exists");
                            }
                        }
                    }
                }
                else
                {
                    lblAddIssue.Text = ("Please enter a valid question");
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnShowAdd_Click(object sender, EventArgs e) //When the showAdd button is clicked it will show the add question facilities
        {
            if (showAdd == false)
            {
                btnAddQuestion.Visible = true;
                lblAddIssue.Visible = true;
                lblAddQuestion.Visible = true;
                lblAddAnswer1.Visible = true;
                lblAddAnswer2.Visible = true;
                lblAddAnswer3.Visible = true;
                lblAddCorrectAnswer.Visible = true;
                lblAddDifficulty.Visible = true;
                txtAddQuestion.Visible = true;
                txtAddAnswer1.Visible = true;
                txtAddAnswer2.Visible = true;
                txtAddAnswer3.Visible = true;
                cbAddCorrectAnswer.Visible = true;
                cbAddDifficulty.Visible = true;
                showAdd = true;
                btnShowEdit.Enabled = false;
                btnShowAdd.Text = "Hide Add Question";
            }
            else if (showAdd == true) //When the showAdd button is clicked again it will hide the add question facilities
            {
                btnAddQuestion.Visible = false;
                lblAddIssue.Visible = false;
                lblAddQuestion.Visible = false;
                lblAddAnswer1.Visible = false;
                lblAddAnswer2.Visible = false;
                lblAddAnswer3.Visible = false;
                lblAddCorrectAnswer.Visible = false;
                lblAddDifficulty.Visible = false;
                txtAddQuestion.Visible = false;
                txtAddAnswer1.Visible = false;
                txtAddAnswer2.Visible = false;
                txtAddAnswer3.Visible = false;
                cbAddCorrectAnswer.Visible = false;
                cbAddDifficulty.Visible = false;
                showAdd = false;
                btnShowEdit.Enabled = true;
                btnShowAdd.Text = ("Show Add Question");
            }
        }

        private void btnShowEdit_Click(object sender, EventArgs e) //When the showEdit button is clicked it will show the edit question facilities
        {
            if (showEdit == false)
            {
                cbQuestion.Visible = true;
                cbDifficulty.Visible = true;
                cbCorrectAnswer.Visible = true;
                txtAnswer1.Visible = true;
                txtAnswer2.Visible = true;
                txtAnswer3.Visible = true;
                txtCorrectAnswer.Visible = true;
                btnDelete.Visible = true;
                btnSave.Visible = true;
                lblAnswer1.Visible = true;
                lblAnswer2.Visible = true;
                lblAnswer3.Visible = true;
                lblCorrect.Visible = true;
                lblSelect.Visible = true;
                lblHard.Visible = true;
                lblOriginal.Visible = true;
                showEdit = true;
                btnShowAdd.Enabled = false;
                btnShowEdit.Text = ("Hide Edit Question");
            }
            else if (showEdit == true) //When the showEdit button is clicked again it will hide the edit question facilities
            {
                cbQuestion.Visible = false;
                cbDifficulty.Visible = false;
                cbCorrectAnswer.Visible = false;
                txtAnswer1.Visible = false;
                txtAnswer2.Visible = false;
                txtAnswer3.Visible = false;
                txtCorrectAnswer.Visible = false;
                btnDelete.Visible = false;
                btnSave.Visible = false;
                lblAnswer1.Visible = false;
                lblAnswer2.Visible = false;
                lblAnswer3.Visible = false;
                lblCorrect.Visible = false;
                lblSelect.Visible = false;
                lblHard.Visible = false;
                lblOriginal.Visible = false;
                showEdit = false;
                btnShowAdd.Enabled = true;
                btnShowEdit.Text = ("Show Edit Question");
            }
        }
    }
}
