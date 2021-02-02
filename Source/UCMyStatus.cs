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
    public partial class UCMyStatus : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string UserName { get; set; }
        //private string CurrentRowUser { get; set; }
        public UCMyStatus(string username)
        {
            InitializeComponent();
            this.UserName = username;
        }

        private void UCMyStatus_Load(object sender, EventArgs e)
        {
            this.Sql = "select * from IssueBook where MemberName = '" +this.UserName+ "';";
            this.PopulateGridViewUCViewMemStatus(this.Sql);
        }

        private void PopulateGridViewUCViewMemStatus(string sql)
        {
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(sql);

            this.dGVMyStatus.ClearSelection();
            this.dGVMyStatus.Refresh();
            this.dGVMyStatus.AutoGenerateColumns = false;
            this.dGVMyStatus.DataSource = Ds.Tables[0];
        }
    }
}
