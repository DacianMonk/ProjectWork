using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic; 

namespace Test_Framework
{
    [TestClass]
    public class tstProductsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsProductsCollection AllProducts = new clsProductsCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProducts); 
        }

        [TestMethod]
        public void ProductsListOK()
        {
            //create an insta ce of the class 
            clsProductsCollection AllProducts = new clsProductsCollection();
            //create some test data to assign to the property
            List<clsProducts> TestList = new List<clsProducts>();
            //create the item of test data
            clsProducts TestItem = new clsProducts();
            //set its properties 
            TestItem.ProductID = 1;
            TestItem.ProductName = "Pokemon";
            TestItem.Price = 15.00;
            TestItem.Quantity = 14;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to tje property
            AllProducts.ProductsList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductsList, TestList); 
        }

        [TestMethod]
        public void ThisProductOK()
        {
            //create an insta ce of the class 
            clsProductsCollection AllProducts = new clsProductsCollection();
            //create the item of test data
            clsProducts TestProduct = new clsProducts();
            //set its properties 
            TestProduct.ProductID = 1;
            TestProduct.ProductName = "Pokemon";
            TestProduct.Price = 15.00;
            TestProduct.Quantity = 14;
            //assign the data to tje property
            AllProducts.ThisProduct = TestProduct;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an insta ce of the class 
            clsProductsCollection AllProducts = new clsProductsCollection();
            //create some test data to assign to the property
            List<clsProducts> TestList = new List<clsProducts>();
            //create the item of test data
            clsProducts TestItem = new clsProducts();
            //set its properties 
            TestItem.ProductID = 1;
            TestItem.ProductName = "Pokemon";
            TestItem.Price = 15.00;
            TestItem.Quantity = 14;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to tje property
            AllProducts.ProductsList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsProductsCollection AllProducts = new clsProductsCollection();
            //create the item of test data
            clsProducts TestItem = new clsProducts();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 11;
            TestItem.ProductName = "Batman";
            TestItem.Price = 15.00;
            TestItem.Quantity = 13;
            //set ThisProduct to test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem); 
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsProductsCollection AllProducts = new clsProductsCollection();
            //create the item of test data
            clsProducts TestItem = new clsProducts();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 1;
            TestItem.ProductName = "Pokemon";
            TestItem.Price = 15.00;
            TestItem.Quantity = 14;
            //set ThisProduct to test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //delete the record 
            AllProducts.Delete();
            //noe find the record 
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey); 
            //test to see that the value was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsProductsCollection AllProducts = new clsProductsCollection();
            //create the item of test data
            clsProducts TestItem = new clsProducts();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 12;
            TestItem.ProductName = "game";
            TestItem.Price = 12.00;
            TestItem.Quantity = 4;
            //set ThisProduct to test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //set its new properties
            TestItem.ProductID = 13;
            TestItem.ProductName = "game 2";
            TestItem.Price = 11.00;
            TestItem.Quantity = 7;
            //set the record based on the new test data 
            AllProducts.ThisProduct = TestItem;
            //update the record
            AllProducts.Update(); 
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsProductsCollection AllProducts = new clsProductsCollection();
            //create an instance of the filtered data
            clsProductsCollection FilteredProducts = new clsProductsCollection();
            //apply blank string
            FilteredProducts.ReportByProductName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count); 
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            //create an instance of the filtered data
            clsProductsCollection FilteredProducts = new clsProductsCollection();
            //apply a product name that doesn't exist 
            FilteredProducts.ReportByProductName("xxxxxxxxxxxxxxxxxxxx");
            //test to see that there are no records 
            Assert.AreEqual(0, FilteredProducts.Count); 
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            //create an instance of the filtered data
            clsProductsCollection FilteredProducts = new clsProductsCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a product name that doesn't exist 
            FilteredProducts.ReportByProductName("game");
            //check that the corrent number of records are found
            if (FilteredProducts.Count == 2)
            {
                //check that the first record is 12
                if (FilteredProducts.ProductsList[0].ProductID != 12)
                {
                    OK = false; 
                }
                //check that the second record is 13
                if (FilteredProducts.ProductsList[1].ProductID != 13)
                {
                    OK = false; 
                }
            }
            else
            {
                OK = false; 
            }
            //test to see that there are no records 
            Assert.IsTrue(OK); 
        }
    }
}
