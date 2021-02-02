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
    public partial class AdminForm : Form
    {
        private LoginForm logref;
        private string UserName { get; set; }
        public AdminForm(LoginForm logref, string userName)
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

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            UCGreet ucwel1 = new UCGreet();
            this.pnlAdminHome.Controls.Add(ucwel1);
            ucwel1.Show();
        }

        private void btnViewMembers_Click(object sender, EventArgs e)
        {
            UCViewMembers viewMem = new UCViewMembers();
            this.pnlAdminHome.Controls.Add(viewMem);
            viewMem.BringToFront();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            UCViewEmployees viewEmp = new UCViewEmployees();
            this.pnlAdminHome.Controls.Add(viewEmp);
            viewEmp.BringToFront();
        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            UCViewInventory viewInv = new UCViewInventory();
            this.pnlAdminHome.Controls.Add(viewInv);
            viewInv.BringToFront();
        }

        private void btnAdminHome_Click(object sender, EventArgs e)
        {
            UCGreet ucwel2 = new UCGreet();
            this.pnlAdminHome.Controls.Add(ucwel2);
            ucwel2.BringToFront();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            UCAddEmployee ucAddEmp = new UCAddEmployee();
            this.pnlAdminHome.Controls.Add(ucAddEmp);
            ucAddEmp.BringToFront();
        }
    }
}
