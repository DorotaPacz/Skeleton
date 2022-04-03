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

        //clsCustomer Customer = new clsCustomer();

        //Customer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //Customer.CustomerName = txtCustomerName.Text;
        //Customer.CustomerDOB = Convert.ToDateTime(txtCustomerDOB.Text);
        //Customer.StudnetDiscountPercentage = Convert.ToDouble(txtStudentDiscountPercentage.Text);
        //Customer.IsStudent = Convert.ToBoolean(chkIsStudnet.Checked);
        //Session["Customer"] = Customer;

        // //navigate to the viewer page
        //Response.Redirect("CustomersViewer.aspx");



        //creatr a new instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        //capture the Customer ID
        string CustomerID = txtCustomerID.Text;
        //Capture the Customer Name 
        string CustomerName = txtCustomerName.Text;
        //Capture the Customer DOB 
        string CustomerDOB = txtCustomerDOB.Text;
        //Capture the student discount percentage
        string StudnetDiscountPercentage = txtStudentDiscountPercentage.Text;
        //Capture the Is Studnet 
        string IsStudent = chkIsStudnet.Text;

        //Variable to store any error message 
        string Error = "";
        //Validate the data 
        Error = Customer.Valid( CustomerName, CustomerDOB, StudnetDiscountPercentage);
        if (Error == "")
        {
            //Capture the Customer Id 
             Customer.CustomerID = Convert.ToInt32(CustomerID);
            //Capture the Customer name 
            Customer.CustomerName = CustomerName;
            //Capture the customer DOB
            Customer.CustomerDOB = Convert.ToDateTime(CustomerDOB);
            //capture the student disscount percentage
            Customer.StudnetDiscountPercentage = Convert.ToDouble(StudnetDiscountPercentage);
            //Capture the is studnet 
            Customer.IsStudent = Convert.ToBoolean(IsStudent);
            //create a new instance if teh Customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //set the ThisCustomer property
            CustomerList.ThisCustomer = Customer;
            //add the new recored
            CustomerList.Add();
            //redirect back to the listpage
            Response.Redirect("CustomersList");


            ////store the custmer is the session object 
            //Session["Customer"] = Customer;
            ////Redirect to the viewer page
            //Response.Write("CustomersViewer.aspx");

        }
        else
        {
            //Display the error message 
            lblError.Text = Error;
        }

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