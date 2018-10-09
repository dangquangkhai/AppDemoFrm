using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppDemoFrm
{
    public partial class sFrmMain : Form
    {
        public sFrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.ToString() != null && textBox2.ToString() != null)
            {
                int a = Convert.ToInt32(textBox1.ToString());
                int b = Convert.ToInt32(textBox2.ToString());
            }

        }
    }
}
