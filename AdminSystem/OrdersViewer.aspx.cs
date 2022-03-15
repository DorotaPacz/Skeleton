using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new instance of Order
        clsOrder anOrder = new clsOrder();

        //get the data from the session object
        anOrder = (clsOrder) Session["OrderID"];
        anOrder = (clsOrder) Session["TotalPrice"];

        //display the house number for this entry
     
        Response.Write(anOrder.ID);
        Response.Write(anOrder.TotalPrice);
        Response.Write(anOrder.IsFulfilled);
    }
}