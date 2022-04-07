using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }
    }

    public void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to list of staff in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "IdNoOK";
        //set the data field to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();
       
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["IdNoOK"] = -1;
        //redirect to the data entry
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key
        Int32 StaffIdNo;
        //if the record has been selected from the list
        if(lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record edit
            StaffIdNo = Convert.ToInt32(lstStaffList.SelectedValue);
            //store data in the sesion object
            Session["StaffIdNo"] = StaffIdNo;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else //if no ecord has been selected
        {
            lblError.Text = "Please select the record to edit from the list";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffIdNo;
        //if the record has been selected from the list
        if(lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffIdNo = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffIdNo"] = StaffIdNo;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportByStaffName(txtStaffName.Text);
        lstStaffList.DataSource = Staffs.StaffList;
        //set the name of the primary key 
        lstStaffList.DataValueField = "IdNoOK";
        //set the name of the field to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();
    }



    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportByStaffName("");
        //clear any existing filter to tidy up the interface 
        txtStaffName.Text = "";
        lstStaffList.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "IdNoOK";
        //set the name of the field to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list 
        lstStaffList.DataBind();
    }
}