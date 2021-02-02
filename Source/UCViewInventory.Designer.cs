
namespace Project.LMS.AppLayer
{
    partial class UCViewInventory
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
            this.pnlInvTitle = new System.Windows.Forms.Panel();
            this.lblInvView = new System.Windows.Forms.Label();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.dGVInventory = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtBoxSearchInv = new System.Windows.Forms.TextBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbPublication = new System.Windows.Forms.ComboBox();
            this.lblSelectPubliction = new System.Windows.Forms.Label();
            this.btnViewCategory = new System.Windows.Forms.Button();
            this.btnViewPub = new System.Windows.Forms.Button();
            this.btnShowAllInv = new System.Windows.Forms.Button();
            this.pnlInvTitle.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInvTitle
            // 
            this.pnlInvTitle.BackColor = System.Drawing.Color.Green;
            this.pnlInvTitle.Controls.Add(this.lblInvView);
            this.pnlInvTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlInvTitle.Name = "pnlInvTitle";
            this.pnlInvTitle.Size = new System.Drawing.Size(657, 57);
            this.pnlInvTitle.TabIndex = 20;
            // 
            // lblInvView
            // 
            this.lblInvView.AutoSize = true;
            this.lblInvView.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblInvView.Location = new System.Drawing.Point(174, 13);
            this.lblInvView.Name = "lblInvView";
            this.lblInvView.Size = new System.Drawing.Size(373, 41);
            this.lblInvView.TabIndex = 0;
            this.lblInvView.Text = "VIEW INVENTORY";
            // 
            // pnlInventory
            // 
            this.pnlInventory.Controls.Add(this.dGVInventory);
            this.pnlInventory.Location = new System.Drawing.Point(1, 238);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(657, 303);
            this.pnlInventory.TabIndex = 21;
            // 
            // dGVInventory
            // 
            this.dGVInventory.AllowUserToAddRows = false;
            this.dGVInventory.AllowUserToDeleteRows = false;
            this.dGVInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.Author,
            this.PublishedYear,
            this.Publication,
            this.Category,
            this.Price,
            this.Quantity});
            this.dGVInventory.Location = new System.Drawing.Point(9, 25);
            this.dGVInventory.Name = "dGVInventory";
            this.dGVInventory.ReadOnly = true;
            this.dGVInventory.RowHeadersWidth = 51;
            this.dGVInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVInventory.Size = new System.Drawing.Size(638, 259);
            this.dGVInventory.TabIndex = 0;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Book Name";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // PublishedYear
            // 
            this.PublishedYear.DataPropertyName = "PublishedYear";
            this.PublishedYear.HeaderText = "Published Year";
            this.PublishedYear.MinimumWidth = 6;
            this.PublishedYear.Name = "PublishedYear";
            this.PublishedYear.ReadOnly = true;
            // 
            // Publication
            // 
            this.Publication.DataPropertyName = "Publication";
            this.Publication.HeaderText = "Publication";
            this.Publication.MinimumWidth = 6;
            this.Publication.Name = "Publication";
            this.Publication.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnSearchBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchBook.FlatAppearance.BorderSize = 2;
            this.btnSearchBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnSearchBook.Location = new System.Drawing.Point(230, 202);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(102, 30);
            this.btnSearchBook.TabIndex = 23;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtBoxSearchInv
            // 
            this.txtBoxSearchInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.txtBoxSearchInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearchInv.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchInv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxSearchInv.Location = new System.Drawing.Point(17, 202);
            this.txtBoxSearchInv.Name = "txtBoxSearchInv";
            this.txtBoxSearchInv.Size = new System.Drawing.Size(200, 36);
            this.txtBoxSearchInv.TabIndex = 22;
            this.txtBoxSearchInv.Text = "    Search by Name";
            this.txtBoxSearchInv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxSearchInv_MouseClick);
            this.txtBoxSearchInv.TextChanged += new System.EventHandler(this.txtBoxSearchInv_TextChanged);
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblSelectCategory.Location = new System.Drawing.Point(14, 127);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(206, 25);
            this.lblSelectCategory.TabIndex = 24;
            this.lblSelectCategory.Text = "     Select Category :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.cmbCategory.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Physics",
            "Chemistry",
            "Biology",
            "Mathematics",
            "Computer Science",
            "Bangla Literature",
            "English Literature"});
            this.cmbCategory.Location = new System.Drawing.Point(173, 120);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 33);
            this.cmbCategory.TabIndex = 25;
            this.cmbCategory.Text = "           Select";
            // 
            // cmbPublication
            // 
            this.cmbPublication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.cmbPublication.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPublication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.cmbPublication.FormattingEnabled = true;
            this.cmbPublication.Items.AddRange(new object[] {
            "Wiley",
            "Modern Publishers",
            "Dover Publications",
            "All"});
            this.cmbPublication.Location = new System.Drawing.Point(173, 155);
            this.cmbPublication.Name = "cmbPublication";
            this.cmbPublication.Size = new System.Drawing.Size(180, 33);
            this.cmbPublication.TabIndex = 27;
            this.cmbPublication.Text = "           Select";
            // 
            // lblSelectPubliction
            // 
            this.lblSelectPubliction.AutoSize = true;
            this.lblSelectPubliction.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPubliction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblSelectPubliction.Location = new System.Drawing.Point(14, 160);
            this.lblSelectPubliction.Name = "lblSelectPubliction";
            this.lblSelectPubliction.Size = new System.Drawing.Size(205, 25);
            this.lblSelectPubliction.TabIndex = 26;
            this.lblSelectPubliction.Text = "Select Publication :";
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnViewCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewCategory.FlatAppearance.BorderSize = 2;
            this.btnViewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnViewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCategory.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewCategory.Location = new System.Drawing.Point(370, 118);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Size = new System.Drawing.Size(102, 30);
            this.btnViewCategory.TabIndex = 28;
            this.btnViewCategory.Text = "View";
            this.btnViewCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewCategory.UseVisualStyleBackColor = false;
            this.btnViewCategory.Click += new System.EventHandler(this.btnViewCategory_Click);
            // 
            // btnViewPub
            // 
            this.btnViewPub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnViewPub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewPub.FlatAppearance.BorderSize = 2;
            this.btnViewPub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnViewPub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPub.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnViewPub.Location = new System.Drawing.Point(370, 155);
            this.btnViewPub.Name = "btnViewPub";
            this.btnViewPub.Size = new System.Drawing.Size(102, 30);
            this.btnViewPub.TabIndex = 29;
            this.btnViewPub.Text = "View";
            this.btnViewPub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewPub.UseVisualStyleBackColor = false;
            this.btnViewPub.Click += new System.EventHandler(this.btnViewPub_Click);
            // 
            // btnShowAllInv
            // 
            this.btnShowAllInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.btnShowAllInv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllInv.FlatAppearance.BorderSize = 2;
            this.btnShowAllInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnShowAllInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllInv.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllInv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.btnShowAllInv.Location = new System.Drawing.Point(338, 202);
            this.btnShowAllInv.Name = "btnShowAllInv";
            this.btnShowAllInv.Size = new System.Drawing.Size(102, 30);
            this.btnShowAllInv.TabIndex = 30;
            this.btnShowAllInv.Text = "Show All";
            this.btnShowAllInv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowAllInv.UseVisualStyleBackColor = false;
            this.btnShowAllInv.Click += new System.EventHandler(this.btnShowAllInv_Click);
            // 
            // UCViewInventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.btnShowAllInv);
            this.Controls.Add(this.btnViewPub);
            this.Controls.Add(this.btnViewCategory);
            this.Controls.Add(this.cmbPublication);
            this.Controls.Add(this.lblSelectPubliction);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblSelectCategory);
            this.Controls.Add(this.pnlInvTitle);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.txtBoxSearchInv);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCViewInventory";
            this.Size = new System.Drawing.Size(658, 563);
            this.Load += new System.EventHandler(this.UCViewInventory_Load);
            this.pnlInvTitle.ResumeLayout(false);
            this.pnlInvTitle.PerformLayout();
            this.pnlInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInvTitle;
        private System.Windows.Forms.Label lblInvView;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.DataGridView dGVInventory;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox txtBoxSearchInv;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbPublication;
        private System.Windows.Forms.Label lblSelectPubliction;
        private System.Windows.Forms.Button btnViewCategory;
        private System.Windows.Forms.Button btnViewPub;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishedYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnShowAllInv;
    }
}
