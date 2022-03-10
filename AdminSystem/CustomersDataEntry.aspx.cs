using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();

        Customer.CustomerName = txtCustomerName.Text;
      
        Session["Customer"] = Customer;

      //  Customer.CustomerDOB = txtCustomerDOB.Text;

       // Session["Customer"] = Customer;

        //Customer.CustomerID = txtCustomerID.Text;

       //Session["Customer"] = Customer;

        
         //navigate to the viewer page
        Response.Redirect("CustomersViewer.aspx");



    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }
}