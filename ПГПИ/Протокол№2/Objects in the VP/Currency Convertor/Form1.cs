using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedItem = "EUR";
        }
        private void ConvertCurrency()
        {
            var originalAmount = this.numericUpDown1.Value;
            var convertedAmount = originalAmount;
            if (this.comboBox1.SelectedItem.ToString() == "EUR")
            {
                convertedAmount = originalAmount / 1.95583m;
            }
            else if (this.comboBox1.SelectedItem.ToString()=="USD")
            {
                convertedAmount = originalAmount / 1.97m;
            }
            else if (this.comboBox1.SelectedItem.ToString()=="GBP")
            {
                convertedAmount = originalAmount / 2.27m;
            }
            this.label2.Text = originalAmount + " лв. = " +
                Math.Round(convertedAmount, 2) + " " + this.comboBox1.SelectedItem;

        }
    }
}
