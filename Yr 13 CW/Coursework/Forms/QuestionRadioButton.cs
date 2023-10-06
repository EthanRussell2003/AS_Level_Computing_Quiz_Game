using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Coursework.Forms
{
    public partial class frmQuestionRadioButton : Template
    {
        string CorrectAnswer, difficulty;
        User thisUser;
        Questions Question = new Questions();
        List<Questions> questions = new List<Questions>();
        List<int> dummyList = new List<int>();
        int listLength, firstLength, i = 0, j = 0, noQuestionsUsed = 0, easyListLength, easy;
        bool newQuestion, admin, help = false;
        int[] easyDummyArray;
        int[] hardDummyArray;

        public frmQuestionRadioButton(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray, string Difficulty, bool Admin) : base (ThisUser)
        {
            InitializeComponent();
            thisUser = ThisUser;
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            admin = Admin;
            if (Admin == true)
            {
                btnContinue.Text = ("Back to admin");
            }
            difficulty = Difficulty;
            readQuestionToList();
            firstLength = questions.Count;
            picAnswer1Correct.Visible = false;
            picAnswer1Wrong.Visible = false;
            do //Creating a list for easy and hard questions
            {
                listLength = questions.Count;
                if(j == firstLength)
                {
                    break;
                }
                Question = questions[i];
                if (Question.Hard == true)
                {
                    questions.Remove(Question);
                }
                else
                {
                    i += 1;
                }
                j += 1;
            } while (i < listLength);
            lblScore.Text = Convert.ToString(thisUser.Score);
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
            if (easyDummyArray != null) //Checks if the dummy array is filled (Mainly for admin usage as regular player won't access this form first)
            {
                easyListLength = easyDummyArray.Length;
                foreach (int num in easyDummyArray)
                {
                    if (num == 1)
                    {
                        easy++;
                    }
                }
                if (easy == easyListLength)
                {
                    MessageBox.Show("Randomised questions have been exhausted. They will now repeat");
                    foreach (int num in easyDummyArray)
                    {
                        for (int a = 0; a < easyListLength; a++)
                        {
                            easyDummyArray[a] = 0;
                        }
                    }
                }
            }
        }
        public frmQuestionRadioButton()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) //Confirmation message if the user clicks the main menu button
        {
            string message = "This will return you to the main menu.\nAre you sure you want to go back?\nUnsaved data will be lost\n(Data is only saved when the quiz is finished)";
            string title = "Main Menu";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                new frmMain(thisUser, easyDummyArray, hardDummyArray).Show();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e) //Checks if the correct answer was selected
        {
            btnContinue.Visible = true;
            btnSubmit.Enabled = false;
            try
            {
                if (CorrectAnswer == Question.CorrectAnswer)
                {
                    picAnswer1Correct.Visible = true;
                    thisUser.Score += 1;
                    lblScore.Text = Convert.ToString(thisUser.Score);
                }
                else
                {
                    picAnswer1Wrong.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select an answer");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e) //Help form
        {
            if (help == false)
            {
                picHelp.BringToFront();
                picHelp.Visible = true;
                btnHelp.Text = ("Back to Question");
                help = true;
            }
            else
            {
                picHelp.SendToBack();
                picHelp.Visible = false;
                btnHelp.Text = ("Help");
                help = false;
            }
        }

        private void frmQuestionRadioButton_Load(object sender, EventArgs e) //Populates the question fields with a random question
        {
            if (easyDummyArray == null)
            {
                int listLength = questions.Count;
                easyDummyArray = new int[listLength];
                for (int i = 0; i < listLength; i++)
                    easyDummyArray[i] = 0;
            }
            Random random = new Random();
            try
            {
                int randomElement = random.Next(listLength);
                do
                {
                    randomElement = random.Next(listLength);
                    Question = questions[randomElement];
                    if (Question.Hard == false)
                    {
                        if (easyDummyArray[randomElement] == 0)
                        {
                            lblShowQuestion.Text = Question.Question;
                            rdbAnswer1.Text = Question.Answer1;
                            rdbAnswer2.Text = Question.Answer2;
                            rdbAnswer3.Text = Question.Answer3;
                            easyDummyArray[randomElement] = 1;
                            newQuestion = false;
                            foreach (int number in easyDummyArray)
                            {
                                if (number == 1)
                                {
                                    noQuestionsUsed++;
                                }
                            }
                        }
                        else
                        {
                            easyDummyArray[randomElement] = 1;
                            randomElement += 1;
                            newQuestion = true;
                        }
                    }
                } while (newQuestion == true);
            }
            catch
            {

            }
        }

        private void rdbAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            CorrectAnswer = rdbAnswer1.Text;
        }

        private void rdbAnswer2_CheckedChanged(object sender, EventArgs e)
        {
            CorrectAnswer = rdbAnswer2.Text;
        }

        private void rdbAnswer3_CheckedChanged(object sender, EventArgs e)
        {
            CorrectAnswer = rdbAnswer3.Text;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if(admin == true)
            {
                this.Close();
                new frmAdmin(thisUser, easyDummyArray, hardDummyArray).Show();
            }
            else
            {
                this.Close();
                new frmQuestionDropDown(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
            }     
        }

        private void readQuestionToList() //Opens questions bin file and reads each question to a list
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
    }
}
