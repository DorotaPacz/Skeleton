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
        //create new instance of Order & OrderLine
        clsOrder anOrder = new clsOrder();
        clsOrderLine anOrderLine = new clsOrderLine();

        //get the data from the session object
        anOrder = (clsOrder) Session["OrderID"];
        anOrderLine = (clsOrderLine) Session["Orderline"];

        //display the house number for this entry
     
        //Write order
        Response.Write(anOrder.ID);
        Response.Write(anOrder.Date);
        Response.Write(anOrder.TotalPrice);
        Response.Write(anOrder.IsFulfilled);

        //Write Orderline
        Response.Write(anOrderLine.StockItemNo);
        Response.Write(anOrderLine.OrderID);
        Response.Write(anOrderLine.Quantity);


    }
}