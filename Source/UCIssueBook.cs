using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project.LMS.AppLayer
{
    public partial class UCIssueBook : UserControl
    { 
        internal string CurrentRowBookName { get; set; }
        internal string CurrentRowAuthor { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private string Sql { get; set; }
        internal LibrarianForm libref;

        public UCIssueBook(LibrarianForm libref)
        {
            InitializeComponent();
            this.libref = libref;
        }

        private void txtBoxSearchInvIssue_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.txtBoxSearchInvIssue.Text == "    Search by Name")
            {
                this.txtBoxSearchInvIssue.Clear();
            }
        }
        private void PopulateGridViewUCIssueBook(string sql)
        {
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(sql);

            this.dGVInvIssueB.ClearSelection();
            this.dGVInvIssueB.Refresh();
            this.dGVInvIssueB.AutoGenerateColumns = false;
            this.dGVInvIssueB.DataSource = Ds.Tables[0];
        }

        private void btnShowAllIssueBook_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory;";
            this.PopulateGridViewUCIssueBook(this.Sql);
            this.cmbCategoryIssue.Text = "    Select Category";
            this.cmbPublicationIssue.Text = "Select Publication";
        }

        private void UCIssueBook_Load(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory;";
            this.PopulateGridViewUCIssueBook(this.Sql);
        }

        private void txtBoxSearchInvIssue_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory where BookName like '" + this.txtBoxSearchInvIssue.Text + "%';";
            this.PopulateGridViewUCIssueBook(this.Sql);
        }

        private void btnSearchBookIssue_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSearchInvIssue.Text == "")
            {
                this.Sql = "select * from Inventory where BookName like '" + this.txtBoxSearchInvIssue.Text + "';";
                this.PopulateGridViewUCIssueBook(this.Sql);
            }
            else
            {
                this.Sql = "select * from Inventory where BookName like '%" + this.txtBoxSearchInvIssue.Text + "%';";
                this.PopulateGridViewUCIssueBook(this.Sql);
            }
        }

        private void btnViewCategoryIssue_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory where Category like '" + this.cmbCategoryIssue.Text + "%'; ";
            this.PopulateGridViewUCIssueBook(this.Sql);
        }

        private void btnViewPubIssue_Click(object sender, EventArgs e)
        {
            if (this.cmbPublicationIssue.Text == "All")
            {
                this.Sql = "select * from Inventory;";
                this.PopulateGridViewUCIssueBook(this.Sql);
            }
            else
            {
                this.Sql = "select * from Inventory where Publication like '" + this.cmbPublicationIssue.Text + "%'; ";
                this.PopulateGridViewUCIssueBook(this.Sql);
            }
        }

        private void btnSelectMember_Click(object sender, EventArgs e)
        {
            CurrentRowBookName = this.dGVInvIssueB.CurrentRow.Cells["BookName"].Value.ToString();
            CurrentRowAuthor = this.dGVInvIssueB.CurrentRow.Cells["Author"].Value.ToString();
            UCMembertoIssue uCMembertoIssue = new UCMembertoIssue(libref, this);
            libref.pnlLibrarianHome.Controls.Add(uCMembertoIssue);
            uCMembertoIssue.BringToFront();
        }
    }
}
