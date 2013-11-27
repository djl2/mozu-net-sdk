using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozu.Api.Contracts.CommerceRuntime.Fulfillment;
using Mozu.Api.Contracts.CommerceRuntime.Orders;
using Mozu.Api.Contracts.CommerceRuntime.Payments;
using Mozu.Api.Contracts.CommerceRuntime.Products;
using Mozu.Api.Test.Helpers;
using Mozu.Api.Contracts.CommerceRuntime.Carts;
using Mozu.Api.Test.Factories;
using Mozu.Api.Contracts.Core;
using UserScope = Mozu.Api.Security.UserScope;

namespace Mozu.Api.Test.MsTestCases
{
    [TestClass]
    public class OrderTests : MozuApiTestBase
    {

        #region NonTestCaseCode

        public OrderTests()
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
            TestBaseTenant = TenantFactory.GetTenant(handler: ApiMsgHandler, tenantId: tenantId);
            masterCatalogId = TestBaseTenant.MasterCatalogs.First().Id;
            catalogId = TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id;
            ApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage(tenantId, masterCatalogId: masterCatalogId, catalogId: catalogId);
            AnonShopperMsgHandler = ServiceClientMessageFactory.GetTestShopperMessage(tenantId, siteId:TestBaseTenant.Sites.First().Id);
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
            //Framework.DataFactory.Platform.SiteSettingsFactory.SetDefaultSiteSettings(ServiceClientMessageFactory.GetTestClientMessage(tenantId, siteId, siteGroupId), true, true, true, true, "LoginRequired", "AuthorizeAndCaptureOnOrderPlacement", cards);
        }

        #endregion

        #region CleanupMethods

        /// <summary>
        /// This will run once after each test.
        /// </summary>
        [TestCleanup]
        public void TestMethodCleanup()
        {
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
        [Priority(1)]
        [Description("Create order from existing cart.")]
        public void OrderTests_Test1()
        {
            var userAuthInfo = new UserAuthInfo();
            var userInfo = Mozu.Api.Security.UserAuthenticator.Authenticate(userAuthInfo, UserScope.Shopper);

            var createdCart = CartFactory.GetOrCreateCart(AnonShopperMsgHandler, authTicket: userInfo.AuthTicket);
            const int index = 0;
            var product = ProductFactory.GetProducts(AnonShopperMsgHandler, index, 13).Items.First();
            const int itemQty = 1; 
            var item = CartItemFactory.AddItemToCart(AnonShopperMsgHandler,
                                                     new CartItem()
                                                         {
                                                             Product =
                                                                 new Product
                                                                     {
                                                                         ProductCode = product.ProductCode
                                                                     },
                                                             Quantity = itemQty
                                                         });
            var order = OrderFactory.CreateOrderFromCart(AnonShopperMsgHandler, createdCart.Id);
            Assert.AreEqual(order.Items.Count, itemQty, "The number of order items is not correct.");
            Assert.AreEqual(order.Items[0].Product.ProductCode, product.ProductCode, "The order item is not the same the shopper entered in the cart.");
            Assert.AreEqual(order.Status, "Created", "The order status is not correct.");
            Assert.IsTrue(order.PaymentStatus.Equals("Unpaid"));
            Assert.IsTrue(order.FulfillmentStatus.Equals("NotShipped"));

        }


        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(1)]
        [Description("Add payment info (pay by check) and shipping info (using customrates provider) to the order.")]

        public void OrderTests_Test2()
        {
            var createdCart = CartFactory.GetOrCreateCart(AnonShopperMsgHandler);
            const int index = 0;
            var product = ProductFactory.GetProducts(AnonShopperMsgHandler, index, 13).Items.First();
            const int itemQty = 3; 
            var item = CartItemFactory.AddItemToCart(AnonShopperMsgHandler,
                                                     new CartItem
                                                         {
                                                             Product =
                                                                 new Product
                                                                     {
                                                                         ProductCode = product.ProductCode
                                                                     },
                                                             Quantity = itemQty
                                                         });
            var getUserCart = CartFactory.GetUserCart(ApiMsgHandler, createdCart.UserId);
            var order = OrderFactory.CreateOrderFromCart(AnonShopperMsgHandler, createdCart.Id);
            var billing = BillingInfoFactory.SetBillingInfo(AnonShopperMsgHandler, order.Id, new BillingInfo()
                                                        {
                                                            PaymentType = "Check",
                                                            BillingContact = new Mozu.Api.Contracts.Core.Contact
                                                             {
                                                                Address = new Address
                                                                    {
                                                                        Address1 = string.Format("{0} {1}", Generator.RandomString(8, Generator.RandomCharacterGroup.NumericOnly), Generator.RandomString(75, Generator.RandomCharacterGroup.AlphaNumericOnly)),
                                                                        Address2 = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address3 = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address4 = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        CityOrTown = Generator.RandomString(25, Generator.RandomCharacterGroup.AlphaOnly),
                                                                        CountryCode = "US",
                                                                        PostalOrZipCode = "78713",
                                                                        StateOrProvince = "TX"
                                                                    },
                                                                CompanyOrOrganization = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                Email = Generator.RandomEmailAddress(),
                                                                FirstName = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaOnly),
                                                                MiddleNameOrInitial = Generator.RandomString(1, Generator.RandomCharacterGroup.AlphaOnly),
                                                                LastNameOrSurname = Generator.RandomString(35, Generator.RandomCharacterGroup.AlphaOnly),
                                                                PhoneNumbers = new Mozu.Api.Contracts.Core.Phone
                                                                    {
                                                                        Home = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Mobile = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Work = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly))
                                                                    }
                                                            },
                                                            IsSameBillingShippingAddress = true
                                                        });

            var shipping = FulfillmentInfoFactory.SetFulFillmentInfo(AnonShopperMsgHandler, order.Id, new FulfillmentInfo(){ IsDestinationCommercial = false,
                                                            FulfillmentContact = new Mozu.Api.Contracts.Core.Contact
                                                             {
                                                                Address = new Address
                                                                    {
                                                                        Address1 = string.Format("{0} {1}", Generator.RandomString(8, Generator.RandomCharacterGroup.NumericOnly), Generator.RandomString(75, Generator.RandomCharacterGroup.AlphaNumericOnly)),
                                                                        Address2 = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address3 = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address4 = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        CityOrTown = Generator.RandomString(25, Generator.RandomCharacterGroup.AlphaOnly),
                                                                        CountryCode = "US",
                                                                        PostalOrZipCode = "78713",
                                                                        StateOrProvince = "TX"
                                                                    },
                                                                CompanyOrOrganization = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                Email = Generator.RandomEmailAddress(),
                                                                FirstName = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaOnly),
                                                                MiddleNameOrInitial = Generator.RandomString(1, Generator.RandomCharacterGroup.AlphaOnly),
                                                                LastNameOrSurname = Generator.RandomString(35, Generator.RandomCharacterGroup.AlphaOnly),
                                                                PhoneNumbers = new Mozu.Api.Contracts.Core.Phone
                                                                    {
                                                                        Home = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Mobile = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Work = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly))
                                                                    }
                                                            },
                                                            ShippingMethodCode = "CUSTOM_FLAT_RATE_PER_ORDER_EXACT_AMOUNT",
                                                            ShippingMethodName = "Flat Rate"
                    });
            var getOrder = OrderFactory.GetOrder(AnonShopperMsgHandler, order.Id);
            Assert.IsTrue(billing.PaymentType.Equals("Check"));
            Assert.IsTrue(billing.BillingContact.Address.StateOrProvince.Equals("TX"));
            Assert.IsTrue(billing.BillingContact.Address.PostalOrZipCode.Equals("78717"));
            Assert.IsTrue(billing.IsSameBillingShippingAddress);
            Assert.IsTrue(shipping.FulfillmentContact.Address.PostalOrZipCode.Equals("78726"));
            Assert.IsTrue(shipping.FulfillmentContact.Address.StateOrProvince.Equals("TX"));
            Assert.IsFalse(Convert.ToBoolean(shipping.IsDestinationCommercial));
            Assert.IsTrue(shipping.ShippingMethodCode.Equals("CUSTOM_FLAT_RATE_PER_ORDER_EXACT_AMOUNT"));
            Assert.IsTrue(shipping.ShippingMethodName.Equals("Flat Rate"));
            Assert.AreEqual(getOrder.Subtotal, getUserCart.Subtotal);
            Assert.AreEqual(getOrder.DiscountTotal, getUserCart.DiscountTotal);
            Assert.AreEqual(getOrder.DiscountedTotal, getUserCart.DiscountedTotal);
            Assert.AreEqual(getOrder.ShippingTotal, 15);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Submit the order.")]
        public void OrderTests_Test3()
        {
            var createdCart = CartFactory.GetOrCreateCart(AnonShopperMsgHandler);
            const int index = 0;
            var product = ProductFactory.GetProducts(AnonShopperMsgHandler, index, 13).Items.First();
            const int itemQty = 1; 
            var item = CartItemFactory.AddItemToCart(AnonShopperMsgHandler,
                                                     new CartItem
                                                         {
                                                             Product =
                                                                 new Product
                                                                     {
                                                                         ProductCode = product.ProductCode
                                                                     },
                                                             Quantity = itemQty
                                                         });
            var order = OrderFactory.CreateOrderFromCart(AnonShopperMsgHandler, createdCart.Id);
            var billing = BillingInfoFactory.SetBillingInfo(AnonShopperMsgHandler, order.Id, new BillingInfo()
                                                        {
                                                            PaymentType = "Check",
                                                            BillingContact = new Mozu.Api.Contracts.Core.Contact
                                                             {
                                                                Address = new Address
                                                                    {
                                                                        Address1 = string.Format("{0} {1}", Generator.RandomString(8, Generator.RandomCharacterGroup.NumericOnly), Generator.RandomString(75, Generator.RandomCharacterGroup.AlphaNumericOnly)),
                                                                        Address2 = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address3 = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address4 = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        CityOrTown = Generator.RandomString(25, Generator.RandomCharacterGroup.AlphaOnly),
                                                                        CountryCode = "US",
                                                                        PostalOrZipCode = "78713",
                                                                        StateOrProvince = "TX"
                                                                    },
                                                                CompanyOrOrganization = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                Email = Generator.RandomEmailAddress(),
                                                                FirstName = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaOnly),
                                                                MiddleNameOrInitial = Generator.RandomString(1, Generator.RandomCharacterGroup.AlphaOnly),
                                                                LastNameOrSurname = Generator.RandomString(35, Generator.RandomCharacterGroup.AlphaOnly),
                                                                PhoneNumbers = new Mozu.Api.Contracts.Core.Phone
                                                                    {
                                                                        Home = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Mobile = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Work = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly))
                                                                    }
                                                            },
                                                            IsSameBillingShippingAddress = true
                                                        });

            var shipping = FulfillmentInfoFactory.SetFulFillmentInfo(AnonShopperMsgHandler, order.Id, new FulfillmentInfo(){ IsDestinationCommercial = false,
                                                            FulfillmentContact = new Mozu.Api.Contracts.Core.Contact
                                                             {
                                                                Address = new Address
                                                                    {
                                                                        Address1 = string.Format("{0} {1}", Generator.RandomString(8, Generator.RandomCharacterGroup.NumericOnly), Generator.RandomString(75, Generator.RandomCharacterGroup.AlphaNumericOnly)),
                                                                        Address2 = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address3 = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address4 = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        CityOrTown = Generator.RandomString(25, Generator.RandomCharacterGroup.AlphaOnly),
                                                                        CountryCode = "US",
                                                                        PostalOrZipCode = "78713",
                                                                        StateOrProvince = "TX"
                                                                    },
                                                                CompanyOrOrganization = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                Email = Generator.RandomEmailAddress(),
                                                                FirstName = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaOnly),
                                                                MiddleNameOrInitial = Generator.RandomString(1, Generator.RandomCharacterGroup.AlphaOnly),
                                                                LastNameOrSurname = Generator.RandomString(35, Generator.RandomCharacterGroup.AlphaOnly),
                                                                PhoneNumbers = new Mozu.Api.Contracts.Core.Phone
                                                                    {
                                                                        Home = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Mobile = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Work = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly))
                                                                    }
                                                            },
                                                            ShippingMethodCode = "CUSTOM_FLAT_RATE_PER_ORDER_EXACT_AMOUNT",
                                                            ShippingMethodName = "Flat Rate"
                    });
            var getOrderActions = OrderFactory.GetAvailableActions(ApiMsgHandler, order.Id);
            Assert.AreEqual(getOrderActions.Count, 1);
            Assert.IsTrue(getOrderActions[0].Equals("SubmitOrder"));
            var status = OrderFactory.PerformOrderAction(AnonShopperMsgHandler, order.Id, new OrderAction(){ActionName = "SubmitOrder"});
            var getOrder = OrderFactory.GetOrder(ApiMsgHandler, order.Id);
            Assert.AreEqual(getOrder.Status, "Submitted");
            Assert.AreEqual(getOrder.PaymentStatus, "Pending");
            Assert.AreEqual(getOrder.FulfillmentStatus, "NotShipped");
            Assert.AreEqual(getOrder.ReturnStatus, "None");
            Assert.AreEqual(getOrder.SubmittedDate.Value.Date, DateTime.Today.Date);
            Assert.AreEqual(getOrder.TotalCollected, 0);
            Assert.AreEqual(getOrder.Payments.Count, 1);
            Assert.AreEqual(getOrder.Payments[0].PaymentType, "Check");
            Assert.AreEqual(getOrder.Payments[0].Status, "Pending");
            Assert.AreEqual(getOrder.Payments[0].Interactions.Count, 1);
            Assert.AreEqual(getOrder.Payments[0].Interactions[0].InteractionType, "RequestCheck");
            Assert.IsTrue(getOrder.Payments[0].Interactions[0].Status.Equals("CheckRequested"));
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Receive the payment check and the check is good.")]
        public void OrderTests_Test4()
        {
                        var createdCart = CartFactory.GetOrCreateCart(AnonShopperMsgHandler);
            const int index = 0;
            var product = ProductFactory.GetProducts(AnonShopperMsgHandler, index, 13).Items.First();
            const int itemQty = 1; 
            var item = CartItemFactory.AddItemToCart(AnonShopperMsgHandler,
                                                     new CartItem
                                                         {
                                                             Product =
                                                                 new Product
                                                                     {
                                                                         ProductCode = product.ProductCode
                                                                     },
                                                             Quantity = itemQty
                                                         });
            var order = OrderFactory.CreateOrderFromCart(AnonShopperMsgHandler, createdCart.Id);
            var billing = BillingInfoFactory.SetBillingInfo(AnonShopperMsgHandler, order.Id, new BillingInfo()
                                                        {
                                                            PaymentType = "Check",
                                                            BillingContact = new Mozu.Api.Contracts.Core.Contact
                                                             {
                                                                Address = new Address
                                                                    {
                                                                        Address1 = string.Format("{0} {1}", Generator.RandomString(8, Generator.RandomCharacterGroup.NumericOnly), Generator.RandomString(75, Generator.RandomCharacterGroup.AlphaNumericOnly)),
                                                                        Address2 = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address3 = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address4 = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        CityOrTown = Generator.RandomString(25, Generator.RandomCharacterGroup.AlphaOnly),
                                                                        CountryCode = "US",
                                                                        PostalOrZipCode = "78713",
                                                                        StateOrProvince = "TX"
                                                                    },
                                                                CompanyOrOrganization = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                Email = Generator.RandomEmailAddress(),
                                                                FirstName = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaOnly),
                                                                MiddleNameOrInitial = Generator.RandomString(1, Generator.RandomCharacterGroup.AlphaOnly),
                                                                LastNameOrSurname = Generator.RandomString(35, Generator.RandomCharacterGroup.AlphaOnly),
                                                                PhoneNumbers = new Mozu.Api.Contracts.Core.Phone
                                                                    {
                                                                        Home = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Mobile = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Work = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly))
                                                                    }
                                                            },
                                                            IsSameBillingShippingAddress = true
                                                        });

            var shipping = FulfillmentInfoFactory.SetFulFillmentInfo(AnonShopperMsgHandler, order.Id, new FulfillmentInfo(){ IsDestinationCommercial = false,
                                                            FulfillmentContact = new Mozu.Api.Contracts.Core.Contact
                                                             {
                                                                Address = new Address
                                                                    {
                                                                        Address1 = string.Format("{0} {1}", Generator.RandomString(8, Generator.RandomCharacterGroup.NumericOnly), Generator.RandomString(75, Generator.RandomCharacterGroup.AlphaNumericOnly)),
                                                                        Address2 = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address3 = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        Address4 = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                        CityOrTown = Generator.RandomString(25, Generator.RandomCharacterGroup.AlphaOnly),
                                                                        CountryCode = "US",
                                                                        PostalOrZipCode = "78713",
                                                                        StateOrProvince = "TX"
                                                                    },
                                                                CompanyOrOrganization = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                                                                Email = Generator.RandomEmailAddress(),
                                                                FirstName = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaOnly),
                                                                MiddleNameOrInitial = Generator.RandomString(1, Generator.RandomCharacterGroup.AlphaOnly),
                                                                LastNameOrSurname = Generator.RandomString(35, Generator.RandomCharacterGroup.AlphaOnly),
                                                                PhoneNumbers = new Mozu.Api.Contracts.Core.Phone
                                                                    {
                                                                        Home = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Mobile = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                                                                        Work = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                                                                         Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly))
                                                                    }
                                                            },
                                                            ShippingMethodCode = "CUSTOM_FLAT_RATE_PER_ORDER_EXACT_AMOUNT",
                                                            ShippingMethodName = "Flat Rate"
                    });
            var getOrderActions = OrderFactory.GetAvailableActions(ApiMsgHandler, order.Id);
            Assert.AreEqual(getOrderActions.Count, 1);
            Assert.IsTrue(getOrderActions[0].Equals("SubmitOrder"));
            var status = OrderFactory.PerformOrderAction(AnonShopperMsgHandler, order.Id, new OrderAction(){ActionName = "SubmitOrder"});
            var getOrder = OrderFactory.GetOrder(ApiMsgHandler, order.Id);
            var getPaymentActions = PaymentFactory.GetAvailablePaymentActions(ApiMsgHandler, order.Id, getOrder.Payments[0].Id);
            Assert.AreEqual(getPaymentActions.Count, 3);
            Assert.IsTrue(getPaymentActions[0].Equals("ApplyCheck") || getPaymentActions[0].Equals("VoidPayment") || getPaymentActions[0].Equals("DeclinePayment"));
            Assert.IsTrue(getPaymentActions[1].Equals("ApplyCheck") || getPaymentActions[1].Equals("VoidPayment") || getPaymentActions[1].Equals("DeclinePayment"));
            Assert.IsTrue(getPaymentActions[2].Equals("ApplyCheck") || getPaymentActions[2].Equals("VoidPayment") || getPaymentActions[2].Equals("DeclinePayment"));
            var paymentAction = new PaymentAction()
            {
                ActionName = "ApplyCheck",
                CheckNumber = "12345",
                Amount = Convert.ToDecimal(getOrder.Total)
            }; 
            var orderPayment1 = PaymentFactory.PerformPaymentAction(ApiMsgHandler, order.Id, getOrder.Payments[0].Id, paymentAction);
            Assert.AreEqual(orderPayment1.PaymentStatus, "Paid");
            Assert.AreEqual(orderPayment1.Payments[0].Status, "Collected");
            Assert.AreEqual(orderPayment1.Payments[0].AmountCollected, getOrder.Total);
            Assert.AreEqual(orderPayment1.Payments[0].Interactions.Count, 2);
            Assert.IsTrue(orderPayment1.Payments[0].Interactions[1].Status.Equals("Captured"));
            Assert.IsTrue(orderPayment1.Payments[0].Interactions[1].InteractionType.Equals("ApplyCheck"));
            Assert.IsTrue(orderPayment1.Payments[0].Interactions[1].CheckNumber.Equals("12345"));
            Assert.AreEqual(orderPayment1.Payments[0].Interactions[1].Amount, getOrder.Total);
        }
    }
}
