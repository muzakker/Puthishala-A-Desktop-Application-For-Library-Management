
namespace Project.LMS.AppLayer
{
    partial class UCViewEmployees
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
            this.btnRmvEmployee = new System.Windows.Forms.Button();
            this.pnlEmpTitle = new System.Windows.Forms.Panel();
            this.lblEmpView = new System.Windows.Forms.Label();
            this.pnlEmpDetails = new System.Windows.Forms.Panel();
            this.dGVEmpDetails = new System.Windows.Forms.DataGridView();
            this.txtBoxSearchEmp = new System.Windows.Forms.TextBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.btnShowAllEmp = new System.Windows.Forms.Button();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEmpTitle.SuspendLayout();
            this.pnlEmpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmpDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRmvEmployee
            // 
            this.btnRmvEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnRmvEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnRmvEmployee.FlatAppearance.BorderSize = 2;
            this.btnRmvEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRmvEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmvEmployee.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.btnRmvEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnRmvEmployee.Location = new System.Drawing.Point(267, 300);
            this.btnRmvEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnRmvEmployee.Name = "btnRmvEmployee";
            this.btnRmvEmployee.Size = new System.Drawing.Size(143, 32);
            this.btnRmvEmployee.TabIndex = 5;
            this.btnRmvEmployee.Text = "Remove Employee";
            this.btnRmvEmployee.UseVisualStyleBackColor = false;
            this.btnRmvEmployee.Click += new System.EventHandler(this.btnRmvEmployee_Click);
            // 
            // pnlEmpTitle
            // 
            this.pnlEmpTitle.BackColor = System.Drawing.Color.Green;
            this.pnlEmpTitle.Controls.Add(this.lblEmpView);
            this.pnlEmpTitle.Location = new System.Drawing.Point(0, -1);
            this.pnlEmpTitle.Name = "pnlEmpTitle";
            this.pnlEmpTitle.Size = new System.Drawing.Size(657, 57);
            this.pnlEmpTitle.TabIndex = 6;
            // 
            // lblEmpView
            // 
            this.lblEmpView.AutoSize = true;
            this.lblEmpView.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblEmpView.Location = new System.Drawing.Point(157, 13);
            this.lblEmpView.Name = "lblEmpView";
            this.lblEmpView.Size = new System.Drawing.Size(427, 41);
            this.lblEmpView.TabIndex = 0;
            this.lblEmpView.Text = "EMPLOYEE DETAILS";
            // 
            // pnlEmpDetails
            // 
            this.pnlEmpDetails.Controls.Add(this.dGVEmpDetails);
            this.pnlEmpDetails.Controls.Add(this.btnRmvEmployee);
            this.pnlEmpDetails.Location = new System.Drawing.Point(0, 171);
            this.pnlEmpDetails.Name = "pnlEmpDetails";
            this.pnlEmpDetails.Size = new System.Drawing.Size(657, 346);
            this.pnlEmpDetails.TabIndex = 7;
            // 
            // dGVEmpDetails
            // 
            this.dGVEmpDetails.AllowUserToAddRows = false;
            this.dGVEmpDetails.AllowUserToDeleteRows = false;
            this.dGVEmpDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVEmpDetails.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dGVEmpDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEmpDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.Designation,
            this.JoinDate,
            this.Salary,
            this.Address,
            this.MobileNo});
            this.dGVEmpDetails.Location = new System.Drawing.Point(10, 25);
            this.dGVEmpDetails.Name = "dGVEmpDetails";
            this.dGVEmpDetails.ReadOnly = true;
            this.dGVEmpDetails.RowHeadersWidth = 51;
            this.dGVEmpDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEmpDetails.Size = new System.Drawing.Size(638, 259);
            this.dGVEmpDetails.TabIndex = 0;
            // 
            // txtBoxSearchEmp
            // 
            this.txtBoxSearchEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxSearchEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearchEmp.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxSearchEmp.Location = new System.Drawing.Point(9, 138);
            this.txtBoxSearchEmp.Name = "txtBoxSearchEmp";
            this.txtBoxSearchEmp.Size = new System.Drawing.Size(220, 36);
            this.txtBoxSearchEmp.TabIndex = 10;
            this.txtBoxSearchEmp.Text = "     Search by Name";
            this.txtBoxSearchEmp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxSearchEmp_MouseClick);
            this.txtBoxSearchEmp.TextChanged += new System.EventHandler(this.txtBoxSearchEmp_TextChanged);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnSearchEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchEmp.FlatAppearance.BorderSize = 2;
            this.btnSearchEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmp.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchEmp.Location = new System.Drawing.Point(245, 138);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(102, 30);
            this.btnSearchEmp.TabIndex = 11;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // btnShowAllEmp
            // 
            this.btnShowAllEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnShowAllEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllEmp.FlatAppearance.BorderSize = 2;
            this.btnShowAllEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnShowAllEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllEmp.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllEmp.Location = new System.Drawing.Point(353, 138);
            this.btnShowAllEmp.Name = "btnShowAllEmp";
            this.btnShowAllEmp.Size = new System.Drawing.Size(102, 30);
            this.btnShowAllEmp.TabIndex = 12;
            this.btnShowAllEmp.Text = "Show All";
            this.btnShowAllEmp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowAllEmp.UseVisualStyleBackColor = false;
            this.btnShowAllEmp.Click += new System.EventHandler(this.btnShowAllEmp_Click);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "Name";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "Designation";
            this.Designation.HeaderText = "Designation";
            this.Designation.MinimumWidth = 6;
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // JoinDate
            // 
            this.JoinDate.DataPropertyName = "JoinDate";
            this.JoinDate.HeaderText = "Joining Date";
            this.JoinDate.MinimumWidth = 6;
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // MobileNo
            // 
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "Mobile No";
            this.MobileNo.MinimumWidth = 6;
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.ReadOnly = true;
            // 
            // UCViewEmployees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.btnShowAllEmp);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.txtBoxSearchEmp);
            this.Controls.Add(this.pnlEmpDetails);
            this.Controls.Add(this.pnlEmpTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCViewEmployees";
            this.Size = new System.Drawing.Size(658, 563);
            this.Load += new System.EventHandler(this.UCViewEmployees_Load);
            this.pnlEmpTitle.ResumeLayout(false);
            this.pnlEmpTitle.PerformLayout();
            this.pnlEmpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmpDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRmvEmployee;
        private System.Windows.Forms.Panel pnlEmpTitle;
        private System.Windows.Forms.Label lblEmpView;
        private System.Windows.Forms.Panel pnlEmpDetails;
        private System.Windows.Forms.DataGridView dGVEmpDetails;
        private System.Windows.Forms.TextBox txtBoxSearchEmp;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Button btnShowAllEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
    }
}
