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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1;
        Response.Redirect("SupplierBookDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierId;
        if (IstSuppliersList.SelectedIndex != -1)
        {
            SupplierId = Convert.ToInt32(IstSuppliersList.SelectedValue);

            Session["SupplierId"] = SupplierId;
            Response.Redirect("SuppliersDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a supplier to edit form the list";
        }
    }
}