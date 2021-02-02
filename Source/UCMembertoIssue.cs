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
    public partial class UCMembertoIssue : UserControl
    {
        private string Book { get; set; }
        private string AuthorName { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string CurrentRowUser { get; set; }
        private string CurrentRowUserName { get; set; }

        internal LibrarianForm libref2;
        internal UCIssueBook ucref;
        public UCMembertoIssue(LibrarianForm libref, UCIssueBook ucref)
        {
            InitializeComponent();
            this.libref2 = libref;
            this.ucref = ucref;
        }

        private void btnSearchMemIssue_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSearchMemIssue.Text == "")
            {
                this.Sql = "select * from Member where Name like '" + this.txtBoxSearchMemIssue.Text + "';";
                this.PopulateGridViewUCViewMemIssue(this.Sql);
            }
            else
            {
                this.Sql = "select * from Member where Name like '%" + this.txtBoxSearchMemIssue.Text + "%';";
                this.PopulateGridViewUCViewMemIssue(this.Sql);
            }
        }
        private void PopulateGridViewUCViewMemIssue(string sql)
        {
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(sql);

            this.dGVMemDetailsIssue.ClearSelection();
            this.dGVMemDetailsIssue.Refresh();
            this.dGVMemDetailsIssue.AutoGenerateColumns = false;
            this.dGVMemDetailsIssue.DataSource = Ds.Tables[0];
        }

        private void UCMembertoIssue_Load(object sender, EventArgs e)
        {
            this.Sql = "select * from Member;";
            this.PopulateGridViewUCViewMemIssue(this.Sql);
        }

        private void txtBoxSearchMemIssue_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Member where Name like '%" + this.txtBoxSearchMemIssue.Text + "%';";
            this.PopulateGridViewUCViewMemIssue(this.Sql);
        }

        private void btnShowAllMemIssue_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Member;";
            this.PopulateGridViewUCViewMemIssue(this.Sql);
        }

        private void txtBoxSearchMemIssue_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.txtBoxSearchMemIssue.Text == "    Search by Name")
            {
                this.txtBoxSearchMemIssue.Clear();
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                this.CurrentRowUser = this.dGVMemDetailsIssue.CurrentRow.Cells["MemberID"].Value.ToString();
                this.CurrentRowUserName = this.dGVMemDetailsIssue.CurrentRow.Cells["MemberName"].Value.ToString();
                this.Book = ucref.CurrentRowBookName;
                this.AuthorName = ucref.CurrentRowAuthor;

                if (this.cmbDays.Text == "  Day(s)")
                {
                    MessageBox.Show("Please Select Days");
                }
                else
                {
                    this.Sql = @"INSERT INTO IssueBook VALUES('" + this.CurrentRowUser + "', '" + this.CurrentRowUserName + "', '" +
                    this.Book + "', '" + this.AuthorName + "', '" + this.dTPickerIssueDate.Text + "', '" + this.cmbDays.Text + "'); ";

                    this.Da.ExecuteUpdateQuery(this.Sql);

                    this.Sql = @"Update Inventory Set Quantity = (Quantity - 1) Where BookName = '" + this.Book + "';";
                    
                    int row = this.Da.ExecuteUpdateQuery(this.Sql);
                    
                    if (row == 1)
                    {
                        MessageBox.Show("Book Issued Successfully");
                        UCIssueBook uCIssueBook1 = new UCIssueBook(libref2);
                        libref2.pnlLibrarianHome.Controls.Add(uCIssueBook1);
                        uCIssueBook1.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Issue Book. Please Try Again");
                    }
                }

                this.cmbDays.Text = "  Day(s)";
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message);
            }
        }
    }
}