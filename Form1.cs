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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
         if(txtUsername.Text == "somedays" && txtPassword.Text == "pass")
            {
                Dashboard db = new Dashboard();
                db.Show();
            }
           else
            {
                MessageBox.Show("Enter valid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled= false;
        }

        //private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
            //if(btnHideShow.Text =="Show")
            //{
              //  btnHideShow.Text ="Hide";
                //txtPassword.PasswordChar='\0';
            //}
            //else 
            //{
              //  btnHideShow.Text="Show";
                //txtPassword.PasswordChar='*';
            //}
        //}

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox.Checked ==true)
            {
               btnLogin.Enabled=true;
            }
             else
            {
                btnLogin.Enabled=false;
              }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHideShow_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text =="Show")
            {
                btnHideShow.Text ="Hide";
                txtPassword.PasswordChar='\0';
            }
            else
            {
                btnHideShow.Text="Show";
                txtPassword.PasswordChar='*';
            }

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "somedays" && txtPassword.Text == "pass")
            {
                Dashboard db = new Dashboard();
                db.Show();
            }
            else
            {
                MessageBox.Show("Enter valid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
