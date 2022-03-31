using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key
    Int32 StaffIdNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        //get the number of the address to be deleted from the session object
        StaffIdNo = Convert.ToInt32(Session["StaffIdNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Staff Register class
        clsStaffCollection StaffRegister = new clsStaffCollection();
        //find the record to delete
        StaffRegister.ThisStaff.Find(StaffIdNo);
        //delete the record
        StaffRegister.Delete();
        //redirect back to the main page
        Response.Redirect("StaffDataEntry.aspx");
    }
}