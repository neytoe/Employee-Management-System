namespace CompanyUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NavigateEmployeeBtn = new System.Windows.Forms.Button();
            this.NavigateQueriesBtn = new System.Windows.Forms.Button();
            this.NavigateDeptPage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NavigateHomeBtn = new System.Windows.Forms.Button();
            this.employeeui1 = new CompanyUI.EmployeeUI();
            this.departmentui1 = new CompanyUI.DepartmentUI();
            this.queriesui1 = new CompanyUI.QueriesUI();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigateEmployeeBtn
            // 
            this.NavigateEmployeeBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NavigateEmployeeBtn.FlatAppearance.BorderSize = 0;
            this.NavigateEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavigateEmployeeBtn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavigateEmployeeBtn.Location = new System.Drawing.Point(24, 182);
            this.NavigateEmployeeBtn.Name = "NavigateEmployeeBtn";
            this.NavigateEmployeeBtn.Size = new System.Drawing.Size(207, 47);
            this.NavigateEmployeeBtn.TabIndex = 0;
            this.NavigateEmployeeBtn.Text = "Go To Employee Page";
            this.NavigateEmployeeBtn.UseVisualStyleBackColor = false;
            this.NavigateEmployeeBtn.Click += new System.EventHandler(this.NavigateEmployeeBtn_Click);
            // 
            // NavigateQueriesBtn
            // 
            this.NavigateQueriesBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NavigateQueriesBtn.FlatAppearance.BorderSize = 0;
            this.NavigateQueriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavigateQueriesBtn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavigateQueriesBtn.Location = new System.Drawing.Point(24, 437);
            this.NavigateQueriesBtn.Name = "NavigateQueriesBtn";
            this.NavigateQueriesBtn.Size = new System.Drawing.Size(207, 47);
            this.NavigateQueriesBtn.TabIndex = 0;
            this.NavigateQueriesBtn.Text = "Go To Queries Page";
            this.NavigateQueriesBtn.UseVisualStyleBackColor = false;
            this.NavigateQueriesBtn.Click += new System.EventHandler(this.NavigateQueriesBtn_Click);
            // 
            // NavigateDeptPage
            // 
            this.NavigateDeptPage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NavigateDeptPage.FlatAppearance.BorderSize = 0;
            this.NavigateDeptPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavigateDeptPage.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavigateDeptPage.Location = new System.Drawing.Point(24, 316);
            this.NavigateDeptPage.Name = "NavigateDeptPage";
            this.NavigateDeptPage.Size = new System.Drawing.Size(207, 47);
            this.NavigateDeptPage.TabIndex = 0;
            this.NavigateDeptPage.Text = "Go To Department Page";
            this.NavigateDeptPage.UseVisualStyleBackColor = false;
            this.NavigateDeptPage.Click += new System.EventHandler(this.NavigateDeptPage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NavigateHomeBtn);
            this.groupBox1.Controls.Add(this.NavigateEmployeeBtn);
            this.groupBox1.Controls.Add(this.NavigateQueriesBtn);
            this.groupBox1.Controls.Add(this.NavigateDeptPage);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 626);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // NavigateHomeBtn
            // 
            this.NavigateHomeBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NavigateHomeBtn.FlatAppearance.BorderSize = 0;
            this.NavigateHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavigateHomeBtn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavigateHomeBtn.Location = new System.Drawing.Point(24, 77);
            this.NavigateHomeBtn.Name = "NavigateHomeBtn";
            this.NavigateHomeBtn.Size = new System.Drawing.Size(207, 43);
            this.NavigateHomeBtn.TabIndex = 1;
            this.NavigateHomeBtn.Text = "Home";
            this.NavigateHomeBtn.UseVisualStyleBackColor = false;
            this.NavigateHomeBtn.Click += new System.EventHandler(this.NavigateHomeBtn_Click);
            // 
            // employeeui1
            // 
            this.employeeui1.Location = new System.Drawing.Point(268, 21);
            this.employeeui1.MaximumSize = new System.Drawing.Size(1019, 675);
            this.employeeui1.MinimumSize = new System.Drawing.Size(1019, 675);
            this.employeeui1.Name = "employeeui1";
            this.employeeui1.Size = new System.Drawing.Size(1019, 675);
            this.employeeui1.TabIndex = 2;
            // 
            // departmentui1
            // 
            this.departmentui1.Location = new System.Drawing.Point(268, 21);
            this.departmentui1.MaximumSize = new System.Drawing.Size(1019, 675);
            this.departmentui1.MinimumSize = new System.Drawing.Size(1019, 675);
            this.departmentui1.Name = "departmentui1";
            this.departmentui1.Size = new System.Drawing.Size(1019, 675);
            this.departmentui1.TabIndex = 3;
            this.departmentui1.Load += new System.EventHandler(this.departmentui1_Load);
            // 
            // queriesui1
            // 
            this.queriesui1.Location = new System.Drawing.Point(280, 31);
            this.queriesui1.MaximumSize = new System.Drawing.Size(1019, 675);
            this.queriesui1.MinimumSize = new System.Drawing.Size(1019, 675);
            this.queriesui1.Name = "queriesui1";
            this.queriesui1.Size = new System.Drawing.Size(1019, 675);
            this.queriesui1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "DASHBOARD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 740);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queriesui1);
            this.Controls.Add(this.departmentui1);
            this.Controls.Add(this.employeeui1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1406, 787);
            this.MinimumSize = new System.Drawing.Size(1406, 787);
            this.Name = "Form1";
            this.Text = "Employeeform";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NavigateEmployeeBtn;
        private System.Windows.Forms.Button NavigateQueriesBtn;
        private System.Windows.Forms.Button NavigateDeptPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private EmployeeUI employeeui1;
        private DepartmentUI departmentui1;
        private QueriesUI queriesui1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NavigateHomeBtn;
    }
}

