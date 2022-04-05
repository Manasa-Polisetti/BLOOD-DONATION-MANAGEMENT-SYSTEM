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
    public partial class UpdateDonorDetails : Form
    {
        function fn = new function();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           // int id = int.Parse(txtDonorID.Text.ToString());
          //  String query = "select* from newDonor where did="+id+"";
             //  DataSet ds = fn.getData(query);
            //if(ds.Tables[0].Rows.Count!=0 )
          //  {
                //txtName.Text=ds.Tables[0].Rows[0][1].Tostring();
                //txtFather.Text=ds.Tables[0].Rows[0][2].Tostring();
                //txtMother.Text=ds.Tables[0].Rows[0][3].Tostring();
                //txtDOB.Text=ds.Tables[0].Rows[0][4].Tostring();
                //txtMobile.Text=ds.Tables[0].Rows[0][5].Tostring();
                //txtGender.Text=ds.Tables[0].Rows[0][6].Tostring();
                //txtEmail.Text=ds.Tables[0].Rows[0][7].Tostring();
                //txtBloodGroup.Text=ds.Tables[0].Rows[0][8].Tostring();
                //txtCity.Text=ds.Tables[0].Rows[0][9].Tostring();
                //txtAddress.Text=ds.Tables[0].Rows[0][10].Tostring();


           // }
           // else
            //{
            //MessageBox.Show("Invalid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if(txtDonorID.Text==" ")
            {
                txtName.Clear();
                txtFather.Clear();
                txtMother.Clear();
                txtDOB.ResetText();
                txtMobile.Clear();
                txtGender.ResetText();
                txtEmail.Clear();
                txtBloodGroup.ResetText();
                txtCity.Clear();
                txtAddress.Clear();


            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            String query = "update newDonor set dname=' "+txtName.Text+"',fname='" +txtFather.Text+"',mname='"+txtMother.Text+"' ,mobile="+txtMobile.Text+",gender='"+txtGender.Text+"',email='"+txtEmail.Text+"',bloodgroup='"+txtBloodGroup.Text+"',city='"+txtCity.Text+"',daddress='"+txtAddress.Text+"' where did="+txtDonorID.Text+"           ";
           // fn.setDate(query);
            UpdateDonorDetails_Load(this,null);
        }

    }
}
