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
        clsOrderLine anOrderline = new clsOrderLine();

        // capture the properties from Order form and assign them to Order object
        int parsedID = Convert.ToInt32(txtOrderID.Text);
        double parsedTotalPrice = Convert.ToDouble(txtTotalPrice.Text);
        DateTime parsedDateTime = Convert.ToDateTime(txtDate.Text);

        anOrder.ID = parsedID;
        anOrder.Date = parsedDateTime;
        anOrder.TotalPrice = parsedTotalPrice;
        anOrder.IsFulfilled = chkFulfilled.Checked;

        // capture the properties from OrderLine form and assign them to Order object
        int parsedStockItemNo = Convert.ToInt32(txtStockItemNo.Text);
        int parsedOrderIDagain = Convert.ToInt32(txtOrderIDagain.Text);
        int parsedQuantity = Convert.ToInt32(txtQuantity.Text);

        anOrderline.StockItemNo = parsedStockItemNo;
        anOrderline.OrderID = parsedOrderIDagain;
        anOrderline.Quantity = parsedQuantity;

        //store the ID in the session object
        Session["OrderID"] = anOrder;
        Session["Orderline"] = anOrderline;

        // navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");
    }


    // FIND ORDER
    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the Order class
        clsOrder anOrder = new clsOrder();

        //variable to store the primary key
        Int32 ID;

        //variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        ID = Convert.ToInt32(txtOrderID.Text);

        //find the record
        Found = anOrder.Find(ID);
        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderID.Text = Convert.ToString(anOrder.ID);
            txtTotalPrice.Text = Convert.ToString(anOrder.TotalPrice);
            txtDate.Text = Convert.ToString(anOrder.Date);
            chkFulfilled.Checked = anOrder.IsFulfilled;
        }
    }

    //FIND ORDERLINE
    protected void Button2_Click(object sender, EventArgs e)
    {
        //create an instance of orderline 
        clsOrderLine anOrderLine = new clsOrderLine();

        //variable to store the primary key
        Int32 StockItemNo;

        //variable to store the result of the find operation
        Boolean Found = false;

        //get primary key entered by the user
        StockItemNo = Convert.ToInt32(txtStockItemNo.Text);

        //find the recort
        Found = anOrderLine.Find(StockItemNo);
        
        //if found
        if (Found == true )
        {
            //display values of the properties in the form
            txtStockItemNo.Text = Convert.ToString(anOrderLine.StockItemNo);
            txtOrderIDagain.Text = Convert.ToString(anOrderLine.OrderID);
            txtQuantity.Text = Convert.ToString(anOrderLine.Quantity);
        }

    }
}