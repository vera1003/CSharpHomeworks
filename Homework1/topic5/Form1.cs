using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string t = textBox2.Text;
            int a = Int32.Parse(s);
            int b = Int32.Parse(t);
            a = a * b;
            s = Convert.ToString(a);
            label1.Text = s;
        }
    }
}
