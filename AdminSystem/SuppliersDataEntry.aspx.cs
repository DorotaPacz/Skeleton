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
        clsSuppliers AnSuppliers = new clsSuppliers();
        AnSuppliers.SupplierName = txtSupplierName.Text;
        AnSuppliers.SupplierEmail = txtSupplierEmail.Text;
        AnSuppliers.SupplierAddress = txtSupplierAddress.Text;
        //AnSuppliers.SupplierContactNo = strSupplierContactNo.Text;
        AnSuppliers.SupplierAvailable = chkSupplierAvailable.Checked;
        Session["AnSuppliers"] = AnSuppliers;
            //navigate to the viewer page
        Response.Redirect("SuppliersViewer.aspx");
    }




    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSuppliers AnSuppliers = new clsSuppliers();
        Int32 SupplierId;
        Boolean Found = false;
        SupplierId = Convert.ToInt32(txtSupplierId.Text);
        Found = AnSuppliers.Find(SupplierId);
        if (Found == true)

        txtSupplierName.Text = AnSuppliers.SupplierName;
        //txtSupplierContactNo.= AnSuppliers.SuppliersContactNo.ToString;
        txtSupplierEmail.Text = AnSuppliers.SupplierEmail;
        txtSupplierAddress.Text = AnSuppliers.SupplierAddress;

    }
}