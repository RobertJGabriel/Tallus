using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tallus3.Apps.Emails
{
    public partial class email_start : Form
    {
   Apps.Emails.EmailClient   ToyStory3;
   Launch.Emails.EmailClient2 ToyStory2;

        public email_start()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ToyStory3 = new Apps.Emails.EmailClient  ();
            ToyStory3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
         
        }

        private void email_start_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            ToyStory2 = new Launch.Emails.EmailClient2();
            ToyStory2.Show();
        }
    }
}
