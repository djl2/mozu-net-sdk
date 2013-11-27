using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozu.Api.Contracts.ProductAdmin;
using Mozu.Api.Test.Helpers;
using Mozu.Api.Test.Factories;
using System.Configuration;
using Attribute = Mozu.Api.Contracts.ProductAdmin.Attribute;


namespace Mozu.Api.Test.MsTestCases
{
    [TestClass]
    public class ProductTests : MozuApiTestBase
    {

        #region NonTestCaseCode
        private static List<string> productCode1 = new List<string>();
        private static List<int> productTypeId1 = new List<int>();
        private static List<string> attributeFQN1 = new List<string>();

        public ProductTests()
        {

        }

        #region Initializers

        /// <summary>
        /// This will run once before each test.
        /// </summary>
        [TestInitialize]
        public void TestMethodInit()
        {
            tenantId = Convert.ToInt32(Mozu.Api.Test.Helpers.Environment.GetConfigValueByEnvironment("TenantId"));
            ApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage();
            TestBaseTenant = TenantFactory.GetTenant(handler: ApiMsgHandler,tenantId: tenantId);
            masterCatalogId = TestBaseTenant.MasterCatalogs.First().Id;
            catalogId = TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id;
            ApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage(tenantId, masterCatalogId:masterCatalogId, catalogId:catalogId);
            productCode1.Clear();
            productTypeId1.Clear();
            attributeFQN1.Clear();
        }

        /// <summary>
        /// Runs once before any test is run.
        /// </summary>
        /// <param name="testContext"></param>
        [ClassInitialize]
        public static void InitializeBeforeRun(TestContext testContext)
        {
            //Call the base class's static initializer.
            MozuApiTestBase.TestClassInitialize(testContext);
            // Populate Test Data.
            //Generator.PopulateProductsToCatalog(TestBaseTenant.Id, TestBaseTenant.MasterCatalogs.First().Id,
            //    TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id);
        }

        #endregion

        #region CleanupMethods

        /// <summary>
        /// This will run once after each test.
        /// </summary>
        [TestCleanup]
        public void TestMethodCleanup()
        {
            CleanUpData.CleanUpProducts(ApiMsgHandler, productCode1);
            CleanUpData.CleanUpProductTypes(ApiMsgHandler, productTypeId1);
            CleanUpData.CleanUpAttributes(ApiMsgHandler, attributeFQN1);
            //Calls the base class's Test Cleanup
            base.TestCleanup();
        }

        /// <summary>
        /// Runs once after all of the tests have run.
        /// </summary>
        [ClassCleanup]
        public static void TestsCleanup()
        {
            //Calls the Base class's static cleanup.
            MozuApiTestBase.TestClassCleanup();
        }

        #endregion

        #endregion

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("StartIndex, PageSize")]
        public void GetProductsTest1()
        {
            int pageSize = 5;
            int totalCount = 0;
            int startIndex = 0;
            int expectedTotalCount = 0;
            while (true)
            {
                var prods = ProductFactory.GetProducts(handler: ApiMsgHandler, startIndex: startIndex, pageSize: pageSize, filter:null,noCount:null,q:null,qLimit:null,sortBy:null);
                Assert.AreEqual(startIndex, prods.StartIndex);
                Assert.AreEqual((prods.TotalCount + prods.PageSize - 1) / prods.PageSize, prods.PageCount);
                totalCount += prods.Items.Count;
                startIndex += pageSize;
                if (prods.Items.Count < pageSize)
                {
                    expectedTotalCount = (int)prods.TotalCount;
                    break;
                }
            }
            Assert.AreEqual(expectedTotalCount, totalCount);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("sortBy")]
        public void GetProductsTest2()
        {
            var prods = ProductFactory.GetProducts(handler: ApiMsgHandler, filter: null, noCount: null, pageSize: null, qLimit: null,startIndex: null, q: null, sortBy: "ProductSequence asc");
            Assert.IsTrue(prods.Items.First().ProductSequence < prods.Items.Last().ProductSequence);

            prods = ProductFactory.GetProducts(handler: ApiMsgHandler, filter: null, noCount: null, pageSize: null, qLimit: null,startIndex: null, q: null,sortBy: "ProductSequence desc");
            Assert.IsTrue(prods.Items.First().ProductSequence > prods.Items.Last().ProductSequence);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("filter")]  //bug 18877
        public void GetProductsTest3()
        {
            var prods = ProductFactory.GetProducts(handler: ApiMsgHandler);
            var prods1 = ProductFactory.GetProducts(handler: ApiMsgHandler, noCount: null, pageSize: null, qLimit: null, startIndex: null, q: null, sortBy:null, filter: "ProductSequence eq " + prods.Items.First().ProductSequence.Value);
            Assert.AreEqual(1, prods1.TotalCount);
            var getProduct = ProductFactory.GetProduct(handler: ApiMsgHandler, productCode: prods.Items.First().ProductCode);
            Assert.AreEqual(prods.Items.First().ProductSequence, getProduct.ProductSequence);
        }


        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("q - sitegroup level : ProductCode and ProductName")]
        public void GetProductsTest6()
        {
            var messageHandler = ServiceClientMessageFactory.GetTestClientMessage(TestBaseTenant.Id, 
                                                                                  TestBaseTenant.MasterCatalogs.First().Id);
            var products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "grp*");
            Assert.AreEqual(2, products.TotalCount);
            products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "site*");
            Assert.AreEqual(4, products.TotalCount);

            messageHandler = ServiceClientMessageFactory.GetTestClientMessage(TestBaseTenant.Id, 
                                                                              TestBaseTenant.MasterCatalogs.Last().Id);
            var products1 = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "group*");
            Assert.AreEqual(2, products1.TotalCount);
            products1 = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "site-*");
            Assert.AreEqual(4, products.TotalCount);

            Assert.AreNotEqual(products.Items.First().ProductCode, products1.Items.First().ProductCode);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("q - multiple words")]
        public void GetProductsTest7()
        {
            var messageHandler = ServiceClientMessageFactory.GetTestClientMessage(TestBaseTenant.Id,
                                                                           TestBaseTenant.MasterCatalogs.First()
                                                                                   .Catalogs.First()
                                                                                   .Id);
            var products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "site " + TestBaseTenant.MasterCatalogs.First()
                                                                                               .Catalogs.First()
                                                                                               .Id);
            Assert.AreEqual(2, products.TotalCount);

            products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "site pro");
            Assert.AreEqual(2, products.TotalCount);

            products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "sit pr");
            Assert.AreEqual(0, products.TotalCount);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("q - word with *")]
        public void GetProductsTest8()
        {
            var messageHandler = ServiceClientMessageFactory.GetTestClientMessage(TestBaseTenant.Id,
                                                                           TestBaseTenant.MasterCatalogs.First()
                                                                                   .Catalogs.First()
                                                                                   .Id );
            var products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "grp* site*");
            Assert.AreEqual(0, products.TotalCount);

            products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "site* " + TestBaseTenant.MasterCatalogs.First()
                                                                                               .Catalogs.First()
                                                                                               .Id + "*");
            Assert.AreEqual(2, products.TotalCount);

            products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "site* pro*");
            Assert.AreEqual(2, products.TotalCount);

            products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "sit* pr*");
            Assert.AreEqual(2, products.TotalCount);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("qlimit")]
        public void GetProductsTest10()
        {
            var messageHandler = ServiceClientMessageFactory.GetTestClientMessage(TestBaseTenant.Id,
                                                                           TestBaseTenant.MasterCatalogs.First()
                                                                                   .Catalogs.First()
                                                                                   .Id);
            var products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "site* pro*");
            Assert.AreEqual(4, products.TotalCount);

            products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, startIndex: null, sortBy: null, q: "site* pro*", qLimit: 0);
            Assert.AreEqual(0, products.TotalCount);

            products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, startIndex: null, sortBy: null, q: "site* pro*", qLimit: 2);
            Assert.AreEqual(2, products.TotalCount);

            products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, startIndex: null, sortBy: null, q: "site* pro*", qLimit: 3);
            Assert.AreEqual(3, products.TotalCount);

            products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, startIndex: null, sortBy: null, q: "site* pro*", qLimit: 5, pageSize: 3);
            Assert.AreEqual(4, products.TotalCount);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description(".")]
        public void GetProductsTest11()
        {
            var messageHandler = ServiceClientMessageFactory.GetTestClientMessage(TestBaseTenant.Id, TestBaseTenant.MasterCatalogs.First()
                                                                                   .Catalogs.First()
                                                                                   .Id);
            var products = ProductFactory.GetProducts(handler: messageHandler, filter: null, noCount: null, pageSize: null, qLimit: null, startIndex: null, sortBy: null, q: "abc.xyz");
            Assert.AreEqual(2, products.TotalCount);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("positive")]
        public void GetProductTest1()
        {
            var prods = ProductFactory.GetProducts(ApiMsgHandler);
            var getCate = ProductFactory.GetProduct(handler: ApiMsgHandler,productCode: prods.Items.Last().ProductCode, expectedCode: (int)HttpStatusCode.OK, successCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(prods.Items.Last().ProductCode, getCate.ProductCode);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("not found")]
        public void GetProductTest2()
        {
            ProductFactory.GetProduct(handler: ApiMsgHandler,productCode: Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly), expectedCode: (int)HttpStatusCode.NotFound);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductTypeId, not found")]
        public void AddProductTest1()
        {
            var pts = ProductTypeFactory.GetProductTypes(handler: ApiMsgHandler, filter: null, pageSize: null,  startIndex: null, sortBy: "Id desc");
            var pro = Generator.GenerateProduct(pts.Items.First().Id.Value + 1);
            ProductFactory.AddProduct(handler: ApiMsgHandler,product: pro, expectedCode: (int)HttpStatusCode.BadRequest);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductTypeId, not found")]
        public void AddProductTest2()
        {
            var pts = ProductTypeFactory.GetProductTypes(handler: ApiMsgHandler, filter: null, pageSize: null, startIndex: null, sortBy: "Id desc");
            var pro = Generator.GenerateProduct(pts.Items.First().Id.Value + 1);
            ProductFactory.AddProduct(handler: ApiMsgHandler,product: pro, expectedCode: (int)HttpStatusCode.BadRequest);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("IsRequiredByAdmin is false, IsValidForProductType is true")]
        public void AddProductTest3()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr, name:
                                                       Generator.RandomString(5,Generator.RandomCharacterGroup.AlphaOnly));
            myPT.Properties.First().IsRequiredByAdmin = false;
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.IsTrue(createdProduct.IsValidForProductType.Value);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("IsRequiredByAdmin is true, IsValidForProductType is false")]
        public void AddProductTest4()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            myPT.Properties.First().IsRequiredByAdmin = true;
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            myProduct.Properties.Clear();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.IsFalse(createdProduct.IsValidForProductType.Value);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("HasConfigurableOptions is false")]
        public void AddProductTest5()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.IsFalse(createdProduct.HasConfigurableOptions);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("HasConfigurableOptions is true,  HasStandAloneOptions is false")]
        public void AddProductTest6()
        {
            var attrObj = Generator.GenerateAttribute(isOption: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.IsTrue(createdProduct.HasConfigurableOptions);
            Assert.IsFalse(createdProduct.HasStandAloneOptions);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("HasStandAloneOptions is true")]
        public void AddProductTest7()
        {
            var attrObj = Generator.GenerateAttribute(isExtra: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr, Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.IsTrue(createdProduct.HasStandAloneOptions);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Options, not existent value")]
        public void AddProductTest8()
        {
            var attrObj = Generator.GenerateAttribute(attributeCode: Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                                                              adminName: Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                                                                              isOption: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            myProduct.Options.First().Values.First().Value = Generator.RandomString(5,
                                                                                    Generator.RandomCharacterGroup
                                                                                             .AlphaOnly);
            ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.BadRequest);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Extras: IsRequired, IsMultiSelect")]
        public void AddProductTest9()
        {
            var attrObj = Generator.GenerateAttribute(isExtra: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            myProduct.Extras.First().IsMultiSelect = true;
            myProduct.Extras.First().IsRequired = true;
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.IsTrue(createdProduct.Extras.First().IsMultiSelect.Value);
            Assert.IsTrue(createdProduct.Extras.First().IsRequired.Value);
            myProduct.ProductCode = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly);
            myProduct.Extras.First().IsMultiSelect = false;
            myProduct.Extras.First().IsRequired = false;
            createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.IsFalse(createdProduct.Extras.First().IsMultiSelect.Value);
            Assert.IsFalse(createdProduct.Extras.First().IsRequired.Value);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductCode, UPC")]
        public void AddProductTest10()
        {
            var attrObj = Generator.GenerateAttribute(isExtra: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            myProduct.ProductCode = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly);
            myProduct.Upc = Generator.RandomUPC();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct, expectedCode: (int)HttpStatusCode.Created);  //bug 13127
            productCode1.Add(createdProduct.ProductCode);
            Assert.AreEqual(myProduct.ProductCode, createdProduct.ProductCode);
            Assert.AreEqual(myProduct.Upc, createdProduct.Upc);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Set true: IsBackOrderAllowed, IsHiddenWhenOutOfStock, IsRecurring, IsTaxable, ManageStock")]
        public void AddProductTest11()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            //            myProduct.IsBackOrderAllowed = true;
            //            myProduct.IsHiddenWhenOutOfStock = true;
            myProduct.IsRecurring = true;
            myProduct.IsTaxable = true;
            myProduct.InventoryInfo.ManageStock = true;
            myProduct.IsVariation = true;      //bug 11407
            myProduct.HasConfigurableOptions = true;
            myProduct.HasStandAloneOptions = true;
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            //            Assert.IsTrue(createdProduct.IsBackOrderAllowed.Value && createdProduct.IsHiddenWhenOutOfStock.Value &&
            //                createdProduct.IsRecurring.Value && createdProduct.IsTaxable.Value && createdProduct.ManageStock.Value);
            Assert.IsFalse(createdProduct.IsVariation);
            Assert.IsFalse(createdProduct.HasConfigurableOptions);
            Assert.IsFalse(createdProduct.HasStandAloneOptions);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Set false: IsBackOrderAllowed, IsHiddenWhenOutOfStock, IsRecurring, IsTaxable, ManageStock")]
        public void AddProductTest12()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            //            myProduct.IsBackOrderAllowed = false;
            //            myProduct.IsHiddenWhenOutOfStock = false;
            myProduct.IsRecurring = false;
            myProduct.IsTaxable = false;
            //            myProduct.ManageStock = false;
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            //            Assert.IsFalse(createdProduct.IsBackOrderAllowed.Value || createdProduct.IsHiddenWhenOutOfStock.Value ||
            //                createdProduct.IsRecurring.Value || createdProduct.IsTaxable.Value || createdProduct.ManageStock.Value);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductInCatalogs: IsContentOverridden, IsPriceOverridden, IsSeoContentOverridden  --false")]
        public void AddProductTest14()   //bug 18881
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            if (cates.TotalCount < 1)
                Assert.Inconclusive("no categories at first site");
            myProduct.ProductInCatalogs = new List<ProductInCatalogInfo>
                {
                    Generator.GenerateProductInCatalogInfo(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id,
                                                           cates.Items.First().Id, null, false, false, false)
                };
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.AreEqual(createdProduct.Content.ProductName, createdProduct.ProductInCatalogs.First().Content.ProductName);
            Assert.AreEqual(createdProduct.Price.Price, createdProduct.ProductInCatalogs.First().Price.Price);
            Assert.AreEqual(createdProduct.SeoContent.TitleTagTitle, createdProduct.ProductInCatalogs.First().SeoContent.TitleTagTitle);
            var messageHandler1 = ServiceClientMessageFactory.GetTestClientMessage(TestBaseTenant.Id, TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, TestBaseTenant.MasterCatalogs.First().Id);
            var info = ProductFactory.GetProductInCatalog(messageHandler1,productCode: createdProduct.ProductCode,catalogId:
                                         TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id);
            Assert.AreEqual(cates.Items.First().Id, info.ProductCategories[0].CategoryId);
            Assert.AreEqual(createdProduct.Content.ProductName, info.Content.ProductName);
            Assert.AreEqual(createdProduct.Price.Price, info.Price.Price);
            Assert.AreEqual(createdProduct.SeoContent.TitleTagTitle, info.SeoContent.TitleTagTitle);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Content")]
        public void AddProductTest15()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var imageList = new List<ProductLocalizedImage>();
            imageList.Add(Generator.GenerateProductLocalizedImage(Generator.RandomURL(), Generator.RandomURL()));

            myProduct.Content =
                Generator.GenerateProductLocalizedContent(
                    Generator.RandomString(6, Generator.RandomCharacterGroup.AlphaOnly), imageList);


            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.AreEqual(myProduct.Content.ProductName, createdProduct.Content.ProductName);
            Assert.AreEqual(myProduct.Content.ProductFullDescription, createdProduct.Content.ProductFullDescription);
            Assert.AreEqual(myProduct.Content.ProductShortDescription, createdProduct.Content.ProductShortDescription);
            Assert.AreEqual(myProduct.Content.ProductImages.First().AltText, createdProduct.Content.ProductImages.First().AltText);
            Assert.AreEqual(myProduct.Content.ProductImages.First().ImageLabel, createdProduct.Content.ProductImages.First().ImageLabel);
            Assert.AreEqual(myProduct.Content.ProductImages.First().ImagePath, createdProduct.Content.ProductImages.First().ImagePath);
            Assert.AreEqual(myProduct.Content.ProductImages.First().ImageUrl, createdProduct.Content.ProductImages.First().ImageUrl);
            Assert.AreEqual(myProduct.Content.ProductImages.First().VideoUrl, createdProduct.Content.ProductImages.First().VideoUrl);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Price")]
        public void AddProductTest16()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            myProduct.Price.Price = Generator.RandomDecimal(80, 100);
            myProduct.Price.SalePrice = Generator.RandomDecimal(60, 80);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.AreEqual(myProduct.Price.Price, createdProduct.Price.Price);
            Assert.AreEqual(myProduct.Price.SalePrice, createdProduct.Price.SalePrice);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("SeoContent")]
        public void AddProductTest17()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            myProduct.SeoContent = Generator.GenerateProductLocalizedSEOContent();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.AreEqual(myProduct.SeoContent.MetaTagDescription, createdProduct.SeoContent.MetaTagDescription);
            Assert.AreEqual(myProduct.SeoContent.MetaTagKeywords, createdProduct.SeoContent.MetaTagKeywords);
            Assert.AreEqual(myProduct.SeoContent.MetaTagTitle, createdProduct.SeoContent.MetaTagTitle);
            Assert.AreEqual(myProduct.SeoContent.SeoFriendlyUrl, createdProduct.SeoContent.SeoFriendlyUrl);
            Assert.AreEqual(myProduct.SeoContent.TitleTagTitle, createdProduct.SeoContent.TitleTagTitle);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Measurement")]
        public void AddProductTest18()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            myProduct.PackageHeight = Generator.GenerateMeasurement("in", Generator.RandomDecimal(10, 100));
            myProduct.PackageLength = Generator.GenerateMeasurement("in", Generator.RandomDecimal(10, 100));
            myProduct.PackageWidth = Generator.GenerateMeasurement("in", Generator.RandomDecimal(10, 100));
            myProduct.PackageWeight = Generator.GenerateMeasurement("lbs", Generator.RandomDecimal(10, 100));
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.AreEqual(myProduct.PackageHeight.Value, createdProduct.PackageHeight.Value);
            Assert.AreEqual(myProduct.PackageLength.Value, createdProduct.PackageLength.Value);
            Assert.AreEqual(myProduct.PackageWeight.Value, createdProduct.PackageWeight.Value);
            Assert.AreEqual(myProduct.PackageWidth.Value, createdProduct.PackageWidth.Value);
            Assert.AreEqual(myProduct.PackageHeight.Unit, createdProduct.PackageHeight.Unit);
            Assert.AreEqual(myProduct.PackageLength.Unit, createdProduct.PackageLength.Unit);
            Assert.AreEqual(myProduct.PackageWeight.Unit, createdProduct.PackageWeight.Unit);
            Assert.AreEqual(myProduct.PackageWidth.Unit, createdProduct.PackageWidth.Unit);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("StandAlonePackageType, IsPackagedStandAlone")]
        public void AddProductTest19()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            myProduct.IsPackagedStandAlone = true;
            myProduct.StandAlonePackageType = Generator.GenerateStandAlonePackageTypeConst();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.IsTrue(createdProduct.IsPackagedStandAlone.Value);
            Assert.AreEqual(myProduct.StandAlonePackageType, createdProduct.StandAlonePackageType);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("AuditInfo")]
        public void AddProductTest20()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            myProduct.AuditInfo = Generator.GenerateAuditInfoRandom();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.AreNotEqual(myProduct.AuditInfo.CreateBy, createdProduct.AuditInfo.CreateBy);
            Assert.AreNotEqual(((DateTime)myProduct.AuditInfo.CreateDate).Date, ((DateTime)createdProduct.AuditInfo.CreateDate).Date);
            Assert.AreNotEqual(myProduct.AuditInfo.UpdateBy, createdProduct.AuditInfo.UpdateBy);
            Assert.AreNotEqual(((DateTime)myProduct.AuditInfo.UpdateDate).Date, ((DateTime)createdProduct.AuditInfo.UpdateDate).Date);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductInCatalogs: IsContentOverridden, IsPriceOverridden, IsSeoContentOverridden  --true")]
        public void AddProductTest21()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            if (cates.TotalCount < 1)
                Assert.Inconclusive("no categories at first site");
            myProduct.ProductInCatalogs = new List<ProductInCatalogInfo>();
            myProduct.ProductInCatalogs.Add(Generator.GenerateProductInCatalogInfo(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cates.Items.First().Id, null, true, true, true));
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct, expectedCode: (int)HttpStatusCode.Created);
            productCode1.Add(createdProduct.ProductCode);
            Assert.AreNotEqual(createdProduct.Content.ProductName, createdProduct.ProductInCatalogs.First().Content.ProductName);
            Assert.AreNotEqual(createdProduct.Price.Price, createdProduct.ProductInCatalogs.First().Price.Price);
            Assert.AreNotEqual(createdProduct.SeoContent.TitleTagTitle, createdProduct.ProductInCatalogs.First().SeoContent.TitleTagTitle);
            var messageHandler1 = ServiceClientMessageFactory.GetTestClientMessage(TestBaseTenant.Id, TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, TestBaseTenant.MasterCatalogs.First().Id);
            var info = ProductFactory.GetProductInCatalog(handler: messageHandler1,productCode: createdProduct.ProductCode, catalogId:
                                         TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id);
            Assert.AreEqual(cates.Items.First().Id, info.ProductCategories[0].CategoryId);
            Assert.AreNotEqual(createdProduct.Content.ProductName, info.Content.ProductName);
            Assert.AreNotEqual(createdProduct.Price.Price, info.Price.Price);
            Assert.AreNotEqual(createdProduct.SeoContent.TitleTagTitle, info.SeoContent.TitleTagTitle);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("readonly: SiteGroupId, ProductSequence, ProductCode")]
        public void UpdateProductTest1()
        {
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: Generator.GenerateProduct());
            productCode1.Add(createdProduct.ProductCode);
            //var prods = ProductFactory.GetProducts(handler: ApiMsgHandler, sortBy: "ProductSequence desc");
            //if (prods.TotalCount == 0 || TestBaseTenant.MasterCatalogs.Count < 2)
            //    Assert.Inconclusive("no products");
            int originalSiteGroupId = createdProduct.MasterCatalogId.Value;
            int originalProductSequence = createdProduct.ProductSequence.Value;
            string originalProductCode = createdProduct.ProductCode;
            createdProduct.MasterCatalogId = TestBaseTenant.MasterCatalogs.Last().Id;
            createdProduct.ProductSequence = originalProductSequence + 1;
            createdProduct.ProductCode = Generator.RandomString(7, Generator.RandomCharacterGroup.AlphaOnly);
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler, product: createdProduct,productCode: originalProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(originalSiteGroupId, updateProd.MasterCatalogId);
            Assert.AreEqual(originalProductSequence, updateProd.ProductSequence);
            Assert.AreEqual(originalProductCode, updateProd.ProductCode);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductInCatalog : remove ")]
        public void UpdateProductTest2()
        {
            var myProduct = Generator.GenerateProduct();
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            if (cates.TotalCount < 1)
                Assert.Inconclusive("no categories at first site");
            myProduct.ProductInCatalogs = new List<ProductInCatalogInfo>();
            myProduct.ProductInCatalogs.Add(Generator.GenerateProductInCatalogInfo(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cates.Items.First().Id));
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            createdProduct.ProductInCatalogs.Clear();
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler,product: createdProduct,productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            var messageHandler1 = ServiceClientMessageFactory.GetTestClientMessage(TestBaseTenant.Id, TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, TestBaseTenant.MasterCatalogs.First().Id);
            ProductFactory.GetProductInCatalog(handler: messageHandler1, productCode: createdProduct.ProductCode, catalogId:
                                            TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.NotFound);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductInCatalog : add ")]
        public void UpdateProductTest3()
        {
            //var attrObj = Attributes.GenerateAttribute(isProperty: true);
            //var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            //var myPT = Product.GenerateProductType(createdAttr,
            //                                           Generator.RandomString(5,
            //                                                                  Generator.RandomCharacterGroup.AlphaOnly));
            //var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            //var myProduct = Product.GenerateProduct(createdPT);
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            Assert.AreEqual(0, createdProduct.ProductInCatalogs.Count);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            if (cates.TotalCount < 1)
                Assert.Inconclusive("no categories at first site");
            createdProduct.ProductInCatalogs = new List<ProductInCatalogInfo>();
            createdProduct.ProductInCatalogs.Add(Generator.GenerateProductInCatalogInfo(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cates.Items.First().Id));
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler,product: createdProduct,productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(1, updateProd.ProductInCatalogs.Count);
            Assert.AreEqual(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, updateProd.ProductInCatalogs[0].CatalogId);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("content")]
        public void UpdateProductTest4()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var imageList = new List<ProductLocalizedImage>();
            imageList.Add(Generator.GenerateProductLocalizedImage(Generator.RandomURL(), Generator.RandomURL()));
            createdProduct.Content =
                Generator.GenerateProductLocalizedContent(
                    Generator.RandomString(6, Generator.RandomCharacterGroup.AlphaOnly), imageList);
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler,product: createdProduct,productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(updateProd.Content.ProductName, createdProduct.Content.ProductName);
            Assert.AreEqual(updateProd.Content.ProductFullDescription, createdProduct.Content.ProductFullDescription);
            Assert.AreEqual(updateProd.Content.ProductShortDescription, createdProduct.Content.ProductShortDescription);
            Assert.AreEqual(updateProd.Content.ProductImages.First().AltText, createdProduct.Content.ProductImages.First().AltText);
            Assert.AreEqual(updateProd.Content.ProductImages.First().ImageLabel, createdProduct.Content.ProductImages.First().ImageLabel);
            Assert.AreEqual(updateProd.Content.ProductImages.First().ImagePath, createdProduct.Content.ProductImages.First().ImagePath);
            Assert.AreEqual(updateProd.Content.ProductImages.First().ImageUrl, createdProduct.Content.ProductImages.First().ImageUrl);
            Assert.AreEqual(updateProd.Content.ProductImages.First().VideoUrl, createdProduct.Content.ProductImages.First().VideoUrl);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("price")]
        public void UpdateProductTest5()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            createdProduct.Price.Price = Generator.RandomDecimal(80, 100);
            createdProduct.Price.SalePrice = Generator.RandomDecimal(60, 80);
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler,product: createdProduct,productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(updateProd.Price.Price, createdProduct.Price.Price);
            Assert.AreEqual(updateProd.Price.SalePrice, createdProduct.Price.SalePrice);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("SeoContent")]
        public void UpdateProductTest6()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            createdProduct.SeoContent = Generator.GenerateProductLocalizedSEOContent();
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler,product: createdProduct,productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(createdProduct.SeoContent.MetaTagDescription, createdProduct.SeoContent.MetaTagDescription);
            Assert.AreEqual(createdProduct.SeoContent.MetaTagKeywords, createdProduct.SeoContent.MetaTagKeywords);
            Assert.AreEqual(createdProduct.SeoContent.MetaTagTitle, createdProduct.SeoContent.MetaTagTitle);
            Assert.AreEqual(createdProduct.SeoContent.SeoFriendlyUrl, createdProduct.SeoContent.SeoFriendlyUrl);
            Assert.AreEqual(createdProduct.SeoContent.TitleTagTitle, createdProduct.SeoContent.TitleTagTitle);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("productTypeId, can not be updated")]
        public void UpdateProductTest7()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var firstPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var secondPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT1 = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: firstPT);
            productTypeId1.Add(createdPT1.Id.Value);
            var createdPT2 = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: secondPT);
            productTypeId1.Add(createdPT2.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT1);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            createdProduct.ProductTypeId = createdPT2.Id;
            ProductFactory.UpdateProduct(handler: ApiMsgHandler,product: createdProduct,productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.Conflict);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("IsValidForProductType, HasConfigurableOptions, HasStandAloneOptions   ----readonly")]
        public void UpdateProductTest8()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            bool original_IsValidForProductType = createdProduct.IsValidForProductType.Value;
            createdProduct.IsValidForProductType = !original_IsValidForProductType;
            bool original_HasConfigurableOptions = createdProduct.HasConfigurableOptions;
            createdProduct.HasConfigurableOptions = !original_HasConfigurableOptions;
            bool original_HasStandAloneOptions = createdProduct.HasStandAloneOptions;
            createdProduct.HasStandAloneOptions = !original_HasStandAloneOptions;
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler,product: createdProduct,productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(original_HasConfigurableOptions, updateProd.HasConfigurableOptions);
            Assert.AreEqual(original_HasStandAloneOptions, updateProd.HasStandAloneOptions);
            Assert.AreEqual(original_IsValidForProductType, updateProd.IsValidForProductType);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Options, IsValidForProductType false -> true")]
        public void UpdateProductTest9()
        {
            var attrObj = Generator.GenerateAttribute(attributeCode: Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                adminName: Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly), isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            myPT.Properties.First().IsRequiredByAdmin = true;
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);

            myProduct.Properties.Clear();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            Assert.IsFalse(createdProduct.IsValidForProductType.Value);

            if (createdProduct.Properties == null)
                createdProduct.Properties = new List<Mozu.Api.Contracts.ProductAdmin.ProductProperty>();

            createdProduct.Properties = Generator.GenerateProduct(createdPT).Properties;
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler,product: createdProduct,productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.IsTrue(updateProd.IsValidForProductType.Value);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Properties, values")]
        public void UpdateProductTest10()
        {
            var attrObj = Generator.GenerateAttribute(attributeCode: Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                adminName: Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly), isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler,attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            myPT.Properties.First().IsRequiredByAdmin = true;
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            if (myProduct.Properties.Last().Values.Count != 2)
                Assert.Inconclusive("The values count for the last property is not 2.");
            myProduct.Properties.Last().Values.Remove(myProduct.Properties.Last().Values.Last());
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            Assert.AreEqual(createdPT.Properties.Last().VocabularyValues.First().Value, createdProduct.Properties.First().Values.First().Value);
            createdProduct.Properties.First().Values.First().Value =
                createdPT.Properties.Last().VocabularyValues.Last().Value;
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler,product: createdProduct,productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(createdPT.Properties.Last().VocabularyValues.Last().Value, createdProduct.Properties.First().Values.First().Value);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("isTaxable, ManageStock, IsRecurring, IsBackOrderAllowed, IsHiddenWhenOutOfStock")]

        public void UpdateProductTest11()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler,product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            createdProduct.IsTaxable = Generator.RandomBool();
            //            createdProduct.ManageStock = Generator.RandomBool();
            createdProduct.IsRecurring = Generator.RandomBool();
            //            createdProduct.IsBackOrderAllowed = Generator.RandomBool();
            //            createdProduct.IsHiddenWhenOutOfStock = Generator.RandomBool();
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler,product: createdProduct,productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(updateProd.IsTaxable, createdProduct.IsTaxable);
            //            Assert.AreEqual(updateProd.ManageStock, productCode: createdProduct.ManageStock);
            Assert.AreEqual(updateProd.IsRecurring, createdProduct.IsRecurring);
            //            Assert.AreEqual(updateProd.IsBackOrderAllowed, productCode: createdProduct.IsBackOrderAllowed);
            //            Assert.AreEqual(updateProd.IsHiddenWhenOutOfStock, productCode: createdProduct.IsHiddenWhenOutOfStock);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("StandAlonePackageType, isPackedStandAlone")]
        public void UpdateProductTest13()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            //            var prods = ProductFactory.GetProducts(ApiMsgHandler);
            createdProduct.IsPackagedStandAlone = true;
            createdProduct.StandAlonePackageType = Generator.GenerateStandAlonePackageTypeConst();
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler, product: createdProduct, productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.IsTrue((bool)updateProd.IsPackagedStandAlone);
            Assert.AreEqual(createdProduct.StandAlonePackageType, updateProd.StandAlonePackageType);
            updateProd.IsPackagedStandAlone = false;
            var updateProd1 = ProductFactory.UpdateProduct(handler: ApiMsgHandler,product: updateProd, productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.IsFalse((bool)updateProd.IsPackagedStandAlone);
        }


        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Measurement")]
        public void UpdateProductTest14()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            //            var prods = ProductFactory.GetProducts(ApiMsgHandler);
            createdProduct.PackageHeight = Generator.GenerateMeasurement("in", Generator.RandomDecimal(10, 100));
            createdProduct.PackageLength = Generator.GenerateMeasurement("in", Generator.RandomDecimal(10, 100));
            createdProduct.PackageWidth = Generator.GenerateMeasurement("in", Generator.RandomDecimal(10, 100));
            createdProduct.PackageWeight = Generator.GenerateMeasurement("lbs", Generator.RandomDecimal(10, 100));
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler, product: createdProduct, productCode:
                                                              createdProduct.ProductCode,
                                                              expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(createdProduct.PackageWidth.Value, updateProd.PackageWidth.Value);
            Assert.AreEqual(createdProduct.PackageLength.Value, updateProd.PackageLength.Value);
            Assert.AreEqual(createdProduct.PackageHeight.Value, updateProd.PackageHeight.Value);
            Assert.AreEqual(createdProduct.PackageWeight.Value, updateProd.PackageWeight.Value);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("AuditInfo")]
        public void UpdateProductTest15()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            //            var prods = ProductFactory.GetProducts(ApiMsgHandler);
            createdProduct.AuditInfo = Generator.GenerateAuditInfoRandom();
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler, product: createdProduct, productCode:
                                                           createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreNotEqual(createdProduct.AuditInfo.CreateBy, updateProd.AuditInfo.CreateBy);
            Assert.AreNotEqual(createdProduct.AuditInfo.CreateDate, updateProd.AuditInfo.CreateDate);
            Assert.AreNotEqual(createdProduct.AuditInfo.UpdateBy, updateProd.AuditInfo.UpdateBy);
            Assert.AreNotEqual(createdProduct.AuditInfo.UpdateDate, updateProd.AuditInfo.UpdateDate);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductInCatalog, change siteId")]  //bug 18881
        public void UpdateProductTest16()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            myProduct.ProductInCatalogs = new List<ProductInCatalogInfo>();
            myProduct.ProductInCatalogs.Add(Generator.GenerateProductInCatalogInfo(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null));
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            createdProduct.ProductInCatalogs.First().CatalogId = TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id;
            var updateProd = ProductFactory.UpdateProduct(handler: ApiMsgHandler, product: createdProduct, productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(1, updateProd.ProductInCatalogs.Count);
            Assert.AreEqual(TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id, updateProd.ProductInCatalogs.First().CatalogId);
            ProductFactory.GetProductInCatalog(handler: ApiMsgHandler, productCode: createdProduct.ProductCode, catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id);
            ProductFactory.GetProductInCatalog(handler: ApiMsgHandler, productCode: createdProduct.ProductCode, catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.NotFound);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductInCatalog, change siteId, but not category")]
        public void UpdateProductTest17()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            myProduct.ProductInCatalogs = new List<ProductInCatalogInfo>
                {
                    Generator.GenerateProductInCatalogInfo(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cateId:
                                                           cates.Items.First().Id)
                };
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            createdProduct.ProductInCatalogs.First().CatalogId = TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id;
            ProductFactory.UpdateProduct(handler: ApiMsgHandler, product: createdProduct, productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.BadRequest);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("positive")]
        public void DeleteProductTest1()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            ProductFactory.DeleteProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.NoContent);
            ProductFactory.GetProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode,
                                      expectedCode: (int)HttpStatusCode.NotFound);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductInCatalogs not empty")]
        public void DeleteProductTest2()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            myProduct.ProductInCatalogs = new List<ProductInCatalogInfo>
                {
                    Generator.GenerateProductInCatalogInfo(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id,
                                                           cates.Items.First().Id)
                };
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            ProductFactory.DeleteProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.NoContent);
            ProductFactory.GetProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode,
                                      expectedCode: (int)HttpStatusCode.NotFound);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("delete and then add one with same product code")]
        public void DeleteProductTest3()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var count = ProductFactory.GetProducts(ApiMsgHandler).TotalCount;
            ProductFactory.DeleteProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.NoContent);
            var newCount = ProductFactory.GetProducts(ApiMsgHandler).TotalCount;
            Assert.AreEqual(count - 1, newCount);
            var newProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: createdProduct);
            newCount = ProductFactory.GetProducts(ApiMsgHandler).TotalCount;
            Assert.AreEqual(count, newCount);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("product already added")]
        public void AddProductInCatalogTest1()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var messageHandler = ServiceClientMessageFactory.GetTestClientMessage(TestBaseTenant.Id,
                                                                          TestBaseTenant.MasterCatalogs.First()
                                                                                  .Catalogs.First()
                                                                                  .Id,
                                                                      TestBaseTenant.MasterCatalogs.First().Id);
            var cates = CategoryFactory.GetCategories(messageHandler);
            myProduct.ProductInCatalogs = new List<ProductInCatalogInfo>
                {
                    Generator.GenerateProductInCatalogInfo(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id,
                                                           cates.Items.First().Id)
                };
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            ProductFactory.AddProductInCatalog(messageHandler, productInCatalogInfoIn:
                                            Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cates.Items.First().Id), productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.Conflict);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("IsContentOverridden, IsPriceOverridden, IsSeoContentOverridden  --false")]
        public void AddProductInCatalogTest2()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            ProductFactory.AddProductInCatalog(ApiMsgHandler, productInCatalogInfoIn:
                                            Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cates.Items.First().Id, null, false, false, false), productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.Created);
            var getProduct = ProductFactory.GetProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode);
            Assert.AreEqual(getProduct.Content.ProductName, getProduct.ProductInCatalogs.First().Content.ProductName);
            Assert.AreEqual(getProduct.Content.ProductFullDescription, getProduct.ProductInCatalogs.First().Content.ProductFullDescription);
            Assert.AreEqual(getProduct.Content.ProductImages, getProduct.ProductInCatalogs.First().Content.ProductImages);
            Assert.AreEqual(getProduct.Content.ProductShortDescription, getProduct.ProductInCatalogs.First().Content.ProductShortDescription);

            Assert.AreEqual(getProduct.Price.Price, getProduct.ProductInCatalogs.First().Price.Price);
            Assert.AreEqual(getProduct.Price.SalePrice, getProduct.ProductInCatalogs.First().Price.SalePrice);

            Assert.AreEqual(getProduct.SeoContent.MetaTagDescription, getProduct.ProductInCatalogs.First().SeoContent.MetaTagDescription);
            Assert.AreEqual(getProduct.SeoContent.MetaTagKeywords, getProduct.ProductInCatalogs.First().SeoContent.MetaTagKeywords);
            Assert.AreEqual(getProduct.SeoContent.MetaTagTitle, getProduct.ProductInCatalogs.First().SeoContent.MetaTagTitle);
            Assert.AreEqual(getProduct.SeoContent.SeoFriendlyUrl, getProduct.ProductInCatalogs.First().SeoContent.SeoFriendlyUrl);
            Assert.AreEqual(getProduct.SeoContent.TitleTagTitle, getProduct.ProductInCatalogs.First().SeoContent.TitleTagTitle);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("IsContentOverridden, IsPriceOverridden, IsSeoContentOverridden  --true")]
        public void AddProductInCatalogTest3()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            ProductFactory.AddProductInCatalog(ApiMsgHandler, productInCatalogInfoIn:
                                            Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cates.Items.First().Id, null, true, true, true), productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.Created);
            var getProduct = ProductFactory.GetProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode);
            Assert.AreNotEqual(getProduct.Content.ProductName, getProduct.ProductInCatalogs.First().Content.ProductName);
            Assert.AreNotEqual(getProduct.Content.ProductFullDescription, getProduct.ProductInCatalogs.First().Content.ProductFullDescription);
            Assert.AreNotEqual(getProduct.Content.ProductShortDescription, getProduct.ProductInCatalogs.First().Content.ProductShortDescription);

            Assert.AreNotEqual(getProduct.Price.Price, getProduct.ProductInCatalogs.First().Price.Price);

            Assert.AreNotEqual(getProduct.SeoContent.MetaTagDescription, getProduct.ProductInCatalogs.First().SeoContent.MetaTagDescription);
            Assert.AreNotEqual(getProduct.SeoContent.MetaTagKeywords, getProduct.ProductInCatalogs.First().SeoContent.MetaTagKeywords);
            Assert.AreNotEqual(getProduct.SeoContent.MetaTagTitle, getProduct.ProductInCatalogs.First().SeoContent.MetaTagTitle);
            Assert.AreNotEqual(getProduct.SeoContent.SeoFriendlyUrl, getProduct.ProductInCatalogs.First().SeoContent.SeoFriendlyUrl);
            Assert.AreNotEqual(getProduct.SeoContent.TitleTagTitle, getProduct.ProductInCatalogs.First().SeoContent.TitleTagTitle);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("two categories")]
        public void AddProductInCatalogTest4()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr, name: Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var messageHandler = ServiceClientMessageFactory.GetTestClientMessage(TestBaseTenant.Id,
                                                                          TestBaseTenant.MasterCatalogs.First()
                                                                                  .Catalogs.First()
                                                                                  .Id);
            var cates = CategoryFactory.GetCategories(messageHandler);
            if (cates.TotalCount < 2)
            {
                Assert.Inconclusive("Less than 2 categories.");
            }
            var catIdList = new List<int>() { (int)cates.Items.First().Id, (int)cates.Items.Last().Id };
            var pcs = Generator.GenerateProductCategoryList(catIdList);

            ProductFactory.AddProductInCatalog(messageHandler, productInCatalogInfoIn:
                                            Generator.GenerateProductInCatalogInfo(
                                            TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, pcs,
                                            Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                                            Generator.RandomDecimal(10, 100), null, null, null, null), 
                                            productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.Created);
            var getProduct = ProductFactory.GetProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode);
            Assert.AreEqual(2, getProduct.ProductInCatalogs.First().ProductCategories.Count());
            Assert.AreEqual(cates.Items.First().Id, getProduct.ProductInCatalogs.First().ProductCategories.First().CategoryId);
            Assert.AreEqual(cates.Items.Last().Id, getProduct.ProductInCatalogs.First().ProductCategories.Last().CategoryId);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("positive")]
        public void GetProductInCatalogTest1()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            var info = Generator.GenerateProductInCatalogInfo(
                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cates.Items.First().Id, true);
            ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: info, productCode: createdProduct.ProductCode);
            var getInfo = ProductFactory.GetProductInCatalog(handler: ApiMsgHandler, productCode: createdProduct.ProductCode, catalogId:
                                                                      TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(info.IsActive, getInfo.IsActive);
            Assert.AreEqual(info.Price.Price, getInfo.Price.Price);
            Assert.AreEqual(info.ProductCategories.First().CategoryId, getInfo.ProductCategories.First().CategoryId);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("not found product code")]
        public void GetProductInCatalogTest2()
        {
            var getInfo = ProductFactory.GetProductInCatalog(handler: ApiMsgHandler,productCode: Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly), catalogId:
                                                                      TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.NotFound);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("not found in the site")]
        public void GetProductInCatalogTest3()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            var info = Generator.GenerateProductInCatalogInfo(
                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cates.Items.First().Id, true);
            ProductFactory.AddProductInCatalog(handler: ApiMsgHandler, productInCatalogInfoIn: info, productCode: createdProduct.ProductCode);
            if (TestBaseTenant.MasterCatalogs.First().Catalogs.Count < 2)
                Assert.Inconclusive("Less than two sites in first site group.");
            var getInfo = ProductFactory.GetProductInCatalog(handler: ApiMsgHandler, productCode: createdProduct.ProductCode, catalogId:
                                                                      TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id, expectedCode: (int)HttpStatusCode.NotFound);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("not found product code")]
        public void GetProductInCatalogsTest1()
        {
            ProductFactory.GetProductInCatalogs(handler: ApiMsgHandler,productCode: Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly), expectedCode: (int)HttpStatusCode.NotFound);
        }


        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("positive")]
        public void GetProductInCatalogsTest2()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cates.Items.First().Id), productCode: createdProduct.ProductCode);
            var getInfo = ProductFactory.GetProductInCatalogs(handler: ApiMsgHandler, productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(1, getInfo.Count);
            Assert.AreEqual(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, getInfo.First().CatalogId);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("two sites")]
        public void GetProductInCatalogsTest3()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, true, true, true, true), productCode: createdProduct.ProductCode);
            ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                 TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id, null, false, false, false, false), productCode: createdProduct.ProductCode);
            var getInfo = ProductFactory.GetProductInCatalogs(handler: ApiMsgHandler, productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(2, getInfo.Count);
            Assert.AreNotEqual(getInfo.First().CatalogId, getInfo.Last().CatalogId);
            Assert.AreNotEqual(getInfo.First().Price.Price, getInfo.Last().Price.Price);
            Assert.AreNotEqual(getInfo.First().IsActive, getInfo.Last().IsActive);
            Assert.AreNotEqual(getInfo.First().Content.ProductName, getInfo.Last().Content.ProductName);
            Assert.AreNotEqual(getInfo.First().SeoContent.TitleTagTitle, getInfo.Last().SeoContent.TitleTagTitle);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Auditinfo")]
        public void UpdateProductInCatalogTest1()
        {
            var attrObj = Generator.GenerateAttribute(isProperty: true);
            var createdAttr = AttributeFactory.AddAttribute(handler: ApiMsgHandler, attribute: attrObj);
            attributeFQN1.Add(createdAttr.AttributeFQN);
            var myPT = Generator.GenerateProductType(createdAttr,
                                                       Generator.RandomString(5,
                                                                              Generator.RandomCharacterGroup.AlphaOnly));
            var createdPT = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: myPT);
            productTypeId1.Add(createdPT.Id.Value);
            var myProduct = Generator.GenerateProduct(createdPT);
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var info = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, true, true, true, true), productCode: createdProduct.ProductCode);
            info.AuditInfo = Generator.GenerateAuditInfoRandom();
            var updateInfo = ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: info, productCode:
                                                                              createdProduct.ProductCode, catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreNotEqual(info.AuditInfo.CreateBy, updateInfo.AuditInfo.CreateBy);
            Assert.AreNotEqual(((DateTime)info.AuditInfo.CreateDate).Date, ((DateTime)updateInfo.AuditInfo.CreateDate).Date);
            Assert.AreNotEqual(info.AuditInfo.UpdateBy, updateInfo.AuditInfo.UpdateBy);
            Assert.AreNotEqual(((DateTime)info.AuditInfo.UpdateDate).Date, ((DateTime)updateInfo.AuditInfo.UpdateDate).Date);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Content, IsContentOverridden = true")]
        public void UpdateProductInCatalogTest2()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var info = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            info.Content =
                Generator.GenerateProductLocalizedContent(Generator.RandomString(5,
                                                                                   Generator.RandomCharacterGroup
                                                                                            .AlphaOnly));
            info.IsContentOverridden = true;
            var updateInfo = ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler, productInCatalogInfoIn: info, productCode:
                                                                              createdProduct.ProductCode, catalogId:
                                                                              TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(updateInfo.Content.ProductName, info.Content.ProductName);
            Assert.AreEqual(updateInfo.Content.ProductFullDescription, info.Content.ProductFullDescription);
            Assert.AreEqual(updateInfo.Content.ProductShortDescription, info.Content.ProductShortDescription);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Content, IsContentOverridden = false")]
        public void UpdateProductInCatalogTest3()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var info = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            info.Content =
                Generator.GenerateProductLocalizedContent(Generator.RandomString(5,
                                                                                   Generator.RandomCharacterGroup
                                                                                            .AlphaOnly));
            info.IsContentOverridden = false;
            var updateInfo = ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler, productInCatalogInfoIn: info, productCode: createdProduct.ProductCode, 
                catalogId:TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(updateInfo.Content.ProductName, createdProduct.Content.ProductName);
            Assert.AreEqual(updateInfo.Content.ProductFullDescription, createdProduct.Content.ProductFullDescription);
            Assert.AreEqual(updateInfo.Content.ProductShortDescription, createdProduct.Content.ProductShortDescription);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Price, IsPriceOverridden = true")]
        public void UpdateProductInCatalogTest4()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var info = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler, productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            info.Price.Price = Generator.RandomDecimal(50, 70);
            info.Price.SalePrice = Generator.RandomDecimal(30, 50);
            info.IsPriceOverridden = true;
            var updateInfo = ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: info, productCode:createdProduct.ProductCode,
                  catalogId:  TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(updateInfo.Price.Price, info.Price.Price);
            Assert.AreEqual(updateInfo.Price.SalePrice, info.Price.SalePrice);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Price, IsPriceOverridden = false")]
        public void UpdateProductInCatalogTest5()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var info = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler, productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            info.Price.Price = Generator.RandomDecimal(50, 70);
            info.Price.SalePrice = Generator.RandomDecimal(30, 50);
            info.IsPriceOverridden = false;
            var updateInfo = ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: info, productCode: createdProduct.ProductCode,
                                                                          catalogId:    TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(updateInfo.Price.Price, createdProduct.Price.Price);
            Assert.AreEqual(updateInfo.Price.SalePrice, createdProduct.Price.SalePrice);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("SeoContent, IsSeoContentOverridden = true")]
        public void UpdateProductInCatalogTest6()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var info = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            info.SeoContent = Generator.GenerateProductLocalizedSEOContent();
            info.IsseoContentOverridden = true;
            var updateInfo = ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: info, productCode:createdProduct.ProductCode,
                                                                     catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(updateInfo.SeoContent.MetaTagDescription, info.SeoContent.MetaTagDescription);
            Assert.AreEqual(updateInfo.SeoContent.MetaTagKeywords, info.SeoContent.MetaTagKeywords);
            Assert.AreEqual(updateInfo.SeoContent.MetaTagTitle, info.SeoContent.MetaTagTitle);
            Assert.AreEqual(updateInfo.SeoContent.SeoFriendlyUrl, info.SeoContent.SeoFriendlyUrl);
            Assert.AreEqual(updateInfo.SeoContent.TitleTagTitle, info.SeoContent.TitleTagTitle);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("SeoContent, IsSeoContentOverridden = false")]
        public void UpdateProductInCatalogTest7()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var info = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler, productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            info.SeoContent = Generator.GenerateProductLocalizedSEOContent();
            info.IsseoContentOverridden = false;
            var updateInfo = ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: info, productCode: createdProduct.ProductCode,
                                                             catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(updateInfo.SeoContent.MetaTagDescription, createdProduct.SeoContent.MetaTagDescription);
            Assert.AreEqual(updateInfo.SeoContent.MetaTagKeywords, createdProduct.SeoContent.MetaTagKeywords);
            Assert.AreEqual(updateInfo.SeoContent.MetaTagTitle, createdProduct.SeoContent.MetaTagTitle);
            Assert.AreEqual(updateInfo.SeoContent.SeoFriendlyUrl, createdProduct.SeoContent.SeoFriendlyUrl);
            Assert.AreEqual(updateInfo.SeoContent.TitleTagTitle, createdProduct.SeoContent.TitleTagTitle);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("isActive")]
        public void UpdateProductInCatalogTest8()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var info = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            info.IsActive = Generator.RandomBool();
            var updateInfo = ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler, productInCatalogInfoIn: info, productCode: createdProduct.ProductCode,
                             catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(updateInfo.IsActive, info.IsActive);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductCategories, add a category")]
        public void UpdateProductInCatalogTest10()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            var info = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cates.Items.First().Id, null, null, null, null), productCode: createdProduct.ProductCode);
            var catIds = new List<int>() { (int)cates.Items.First().Id, (int)cates.Items.Last().Id };
            info.ProductCategories = Generator.GenerateProductCategoryList(cateIds: catIds);

            //info.ProductCategories = Product.GenerateProductCategory(2);// new ProductCategory[2];
            info.ProductCategories[0] = Generator.GenerateProductCategory((int)cates.Items.First().Id);
            info.ProductCategories[1] = Generator.GenerateProductCategory((int)cates.Items.Last().Id);
            var updateInfo = ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: info,productCode: createdProduct.ProductCode,
                                                    catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(2, updateInfo.ProductCategories.Count());
            Assert.AreEqual(cates.Items.First().Id, updateInfo.ProductCategories.First().CategoryId);
            Assert.AreEqual(cates.Items.Last().Id, updateInfo.ProductCategories.Last().CategoryId);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("ProductCategories, change to another category")]
        public void UpdateProductInCatalogTest11()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var cates = CategoryFactory.GetCategories(ApiMsgHandler);
            var info = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, cates.Items.First().Id, null, null, null, null), productCode: createdProduct.ProductCode);
            info.ProductCategories[0] = Generator.GenerateProductCategory((int)cates.Items.Last().Id);
            var updateInfo = ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: info, productCode: createdProduct.ProductCode,
                                         catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(1, updateInfo.ProductCategories.Count());
            Assert.AreEqual(cates.Items.Last().Id, updateInfo.ProductCategories.Last().CategoryId);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("SiteId -- readonly")]
        public void UpdateProductInCatalogTest12()
        {
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var info = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler, productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            info.CatalogId = TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id;
            var updateInfo = ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: info, productCode:createdProduct.ProductCode,
                                                                  catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, updateInfo.CatalogId);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("two sites -> one site")]
        public void UpdateProductInCatalogsTest1()
        {
            if (TestBaseTenant.MasterCatalogs.First().Catalogs.Count < 2)
            {
                Assert.Inconclusive("Less than 2 sites in first sitegroup");
            }
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var info1 = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            var info2 = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            var infos = new List<ProductInCatalogInfo>();
            infos.Add(info1);
            var getInfos = ProductFactory.UpdateProductInCatalogs(handler: ApiMsgHandler,productInCatalogsIn: infos, productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(1, getInfos.Count);
            var getProduct = ProductFactory.GetProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode);
            Assert.AreEqual(1, getProduct.ProductInCatalogs.Count);
            Assert.AreEqual(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, getProduct.ProductInCatalogs.First().CatalogId);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("one site -> two sites")]
        public void UpdateProductInCatalogsTest2()
        {
            if (TestBaseTenant.MasterCatalogs.First().Catalogs.Count < 2)
            {
                Assert.Inconclusive("Less than 2 sites in first sitegroup");
            }
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            var info1 = ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            var info2 = Generator.GenerateProductInCatalogInfo(TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id, null, null, null, null, null);
            var infos = new List<ProductInCatalogInfo>();
            infos.Add(info1);
            infos.Add(info2);
            var getInfos = ProductFactory.UpdateProductInCatalogs(handler: ApiMsgHandler,productInCatalogsIn: infos, productCode: createdProduct.ProductCode, expectedCode: (int)HttpStatusCode.OK);
            Assert.AreEqual(2, getInfos.Count);
            var getProduct = ProductFactory.GetProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode);
            Assert.AreEqual(2, getProduct.ProductInCatalogs.Count);
            Assert.AreEqual(TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, getProduct.ProductInCatalogs.First().CatalogId);
            Assert.AreEqual(TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id, getProduct.ProductInCatalogs.Last().CatalogId);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("SiteId is wrong")]
        public void DeleteProductInCatalog1()
        {
            if (TestBaseTenant.MasterCatalogs.First().Catalogs.Count < 2)
            {
                Assert.Inconclusive("Less than 2 sites in first sitegroup");
            }
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            ProductFactory.AddProductInCatalog(handler: ApiMsgHandler, productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            ProductFactory.DeleteProductInCatalog(handler: ApiMsgHandler, productCode: createdProduct.ProductCode, catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id, expectedCode: (int)HttpStatusCode.NotFound);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("two sites -> one -> none")]
        public void DeleteProductInCatalog2()
        {
            if (TestBaseTenant.MasterCatalogs.First().Catalogs.Count < 2)
            {
                Assert.Inconclusive("Less than 2 sites in first sitegroup");
            }
            var myProduct = Generator.GenerateProduct();
            var createdProduct = ProductFactory.AddProduct(handler: ApiMsgHandler, product: myProduct);
            productCode1.Add(createdProduct.ProductCode);
            ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: Generator.GenerateProductInCatalogInfo(
                                                TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id, null, null, null, null, null), productCode: createdProduct.ProductCode);
            ProductFactory.DeleteProductInCatalog(handler: ApiMsgHandler, productCode: createdProduct.ProductCode,catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id, expectedCode: (int)HttpStatusCode.NoContent); //bug 11401
            var pt = ProductFactory.GetProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode);
            Assert.AreEqual(1, pt.ProductInCatalogs.Count);
            Assert.AreEqual(TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id, pt.ProductInCatalogs.First().CatalogId);
            ProductFactory.DeleteProductInCatalog(handler: ApiMsgHandler, productCode: createdProduct.ProductCode,catalogId: TestBaseTenant.MasterCatalogs.First().Catalogs.Last().Id, expectedCode: (int)HttpStatusCode.NoContent);
            pt = ProductFactory.GetProduct(handler: ApiMsgHandler, productCode: createdProduct.ProductCode);
            Assert.AreEqual(0, pt.ProductInCatalogs.Count);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Add two vocabulary values")]
        public void AddOptionTest1()
        {
            var colorAttr = Generator.CreateOptionAttribute(handler: ApiMsgHandler,attributeName: "Color", values: new List<string>() { "Red", "Blue", "Green" });

            attributeFQN1.Add(colorAttr.AttributeFQN);
            var sizeAttr = Generator.CreateOptionAttribute(handler: ApiMsgHandler, attributeName: "Size",values: new List<string>() { "Small", "Medium", "Large" });
            attributeFQN1.Add(sizeAttr.AttributeFQN);
            var attList = new List<Attribute>();
            attList.Add(colorAttr);
            attList.Add(sizeAttr);
            var shirtTypeObj = Generator.GenerateProductType(attList, "Shirt");
            var shirtType = ProductTypeFactory.AddProductType(handler: ApiMsgHandler,productType: shirtTypeObj);
            productTypeId1.Add(shirtType.Id.Value);
            var pro = Generator.GenerateProduct(shirtType.Id);
            var createdPro = ProductFactory.AddProduct(handler: ApiMsgHandler,product: pro);
            productCode1.Add(createdPro.ProductCode);
            var option = Generator.GenerateProductOption(shirtType.Options.First(), 2);
            ProductOptionFactory.AddOption(handler: ApiMsgHandler,productOption: option,productCode: pro.ProductCode);
        }
    }
}
