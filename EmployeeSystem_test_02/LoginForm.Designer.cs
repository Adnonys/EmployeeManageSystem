namespace EmployeeSystem_test_02
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo_App = new System.Windows.Forms.PictureBox();
            this.EmployeeManagementSysTem = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.Registeryouraccount = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoginAccount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LogIn_Username = new System.Windows.Forms.TextBox();
            this.LogIn_Pass = new System.Windows.Forms.TextBox();
            this.Show_Pass = new System.Windows.Forms.CheckBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_App)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Logo_App);
            this.panel1.Controls.Add(this.EmployeeManagementSysTem);
            this.panel1.Controls.Add(this.RegisterBtn);
            this.panel1.Controls.Add(this.Registeryouraccount);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 545);
            this.panel1.TabIndex = 1;
            // 
            // Logo_App
            // 
            this.Logo_App.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo_App.Image = ((System.Drawing.Image)(resources.GetObject("Logo_App.Image")));
            this.Logo_App.Location = new System.Drawing.Point(99, 98);
            this.Logo_App.Name = "Logo_App";
            this.Logo_App.Size = new System.Drawing.Size(121, 115);
            this.Logo_App.TabIndex = 12;
            this.Logo_App.TabStop = false;
            // 
            // EmployeeManagementSysTem
            // 
            this.EmployeeManagementSysTem.AutoSize = true;
            this.EmployeeManagementSysTem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeManagementSysTem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EmployeeManagementSysTem.Location = new System.Drawing.Point(3, 216);
            this.EmployeeManagementSysTem.Name = "EmployeeManagementSysTem";
            this.EmployeeManagementSysTem.Size = new System.Drawing.Size(324, 24);
            this.EmployeeManagementSysTem.TabIndex = 11;
            this.EmployeeManagementSysTem.Text = "Employee Management System";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(36, 488);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(270, 33);
            this.RegisterBtn.TabIndex = 10;
            this.RegisterBtn.Text = "Register Now";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // Registeryouraccount
            // 
            this.Registeryouraccount.AutoSize = true;
            this.Registeryouraccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registeryouraccount.ForeColor = System.Drawing.SystemColors.Control;
            this.Registeryouraccount.Location = new System.Drawing.Point(67, 450);
            this.Registeryouraccount.Name = "Registeryouraccount";
            this.Registeryouraccount.Size = new System.Drawing.Size(216, 22);
            this.Registeryouraccount.TabIndex = 0;
            this.Registeryouraccount.Text = "Register Your Account";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginAccount
            // 
            this.LoginAccount.AutoSize = true;
            this.LoginAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAccount.Location = new System.Drawing.Point(369, 133);
            this.LoginAccount.Name = "LoginAccount";
            this.LoginAccount.Size = new System.Drawing.Size(158, 24);
            this.LoginAccount.TabIndex = 3;
            this.LoginAccount.Text = "Login Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // LogIn_Username
            // 
            this.LogIn_Username.Location = new System.Drawing.Point(372, 208);
            this.LogIn_Username.Name = "LogIn_Username";
            this.LogIn_Username.Size = new System.Drawing.Size(275, 20);
            this.LogIn_Username.TabIndex = 6;
            this.LogIn_Username.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LogIn_Pass
            // 
            this.LogIn_Pass.Location = new System.Drawing.Point(372, 271);
            this.LogIn_Pass.Name = "LogIn_Pass";
            this.LogIn_Pass.PasswordChar = '*';
            this.LogIn_Pass.Size = new System.Drawing.Size(275, 20);
            this.LogIn_Pass.TabIndex = 7;
            // 
            // Show_Pass
            // 
            this.Show_Pass.AutoSize = true;
            this.Show_Pass.Location = new System.Drawing.Point(560, 297);
            this.Show_Pass.Name = "Show_Pass";
            this.Show_Pass.Size = new System.Drawing.Size(102, 17);
            this.Show_Pass.TabIndex = 8;
            this.Show_Pass.Text = "Show Password";
            this.Show_Pass.UseVisualStyleBackColor = true;
            this.Show_Pass.CheckedChanged += new System.EventHandler(this.Show_Pass_CheckedChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBtn.Location = new System.Drawing.Point(372, 381);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(106, 35);
            this.LoginBtn.TabIndex = 9;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(648, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(670, 531);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Show_Pass);
            this.Controls.Add(this.LogIn_Pass);
            this.Controls.Add(this.LogIn_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginAccount);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_App)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LoginAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LogIn_Username;
        private System.Windows.Forms.TextBox LogIn_Pass;
        private System.Windows.Forms.CheckBox Show_Pass;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label Registeryouraccount;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.PictureBox Logo_App;
        private System.Windows.Forms.Label EmployeeManagementSysTem;
        private System.Windows.Forms.Label label6;
    }
}

