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
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* try
            {
                if (txtfn.Text != "" && txtln.Text != "" && txtbd.Text != "" && txtg.Text != "" && txta.Text != "" && txtt.Text != "" && txte.Text != "" && txtal.Text != "" &&
                    txtc.Text != "" && txts.Text != "")
                {

                    int v = check(txte.Text);
                    if (v != 1)
                    {
                        connection = new SqlConnection(connectionString);
                        connection.Open();
                        SqlCommand command = new SqlCommand("insert into tblstudent values(@f_name,@l_name,@b_day,@gender,@address,@tel,@email,@academic_level,@class,@subject,@note_end)", connection);
                        command.Parameters.AddWithValue("@f_name", txtfn.Text);
                        command.Parameters.AddWithValue("@l_name", txtln.Text);
                        command.Parameters.AddWithValue("@b_day", Convert.ToDateTime(txtbd.Text));
                        command.Parameters.AddWithValue("@gender", txtg.Text);
                        command.Parameters.AddWithValue("@address", txta.Text);
                        command.Parameters.AddWithValue("@tel", txtt.Text);
                        command.Parameters.AddWithValue("@email", txte.Text);
                        command.Parameters.AddWithValue("@academic_level", txtal.Text);
                        command.Parameters.AddWithValue("@class", txtc.Text);
                        command.Parameters.AddWithValue("@subject", txts.Text);
                        command.Parameters.AddWithValue("@f_point", txtgp.Text);

                        command.ExecuteScalar();
                        connection.Close();
                        MessageBox.Show("Register Succesfully!");
                        txtfn.Text = "";
                        txtln.Text = "";
                        txtg.Text = "";
                        txta.Text = "";
                        txtt.Text = "";
                        txte.Text = "";
                        txtal.Text = "";
                        txtc.Text = "";
                        txts.Text = "";
                        txtgp.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("You are already registered");
                    }


                }
                else
                {
                    MessageBox.Show("Fill in the blinks!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
/*        int check(string email)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select count(*) from tblstudent where email= '" + email + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }*/

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
