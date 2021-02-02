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
    public partial class UCAddEmployee : UserControl
    {
        private string Sql { get; set; }
        private string AutoIdValue { get; set; }
        private DataAccess Da { get; set; }
        public UCAddEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void AutoIdGenerate()
        {
            string sql = "select EmployeeID from Employee order by EmployeeID desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            string previousId = dt.Rows[0][0].ToString();
            string[] temp = previousId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string nextId = "E-" + (++serialNo).ToString("000");
            this.AutoIdValue = nextId;
        }
        private void UCAddEmployee_Load(object sender, EventArgs e)
        {
            this.AutoIdGenerate();
            this.txtBoxEmpId.Text = this.AutoIdValue;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = @"INSERT INTO Employee VALUES('" + this.AutoIdValue + "', '" + this.txtBoxEmpName.Text + "', '" 
                    + this.cmbDesignation.Text + "', '" + this.dTPickerJoinDate.Text + "', "+ this.txtBoxSalary.Text + ", '" 
                    + this.txtBoxEmpAddress.Text + "', '"+ this.txtBoxEmpMobile.Text + "');";
                
                this.Da.ExecuteUpdateQuery(this.Sql);

                this.Sql = @"INSERT INTO UserLogin VALUES('" + this.AutoIdValue + "', '" + this.txtBoxEmpPass.Text + "', '" +
                    this.txtBoxEmpName.Text + "', '" + this.cmbDesignation.Text + "'); ";
                
                int row = this.Da.ExecuteUpdateQuery(this.Sql);

                if (row == 1)
                    MessageBox.Show("1 row added Successfully");
                else
                {
                    MessageBox.Show("Failed to insert Data");
                    this.cmbDesignation.Text = "         Select Designation";
                }

                this.txtBoxEmpPass.Text = "";
                this.txtBoxEmpName.Text = "";
                this.txtBoxEmpMobile.Text = "";
                this.txtBoxEmpAddress.Text = "";
                this.txtBoxSalary.Text = "";
                this.cmbDesignation.Text = "         Select Designation";
                this.dTPickerJoinDate.Text = "";
                this.AutoIdGenerate();
                this.txtBoxEmpId.Text = this.AutoIdValue;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                this.cmbDesignation.Text = "         Select Designation";
            }
        }
    }
}
