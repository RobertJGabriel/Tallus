using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Diagnostics;
using System.Threading;



namespace Tallus3
{
    public partial class Login : Form
    {
      
        
        DataSet high = new DataSet();
   Launch.Form1     BillGates;
 Teacher.Form1   SteveJobs;
 Background.Form1 BillGates2;

  


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Close (object sender, EventArgs e)
        {
        
        }



        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);

     

 
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.TeacherInformation' table. You can move, or remove it, as needed.
            this.teacherInformationTableAdapter.Fill(this.tallusDatabaseDataSet.TeacherInformation);
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Icons_Control' table. You can move, or remove it, as needed.
            this.icons_ControlTableAdapter.Fill(this.tallusDatabaseDataSet.Icons_Control);
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Studentsinformation' table. You can move, or remove it, as needed.
            this.studentsinformationTableAdapter.Fill(this.tallusDatabaseDataSet.Studentsinformation);
            BillGates2 = new Background.Form1();

            BillGates2.Show();
  
            int hwnd = FindWindow("Shell_TrayWnd", "");
            ShowWindow(hwnd, SW_HIDE);



           panel3.Left = (this.Width - panel3.Width) / 2;
          panel3.Top = (this.Height - panel3.Height) / 2;

         
        }

        private void studentsinformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsinformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {
         
               dynamic login = this.studentsinformationTableAdapter.ScalarQuery(textBox1.Text, textBox2.Text);
            if (login == null)
            {   
                dynamic loginy = this.teacherInformationTableAdapter.ScalarQuery(textBox1.Text, textBox2.Text);
                 if (loginy == null)
            {



                MessageBox.Show("No Student Found");

              
 }
            else
            {
                SteveJobs = new Teacher.Form1();

               SteveJobs.Show();


                this.Hide();
   }
            }
            else
            {


                BillGates = new Launch.Form1 ();

                BillGates.Show();

         
                this.Hide();
        }


            string searchFor = textBox1.Text;
            int results = 0;
            DataRow[] returnedRows;



            returnedRows = tallusDatabaseDataSet.Tables["Studentsinformation"].Select("FirstName='" + searchFor + "'");
            results = returnedRows.Length;
            if (results > 0)
            {
                DataRow dr1;
                dr1 = returnedRows[0];
                Properties.Settings.Default.StudentNamefirst = (dr1["FirstName"].ToString());
                Properties.Settings.Default.StudentNamefirst = textBox1.Text;
                Properties.Settings.Default.StudentAge = (dr1["Age"].ToString());
                Properties.Settings.Default.StudentPoints = (dr1["Points"].ToString());


                Properties.Settings.Default.Save();
            }
            else
            {
      
            }
                }
         
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.icons_ControlTableAdapter.Fill(this.tallusDatabaseDataSet.Icons_Control);
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Studentsinformation' table. You can move, or remove it, as needed.
            this.studentsinformationTableAdapter.Fill(this.tallusDatabaseDataSet.Studentsinformation);
     
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void studentsinformationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
           protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
{
	if (keyData == (Keys.Alt | Keys.F4)) {
		return true;
	} else {
		return base.ProcessCmdKey(ref msg, keyData);
	}
    if  (keyData == (Keys.Escape ))
    {
        return true;
    }
    else
    {
        return base.ProcessCmdKey(ref msg, keyData);
    }
    if (keyData == (Keys.Alt | Keys.ControlKey | Keys.Delete ))
    {
        return true;
    }
    else
    {
        return base.ProcessCmdKey(ref msg, keyData);
    }
    if (keyData == (Keys.F10))
    {
       

      
    }


}


           private static void EnableTaskManager(bool enable)
  {
      Microsoft.Win32.RegistryKey HKCU = Microsoft.Win32.Registry.CurrentUser;
      Microsoft.Win32.RegistryKey key = HKCU.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
      key.SetValue("DisableTaskMgr", enable ? 0 : 1, Microsoft.Win32.RegistryValueKind.DWord);

    
           }

           private void pictureBox1_Click(object sender, EventArgs e)
           {
               BillGates2.Close();
               int hwnd = FindWindow("Shell_TrayWnd", "");
               ShowWindow(hwnd, SW_SHOW);

               this.Close();

           }

           private void panel3_Paint(object sender, PaintEventArgs e)
           {

           }

           private void panel4_Paint(object sender, PaintEventArgs e)
           {
         
           }

           private void timer3_Tick(object sender, EventArgs e)


           {
               panel3.Left = (this.Width - panel3.Width) / 2;
               panel3.Top = (this.Height - panel3.Height) / 2;
               Rectangle r = new Rectangle(0, 0, panel1.Width, panel1.Height);
               System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
               int d = 20;
               gp.AddArc(r.X, r.Y, d, d, 180, 90);
               gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
               gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
               gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
               panel1.Region = new Region(gp);
           }

           private void panel5_Paint(object sender, PaintEventArgs e)
           {

           }

           private void pictureBox2_Click(object sender, EventArgs e)
           {
               Process.Start("shutdown.exe", "-s");
           }

           private void button1_Click_1(object sender, EventArgs e)
           {

           }
          }
           }
    


    
     