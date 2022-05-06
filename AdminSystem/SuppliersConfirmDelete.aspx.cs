using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierId = Convert.ToInt32(Session["SupplierId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsSuppliersCollection SupplierBook = new clsSuppliersCollection();
        SupplierBook.ThisSuppliers.Find(SupplierId);
        SupplierBook.Delete();
        Response.Redirect("SupplierList.aspx");
    }
}