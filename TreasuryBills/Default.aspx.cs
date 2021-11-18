using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TreasuryBills
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tuUpdateButton_Click(object sender, EventArgs e)
        {
            var connString = ConfigurationManager.ConnectionStrings["TreasuryBillsClients"].ToString();

            using (var w = new SqlConnection(connString))
            {
                try
                {
                    var sqlCommand = "update InterestedCustomers set firstname=@fname, lastname=@lname, age=@age, custaccountnumber=@custacctnum, customeraddress=@custaddr where CustAccountNumber=@custacctnum";
                    var myCommand = new SqlCommand(sqlCommand, w);

                    myCommand.Parameters.AddWithValue("@fname", tbFName.Text);
                    myCommand.Parameters.AddWithValue("@lname", tbLName.Text);
                    myCommand.Parameters.AddWithValue("@age", tbAge.Text);
                    myCommand.Parameters.AddWithValue("@custacctnum", tbAcctNum.Text);
                    myCommand.Parameters.AddWithValue("@custaddr", tbAddr.Text);

                    w.Open();
                    int noOfAffectedRows = myCommand.ExecuteNonQuery();

                    if (noOfAffectedRows > 0)
                    {
                        lbResult.Text = noOfAffectedRows.ToString() + " row(s) has been updated successfully";
                    }
                }
                catch (SqlException ex)
                {
                    lbResult.Text = ex.ToString();
                }
            }
        }

        protected void tbDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                var connString = ConfigurationManager.ConnectionStrings["TreasuryBillsClients"].ToString();

                using (var w = new SqlConnection(connString))
                {
                    var sqlCommand = "delete from InterestedCustomers where CustAccountNumber=@custacctnum";
                    var myCommand = new SqlCommand(sqlCommand, w);

                    myCommand.Parameters.AddWithValue("@custacctnum", tbDeleteAcctNum.Text);

                    w.Open();
                    int noOfAffectedRows = myCommand.ExecuteNonQuery();

                    if (noOfAffectedRows > 0)
                    {
                        deletedRowsInfo.Text = noOfAffectedRows.ToString() + " row(s) has been successfully deleted";
                    }
                }
            }catch(SqlException ex)
            {
                deletedRowsInfo.Text = ex.ToString();
            }
        }

        protected void tbGetCust_Click(object sender, EventArgs e)
        {
            try
            {
                var connString = ConfigurationManager.ConnectionStrings["TreasuryBillsClients"].ToString();

                using (var w = new SqlConnection(connString))
                {
                    var sqlCommand = "select * from InterestedCustomers";
                    var myCommand = new SqlCommand(sqlCommand, w);

                    //myCommand.Parameters.AddWithValue("@num", Convert.ToInt32(tbNumOfCust.Text));

                    var data = new DataSet(); // dataset helps us to display the result in a table
                    w.Open();


                    var adapter = new SqlDataAdapter(myCommand); // my command carries conn

                    adapter.Fill(data); //filling my adapter with data

                    //this next two line is ASP.NET specific
                    dataTable.DataSource = data;
                    dataTable.DataBind();
                }
            }catch(SqlException ex)
            {
                label.Text = ex.ToString();
            }
        }
    }
}