using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood__Donation_Management
{
    class function

    {
       // public SqlConnection cmd { get; private set; }

        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString="data source= bloodbank.database.windows.net;database=bloodbank;integrated security=True";
            return con;


        }
        public DataSet getData(String query)
       {
             SqlConnection con = getConnection();
             SqlCommand cmd = new SqlCommand();
             cmd.Connection=con;
             cmd.CommandText=query;
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             da.Fill(ds);
             return ds;
            
        }

      

      

      //  protected void setData(String query, SqlConnection cmd)
           
       // {
          
        //SqlConnection con = getConnection();
        //var cmd = new SqlConnection();
        //cmd.ConnectionString = con;
        //con.Open();
        //cmd.CommandText= query;
        //cmd.ExecuteNonQuery();
        //con.Close();
        //MessageBox.Show("Data processed successfully.","success",MessageBoxButtons.OK,MessageBoxIcon.Information            );

      //}




    }            
}
