namespace EmployeeSystem_test_02
{
    partial class AddEmployeeForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addemployee_position = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addemployee_clear_btn = new System.Windows.Forms.Button();
            this.addemployee_delete_btn = new System.Windows.Forms.Button();
            this.addemployee_updatebtn = new System.Windows.Forms.Button();
            this.addemployee_add_btn = new System.Windows.Forms.Button();
            this.addemployee_importpicture = new System.Windows.Forms.Button();
            this.addEmployee_picture = new System.Windows.Forms.PictureBox();
            this.addemployee_phonenumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addemployee_gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addemployee_fullname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addemployee_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(18, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(785, 160);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 228);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.addEmployee_status);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.addemployee_position);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.addemployee_clear_btn);
            this.panel5.Controls.Add(this.addemployee_delete_btn);
            this.panel5.Controls.Add(this.addemployee_updatebtn);
            this.panel5.Controls.Add(this.addemployee_add_btn);
            this.panel5.Controls.Add(this.addemployee_importpicture);
            this.panel5.Controls.Add(this.addEmployee_picture);
            this.panel5.Controls.Add(this.addemployee_phonenumber);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.addemployee_gender);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.addemployee_fullname);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.addemployee_id);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(12, 259);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(823, 228);
            this.panel5.TabIndex = 15;
            // 
            // addEmployee_status
            // 
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addEmployee_status.Location = new System.Drawing.Point(449, 114);
            this.addEmployee_status.Name = "addEmployee_status";
            this.addEmployee_status.Size = new System.Drawing.Size(189, 21);
            this.addEmployee_status.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Status:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addemployee_position
            // 
            this.addemployee_position.FormattingEnabled = true;
            this.addemployee_position.Items.AddRange(new object[] {
            "Manager",
            "Saler",
            "Staff",
            "Bussiness Analyst"});
            this.addemployee_position.Location = new System.Drawing.Point(449, 72);
            this.addemployee_position.Name = "addemployee_position";
            this.addemployee_position.Size = new System.Drawing.Size(189, 21);
            this.addemployee_position.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Position: ";
            // 
            // addemployee_clear_btn
            // 
            this.addemployee_clear_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addemployee_clear_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee_clear_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addemployee_clear_btn.Location = new System.Drawing.Point(543, 163);
            this.addemployee_clear_btn.Name = "addemployee_clear_btn";
            this.addemployee_clear_btn.Size = new System.Drawing.Size(113, 58);
            this.addemployee_clear_btn.TabIndex = 15;
            this.addemployee_clear_btn.Text = "Clear";
            this.addemployee_clear_btn.UseVisualStyleBackColor = false;
            this.addemployee_clear_btn.Click += new System.EventHandler(this.addemployee_clear_btn_Click);
            // 
            // addemployee_delete_btn
            // 
            this.addemployee_delete_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addemployee_delete_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee_delete_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addemployee_delete_btn.Location = new System.Drawing.Point(393, 163);
            this.addemployee_delete_btn.Name = "addemployee_delete_btn";
            this.addemployee_delete_btn.Size = new System.Drawing.Size(113, 58);
            this.addemployee_delete_btn.TabIndex = 14;
            this.addemployee_delete_btn.Text = "Delete";
            this.addemployee_delete_btn.UseVisualStyleBackColor = false;
            this.addemployee_delete_btn.Click += new System.EventHandler(this.addemployee_delete_btn_Click);
            // 
            // addemployee_updatebtn
            // 
            this.addemployee_updatebtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addemployee_updatebtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee_updatebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addemployee_updatebtn.Location = new System.Drawing.Point(242, 163);
            this.addemployee_updatebtn.Name = "addemployee_updatebtn";
            this.addemployee_updatebtn.Size = new System.Drawing.Size(113, 58);
            this.addemployee_updatebtn.TabIndex = 13;
            this.addemployee_updatebtn.Text = "Update";
            this.addemployee_updatebtn.UseVisualStyleBackColor = false;
            this.addemployee_updatebtn.Click += new System.EventHandler(this.addemployee_updatebtn_Click);
            // 
            // addemployee_add_btn
            // 
            this.addemployee_add_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addemployee_add_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee_add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addemployee_add_btn.Location = new System.Drawing.Point(92, 163);
            this.addemployee_add_btn.Name = "addemployee_add_btn";
            this.addemployee_add_btn.Size = new System.Drawing.Size(113, 58);
            this.addemployee_add_btn.TabIndex = 12;
            this.addemployee_add_btn.Text = "Add";
            this.addemployee_add_btn.UseVisualStyleBackColor = false;
            this.addemployee_add_btn.Click += new System.EventHandler(this.addemployee_add_btn_Click);
            // 
            // addemployee_importpicture
            // 
            this.addemployee_importpicture.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addemployee_importpicture.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee_importpicture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addemployee_importpicture.Location = new System.Drawing.Point(703, 154);
            this.addemployee_importpicture.Name = "addemployee_importpicture";
            this.addemployee_importpicture.Size = new System.Drawing.Size(100, 30);
            this.addemployee_importpicture.TabIndex = 11;
            this.addemployee_importpicture.Text = "Import";
            this.addemployee_importpicture.UseVisualStyleBackColor = false;
            this.addemployee_importpicture.Click += new System.EventHandler(this.addemployee_importpicture_Click);
            // 
            // addEmployee_picture
            // 
            this.addEmployee_picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addEmployee_picture.Location = new System.Drawing.Point(703, 34);
            this.addEmployee_picture.Name = "addEmployee_picture";
            this.addEmployee_picture.Size = new System.Drawing.Size(100, 123);
            this.addEmployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_picture.TabIndex = 10;
            this.addEmployee_picture.TabStop = false;
            // 
            // addemployee_phonenumber
            // 
            this.addemployee_phonenumber.Location = new System.Drawing.Point(449, 33);
            this.addemployee_phonenumber.Name = "addemployee_phonenumber";
            this.addemployee_phonenumber.Size = new System.Drawing.Size(189, 20);
            this.addemployee_phonenumber.TabIndex = 9;
            this.addemployee_phonenumber.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone Number:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // addemployee_gender
            // 
            this.addemployee_gender.FormattingEnabled = true;
            this.addemployee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.addemployee_gender.Location = new System.Drawing.Point(135, 114);
            this.addemployee_gender.Name = "addemployee_gender";
            this.addemployee_gender.Size = new System.Drawing.Size(160, 21);
            this.addemployee_gender.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender: ";
            // 
            // addemployee_fullname
            // 
            this.addemployee_fullname.Location = new System.Drawing.Point(135, 73);
            this.addemployee_fullname.Name = "addemployee_fullname";
            this.addemployee_fullname.Size = new System.Drawing.Size(160, 20);
            this.addemployee_fullname.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Full Name: ";
            // 
            // addemployee_id
            // 
            this.addemployee_id.Location = new System.Drawing.Point(135, 32);
            this.addemployee_id.Name = "addemployee_id";
            this.addemployee_id.Size = new System.Drawing.Size(160, 20);
            this.addemployee_id.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Employee ID: ";
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 337);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1076, 239);
            this.panel6.TabIndex = 1;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployeeForm";
            this.Size = new System.Drawing.Size(858, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button addemployee_clear_btn;
        private System.Windows.Forms.Button addemployee_delete_btn;
        private System.Windows.Forms.Button addemployee_updatebtn;
        private System.Windows.Forms.Button addemployee_add_btn;
        private System.Windows.Forms.Button addemployee_importpicture;
        private System.Windows.Forms.PictureBox addEmployee_picture;
        private System.Windows.Forms.TextBox addemployee_phonenumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addemployee_gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addemployee_fullname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addemployee_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox addemployee_position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.Label label3;
    }
}
