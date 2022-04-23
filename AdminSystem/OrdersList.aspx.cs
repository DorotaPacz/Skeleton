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
        if(IsPostBack == false)
        {
            DisplayAddresses();
        }
    }

    void DisplayAddresses()
    {
        clsOrderCollection OrderCollection = new clsOrderCollection();
        lstOrderList.DataSource = OrderCollection.OrderList;
        lstOrderList.DataValueField = "ID";
        lstOrderList.DataTextField = "TotalPrice";
        lstOrderList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrdersDataEntry.aspx");
    }
}

