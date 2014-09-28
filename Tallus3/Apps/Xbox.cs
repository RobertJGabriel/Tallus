using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tallus3.Apps
{
    public partial class Xbox : Form
    {
        public Xbox()
        {
            InitializeComponent();
        }
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
        
        }

        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //If drag is set to true then move the form accordingly.
         
        }

        private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
                   //Sets drag to false, so the form does not move according to the code in MouseMove
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            WebBrowser1.Navigate(TextBox2.Text + TextBox1.Text + TextBox3.Text);
            WebBrowser2.Navigate(TextBox9.Text + TextBox1.Text + TextBox8.Text);

        }

        private void Xbox_Load(System.Object sender, System.EventArgs e)
        {
            this.TopMost = true;
        }


        private void WebBrowser1_DocumentCompleted(System.Object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {
        }


        private void Panel3_Click(object sender, System.EventArgs e)
        {
            WebBrowser1.Navigate(TextBox2.Text + TextBox1.Text + TextBox3.Text);
            WebBrowser2.Navigate(TextBox9.Text + TextBox1.Text + TextBox8.Text);
        }


        private void Label1_Click(System.Object sender, System.EventArgs e)
        {
            Panel2.Show();
        }


        private void Panel3_Paint(System.Object sender, System.Windows.Forms.PaintEventArgs e)
        {
        }


        private void gamesforwindows_Load(System.Object sender, System.EventArgs e)
        {
        }


        private void gamesforwindows_MouseLeave(object sender, System.EventArgs e)
        {
            this.Close();

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {
            Panel2.Show();
        }

        private void Panel3_Paint_1(object sender, PaintEventArgs e)
        {
     
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WebBrowser1.Navigate(TextBox2.Text + TextBox1.Text + TextBox3.Text);
            WebBrowser2.Navigate(TextBox9.Text + TextBox1.Text + TextBox8.Text);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Panel2.Hide();

        }

    
    }
}
