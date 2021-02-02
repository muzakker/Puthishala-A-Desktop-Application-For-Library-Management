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
    public partial class UCViewInventory : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        public UCViewInventory()
        {
            InitializeComponent();
        }

        private void txtBoxSearchInv_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.txtBoxSearchInv.Text == "    Search by Name")
            {
                this.txtBoxSearchInv.Clear();
            }
        }

        private void PopulateGridViewUCViewInventory(string sql)
        {
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(sql);

            this.dGVInventory.ClearSelection();
            this.dGVInventory.Refresh();
            this.dGVInventory.AutoGenerateColumns = false;
            this.dGVInventory.DataSource = Ds.Tables[0];
        }

        private void UCViewInventory_Load(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory;";
            this.PopulateGridViewUCViewInventory(this.Sql);
        }

        private void txtBoxSearchInv_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory where BookName like '%" + this.txtBoxSearchInv.Text + "%';";
            this.PopulateGridViewUCViewInventory(this.Sql);
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            if(this.txtBoxSearchInv.Text == "")
            {
                this.Sql = "select * from Inventory where BookName like '" + this.txtBoxSearchInv.Text + "';";
                this.PopulateGridViewUCViewInventory(this.Sql);
            }
            else
            {
                this.Sql = "select * from Inventory where BookName like '%" + this.txtBoxSearchInv.Text + "%';";
                this.PopulateGridViewUCViewInventory(this.Sql);
            }
        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory where Category like '" + this.cmbCategory.Text + "%'; ";
            this.PopulateGridViewUCViewInventory(this.Sql);
        }

        private void btnViewPub_Click(object sender, EventArgs e)
        {
            if (this.cmbPublication.Text == "All")
            {
                this.Sql = "select * from Inventory;";
                this.PopulateGridViewUCViewInventory(this.Sql);
            }
            else
            {
                this.Sql = "select * from Inventory where Publication like '" + this.cmbPublication.Text + "%'; ";
                this.PopulateGridViewUCViewInventory(this.Sql);
            }
        }

        private void btnShowAllInv_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Inventory;";
            this.PopulateGridViewUCViewInventory(this.Sql);
            this.cmbCategory.Text = "           Select";
            this.cmbPublication.Text = "           Select";
        }
    }
}
