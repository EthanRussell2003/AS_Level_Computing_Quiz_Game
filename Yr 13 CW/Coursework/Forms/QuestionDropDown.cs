using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class frmQuestionDropDown : Coursework.Template
    {
        User thisUser;
        int[] easyDummyArray;
        int[] hardDummyArray;
        string difficulty;
        bool admin, help = false;

        public frmQuestionDropDown(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray, string Difficulty, bool Admin) : base (ThisUser)
        {
            InitializeComponent();
            thisUser = ThisUser;
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            difficulty = Difficulty;
            admin = Admin;
            if (Admin == true)
            {
                btnFinish.Text = ("Back to admin");
            }
            btnFinish.Visible = false;
            lblScore.Text = Convert.ToString(thisUser.Score);
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
            cbOne.Items.Add("arithmetic"); //Setting elements of the combo boxes
            cbOne.Items.Add("drawing");
            cbTwo.Items.Add("architecture");
            cbTwo.Items.Add("logic");
            cbThree.Items.Add("sound");
            cbThree.Items.Add("video");
            cbFour.Items.Add("speed");
            cbFour.Items.Add("graphics");
            cbFive.Items.Add("temporary");
            cbFive.Items.Add("permanent");
            cbSix.Items.Add("delete");
            cbSix.Items.Add("store");
            cbSeven.Items.Add("delete");
            cbSeven.Items.Add("store");
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

        private void btnSubmit_Click(object sender, EventArgs e) //Checking if the correct element was selected and will change the colour depending on if the answer was correct or incorrect
        {
            btnSubmit.Enabled = false;
            btnFinish.Visible = true;
            if (cbOne.SelectedIndex == 0)
            {
                cbOne.BackColor = Color.Green;
                thisUser.Score += 1;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                cbOne.BackColor = Color.Red;
            }
            if (cbTwo.SelectedIndex == 1)
            {
                cbTwo.BackColor = Color.Green;
                thisUser.Score += 1;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                cbTwo.BackColor = Color.Red;
            }
            if (cbThree.SelectedIndex == 1)
            {
                cbThree.BackColor = Color.Green;
                thisUser.Score += 1;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                cbThree.BackColor = Color.Red;
            }
            if (cbFour.SelectedIndex == 1)
            {
                cbFour.BackColor = Color.Green;
                thisUser.Score += 1;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                cbFour.BackColor = Color.Red;
            }
            if (cbFive.SelectedIndex == 0)
            {
                cbFive.BackColor = Color.Green;
                thisUser.Score += 1;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                cbFive.BackColor = Color.Red;
            }
            if (cbSix.SelectedIndex == 1)
            {
                cbSix.BackColor = Color.Green;
                thisUser.Score += 1;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                cbSix.BackColor = Color.Red;
            }
            if (cbSeven.SelectedIndex == 0)
            {
                cbSeven.BackColor = Color.Green;
                thisUser.Score += 1;
                lblScore.Text = Convert.ToString(thisUser.Score);
            }
            else
            {
                cbSeven.BackColor = Color.Red;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e) //Brings user to end screen
        {
            if (admin == true)
            {
                this.Close();
                new frmAdmin(thisUser, easyDummyArray, hardDummyArray).Show();
            }
            else
            {
                this.Close();
                new frmEndScreen(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
            }
        }

        private void cbOne_KeyPress(object sender, KeyPressEventArgs e) //Stops the user from typing in the combo box
        {
            e.Handled = true;
        }

        private void cbTwo_KeyPress(object sender, KeyPressEventArgs e) //Stops the user from typing in the combo box
        {
            e.Handled = true;
        }

        private void cbThree_KeyPress(object sender, KeyPressEventArgs e) //Stops the user from typing in the combo box
        {
            e.Handled = true;
        }

        private void cbFour_KeyPress(object sender, KeyPressEventArgs e) //Stops the user from typing in the combo box
        {
            e.Handled = true;
        }

        private void cbFive_KeyPress(object sender, KeyPressEventArgs e) //Stops the user from typing in the combo box
        {
            e.Handled = true;
        }

        private void cbSix_KeyPress(object sender, KeyPressEventArgs e) //Stops the user from typing in the combo box
        {
            e.Handled = true;
        }

        private void cbSeven_KeyPress(object sender, KeyPressEventArgs e) //Stops the user from typing in the combo box
        {
            e.Handled = true;
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
