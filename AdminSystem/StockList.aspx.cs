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
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "StockItemNo";
        lstStockList.DataTextField = "StockItemDescription";
        lstStockList.DataBind();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["StockItemNo"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StockItemNo;
        if(lstStockList.SelectedIndex != -1)
        {
            StockItemNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockItemNo"] = StockItemNo;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}