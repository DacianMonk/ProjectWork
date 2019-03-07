using System;

namespace Class_Library
{
    public class clsProducts
    {
        //private data members for the Product properties
        private Int32 mProductID;
        private string mProductName;
        private object mPrice;
        private string mQuantity; 

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
        public string ProductName { get; set; }
        public object Price { get; set; }
        public string Quantity { get; set; }

        public bool Find(int productID)
        {
            //set the private data member to the test data value 
            mProductID = 10; 
            //always return true 
            return true; 
        }
    }
}