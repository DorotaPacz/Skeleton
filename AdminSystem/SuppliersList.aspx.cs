using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySupplieres();
        }
    }
    void DisplaySupplieres()
    {
        clsSuppliersCollection Supplieres = new clsSuppliersCollection();
        IstSuppliersList.DataSource = Supplieres.SuppliersList;
        IstSuppliersList.DataValueField = "SupplierId";
        IstSuppliersList.DataTextField = "SupplierAddress";
        IstSuppliersList.DataBind();

    }
}