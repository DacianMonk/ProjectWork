using System;

namespace Class_Library
{
    public class clsProducts
    {
        //private data members for the Product properties
        private Int32 mProductID;
        private string mProductName;
        private double mPrice;
        private Int32 mQuantity; 

        //public property for the productID
        public int ProductID
        {
            get
            {
                //reutrn the private data 
                return mProductID; 
            }
            set
            {
                //set the value of the private data member 
                mProductID = value; 
            }
        }

        //public property for the productName
        public string ProductName
        {
            get
            {
                //reutrn the private data 
                return mProductName;
            }
            set
            {
                //set the value of the private data member 
                mProductName = value;
            }
        }

        //public property for the price
        public double Price
        {
            get
            {
                //reutrn the private data 
                return mPrice;
            }
            set
            {
                //set the value of the private data member 
                mPrice = value;
            }
        }

        //public property for the quantity
        public Int32 Quantity
        {
            get
            {
                //reutrn the private data 
                return mQuantity;
            }
            set
            {
                //set the value of the private data member 
                mQuantity = value;
            }
        }

        public bool Find(int productID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the productid to search for
            DB.AddParameter("@ProductID", productID);
            //execute the stored procedure 
            DB.Execute("sproc_tblProduct_FilterByProductID"); 
            //if one record is found (should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                //return that everything worked ok
                return true; 
            }
            //if no reocrd was found
            else
            {
                //return false indicating a problem 
                return false; 
            }
        }

        public string Valid(string productID, string productName, string price, string quantity)
        {
            //create a string variable to store the error
            String Error = ""; 
            //if the productid is blank
            if (productID.Length == 0)
            {
                //record the error
                Error = Error + "The Product ID should not be blank : "; 
            }
            //if the number is bigger than 6 characters 
            if(productID.Length > 6)
            {
                //record the error 
                Error = Error + "The Product ID must be less than 6 characters : "; 
            }
            //if productname is blank 
            if(productName.Length == 0)
            {
                //record the error 
                Error = Error + "The Product Name should not be blank : ";
            }
            //if the number is bigger than 20 characters 
            if (productName.Length > 20)
            {
                //record the error 
                Error = Error + "The Product Name must be less than 20 characters : ";
            }
            //if price is blank 
            if (price.Length == 0)
            {
                //record the error 
                Error = Error + "The Price should not be blank : ";
            }
            //if the number is bigger than 5 characters 
            if (price.Length > 5)
            {
                //record the error 
                Error = Error + "The Price must be less than 5 characters : ";
            }
            //if quantity is blank 
            if (quantity.Length == 0)
            {
                //record the error 
                Error = Error + "The quantity should not be blank : ";
            }
            //if the number is bigger than 5 characters 
            if (quantity.Length > 5)
            {
                //record the error 
                Error = Error + "The quantity must be less than 5 characters : ";
            }
            //return any error message 
            return Error; 
        }
    }
}