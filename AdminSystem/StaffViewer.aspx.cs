using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get data from session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the ID number of the staff
        Response.Write(AStaff.IdNoOK + "<br/>");
        //display the name of the staff
        Response.Write(AStaff.StaffName + "<br/>");
        //display the registration date of the staff
        Response.Write(AStaff.DateBegin + "<br/>");
        //display the salary of the staff
        Response.Write(AStaff.Salary + "<br/>");
        //Confirm that the staff is Admin
        Response.Write(AStaff.IsAdmin);
    }


}