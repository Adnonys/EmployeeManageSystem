namespace EmployeeSystem_test_02
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Mainform_exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Performace_btn = new System.Windows.Forms.Button();
            this.Salary_btn = new System.Windows.Forms.Button();
            this.Add_employee_btn = new System.Windows.Forms.Button();
            this.wellcome_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashBoard1 = new EmployeeSystem_test_02.DashBoard();
            this.addEmployeeForm1 = new EmployeeSystem_test_02.AddEmployeeForm();
            this.salaryForm1 = new EmployeeSystem_test_02.SalaryForm();
            this.panel_top.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.Mainform_exit);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1084, 36);
            this.panel_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phat\'s Employee Management System";
            // 
            // Mainform_exit
            // 
            this.Mainform_exit.AutoSize = true;
            this.Mainform_exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainform_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mainform_exit.Location = new System.Drawing.Point(1058, 9);
            this.Mainform_exit.Name = "Mainform_exit";
            this.Mainform_exit.Size = new System.Drawing.Size(16, 16);
            this.Mainform_exit.TabIndex = 1;
            this.Mainform_exit.Text = "X";
            this.Mainform_exit.Click += new System.EventHandler(this.Mainform_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.Dashboard_btn);
            this.panel1.Controls.Add(this.Logout_btn);
            this.panel1.Controls.Add(this.Performace_btn);
            this.panel1.Controls.Add(this.Salary_btn);
            this.panel1.Controls.Add(this.Add_employee_btn);
            this.panel1.Controls.Add(this.wellcome_user);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 525);
            this.panel1.TabIndex = 1;
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dashboard_btn.Location = new System.Drawing.Point(12, 223);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(195, 38);
            this.Dashboard_btn.TabIndex = 10;
            this.Dashboard_btn.Text = "DASHBOARD";
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Location = new System.Drawing.Point(3, 500);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(51, 22);
            this.Logout_btn.TabIndex = 9;
            this.Logout_btn.Text = "LogOut";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Performace_btn
            // 
            this.Performace_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Performace_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Performace_btn.Location = new System.Drawing.Point(12, 392);
            this.Performace_btn.Name = "Performace_btn";
            this.Performace_btn.Size = new System.Drawing.Size(195, 38);
            this.Performace_btn.TabIndex = 8;
            this.Performace_btn.Text = "PERFORMANCE";
            this.Performace_btn.UseVisualStyleBackColor = true;
            this.Performace_btn.Click += new System.EventHandler(this.Performace_btn_Click);
            // 
            // Salary_btn
            // 
            this.Salary_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salary_btn.Location = new System.Drawing.Point(12, 338);
            this.Salary_btn.Name = "Salary_btn";
            this.Salary_btn.Size = new System.Drawing.Size(195, 38);
            this.Salary_btn.TabIndex = 7;
            this.Salary_btn.Text = "SALARY";
            this.Salary_btn.UseVisualStyleBackColor = true;
            this.Salary_btn.Click += new System.EventHandler(this.Salary_btn_Click);
            // 
            // Add_employee_btn
            // 
            this.Add_employee_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_employee_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_employee_btn.Location = new System.Drawing.Point(12, 280);
            this.Add_employee_btn.Name = "Add_employee_btn";
            this.Add_employee_btn.Size = new System.Drawing.Size(195, 38);
            this.Add_employee_btn.TabIndex = 6;
            this.Add_employee_btn.Text = "ADD EMPLOYEE";
            this.Add_employee_btn.UseVisualStyleBackColor = true;
            this.Add_employee_btn.Click += new System.EventHandler(this.Add_employee_btn_Click);
            // 
            // wellcome_user
            // 
            this.wellcome_user.AutoSize = true;
            this.wellcome_user.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wellcome_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wellcome_user.Location = new System.Drawing.Point(48, 182);
            this.wellcome_user.Name = "wellcome_user";
            this.wellcome_user.Size = new System.Drawing.Size(120, 18);
            this.wellcome_user.TabIndex = 4;
            this.wellcome_user.Text = "Wellcome users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::EmployeeSystem_test_02.Properties.Resources.icons8_employee_card_100px;
            this.pictureBox1.Location = new System.Drawing.Point(51, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashBoard1
            // 
            this.dashBoard1.Location = new System.Drawing.Point(227, 49);
            this.dashBoard1.Name = "dashBoard1";
            this.dashBoard1.Size = new System.Drawing.Size(858, 500);
            this.dashBoard1.TabIndex = 4;
            this.dashBoard1.Load += new System.EventHandler(this.dashBoard1_Load);
            // 
            // addEmployeeForm1
            // 
            this.addEmployeeForm1.Location = new System.Drawing.Point(226, 42);
            this.addEmployeeForm1.Name = "addEmployeeForm1";
            this.addEmployeeForm1.Size = new System.Drawing.Size(858, 500);
            this.addEmployeeForm1.TabIndex = 3;
            // 
            // salaryForm1
            // 
            this.salaryForm1.AccessibleName = "salary_empoyeeID";
            this.salaryForm1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryForm1.Location = new System.Drawing.Point(227, 42);
            this.salaryForm1.Margin = new System.Windows.Forms.Padding(4);
            this.salaryForm1.Name = "salaryForm1";
            this.salaryForm1.Size = new System.Drawing.Size(858, 500);
            this.salaryForm1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.dashBoard1);
            this.Controls.Add(this.addEmployeeForm1);
            this.Controls.Add(this.salaryForm1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label Mainform_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label wellcome_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Performace_btn;
        private System.Windows.Forms.Button Salary_btn;
        private System.Windows.Forms.Button Add_employee_btn;
        private SalaryForm salaryForm1;
        private AddEmployeeForm addEmployeeForm1;
        private DashBoard dashBoard1;
        private System.Windows.Forms.Button Dashboard_btn;
    }
}