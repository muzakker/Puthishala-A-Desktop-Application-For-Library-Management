
namespace Project.LMS.AppLayer
{
    partial class UCBookList
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
            this.pnlBookList = new System.Windows.Forms.Panel();
            this.lblBookList = new System.Windows.Forms.Label();
            this.pnlBookStat = new System.Windows.Forms.Panel();
            this.txtBoxSelectDaysBorrow = new System.Windows.Forms.TextBox();
            this.lblSelectDaysBorrow = new System.Windows.Forms.Label();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.dGVBookStat = new System.Windows.Forms.DataGridView();
            this.btnViewPubBList = new System.Windows.Forms.Button();
            this.btnViewCategoryBList = new System.Windows.Forms.Button();
            this.cmbPublicationBList = new System.Windows.Forms.ComboBox();
            this.lblSelectPublictionBList = new System.Windows.Forms.Label();
            this.cmbCategoryBList = new System.Windows.Forms.ComboBox();
            this.lblSelectCategoryBList = new System.Windows.Forms.Label();
            this.btnSearchBookList = new System.Windows.Forms.Button();
            this.txtBoxSearchBookList = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAllBookList = new System.Windows.Forms.Button();
            this.pnlBookList.SuspendLayout();
            this.pnlBookStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBookStat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBookList
            // 
            this.pnlBookList.BackColor = System.Drawing.Color.Green;
            this.pnlBookList.Controls.Add(this.lblBookList);
            this.pnlBookList.Location = new System.Drawing.Point(0, 1);
            this.pnlBookList.Name = "pnlBookList";
            this.pnlBookList.Size = new System.Drawing.Size(766, 66);
            this.pnlBookList.TabIndex = 30;
            // 
            // lblBookList
            // 
            this.lblBookList.AutoSize = true;
            this.lblBookList.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblBookList.Location = new System.Drawing.Point(274, 15);
            this.lblBookList.Name = "lblBookList";
            this.lblBookList.Size = new System.Drawing.Size(183, 34);
            this.lblBookList.TabIndex = 0;
            this.lblBookList.Text = "BOOK LIST";
            // 
            // pnlBookStat
            // 
            this.pnlBookStat.Controls.Add(this.txtBoxSelectDaysBorrow);
            this.pnlBookStat.Controls.Add(this.lblSelectDaysBorrow);
            this.pnlBookStat.Controls.Add(this.btnBorrowBook);
            this.pnlBookStat.Controls.Add(this.dGVBookStat);
            this.pnlBookStat.Location = new System.Drawing.Point(1, 234);
            this.pnlBookStat.Name = "pnlBookStat";
            this.pnlBookStat.Size = new System.Drawing.Size(766, 388);
            this.pnlBookStat.TabIndex = 31;
            // 
            // txtBoxSelectDaysBorrow
            // 
            this.txtBoxSelectDaysBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxSelectDaysBorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSelectDaysBorrow.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSelectDaysBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxSelectDaysBorrow.Location = new System.Drawing.Point(303, 335);
            this.txtBoxSelectDaysBorrow.Name = "txtBoxSelectDaysBorrow";
            this.txtBoxSelectDaysBorrow.Size = new System.Drawing.Size(58, 28);
            this.txtBoxSelectDaysBorrow.TabIndex = 46;
            // 
            // lblSelectDaysBorrow
            // 
            this.lblSelectDaysBorrow.AutoSize = true;
            this.lblSelectDaysBorrow.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDaysBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblSelectDaysBorrow.Location = new System.Drawing.Point(169, 340);
            this.lblSelectDaysBorrow.Name = "lblSelectDaysBorrow";
            this.lblSelectDaysBorrow.Size = new System.Drawing.Size(109, 21);
            this.lblSelectDaysBorrow.TabIndex = 45;
            this.lblSelectDaysBorrow.Text = "Select Days :";
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnBorrowBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnBorrowBook.FlatAppearance.BorderSize = 2;
            this.btnBorrowBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnBorrowBook.Location = new System.Drawing.Point(419, 335);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(177, 35);
            this.btnBorrowBook.TabIndex = 34;
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            // 
            // dGVBookStat
            // 
            this.dGVBookStat.AllowUserToAddRows = false;
            this.dGVBookStat.AllowUserToDeleteRows = false;
            this.dGVBookStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBookStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.Author,
            this.PublishedYear,
            this.Publication,
            this.Category,
            this.Price,
            this.Quantity});
            this.dGVBookStat.Location = new System.Drawing.Point(10, 29);
            this.dGVBookStat.Name = "dGVBookStat";
            this.dGVBookStat.ReadOnly = true;
            this.dGVBookStat.Size = new System.Drawing.Size(744, 299);
            this.dGVBookStat.TabIndex = 0;
            // 
            // btnViewPubBList
            // 
            this.btnViewPubBList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnViewPubBList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewPubBList.FlatAppearance.BorderSize = 2;
            this.btnViewPubBList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnViewPubBList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPubBList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPubBList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewPubBList.Location = new System.Drawing.Point(432, 135);
            this.btnViewPubBList.Name = "btnViewPubBList";
            this.btnViewPubBList.Size = new System.Drawing.Size(119, 35);
            this.btnViewPubBList.TabIndex = 39;
            this.btnViewPubBList.Text = "View";
            this.btnViewPubBList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewPubBList.UseVisualStyleBackColor = false;
            this.btnViewPubBList.Click += new System.EventHandler(this.btnViewPubBList_Click);
            // 
            // btnViewCategoryBList
            // 
            this.btnViewCategoryBList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnViewCategoryBList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewCategoryBList.FlatAppearance.BorderSize = 2;
            this.btnViewCategoryBList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnViewCategoryBList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCategoryBList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCategoryBList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewCategoryBList.Location = new System.Drawing.Point(432, 92);
            this.btnViewCategoryBList.Name = "btnViewCategoryBList";
            this.btnViewCategoryBList.Size = new System.Drawing.Size(119, 35);
            this.btnViewCategoryBList.TabIndex = 38;
            this.btnViewCategoryBList.Text = "View";
            this.btnViewCategoryBList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewCategoryBList.UseVisualStyleBackColor = false;
            this.btnViewCategoryBList.Click += new System.EventHandler(this.btnViewCategoryBList_Click);
            // 
            // cmbPublicationBList
            // 
            this.cmbPublicationBList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.cmbPublicationBList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPublicationBList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPublicationBList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.cmbPublicationBList.FormattingEnabled = true;
            this.cmbPublicationBList.Items.AddRange(new object[] {
            "Wiley",
            "Modern Publications",
            "Dover Publications",
            "O\'Reilly"});
            this.cmbPublicationBList.Location = new System.Drawing.Point(202, 135);
            this.cmbPublicationBList.Name = "cmbPublicationBList";
            this.cmbPublicationBList.Size = new System.Drawing.Size(209, 29);
            this.cmbPublicationBList.TabIndex = 37;
            // 
            // lblSelectPublictionBList
            // 
            this.lblSelectPublictionBList.AutoSize = true;
            this.lblSelectPublictionBList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPublictionBList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblSelectPublictionBList.Location = new System.Drawing.Point(16, 141);
            this.lblSelectPublictionBList.Name = "lblSelectPublictionBList";
            this.lblSelectPublictionBList.Size = new System.Drawing.Size(161, 21);
            this.lblSelectPublictionBList.TabIndex = 36;
            this.lblSelectPublictionBList.Text = "Select Publication :";
            // 
            // cmbCategoryBList
            // 
            this.cmbCategoryBList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.cmbCategoryBList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryBList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryBList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.cmbCategoryBList.FormattingEnabled = true;
            this.cmbCategoryBList.Items.AddRange(new object[] {
            "Physics",
            "Chemistry",
            "Biology",
            "Mathematics",
            "Computer Science",
            "Bangla Literature",
            "English Literature"});
            this.cmbCategoryBList.Location = new System.Drawing.Point(202, 95);
            this.cmbCategoryBList.Name = "cmbCategoryBList";
            this.cmbCategoryBList.Size = new System.Drawing.Size(209, 29);
            this.cmbCategoryBList.TabIndex = 35;
            // 
            // lblSelectCategoryBList
            // 
            this.lblSelectCategoryBList.AutoSize = true;
            this.lblSelectCategoryBList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategoryBList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblSelectCategoryBList.Location = new System.Drawing.Point(16, 103);
            this.lblSelectCategoryBList.Name = "lblSelectCategoryBList";
            this.lblSelectCategoryBList.Size = new System.Drawing.Size(161, 21);
            this.lblSelectCategoryBList.TabIndex = 34;
            this.lblSelectCategoryBList.Text = "     Select Category :";
            // 
            // btnSearchBookList
            // 
            this.btnSearchBookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnSearchBookList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchBookList.FlatAppearance.BorderSize = 2;
            this.btnSearchBookList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSearchBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBookList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBookList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchBookList.Location = new System.Drawing.Point(268, 189);
            this.btnSearchBookList.Name = "btnSearchBookList";
            this.btnSearchBookList.Size = new System.Drawing.Size(119, 35);
            this.btnSearchBookList.TabIndex = 33;
            this.btnSearchBookList.Text = "Search";
            this.btnSearchBookList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchBookList.UseVisualStyleBackColor = false;
            this.btnSearchBookList.Click += new System.EventHandler(this.btnSearchBookList_Click);
            // 
            // txtBoxSearchBookList
            // 
            this.txtBoxSearchBookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxSearchBookList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearchBookList.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchBookList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxSearchBookList.Location = new System.Drawing.Point(20, 189);
            this.txtBoxSearchBookList.Name = "txtBoxSearchBookList";
            this.txtBoxSearchBookList.Size = new System.Drawing.Size(233, 30);
            this.txtBoxSearchBookList.TabIndex = 32;
            this.txtBoxSearchBookList.Text = "      Search Book";
            this.txtBoxSearchBookList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxSearchBookStat_MouseClick);
            this.txtBoxSearchBookList.TextChanged += new System.EventHandler(this.txtBoxSearchBookList_TextChanged);
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
            this.PublishedYear.HeaderText = "Published Year";
            this.PublishedYear.Name = "PublishedYear";
            this.PublishedYear.ReadOnly = true;
            // 
            // Publication
            // 
            this.Publication.DataPropertyName = "Publication";
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
            // btnShowAllBookList
            // 
            this.btnShowAllBookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnShowAllBookList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllBookList.FlatAppearance.BorderSize = 2;
            this.btnShowAllBookList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnShowAllBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllBookList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllBookList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllBookList.Location = new System.Drawing.Point(394, 189);
            this.btnShowAllBookList.Name = "btnShowAllBookList";
            this.btnShowAllBookList.Size = new System.Drawing.Size(119, 35);
            this.btnShowAllBookList.TabIndex = 40;
            this.btnShowAllBookList.Text = "Show All";
            this.btnShowAllBookList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowAllBookList.UseVisualStyleBackColor = false;
            this.btnShowAllBookList.Click += new System.EventHandler(this.btnShowAllBookList_Click);
            // 
            // UCBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.btnShowAllBookList);
            this.Controls.Add(this.pnlBookList);
            this.Controls.Add(this.pnlBookStat);
            this.Controls.Add(this.btnViewPubBList);
            this.Controls.Add(this.btnViewCategoryBList);
            this.Controls.Add(this.cmbPublicationBList);
            this.Controls.Add(this.lblSelectPublictionBList);
            this.Controls.Add(this.cmbCategoryBList);
            this.Controls.Add(this.lblSelectCategoryBList);
            this.Controls.Add(this.btnSearchBookList);
            this.Controls.Add(this.txtBoxSearchBookList);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCBookList";
            this.Size = new System.Drawing.Size(768, 650);
            this.Load += new System.EventHandler(this.UCBookList_Load);
            this.pnlBookList.ResumeLayout(false);
            this.pnlBookList.PerformLayout();
            this.pnlBookStat.ResumeLayout(false);
            this.pnlBookStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBookStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBookList;
        private System.Windows.Forms.Label lblBookList;
        private System.Windows.Forms.Panel pnlBookStat;
        private System.Windows.Forms.DataGridView dGVBookStat;
        private System.Windows.Forms.Button btnViewPubBList;
        private System.Windows.Forms.Button btnViewCategoryBList;
        private System.Windows.Forms.ComboBox cmbPublicationBList;
        private System.Windows.Forms.Label lblSelectPublictionBList;
        private System.Windows.Forms.ComboBox cmbCategoryBList;
        private System.Windows.Forms.Label lblSelectCategoryBList;
        private System.Windows.Forms.Button btnSearchBookList;
        private System.Windows.Forms.TextBox txtBoxSearchBookList;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.TextBox txtBoxSelectDaysBorrow;
        private System.Windows.Forms.Label lblSelectDaysBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishedYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnShowAllBookList;
    }
}
