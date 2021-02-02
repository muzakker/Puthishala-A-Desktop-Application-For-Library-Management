
namespace Project.LMS.AppLayer
{
    partial class UCMyStatus
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
            this.pnlMyStatus = new System.Windows.Forms.Panel();
            this.lblMyStatus = new System.Windows.Forms.Label();
            this.pnlMyStat = new System.Windows.Forms.Panel();
            this.dGVMyStatus = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMyStatus.SuspendLayout();
            this.pnlMyStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMyStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMyStatus
            // 
            this.pnlMyStatus.BackColor = System.Drawing.Color.Green;
            this.pnlMyStatus.Controls.Add(this.lblMyStatus);
            this.pnlMyStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlMyStatus.Name = "pnlMyStatus";
            this.pnlMyStatus.Size = new System.Drawing.Size(657, 57);
            this.pnlMyStatus.TabIndex = 40;
            // 
            // lblMyStatus
            // 
            this.lblMyStatus.AutoSize = true;
            this.lblMyStatus.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblMyStatus.Location = new System.Drawing.Point(239, 13);
            this.lblMyStatus.Name = "lblMyStatus";
            this.lblMyStatus.Size = new System.Drawing.Size(193, 34);
            this.lblMyStatus.TabIndex = 0;
            this.lblMyStatus.Text = "MY STATUS";
            // 
            // pnlMyStat
            // 
            this.pnlMyStat.Controls.Add(this.dGVMyStatus);
            this.pnlMyStat.Location = new System.Drawing.Point(1, 135);
            this.pnlMyStat.Name = "pnlMyStat";
            this.pnlMyStat.Size = new System.Drawing.Size(657, 336);
            this.pnlMyStat.TabIndex = 41;
            // 
            // dGVMyStatus
            // 
            this.dGVMyStatus.AllowUserToAddRows = false;
            this.dGVMyStatus.AllowUserToDeleteRows = false;
            this.dGVMyStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVMyStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMyStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.MemberName,
            this.BookName,
            this.Author,
            this.IssueDate,
            this.Duration});
            this.dGVMyStatus.Location = new System.Drawing.Point(9, 25);
            this.dGVMyStatus.Name = "dGVMyStatus";
            this.dGVMyStatus.ReadOnly = true;
            this.dGVMyStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVMyStatus.Size = new System.Drawing.Size(638, 259);
            this.dGVMyStatus.TabIndex = 0;
            // 
            // MemberID
            // 
            this.MemberID.DataPropertyName = "MemberID";
            this.MemberID.HeaderText = "Member ID";
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            // 
            // MemberName
            // 
            this.MemberName.DataPropertyName = "MemberName";
            this.MemberName.HeaderText = "Member Name";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // IssueDate
            // 
            this.IssueDate.DataPropertyName = "IssueDate";
            this.IssueDate.HeaderText = "Issue Date";
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // UCMyStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.pnlMyStatus);
            this.Controls.Add(this.pnlMyStat);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCMyStatus";
            this.Size = new System.Drawing.Size(658, 563);
            this.Load += new System.EventHandler(this.UCMyStatus_Load);
            this.pnlMyStatus.ResumeLayout(false);
            this.pnlMyStatus.PerformLayout();
            this.pnlMyStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMyStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMyStatus;
        private System.Windows.Forms.Label lblMyStatus;
        private System.Windows.Forms.Panel pnlMyStat;
        private System.Windows.Forms.DataGridView dGVMyStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
    }
}
