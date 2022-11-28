using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class Figures : Form
    {
        public Figures()
        {
            InitializeComponent();
        }

        private void Square_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Figures.ActiveForm.Close();
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Square_Click(object sender, EventArgs e)
        {
            textBoxA.Visible = true; labelA.Visible = true;
            textBoxB.Visible = false; labelB.Visible = false;
            textBoxC.Visible = false; labelC.Visible = false;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            textBoxA.Visible = true; labelA.Visible = true;
            textBoxB.Visible = true; labelB.Visible = true;
            textBoxC.Visible = false; labelC.Visible = false;
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            textBoxA.Visible = true; labelA.Visible = true;
            textBoxB.Visible = true; labelB.Visible = true;
            textBoxC.Visible = true; labelC.Visible = true;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int a, b, c;
            try
            {
                a = int.Parse(textBoxA.Text);
            }
            catch (FormatException)
            {
                a = 0;
                textBoxA.Text = "0";
            }
            try
            {
                b = int.Parse(textBoxB.Text);
            }
            catch (FormatException)
            {
                b = 0;
                textBoxB.Text = "0";
                
            }
            try
            {
                c = int.Parse(textBoxC.Text);
            }
            catch (FormatException)
            {
                c = 0;
                textBoxC.Text = "0";
            }
            double S, P, p;
            if (Square.Checked)
            {
                S = a * a;
                P = 4 * a;
                Perimeter.Text = P.ToString();
                Face.Text = S.ToString();
            }
            else if (Rectangle.Checked)
            {
                S = a * b; 
                P = 2 * (a + b);
                Perimeter.Text = P.ToString();
                Face.Text = S.ToString();
            }
            else
            {
                P = a + b + c; p = P / 2;
                S=Math.Sqrt(p*(p-a)*(p-b) * (p-c));
                Perimeter.Text = P.ToString();
                Face.Text = S.ToString();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
            Perimeter.Text = "0";
            Face.Text = "0";
            textBoxA.Focus();

        }
    }
}
