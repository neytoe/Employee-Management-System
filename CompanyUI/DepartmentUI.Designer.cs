namespace CompanyUI
{
    partial class DepartmentUI
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
            this.DeptdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CreateDeptBtn = new System.Windows.Forms.Button();
            this.deptnameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeptdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeptdataGridView
            // 
            this.DeptdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeptdataGridView.Location = new System.Drawing.Point(242, 306);
            this.DeptdataGridView.Name = "DeptdataGridView";
            this.DeptdataGridView.RowHeadersWidth = 51;
            this.DeptdataGridView.Size = new System.Drawing.Size(548, 355);
            this.DeptdataGridView.TabIndex = 0;
            this.DeptdataGridView.Text = "dataGridView1";
            this.DeptdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeptDatagrid_cellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.CreateDeptBtn);
            this.groupBox1.Controls.Add(this.deptnameTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Department";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(552, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update Department";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.UpdateDeptClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(764, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Department";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CreateDeptBtn
            // 
            this.CreateDeptBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CreateDeptBtn.FlatAppearance.BorderSize = 0;
            this.CreateDeptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateDeptBtn.Location = new System.Drawing.Point(352, 165);
            this.CreateDeptBtn.Name = "CreateDeptBtn";
            this.CreateDeptBtn.Size = new System.Drawing.Size(181, 46);
            this.CreateDeptBtn.TabIndex = 2;
            this.CreateDeptBtn.Text = "Create Department";
            this.CreateDeptBtn.UseVisualStyleBackColor = false;
            this.CreateDeptBtn.Click += new System.EventHandler(this.CreateDeptBtn_Click);
            // 
            // deptnameTextbox
            // 
            this.deptnameTextbox.Location = new System.Drawing.Point(217, 40);
            this.deptnameTextbox.Multiline = true;
            this.deptnameTextbox.Name = "deptnameTextbox";
            this.deptnameTextbox.Size = new System.Drawing.Size(242, 45);
            this.deptnameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Department Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(377, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department Page";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DepartmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeptdataGridView);
            this.MaximumSize = new System.Drawing.Size(1019, 675);
            this.MinimumSize = new System.Drawing.Size(1019, 675);
            this.Name = "DepartmentUI";
            this.Size = new System.Drawing.Size(1019, 675);
            this.Load += new System.EventHandler(this.DepartmentUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeptdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DeptdataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deptnameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CreateDeptBtn;
        private System.Windows.Forms.Button button1;
    }
}
