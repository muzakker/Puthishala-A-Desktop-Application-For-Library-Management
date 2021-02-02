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
    public partial class MemberForm : Form
    {
        private LoginForm logref;
        internal string UserName { get; set; }
        public MemberForm(LoginForm logref, string username)
        {
            InitializeComponent();
            this.logref = logref;
            this.UserName = username;
        }

        private void btnMemberHome_Click(object sender, EventArgs e)
        {
            UCGreet ucGreetMem = new UCGreet();
            this.pnlMemberHome.Controls.Add(ucGreetMem);
            ucGreetMem.BringToFront();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            UCGreet ucGreetMem2 = new UCGreet();
            this.pnlMemberHome.Controls.Add(ucGreetMem2);
            ucGreetMem2.Show();
            this.lblMemName.Text = this.UserName;
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            UCMemberAccount ucMemAcc = new UCMemberAccount();
            this.pnlMemberHome.Controls.Add(ucMemAcc);
            ucMemAcc.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.logref.Visible = true;
        }

        private void btnBookStatus_Click(object sender, EventArgs e)
        {
            UCBookList ucBookList = new UCBookList();
            this.pnlMemberHome.Controls.Add(ucBookList);
            ucBookList.BringToFront();
        }

        private void btnMyStatus_Click(object sender, EventArgs e)
        {
            UCMyStatus ucMyStat = new UCMyStatus(this.UserName);
            this.pnlMemberHome.Controls.Add(ucMyStat);
            ucMyStat.BringToFront();
        }

        private void btnPenaltyStatus_Click(object sender, EventArgs e)
        {
            UCPenaltyStatus uCPenaltyStatus = new UCPenaltyStatus(this.UserName);
            this.pnlMemberHome.Controls.Add(uCPenaltyStatus);
            uCPenaltyStatus.BringToFront();
        }

        private void MemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnBookStatus_Click_1(object sender, EventArgs e)
        {
            UCMyStatus uCMyStatus = new UCMyStatus(this.UserName);
            this.pnlMemberHome.Controls.Add(uCMyStatus);
            uCMyStatus.BringToFront();
        }
    }
}
