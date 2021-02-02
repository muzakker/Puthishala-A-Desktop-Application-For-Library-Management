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
    public partial class UCBookList : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        public UCBookList()
        {
            InitializeComponent();
        }

        private void txtBoxSearchBookStat_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.txtBoxSearchBookList.Text == "      Search Book")
            {
                this.txtBoxSearchBookList.Clear();
            }
        }
        private void PopulateGridViewUCBookList(string sql)
        {
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(sql);

            this.dGVBookStat.ClearSelection();
            this.dGVBookStat.Refresh();
            this.dGVBookStat.AutoGenerateColumns = false;
            this.dGVBookStat.DataSource = Ds.Tables[0];
        }

        private void btnViewCategoryBList_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory where Category like '" + this.cmbCategoryBList.Text + "%'; ";
            this.PopulateGridViewUCBookList(this.Sql);
        }

        private void UCBookList_Load(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory;";
            this.PopulateGridViewUCBookList(this.Sql);
        }

        private void txtBoxSearchBookList_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory where BookName like '" + this.txtBoxSearchBookList.Text + "%';";
            this.PopulateGridViewUCBookList(this.Sql);
        }

        private void btnSearchBookList_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory where BookName like '" + this.txtBoxSearchBookList.Text + "%';";
            this.PopulateGridViewUCBookList(this.Sql);
        }

        private void btnViewPubBList_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory where Publication like '" + this.cmbPublicationBList.Text + "%'; ";
            this.PopulateGridViewUCBookList(this.Sql);
        }

        private void btnShowAllBookList_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory;";
            this.PopulateGridViewUCBookList(this.Sql);
        }
    }
}
