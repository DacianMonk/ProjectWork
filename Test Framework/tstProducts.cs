using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstProducts
    {
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
            string TestData = "10";
            //assign the data to the property
            AProduct.Quantity = TestData;
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
            Int32 ProductID = 1;
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
    }
}
