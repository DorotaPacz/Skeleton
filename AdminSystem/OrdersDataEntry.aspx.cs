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

        }
    }
}