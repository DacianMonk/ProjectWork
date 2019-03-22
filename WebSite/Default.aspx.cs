using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library; 

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
            lblError.Text = DisplayFilteredProducts("") + " records in the database";
        }
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ProductID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AProduct.aspx");
    }

    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ProductID;
        //if a record has been selected from the list
        if (lstProducts.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductID = Convert.ToInt32(lstProducts.SelectedValue);
            //store the data in the session object
            Session["ProductNo"] = ProductID;
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
        Int32 ProductID;
        //if a record has been selected from the list
        if (lstProducts.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ProductID = Convert.ToInt32(lstProducts.SelectedValue);
            //store the data in the session object
            Session["ProductID"] = ProductID;
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
        RecordCount = DisplayFilteredProducts(txtProduct.Text);
        //display the number of records found
        lblError.Text = RecordCount + " products found";
    }

    //event hanlder for the display all button
    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayProducts function to the record count var
        RecordCount = DisplayFilteredProducts("");
        //display the number of records found
        lblError.Text = RecordCount + " products in the database";
        //clear the post code filter text box
        txtProduct.Text = "";
    }


    Int32 DisplayFilteredProducts(string ProductNameFilter)
    {
        //create instance of products collection
        clsProductsCollection Products = new clsProductsCollection();
        //store records count
        Int32 RecordCount;
        //variables 
        string ProductID;
        string ProductName;
        string Price;
        string Quantity;
        Int32 Index = 0;
        //clear list 
        lstProducts.Items.Clear();
        //call the filter
        Products.ReportByProductName(ProductNameFilter);
        //count records found
        RecordCount = Products.Count;
        // loop each record
        while (Index < RecordCount)
        {
            //get the product id from the query results
            ProductID = Convert.ToString(Products.ProductsList[Index].ProductID);
            //get the product name from the query results
            ProductName = Convert.ToString(Products.ProductsList[Index].ProductName);
            //get the price from the query results
            Price = Convert.ToString(Products.ProductsList[Index].Price);
            //get the quantity from the query results
            Quantity = Convert.ToString(Products.ProductsList[Index].Quantity);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem("Name:" + ProductName + " " + "Price:" + Price + " " + "Quantity:" + Quantity, ProductID);
            //add the new item to the list
            lstProducts.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }
}