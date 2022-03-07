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
        clsSuppliers AnSuppliers = new clsSuppliers();
        AnSuppliers = (clsSuppliers)Session["AnSuppliers"];
        Response.Write(AnSuppliers.SupplierName);
        Response.Write(AnSuppliers.SupplierEmail);
        Response.Write(AnSuppliers.SupplierAddress);
        //Response.Write(AnSuppliers.SupplierContactNo);
        Response.Write(AnSuppliers.SupplierAvailable);


    }
}