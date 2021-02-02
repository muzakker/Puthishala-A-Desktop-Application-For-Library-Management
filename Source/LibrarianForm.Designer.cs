
namespace Project.LMS.AppLayer
{
    partial class LibrarianForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianForm));
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPenalty = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnViewMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.pnlLibrarianHome = new System.Windows.Forms.Panel();
            this.pnlOptionDivLib = new System.Windows.Forms.Panel();
            this.lblLibrarian = new System.Windows.Forms.Label();
            this.lblLibName = new System.Windows.Forms.Label();
            this.pnlOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOption
            // 
            this.pnlOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.pnlOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOption.Controls.Add(this.lblLibName);
            this.pnlOption.Controls.Add(this.lblLibrarian);
            this.pnlOption.Controls.Add(this.btnHome);
            this.pnlOption.Controls.Add(this.btnPenalty);
            this.pnlOption.Controls.Add(this.btnInventory);
            this.pnlOption.Controls.Add(this.btnViewMember);
            this.pnlOption.Controls.Add(this.btnAddMember);
            this.pnlOption.Controls.Add(this.btnReturnBook);
            this.pnlOption.Controls.Add(this.btnLogOut);
            this.pnlOption.Controls.Add(this.btnAddBook);
            this.pnlOption.Controls.Add(this.btnIssueBook);
            this.pnlOption.Location = new System.Drawing.Point(1, 2);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(238, 562);
            this.pnlOption.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnHome.FlatAppearance.BorderSize = 2;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnHome.Location = new System.Drawing.Point(3, 52);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(216, 51);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPenalty
            // 
            this.btnPenalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnPenalty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnPenalty.FlatAppearance.BorderSize = 2;
            this.btnPenalty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPenalty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnPenalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenalty.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.btnPenalty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnPenalty.Location = new System.Drawing.Point(3, 451);
            this.btnPenalty.Name = "btnPenalty";
            this.btnPenalty.Size = new System.Drawing.Size(216, 51);
            this.btnPenalty.TabIndex = 7;
            this.btnPenalty.Text = "Penalty";
            this.btnPenalty.UseVisualStyleBackColor = false;
            this.btnPenalty.Click += new System.EventHandler(this.btnPenalty_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnInventory.FlatAppearance.BorderSize = 2;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnInventory.Location = new System.Drawing.Point(3, 166);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(216, 51);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnViewMember
            // 
            this.btnViewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnViewMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewMember.FlatAppearance.BorderSize = 2;
            this.btnViewMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnViewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMember.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.btnViewMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewMember.Location = new System.Drawing.Point(3, 280);
            this.btnViewMember.Name = "btnViewMember";
            this.btnViewMember.Size = new System.Drawing.Size(216, 51);
            this.btnViewMember.TabIndex = 4;
            this.btnViewMember.Text = "View Members";
            this.btnViewMember.UseVisualStyleBackColor = false;
            this.btnViewMember.Click += new System.EventHandler(this.btnViewMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnAddMember.FlatAppearance.BorderSize = 2;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.btnAddMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnAddMember.Location = new System.Drawing.Point(3, 223);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(216, 51);
            this.btnAddMember.TabIndex = 3;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnReturnBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnReturnBook.FlatAppearance.BorderSize = 2;
            this.btnReturnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.btnReturnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnReturnBook.Location = new System.Drawing.Point(3, 394);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(216, 51);
            this.btnReturnBook.TabIndex = 6;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnLogOut.FlatAppearance.BorderSize = 2;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnLogOut.Location = new System.Drawing.Point(3, 508);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(216, 51);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Sign Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnAddBook.FlatAppearance.BorderSize = 2;
            this.btnAddBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.btnAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnAddBook.Location = new System.Drawing.Point(3, 109);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(216, 51);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnIssueBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnIssueBook.FlatAppearance.BorderSize = 2;
            this.btnIssueBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIssueBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.btnIssueBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnIssueBook.Location = new System.Drawing.Point(3, 337);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(216, 51);
            this.btnIssueBook.TabIndex = 5;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // pnlLibrarianHome
            // 
            this.pnlLibrarianHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLibrarianHome.ForeColor = System.Drawing.Color.Black;
            this.pnlLibrarianHome.Location = new System.Drawing.Point(237, 2);
            this.pnlLibrarianHome.Name = "pnlLibrarianHome";
            this.pnlLibrarianHome.Size = new System.Drawing.Size(658, 562);
            this.pnlLibrarianHome.TabIndex = 5;
            // 
            // pnlOptionDivLib
            // 
            this.pnlOptionDivLib.BackColor = System.Drawing.Color.Green;
            this.pnlOptionDivLib.Location = new System.Drawing.Point(226, 1);
            this.pnlOptionDivLib.Name = "pnlOptionDivLib";
            this.pnlOptionDivLib.Size = new System.Drawing.Size(10, 564);
            this.pnlOptionDivLib.TabIndex = 7;
            // 
            // lblLibrarian
            // 
            this.lblLibrarian.AutoSize = true;
            this.lblLibrarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarian.Location = new System.Drawing.Point(10, 6);
            this.lblLibrarian.Name = "lblLibrarian";
            this.lblLibrarian.Size = new System.Drawing.Size(92, 24);
            this.lblLibrarian.TabIndex = 9;
            this.lblLibrarian.Text = "Librarian :";
            // 
            // lblLibName
            // 
            this.lblLibName.AutoSize = true;
            this.lblLibName.Location = new System.Drawing.Point(105, 6);
            this.lblLibName.Name = "lblLibName";
            this.lblLibName.Size = new System.Drawing.Size(0, 24);
            this.lblLibName.TabIndex = 10;
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(897, 565);
            this.Controls.Add(this.pnlOptionDivLib);
            this.Controls.Add(this.pnlLibrarianHome);
            this.Controls.Add(this.pnlOption);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "LibrarianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LibrarianForm_FormClosed);
            this.Load += new System.EventHandler(this.LibrarianForm_Load);
            this.pnlOption.ResumeLayout(false);
            this.pnlOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnViewMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnPenalty;
        private System.Windows.Forms.Button btnReturnBook;
        internal System.Windows.Forms.Panel pnlLibrarianHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlOptionDivLib;
        private System.Windows.Forms.Label lblLibName;
        private System.Windows.Forms.Label lblLibrarian;
    }
}