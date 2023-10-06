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
    public partial class frmSplash : Form
    {
        User thisUser;
        int[] easyDummyArray;
        int[] hardDummyArray;

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        public frmSplash() //Starts the timer
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) //Will begin to fill the progress bar
        {
            pbrSplash.Value += 5;
            if (pbrSplash.Value >= 100)
            {
                timer1.Stop();
                this.Hide();
                new frmLogin(thisUser, easyDummyArray, hardDummyArray).Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
