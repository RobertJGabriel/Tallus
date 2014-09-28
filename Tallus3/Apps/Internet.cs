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
    public partial class Internett : Form
    {
    
        public Internett()
        {
            InitializeComponent();
        }

        

    

        private void Internet_Load(object sender, EventArgs e)
        {
            WebBrowser Browse = new WebBrowser();

            tabControl1.TabPages.Add("Page");
            tabControl1.SelectedTab.Controls.Add(Browse);

            Browse.Name = "wb";
            Browse.Dock = DockStyle.Fill;


            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Properties.Settings.Default.internethome);
      

            Browse.DocumentCompleted += done;
          
        }

      
      
        private void done(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {

            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
            TextBox1.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

          

            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Properties.Settings.Default.internethome );
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = Properties.Settings.Default.StudentPoints;
        }
        int @int = 1;
        private void pictureBox7_Click(object sender, EventArgs e)
        {
               
    
        
            WebBrowser Browse = new WebBrowser();
            
            tabControl1.TabPages.Add("Page");
            tabControl1.SelectTab(@int);
        
            Browse.Name ="wb";
            Browse.Dock = DockStyle.Fill;
            tabControl1.SelectedTab.Controls.Add(Browse );
        @int = @int + 1;
        ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Properties.Settings.Default.internethome);
      

        Browse.DocumentCompleted += done ;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Hide();
        }
           float a, b, r;
        private void timer3_Tick(object sender, EventArgs e)
        {

            if (TextBox1.Text == "http://www.facebook.com/pages/create.php?campaign_id=372931622610&placement=pghm&extra_1=0")
            {


                Properties.Settings.Default.points101 = "true";

                Properties.Settings.Default.unlockgood = "Did you have to go on facebook?";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Properties.Settings.Default.internethome);

            }


            if (TextBox1.Text == "http://www.facebook.com/find-friends/")
            {


                Properties.Settings.Default.points101 = "true";

                Properties.Settings.Default.unlockgood = "Did you have to go on facebook?";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Properties.Settings.Default.internethome);

            }



            if (TextBox1.Text == "http://www.facebook.com/login.php")
            {


                Properties.Settings.Default.points101 = "true";

                Properties.Settings.Default.unlockgood = "Did you have to go on facebook?";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Properties.Settings.Default.internethome);

            }














            if (TextBox1.Text == "http://www.hidemenow.cz.cc/")
            {


                Properties.Settings.Default.points101 = "true";
         
                Properties.Settings.Default.unlockgood = "Why,why why ";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Properties.Settings.Default.internethome);
      
            }
            if (TextBox1.Text  == "http://www.bebo.com/")
            {
                Properties.Settings.Default.points101  = "true";
                Properties.Settings.Default.unlockgood  = "Did You Need to go bebo? ";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Properties.Settings.Default.internethome);
            }
            if (TextBox1.Text == "http://twitter.com/")
            {
                Properties.Settings.Default.points101 = "true";
                Properties.Settings.Default.unlockgood = "Your follows can wait:)";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Properties.Settings.Default.internethome);
            }

            if (TextBox1.Text == "http://www.facebook.com/")
            {
                Properties.Settings.Default.points101 = "true";
                Properties.Settings.Default.unlockgood = "Did you have to go on facebook?";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Properties.Settings.Default.internethome);
            }
            if (TextBox1.Text == "http://www.myspace.com/")
            {


                Properties.Settings.Default.points101 = "true";
                Properties.Settings.Default.unlockgood = "Did You Need to go myspace? ";

                Properties.Settings.Default.scorebanner = "true";

                Properties.Settings.Default.Save();




                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Properties.Settings.Default.internethome);
            }
}

        private void timer4_Tick(object sender, EventArgs e)
        {

            if (TextBox1.Text == "http://www.engadget.com/")
            {

                Properties.Settings.Default.points10 = "True";



                Properties.Settings.Default.unlockgood = "Gadets....yum!!!!!!!!!";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                timer4.Stop();
            }













            if (TextBox1.Text == "http://news.google.com/")
            {

                Properties.Settings.Default.points10 = "true";



                Properties.Settings.Default.unlockgood = "News!!!!!!!";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                timer4.Stop();
            }



















            if (TextBox1.Text == "http://www.funbrain.com/")
            {

                Properties.Settings.Default.points10 = "true";



                Properties.Settings.Default.unlockgood = "Fun Brain..woooooooo";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                timer4.Stop();
            }


















            if (TextBox1.Text == "http://www.cit.ie/")
            {

                Properties.Settings.Default.points10 = "true";



                Properties.Settings.Default.unlockgood = "Cit next leader i hope so:) ";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                timer4.Stop();
            }
            if (TextBox1.Text == "http://www.smgsblarney.ie/")
            {

                Properties.Settings.Default.points10 = "true";



                Properties.Settings.Default.unlockgood = "Ilove this school";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                timer4.Stop();
            }
            if (TextBox1.Text == "http://www.skoool.ie/")
            {

                Properties.Settings.Default.points10 = "true";



                Properties.Settings.Default.unlockgood = "Skoooooooooooool:)";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                timer4.Stop();
            }
            if (TextBox1.Text == "http://www.btyoungscientist.ie/")
            {

                timer4.Start();
                a = Convert.ToInt32(label1.Text);
                b = Convert.ToInt32(10);
                r = a + b;
                label1.Text = r.ToString();

                Properties.Settings.Default.points2 = label1.Text;

                Properties.Settings.Default.points2 = (label1.Text);



                Properties.Settings.Default.unlockgood = "Young Scientist,can you find any ideas? ";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                timer4.Stop();
            }
            if (TextBox1.Text == "http://www.btyoungscientist.com/downloads/2011-qualified-all.pdf")
            {
                timer4.Start();

                a = Convert.ToInt32(label1.Text);
                b = Convert.ToInt32(10);
                r = a + b;
                label1.Text = r.ToString();

                Properties.Settings.Default.points2 = label1.Text;

                Properties.Settings.Default.points2 = (label1.Text);



                Properties.Settings.Default.unlockgood = "Great ,Can you think of any better ideas? ";
                Properties.Settings.Default.scorebanner = "true";
                Properties.Settings.Default.Save();
                timer4.Stop();
        }
}

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            panel2.Hide();

        }
    }
}
