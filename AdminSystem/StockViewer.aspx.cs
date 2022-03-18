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
        //create new instance of clsStock
        clsStock AStock = new clsStock();

        //get the data from the session object
        AStock = (clsStock)Session["AStock"];

        //display stock number for this entry
        Response.Write(AStock.StockItemNo + "<br/>");

        //display stock description
        Response.Write(AStock.StockItemDescription + "<br/>");

        //display stock date added
        Response.Write(AStock.DateAdded + "<br/>");

        //display stock item price
        Response.Write(AStock.Price + "<br/>");

        //display stock item quantity
        Response.Write(AStock.QuantityInStock + "<br/>");

        //display stock item availability
        Response.Write(AStock.Available);
    }
}