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
    public partial class UCPenalty : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string CurrentRowUser { get; set; }
        private string CurrentRowUserName { get; set; }
        private string CurrentRowUserBook { get; set; }

        public UCPenalty()
        {
            InitializeComponent();
        }

        private void PopulateGridViewUCViewMemPenalty(string sql)
        {
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(sql);

            this.dGVPenalty.ClearSelection();
            this.dGVPenalty.Refresh();
            this.dGVPenalty.AutoGenerateColumns = false;
            this.dGVPenalty.DataSource = Ds.Tables[0];
        }

        private void UCPenalty_Load(object sender, EventArgs e)
        {
            this.Sql = "select * from IssueBook;";
            this.PopulateGridViewUCViewMemPenalty(this.Sql);
        }

        int durationLeft = 0;
        int durationExceed = 0;
        private void btnDurationExceed_Click(object sender, EventArgs e)
        {
            try
            {
                string dateWhole = this.dGVPenalty.CurrentRow.Cells["IssueDate"].Value.ToString();
                string[] dateCustom = dateWhole.Split('/');
                string day = dateCustom[0];
                int day1 = Convert.ToInt32(day);
                int duration = Convert.ToInt32(this.dGVPenalty.CurrentRow.Cells["Duration"].Value.ToString());
                int day2 = DateTime.Today.Day;
                if (day2 >= day1)
                {
                    durationLeft = day2 - day1;
                }
                else
                {
                    if (DateTime.Today.Month == 31)
                    {
                        durationLeft = (31 - day1) + day2;
                    }
                    else if (DateTime.Today.Month == 28)
                    {
                        durationLeft = (28 - day1) + day2;
                    }
                    else if (DateTime.Today.Month == 29)
                    {
                        durationLeft = (29 - day1) + day2;
                    }
                    else
                    {
                        durationLeft = (30 - day1) + day2;
                    }
                }
                if(duration >= durationLeft)
                    this.txtBoxDurationExceed.Text = "0";
                else
                {
                    this.durationExceed = durationLeft - duration;
                    this.txtBoxDurationExceed.Text = this.durationExceed.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }

         private void btnPenaltyAmount_Click(object sender, EventArgs e)
        {
            this.txtBoxPenaltyAmount.Text = (durationExceed * 10).ToString();
        }

        private void btnPenalty_Click(object sender, EventArgs e)
        {
            try
            {
                this.CurrentRowUser = this.dGVPenalty.CurrentRow.Cells["MemberID"].Value.ToString();
                this.CurrentRowUserName = this.dGVPenalty.CurrentRow.Cells["MemberName"].Value.ToString();
                this.CurrentRowUserBook = this.dGVPenalty.CurrentRow.Cells["BookName"].Value.ToString();
                int penaltyAmount = Convert.ToInt32(this.txtBoxPenaltyAmount.Text);
                string durationExceeded = this.durationExceed.ToString();

                this.Sql = @"INSERT INTO PenaltyStatus VALUES('" + this.CurrentRowUser + "', '" + this.CurrentRowUserName + "', '"
                    + durationExceed + "', '" + this.CurrentRowUserBook + "', " + penaltyAmount + "); ";

                int row = this.Da.ExecuteUpdateQuery(this.Sql);

                if (row == 1)
                {
                    MessageBox.Show(this.CurrentRowUserName + "  Penalized.");
                }
                else
                {
                    MessageBox.Show("ERROR! Process Failed.");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message);
            }

        }
    }
 
}
