using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //this function is the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear existing error messages
        lblError.Text = "";
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //populate the list and display the number of records found
            lblError.Text = DisplayProducts("") + " products in the database";
        }
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ProductNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AProduct.aspx");
    }

    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ProductNo;
        //if a record has been selected from the list
        if (lstProducts.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductNo = Convert.ToInt32(lstProducts.SelectedValue);
            //store the data in the session object
            Session["ProductNo"] = ProductNo;
            //redirect to the edit page
            Response.Redirect("AProduct.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a product to edit from the list";
        }
    }

    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 ProductNo;
        //if a record has been selected from the list
        if (lstProducts.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ProductNo = Convert.ToInt32(lstProducts.SelectedValue);
            //store the data in the session object
            Session["ProductNo"] = ProductNo;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a product to delete from the list";
        }
    }

    //event handler for the apply button
    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayProducts function to the record count var
        RecordCount = DisplayProducts(txtProduct.Text);
        //display the number of records found
        lblError.Text = RecordCount + " products found";
    }

    //event hanlder for the display all button
    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayProducts function to the record count var
        RecordCount = DisplayProducts("");
        //display the number of records found
        lblError.Text = RecordCount + " products in the database";
        //clear the post code filter text box
        txtProduct.Text = "";
    }

    //function use to populate the list box
    Int32 DisplayProducts(string ProductsFilter)
    {
        //var to store the count of records
        Int32 RecordCount;
        //return the number of records found
        return 1;
    }
}