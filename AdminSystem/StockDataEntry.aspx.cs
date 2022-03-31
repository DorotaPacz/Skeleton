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
        AStock.StockItemNo = Convert.ToInt32(txtStockItemNo.Text);

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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AStock = new clsStock();
        //variable to store the primary key
        Int32 StockItemNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StockItemNo = Convert.ToInt32(txtStockItemNo.Text);
        //find the record
        Found = AStock.Find(StockItemNo);
        //if found
        if(Found == true)
        {
            //display the values of the properties in the form
            txtStockItemDesc.Text = AStock.StockItemDescription;
            txtDateAdded.Text = AStock.DateAdded.ToString();
            txtPrice.Text = AStock.Price.ToString();
            txtQuantityInStock.Text = AStock.QuantityInStock.ToString();

        }
    }
}