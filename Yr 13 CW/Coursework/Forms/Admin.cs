using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class frmAdmin : Coursework.Template
    {
        User thisUser;
        int[] easyDummyArray;
        int[] hardDummyArray;
        bool replay, admin = false, help = false;
        string difficulty;

        public frmAdmin(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray) : base(ThisUser)
        {
            InitializeComponent();
            thisUser = ThisUser;
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            thisUser.Score = 0;
            lblScore.Text = Convert.ToString(thisUser.Score);
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
        }
        private void btnEditPlayer_Click(object sender, EventArgs e) //Code to send user to respective form
        {

            this.Close();
            new frmUserEdit(thisUser, easyDummyArray, hardDummyArray).Show();
        }

        private void btnEditQuestion_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            this.Close();
            new frmQuestionEdit(thisUser, easyDummyArray, hardDummyArray).Show();
        }

        private void btnDragDropTest_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            admin = true;
            this.Close();
            new frmQuestionDragDrop(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnComboBoxTest_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            admin = true;
            this.Close();
            new frmQuestionDropDown(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnRadioButtonTest_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            admin = true;
            this.Close();
            new frmQuestionRadioButton(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnTextEntryTest_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            admin = true;
            this.Close();
            new frmQuestionTextEntry(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnBack_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            this.Close();
            new frmMain(thisUser, easyDummyArray, hardDummyArray).Show();
        }

        private void btnHardDragDrop_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            admin = true;
            this.Close();
            new frmHardQuestionDragDrop(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnHardComboBox_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            admin = true;
            this.Close();
            new frmHardQuestionDropDown(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnHardRadioButton_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            admin = true;
            this.Close();
            new frmHardQuestionRadioButton(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }
         
        private void btnHardTextBox_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            admin = true;
            this.Close();
            new frmHardQuestionTextBox(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnBonus_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            admin = true;
            this.Close();
            new frmBreakout(thisUser, easyDummyArray, hardDummyArray, replay, difficulty, admin).Show();
        }

        private void btnHelp_Click(object sender, EventArgs e) //Help form using an image
        {
            if (help == false) 
            {
                picHelp.BringToFront();
                picHelp.Visible = true;
                btnHelp.Text = ("Back to Admin Menu");
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

        private void btnEndScreen_Click(object sender, EventArgs e) //Code to send user to respective form
        {
            admin = true;
            this.Close();
            new frmEndScreen(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }
    }
}
