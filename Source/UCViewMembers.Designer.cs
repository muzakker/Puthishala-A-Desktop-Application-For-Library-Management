
namespace Project.LMS.AppLayer
{
    partial class UCViewMembers
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
            this.pnlMemTitle = new System.Windows.Forms.Panel();
            this.lblMemView = new System.Windows.Forms.Label();
            this.pnlMemDetails = new System.Windows.Forms.Panel();
            this.btnMemRmv = new System.Windows.Forms.Button();
            this.dGVMemDetails = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchMem = new System.Windows.Forms.Button();
            this.txtBoxSearchMem = new System.Windows.Forms.TextBox();
            this.btnShowAllMem = new System.Windows.Forms.Button();
            this.pnlMemTitle.SuspendLayout();
            this.pnlMemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMemTitle
            // 
            this.pnlMemTitle.BackColor = System.Drawing.Color.Green;
            this.pnlMemTitle.Controls.Add(this.lblMemView);
            this.pnlMemTitle.Location = new System.Drawing.Point(1, 1);
            this.pnlMemTitle.Name = "pnlMemTitle";
            this.pnlMemTitle.Size = new System.Drawing.Size(657, 57);
            this.pnlMemTitle.TabIndex = 16;
            // 
            // lblMemView
            // 
            this.lblMemView.AutoSize = true;
            this.lblMemView.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblMemView.Location = new System.Drawing.Point(174, 13);
            this.lblMemView.Name = "lblMemView";
            this.lblMemView.Size = new System.Drawing.Size(306, 34);
            this.lblMemView.TabIndex = 0;
            this.lblMemView.Text = "MEMBER DETAILS";
            // 
            // pnlMemDetails
            // 
            this.pnlMemDetails.Controls.Add(this.btnMemRmv);
            this.pnlMemDetails.Controls.Add(this.dGVMemDetails);
            this.pnlMemDetails.Location = new System.Drawing.Point(1, 175);
            this.pnlMemDetails.Name = "pnlMemDetails";
            this.pnlMemDetails.Size = new System.Drawing.Size(657, 346);
            this.pnlMemDetails.TabIndex = 17;
            // 
            // btnMemRmv
            // 
            this.btnMemRmv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnMemRmv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnMemRmv.FlatAppearance.BorderSize = 2;
            this.btnMemRmv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMemRmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemRmv.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemRmv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnMemRmv.Location = new System.Drawing.Point(245, 295);
            this.btnMemRmv.Name = "btnMemRmv";
            this.btnMemRmv.Size = new System.Drawing.Size(102, 37);
            this.btnMemRmv.TabIndex = 21;
            this.btnMemRmv.Text = "Remove";
            this.btnMemRmv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMemRmv.UseVisualStyleBackColor = false;
            this.btnMemRmv.Click += new System.EventHandler(this.btnMemRmv_Click);
            // 
            // dGVMemDetails
            // 
            this.dGVMemDetails.AllowUserToAddRows = false;
            this.dGVMemDetails.AllowUserToDeleteRows = false;
            this.dGVMemDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVMemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMemDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.MemberName,
            this.Profession,
            this.DateofBirth,
            this.Address,
            this.MobileNo});
            this.dGVMemDetails.Location = new System.Drawing.Point(9, 25);
            this.dGVMemDetails.Name = "dGVMemDetails";
            this.dGVMemDetails.ReadOnly = true;
            this.dGVMemDetails.RowHeadersWidth = 51;
            this.dGVMemDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVMemDetails.Size = new System.Drawing.Size(638, 259);
            this.dGVMemDetails.TabIndex = 0;
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
            // btnSearchMem
            // 
            this.btnSearchMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnSearchMem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchMem.FlatAppearance.BorderSize = 2;
            this.btnSearchMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSearchMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMem.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchMem.Location = new System.Drawing.Point(246, 128);
            this.btnSearchMem.Name = "btnSearchMem";
            this.btnSearchMem.Size = new System.Drawing.Size(102, 30);
            this.btnSearchMem.TabIndex = 19;
            this.btnSearchMem.Text = "Search";
            this.btnSearchMem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchMem.UseVisualStyleBackColor = false;
            this.btnSearchMem.Click += new System.EventHandler(this.btnSearchMem_Click);
            // 
            // txtBoxSearchMem
            // 
            this.txtBoxSearchMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxSearchMem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearchMem.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxSearchMem.Location = new System.Drawing.Point(10, 128);
            this.txtBoxSearchMem.Name = "txtBoxSearchMem";
            this.txtBoxSearchMem.Size = new System.Drawing.Size(220, 30);
            this.txtBoxSearchMem.TabIndex = 18;
            this.txtBoxSearchMem.Text = "    Search by Name";
            this.txtBoxSearchMem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxSearchMem_MouseClick);
            this.txtBoxSearchMem.TextChanged += new System.EventHandler(this.txtBoxSearchMem_TextChanged);
            // 
            // btnShowAllMem
            // 
            this.btnShowAllMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnShowAllMem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllMem.FlatAppearance.BorderSize = 2;
            this.btnShowAllMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnShowAllMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllMem.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllMem.Location = new System.Drawing.Point(354, 128);
            this.btnShowAllMem.Name = "btnShowAllMem";
            this.btnShowAllMem.Size = new System.Drawing.Size(102, 30);
            this.btnShowAllMem.TabIndex = 20;
            this.btnShowAllMem.Text = "Show All";
            this.btnShowAllMem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowAllMem.UseVisualStyleBackColor = false;
            this.btnShowAllMem.Click += new System.EventHandler(this.btnShowAllMem_Click);
            // 
            // UCViewMembers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.btnShowAllMem);
            this.Controls.Add(this.pnlMemTitle);
            this.Controls.Add(this.pnlMemDetails);
            this.Controls.Add(this.btnSearchMem);
            this.Controls.Add(this.txtBoxSearchMem);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCViewMembers";
            this.Size = new System.Drawing.Size(658, 563);
            this.Load += new System.EventHandler(this.UCViewMembers_Load);
            this.pnlMemTitle.ResumeLayout(false);
            this.pnlMemTitle.PerformLayout();
            this.pnlMemDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMemDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMemTitle;
        private System.Windows.Forms.Label lblMemView;
        private System.Windows.Forms.Panel pnlMemDetails;
        private System.Windows.Forms.DataGridView dGVMemDetails;
        private System.Windows.Forms.Button btnSearchMem;
        private System.Windows.Forms.TextBox txtBoxSearchMem;
        private System.Windows.Forms.Button btnShowAllMem;
        private System.Windows.Forms.Button btnMemRmv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
    }
}
