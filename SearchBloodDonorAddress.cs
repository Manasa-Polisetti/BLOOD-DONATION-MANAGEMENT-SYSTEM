using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood__Donation_Management
{
    // fn = new function();
    public partial class SearchBloodDonorAddress : Form
    {
        public SearchBloodDonorAddress()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBloodDonorAddress_Load(object sender, EventArgs e)
        {
            String query = "Select * from newDonor";
          //  DataSet ds = fn.getData(query);
           // dataGridView1.DataSource= ds.Tables[0];
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if(txtAddress.Text !=" ")
            {
                String query = "select * from newDonor where city like '"+txtAddress.Text+"%' or daddress Like '"+txtAddress.Text+"%' ";
              //  DataSet ds= fn.getData(query);
             // dataGridView1.DataSource= ds.Tables[0];
            }
            else
            {
                String query = " select * from newDonor";
             //   DataSet ds= fn.getData(query);
            // dataGridView1.DataSource=ds.Tables[0];

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
