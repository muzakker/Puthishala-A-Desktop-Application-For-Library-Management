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
    public partial class UCPenaltyStatus : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string CurrentRowUser { get; set; }
        private string UserName { get; set; }
        public UCPenaltyStatus(string username)
        {
            InitializeComponent();
            this.UserName = username;
        }

        private void UCPenaltyStatus_Load(object sender, EventArgs e)
        {
            this.Sql = "select * from PenaltyStatus where MemberName = '"+ this.UserName +"';";
            this.PopulateGridViewUCViewMemPenaltyStatus(this.Sql);
        }
        private void PopulateGridViewUCViewMemPenaltyStatus(string sql)
        {
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(sql);

            this.dGVPenaltyStatus.ClearSelection();
            this.dGVPenaltyStatus.Refresh();
            this.dGVPenaltyStatus.AutoGenerateColumns = false;
            this.dGVPenaltyStatus.DataSource = Ds.Tables[0];
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                this.CurrentRowUser = this.dGVPenaltyStatus.CurrentRow.Cells["MemberID"].Value.ToString();
                if (this.CurrentRowUser == null)
                {
                    MessageBox.Show("You do not have any Penalty.");
                }
                else
                {
                    
                    this.Sql = @"DELETE FROM PenaltyStatus WHERE MemberID ='" + this.CurrentRowUser + "';";
                    int row = this.Da.ExecuteUpdateQuery(this.Sql);


                    if (row == 1)
                        MessageBox.Show("Penalty Cleared.");
                    else
                        MessageBox.Show("ERROR! Penalty Payment Failed");

                    this.Sql = "select * from PenaltyStatus;";
                    this.PopulateGridViewUCViewMemPenaltyStatus(this.Sql);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message);
            }
        }
    }
}
