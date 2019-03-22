using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted 
    Int32 ProductID; 

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the product to be deleted  
        ProductID = Convert.ToInt32(Session["ProductID"]); 
    }

    void DeleteProduct()
    {
        //create new instance of product book
        clsProductsCollection ProductBook = new clsProductsCollection();
        //find the record to delete 
        ProductBook.ThisProduct.Find(ProductID);
        //delete the record 
        ProductBook.Delete(); 
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteProduct();
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }
}