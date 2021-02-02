
namespace Project.LMS.AppLayer
{
    partial class UCIssueBook
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
            this.pnlIssueBTitle = new System.Windows.Forms.Panel();
            this.lblIssueBook = new System.Windows.Forms.Label();
            this.pnlInvIssueB = new System.Windows.Forms.Panel();
            this.btnSelectMember = new System.Windows.Forms.Button();
            this.dGVInvIssueB = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewPubIssue = new System.Windows.Forms.Button();
            this.btnViewCategoryIssue = new System.Windows.Forms.Button();
            this.cmbPublicationIssue = new System.Windows.Forms.ComboBox();
            this.lblSelectPublictionIssue = new System.Windows.Forms.Label();
            this.cmbCategoryIssue = new System.Windows.Forms.ComboBox();
            this.lblSelectCategoryIssue = new System.Windows.Forms.Label();
            this.btnSearchBookIssue = new System.Windows.Forms.Button();
            this.txtBoxSearchInvIssue = new System.Windows.Forms.TextBox();
            this.btnShowAllIssueBook = new System.Windows.Forms.Button();
            this.pnlIssueBTitle.SuspendLayout();
            this.pnlInvIssueB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInvIssueB)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIssueBTitle
            // 
            this.pnlIssueBTitle.BackColor = System.Drawing.Color.Green;
            this.pnlIssueBTitle.Controls.Add(this.lblIssueBook);
            this.pnlIssueBTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlIssueBTitle.Name = "pnlIssueBTitle";
            this.pnlIssueBTitle.Size = new System.Drawing.Size(657, 57);
            this.pnlIssueBTitle.TabIndex = 30;
            // 
            // lblIssueBook
            // 
            this.lblIssueBook.AutoSize = true;
            this.lblIssueBook.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblIssueBook.Location = new System.Drawing.Point(229, 13);
            this.lblIssueBook.Name = "lblIssueBook";
            this.lblIssueBook.Size = new System.Drawing.Size(203, 34);
            this.lblIssueBook.TabIndex = 0;
            this.lblIssueBook.Text = "ISSUE BOOK";
            // 
            // pnlInvIssueB
            // 
            this.pnlInvIssueB.Controls.Add(this.btnSelectMember);
            this.pnlInvIssueB.Controls.Add(this.dGVInvIssueB);
            this.pnlInvIssueB.Location = new System.Drawing.Point(1, 194);
            this.pnlInvIssueB.Name = "pnlInvIssueB";
            this.pnlInvIssueB.Size = new System.Drawing.Size(657, 357);
            this.pnlInvIssueB.TabIndex = 31;
            // 
            // btnSelectMember
            // 
            this.btnSelectMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnSelectMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSelectMember.FlatAppearance.BorderSize = 2;
            this.btnSelectMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSelectMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMember.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSelectMember.Location = new System.Drawing.Point(247, 290);
            this.btnSelectMember.Name = "btnSelectMember";
            this.btnSelectMember.Size = new System.Drawing.Size(146, 30);
            this.btnSelectMember.TabIndex = 40;
            this.btnSelectMember.Text = "Select Member";
            this.btnSelectMember.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectMember.UseVisualStyleBackColor = false;
            this.btnSelectMember.Click += new System.EventHandler(this.btnSelectMember_Click);
            // 
            // dGVInvIssueB
            // 
            this.dGVInvIssueB.AllowUserToAddRows = false;
            this.dGVInvIssueB.AllowUserToDeleteRows = false;
            this.dGVInvIssueB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVInvIssueB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInvIssueB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.Author,
            this.PublishedYear,
            this.Publication,
            this.Category,
            this.Price,
            this.Quantity});
            this.dGVInvIssueB.Location = new System.Drawing.Point(9, 12);
            this.dGVInvIssueB.Name = "dGVInvIssueB";
            this.dGVInvIssueB.ReadOnly = true;
            this.dGVInvIssueB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVInvIssueB.Size = new System.Drawing.Size(638, 259);
            this.dGVInvIssueB.TabIndex = 0;
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
            // PublishedYear
            // 
            this.PublishedYear.DataPropertyName = "PublishedYear";
            this.PublishedYear.HeaderText = "PublishedYear";
            this.PublishedYear.Name = "PublishedYear";
            this.PublishedYear.ReadOnly = true;
            // 
            // Publication
            // 
            this.Publication.DataPropertyName = "Category";
            this.Publication.HeaderText = "Publication";
            this.Publication.Name = "Publication";
            this.Publication.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // btnViewPubIssue
            // 
            this.btnViewPubIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnViewPubIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewPubIssue.FlatAppearance.BorderSize = 2;
            this.btnViewPubIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnViewPubIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPubIssue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPubIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewPubIssue.Location = new System.Drawing.Point(370, 108);
            this.btnViewPubIssue.Name = "btnViewPubIssue";
            this.btnViewPubIssue.Size = new System.Drawing.Size(102, 30);
            this.btnViewPubIssue.TabIndex = 39;
            this.btnViewPubIssue.Text = "View";
            this.btnViewPubIssue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewPubIssue.UseVisualStyleBackColor = false;
            this.btnViewPubIssue.Click += new System.EventHandler(this.btnViewPubIssue_Click);
            // 
            // btnViewCategoryIssue
            // 
            this.btnViewCategoryIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnViewCategoryIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewCategoryIssue.FlatAppearance.BorderSize = 2;
            this.btnViewCategoryIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnViewCategoryIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCategoryIssue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCategoryIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewCategoryIssue.Location = new System.Drawing.Point(370, 71);
            this.btnViewCategoryIssue.Name = "btnViewCategoryIssue";
            this.btnViewCategoryIssue.Size = new System.Drawing.Size(102, 30);
            this.btnViewCategoryIssue.TabIndex = 38;
            this.btnViewCategoryIssue.Text = "View";
            this.btnViewCategoryIssue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewCategoryIssue.UseVisualStyleBackColor = false;
            this.btnViewCategoryIssue.Click += new System.EventHandler(this.btnViewCategoryIssue_Click);
            // 
            // cmbPublicationIssue
            // 
            this.cmbPublicationIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.cmbPublicationIssue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPublicationIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.cmbPublicationIssue.FormattingEnabled = true;
            this.cmbPublicationIssue.Items.AddRange(new object[] {
            "Wiley",
            "Modern Publications",
            "Dover Publications",
            "All"});
            this.cmbPublicationIssue.Location = new System.Drawing.Point(173, 108);
            this.cmbPublicationIssue.Name = "cmbPublicationIssue";
            this.cmbPublicationIssue.Size = new System.Drawing.Size(180, 29);
            this.cmbPublicationIssue.TabIndex = 37;
            this.cmbPublicationIssue.Text = " Select Publication";
            // 
            // lblSelectPublictionIssue
            // 
            this.lblSelectPublictionIssue.AutoSize = true;
            this.lblSelectPublictionIssue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPublictionIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblSelectPublictionIssue.Location = new System.Drawing.Point(14, 113);
            this.lblSelectPublictionIssue.Name = "lblSelectPublictionIssue";
            this.lblSelectPublictionIssue.Size = new System.Drawing.Size(161, 21);
            this.lblSelectPublictionIssue.TabIndex = 36;
            this.lblSelectPublictionIssue.Text = "Select Publication :";
            // 
            // cmbCategoryIssue
            // 
            this.cmbCategoryIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.cmbCategoryIssue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.cmbCategoryIssue.FormattingEnabled = true;
            this.cmbCategoryIssue.Items.AddRange(new object[] {
            "Physics",
            "Chemistry",
            "Biology",
            "Mathematics",
            "Computer Science",
            "Bangla Literature",
            "English Literature"});
            this.cmbCategoryIssue.Location = new System.Drawing.Point(173, 73);
            this.cmbCategoryIssue.Name = "cmbCategoryIssue";
            this.cmbCategoryIssue.Size = new System.Drawing.Size(180, 29);
            this.cmbCategoryIssue.TabIndex = 35;
            this.cmbCategoryIssue.Text = "    Select Category";
            // 
            // lblSelectCategoryIssue
            // 
            this.lblSelectCategoryIssue.AutoSize = true;
            this.lblSelectCategoryIssue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategoryIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblSelectCategoryIssue.Location = new System.Drawing.Point(14, 80);
            this.lblSelectCategoryIssue.Name = "lblSelectCategoryIssue";
            this.lblSelectCategoryIssue.Size = new System.Drawing.Size(161, 21);
            this.lblSelectCategoryIssue.TabIndex = 34;
            this.lblSelectCategoryIssue.Text = "     Select Category :";
            // 
            // btnSearchBookIssue
            // 
            this.btnSearchBookIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnSearchBookIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchBookIssue.FlatAppearance.BorderSize = 2;
            this.btnSearchBookIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSearchBookIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBookIssue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBookIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchBookIssue.Location = new System.Drawing.Point(230, 155);
            this.btnSearchBookIssue.Name = "btnSearchBookIssue";
            this.btnSearchBookIssue.Size = new System.Drawing.Size(102, 30);
            this.btnSearchBookIssue.TabIndex = 33;
            this.btnSearchBookIssue.Text = "Search";
            this.btnSearchBookIssue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchBookIssue.UseVisualStyleBackColor = false;
            this.btnSearchBookIssue.Click += new System.EventHandler(this.btnSearchBookIssue_Click);
            // 
            // txtBoxSearchInvIssue
            // 
            this.txtBoxSearchInvIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxSearchInvIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearchInvIssue.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchInvIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxSearchInvIssue.Location = new System.Drawing.Point(17, 155);
            this.txtBoxSearchInvIssue.Name = "txtBoxSearchInvIssue";
            this.txtBoxSearchInvIssue.Size = new System.Drawing.Size(200, 30);
            this.txtBoxSearchInvIssue.TabIndex = 32;
            this.txtBoxSearchInvIssue.Text = "    Search by Name";
            this.txtBoxSearchInvIssue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxSearchInvIssue_MouseClick);
            this.txtBoxSearchInvIssue.TextChanged += new System.EventHandler(this.txtBoxSearchInvIssue_TextChanged);
            // 
            // btnShowAllIssueBook
            // 
            this.btnShowAllIssueBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnShowAllIssueBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllIssueBook.FlatAppearance.BorderSize = 2;
            this.btnShowAllIssueBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnShowAllIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllIssueBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllIssueBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllIssueBook.Location = new System.Drawing.Point(338, 155);
            this.btnShowAllIssueBook.Name = "btnShowAllIssueBook";
            this.btnShowAllIssueBook.Size = new System.Drawing.Size(102, 30);
            this.btnShowAllIssueBook.TabIndex = 40;
            this.btnShowAllIssueBook.Text = "Show All";
            this.btnShowAllIssueBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowAllIssueBook.UseVisualStyleBackColor = false;
            this.btnShowAllIssueBook.Click += new System.EventHandler(this.btnShowAllIssueBook_Click);
            // 
            // UCIssueBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.btnShowAllIssueBook);
            this.Controls.Add(this.pnlIssueBTitle);
            this.Controls.Add(this.pnlInvIssueB);
            this.Controls.Add(this.btnViewPubIssue);
            this.Controls.Add(this.btnViewCategoryIssue);
            this.Controls.Add(this.cmbPublicationIssue);
            this.Controls.Add(this.lblSelectPublictionIssue);
            this.Controls.Add(this.cmbCategoryIssue);
            this.Controls.Add(this.lblSelectCategoryIssue);
            this.Controls.Add(this.btnSearchBookIssue);
            this.Controls.Add(this.txtBoxSearchInvIssue);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCIssueBook";
            this.Size = new System.Drawing.Size(658, 563);
            this.Load += new System.EventHandler(this.UCIssueBook_Load);
            this.pnlIssueBTitle.ResumeLayout(false);
            this.pnlIssueBTitle.PerformLayout();
            this.pnlInvIssueB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVInvIssueB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIssueBTitle;
        private System.Windows.Forms.Label lblIssueBook;
        private System.Windows.Forms.Panel pnlInvIssueB;
        private System.Windows.Forms.DataGridView dGVInvIssueB;
        private System.Windows.Forms.Button btnViewPubIssue;
        private System.Windows.Forms.Button btnViewCategoryIssue;
        private System.Windows.Forms.ComboBox cmbPublicationIssue;
        private System.Windows.Forms.Label lblSelectPublictionIssue;
        private System.Windows.Forms.ComboBox cmbCategoryIssue;
        private System.Windows.Forms.Label lblSelectCategoryIssue;
        private System.Windows.Forms.Button btnSearchBookIssue;
        private System.Windows.Forms.TextBox txtBoxSearchInvIssue;
        private System.Windows.Forms.Button btnSelectMember;
        private System.Windows.Forms.Button btnShowAllIssueBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishedYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}
