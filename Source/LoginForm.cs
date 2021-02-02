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
    public partial class LoginForm : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = @"select * from UserLogin where UserID = '" + 
                this.txtBoxID.Text + "' and Password = '" + this.txtBoxPassword.Text + "';";

            this.Da = new DataAccess();
            this.Ds = new DataSet();
            this.Ds = this.Da.ExecuteQuery(query);

            if (this.Ds.Tables[0].Rows.Count > 0)
            {
                if (this.Ds.Tables[0].Rows[0]["UserType"].ToString() == "Admin")
                {
                    AdminForm adminForm = new AdminForm(this, Ds.Tables[0].Rows[0]["UserName"].ToString());
                    this.Visible = false;
                    adminForm.Visible = true;
                }
                else if (this.Ds.Tables[0].Rows[0]["UserType"].ToString() == "Librarian")
                {
                    LibrarianForm librarianForm = new LibrarianForm(this, Ds.Tables[0].Rows[0]["UserName"].ToString());
                    this.Visible = false;
                    librarianForm.Visible = true;
                }
                else if (this.Ds.Tables[0].Rows[0]["UserType"].ToString() == "Member")
                {
                    MemberForm memberForm = new MemberForm(this, Ds.Tables[0].Rows[0]["UserName"].ToString());
                    this.Visible = false;
                    memberForm.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("ERROR!!! Incorrect Credentials. \n\n\tPlease Try Again.");
            }

            this.txtBoxID.Text = "";
            this.txtBoxPassword.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtBoxID.Clear();
            this.txtBoxPassword.Clear();
        }
    }
}
