using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Transfering_from_one_to_another_form_and_out
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
       /// <summary> About Closing Active Forms ...
       /// If we close Form 2 the program still will be active so we make some instructions 
       /// Variant 1:
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        ///Variant 2:
        // protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //Environment.Exit( 0 );
        //}
        ///


        ///<summary> Transfering to Other Forms
        ///We want to transfer to another form and exit the current one:
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.Show();
            this.Close();
        }
        ///<summary>About Closing buttons :
        ///Making a new button "Exit" -> Application.Exit():
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        ///</summary>
    }
}
