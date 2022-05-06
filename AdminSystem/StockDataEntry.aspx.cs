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
        //capture info
        string StockItemDescription = txtStockItemDesc.Text;
        string DateAdded = txtDateAdded.Text;
        string Price = txtPrice.Text;
        string QuantityInStock = txtQuantityInStock.Text;
        string Error = "";

        //validate
        Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
        if(Error == "")
        {
            //capture info
            AStock.StockItemDescription = StockItemDescription;
            AStock.DateAdded = Convert.ToDateTime(DateAdded);
            AStock.Price = Convert.ToDouble(Price);
            AStock.QuantityInStock = Convert.ToInt32(QuantityInStock);
            //store stock in session object
            Session["AStock"] = AStock;
            //redirect to the viewr page
            Response.Write("StockViewer.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
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