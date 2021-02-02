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
    public partial class UCAddBook : UserControl
    {
        private string Sql { get; set; }
        private DataAccess Da { get; set; }
        public UCAddBook()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
            {
            try
            {
                this.Sql = @"INSERT INTO Inventory VALUES('" + this.txtBoxBName.Text + "', '" +
                     this.txtBoxAuthor.Text + "', " + this.txtBoxPubYear.Text + ", '"
                    + this.cmbPublication.Text + "', '" + this.cmbCategory.Text + "', "
                    + this.txtBoxPrice.Text + ", " + this.txtBoxQuantity.Text + "); ";

                int row = this.Da.ExecuteUpdateQuery(this.Sql);
                if (row == 1)
                    MessageBox.Show("1 row added Successfully");
                else
                {
                    MessageBox.Show("Error! Please fill up the information correctly.");
                    this.cmbCategory.Text = "            Select Category";
                    this.cmbPublication.Text = "          Select Publication";
                }

                    this.txtBoxBName.Text = "";
                this.txtBoxAuthor.Text = "";
                this.cmbCategory.Text = "            Select Category";
                this.cmbPublication.Text = "          Select Publication";
                this.txtBoxPrice.Text = "";
                this.txtBoxPubYear.Text = "";
                this.txtBoxQuantity.Text = "";
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                this.cmbCategory.Text = "            Select Category";
                this.cmbPublication.Text = "          Select Publication";
            }
        }
    }
}
