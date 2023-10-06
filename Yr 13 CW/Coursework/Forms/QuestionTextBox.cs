using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Forms
{
    public partial class frmQuestionTextEntry : Coursework.Template
    {
        User thisUser;
        string answer1 = "cpu", answer2 = "randomaccessmemory", answer3 = "8", answer4 = "image", difficulty;
        int[] easyDummyArray;
        int[] hardDummyArray;
        bool admin, help = false;

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {

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
                new frmQuestionRadioButton(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            txtAnswer1.Enabled = false;
            txtAnswer2.Enabled = false;
            txtAnswer3.Enabled = false;
            txtAnswer4.Enabled = false;
            btnContinue.Visible = true;

            //Removes any spaces or capitalisation in an answer and compares to the accepted answers
            if (answer1 == txtAnswer1.Text.ToLower().Replace(" ", ""))
            {
                picAnswer1Correct.Visible = true;
                thisUser.Score += 1;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                picAnswer1Wrong.Visible = true;
            }
            if (answer2 == txtAnswer2.Text.ToLower().Replace(" ","") || txtAnswer2.Text.ToLower().Replace(" ", "") == "randomacesmemory" || txtAnswer2.Text.ToLower().Replace(" ", "") == "randomaccesmemory" || txtAnswer2.Text.ToLower().Replace(" ", "") == "randomacessmemory")
            {
                picAnswer2Correct.Visible = true;
                thisUser.Score += 1;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                picAnswer2Wrong.Visible = true;
            }
            if (answer3 == txtAnswer3.Text.ToLower().Replace(" ", "") || txtAnswer3.Text.ToLower().Replace(" ", "") == "eight")
            {
                picAnswer3Correct.Visible = true;
                thisUser.Score += 1;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                picAnswer3Wrong.Visible = true;
            }
            if (answer4 == txtAnswer4.Text.ToLower().Replace(" ", ""))
            {
                picAnswer4Correct.Visible = true;
                thisUser.Score += 1;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                picAnswer4Wrong.Visible = true;
            }

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

        private void picAnswer4Correct_Click(object sender, EventArgs e)
        {

        }

        public frmQuestionTextEntry(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray, string Difficulty, bool Admin) : base (ThisUser)
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
            lblScore.Text = Convert.ToString(thisUser.Score);
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
        }

        public frmQuestionTextEntry()
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
    }
}
