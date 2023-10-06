using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Template : Form
    {
        User thisUser;
        int[] easyDummyArray;
        int[] hardDummyArray;

        public Template()
        {
            InitializeComponent();
        }
        public Template(User ThisUser)
        {
            InitializeComponent();
            thisUser = ThisUser;
            lblDisplayUsername.Text = thisUser.Username;
            pbIcon.Image = thisUser.Icon;
        }
            public void Template_Load(object sender, EventArgs e)
        {
        }

        public void btnExit_Click(object sender, EventArgs e) //Confirmation message if the user clicks the exit button
        { 
            string message = "Are you sure you want to exit?\nUnsaved data will be lost\n(Data is only saved when the quiz is finished)";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgIcon_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e) //Confirmation message if the user clicks the logout button
        {
            string message = "Are you sure you want to log out?\nUnsaved data will be lost\n(Data is only saved when the quiz is finished)";
            string title = "Log out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons); 
            if (result == DialogResult.Yes)                                   
            {
                Form Form1 = new frmLogin(thisUser, easyDummyArray, hardDummyArray);
                this.Close();
                Form1.Show();
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
