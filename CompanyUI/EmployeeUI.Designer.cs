namespace CompanyUI
{
    partial class EmployeeUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeptdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeptcomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryTbox = new System.Windows.Forms.TextBox();
            this.phonenumTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstnametbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeedataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeptdateTimePicker);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DeptcomboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.salaryTbox);
            this.groupBox1.Controls.Add(this.phonenumTbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailTbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lastNameTbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.firstnametbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Employee";
            // 
            // DeptdateTimePicker
            // 
            this.DeptdateTimePicker.Location = new System.Drawing.Point(135, 147);
            this.DeptdateTimePicker.Name = "DeptdateTimePicker";
            this.DeptdateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.DeptdateTimePicker.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "HireDate";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(469, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Create Employee";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(640, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update Employee";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.UpdateEmployeeBtnClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(819, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete Employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DeleteEmpBtn);
            // 
            // DeptcomboBox
            // 
            this.DeptcomboBox.FormattingEnabled = true;
            this.DeptcomboBox.Location = new System.Drawing.Point(794, 90);
            this.DeptcomboBox.Name = "DeptcomboBox";
            this.DeptcomboBox.Size = new System.Drawing.Size(162, 28);
            this.DeptcomboBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Salary";
            // 
            // salaryTbox
            // 
            this.salaryTbox.Location = new System.Drawing.Point(794, 26);
            this.salaryTbox.Multiline = true;
            this.salaryTbox.Name = "salaryTbox";
            this.salaryTbox.Size = new System.Drawing.Size(162, 37);
            this.salaryTbox.TabIndex = 1;
            // 
            // phonenumTbox
            // 
            this.phonenumTbox.Location = new System.Drawing.Point(469, 87);
            this.phonenumTbox.Multiline = true;
            this.phonenumTbox.Name = "phonenumTbox";
            this.phonenumTbox.Size = new System.Drawing.Size(162, 37);
            this.phonenumTbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "PhoneNumber";
            // 
            // emailTbox
            // 
            this.emailTbox.Location = new System.Drawing.Point(469, 26);
            this.emailTbox.Multiline = true;
            this.emailTbox.Name = "emailTbox";
            this.emailTbox.Size = new System.Drawing.Size(162, 37);
            this.emailTbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // lastNameTbox
            // 
            this.lastNameTbox.Location = new System.Drawing.Point(136, 87);
            this.lastNameTbox.Multiline = true;
            this.lastNameTbox.Name = "lastNameTbox";
            this.lastNameTbox.Size = new System.Drawing.Size(162, 37);
            this.lastNameTbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "LastName";
            // 
            // firstnametbox
            // 
            this.firstnametbox.Location = new System.Drawing.Point(136, 26);
            this.firstnametbox.Multiline = true;
            this.firstnametbox.Name = "firstnametbox";
            this.firstnametbox.Size = new System.Drawing.Size(162, 37);
            this.firstnametbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(408, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Page";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "EmployeeId";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LastName.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneNumber.Width = 125;
            // 
            // HireDate
            // 
            this.HireDate.DataPropertyName = "HireDate";
            this.HireDate.HeaderText = "Hire Date";
            this.HireDate.MinimumWidth = 6;
            this.HireDate.Name = "HireDate";
            this.HireDate.ReadOnly = true;
            this.HireDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HireDate.Width = 125;
            // 
            // DepartmentId
            // 
            this.DepartmentId.DataPropertyName = "DepartmentId";
            this.DepartmentId.HeaderText = "DepartmentId";
            this.DepartmentId.MinimumWidth = 6;
            this.DepartmentId.Name = "DepartmentId";
            this.DepartmentId.ReadOnly = true;
            this.DepartmentId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DepartmentId.Visible = false;
            this.DepartmentId.Width = 125;
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "Department";
            this.DepartmentName.MinimumWidth = 6;
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            this.DepartmentName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DepartmentName.Width = 125;
            // 
            // EmployeedataGridView1
            // 
            this.EmployeedataGridView1.AllowUserToAddRows = false;
            this.EmployeedataGridView1.AllowUserToDeleteRows = false;
            this.EmployeedataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeedataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.PhoneNumber,
            this.HireDate,
            this.DepartmentId,
            this.DepartmentName});
            this.EmployeedataGridView1.Location = new System.Drawing.Point(17, 368);
            this.EmployeedataGridView1.Name = "EmployeedataGridView1";
            this.EmployeedataGridView1.ReadOnly = true;
            this.EmployeedataGridView1.RowHeadersWidth = 51;
            this.EmployeedataGridView1.Size = new System.Drawing.Size(987, 290);
            this.EmployeedataGridView1.TabIndex = 0;
            this.EmployeedataGridView1.Text = "dataGridView1";
            this.EmployeedataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeedataGridView1_CellClick);
            // 
            // EmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmployeedataGridView1);
            this.MaximumSize = new System.Drawing.Size(1019, 675);
            this.MinimumSize = new System.Drawing.Size(1019, 675);
            this.Name = "EmployeeUI";
            this.Size = new System.Drawing.Size(1019, 675);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmplodataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox DeptcomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salaryTbox;
        private System.Windows.Forms.TextBox phonenumTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstnametbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker DeptdateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView EmployeedataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
    }
}
