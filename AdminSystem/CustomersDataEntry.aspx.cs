using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    //var to store the primary key with page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if(IsPostBack == false)
        {
            // if this is not a new recored
            if (CustomerID != -1)
            {
                //display teh current daat for the recored
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        //craete an instance of the customerList
        clsCustomerCollection CustomerL = new clsCustomerCollection();
        //find teh recored to update
        CustomerL.ThisCustomer.Find(CustomerID);
        //dispaly the data for this recored
        txtCustomerID.Text = CustomerL.ThisCustomer.CustomerID.ToString();
        txtCustomerName.Text = CustomerL.ThisCustomer.CustomerName;
        txtCustomerDOB.Text = CustomerL.ThisCustomer.CustomerDOB.ToString();
        txtStudentDiscountPercentage.Text = CustomerL.ThisCustomer.StudnetDiscountPercentage.ToString();
        chkIsStudnet.Checked = CustomerL.ThisCustomer.IsStudent;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

  



        //creatr a new instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        //capture the Customer ID
        // ustring CustomerID = txtCustomerID.Text;
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

            
            //if this is a new recored i.e. CustomerID = -1 then add the data
           if (CustomerID == -1)
            {
                //seth the ThisCustomer property
                CustomerList.ThisCustomer = Customer;
                //add the new recored
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the recored to update
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the thisCustomer property
                CustomerList.Update();
                //update the recored
                CustomerList.Update();
            }
            //redirectt back to the listpage
            Response.Redirect("CustomersList.aspx");
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