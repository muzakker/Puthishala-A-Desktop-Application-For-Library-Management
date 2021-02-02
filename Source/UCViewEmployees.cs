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
    public partial class UCViewEmployees : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private string Sql { get; set; }
        private string CurrentRowUser { get; set; }
        public UCViewEmployees()
        {
            InitializeComponent();
        }

        private void txtBoxSearchEmp_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.txtBoxSearchEmp.Text == "     Search by Name")
            {
                this.txtBoxSearchEmp.Clear();
            }
        }

        private void PopulateGridViewUCViewEmp(string sql)
        {
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(sql);

            this.dGVEmpDetails.ClearSelection();
            this.dGVEmpDetails.Refresh();
            this.dGVEmpDetails.AutoGenerateColumns = false;
            this.dGVEmpDetails.DataSource = Ds.Tables[0];
        }

        private void UCViewEmployees_Load(object sender, EventArgs e)
        {
            this.Sql = "select * from Employee;";
            this.PopulateGridViewUCViewEmp(this.Sql);
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSearchEmp.Text == "")
            {
                this.Sql = "select * from Employee where Name like '" + this.txtBoxSearchEmp.Text + "';";
                this.PopulateGridViewUCViewEmp(this.Sql);
            }
            else
            {
                this.Sql = "select * from Employee where Name like '" + this.txtBoxSearchEmp.Text + "%';";
                this.PopulateGridViewUCViewEmp(this.Sql);
            }
        }

        private void txtBoxSearchEmp_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Employee where Name like '" + this.txtBoxSearchEmp.Text + "%';";
            this.PopulateGridViewUCViewEmp(this.Sql);
        }

        private void btnShowAllEmp_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Employee;";
            this.PopulateGridViewUCViewEmp(this.Sql);
        }

        private void btnRmvEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                this.CurrentRowUser = this.dGVEmpDetails.CurrentRow.Cells["EmployeeID"].Value.ToString();
                this.Sql = @"DELETE FROM Employee WHERE EmployeeID ='" + this.CurrentRowUser + "';";
                this.Da.ExecuteUpdateQuery(this.Sql);

                this.CurrentRowUser = this.dGVEmpDetails.CurrentRow.Cells["EmployeeID"].Value.ToString();
                this.Sql = @"DELETE FROM UserLogin WHERE UserID ='" + this.CurrentRowUser + "';";
                int row = this.Da.ExecuteUpdateQuery(this.Sql);

                if (row == 1)
                    MessageBox.Show("1 row has been deleted!");
                else
                    MessageBox.Show("ERROR! Data Removal Failed");

                this.Sql = "select * from Employee;";
                this.PopulateGridViewUCViewEmp(this.Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message);
            }
        }
    }
}
