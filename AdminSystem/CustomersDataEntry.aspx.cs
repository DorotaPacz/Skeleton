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
        Customer.StudnetDiscountPercentage = Convert.ToDouble(txtStudentDiscountPercentage.Text);
        Customer.IsStudent = Convert.ToBoolean(chkIsStudnet.Checked);
        Session["Customer"] = Customer;

         //navigate to the viewer page
        Response.Redirect("CustomersViewer.aspx");



    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomer Customer = new clsCustomer();
        //variable to ostore the primary key
        Int32 CustomerID;
        //variable to store the result of theh find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = Customer.Find(CustomerID);
        //if found
        if(Found == true)
        {
            //display the values of the properties in the form
            
            txtCustomerName.Text = Customer.CustomerName;
            txtCustomerDOB.Text = Customer.CustomerDOB.ToString();
            txtStudentDiscountPercentage.Text = Customer.StudnetDiscountPercentage.ToString();
           

        }
    }
}