
namespace Project.LMS.AppLayer
{
    partial class UCPenaltyStatus
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
            this.pnlPenaltyStatus = new System.Windows.Forms.Panel();
            this.lblPenaltyStatus = new System.Windows.Forms.Label();
            this.pnlPenaltyStat = new System.Windows.Forms.Panel();
            this.dGVPenaltyStatus = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationExceed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenaltyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnlPenaltyStatus.SuspendLayout();
            this.pnlPenaltyStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPenaltyStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPenaltyStatus
            // 
            this.pnlPenaltyStatus.BackColor = System.Drawing.Color.Green;
            this.pnlPenaltyStatus.Controls.Add(this.lblPenaltyStatus);
            this.pnlPenaltyStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlPenaltyStatus.Name = "pnlPenaltyStatus";
            this.pnlPenaltyStatus.Size = new System.Drawing.Size(657, 57);
            this.pnlPenaltyStatus.TabIndex = 41;
            // 
            // lblPenaltyStatus
            // 
            this.lblPenaltyStatus.AutoSize = true;
            this.lblPenaltyStatus.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenaltyStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblPenaltyStatus.Location = new System.Drawing.Point(199, 13);
            this.lblPenaltyStatus.Name = "lblPenaltyStatus";
            this.lblPenaltyStatus.Size = new System.Drawing.Size(295, 34);
            this.lblPenaltyStatus.TabIndex = 0;
            this.lblPenaltyStatus.Text = "PENALTY STATUS";
            // 
            // pnlPenaltyStat
            // 
            this.pnlPenaltyStat.Controls.Add(this.btnPayment);
            this.pnlPenaltyStat.Controls.Add(this.dGVPenaltyStatus);
            this.pnlPenaltyStat.Location = new System.Drawing.Point(1, 127);
            this.pnlPenaltyStat.Name = "pnlPenaltyStat";
            this.pnlPenaltyStat.Size = new System.Drawing.Size(657, 344);
            this.pnlPenaltyStat.TabIndex = 44;
            // 
            // dGVPenaltyStatus
            // 
            this.dGVPenaltyStatus.AllowUserToAddRows = false;
            this.dGVPenaltyStatus.AllowUserToDeleteRows = false;
            this.dGVPenaltyStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVPenaltyStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPenaltyStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.MemberName,
            this.DurationExceed,
            this.BookName,
            this.PenaltyAmount});
            this.dGVPenaltyStatus.Location = new System.Drawing.Point(9, 25);
            this.dGVPenaltyStatus.Name = "dGVPenaltyStatus";
            this.dGVPenaltyStatus.ReadOnly = true;
            this.dGVPenaltyStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPenaltyStatus.Size = new System.Drawing.Size(638, 259);
            this.dGVPenaltyStatus.TabIndex = 0;
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
            // DurationExceed
            // 
            this.DurationExceed.DataPropertyName = "DurationExceed";
            this.DurationExceed.HeaderText = "Duration Exceed";
            this.DurationExceed.Name = "DurationExceed";
            this.DurationExceed.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // PenaltyAmount
            // 
            this.PenaltyAmount.DataPropertyName = "PenaltyAmount";
            this.PenaltyAmount.HeaderText = "Penalty Amount";
            this.PenaltyAmount.Name = "PenaltyAmount";
            this.PenaltyAmount.ReadOnly = true;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnPayment.FlatAppearance.BorderSize = 2;
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnPayment.Location = new System.Drawing.Point(237, 290);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(172, 38);
            this.btnPayment.TabIndex = 30;
            this.btnPayment.Text = "Pay the Amount";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // UCPenaltyStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.pnlPenaltyStat);
            this.Controls.Add(this.pnlPenaltyStatus);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCPenaltyStatus";
            this.Size = new System.Drawing.Size(658, 563);
            this.Load += new System.EventHandler(this.UCPenaltyStatus_Load);
            this.pnlPenaltyStatus.ResumeLayout(false);
            this.pnlPenaltyStatus.PerformLayout();
            this.pnlPenaltyStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPenaltyStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPenaltyStatus;
        private System.Windows.Forms.Label lblPenaltyStatus;
        private System.Windows.Forms.Panel pnlPenaltyStat;
        private System.Windows.Forms.DataGridView dGVPenaltyStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationExceed;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenaltyAmount;
        private System.Windows.Forms.Button btnPayment;
    }
}
