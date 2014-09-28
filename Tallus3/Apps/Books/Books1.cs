using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tallus3.Apps.Books
{  

    public partial class Books1 : Form
    {
        Apps.Books.Books2 hollowman;
        public Books1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.points10 = "true";



        
     

            Properties.Settings.Default.unlockgood = "Books are super fun:) ";
            Properties.Settings.Default.scorebanner = "true";
            Properties.Settings.Default.Save();
            hollowman = new Apps.Books.Books2();
            hollowman.Show();
            hollowman.webBrowser1.Navigate("http://books.projectbird.com/files/theme/btyoung.html");
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.points101 = "true";
            Properties.Settings.Default.unlockgood = "Comics ???/ Its school time";
            Properties.Settings.Default.scorebanner = "true";
            Properties.Settings.Default.Save();
                hollowman = new Apps.Books.Books2();
           hollowman.Show();
           hollowman.webBrowser1.Navigate("http://books.projectbird.com/files/theme/comiccon.html");
           this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.points10 = "true";






            Properties.Settings.Default.unlockgood = "Books are super fun:) ";
            Properties.Settings.Default.scorebanner = "true";
            Properties.Settings.Default.Save();
            
            hollowman = new Apps.Books.Books2();
           hollowman.Show();
           hollowman.webBrowser1.Navigate("http://books.projectbird.com/files/theme/chemisty.html");
           this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {




            Properties.Settings.Default.points10 = "true";






            Properties.Settings.Default.unlockgood = "Books are super fun:) ";
            Properties.Settings.Default.scorebanner = "true";
            Properties.Settings.Default.Save();



            hollowman = new Apps.Books.Books2();
            hollowman.Show();
            hollowman.webBrowser1.Navigate("http://books.projectbird.com/files/theme/ScifestFlyer.html");
         
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {


            Properties.Settings.Default.points10 = "true";






            Properties.Settings.Default.unlockgood = "Books are super fun:) ";
            Properties.Settings.Default.scorebanner = "true";
            Properties.Settings.Default.Save();
            
            
            
            
            hollowman = new Apps.Books.Books2();
            hollowman.Show();
            hollowman.webBrowser1.Navigate("http://books.projectbird.com/files/theme/MUSICALNOTESSITR.html");
            this.Close();
        }
    }
}
