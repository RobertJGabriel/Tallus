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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void studentsinformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsinformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);

        }

        private void users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Studentsinformation' table. You can move, or remove it, as needed.
            this.studentsinformationTableAdapter.Fill(this.tallusDatabaseDataSet.Studentsinformation);

        }
    }
}
