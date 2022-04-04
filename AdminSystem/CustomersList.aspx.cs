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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 ito the session object to indicate this is a new recored
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of teh recored to be edited
        Int32 CustomerID;
        //if a recored has been selected from tge ;ist
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key va;ie of teh recored to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to th edit page
            Response.Redirect("CustomersDataEntry.aspx");
        }
        else //if no recored has been selected
        {
            lblError.Text = "Please select a recored to edit from the list";

        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key valueof the recored to be edited
        Int32 CustomerID;
        //if a recored has been selected from teh list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of teh recored to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redired to the delete page
            Response.Redirect("CustomersConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a recored to delete from the list";
        }
    }
}