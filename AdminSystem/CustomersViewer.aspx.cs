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

        Response.Write(Customer.CustomerName);
    }
    protected void Page_Load2(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();

        Customer = (clsCustomer)Session["Customer"];

        Response.Write(Customer.StudnetDisscountPercentage);
    }
    protected void Page_Load3(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();

        Customer = (clsCustomer)Session["Customer"];

        Response.Write(Customer.CustomerDOB);
    }
    protected void Page_Load4(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();

        Customer = (clsCustomer)Session["Customer"];

        Response.Write(Customer.CustomerID);
    }
}
