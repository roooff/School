using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transfering_from_one_to_another_form_and_out
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
            this.Hide();

        }
    }
}
