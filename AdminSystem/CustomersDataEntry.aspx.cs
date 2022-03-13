using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();

        Customer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Customer.CustomerName = txtCustomerName.Text;
        Customer.CustomerDOB = Convert.ToDateTime(txtCustomerDOB.Text);
        Customer.StudnetDisscountPercentage = Convert.ToDouble(txtStudentDiscountPercentage.Text);
        Customer.IsStudent = Convert.ToBoolean(chkIsStudnet.Checked);
        Session["Customer"] = Customer;

         //navigate to the viewer page
        Response.Redirect("CustomersViewer.aspx");



    }

    
}