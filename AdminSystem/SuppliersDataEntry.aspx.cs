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
        string SupplierName = txtSupplierName.Text;
        string SupplierEmail = txtSupplierEmail.Text;
        string SupplierAddress = txtSupplierAddress.Text;
        string SupplierContactNo = txtSupplierContactNo.Text;
        string Error = "";
        Error = AnSuppliers.Valid(SupplierName, SupplierEmail, SupplierAddress, SupplierContactNo);
        if (Error == "")
        {
            AnSuppliers.SupplierName = SupplierName;
            AnSuppliers.SupplierEmail = SupplierEmail;
            AnSuppliers.SupplierAddress = SupplierAddress;
            // AnSuppliers.SupplierContactNo = txtSupplierContactNo.Text;
             AnSuppliers.SupplierAvailable = chkSupplierAvailable.Checked;
            clsSuppliersCollection SuppliersList = new clsSuppliersCollection();
            SuppliersList.ThisSuppliers = AnSuppliers;
            SuppliersList.Add();
           // Session["AnSuppliers"] = AnSuppliers;
            //navigate to the viewer page
            Response.Redirect("SuppliersViewer.aspx");
        }
        else
        {
            //display the error message
            iblError.Text = Error;
        }
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
        //txtSupplierContactNo.Text= AnSuppliers.SupplierContactNo;
        txtSupplierEmail.Text = AnSuppliers.SupplierEmail;
        txtSupplierAddress.Text = AnSuppliers.SupplierAddress;

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}