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
    public partial class LibrarianForm : Form
    {
        private LoginForm logref;
        private string UserName { get; set; }
        public LibrarianForm(LoginForm logref, string userName)
        {
            InitializeComponent();
            this.logref = logref;
            this.UserName = userName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.logref.Visible = true;
        }

        private void LibrarianForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            UCAddBook addBook = new UCAddBook();
            this.pnlLibrarianHome.Controls.Add(addBook);
            addBook.BringToFront();
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            UCGreet ucwel4 = new UCGreet();
            this.pnlLibrarianHome.Controls.Add(ucwel4);
            ucwel4.Show();
            this.lblLibName.Text = this.UserName;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            UCViewInventory viewEnv2 = new UCViewInventory();
            this.pnlLibrarianHome.Controls.Add(viewEnv2);
            viewEnv2.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UCGreet ucwel3 = new UCGreet();
            this.pnlLibrarianHome.Controls.Add(ucwel3);
            ucwel3.BringToFront();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            UCAddMember ucAddMem = new UCAddMember();
            this.pnlLibrarianHome.Controls.Add(ucAddMem);
            ucAddMem.BringToFront();
        }

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            UCViewMembers ucViewMem2 = new UCViewMembers();
            this.pnlLibrarianHome.Controls.Add(ucViewMem2);
            ucViewMem2.BringToFront();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            UCIssueBook ucIssue = new UCIssueBook(this);
            this.pnlLibrarianHome.Controls.Add(ucIssue);
            ucIssue.BringToFront();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            UCReturnBook ucReturn = new UCReturnBook();
            this.pnlLibrarianHome.Controls.Add(ucReturn);
            ucReturn.BringToFront();
        }

        private void btnPenalty_Click(object sender, EventArgs e)
        {
            UCPenalty ucPenalty = new UCPenalty();
            this.pnlLibrarianHome.Controls.Add(ucPenalty);
            ucPenalty.BringToFront();
        }
    }
}
