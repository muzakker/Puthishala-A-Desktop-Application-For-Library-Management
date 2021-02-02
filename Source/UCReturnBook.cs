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
    public partial class UCReturnBook : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string CurrentRowUser { get; set; }
        private string CurrentRowUserBook { get; set; }
        public UCReturnBook()
        {
            InitializeComponent();
        }

        private void txtBoxSearchMemRB_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.txtBoxSearchMemRB.Text == "      Search Member")
            {
                this.txtBoxSearchMemRB.Clear();
            }
        }

        private void PopulateGridViewUCViewMemReturnB(string sql)
        {
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(sql);

            this.dGVReturnDetails.ClearSelection();
            this.dGVReturnDetails.Refresh();
            this.dGVReturnDetails.AutoGenerateColumns = false;
            this.dGVReturnDetails.DataSource = Ds.Tables[0];
        }

        private void UCReturnBook_Load(object sender, EventArgs e)
        {
            this.Sql = "select * from IssueBook;";
            this.PopulateGridViewUCViewMemReturnB(this.Sql);
        }

        private void btnSearchMemRB_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSearchMemRB.Text == "")
            {
                this.Sql = "select * from IssueBook where Name like '" + this.txtBoxSearchMemRB.Text + "';";
                this.PopulateGridViewUCViewMemReturnB(this.Sql);
            }
            else
            {
                this.Sql = "select * from IssueBook where Name like '%" + this.txtBoxSearchMemRB.Text + "%';";
                this.PopulateGridViewUCViewMemReturnB(this.Sql);
            }
        }

        private void txtBoxSearchMemRB_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from IssueBook where Name like '%" + this.txtBoxSearchMemRB.Text + "%';";
            this.PopulateGridViewUCViewMemReturnB(this.Sql);
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                this.CurrentRowUser = this.dGVReturnDetails.CurrentRow.Cells["MemberID"].Value.ToString();
                this.Sql = @"DELETE FROM IssueBook WHERE MemberID ='" + this.CurrentRowUser + "';";
                this.Da.ExecuteUpdateQuery(this.Sql);

                this.CurrentRowUserBook = this.dGVReturnDetails.CurrentRow.Cells["BookName"].Value.ToString();
                this.Sql = @"Update Inventory Set Quantity = (Quantity + 1) Where BookName = '"+this.CurrentRowUserBook+"';";
                int row = this.Da.ExecuteUpdateQuery(this.Sql);

                if (row == 1)
                    MessageBox.Show("Book Returned Successfully.");
                else
                    MessageBox.Show("ERROR! Book Returned Failed");

                this.Sql = "select * from IssueBook;";
                this.PopulateGridViewUCViewMemReturnB(this.Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message);
            }
        }
    }
}
