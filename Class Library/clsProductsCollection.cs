using System.Collections.Generic;
using System;
using System.Linq;
using System.Web; 

namespace Class_Library
{
    public class clsProductsCollection
    {
        List<clsProducts> mProductsList = new List<clsProducts>();
        clsProducts mThisProduct = new clsProducts(); 

        //constructor for the class
        public clsProductsCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_SelectAllProducts");
            //populate the array list with the data table
            PopulateArray(DB); 
        }

        public List<clsProducts> ProductsList
        {
            get
            {
                //return the private data 
                return mProductsList; 
            }
            set
            {
                //set the private data 
                mProductsList = value; 
            }
         }

        public int Count
        {
            get
            {
                return mProductsList.Count; 
            }
            set
            {

            }
        }

        public clsProducts ThisProduct
        {
            get
            {
                //return private data
                return mThisProduct; 
            }
            set
            {
                //set private data
                mThisProduct = value; 
            }
        }

        public int Add()
        {
            //connect to database 
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Quantity", mThisProduct.Quantity);
            //execute the query returning the primary value
            return DB.Execute("sproc_tblProduct_Insert"); 
        }

        public void Delete()
        {
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            //execute the stored procedure 
            DB.Execute("sproc_tblProduct_Delete"); 
        }

        public void Update()
        {
            //connect to database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for stored procedure 
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Quantity", mThisProduct.Quantity);
            //execute stored procedure
            DB.Execute("sproc_tblProducts_Update"); 
        }

        public void ReportByProductName(string ProductName)
        {
            //filters the records based on a full or partial product name
            //connect to database 
            clsDataConnection DB = new clsDataConnection();
            //send the product name parameter to database
            DB.AddParameter("@ProductName", ProductName);
            //execute stored procedure 
            DB.Execute("sproc_tblProduct_FilterByProductName");
            //populate the array list with the data table
            PopulateArray(DB); 
        }

        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            RecordCount = DB.Count;
            //clear private array list
            mProductsList = new List<clsProducts>(); 
            //while there are records
            while (Index < RecordCount)
            {
                //create a blank product 
                clsProducts AProduct = new clsProducts();
                //read in the fields from the current record 
                AProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AProduct.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AProduct.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AProduct.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                //add the record to the private data member 
                mProductsList.Add(AProduct);
                //point at the next record
                Index++;
            }
        }
    }
}