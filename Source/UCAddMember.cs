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
    public partial class UCAddMember : UserControl
    {
        private string Sql { get; set; }
        private string AutoIdValue {get; set;}
        private DataAccess Da { get; set; }
        public UCAddMember()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void AutoIdGenerate()
        {
            string sql = "select MemberID from Member order by MemberID desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            string previousId = dt.Rows[0][0].ToString();
            string[] temp = previousId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string nextId = "M-" + (++serialNo).ToString("000");
            this.AutoIdValue = nextId;
        }
        private void btnAddMem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = @"INSERT INTO Member VALUES('" + this.AutoIdValue + "', '" + this.txtBoxMemName.Text + "', '" +
                    this.cmbProfession.Text + "', '" + this.dTPickerDoB.Text + "', '" + this.txtBoxMemAddress.Text + "', '" 
                    + this.txtBoxMemMobile.Text + "'); ";

                this.Da.ExecuteUpdateQuery(this.Sql);

                this.Sql = @"INSERT INTO UserLogin VALUES('" + this.AutoIdValue + "', '" + this.txtBoxMemPass.Text + "', '" +
                    this.txtBoxMemName.Text + "', 'Member'); ";
                
                int row = this.Da.ExecuteUpdateQuery(this.Sql);

                if (row == 1)
                    MessageBox.Show("1 row added Successfully");
                else
                { 
                    MessageBox.Show("Failed to insert Data");
                    this.cmbProfession.Text = "           Select Profession";
                }

                this.txtBoxMemPass.Text = "";
                this.txtBoxMemName.Text = "";
                this.txtBoxMemMobile.Text = "";
                this.txtBoxMemAddress.Text = "";
                this.cmbProfession.Text = "           Select Profession";
                this.dTPickerDoB.Text = "";
                this.AutoIdGenerate();
                this.txtBoxMemId.Text = this.AutoIdValue;
            }   
        catch(Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                this.cmbProfession.Text = "           Select Profession";
            }
}

        private void UCAddMember_Load(object sender, EventArgs e)
        {
            this.AutoIdGenerate();
            this.txtBoxMemId.Text = this.AutoIdValue;
        }
    }
}
