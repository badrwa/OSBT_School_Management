using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtsm_CheckedChanged(object sender, EventArgs e)
        {
            if (txtsm.Checked)
            {
                txtp.PasswordChar = '\0';


            }
            else
            {
                txtp.PasswordChar = '*';

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
/*            if (txte.Text != "" && txtp.Text != "")
            {

                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "select count(*) from tblregister where email= '" + txte.Text + "' and password='" + txtp.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                connection.Close();
                if (v != 1)
                {
                    MessageBox.Show("Error email or password", "Error!");
                }
                else
                {
                    //    MessageBox.Show("Welcome to your profile!");
                    new Home().Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Fill the blanks!");
            }*/
        }
    }
}
