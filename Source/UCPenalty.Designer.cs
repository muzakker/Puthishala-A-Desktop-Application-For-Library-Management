
namespace Project.LMS.AppLayer
{
    partial class UCPenalty
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
            this.pnlPenaltyTitle = new System.Windows.Forms.Panel();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.pnlPenaltyDetails = new System.Windows.Forms.Panel();
            this.btnPenaltyAmount = new System.Windows.Forms.Button();
            this.btnDurationExceed = new System.Windows.Forms.Button();
            this.txtBoxDurationExceed = new System.Windows.Forms.TextBox();
            this.txtBoxPenaltyAmount = new System.Windows.Forms.TextBox();
            this.btnPenalty = new System.Windows.Forms.Button();
            this.dGVPenalty = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPenaltyTitle.SuspendLayout();
            this.pnlPenaltyDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPenalty)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPenaltyTitle
            // 
            this.pnlPenaltyTitle.BackColor = System.Drawing.Color.Green;
            this.pnlPenaltyTitle.Controls.Add(this.lblPenalty);
            this.pnlPenaltyTitle.Location = new System.Drawing.Point(0, -1);
            this.pnlPenaltyTitle.Name = "pnlPenaltyTitle";
            this.pnlPenaltyTitle.Size = new System.Drawing.Size(657, 57);
            this.pnlPenaltyTitle.TabIndex = 24;
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenalty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblPenalty.Location = new System.Drawing.Point(190, 13);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(303, 34);
            this.lblPenalty.TabIndex = 0;
            this.lblPenalty.Text = "PENALTY REPORT";
            // 
            // pnlPenaltyDetails
            // 
            this.pnlPenaltyDetails.Controls.Add(this.btnPenaltyAmount);
            this.pnlPenaltyDetails.Controls.Add(this.btnDurationExceed);
            this.pnlPenaltyDetails.Controls.Add(this.txtBoxDurationExceed);
            this.pnlPenaltyDetails.Controls.Add(this.txtBoxPenaltyAmount);
            this.pnlPenaltyDetails.Controls.Add(this.btnPenalty);
            this.pnlPenaltyDetails.Controls.Add(this.dGVPenalty);
            this.pnlPenaltyDetails.Location = new System.Drawing.Point(1, 128);
            this.pnlPenaltyDetails.Name = "pnlPenaltyDetails";
            this.pnlPenaltyDetails.Size = new System.Drawing.Size(657, 346);
            this.pnlPenaltyDetails.TabIndex = 25;
            // 
            // btnPenaltyAmount
            // 
            this.btnPenaltyAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnPenaltyAmount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnPenaltyAmount.FlatAppearance.BorderSize = 2;
            this.btnPenaltyAmount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnPenaltyAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenaltyAmount.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenaltyAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnPenaltyAmount.Location = new System.Drawing.Point(245, 302);
            this.btnPenaltyAmount.Name = "btnPenaltyAmount";
            this.btnPenaltyAmount.Size = new System.Drawing.Size(130, 30);
            this.btnPenaltyAmount.TabIndex = 48;
            this.btnPenaltyAmount.Text = "Penalty Amount";
            this.btnPenaltyAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPenaltyAmount.UseVisualStyleBackColor = false;
            this.btnPenaltyAmount.Click += new System.EventHandler(this.btnPenaltyAmount_Click);
            // 
            // btnDurationExceed
            // 
            this.btnDurationExceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnDurationExceed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnDurationExceed.FlatAppearance.BorderSize = 2;
            this.btnDurationExceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDurationExceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurationExceed.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDurationExceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnDurationExceed.Location = new System.Drawing.Point(9, 302);
            this.btnDurationExceed.Name = "btnDurationExceed";
            this.btnDurationExceed.Size = new System.Drawing.Size(156, 30);
            this.btnDurationExceed.TabIndex = 28;
            this.btnDurationExceed.Text = "Duration Exceeded";
            this.btnDurationExceed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDurationExceed.UseVisualStyleBackColor = false;
            this.btnDurationExceed.Click += new System.EventHandler(this.btnDurationExceed_Click);
            // 
            // txtBoxDurationExceed
            // 
            this.txtBoxDurationExceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxDurationExceed.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDurationExceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxDurationExceed.Location = new System.Drawing.Point(174, 304);
            this.txtBoxDurationExceed.Name = "txtBoxDurationExceed";
            this.txtBoxDurationExceed.Size = new System.Drawing.Size(48, 28);
            this.txtBoxDurationExceed.TabIndex = 47;
            // 
            // txtBoxPenaltyAmount
            // 
            this.txtBoxPenaltyAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxPenaltyAmount.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPenaltyAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxPenaltyAmount.Location = new System.Drawing.Point(381, 304);
            this.txtBoxPenaltyAmount.Name = "txtBoxPenaltyAmount";
            this.txtBoxPenaltyAmount.Size = new System.Drawing.Size(87, 28);
            this.txtBoxPenaltyAmount.TabIndex = 45;
            // 
            // btnPenalty
            // 
            this.btnPenalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnPenalty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnPenalty.FlatAppearance.BorderSize = 2;
            this.btnPenalty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPenalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenalty.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenalty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnPenalty.Location = new System.Drawing.Point(512, 302);
            this.btnPenalty.Name = "btnPenalty";
            this.btnPenalty.Size = new System.Drawing.Size(133, 30);
            this.btnPenalty.TabIndex = 44;
            this.btnPenalty.Text = "Penalize";
            this.btnPenalty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPenalty.UseVisualStyleBackColor = false;
            this.btnPenalty.Click += new System.EventHandler(this.btnPenalty_Click);
            // 
            // dGVPenalty
            // 
            this.dGVPenalty.AllowUserToAddRows = false;
            this.dGVPenalty.AllowUserToDeleteRows = false;
            this.dGVPenalty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPenalty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.MemberName,
            this.BookName,
            this.Author,
            this.IssueDate,
            this.Duration});
            this.dGVPenalty.Location = new System.Drawing.Point(9, 25);
            this.dGVPenalty.Name = "dGVPenalty";
            this.dGVPenalty.ReadOnly = true;
            this.dGVPenalty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPenalty.Size = new System.Drawing.Size(638, 259);
            this.dGVPenalty.TabIndex = 0;
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
            // UCPenalty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.pnlPenaltyTitle);
            this.Controls.Add(this.pnlPenaltyDetails);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCPenalty";
            this.Size = new System.Drawing.Size(658, 563);
            this.Load += new System.EventHandler(this.UCPenalty_Load);
            this.pnlPenaltyTitle.ResumeLayout(false);
            this.pnlPenaltyTitle.PerformLayout();
            this.pnlPenaltyDetails.ResumeLayout(false);
            this.pnlPenaltyDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPenalty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPenaltyTitle;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Panel pnlPenaltyDetails;
        private System.Windows.Forms.Button btnPenalty;
        private System.Windows.Forms.DataGridView dGVPenalty;
        private System.Windows.Forms.TextBox txtBoxPenaltyAmount;
        private System.Windows.Forms.TextBox txtBoxDurationExceed;
        private System.Windows.Forms.Button btnDurationExceed;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Button btnPenaltyAmount;
    }
}
