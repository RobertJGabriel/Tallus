using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tallus3.Launch
{
    public partial class Form2 : Form
    {
Login   facebook;
        public Form2()
        {
         
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


            string connectionString = Properties.Settings.Default.UserConnectionString;
            Properties.Settings.Default.UserConnectionString = label4.Text + label5.Text + label6.Text ;
            Properties.Settings.Default.Save();


            openFileDialog1.ShowDialog();
            label5.Text = openFileDialog1.FileName;
            //get the value of SavedSetting1 which is a string  

            label2.Text = label4.Text + label5.Text + label6.Text;
          
        }






        















           private void label1_DoubleClick(object sender, EventArgs e)
        {
          
        }
        private void label3_Click(object sender, EventArgs e)
        {
            facebook = new Login();
            facebook.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = label2.Text;
        }
    }

}

