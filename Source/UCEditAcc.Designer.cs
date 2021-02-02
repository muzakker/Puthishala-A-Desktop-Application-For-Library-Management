
namespace Project.LMS.AppLayer
{
    partial class UCEditAcc
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
            this.pnlUCEditAcc = new System.Windows.Forms.Panel();
            this.lblEditAccountDetails = new System.Windows.Forms.Label();
            this.cmbProfessionEdit = new System.Windows.Forms.ComboBox();
            this.pnlDoBEdit = new System.Windows.Forms.Panel();
            this.dTPickerDoBEdit = new System.Windows.Forms.DateTimePicker();
            this.pnlMemMobileEdit = new System.Windows.Forms.Panel();
            this.txtBoxMemMobileEdit = new System.Windows.Forms.TextBox();
            this.pnlMemAddressEdit = new System.Windows.Forms.Panel();
            this.lblMemMobileEdit = new System.Windows.Forms.Label();
            this.txtBoxMemAddressEdit = new System.Windows.Forms.TextBox();
            this.lblMemAddressEdit = new System.Windows.Forms.Label();
            this.pnlProfessionEdit = new System.Windows.Forms.Panel();
            this.lblProfessionEdit = new System.Windows.Forms.Label();
            this.pnlMemNameEdit = new System.Windows.Forms.Panel();
            this.txtBoxMemNameEdit = new System.Windows.Forms.TextBox();
            this.lblMemNameEdit = new System.Windows.Forms.Label();
            this.lblDoBEdit = new System.Windows.Forms.Label();
            this.btnUpdateMem = new System.Windows.Forms.Button();
            this.pnlUCEditAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUCEditAcc
            // 
            this.pnlUCEditAcc.BackColor = System.Drawing.Color.Green;
            this.pnlUCEditAcc.Controls.Add(this.lblEditAccountDetails);
            this.pnlUCEditAcc.Location = new System.Drawing.Point(-1, 0);
            this.pnlUCEditAcc.Name = "pnlUCEditAcc";
            this.pnlUCEditAcc.Size = new System.Drawing.Size(514, 57);
            this.pnlUCEditAcc.TabIndex = 27;
            // 
            // lblEditAccountDetails
            // 
            this.lblEditAccountDetails.AutoSize = true;
            this.lblEditAccountDetails.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditAccountDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblEditAccountDetails.Location = new System.Drawing.Point(59, 12);
            this.lblEditAccountDetails.Name = "lblEditAccountDetails";
            this.lblEditAccountDetails.Size = new System.Drawing.Size(393, 34);
            this.lblEditAccountDetails.TabIndex = 0;
            this.lblEditAccountDetails.Text = "EDIT ACCOUNT DETAILS";
            // 
            // cmbProfessionEdit
            // 
            this.cmbProfessionEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.cmbProfessionEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessionEdit.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.cmbProfessionEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.cmbProfessionEdit.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Service Holder",
            "Businessman"});
            this.cmbProfessionEdit.Location = new System.Drawing.Point(181, 100);
            this.cmbProfessionEdit.Name = "cmbProfessionEdit";
            this.cmbProfessionEdit.Size = new System.Drawing.Size(271, 26);
            this.cmbProfessionEdit.TabIndex = 100;
            // 
            // pnlDoBEdit
            // 
            this.pnlDoBEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlDoBEdit.Location = new System.Drawing.Point(182, 169);
            this.pnlDoBEdit.Name = "pnlDoBEdit";
            this.pnlDoBEdit.Size = new System.Drawing.Size(272, 2);
            this.pnlDoBEdit.TabIndex = 99;
            // 
            // dTPickerDoBEdit
            // 
            this.dTPickerDoBEdit.CalendarFont = new System.Drawing.Font("Times New Roman", 12F);
            this.dTPickerDoBEdit.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.dTPickerDoBEdit.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.dTPickerDoBEdit.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.dTPickerDoBEdit.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.dTPickerDoBEdit.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.dTPickerDoBEdit.CustomFormat = "                    dd/MM/yyyy";
            this.dTPickerDoBEdit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dTPickerDoBEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerDoBEdit.Location = new System.Drawing.Point(182, 142);
            this.dTPickerDoBEdit.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dTPickerDoBEdit.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dTPickerDoBEdit.Name = "dTPickerDoBEdit";
            this.dTPickerDoBEdit.Size = new System.Drawing.Size(272, 26);
            this.dTPickerDoBEdit.TabIndex = 98;
            this.dTPickerDoBEdit.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // pnlMemMobileEdit
            // 
            this.pnlMemMobileEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlMemMobileEdit.Location = new System.Drawing.Point(178, 242);
            this.pnlMemMobileEdit.Name = "pnlMemMobileEdit";
            this.pnlMemMobileEdit.Size = new System.Drawing.Size(272, 2);
            this.pnlMemMobileEdit.TabIndex = 97;
            // 
            // txtBoxMemMobileEdit
            // 
            this.txtBoxMemMobileEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxMemMobileEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMemMobileEdit.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.txtBoxMemMobileEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxMemMobileEdit.Location = new System.Drawing.Point(178, 222);
            this.txtBoxMemMobileEdit.Name = "txtBoxMemMobileEdit";
            this.txtBoxMemMobileEdit.Size = new System.Drawing.Size(272, 20);
            this.txtBoxMemMobileEdit.TabIndex = 96;
            // 
            // pnlMemAddressEdit
            // 
            this.pnlMemAddressEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlMemAddressEdit.Location = new System.Drawing.Point(175, 203);
            this.pnlMemAddressEdit.Name = "pnlMemAddressEdit";
            this.pnlMemAddressEdit.Size = new System.Drawing.Size(272, 2);
            this.pnlMemAddressEdit.TabIndex = 94;
            // 
            // lblMemMobileEdit
            // 
            this.lblMemMobileEdit.AutoSize = true;
            this.lblMemMobileEdit.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.lblMemMobileEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblMemMobileEdit.Location = new System.Drawing.Point(34, 222);
            this.lblMemMobileEdit.Name = "lblMemMobileEdit";
            this.lblMemMobileEdit.Size = new System.Drawing.Size(130, 21);
            this.lblMemMobileEdit.TabIndex = 95;
            this.lblMemMobileEdit.Text = "      Mobile No :";
            // 
            // txtBoxMemAddressEdit
            // 
            this.txtBoxMemAddressEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxMemAddressEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMemAddressEdit.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.txtBoxMemAddressEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxMemAddressEdit.Location = new System.Drawing.Point(175, 183);
            this.txtBoxMemAddressEdit.Name = "txtBoxMemAddressEdit";
            this.txtBoxMemAddressEdit.Size = new System.Drawing.Size(272, 20);
            this.txtBoxMemAddressEdit.TabIndex = 93;
            // 
            // lblMemAddressEdit
            // 
            this.lblMemAddressEdit.AutoSize = true;
            this.lblMemAddressEdit.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.lblMemAddressEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblMemAddressEdit.Location = new System.Drawing.Point(32, 182);
            this.lblMemAddressEdit.Name = "lblMemAddressEdit";
            this.lblMemAddressEdit.Size = new System.Drawing.Size(129, 21);
            this.lblMemAddressEdit.TabIndex = 92;
            this.lblMemAddressEdit.Text = "          Address :";
            // 
            // pnlProfessionEdit
            // 
            this.pnlProfessionEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlProfessionEdit.Location = new System.Drawing.Point(181, 127);
            this.pnlProfessionEdit.Name = "pnlProfessionEdit";
            this.pnlProfessionEdit.Size = new System.Drawing.Size(272, 2);
            this.pnlProfessionEdit.TabIndex = 90;
            // 
            // lblProfessionEdit
            // 
            this.lblProfessionEdit.AutoSize = true;
            this.lblProfessionEdit.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.lblProfessionEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblProfessionEdit.Location = new System.Drawing.Point(41, 108);
            this.lblProfessionEdit.Name = "lblProfessionEdit";
            this.lblProfessionEdit.Size = new System.Drawing.Size(121, 21);
            this.lblProfessionEdit.TabIndex = 89;
            this.lblProfessionEdit.Text = "    Profession :";
            // 
            // pnlMemNameEdit
            // 
            this.pnlMemNameEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlMemNameEdit.Location = new System.Drawing.Point(182, 86);
            this.pnlMemNameEdit.Name = "pnlMemNameEdit";
            this.pnlMemNameEdit.Size = new System.Drawing.Size(272, 2);
            this.pnlMemNameEdit.TabIndex = 88;
            // 
            // txtBoxMemNameEdit
            // 
            this.txtBoxMemNameEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxMemNameEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMemNameEdit.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.txtBoxMemNameEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxMemNameEdit.Location = new System.Drawing.Point(182, 64);
            this.txtBoxMemNameEdit.Name = "txtBoxMemNameEdit";
            this.txtBoxMemNameEdit.Size = new System.Drawing.Size(272, 20);
            this.txtBoxMemNameEdit.TabIndex = 87;
            // 
            // lblMemNameEdit
            // 
            this.lblMemNameEdit.AutoSize = true;
            this.lblMemNameEdit.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.lblMemNameEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblMemNameEdit.Location = new System.Drawing.Point(37, 67);
            this.lblMemNameEdit.Name = "lblMemNameEdit";
            this.lblMemNameEdit.Size = new System.Drawing.Size(128, 21);
            this.lblMemNameEdit.TabIndex = 86;
            this.lblMemNameEdit.Text = "             Name :";
            // 
            // lblDoBEdit
            // 
            this.lblDoBEdit.AutoSize = true;
            this.lblDoBEdit.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.lblDoBEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblDoBEdit.Location = new System.Drawing.Point(34, 147);
            this.lblDoBEdit.Name = "lblDoBEdit";
            this.lblDoBEdit.Size = new System.Drawing.Size(126, 21);
            this.lblDoBEdit.TabIndex = 91;
            this.lblDoBEdit.Text = "Date of Birth :";
            // 
            // btnUpdateMem
            // 
            this.btnUpdateMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnUpdateMem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnUpdateMem.FlatAppearance.BorderSize = 2;
            this.btnUpdateMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnUpdateMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMem.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.btnUpdateMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnUpdateMem.Location = new System.Drawing.Point(240, 278);
            this.btnUpdateMem.Name = "btnUpdateMem";
            this.btnUpdateMem.Size = new System.Drawing.Size(154, 42);
            this.btnUpdateMem.TabIndex = 101;
            this.btnUpdateMem.Text = "UPDATE";
            this.btnUpdateMem.UseVisualStyleBackColor = false;
            // 
            // UCEditAcc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.btnUpdateMem);
            this.Controls.Add(this.cmbProfessionEdit);
            this.Controls.Add(this.pnlDoBEdit);
            this.Controls.Add(this.dTPickerDoBEdit);
            this.Controls.Add(this.pnlMemMobileEdit);
            this.Controls.Add(this.txtBoxMemMobileEdit);
            this.Controls.Add(this.pnlMemAddressEdit);
            this.Controls.Add(this.lblMemMobileEdit);
            this.Controls.Add(this.txtBoxMemAddressEdit);
            this.Controls.Add(this.lblMemAddressEdit);
            this.Controls.Add(this.pnlProfessionEdit);
            this.Controls.Add(this.lblProfessionEdit);
            this.Controls.Add(this.pnlMemNameEdit);
            this.Controls.Add(this.txtBoxMemNameEdit);
            this.Controls.Add(this.lblMemNameEdit);
            this.Controls.Add(this.lblDoBEdit);
            this.Controls.Add(this.pnlUCEditAcc);
            this.Name = "UCEditAcc";
            this.Size = new System.Drawing.Size(514, 345);
            this.pnlUCEditAcc.ResumeLayout(false);
            this.pnlUCEditAcc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUCEditAcc;
        private System.Windows.Forms.Label lblEditAccountDetails;
        private System.Windows.Forms.ComboBox cmbProfessionEdit;
        private System.Windows.Forms.Panel pnlDoBEdit;
        private System.Windows.Forms.DateTimePicker dTPickerDoBEdit;
        private System.Windows.Forms.Panel pnlMemMobileEdit;
        private System.Windows.Forms.TextBox txtBoxMemMobileEdit;
        private System.Windows.Forms.Panel pnlMemAddressEdit;
        private System.Windows.Forms.Label lblMemMobileEdit;
        private System.Windows.Forms.TextBox txtBoxMemAddressEdit;
        private System.Windows.Forms.Label lblMemAddressEdit;
        private System.Windows.Forms.Panel pnlProfessionEdit;
        private System.Windows.Forms.Label lblProfessionEdit;
        private System.Windows.Forms.Panel pnlMemNameEdit;
        private System.Windows.Forms.TextBox txtBoxMemNameEdit;
        private System.Windows.Forms.Label lblMemNameEdit;
        private System.Windows.Forms.Label lblDoBEdit;
        private System.Windows.Forms.Button btnUpdateMem;
    }
}
