using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int a = num / 1000;
            int b = num / 100;
            int c = num / 10;
            label2.Text = "Числото става" + c.ToString() + b.ToString() + c.ToString(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
