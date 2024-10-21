using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSystem_test_02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Mainform_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void Performace_btn_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = true;
            addEmployeeForm1.Visible = false;
            salaryForm1.Visible = false;

            DashBoard dashForm = dashBoard1 as DashBoard;

            if (dashForm != null)
            {
                dashForm.RefreshData();
            }
        }

        private void Add_employee_btn_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addEmployeeForm1.Visible = true;
            salaryForm1.Visible = false;

            AddEmployeeForm addEmForm = addEmployeeForm1 as AddEmployeeForm;

            if (addEmForm != null)
            {
                addEmForm.RefreshData();
            }
        }

        private void Salary_btn_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addEmployeeForm1.Visible = false;
            salaryForm1.Visible = true;

            SalaryForm salaryForm = salaryForm1 as SalaryForm;

            if (salaryForm != null)
            {
                salaryForm.RefreshData();
            }
        }

        private void dashBoard1_Load(object sender, EventArgs e)
        {

        }
    }
}
