using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{


    Int32 ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the ID of the Order to process
        ID = Convert.ToInt32(Session["ID"]);
        if(IsPostBack == false)
        {
            //if this is not a new record
            if(ID != -1)
            {
                DisplayOrder();
            }
        }

    }

    void DisplayOrder()
    {
        //create an instance of OrderCollection
        clsOrderCollection aCollection = new clsOrderCollection();

        //find the record to update
        aCollection.ThisOrder.Find(ID);

        // display the data for this record
        txtOrderID.Text = aCollection.ThisOrder.ID.ToString();
        txtDate.Text = aCollection.ThisOrder.Date.ToString();
        txtTotalPrice.Text = aCollection.ThisOrder.TotalPrice.ToString();
        chkFulfilled.Checked = aCollection.ThisOrder.IsFulfilled;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of clsOrder
        clsOrder anOrder = new clsOrder();
        clsOrderLine anOrderline = new clsOrderLine();

        // capture the properties from Order form and assign them to Order object

        string testDate = txtDate.Text;
        string testTotalPrice = txtTotalPrice.Text;
        string testQuantity = txtQuantity.Text;
        string Error = "";

        Error = anOrder.Valid(testDate, testTotalPrice);
        Error = Error + anOrderline.Valid(testQuantity);
        if (Error == "")
        {
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

            //collection object  add update delete methods
            clsOrderCollection OrderCollection = new clsOrderCollection();

            if(ID == -1)
            {
                OrderCollection.ThisOrder = anOrder;
                OrderCollection.Add();
            }
            else
            {
                //find the record to update 
                OrderCollection.ThisOrder.Find(ID);
                OrderCollection.ThisOrder = anOrder;
                OrderCollection.Update();
            }


            // navigate to the viewer page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
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