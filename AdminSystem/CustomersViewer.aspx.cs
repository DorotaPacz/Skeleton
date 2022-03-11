using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();

        Customer = (clsCustomer)Session["Customer"];

        Response.Write(Customer.CustomerID);
        Response.Write(Customer.CustomerName);
        Response.Write(Customer.CustomerDOB);
        Response.Write(Customer.StudnetDisscountPercentage);
        Response.Write(Customer.IsStudent);
        
     
        

    }
   
}
