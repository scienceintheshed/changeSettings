using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changeSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.val1 = txtValue1.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValue1.Text = Properties.Settings.Default.val1;
            txtValue2.Text = Properties.Settings.Default.val2;
        }
    }
}
