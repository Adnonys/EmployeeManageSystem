using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeSystem_test_02
{
    public partial class LoginForm : Form
    {
        // SQL server connection
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Documents\employeeTest02.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        /// <summary>
        ///
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LogIn_Username.Text == ""
                || LogIn_Pass.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        // access Sql Server
                        connect.Open();

                        // Functions
                        string selectData = "SELECT COUNT(1) FROM users WHERE username = @username AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", LogIn_Username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", LogIn_Pass.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                             //   MessageBox.Show("Login successfully!",
                             //       "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             MainForm mainform = new MainForm();
                                mainform.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username or password, please login again", 
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                            
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex, "Error Message"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Pass_CheckedChanged(object sender, EventArgs e)
        {
            LogIn_Pass.PasswordChar = Show_Pass.Checked ? '\0' : '*';
        }
    }
}
