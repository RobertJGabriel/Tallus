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
    public partial class Notes : Form
    {
        Apps.Notes SawVI;
        public Notes()
        {
            InitializeComponent();
        }

   

        private void Notes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.TeacherInformation' table. You can move, or remove it, as needed.
            this.teacherInformationTableAdapter.Fill(this.tallusDatabaseDataSet.TeacherInformation);
       

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SawVI = new Apps.Notes();
       
            SawVI.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void teacherInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);

        }

      
    }
}
