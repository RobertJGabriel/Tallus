using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tallus3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentsinformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsinformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Studentsinformation' table. You can move, or remove it, as needed.
            this.studentsinformationTableAdapter.Fill(this.tallusDatabaseDataSet.Studentsinformation);

        }
    }
}
