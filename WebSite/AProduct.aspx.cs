using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library; 

public partial class AProduct : System.Web.UI.Page
{
    Int32 ProductID; 

    protected void Page_Load(object sender, EventArgs e)
    {
        //clear existing error messages
        lblError.Text = "";
        //get number of products to be processed
        ProductID = Convert.ToInt32(Session["ProductID"]);
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //populate the list 
            DisplayProducts();
            //if this is not a new record 
            if (ProductID != -1)
            {
                //display current data for record
                DisplayProducts(); 
            }
        }
    }

    void Add()
    {
        //create an instance of product book
        clsProductsCollection ProductBook = new clsProductsCollection();
        //validate the data on the web form
        String Error = ProductBook.ThisProduct.Valid(txtProductID.Text, txtProductName.Text, txtPrice.Text, txtQuantity.Text); 
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by user
            ProductBook.ThisProduct.ProductID = Convert.ToInt32(txtProductID.Text);
            ProductBook.ThisProduct.ProductName = txtProductName.Text;
            ProductBook.ThisProduct.Price = Convert.ToDouble(txtPrice.Text);
            ProductBook.ThisProduct.Quantity = Convert.ToInt32(txtQuantity.Text);
            //add the record 
            ProductBook.Add();
            //redirec to default page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error; 
        }
    }

    void Update()
    {
        //create an instance of product book
        clsProductsCollection ProductBook = new clsProductsCollection();
        //validate the data on the web form
        String Error = ProductBook.ThisProduct.Valid(txtProductID.Text, txtProductName.Text, txtPrice.Text, txtQuantity.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by user
            ProductBook.ThisProduct.ProductID = Convert.ToInt32(txtProductID.Text);
            ProductBook.ThisProduct.ProductName = txtProductName.Text;
            ProductBook.ThisProduct.Price = Convert.ToDouble(txtPrice.Text);
            ProductBook.ThisProduct.Quantity = Convert.ToInt32(txtQuantity.Text);
            //update the record 
            ProductBook.Update();
            //redirec to default page
            Response.Redirect("Default.aspx"); 
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayProducts()
    {
        //create an instance of product book
        clsProductsCollection ProductBook = new clsProductsCollection();
        //find the record to update 
        ProductBook.ThisProduct.Find(ProductID);
        //display the data for this record 
        txtProductID.Text = ProductBook.ThisProduct.ProductID.ToString();
        txtProductName.Text = ProductBook.ThisProduct.ProductName;
        txtPrice.Text = ProductBook.ThisProduct.Price.ToString();
        txtQuantity.Text = ProductBook.ThisProduct.Quantity.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (ProductID == -1)
        {
            //add new record 
            Add();
        }
        else
        {
            //update record
            Update(); 
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("Default.aspx");
    }
}