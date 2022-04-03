using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is teh first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        //craete an instance of teh customer collection 
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list customers in teh collection 
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the data field to display 
        lstCustomerList.DataTextField = "CustomerName";
        //bind teh data to teh list
        lstCustomerList.DataBind();
    }
}