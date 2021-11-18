using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TreasuryBills
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void tbSend_Click(object sender, EventArgs e)
        {
            var connString = ConfigurationManager.ConnectionStrings["TreasuryBillsClients"].ToString();

            using (var w = new SqlConnection(connString))
            {
                try
                {

                    var sqlCommand = "insert into InterestedCustomers(firstname, lastname, age, custaccountnumber, customeraddress) values(@fname, @lname, @age, @custacctnum, @custaddr)";
                    var myCommand = new SqlCommand(sqlCommand, w);

                    myCommand.Parameters.AddWithValue("@fname", tbFirstName.Text);
                    myCommand.Parameters.AddWithValue("@lname", tbLastName.Text);
                    myCommand.Parameters.AddWithValue("@age", tbAge.Text);
                    myCommand.Parameters.AddWithValue("@custacctnum", tbAccountNumber.Text);
                    myCommand.Parameters.AddWithValue("@custaddr", tbAddress.Text);

                    w.Open();
                    int noOfAffectedRows = myCommand.ExecuteNonQuery();

                    if (noOfAffectedRows > 0)
                    {
                        lbResult.Text = noOfAffectedRows.ToString() + " record(s) has been added successfully";
                    }
                }catch(SqlException ex)
                {
                    lbResult.Text = ex.ToString();
                }
            }
        }
    }
}