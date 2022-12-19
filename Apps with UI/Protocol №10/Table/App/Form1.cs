using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBttn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con =
                new SqlConnection("Data Source=DESKTOP-UVGJIEG;Initial Catalog=SystemPersonInfo;Integrated Security=True"))
            {
                string sqlQuery = "insert into dbo.Persons (FirstName,LastName,ModifiedDate)" +
                      " values (@FirstName,@LastName,@ModifiedDate)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", lastName.Text);
                    cmd.Parameters.AddWithValue("@ModifiedDate", date.Text);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if (i != 0)
                    {
                        MessageBox.Show(i + "Data Saved");
                    }
                }
            }
        }
    }
}
