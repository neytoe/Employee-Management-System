namespace CompanyUI
{
    partial class QueriesUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(977, 367);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(19, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Queries";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(319, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(616, 58);
            this.button5.TabIndex = 0;
            this.button5.Text = "All Employees and Departments with Assigned or Not Assigned";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.EmployeesAssignedAndNotAssignedBtnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(297, 58);
            this.button4.TabIndex = 0;
            this.button4.Text = "All Depts Not Assigned Any Employee";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AllDeptsNotAssignedAnyEmployeeBTN);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(297, 58);
            this.button3.TabIndex = 0;
            this.button3.Text = "Records Grouped By Depts";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AllRecordsGroupedByDeptsBTN);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 58);
            this.button2.TabIndex = 0;
            this.button2.Text = "Employees With Salary Above 150,000";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EmployeesWithSalAbove150k);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "All Employees With Dept Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EmployeesWithDeptNameBtn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(413, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Queries Page";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QueriesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1019, 675);
            this.MinimumSize = new System.Drawing.Size(1019, 675);
            this.Name = "QueriesUI";
            this.Size = new System.Drawing.Size(1019, 675);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
