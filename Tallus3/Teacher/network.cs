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
    public partial class network : Form
    {
        public network()
        {
            InitializeComponent();
        }

        private void icons_ControlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.icons_ControlBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallusDatabaseDataSet);

        }

        private void network_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallusDatabaseDataSet.Icons_Control' table. You can move, or remove it, as needed.
            this.icons_ControlTableAdapter.Fill(this.tallusDatabaseDataSet.Icons_Control);

        }
    }
}
