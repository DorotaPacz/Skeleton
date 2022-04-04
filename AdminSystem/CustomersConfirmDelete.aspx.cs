using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key valueof the recored to be deleted
    Int32 CustomerID;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get theh number of the customer to be deleted fom teh session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instnce of the address book class
        clsCustomerCollection CustomerL = new clsCustomerCollection();
        //find the recored to deleted
        CustomerL.ThisCustomer.Find(CustomerID);
        //delete the recored
        CustomerL.Delete();
        //redirect back to the main page
        Response.Redirect("CustomersList.aspx");
    }
}