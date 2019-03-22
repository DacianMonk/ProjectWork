using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstProducts
    {
        //test data 
        string ProductID = "10";
        string ProductName = "Super Smash Bros";
        string Price = "10.99";
        string Quantity = "10";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsProducts AProduct = new clsProducts();
            //test to see that it exists
            Assert.IsNotNull(AProduct);
        }

        [TestMethod]
        public void ProductIDOK()
        {
            //create an instance of the class we want to create 
            clsProducts AProduct = new clsProducts();
            //create some test data at assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AProduct.ProductID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AProduct.ProductID, TestData);
        }

        [TestMethod]
        public void ProductNameOK()
        {
            //create an instance of the class we want to create 
            clsProducts AProduct = new clsProducts();
            //create some test data at assign to the property
            string TestData = "Xbox ONE";
            //assign the data to the property
            AProduct.ProductName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AProduct.ProductName, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create 
            clsProducts AProduct = new clsProducts();
            //create some test data at assign to the property
            double TestData = 99.99;
            //assign the data to the property
            AProduct.Price = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AProduct.Price, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            //create an instance of the class we want to create 
            clsProducts AProduct = new clsProducts();
            //create some test data at assign to the property
            Int32 TestData = 10;
            //assign the data to the property
            AProduct.Quantity = Convert.ToInt32(TestData);
            //test to see that the two values are the same 
            Assert.AreEqual(AProduct.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsProducts AProduct = new clsProducts();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use woth the method
            Int32 ProductID = 10;
            //invoke the method 
            Found = AProduct.Find(ProductID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create 
            clsProducts AProduct = new clsProducts();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ProductID = 10;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the productID
            if (AProduct.ProductID != 10)
            {
                OK = false;
            }
            //test to seee that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want to create 
            clsProducts AProduct = new clsProducts();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ProductID = 10;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the productname
            if (AProduct.ProductName != "Super Smash Bros")
            {
                OK = false;
            }
            //test to seee that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create 
            clsProducts AProduct = new clsProducts();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ProductID = 10;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the price
            if (AProduct.Price != 10.99)
            {
                OK = false;
            }
            //test to seee that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create 
            clsProducts AProduct = new clsProducts();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ProductID = 10;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the quantity
            if (AProduct.Quantity != 5)
            {
                OK = false;
            }
            //test to seee that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error message 
            String Error = "";
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinMinusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error message 
            String Error = "";
            //create test data to pass to method 
            string ProductID = ""; //this will trigger error
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMin()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductID = "1"; //this is fine
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductID = "11"; //this is fine
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxMinusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductID = "11111"; //this is fine
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMax()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductID = "111111"; //this is fine
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMid()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductID = "111"; //this is fine
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxPlusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductID = "1111111"; //this will fail
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDExtremeMax()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductID = ""; //this will fail
            ProductID = ProductID.PadRight(500, '1'); 
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinMinusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductName = ""; //this will fail
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductName = "a"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductName = "aa"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxMinusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductName = ""; //this will pass
            ProductName = ProductName.PadRight(19, 'a');
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductName = ""; //this will pass
            ProductName = ProductName.PadRight(20, 'a');
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductName = ""; //this will fail
            ProductName = ProductName.PadRight(21, 'a');
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductName = ""; //this will pass
            ProductName = ProductName.PadRight(10, 'a');
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string ProductName = ""; //this will fail
            ProductName = ProductName.PadRight(500, '1');
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinMinusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Price = ""; //this will fail
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Price = "1"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Price = "11"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxMinusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Price = "1111"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Price = "11111"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Price = "111111"; //this will fail
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Price = "111"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Price = ""; //this will fail
            Price = Price.PadRight(500, '1');
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinMinusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Quantity = ""; //this will fail
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Quantity = "1"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Quantity = "11"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxMinusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Quantity = "1111"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Quantity = "11111"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Quantity = "111111"; //this will fail
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Quantity = "111"; //this will pass
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instace of the class
            clsProducts AProduct = new clsProducts();
            //string variable to store error 
            string Error = "";
            //create test data to pass to the method
            string Quantity = ""; //this will fail
            Quantity = Quantity.PadRight(500, '1');
            //invoke the method 
            Error = AProduct.Valid(ProductID, ProductName, Price, Quantity);
            //test if result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
