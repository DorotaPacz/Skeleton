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
        //create new instance
        clsStaff AStaff = new clsStaff();
        //capture the Id  
        AStaff.IdNoOK = Convert.ToInt32(txtStaffIdNo.Text);
        //capture the name
        AStaff.StaffName = txtStaffName.Text;
        //capture the registration date
        AStaff.DateBegin = Convert.ToDateTime(txtStaffStartDate.Text);
        //capture the salary
        AStaff.Salary = Convert.ToDouble(txtStaffSalary.Text);
        //capture the admin confirmation 
        AStaff.IsAdmin = chkIsAdmin.Checked;

        //store name
        Session["AStaff"] = AStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }




    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the Primary key
        Int32 StaffIdNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffIdNo = Convert.ToInt32(txtStaffIdNo.Text);
        //find the record
        Found = AStaff.Find(StaffIdNo);
        //if found 
        if(Found ==true)
        {
            //display the values of the properties in the form
            txtStaffName.Text = AStaff.StaffName;
            txtStaffStartDate.Text = AStaff.DateBegin.ToString();
            txtStaffSalary.Text = AStaff.Salary.ToString();
            chkIsAdmin.Text = AStaff.IsAdmin.ToString();
        }
    }
}