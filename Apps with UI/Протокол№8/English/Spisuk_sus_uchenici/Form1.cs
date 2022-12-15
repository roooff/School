using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spisuk_sus_uchenici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (textInput.Text !="0")
            {
                int index = listBox1.FindString(textInput.Text, -1);
                if (index<0)
                {
                    listBox1.Items.Add(textInput.Text);
                }
                else
                {
                    MessageBox.Show("Елементът се повтаря!");
                }
                textInput.Text = "";
            }
            textInput.Focus();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cmdAdd_Click(sender, e);
            }
        }
    }
}
