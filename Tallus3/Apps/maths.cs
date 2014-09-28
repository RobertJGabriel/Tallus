using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using System.Collections;


namespace Tallus3.Apps
{
    public partial class maths : Form
    {
      
        public maths()
        {
            InitializeComponent();
      
        }
	private void cmd1_Click(System.Object sender, System.EventArgs e)
	{
	
}

    private void cmdMultiply_Click(object sender, EventArgs e)
    {
        Properties.Settings.Default.mathsnumber = "*";
        Properties.Settings.Default.Save();
    }

    private void cmdDivide_Click(object sender, EventArgs e)
    {
        Properties.Settings.Default.mathsnumber = "/";
        Properties.Settings.Default.Save();
    }

    private void cmdAdd_Click(object sender, EventArgs e)
    {
        Properties.Settings.Default.mathsnumber = "+";
        Properties.Settings.Default.Save();
    }

    private void cmdMinus_Click(object sender, EventArgs e)
    {
        Properties.Settings.Default.mathsnumber = "-";
        Properties.Settings.Default.Save();
    }

    private void cmdClear_Click(object sender, EventArgs e)
    {
        txtDisplay.Text = "0";

    }

    private void cmdEquals_Click(object sender, EventArgs e)
    {
        float a, b, r;
        a = Convert.ToInt32(textBox1.Text);
        b = Convert.ToInt32(textBox2.Text);
        r = a + b;

        txtDisplay.Text = r.ToString();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        label1.Text = Properties.Settings.Default.mathsnumber;





        if (txtDisplay.Text == "666")
        {
            Properties.Settings.Default.points101 = "true";
            Properties.Settings.Default.unlockgood = "The Devil????";

            Properties.Settings.Default.scorebanner = "true";

            Properties.Settings.Default.Save();

        }


        if (txtDisplay.Text == "23")
        {
            Properties.Settings.Default.points101 = "true";
            Properties.Settings.Default.unlockgood = "James Bond :)";

            Properties.Settings.Default.scorebanner = "true";

            Properties.Settings.Default.Save();

        }

        if (txtDisplay.Text == "1")
        {
            Properties.Settings.Default.points101 = "true";
            Properties.Settings.Default.unlockgood = "Winner";

            Properties.Settings.Default.scorebanner = "true";

            Properties.Settings.Default.Save();

        }



        if (txtDisplay.Text == "3")
        {
            Properties.Settings.Default.points101 = "true";
            Properties.Settings.Default.unlockgood = "Brock lenser lol";

            Properties.Settings.Default.scorebanner = "true";

            Properties.Settings.Default.Save();

        }








    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        float a, b, r;
        a = Convert.ToInt32(textBox1.Text);
        b = Convert.ToInt32(textBox2.Text);
        r = a - b;

        txtDisplay.Text = r.ToString();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        float a, b, r;
        a = Convert.ToInt32(textBox1.Text);
        b = Convert.ToInt32(textBox2.Text);
        r = a * b;

        txtDisplay.Text = r.ToString();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        float a, b, r;
        a = Convert.ToInt32(textBox1.Text);
        b = Convert.ToInt32(textBox2.Text);
        r = a / b;

        txtDisplay.Text = r.ToString();
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
        if (label1.Text == "+")
        {
            plus.Visible = true;
            x.Visible = false;
            divide.Visible = false;
            take.Visible = false;
        }
        if (label1.Text == "*")
        {
            plus.Visible = false;
            x.Visible = true;
            divide.Visible = false;
            take.Visible = false;
        }

        if (label1.Text == "/")
        {
           divide.Visible = true;
           plus.Visible = false;
          x.Visible = false;
           take.Visible = false;

        }

        if (label1.Text == "-")
        {
           take.Visible = true;
           divide.Visible = false;
           plus.Visible = false;
           x.Visible = false;
        }


    }

    private void maths_Load(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {
        Properties.Settings.Default.mathsnumber = "*";
        Properties.Settings.Default.Save();
    }

    private void label3_Click(object sender, EventArgs e)
    {
        Properties.Settings.Default.mathsnumber = "/";
        Properties.Settings.Default.Save();
    }

    private void label4_Click(object sender, EventArgs e)
    {
        Properties.Settings.Default.mathsnumber = "+";
        Properties.Settings.Default.Save();
    }

    private void label5_Click(object sender, EventArgs e)
    {
        Properties.Settings.Default.mathsnumber = "-";
        Properties.Settings.Default.Save();
    }

    private void label6_Click(object sender, EventArgs e)
    {
        txtDisplay.Text = "0";
        textBox1.Text = "0";
        textBox2.Text = "0";
    }

    private void label7_Click(object sender, EventArgs e)
    {
        float a, b, r;
        a = Convert.ToInt32(textBox1.Text);
        b = Convert.ToInt32(textBox2.Text);
        r = a / b;

        txtDisplay.Text = r.ToString();
    }

    private void label8_Click(object sender, EventArgs e)
    {
        float a, b, r;
        a = Convert.ToInt32(textBox1.Text);
        b = Convert.ToInt32(textBox2.Text);
        r = a * b;

        txtDisplay.Text = r.ToString();
    }

    private void label10_Click(object sender, EventArgs e)
    {

        float a, b, r;
        a = Convert.ToInt32(textBox1.Text);
        b = Convert.ToInt32(textBox2.Text);
        r = a + b;

        txtDisplay.Text = r.ToString();
    }

    private void label9_Click(object sender, EventArgs e)
    {
        float a, b, r;
        a = Convert.ToInt32(textBox1.Text);
        b = Convert.ToInt32(textBox2.Text);
        r = a - b;

        txtDisplay.Text = r.ToString();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label9_Click_1(object sender, EventArgs e)
    {
      
    }

    private void textBox2_Click(object sender, EventArgs e)
    {
        panel1.Visible = false;
        panel2.Visible = true;
        panel2.Location = panel1.Location;
    }

    private void label9_Click_2(object sender, EventArgs e)
    {
        textBox1.Text = textBox1.Text + 1;
      
    }

    private void label12_Click(object sender, EventArgs e)
    {
        textBox1.Text = textBox1.Text + 2;
    }

    private void label15_Click(object sender, EventArgs e)
    {
        textBox1.Text = textBox1.Text + 3;
    }

    private void label8_Click_1(object sender, EventArgs e)
    {
        textBox1.Text = textBox1.Text + 4;
    }

    private void label11_Click(object sender, EventArgs e)
    {
        textBox1.Text = textBox1.Text + 5;
    }

    private void label14_Click(object sender, EventArgs e)
    {
        textBox1.Text = textBox1.Text + 6;
    }

    private void label7_Click_1(object sender, EventArgs e)
    {
        textBox1.Text = textBox1.Text + 7;
    }

    private void label10_Click_1(object sender, EventArgs e)
    {
        textBox1.Text = textBox1.Text + 8;
    }

    private void label13_Click(object sender, EventArgs e)
    {
        textBox1.Text = textBox1.Text + 9;
    }

    private void label16_Click(object sender, EventArgs e)
    {
    
        textBox1.Text = textBox1.Text + 0;
    }

    private void label18_Click(object sender, EventArgs e)
    {
        textBox2.Text = textBox2.Text + 1;
      
    }

    private void label21_Click(object sender, EventArgs e)
    {
        textBox2.Text = textBox2.Text + 2;
      
    }

    private void label24_Click(object sender, EventArgs e)
    {
        textBox2.Text = textBox2.Text + 3;
      
    }

    private void label19_Click(object sender, EventArgs e)
    {
        textBox2.Text = textBox2.Text + 4;
      
    }

    private void label22_Click(object sender, EventArgs e)
    {
        textBox2.Text = textBox2.Text + 5;
      
    }

    private void label25_Click(object sender, EventArgs e)
    {
        textBox2.Text = textBox2.Text + 6;
      
    }

    private void label20_Click(object sender, EventArgs e)
    {
        textBox2.Text = textBox2.Text + 7;
      
    }

    private void label23_Click(object sender, EventArgs e)
    {
        textBox2.Text = textBox2.Text + 8;
      
    }

    private void label26_Click(object sender, EventArgs e)
    {
        textBox2.Text = textBox2.Text + 9;
      
    }

    private void label17_Click(object sender, EventArgs e)
    {
        textBox2.Text = textBox2.Text + 0;
      
    }

    private void textBox1_Click(object sender, EventArgs e)
    {
        panel1.Visible = true;
        panel2.Visible = false;
    }

    private void textBox2__Click(object sender, System.EventArgs e)
    {
        panel1.Visible = false;
        panel2.Visible = true;
        panel2.Location = panel1.Location;
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {

    }
    	}
}
    	
