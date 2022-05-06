using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StockItemNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockItemNo = Convert.ToInt32(Session["StockItemNo"]);
        if(IsPostBack == false)
        {
            if(StockItemNo != -1)
            {
                DisplayStock();
            }
        }
    }

    private void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(StockItemNo);
        txtStockItemNo.Text = Stock.ThisStock.StockItemNo.ToString();
        txtStockItemDesc.Text = Stock.ThisStock.StockItemDescription.ToString();
        txtDateAdded.Text = Stock.ThisStock.DateAdded.ToString();
        txtQuantityInStock.Text = Stock.ThisStock.QuantityInStock.ToString();
        txtPrice.Text = Stock.ThisStock.Price.ToString();
        chkAvailable.Checked = Stock.ThisStock.Available;
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
            AStock.StockItemNo = StockItemNo;
            AStock.StockItemDescription = StockItemDescription;
            AStock.DateAdded = Convert.ToDateTime(DateAdded);
            AStock.Price = Convert.ToDouble(Price);
            AStock.QuantityInStock = Convert.ToInt32(QuantityInStock);
            AStock.Available = chkAvailable.Checked;

            clsStockCollection StockList = new clsStockCollection();
            
            if(StockItemNo == -1)
            {
                StockList.ThisStock = AStock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(StockItemNo);
                StockList.ThisStock = AStock;
                StockList.Update();
            }
            Response.Redirect("AddressBoookList.aspx");
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