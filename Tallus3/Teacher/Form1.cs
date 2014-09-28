using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tallus3.Teacher
{
    public partial class Form1 : Form
    {
        Apps.Emails.EmailClient ToyStory;
        Launch.Emails.EmailClient2 ToyStory2;
        Apps.Emails.email_start facebook;
        Background.Form1 BillGates2;
        Apps.Notes SawVI;
        Teacher.network Jaws2;
        Apps.Books.Books1 Jaws;

        Apps.Internett DarkKnight;
        Login ToyStory3;
        Teacher.users StepUp;
        public Form1()
        {
       
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel11.Left = (panel5.Width - panel11.Width) / 2;
            panel11.Top = (panel5.Height - panel11.Height) / 2;

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
         DarkKnight  = new Apps.Internett ();
         DarkKnight.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel19.Visible = true;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            SawVI = new Apps.Notes();
            SawVI.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            StepUp = new Teacher.users();
            StepUp.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Jaws2 = new Teacher.network();
            Jaws2.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            this.Close();
            ToyStory3 = new Login();
            ToyStory3.Show();
            BillGates2 = new Background.Form1();

            BillGates2.Close();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Hide();
            panel5.Show();
        }
        void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Hide();
            panel5.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label11.Text = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            Label12.Text = DateTime.Now.ToString(DateTime.Now.ToShortDateString());



            PowerStatus psBattery = SystemInformation.PowerStatus;
            float perFull = psBattery.BatteryLifePercent;
            //Show the remaining battery power in percentages
            label17.Text = (perFull * 100 + "%");
            //Is the battery charging?


            if (label17.Text == "100%")
            {
                pictureBox28.Image = Properties.Resources.battery100;

            }

            if (label17.Text == "80%")
            {
                pictureBox28.Image = Properties.Resources.battery80;

            }

            if (label17.Text == "60%")
            {
                pictureBox28.Image = Properties.Resources.battery60;

            }



            if (label17.Text == "20%")
            {
                pictureBox28.Image = Properties.Resources.battery20;

            }



            if (label17.Text == "5%")
            {
                pictureBox28.Image = Properties.Resources.battery00;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel5.Hide();
            pictureBox6.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
  
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
          
            panel19.Visible = false;
            ToyStory = new Apps.Emails.EmailClient();
            ToyStory.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            panel19.Visible = false;
            ToyStory2 = new Launch.Emails.EmailClient2();
            ToyStory2.Show();
        }
    }
}
