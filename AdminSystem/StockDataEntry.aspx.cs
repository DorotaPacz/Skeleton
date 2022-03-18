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
        //create a new instance of clsStock
        clsStock AStock = new clsStock();

        //capture stock item number
        AStock.StockItemNo = Convert.ToInt32(txtStockNo.Text);

        //capture stock item description
        AStock.StockItemDescription = txtStockItemDesc.Text;

        //capture stock item date added
        AStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);

        //capture stock item price
        AStock.Price = Convert.ToDouble(txtPrice.Text);

        //capture stock item quantity
        AStock.QuantityInStock = Convert.ToInt32(txtQuantityInStock.Text);

        //capture stock item availability
        AStock.Available = chkAvailable.Checked;

        //store input in the session object
        Session["AStock"] = AStock;

        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}