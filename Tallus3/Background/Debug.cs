using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tallus3.Background
{
    public partial class Debug : Form
    {
        public Debug()
        {
            InitializeComponent();
        }

        private void studentsinformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsinformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);

        }

        private void Debug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Studentsinformation' table. You can move, or remove it, as needed.
            this.studentsinformationTableAdapter.Fill(this.tallusDatabaseDataSet.Studentsinformation);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Studentsinformation' table. You can move, or remove it, as needed.
            this.studentsinformationTableAdapter.Fill(this.tallusDatabaseDataSet.Studentsinformation);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        
         
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.studentsinformationTableAdapter.Fill(this.tallusDatabaseDataSet.Studentsinformation);
        }
    }
}
