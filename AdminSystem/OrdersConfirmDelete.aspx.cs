using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 ID;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the order collection
        clsOrderCollection aCollection = new clsOrderCollection();
        //find record to delete
        aCollection.ThisOrder.Find(ID);
        //delete the order
        aCollection.Delete();
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}