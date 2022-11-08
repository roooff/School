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
            x.Text = "";
            y.Text = "";
            Result.Text = "";
           
        }

        private void CalcSum_Click(object sender, EventArgs e)
        {
            int rezultat = 0, x, y;
            x = int.Parse(this.x.Text);
            y = int.Parse(this.y.Text); 
            switch (Char.Text)
            {
                case "+": rezultat = x + y; break;
                case "-": rezultat = x - y; break;
                case "*": rezultat = x * y; break;
                case "/": rezultat = x / y; break;
               
            }
            CalcSum.Text = rezultat.ToString();
        }
    }
}
