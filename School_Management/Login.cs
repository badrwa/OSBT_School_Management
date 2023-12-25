using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=OSBT Management;Integrated Security=True";
        SqlConnection connection;
        SqlCommand Command;



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
            if (txte.Text != "" && txtp.Text != "")
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Use a SELECT statement to retrieve the id based on email and password
                    string query = "SELECT id FROM tblregister WHERE email = @email AND password = @password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", txte.Text);
                    command.Parameters.AddWithValue("@password", txtp.Text);

                    // ExecuteScalar to retrieve the id
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int id = (int)result;

                        // Close the connection after retrieving the id
                        connection.Close();

                        Class.Show(id);

                        // MessageBox.Show("Welcome to your profile!");
                        new Home().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password", "Error!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill the blanks!");
            }
        }
    }
}
