
namespace Project.LMS.AppLayer
{
    partial class UCMembertoIssue
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
            this.pnlIssueBTitleMem = new System.Windows.Forms.Panel();
            this.lblIssueBookMem = new System.Windows.Forms.Label();
            this.btnShowAllMemIssue = new System.Windows.Forms.Button();
            this.pnlMemDetailsIssue = new System.Windows.Forms.Panel();
            this.dGVMemDetailsIssue = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchMemIssue = new System.Windows.Forms.Button();
            this.txtBoxSearchMemIssue = new System.Windows.Forms.TextBox();
            this.lblSelectDays = new System.Windows.Forms.Label();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.dTPickerIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.pnlIssueBTitleMem.SuspendLayout();
            this.pnlMemDetailsIssue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMemDetailsIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIssueBTitleMem
            // 
            this.pnlIssueBTitleMem.BackColor = System.Drawing.Color.Green;
            this.pnlIssueBTitleMem.Controls.Add(this.lblIssueBookMem);
            this.pnlIssueBTitleMem.Location = new System.Drawing.Point(0, -1);
            this.pnlIssueBTitleMem.Name = "pnlIssueBTitleMem";
            this.pnlIssueBTitleMem.Size = new System.Drawing.Size(657, 57);
            this.pnlIssueBTitleMem.TabIndex = 31;
            // 
            // lblIssueBookMem
            // 
            this.lblIssueBookMem.AutoSize = true;
            this.lblIssueBookMem.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueBookMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblIssueBookMem.Location = new System.Drawing.Point(229, 13);
            this.lblIssueBookMem.Name = "lblIssueBookMem";
            this.lblIssueBookMem.Size = new System.Drawing.Size(203, 34);
            this.lblIssueBookMem.TabIndex = 0;
            this.lblIssueBookMem.Text = "ISSUE BOOK";
            // 
            // btnShowAllMemIssue
            // 
            this.btnShowAllMemIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnShowAllMemIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllMemIssue.FlatAppearance.BorderSize = 2;
            this.btnShowAllMemIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnShowAllMemIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllMemIssue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllMemIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllMemIssue.Location = new System.Drawing.Point(354, 134);
            this.btnShowAllMemIssue.Name = "btnShowAllMemIssue";
            this.btnShowAllMemIssue.Size = new System.Drawing.Size(102, 30);
            this.btnShowAllMemIssue.TabIndex = 35;
            this.btnShowAllMemIssue.Text = "Show All";
            this.btnShowAllMemIssue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowAllMemIssue.UseVisualStyleBackColor = false;
            this.btnShowAllMemIssue.Click += new System.EventHandler(this.btnShowAllMemIssue_Click);
            // 
            // pnlMemDetailsIssue
            // 
            this.pnlMemDetailsIssue.Controls.Add(this.btnIssue);
            this.pnlMemDetailsIssue.Controls.Add(this.lblIssueDate);
            this.pnlMemDetailsIssue.Controls.Add(this.dTPickerIssueDate);
            this.pnlMemDetailsIssue.Controls.Add(this.cmbDays);
            this.pnlMemDetailsIssue.Controls.Add(this.lblSelectDays);
            this.pnlMemDetailsIssue.Controls.Add(this.dGVMemDetailsIssue);
            this.pnlMemDetailsIssue.Location = new System.Drawing.Point(1, 181);
            this.pnlMemDetailsIssue.Name = "pnlMemDetailsIssue";
            this.pnlMemDetailsIssue.Size = new System.Drawing.Size(657, 346);
            this.pnlMemDetailsIssue.TabIndex = 32;
            // 
            // dGVMemDetailsIssue
            // 
            this.dGVMemDetailsIssue.AllowUserToAddRows = false;
            this.dGVMemDetailsIssue.AllowUserToDeleteRows = false;
            this.dGVMemDetailsIssue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVMemDetailsIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMemDetailsIssue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.MemberName,
            this.Profession,
            this.DateofBirth,
            this.Address,
            this.MobileNo});
            this.dGVMemDetailsIssue.Location = new System.Drawing.Point(9, 25);
            this.dGVMemDetailsIssue.Name = "dGVMemDetailsIssue";
            this.dGVMemDetailsIssue.ReadOnly = true;
            this.dGVMemDetailsIssue.RowHeadersWidth = 51;
            this.dGVMemDetailsIssue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVMemDetailsIssue.Size = new System.Drawing.Size(638, 259);
            this.dGVMemDetailsIssue.TabIndex = 0;
            // 
            // MemberID
            // 
            this.MemberID.DataPropertyName = "MemberID";
            this.MemberID.HeaderText = "Member ID";
            this.MemberID.MinimumWidth = 6;
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            // 
            // MemberName
            // 
            this.MemberName.DataPropertyName = "Name";
            this.MemberName.HeaderText = "Member Name";
            this.MemberName.MinimumWidth = 6;
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // Profession
            // 
            this.Profession.DataPropertyName = "Profession";
            this.Profession.HeaderText = "Profession";
            this.Profession.MinimumWidth = 6;
            this.Profession.Name = "Profession";
            this.Profession.ReadOnly = true;
            // 
            // DateofBirth
            // 
            this.DateofBirth.DataPropertyName = "DateofBirth";
            this.DateofBirth.HeaderText = "Date of Birth";
            this.DateofBirth.MinimumWidth = 6;
            this.DateofBirth.Name = "DateofBirth";
            this.DateofBirth.ReadOnly = true;
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
            // btnSearchMemIssue
            // 
            this.btnSearchMemIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnSearchMemIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchMemIssue.FlatAppearance.BorderSize = 2;
            this.btnSearchMemIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSearchMemIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMemIssue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMemIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchMemIssue.Location = new System.Drawing.Point(246, 134);
            this.btnSearchMemIssue.Name = "btnSearchMemIssue";
            this.btnSearchMemIssue.Size = new System.Drawing.Size(102, 30);
            this.btnSearchMemIssue.TabIndex = 34;
            this.btnSearchMemIssue.Text = "Search";
            this.btnSearchMemIssue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchMemIssue.UseVisualStyleBackColor = false;
            this.btnSearchMemIssue.Click += new System.EventHandler(this.btnSearchMemIssue_Click);
            // 
            // txtBoxSearchMemIssue
            // 
            this.txtBoxSearchMemIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxSearchMemIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearchMemIssue.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchMemIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxSearchMemIssue.Location = new System.Drawing.Point(10, 134);
            this.txtBoxSearchMemIssue.Name = "txtBoxSearchMemIssue";
            this.txtBoxSearchMemIssue.Size = new System.Drawing.Size(220, 30);
            this.txtBoxSearchMemIssue.TabIndex = 33;
            this.txtBoxSearchMemIssue.Text = "    Search by Name";
            this.txtBoxSearchMemIssue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxSearchMemIssue_MouseClick);
            this.txtBoxSearchMemIssue.TextChanged += new System.EventHandler(this.txtBoxSearchMemIssue_TextChanged);
            // 
            // lblSelectDays
            // 
            this.lblSelectDays.AutoSize = true;
            this.lblSelectDays.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblSelectDays.Location = new System.Drawing.Point(59, 301);
            this.lblSelectDays.Name = "lblSelectDays";
            this.lblSelectDays.Size = new System.Drawing.Size(109, 21);
            this.lblSelectDays.TabIndex = 1;
            this.lblSelectDays.Text = "Select Days :";
            // 
            // cmbDays
            // 
            this.cmbDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.cmbDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.cmbDays.Location = new System.Drawing.Point(174, 300);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(79, 27);
            this.cmbDays.TabIndex = 2;
            this.cmbDays.Text = "  Day(s)";
            // 
            // dTPickerIssueDate
            // 
            this.dTPickerIssueDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.dTPickerIssueDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.dTPickerIssueDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.dTPickerIssueDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.dTPickerIssueDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.dTPickerIssueDate.CustomFormat = "      dd/MM/yyyy";
            this.dTPickerIssueDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPickerIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerIssueDate.Location = new System.Drawing.Point(321, 297);
            this.dTPickerIssueDate.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dTPickerIssueDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dTPickerIssueDate.Name = "dTPickerIssueDate";
            this.dTPickerIssueDate.Size = new System.Drawing.Size(156, 29);
            this.dTPickerIssueDate.TabIndex = 84;
            this.dTPickerIssueDate.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblIssueDate.Location = new System.Drawing.Point(262, 301);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(56, 21);
            this.lblIssueDate.TabIndex = 85;
            this.lblIssueDate.Text = "Date :";
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnIssue.FlatAppearance.BorderSize = 2;
            this.btnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnIssue.Location = new System.Drawing.Point(503, 296);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(120, 30);
            this.btnIssue.TabIndex = 36;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // UCMembertoIssue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.btnShowAllMemIssue);
            this.Controls.Add(this.pnlMemDetailsIssue);
            this.Controls.Add(this.btnSearchMemIssue);
            this.Controls.Add(this.txtBoxSearchMemIssue);
            this.Controls.Add(this.pnlIssueBTitleMem);
            this.Name = "UCMembertoIssue";
            this.Size = new System.Drawing.Size(658, 563);
            this.Load += new System.EventHandler(this.UCMembertoIssue_Load);
            this.pnlIssueBTitleMem.ResumeLayout(false);
            this.pnlIssueBTitleMem.PerformLayout();
            this.pnlMemDetailsIssue.ResumeLayout(false);
            this.pnlMemDetailsIssue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMemDetailsIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIssueBTitleMem;
        private System.Windows.Forms.Label lblIssueBookMem;
        private System.Windows.Forms.Button btnShowAllMemIssue;
        private System.Windows.Forms.Panel pnlMemDetailsIssue;
        private System.Windows.Forms.DataGridView dGVMemDetailsIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.Button btnSearchMemIssue;
        private System.Windows.Forms.TextBox txtBoxSearchMemIssue;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Label lblSelectDays;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dTPickerIssueDate;
    }
}
