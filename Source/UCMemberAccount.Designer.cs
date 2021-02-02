
namespace Project.LMS.AppLayer
{
    partial class UCMemberAccount
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
            this.pnlMemAccTitle = new System.Windows.Forms.Panel();
            this.lblMyAccount = new System.Windows.Forms.Label();
            this.btnViewAcc = new System.Windows.Forms.Button();
            this.btnEditAcc = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pnlMyAccountHome = new System.Windows.Forms.Panel();
            this.pnlMemAccTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMemAccTitle
            // 
            this.pnlMemAccTitle.BackColor = System.Drawing.Color.Green;
            this.pnlMemAccTitle.Controls.Add(this.lblMyAccount);
            this.pnlMemAccTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlMemAccTitle.Name = "pnlMemAccTitle";
            this.pnlMemAccTitle.Size = new System.Drawing.Size(657, 57);
            this.pnlMemAccTitle.TabIndex = 25;
            // 
            // lblMyAccount
            // 
            this.lblMyAccount.AutoSize = true;
            this.lblMyAccount.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblMyAccount.Location = new System.Drawing.Point(217, 13);
            this.lblMyAccount.Name = "lblMyAccount";
            this.lblMyAccount.Size = new System.Drawing.Size(217, 34);
            this.lblMyAccount.TabIndex = 0;
            this.lblMyAccount.Text = "MY ACCOUNT";
            // 
            // btnViewAcc
            // 
            this.btnViewAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnViewAcc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewAcc.FlatAppearance.BorderSize = 2;
            this.btnViewAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnViewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAcc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewAcc.Location = new System.Drawing.Point(71, 81);
            this.btnViewAcc.Name = "btnViewAcc";
            this.btnViewAcc.Size = new System.Drawing.Size(138, 38);
            this.btnViewAcc.TabIndex = 28;
            this.btnViewAcc.Text = "View Account";
            this.btnViewAcc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewAcc.UseVisualStyleBackColor = false;
            this.btnViewAcc.Click += new System.EventHandler(this.btnViewAcc_Click);
            // 
            // btnEditAcc
            // 
            this.btnEditAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnEditAcc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnEditAcc.FlatAppearance.BorderSize = 2;
            this.btnEditAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnEditAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAcc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnEditAcc.Location = new System.Drawing.Point(245, 81);
            this.btnEditAcc.Name = "btnEditAcc";
            this.btnEditAcc.Size = new System.Drawing.Size(138, 38);
            this.btnEditAcc.TabIndex = 29;
            this.btnEditAcc.Text = "Edit Account";
            this.btnEditAcc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditAcc.UseVisualStyleBackColor = false;
            this.btnEditAcc.Click += new System.EventHandler(this.btnEditAcc_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 2;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnChangePassword.Location = new System.Drawing.Point(412, 81);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(174, 38);
            this.btnChangePassword.TabIndex = 30;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // pnlMyAccountHome
            // 
            this.pnlMyAccountHome.Location = new System.Drawing.Point(71, 138);
            this.pnlMyAccountHome.Name = "pnlMyAccountHome";
            this.pnlMyAccountHome.Size = new System.Drawing.Size(514, 345);
            this.pnlMyAccountHome.TabIndex = 31;
            // 
            // UCMemberAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.pnlMyAccountHome);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnEditAcc);
            this.Controls.Add(this.btnViewAcc);
            this.Controls.Add(this.pnlMemAccTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCMemberAccount";
            this.Size = new System.Drawing.Size(658, 563);
            this.Load += new System.EventHandler(this.UCMemberAccount_Load);
            this.pnlMemAccTitle.ResumeLayout(false);
            this.pnlMemAccTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMemAccTitle;
        private System.Windows.Forms.Label lblMyAccount;
        private System.Windows.Forms.Button btnViewAcc;
        private System.Windows.Forms.Button btnEditAcc;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel pnlMyAccountHome;
    }
}
