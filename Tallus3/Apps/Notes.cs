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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e)
        {

        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.SelectAll();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Copy();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Cut();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Paste();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Undo();
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
        }

        private void ClearUndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.ClearUndo();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog FS = new FontDialog();
            try
            {
                FS.ShowDialog();
                TextBox1.Font = FS.Font;
            }
            catch (Exception ex)
            {
                //Do nothing on exeption
            }
        }

        private void BackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog FC = new ColorDialog();
            try
            {
                FC.ShowDialog();
                TextBox1.ForeColor = FC.Color;
            }
            catch (Exception ex)
            {
                //Again, do nothing on exception
            }
        }

        private void KeyBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk");
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
        }
        private void OpenToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.points101 = "true";
            Properties.Settings.Default.unlockgood = "Stop It!!:( ";

            Properties.Settings.Default.scorebanner = "true";

            Properties.Settings.Default.Save();
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.points10 = "true";



            Properties.Settings.Default.unlockgood = "Open,Open,Open:)";
            Properties.Settings.Default.scorebanner = "true";
            Properties.Settings.Default.Save();
    

            string alltext = "";
            string lineoftext = null;
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                try
                {
                   
                  
                    {
                  
                    }
                    TextBox1.Text = alltext;
                }
                catch
                {
                }
                finally
                {
                      
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.Filter = "txt (*.txt) |*.txt";
            savefiledialog1.ShowDialog();
            if (!string.IsNullOrEmpty(savefiledialog1.FileName))
            {
             
            }
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog AB = new PrintDialog();
try {
	AB.ShowDialog();
  
} catch (Exception ex) {
	//Again, do nothing on exception
}
        }
    }
}
