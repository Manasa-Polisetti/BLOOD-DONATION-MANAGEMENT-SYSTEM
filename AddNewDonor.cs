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
    public partial class AddNewDonor : Form1
    {

        function fn = new function();
        public AddNewDonor()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //
        //}

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text!="" && txtFather.Text!="" && txtMother.Text!=" "&& txtDOB.Text!=" "&& txtMobile.Text!=" " && txtGender.Text!=" " && txtEmail.Text!=" ")
            {
                String dname = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtDOB.Text;
                String dob = txtDOB.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String bgroup = txtBloodGroup.Text;
                String city = txtCity.Text;
                String address = txtAddress.Text;
                String query = " insert into newDonor(dname,fname)";

            }

            else
            {
                MessageBox.Show(" Fill all Fields", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddNewDonor_Load(object sender,EventArgs e)
        {
            String query = "SELECT MAX(did) FROM newDonor1";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text =count.ToString();

        }

    }
}
