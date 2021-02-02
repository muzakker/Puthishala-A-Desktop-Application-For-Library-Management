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
    public partial class UCViewMembers : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string CurrentRowUser { get; set; }

        public UCViewMembers()
        {
            InitializeComponent();
        }

        private void txtBoxSearchMem_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.txtBoxSearchMem.Text == "    Search by Name")
            {
                this.txtBoxSearchMem.Clear();
            }
        }

        private void PopulateGridViewUCViewMem(string sql)
        {
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(sql);

            this.dGVMemDetails.ClearSelection();
            this.dGVMemDetails.Refresh();
            this.dGVMemDetails.AutoGenerateColumns = false;
            this.dGVMemDetails.DataSource = Ds.Tables[0];
        }

        private void UCViewMembers_Load(object sender, EventArgs e)
        {
            this.Sql = "select * from Member;";
            this.PopulateGridViewUCViewMem(this.Sql);
        }

        private void btnSearchMem_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSearchMem.Text == "")
            {
                this.Sql = "select * from Member where Name like '" + this.txtBoxSearchMem.Text + "';";
                this.PopulateGridViewUCViewMem(this.Sql);
            }
            else
            {
                this.Sql = "select * from Member where Name like '%" + this.txtBoxSearchMem.Text + "%';";
                this.PopulateGridViewUCViewMem(this.Sql);
            }
        }

        private void txtBoxSearchMem_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Member where Name like '%" + this.txtBoxSearchMem.Text + "%';";
            this.PopulateGridViewUCViewMem(this.Sql);
        }

        private void btnShowAllMem_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Member;";
            this.PopulateGridViewUCViewMem(this.Sql);
        }

        private void btnMemRmv_Click(object sender, EventArgs e)
        {
            try
            {
                this.CurrentRowUser = this.dGVMemDetails.CurrentRow.Cells["MemberID"].Value.ToString();
                this.Sql = @"DELETE FROM Member WHERE MemberID ='" + this.CurrentRowUser + "';";
                this.Da.ExecuteUpdateQuery(this.Sql);

                this.CurrentRowUser = this.dGVMemDetails.CurrentRow.Cells["MemberID"].Value.ToString();
                this.Sql = @"DELETE FROM UserLogin WHERE UserID ='" + this.CurrentRowUser + "';";
                int row = this.Da.ExecuteUpdateQuery(this.Sql);

                if (row == 1)
                    MessageBox.Show("1 row has been deleted!");
                else
                    MessageBox.Show("ERROR! Data Removal Failed");

                this.Sql = "select * from Member;";
                this.PopulateGridViewUCViewMem(this.Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message);
            }
        }
    }
}
