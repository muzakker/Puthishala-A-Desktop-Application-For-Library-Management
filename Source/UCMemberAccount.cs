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
    public partial class UCMemberAccount : UserControl
    {
        public UCMemberAccount()
        {
            InitializeComponent();
        }

        private void btnViewAcc_Click(object sender, EventArgs e)
        {
            UCViewAcc ucViewAcc = new UCViewAcc();
            this.pnlMyAccountHome.Controls.Add(ucViewAcc);
            ucViewAcc.BringToFront();
        }

        private void btnEditAcc_Click(object sender, EventArgs e)
        {
            UCEditAcc ucEditAcc = new UCEditAcc();
            this.pnlMyAccountHome.Controls.Add(ucEditAcc);
            ucEditAcc.BringToFront();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            UCChangePass ucChPass = new UCChangePass();
            this.pnlMyAccountHome.Controls.Add(ucChPass);
            ucChPass.BringToFront();
        }

        private void UCMemberAccount_Load(object sender, EventArgs e)
        {
            UCViewAcc ucViewAcc2 = new UCViewAcc();
            this.pnlMyAccountHome.Controls.Add(ucViewAcc2);
            ucViewAcc2.Show();
        }
    }
}
