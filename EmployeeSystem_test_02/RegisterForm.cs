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
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Documents\employeeTest02.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Register_password.PasswordChar = Register_ShowPass.Checked ? '\0':  '*';
            Register_Confirm_Pass.PasswordChar = Register_ShowPass.Checked ? '\0' : '*';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (Resgister_username.Text == ""
                || Register_password.Text == "" 
                || Register_Confirm_Pass.Text == ""
                )
            {
                MessageBox.Show("Please fill all blank fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (Register_Confirm_Pass.Text != Register_password.Text)
                {
                    MessageBox.Show("Password does not match!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            else
                {
                    if (connect.State != ConnectionState.Open) 
                    {
                        try
                        {
                            connect.Open();
                        // Check if the username is taken already
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", Resgister_username.Text.Trim());
                            int count = (int) checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(Resgister_username.Text.Trim() +"is already taken ",
                                    "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO users"
                                    + "(username, password, date_register)"
                                    + "VALUES(@username, @password, @dateReg)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", Resgister_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", Register_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered succesfully!",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoginForm loginForm = new LoginForm();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }

                            
                        } catch(Exception ex)
                        {
                            MessageBox.Show("Error: " + ex,
                                 "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
        }
    }
}
