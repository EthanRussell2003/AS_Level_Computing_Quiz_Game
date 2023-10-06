using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class frmHardQuestionTextBox : Coursework.Template
    {
        User thisUser;
        int[] easyDummyArray;
        int[] hardDummyArray;
        string difficulty;
        bool admin, help = false;

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

        public frmHardQuestionTextBox(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray, string Difficulty, bool Admin) : base(ThisUser)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            txtAnswer1.Enabled = false;
            txtAnswer2.Enabled = false;
            txtAnswer3.Enabled = false;
            txtAnswer4.Enabled = false;
            btnContinue.Visible = true;

            //Removes any spaces or capitalisation in an answer and compares to the accepted answers
            if (txtAnswer1.Text.ToLower().Replace(" ", "")  == "lossycompression" || txtAnswer1.Text.ToLower().Replace(" ", "") == "irreversiblecompression" || txtAnswer1.Text.ToLower().Replace(" ", "") == "lossy" || txtAnswer1.Text.ToLower().Replace(" ", "") == "irreversible" || txtAnswer1.Text.ToLower().Replace(" ", "") == "ireversible" || txtAnswer1.Text.ToLower().Replace(" ", "") == "lossy compresion" || txtAnswer1.Text.ToLower().Replace(" ", "") == "irreversiblecompresion")
            {
                picAnswer1Correct.Visible = true;
                thisUser.Score += 2;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                picAnswer1Wrong.Visible = true;
            }
            if (txtAnswer2.Text.ToLower().Replace(" ", "") == "afunction" || txtAnswer2.Text.ToLower().Replace(" ", "") == "function" || txtAnswer2.Text.ToLower().Replace(" ", "") == "amethod" || txtAnswer2.Text.ToLower().Replace(" ", "") == "method")
            {
                picAnswer2Correct.Visible = true;
                thisUser.Score += 2;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                picAnswer2Wrong.Visible = true;
            }
            if (txtAnswer3.Text.ToLower().Replace(" ", "") == "thedatatype" || txtAnswer3.Text.ToLower().Replace(" ", "") == "datatype" || txtAnswer3.Text.ToLower().Replace(" ", "") == "adatatype" || txtAnswer3.Text.ToLower().Replace(" ", "") == "itsdatatype" || txtAnswer3.Text.ToLower().Replace(" ", "") == "it'sdatatype")
            {
                picAnswer3Correct.Visible = true;
                thisUser.Score += 2;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                picAnswer3Wrong.Visible = true;
            }
            if (txtAnswer4.Text.ToLower().Replace(" ", "") == "efficient" || txtAnswer4.Text.ToLower().Replace(" ", "") == "eficient")
            {
                picAnswer4Correct.Visible = true;
                thisUser.Score += 2;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                picAnswer4Wrong.Visible = true;
                if (txtAnswer4.Text.ToLower().Replace(" ", "") == "clean" || txtAnswer3.Text.ToLower().Replace(" ", "") == "clear")
                {
                    thisUser.Score += 1;
                }
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                this.Close();
                new frmAdmin(thisUser, easyDummyArray, hardDummyArray).Show();
            }
            else
            {
                this.Close();
                new frmHardQuestionRadioButton(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
            }
        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
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
    }
}
