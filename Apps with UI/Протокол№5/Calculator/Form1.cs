using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void CalcSum_Click(object sender, EventArgs e)
        {
            int result = 0, x, y;
            x = int.Parse(FirstNum.Text);
            y = int.Parse(SecnuM.Text);
            switch (label1Sight.Text)
            {
                case "+": result = x + y; break;
                case "-": result = x - y; break;
                case "*": result = x * y; break;
                case "/": result = x / y; break;
                default:
                    { labelBug.Font = new Font(labelBug.Font, FontStyle.Bold); MessageBox.Show(labelBug.Text); break; }
            }
            textBox3Sum.Text = rezultat.ToString();

        }

        private void Char_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
