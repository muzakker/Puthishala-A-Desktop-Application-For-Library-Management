
namespace Project.LMS.AppLayer
{
    partial class UCAddMember
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
            this.btnAddMem = new System.Windows.Forms.Button();
            this.cmbProfession = new System.Windows.Forms.ComboBox();
            this.pnlDoB = new System.Windows.Forms.Panel();
            this.dTPickerDoB = new System.Windows.Forms.DateTimePicker();
            this.pnlMemPass = new System.Windows.Forms.Panel();
            this.txtBoxMemPass = new System.Windows.Forms.TextBox();
            this.lblMemPass = new System.Windows.Forms.Label();
            this.pnlMemMobile = new System.Windows.Forms.Panel();
            this.txtBoxMemMobile = new System.Windows.Forms.TextBox();
            this.pnlMemAddress = new System.Windows.Forms.Panel();
            this.lblMemMobile = new System.Windows.Forms.Label();
            this.txtBoxMemAddress = new System.Windows.Forms.TextBox();
            this.lblMemAddress = new System.Windows.Forms.Label();
            this.pnlProfession = new System.Windows.Forms.Panel();
            this.lblProfession = new System.Windows.Forms.Label();
            this.pnlMemName = new System.Windows.Forms.Panel();
            this.txtBoxMemName = new System.Windows.Forms.TextBox();
            this.lblMemName = new System.Windows.Forms.Label();
            this.pnlMemId = new System.Windows.Forms.Panel();
            this.txtBoxMemId = new System.Windows.Forms.TextBox();
            this.lblMemId = new System.Windows.Forms.Label();
            this.lblAddMem = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.pnlAddMemTitle = new System.Windows.Forms.Panel();
            this.pnlAddMemTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMem
            // 
            this.btnAddMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnAddMem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnAddMem.FlatAppearance.BorderSize = 2;
            this.btnAddMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAddMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMem.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnAddMem.Location = new System.Drawing.Point(301, 459);
            this.btnAddMem.Name = "btnAddMem";
            this.btnAddMem.Size = new System.Drawing.Size(166, 42);
            this.btnAddMem.TabIndex = 86;
            this.btnAddMem.Text = "ADD";
            this.btnAddMem.UseVisualStyleBackColor = false;
            this.btnAddMem.Click += new System.EventHandler(this.btnAddMem_Click);
            // 
            // cmbProfession
            // 
            this.cmbProfession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.cmbProfession.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.cmbProfession.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Service Holder",
            "Businessman"});
            this.cmbProfession.Location = new System.Drawing.Point(244, 242);
            this.cmbProfession.Name = "cmbProfession";
            this.cmbProfession.Size = new System.Drawing.Size(271, 29);
            this.cmbProfession.TabIndex = 85;
            this.cmbProfession.Text = "           Select Profession";
            // 
            // pnlDoB
            // 
            this.pnlDoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlDoB.Location = new System.Drawing.Point(246, 322);
            this.pnlDoB.Name = "pnlDoB";
            this.pnlDoB.Size = new System.Drawing.Size(272, 2);
            this.pnlDoB.TabIndex = 84;
            // 
            // dTPickerDoB
            // 
            this.dTPickerDoB.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.dTPickerDoB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.dTPickerDoB.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.dTPickerDoB.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.dTPickerDoB.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.dTPickerDoB.CustomFormat = " dd/MM/yyyy";
            this.dTPickerDoB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPickerDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerDoB.Location = new System.Drawing.Point(245, 292);
            this.dTPickerDoB.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dTPickerDoB.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dTPickerDoB.Name = "dTPickerDoB";
            this.dTPickerDoB.Size = new System.Drawing.Size(272, 29);
            this.dTPickerDoB.TabIndex = 83;
            this.dTPickerDoB.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // pnlMemPass
            // 
            this.pnlMemPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlMemPass.Location = new System.Drawing.Point(244, 177);
            this.pnlMemPass.Name = "pnlMemPass";
            this.pnlMemPass.Size = new System.Drawing.Size(272, 2);
            this.pnlMemPass.TabIndex = 82;
            // 
            // txtBoxMemPass
            // 
            this.txtBoxMemPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxMemPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMemPass.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMemPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxMemPass.Location = new System.Drawing.Point(244, 155);
            this.txtBoxMemPass.Name = "txtBoxMemPass";
            this.txtBoxMemPass.Size = new System.Drawing.Size(272, 23);
            this.txtBoxMemPass.TabIndex = 81;
            // 
            // lblMemPass
            // 
            this.lblMemPass.AutoSize = true;
            this.lblMemPass.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lblMemPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblMemPass.Location = new System.Drawing.Point(101, 154);
            this.lblMemPass.Name = "lblMemPass";
            this.lblMemPass.Size = new System.Drawing.Size(139, 24);
            this.lblMemPass.TabIndex = 80;
            this.lblMemPass.Text = "       Password :";
            // 
            // pnlMemMobile
            // 
            this.pnlMemMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlMemMobile.Location = new System.Drawing.Point(244, 415);
            this.pnlMemMobile.Name = "pnlMemMobile";
            this.pnlMemMobile.Size = new System.Drawing.Size(272, 2);
            this.pnlMemMobile.TabIndex = 76;
            // 
            // txtBoxMemMobile
            // 
            this.txtBoxMemMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxMemMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMemMobile.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMemMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxMemMobile.Location = new System.Drawing.Point(244, 393);
            this.txtBoxMemMobile.Name = "txtBoxMemMobile";
            this.txtBoxMemMobile.Size = new System.Drawing.Size(272, 23);
            this.txtBoxMemMobile.TabIndex = 75;
            // 
            // pnlMemAddress
            // 
            this.pnlMemAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlMemAddress.Location = new System.Drawing.Point(244, 365);
            this.pnlMemAddress.Name = "pnlMemAddress";
            this.pnlMemAddress.Size = new System.Drawing.Size(272, 2);
            this.pnlMemAddress.TabIndex = 73;
            // 
            // lblMemMobile
            // 
            this.lblMemMobile.AutoSize = true;
            this.lblMemMobile.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lblMemMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblMemMobile.Location = new System.Drawing.Point(100, 393);
            this.lblMemMobile.Name = "lblMemMobile";
            this.lblMemMobile.Size = new System.Drawing.Size(142, 24);
            this.lblMemMobile.TabIndex = 74;
            this.lblMemMobile.Text = "      Mobile No :";
            // 
            // txtBoxMemAddress
            // 
            this.txtBoxMemAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxMemAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMemAddress.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMemAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxMemAddress.Location = new System.Drawing.Point(244, 343);
            this.txtBoxMemAddress.Name = "txtBoxMemAddress";
            this.txtBoxMemAddress.Size = new System.Drawing.Size(272, 23);
            this.txtBoxMemAddress.TabIndex = 72;
            // 
            // lblMemAddress
            // 
            this.lblMemAddress.AutoSize = true;
            this.lblMemAddress.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lblMemAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblMemAddress.Location = new System.Drawing.Point(101, 342);
            this.lblMemAddress.Name = "lblMemAddress";
            this.lblMemAddress.Size = new System.Drawing.Size(141, 24);
            this.lblMemAddress.TabIndex = 71;
            this.lblMemAddress.Text = "          Address :";
            // 
            // pnlProfession
            // 
            this.pnlProfession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlProfession.Location = new System.Drawing.Point(244, 272);
            this.pnlProfession.Name = "pnlProfession";
            this.pnlProfession.Size = new System.Drawing.Size(272, 2);
            this.pnlProfession.TabIndex = 69;
            // 
            // lblProfession
            // 
            this.lblProfession.AutoSize = true;
            this.lblProfession.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lblProfession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblProfession.Location = new System.Drawing.Point(104, 250);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(135, 24);
            this.lblProfession.TabIndex = 68;
            this.lblProfession.Text = "    Profession :";
            // 
            // pnlMemName
            // 
            this.pnlMemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlMemName.Location = new System.Drawing.Point(244, 220);
            this.pnlMemName.Name = "pnlMemName";
            this.pnlMemName.Size = new System.Drawing.Size(272, 2);
            this.pnlMemName.TabIndex = 67;
            // 
            // txtBoxMemName
            // 
            this.txtBoxMemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxMemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMemName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxMemName.Location = new System.Drawing.Point(244, 198);
            this.txtBoxMemName.Name = "txtBoxMemName";
            this.txtBoxMemName.Size = new System.Drawing.Size(272, 23);
            this.txtBoxMemName.TabIndex = 66;
            // 
            // lblMemName
            // 
            this.lblMemName.AutoSize = true;
            this.lblMemName.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lblMemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblMemName.Location = new System.Drawing.Point(104, 198);
            this.lblMemName.Name = "lblMemName";
            this.lblMemName.Size = new System.Drawing.Size(136, 24);
            this.lblMemName.TabIndex = 65;
            this.lblMemName.Text = "             Name :";
            // 
            // pnlMemId
            // 
            this.pnlMemId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlMemId.Location = new System.Drawing.Point(244, 132);
            this.pnlMemId.Name = "pnlMemId";
            this.pnlMemId.Size = new System.Drawing.Size(272, 2);
            this.pnlMemId.TabIndex = 64;
            // 
            // txtBoxMemId
            // 
            this.txtBoxMemId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxMemId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMemId.Enabled = false;
            this.txtBoxMemId.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMemId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxMemId.Location = new System.Drawing.Point(244, 110);
            this.txtBoxMemId.Name = "txtBoxMemId";
            this.txtBoxMemId.Size = new System.Drawing.Size(272, 23);
            this.txtBoxMemId.TabIndex = 63;
            // 
            // lblMemId
            // 
            this.lblMemId.AutoSize = true;
            this.lblMemId.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lblMemId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblMemId.Location = new System.Drawing.Point(104, 110);
            this.lblMemId.Name = "lblMemId";
            this.lblMemId.Size = new System.Drawing.Size(133, 24);
            this.lblMemId.TabIndex = 62;
            this.lblMemId.Text = "  Member ID :";
            // 
            // lblAddMem
            // 
            this.lblAddMem.AutoSize = true;
            this.lblAddMem.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblAddMem.Location = new System.Drawing.Point(233, 13);
            this.lblAddMem.Name = "lblAddMem";
            this.lblAddMem.Size = new System.Drawing.Size(235, 34);
            this.lblAddMem.TabIndex = 0;
            this.lblAddMem.Text = "ADD MEMBER";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lblDoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblDoB.Location = new System.Drawing.Point(99, 297);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(141, 24);
            this.lblDoB.TabIndex = 70;
            this.lblDoB.Text = "Date of Birth :";
            // 
            // pnlAddMemTitle
            // 
            this.pnlAddMemTitle.BackColor = System.Drawing.Color.Green;
            this.pnlAddMemTitle.Controls.Add(this.lblAddMem);
            this.pnlAddMemTitle.Location = new System.Drawing.Point(-1, 1);
            this.pnlAddMemTitle.Name = "pnlAddMemTitle";
            this.pnlAddMemTitle.Size = new System.Drawing.Size(658, 57);
            this.pnlAddMemTitle.TabIndex = 61;
            // 
            // UCAddMember
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.btnAddMem);
            this.Controls.Add(this.cmbProfession);
            this.Controls.Add(this.pnlDoB);
            this.Controls.Add(this.dTPickerDoB);
            this.Controls.Add(this.pnlMemPass);
            this.Controls.Add(this.txtBoxMemPass);
            this.Controls.Add(this.lblMemPass);
            this.Controls.Add(this.pnlMemMobile);
            this.Controls.Add(this.txtBoxMemMobile);
            this.Controls.Add(this.pnlMemAddress);
            this.Controls.Add(this.lblMemMobile);
            this.Controls.Add(this.txtBoxMemAddress);
            this.Controls.Add(this.lblMemAddress);
            this.Controls.Add(this.pnlProfession);
            this.Controls.Add(this.lblProfession);
            this.Controls.Add(this.pnlMemName);
            this.Controls.Add(this.txtBoxMemName);
            this.Controls.Add(this.lblMemName);
            this.Controls.Add(this.pnlMemId);
            this.Controls.Add(this.txtBoxMemId);
            this.Controls.Add(this.lblMemId);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.pnlAddMemTitle);
            this.Name = "UCAddMember";
            this.Size = new System.Drawing.Size(658, 563);
            this.Load += new System.EventHandler(this.UCAddMember_Load);
            this.pnlAddMemTitle.ResumeLayout(false);
            this.pnlAddMemTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMem;
        private System.Windows.Forms.ComboBox cmbProfession;
        private System.Windows.Forms.Panel pnlDoB;
        private System.Windows.Forms.DateTimePicker dTPickerDoB;
        private System.Windows.Forms.Panel pnlMemPass;
        private System.Windows.Forms.TextBox txtBoxMemPass;
        private System.Windows.Forms.Label lblMemPass;
        private System.Windows.Forms.Panel pnlMemMobile;
        private System.Windows.Forms.TextBox txtBoxMemMobile;
        private System.Windows.Forms.Panel pnlMemAddress;
        private System.Windows.Forms.Label lblMemMobile;
        private System.Windows.Forms.TextBox txtBoxMemAddress;
        private System.Windows.Forms.Label lblMemAddress;
        private System.Windows.Forms.Panel pnlProfession;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.Panel pnlMemName;
        private System.Windows.Forms.TextBox txtBoxMemName;
        private System.Windows.Forms.Label lblMemName;
        private System.Windows.Forms.Panel pnlMemId;
        private System.Windows.Forms.TextBox txtBoxMemId;
        private System.Windows.Forms.Label lblMemId;
        private System.Windows.Forms.Label lblAddMem;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Panel pnlAddMemTitle;
    }
}
