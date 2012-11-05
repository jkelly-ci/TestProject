using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("This is a test about branching.");
                MessageBox.Show("This is a second test about branching.");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Disconnect();
            }
            

        }
    }
}
