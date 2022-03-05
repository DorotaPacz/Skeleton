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
        AStaff.IdNoOK = Convert.ToInt32(txtIdNo.Text);
        //capture the name
        AStaff.StaffName = txtName.Text;
        //capture the registration date
        AStaff.DateBegin = Convert.ToDateTime(txtStartDate.Text);
        //capture the salary
        AStaff.Salary = Convert.ToDouble(txtSalary.Text);
        //capture the admin confirmation 
        AStaff.IsAdmin = chkIsAdmin.Checked;

        //store name
        Session["AStaff"] = AStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    

}