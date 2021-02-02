
namespace Project.LMS.AppLayer
{
    partial class UCReturnBook
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
            this.pnlReturnBTitle = new System.Windows.Forms.Panel();
            this.lblReturnBook = new System.Windows.Forms.Label();
            this.pnlReturnDetaills = new System.Windows.Forms.Panel();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.dGVReturnDetails = new System.Windows.Forms.DataGridView();
            this.btnSearchMemRB = new System.Windows.Forms.Button();
            this.txtBoxSearchMemRB = new System.Windows.Forms.TextBox();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReturnBTitle.SuspendLayout();
            this.pnlReturnDetaills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReturnDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReturnBTitle
            // 
            this.pnlReturnBTitle.BackColor = System.Drawing.Color.Green;
            this.pnlReturnBTitle.Controls.Add(this.lblReturnBook);
            this.pnlReturnBTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlReturnBTitle.Name = "pnlReturnBTitle";
            this.pnlReturnBTitle.Size = new System.Drawing.Size(657, 57);
            this.pnlReturnBTitle.TabIndex = 20;
            // 
            // lblReturnBook
            // 
            this.lblReturnBook.AutoSize = true;
            this.lblReturnBook.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblReturnBook.Location = new System.Drawing.Point(208, 13);
            this.lblReturnBook.Name = "lblReturnBook";
            this.lblReturnBook.Size = new System.Drawing.Size(242, 34);
            this.lblReturnBook.TabIndex = 0;
            this.lblReturnBook.Text = "RETURN BOOK";
            // 
            // pnlReturnDetaills
            // 
            this.pnlReturnDetaills.Controls.Add(this.btnReturnBook);
            this.pnlReturnDetaills.Controls.Add(this.dGVReturnDetails);
            this.pnlReturnDetaills.Location = new System.Drawing.Point(1, 174);
            this.pnlReturnDetaills.Name = "pnlReturnDetaills";
            this.pnlReturnDetaills.Size = new System.Drawing.Size(657, 346);
            this.pnlReturnDetaills.TabIndex = 21;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnReturnBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnReturnBook.FlatAppearance.BorderSize = 2;
            this.btnReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnReturnBook.Location = new System.Drawing.Point(496, 302);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(151, 30);
            this.btnReturnBook.TabIndex = 44;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // dGVReturnDetails
            // 
            this.dGVReturnDetails.AllowUserToAddRows = false;
            this.dGVReturnDetails.AllowUserToDeleteRows = false;
            this.dGVReturnDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVReturnDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReturnDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.MemberName,
            this.BookName,
            this.Author,
            this.IssueDate,
            this.Duration});
            this.dGVReturnDetails.Location = new System.Drawing.Point(9, 25);
            this.dGVReturnDetails.Name = "dGVReturnDetails";
            this.dGVReturnDetails.ReadOnly = true;
            this.dGVReturnDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVReturnDetails.Size = new System.Drawing.Size(638, 259);
            this.dGVReturnDetails.TabIndex = 0;
            // 
            // btnSearchMemRB
            // 
            this.btnSearchMemRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnSearchMemRB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchMemRB.FlatAppearance.BorderSize = 2;
            this.btnSearchMemRB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSearchMemRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMemRB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMemRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchMemRB.Location = new System.Drawing.Point(246, 127);
            this.btnSearchMemRB.Name = "btnSearchMemRB";
            this.btnSearchMemRB.Size = new System.Drawing.Size(102, 30);
            this.btnSearchMemRB.TabIndex = 23;
            this.btnSearchMemRB.Text = "Search";
            this.btnSearchMemRB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchMemRB.UseVisualStyleBackColor = false;
            this.btnSearchMemRB.Click += new System.EventHandler(this.btnSearchMemRB_Click);
            // 
            // txtBoxSearchMemRB
            // 
            this.txtBoxSearchMemRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxSearchMemRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearchMemRB.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchMemRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxSearchMemRB.Location = new System.Drawing.Point(10, 127);
            this.txtBoxSearchMemRB.Name = "txtBoxSearchMemRB";
            this.txtBoxSearchMemRB.Size = new System.Drawing.Size(220, 30);
            this.txtBoxSearchMemRB.TabIndex = 22;
            this.txtBoxSearchMemRB.Text = "      Search Member";
            this.txtBoxSearchMemRB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxSearchMemRB_MouseClick);
            this.txtBoxSearchMemRB.TextChanged += new System.EventHandler(this.txtBoxSearchMemRB_TextChanged);
            // 
            // MemberID
            // 
            this.MemberID.DataPropertyName = "MemberID";
            this.MemberID.HeaderText = "MemberID";
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
            // UCReturnBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.pnlReturnBTitle);
            this.Controls.Add(this.pnlReturnDetaills);
            this.Controls.Add(this.btnSearchMemRB);
            this.Controls.Add(this.txtBoxSearchMemRB);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCReturnBook";
            this.Size = new System.Drawing.Size(658, 563);
            this.Load += new System.EventHandler(this.UCReturnBook_Load);
            this.pnlReturnBTitle.ResumeLayout(false);
            this.pnlReturnBTitle.PerformLayout();
            this.pnlReturnDetaills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVReturnDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlReturnBTitle;
        private System.Windows.Forms.Label lblReturnBook;
        private System.Windows.Forms.Panel pnlReturnDetaills;
        private System.Windows.Forms.DataGridView dGVReturnDetails;
        private System.Windows.Forms.Button btnSearchMemRB;
        private System.Windows.Forms.TextBox txtBoxSearchMemRB;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
    }
}
