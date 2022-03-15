using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of clsOrder
        clsOrder anOrder = new clsOrder();

        // capture the ID
        // ID & Total price are of type int and we get string from input so we have to convert it
        int parsedID = Int32.Parse(txtOrderID.Text);
        int parsedTotalPrice = Int32.Parse(txtTotalPrice.Text);

        anOrder.ID = parsedID;
        anOrder.TotalPrice = parsedTotalPrice;
        anOrder.IsFulfilled = chkFulfilled.Checked;

        //store the ID in the session object
        Session["OrderID"] = anOrder;
        Session["TotalPrice"] = anOrder;
        Session["isFulfilled"] = anOrder;

        // navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");
    }
}