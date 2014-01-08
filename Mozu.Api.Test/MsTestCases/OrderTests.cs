using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozu.Api.Contracts.CommerceRuntime.Fulfillment;
using Mozu.Api.Contracts.CommerceRuntime.Orders;
using Mozu.Api.Contracts.CommerceRuntime.Payments;
using Mozu.Api.Contracts.CommerceRuntime.Products;
using Mozu.Api.Contracts.CommerceRuntime.Returns;
using Mozu.Api.Contracts.Customer;
using Mozu.Api.Test.Helpers;
using Mozu.Api.Contracts.CommerceRuntime.Carts;
using Mozu.Api.Test.Factories;
using Mozu.Api.Contracts.Core;


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
            ShopperMsgHandler = ServiceClientMessageFactory.GetTestShopperMessage(tenantId, siteId: TestBaseTenant.Sites.First().Id);
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
        // NOTE:  This create an empty, first stage order.  It will not show up in MozuAdmin Orders UI until after the customer fulfillment and billing info is added and processed.
        public void OrderTests_Test1()
        {
            var customerAccountAndAuthInfo = Generator.GenerateCustomerAccountAndAuthInfo(taxExempt: true, taxId: "98-02565-0000");
            var createdCustomerAccount = CustomerAccountFactory.AddAccountAndLogin(handler: ShopperMsgHandler,
                                                                                   accountAndAuthInfo:
                                                                                       customerAccountAndAuthInfo);

            var updateCustomerAccount = CustomerContactFactory.AddAccountContact(handler: ShopperMsgHandler,
                                                                                 contact:
                                                                                     Generator
                                                                                     .GenerateCustomerContactReal(
                                                                                         accountId:
                                                                                             createdCustomerAccount
                                                                                             .CustomerAccount.Id,
                                                                                             firstname: customerAccountAndAuthInfo.Account.FirstName,
                                                                                             lastname: customerAccountAndAuthInfo.Account.LastName,
                                                                                             username: customerAccountAndAuthInfo.Account.UserName),
                                                                                 accountId:
                                                                                     createdCustomerAccount
                                                                                     .CustomerAccount.Id);

            var shopperUserAuthInfo = Generator.GenerateCustomerUserAuthInfo(userName: customerAccountAndAuthInfo.Account.UserName);

            var ShopperAuth = Mozu.Api.Security.CustomerAuthenticator.Authenticate(customerUserAuthInfo: shopperUserAuthInfo,
                tenantId: TestBaseTenant.Id, siteId: TestBaseTenant.Sites.FirstOrDefault().Id);

            var createdCart = CartFactory.GetOrCreateCart(ShopperMsgHandler, authTicket: ShopperAuth.AuthTicket);
            const int index = 0;
            var product = StorefrontProductFactory.GetProducts(handler: ShopperMsgHandler, startIndex: index, pageSize: 13,
                                                authTicket: ShopperAuth.AuthTicket).Items.First();
            const int itemQty = 1;
            var item = CartItemFactory.AddItemToCart(ShopperMsgHandler,
                                                     new CartItem()
                                                     {
                                                         Product =
                                                             new Product
                                                             {
                                                                 ProductCode = product.ProductCode
                                                             },
                                                         Quantity = itemQty
                                                     },
                                                         authTicket: ShopperAuth.AuthTicket);
            var order = OrderFactory.CreateOrderFromCart(ShopperMsgHandler, createdCart.Id);
            Assert.AreEqual(order.Items.Count, itemQty, "The number of order items is not correct.");
            Assert.AreEqual(order.Items[0].Product.ProductCode, product.ProductCode, "The order item is not the same the shopper entered in the cart.");
            Assert.AreEqual(order.Status, "Created", "The order status is not correct.");
            Assert.IsTrue(order.PaymentStatus.Equals("Unpaid"));
            Assert.IsTrue(order.FulfillmentStatus.Equals("NotFulfilled"));
        }


        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(1)]
        [Description("Add payment info (pay by check) and shipping info (using customrates provider) to the order.")]
        public void OrderTests_Test2()
        {
            var customerAccountAndAuthInfo = Generator.GenerateCustomerAccountAndAuthInfo(taxExempt: true, taxId: "98-02565-0000");
            var createdCustomerAccount = CustomerAccountFactory.AddAccountAndLogin(handler: ShopperMsgHandler,
                                                                                   accountAndAuthInfo:
                                                                                       customerAccountAndAuthInfo);

            var updateCustomerAccount = CustomerContactFactory.AddAccountContact(handler: ShopperMsgHandler,
                                                                                 contact:
                                                                                     Generator
                                                                                     .GenerateCustomerContactReal(
                                                                                         accountId:
                                                                                             createdCustomerAccount
                                                                                             .CustomerAccount.Id,
                                                                                             firstname: customerAccountAndAuthInfo.Account.FirstName,
                                                                                             lastname: customerAccountAndAuthInfo.Account.LastName,
                                                                                             username: customerAccountAndAuthInfo.Account.UserName),
                                                                                 accountId:
                                                                                     createdCustomerAccount
                                                                                     .CustomerAccount.Id);

            var shopperUserAuthInfo = Generator.GenerateCustomerUserAuthInfo(userName: customerAccountAndAuthInfo.Account.UserName);

            var ShopperAuth = Mozu.Api.Security.CustomerAuthenticator.Authenticate(customerUserAuthInfo: shopperUserAuthInfo,
                tenantId: TestBaseTenant.Id,
                siteId: TestBaseTenant.Sites.FirstOrDefault().Id);

            var createdCart = CartFactory.GetOrCreateCart(ShopperMsgHandler, authTicket: ShopperAuth.AuthTicket);
            const int index = 0;
            var product = StorefrontProductFactory.GetProducts(handler: ShopperMsgHandler, startIndex: index, pageSize: 13,
                                                        authTicket: ShopperAuth.AuthTicket).Items.First();
            const int itemQty = 3;
            var item = CartItemFactory.AddItemToCart(ShopperMsgHandler,
                                                  new CartItem()
                                                  {
                                                      Product = new Product
                                                      {
                                                          ProductCode = product.ProductCode
                                                      },
                                                      Quantity = itemQty
                                                  },
                                                  authTicket: ShopperAuth.AuthTicket);

            var getUserCart = CartFactory.GetUserCart(handler: ShopperMsgHandler, userId: createdCart.UserId);

            var order = OrderFactory.CreateOrderFromCart(handler: ShopperMsgHandler, cartId: createdCart.Id, authTicket: ShopperAuth.AuthTicket);
            var shippingContact = Generator.GenerateContactRealAddress(isValidated: true);

            var shippingAddressInfo = FulfillmentActionFactory.SetFulFillmentInfo(handler: ShopperMsgHandler, orderId: order.Id,
                fulfillmentInfo: new FulfillmentInfo()
                {
                    IsDestinationCommercial = false,
                    FulfillmentContact = shippingContact,
                },
                authTicket: ShopperAuth.AuthTicket);

            var billingContact = Generator.GenerateContactRealAddress();

            var billingAddress = BillingInfoFactory.SetBillingInfo(handler: ShopperMsgHandler, orderId: order.Id,
                billingInfo: new BillingInfo()
                {
                    PaymentType = "Check",
                    BillingContact = billingContact,
                    IsSameBillingShippingAddress = true
                });


            var availableShippingMethods = ShipmentFactory.GetAvailableShipmentMethods(handler: ShopperMsgHandler,
                                                                                       orderId: order.Id,
                                                                                       authTicket: ShopperAuth.AuthTicket);
            var shipping = FulfillmentActionFactory.SetFulFillmentInfo(handler: ShopperMsgHandler, orderId: order.Id,
                fulfillmentInfo: new FulfillmentInfo()
                {
                    IsDestinationCommercial = false,
                    FulfillmentContact = shippingContact,
                    ShippingMethodCode = availableShippingMethods.First().ShippingMethodCode,
                    ShippingMethodName = availableShippingMethods.First().ShippingMethodName
                },
                authTicket: ShopperAuth.AuthTicket);

            var getOrder = OrderFactory.GetOrder(handler: ShopperMsgHandler,
                orderId: order.Id, authTicket:
                ShopperAuth.AuthTicket,
                draft: false);

            Assert.IsTrue(billingAddress.PaymentType.Equals("Check"));
            Assert.IsTrue(billingAddress.BillingContact.Address.StateOrProvince.Equals(billingContact.Address.StateOrProvince));
            Assert.IsTrue(billingAddress.BillingContact.Address.PostalOrZipCode.Equals(billingContact.Address.PostalOrZipCode));
            Assert.IsTrue(billingAddress.IsSameBillingShippingAddress);
            Assert.IsTrue(shipping.FulfillmentContact.Address.PostalOrZipCode.Equals(shippingContact.Address.PostalOrZipCode));
            Assert.IsTrue(shipping.FulfillmentContact.Address.StateOrProvince.Equals(shippingContact.Address.StateOrProvince));
            Assert.IsFalse(Convert.ToBoolean(shipping.IsDestinationCommercial));
            Assert.IsTrue(shipping.ShippingMethodCode.Equals(availableShippingMethods.First().ShippingMethodCode));
            Assert.IsTrue(shipping.ShippingMethodName.Equals(availableShippingMethods.First().ShippingMethodName));
            Assert.AreEqual(getOrder.Subtotal, getUserCart.Subtotal);
            Assert.AreEqual(getOrder.DiscountTotal, getUserCart.DiscountTotal);
            Assert.AreEqual(getOrder.DiscountedTotal, getUserCart.DiscountedTotal);
            // Assert.AreEqual(getOrder.ShippingTotal, 15);
        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Submit the order, pay by check, fulfill and rma checks")]
        public void OrderTests_Test3()
        {
            var customerAccountAndAuthInfo = Generator.GenerateCustomerAccountAndAuthInfo(taxExempt: true, taxId: "98-02565-0000");
            var createdCustomerAccount = CustomerAccountFactory.AddAccountAndLogin(handler: ShopperMsgHandler,
                                                                                   accountAndAuthInfo:
                                                                                       customerAccountAndAuthInfo);

            var updateCustomerAccount = CustomerContactFactory.AddAccountContact(handler: ShopperMsgHandler,
                                                                                 contact:
                                                                                     Generator
                                                                                     .GenerateCustomerContactReal(
                                                                                         accountId:
                                                                                             createdCustomerAccount
                                                                                             .CustomerAccount.Id,
                                                                                             firstname: customerAccountAndAuthInfo.Account.FirstName,
                                                                                             lastname: customerAccountAndAuthInfo.Account.LastName,
                                                                                             username: customerAccountAndAuthInfo.Account.UserName),
                                                                                 accountId:
                                                                                     createdCustomerAccount
                                                                                     .CustomerAccount.Id);

            var shopperUserAuthInfo = Generator.GenerateCustomerUserAuthInfo(userName: customerAccountAndAuthInfo.Account.UserName);

            var ShopperAuth =
                Mozu.Api.Security.CustomerAuthenticator.Authenticate(customerUserAuthInfo: shopperUserAuthInfo,
                                                                     tenantId: TestBaseTenant.Id,
                                                                     siteId: TestBaseTenant.Sites.FirstOrDefault().Id);

            var createdCart = CartFactory.GetOrCreateCart(ShopperMsgHandler, authTicket: ShopperAuth.AuthTicket);
            const int index = 0;

            var productCollection = StorefrontProductFactory.GetProducts(handler: ShopperMsgHandler, startIndex: index, pageSize: 13, filter: "productcode eq AC-1",
                                                        authTicket: ShopperAuth.AuthTicket);
            if (productCollection.TotalCount == 0)
            {
                productCollection = StorefrontProductFactory.GetProducts(handler: ShopperMsgHandler, startIndex: index, pageSize: 13, filter: null,
                                                        authTicket: ShopperAuth.AuthTicket);
            }
            var product = productCollection.Items.First();


            const int itemQty = 3;
            var item = CartItemFactory.AddItemToCart(ShopperMsgHandler,
                                                  new CartItem()
                                                  {
                                                      Product = new Product
                                                      {
                                                          ProductCode = product.ProductCode
                                                      },
                                                      Quantity = itemQty
                                                      ,
                                                      FulfillmentLocationCode = "HomeBase",
                                                      FulfillmentMethod = "PickUp"
                                                  },
                                                  authTicket: ShopperAuth.AuthTicket);
            //item = CartItemFactory.AddItemToCart(ShopperMsgHandler,
            //                          new CartItem()
            //                          {
            //                              Product = new Product
            //                              {
            //                                  ProductCode = product.ProductCode
            //                              },
            //                              Quantity = itemQty
            //                              ,
            //                              FulfillmentLocationCode = "HomeBase",
            //                              FulfillmentMethod = "Ship"
            //                          },
            //                          authTicket: ShopperAuth.AuthTicket);

            var getUserCart = CartFactory.GetUserCart(handler: ShopperMsgHandler, userId: createdCart.UserId);

            var order = OrderFactory.CreateOrderFromCart(handler: ShopperMsgHandler, cartId: createdCart.Id, authTicket: ShopperAuth.AuthTicket);
            var shippingContact = Generator.GenerateContactRealAddress(isValidated: true);


            var shippingAddressInfo = FulfillmentActionFactory.SetFulFillmentInfo(handler: ShopperMsgHandler, orderId: order.Id,
                fulfillmentInfo: new FulfillmentInfo()
                {

                    IsDestinationCommercial = false,
                    FulfillmentContact = shippingContact,
                },
                authTicket: ShopperAuth.AuthTicket);

            var billingContact = Generator.GenerateContactRealAddress();

            var billingAddress = BillingInfoFactory.SetBillingInfo(handler: ShopperMsgHandler, orderId: order.Id,
                billingInfo: new BillingInfo()
                {
                    PaymentType = "Check",
                    BillingContact = billingContact,
                    IsSameBillingShippingAddress = true,
                });

            System.Threading.Thread.Sleep(200);
            var availableShippingMethods = ShipmentFactory.GetAvailableShipmentMethods(handler: ShopperMsgHandler,
                                                                                       orderId: order.Id,
                                                                                       authTicket: ShopperAuth.AuthTicket);
            var shipping = FulfillmentActionFactory.SetFulFillmentInfo(handler: ShopperMsgHandler, orderId: order.Id,
                fulfillmentInfo: new FulfillmentInfo()
                {

                    IsDestinationCommercial = false,
                    FulfillmentContact = shippingContact,
                    ShippingMethodCode = availableShippingMethods.First().ShippingMethodCode,
                    ShippingMethodName = availableShippingMethods.First().ShippingMethodName
                },
                authTicket: ShopperAuth.AuthTicket);

            var paymentAction = Generator.GeneratePaymentAction(action: "CreatePayment",
                amt: Convert.ToDecimal(order.Total),
                billingInfo: billingAddress,
                checkNumber: Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly));

            var createdPaymentAction = PaymentFactory.CreatePaymentAction(handler: ShopperMsgHandler,
                orderId: order.Id,
                action: paymentAction,
                authTicket: ShopperAuth.AuthTicket, expectedCode: HttpStatusCode.OK, successCode: HttpStatusCode.OK);

            var getOrder = OrderFactory.GetOrder(handler: ShopperMsgHandler,
                orderId: order.Id,
                authTicket: ShopperAuth.AuthTicket,
                draft: false);

            var getOrderActions = OrderFactory.GetAvailableActions(handler: ShopperMsgHandler, orderId: getOrder.Id, authTicket: ShopperAuth.AuthTicket);
            Assert.AreEqual(getOrderActions.Count, 1);
            Assert.IsTrue(getOrderActions[0].Equals("SubmitOrder"));

            var status = OrderFactory.PerformOrderAction(handler: ShopperMsgHandler, orderId: getOrder.Id, action:
                new OrderAction()
                {
                    ActionName = "SubmitOrder"
                }, authTicket: ShopperAuth.AuthTicket);

            getOrder = OrderFactory.GetOrder(handler: ShopperMsgHandler,
                orderId: order.Id, authTicket:
                ShopperAuth.AuthTicket,
                draft: false);

            Assert.AreEqual(getOrder.Status, "Accepted");
            Assert.AreEqual(getOrder.PaymentStatus, "Pending");
            Assert.AreEqual(getOrder.FulfillmentStatus, "NotFulfilled");
            Assert.AreEqual(getOrder.ReturnStatus, "None");
            Assert.AreEqual(getOrder.SubmittedDate.Value.Date, DateTime.UtcNow.Date);
            Assert.AreEqual(getOrder.TotalCollected, 0);
            Assert.AreEqual(getOrder.Payments.Count, 1);
            Assert.AreEqual(getOrder.Payments[0].PaymentType, "Check");
            Assert.AreEqual(getOrder.Payments[0].Status, "Pending");
            Assert.AreEqual(getOrder.Payments[0].Interactions.Count, 1);
            Assert.AreEqual(getOrder.Payments[0].Interactions[0].InteractionType, "RequestCheck");
            Assert.IsTrue(getOrder.Payments[0].Interactions[0].Status.Equals("CheckRequested"));

            var getPaymentActions = PaymentFactory.GetAvailablePaymentActions(ApiMsgHandler, order.Id, getOrder.Payments[0].Id);
            Assert.AreEqual(getPaymentActions.Count, 3);
            Assert.IsTrue(getPaymentActions[0].Equals("CapturePayment") || getPaymentActions[0].Equals("VoidPayment") || getPaymentActions[0].Equals("DeclinePayment"));
            Assert.IsTrue(getPaymentActions[1].Equals("CapturePayment") || getPaymentActions[1].Equals("VoidPayment") || getPaymentActions[1].Equals("DeclinePayment"));
            Assert.IsTrue(getPaymentActions[2].Equals("CapturePayment") || getPaymentActions[2].Equals("VoidPayment") || getPaymentActions[2].Equals("DeclinePayment"));
            var newPaymentAction = new PaymentAction()
            {
                ActionName = "CapturePayment",
                CheckNumber = Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly),
                Amount = Convert.ToDecimal(getOrder.Total)
            };
            var orderPayment1 = PaymentFactory.PerformPaymentAction(handler: ApiMsgHandler, orderId: order.Id, paymentId: getOrder.Payments[0].Id, action: newPaymentAction);
            Assert.AreEqual(orderPayment1.PaymentStatus, "Paid");
            Assert.AreEqual(orderPayment1.Payments[0].Status, "Collected");
            Assert.AreEqual(orderPayment1.Payments[0].AmountCollected, getOrder.Total);
            Assert.AreEqual(orderPayment1.Payments[0].Interactions.Count, 2);
            Assert.IsTrue(orderPayment1.Payments[0].Interactions[1].Status.Equals("Captured"));
            Assert.IsTrue(orderPayment1.Payments[0].Interactions[1].InteractionType.Equals("Capture"));
            Assert.IsTrue(orderPayment1.Payments[0].Interactions[1].CheckNumber.Equals(newPaymentAction.CheckNumber));
            Assert.AreEqual(orderPayment1.Payments[0].Interactions[1].Amount, getOrder.Total);

            var pkgItems = new List<PackageItem>
                {
                    Generator.GeneratePackageItem(getOrder.Items[0].Product.ProductCode, getOrder.Items[0].Quantity)
                };

            availableShippingMethods = ShipmentFactory.GetAvailableShipmentMethods(handler: ShopperMsgHandler,
                                                                                       orderId: order.Id,
                                                                                       authTicket: ShopperAuth.AuthTicket);



            var pkg = Generator.GeneratePackage(shippingMethodCode: availableShippingMethods.First().ShippingMethodCode,
                shippingMethodName: availableShippingMethods.First().ShippingMethodName, items: pkgItems);

            var createdPkg = PackageFactory.CreatePackage(handler: ApiMsgHandler, orderId: order.Id, pkg: pkg);

            var pkgIds = new List<string>() { createdPkg.Id };

            var AdminApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage(tenantId, masterCatalogId: masterCatalogId, catalogId: catalogId, siteId: ShopperMsgHandler.ApiContext.SiteId);

            var createPkgShipment = ShipmentFactory.CreatePackageShipments(handler: AdminApiMsgHandler, orderId: order.Id, packageIds: pkgIds, expectedCode: HttpStatusCode.OK, successCode: HttpStatusCode.OK);
            var getLabel = PackageFactory.GetPackageLabel(handler: AdminApiMsgHandler, orderId: order.Id, packageId: createdPkg.Id);
            //Assert.IsNotNull(getLabel);

            var orderShipment = FulfillmentActionFactory.PerformFulfillmentAction(handler: AdminApiMsgHandler,
                orderId: order.Id, action: Generator.GenerateFulfillmentAction("Ship", pkgIds));
            Assert.AreEqual(orderShipment.FulfillmentStatus, "Fulfilled");


            var reasons = new Dictionary<string, int>();
            var returnItems = new List<ReturnItem>();
            reasons.Add("Damaged", 1);
            returnItems.Add(Generator.GenerateReturnItem(order.Items[0].Id, reasons));

            var createdReturn = ReturnFactory.CreateReturn(handler: AdminApiMsgHandler,
                ret: Generator.GenerateReturn(Generator.ReturnType.Refund, returnItems, order.Id));
            var returnIds = new List<string> { createdReturn.Id };


            var authReturn = ReturnFactory.PerformReturnActions(handler: AdminApiMsgHandler, action:
                Generator.GenerateReturnAction("Authorize", returnIds));

            getOrder = OrderFactory.GetOrder(handler: ShopperMsgHandler,
                orderId: order.Id, authTicket:
                ShopperAuth.AuthTicket,
                draft: false);

            var createdReturnPaymentAction = ReturnFactory.CreatePaymentActionForReturn(handler: AdminApiMsgHandler, returnId: createdReturn.Id,
                action: Generator.GeneratePaymentAction(action: "CreditPayment", checkNumber: "", amt: 5, paymentSourceId: getOrder.Payments[0].Id), expectedCode: HttpStatusCode.OK, successCode: HttpStatusCode.OK);

            var refundReturn = ReturnFactory.PerformReturnActions(handler: AdminApiMsgHandler, action: Generator.GenerateReturnAction("Refund", returnIds));
            Assert.AreEqual(refundReturn.Items[0].Status, "Refunded");
            var returnActions = ReturnFactory.GetAvailableReturnActions(handler: AdminApiMsgHandler, returnId: createdReturn.Id);
            Assert.AreEqual(returnActions.Count, 1);
            Assert.IsTrue(returnActions[0].Contains("Close"));
            refundReturn.Items[0].Items[0].QuantityReceived = 1;

            var updatedReturn = ReturnFactory.UpdateReturn(handler: AdminApiMsgHandler, returnId: refundReturn.Items[0].Id, ret: refundReturn.Items[0]);
            returnActions = ReturnFactory.GetAvailableReturnActions(handler: AdminApiMsgHandler, returnId: createdReturn.Id);
            Assert.AreEqual(returnActions.Count, 1);
            Assert.IsTrue(returnActions[0].Contains("Close"));
            var closeReturn = ReturnFactory.PerformReturnActions(handler: AdminApiMsgHandler, action: Generator.GenerateReturnAction("Close", returnIds));
            Assert.AreEqual(closeReturn.Items[0].Status, "Closed");


        }

        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Submit the order, pay by check.")]
        public void OrderTests_Test4()
        {
            var customerAccountAndAuthInfo = Generator.GenerateCustomerAccountAndAuthInfo(taxExempt: true,
                                                                                          taxId: "98-02565-0000");

            var checkCustomerIdentDuplication = CustomerAccountFactory.GetAccounts(handler: ShopperMsgHandler,
                                                                                   startIndex: 100,
                                                                                   filter:
                                                                                       "firstname eq '" +
                                                                                       customerAccountAndAuthInfo
                                                                                           .Account.FirstName + 
                                                                                       "' and lastname eq '" +
                                                                                       customerAccountAndAuthInfo
                                                                                           .Account.LastName + "'");

            if (checkCustomerIdentDuplication.TotalCount == 0)
            {

                var createdCustomerAccount = CustomerAccountFactory.AddAccountAndLogin(handler: ShopperMsgHandler,
                                                                                       accountAndAuthInfo:
                                                                                           customerAccountAndAuthInfo);
                var updateCustomerAccount = CustomerContactFactory.AddAccountContact(handler: ShopperMsgHandler,
                                                                     contact:
                                                                         Generator
                                                                         .GenerateCustomerContactReal(
                                                                             accountId:
                                                                                 createdCustomerAccount
                                                                                 .CustomerAccount.Id,
                                                                             firstname:
                                                                                 customerAccountAndAuthInfo
                                                                                 .Account.FirstName,
                                                                             lastname:
                                                                                 customerAccountAndAuthInfo
                                                                                 .Account.LastName,
                                                                             username:
                                                                                 customerAccountAndAuthInfo
                                                                                 .Account.UserName),
                                                                     accountId:
                                                                         createdCustomerAccount
                                                                         .CustomerAccount.Id);
            }
            else
            {
                var getCustomerAccount = checkCustomerIdentDuplication.Items.First();
            }


            var shopperUserAuthInfo =
                Generator.GenerateCustomerUserAuthInfo(userName: customerAccountAndAuthInfo.Account.UserName);

            var ShopperAuth =
                Mozu.Api.Security.CustomerAuthenticator.Authenticate(customerUserAuthInfo: shopperUserAuthInfo,
                                                                     tenantId: TestBaseTenant.Id,
                                                                     siteId: TestBaseTenant.Sites.FirstOrDefault().Id);

            var fulfillmentLocationCodes = LocationTypeFactory.GetLocationTypes(handler: ShopperMsgHandler);
            var fulfillmentLocationCode = fulfillmentLocationCodes.First().Code;


            var createdCart = CartFactory.GetOrCreateCart(ShopperMsgHandler, authTicket: ShopperAuth.AuthTicket);
            const int index = 0;
            var productCollection = StorefrontProductFactory.GetProducts(handler: ShopperMsgHandler, startIndex: index,
                                                                         pageSize: 13, filter: "productcode eq 'AC-1'",
                                                                         authTicket: ShopperAuth.AuthTicket);
            if (productCollection.TotalCount == 0)
            {
                productCollection = StorefrontProductFactory.GetProducts(handler: ShopperMsgHandler, startIndex: index,
                                                                         pageSize: 13, filter: null,
                                                                         authTicket: ShopperAuth.AuthTicket);
            }
            Assert.AreNotEqual(productCollection.Items.Count, 0, "No products in Store to use");
            var product = productCollection.Items.First();



            const int itemQty = 3;
            var item = CartItemFactory.AddItemToCart(ShopperMsgHandler,
                                                     new CartItem()
                                                         {
                                                             Product = new Product
                                                                 {
                                                                     ProductCode = product.ProductCode
                                                                 },
                                                             Quantity = itemQty
                                                             ,
                                                             FulfillmentLocationCode =   "HomeBase", //"MainWarehouse",
                                                             FulfillmentMethod = "PickUp"
                                                         },
                                                     authTicket: ShopperAuth.AuthTicket);
            item = CartItemFactory.AddItemToCart(ShopperMsgHandler,
                                                 new CartItem()
                                                     {
                                                         Product = new Product
                                                             {
                                                                 ProductCode = product.ProductCode
                                                             },
                                                         Quantity = itemQty
                                                         ,
                                                         FulfillmentLocationCode =  "HomeBase", // "MainWarehouse"
                                                         FulfillmentMethod = "Ship"
                                                     },
                                                 authTicket: ShopperAuth.AuthTicket);

            var getUserCart = CartFactory.GetUserCart(handler: ShopperMsgHandler, userId: createdCart.UserId);

            var order = OrderFactory.CreateOrderFromCart(handler: ShopperMsgHandler, cartId: createdCart.Id,
                                                         authTicket: ShopperAuth.AuthTicket);
            var shippingContact = Generator.GenerateContactRealAddress(isValidated: true);


            var shippingAddressInfo = FulfillmentActionFactory.SetFulFillmentInfo(handler: ShopperMsgHandler,
                                                                                  orderId: order.Id,
                                                                                  fulfillmentInfo: new FulfillmentInfo()
                                                                                      {

                                                                                          IsDestinationCommercial =
                                                                                              false,
                                                                                          FulfillmentContact =
                                                                                              shippingContact,
                                                                                      },
                                                                                  authTicket: ShopperAuth.AuthTicket);

            var billingContact = Generator.GenerateContactRealAddress();

            var billingAddress = BillingInfoFactory.SetBillingInfo(handler: ShopperMsgHandler, orderId: order.Id,
                                                                   billingInfo: new BillingInfo()
                                                                       {
                                                                           PaymentType = "Check",
                                                                           BillingContact = billingContact,
                                                                           IsSameBillingShippingAddress = true,
                                                                       });

            System.Threading.Thread.Sleep(200);
            var availableShippingMethods = ShipmentFactory.GetAvailableShipmentMethods(handler: ShopperMsgHandler,
                                                                                       orderId: order.Id,
                                                                                       authTicket:
                                                                                           ShopperAuth.AuthTicket);
            var shipping = FulfillmentActionFactory.SetFulFillmentInfo(handler: ShopperMsgHandler, orderId: order.Id,
                                                                       fulfillmentInfo: new FulfillmentInfo()
                                                                           {

                                                                               IsDestinationCommercial = false,
                                                                               FulfillmentContact = shippingContact,
                                                                               ShippingMethodCode =
                                                                                   availableShippingMethods.First()
                                                                                                           .ShippingMethodCode,
                                                                               ShippingMethodName =
                                                                                   availableShippingMethods.First()
                                                                                                           .ShippingMethodName
                                                                           },
                                                                       authTicket: ShopperAuth.AuthTicket);

            var paymentAction = Generator.GeneratePaymentAction(action: "CreatePayment",
                                                                amt: Convert.ToDecimal(order.Total),
                                                                billingInfo: billingAddress,
                                                                checkNumber:
                                                                    Generator.RandomString(4,
                                                                                           Generator
                                                                                               .RandomCharacterGroup
                                                                                               .NumericOnly));

            var createdPaymentAction = PaymentFactory.CreatePaymentAction(handler: ShopperMsgHandler,
                                                                          orderId: order.Id,
                                                                          action: paymentAction,
                                                                          authTicket: ShopperAuth.AuthTicket,
                                                                          expectedCode: HttpStatusCode.OK,
                                                                          successCode: HttpStatusCode.OK);

            var getOrder = OrderFactory.GetOrder(handler: ShopperMsgHandler,
                                                 orderId: order.Id,
                                                 authTicket: ShopperAuth.AuthTicket,
                                                 draft: false);

            var getOrderActions = OrderFactory.GetAvailableActions(handler: ShopperMsgHandler, orderId: getOrder.Id,
                                                                   authTicket: ShopperAuth.AuthTicket);
            Assert.AreEqual(getOrderActions.Count, 1);
            Assert.IsTrue(getOrderActions[0].Equals("SubmitOrder"));

            var status = OrderFactory.PerformOrderAction(handler: ShopperMsgHandler, orderId: getOrder.Id, action:
                                                                                                               new OrderAction
                                                                                                               ()
                                                                                                                   {
                                                                                                                       ActionName
                                                                                                                           =
                                                                                                                           "SubmitOrder"
                                                                                                                   },
                                                         authTicket: ShopperAuth.AuthTicket);

            getOrder = OrderFactory.GetOrder(handler: ShopperMsgHandler,
                                             orderId: order.Id, authTicket:
                                                                    ShopperAuth.AuthTicket,
                                             draft: false);

            Assert.AreEqual(getOrder.Status, "Accepted");
            Assert.AreEqual(getOrder.PaymentStatus, "Pending");
            Assert.AreEqual(getOrder.FulfillmentStatus, "NotFulfilled");
            Assert.AreEqual(getOrder.ReturnStatus, "None");
            Assert.AreEqual(getOrder.SubmittedDate.Value.Date, DateTime.UtcNow.Date);
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
        [Description("Submit the order, pay by credit card.")]
        public void OrderTests_Test5()
        {
            var customerAccountAndAuthInfo = Generator.GenerateCustomerAccountAndAuthInfo(taxExempt: true, taxId: "98-02565-0000");
            var createdCustomerAccount = CustomerAccountFactory.AddAccountAndLogin(handler: ShopperMsgHandler,
                                                                                   accountAndAuthInfo:
                                                                                       customerAccountAndAuthInfo);

            var updateCustomerAccount = CustomerContactFactory.AddAccountContact(handler: ShopperMsgHandler,
                                                                                 contact:
                                                                                     Generator
                                                                                     .GenerateCustomerContactReal(
                                                                                         accountId:
                                                                                             createdCustomerAccount
                                                                                             .CustomerAccount.Id,
                                                                                             firstname: customerAccountAndAuthInfo.Account.FirstName,
                                                                                             lastname: customerAccountAndAuthInfo.Account.LastName,
                                                                                             username: customerAccountAndAuthInfo.Account.UserName),
                                                                                 accountId:
                                                                                     createdCustomerAccount
                                                                                     .CustomerAccount.Id);

            var shopperUserAuthInfo =
                Generator.GenerateCustomerUserAuthInfo(userName: customerAccountAndAuthInfo.Account.UserName);

            var ShopperAuth =
                Mozu.Api.Security.CustomerAuthenticator.Authenticate(customerUserAuthInfo: shopperUserAuthInfo,
                                                                     tenantId: TestBaseTenant.Id,
                                                                     siteId: TestBaseTenant.Sites.FirstOrDefault().Id);

            var createdCart = CartFactory.GetOrCreateCart(ShopperMsgHandler, authTicket: ShopperAuth.AuthTicket);
            const int index = 0;

            var productCollection = StorefrontProductFactory.GetProducts(handler: ShopperMsgHandler, startIndex: index,
                                                                         pageSize: 13, filter: "productcode eq AC-1",
                                                                         authTicket: ShopperAuth.AuthTicket);
            if (productCollection.TotalCount == 0)
            {
                productCollection = StorefrontProductFactory.GetProducts(handler: ShopperMsgHandler, startIndex: index,
                                                                         pageSize: 13, filter: null,
                                                                         authTicket: ShopperAuth.AuthTicket);
            }
            var product = productCollection.Items.First();


            const int itemQty = 3;
            var item = CartItemFactory.AddItemToCart(ShopperMsgHandler,
                                                     new CartItem()
                                                     {
                                                         Product = new Product
                                                         {
                                                             ProductCode = product.ProductCode
                                                         },
                                                         Quantity = itemQty
                                                         ,
                                                         FulfillmentLocationCode = "HomeBase",
                                                         FulfillmentMethod = "PickUp"
                                                     },
                                                     authTicket: ShopperAuth.AuthTicket);
            item = CartItemFactory.AddItemToCart(ShopperMsgHandler,
                                      new CartItem()
                                      {
                                          Product = new Product
                                          {
                                              ProductCode = product.ProductCode
                                          },
                                          Quantity = itemQty
                                          ,
                                          FulfillmentLocationCode = "HomeBase",
                                          FulfillmentMethod = "Ship"
                                      },
                                      authTicket: ShopperAuth.AuthTicket);

            var getUserCart = CartFactory.GetUserCart(handler: ShopperMsgHandler, userId: createdCart.UserId);

            var order = OrderFactory.CreateOrderFromCart(handler: ShopperMsgHandler, cartId: createdCart.Id,
                                                         authTicket: ShopperAuth.AuthTicket);
            var shippingContact = Generator.GenerateContactRealAddress(isValidated: true);


            var shippingAddressInfo = FulfillmentActionFactory.SetFulFillmentInfo(handler: ShopperMsgHandler,
                                                                                orderId: order.Id,
                                                                                fulfillmentInfo: new FulfillmentInfo()
                                                                                {

                                                                                    IsDestinationCommercial = false,
                                                                                    FulfillmentContact =
                                                                                        shippingContact,
                                                                                },
                                                                                authTicket: ShopperAuth.AuthTicket);

            var billingContact = Generator.GenerateContactRealAddress();
            var discover = new AuthorizeDotNetCreditCard(Constant.DISCOVER);
            var card = Generator.GenerateDefaultCard(sendPart: discover.SendPart,
                                                     paymentServiceCardId: Generator.RandomInt32().ToString(),
                                                     type: Constant.DISCOVER);

            var billingAddress = BillingInfoFactory.SetBillingInfo(handler: ShopperMsgHandler, orderId: order.Id,
                                                                   billingInfo: new BillingInfo()
                                                                   {
                                                                       PaymentType = "CreditCard",
                                                                       BillingContact = billingContact,
                                                                       IsSameBillingShippingAddress = true,
                                                                       Card = card
                                                                   });

            System.Threading.Thread.Sleep(200);
            var availableShippingMethods = ShipmentFactory.GetAvailableShipmentMethods(handler: ShopperMsgHandler,
                                                                                       orderId: order.Id,
                                                                                       authTicket:
                                                                                           ShopperAuth.AuthTicket);
            var shipping = FulfillmentActionFactory.SetFulFillmentInfo(handler: ShopperMsgHandler, orderId: order.Id,
                                                                     fulfillmentInfo: new FulfillmentInfo()
                                                                     {

                                                                         IsDestinationCommercial = false,
                                                                         FulfillmentContact = shippingContact,
                                                                         ShippingMethodCode =
                                                                             availableShippingMethods.First()
                                                                                                     .ShippingMethodCode,
                                                                         ShippingMethodName =
                                                                             availableShippingMethods.First()
                                                                                                     .ShippingMethodName
                                                                     },
                                                                     authTicket: ShopperAuth.AuthTicket);

            var getOrder = OrderFactory.GetOrder(handler: ShopperMsgHandler,
                                                 orderId: order.Id,
                                                 authTicket: ShopperAuth.AuthTicket,
                                                 draft: false);

            var getOrderActions = OrderFactory.GetAvailableActions(handler: ShopperMsgHandler, orderId: getOrder.Id,
                                                                   authTicket: ShopperAuth.AuthTicket);
            Assert.AreEqual(getOrderActions.Count, 1);
            Assert.IsTrue(getOrderActions[0].Equals("SubmitOrder"));

            var status = OrderFactory.PerformOrderAction(handler: ShopperMsgHandler, orderId: getOrder.Id, action:
                                                                                                               new OrderAction
                                                                                                               ()
                                                                                                               {
                                                                                                                   ActionName
                                                                                                                       =
                                                                                                                       "SubmitOrder"
                                                                                                               },
                                                         authTicket: ShopperAuth.AuthTicket);

            getOrder = OrderFactory.GetOrder(handler: ShopperMsgHandler,
                                             orderId: order.Id, authTicket:
                                                                    ShopperAuth.AuthTicket,
                                             draft: false);

            Assert.AreEqual(getOrder.Payments[0].AvailableActions.Count, 1);
            Assert.IsTrue(getOrder.Payments[0].AvailableActions[0].Contains("CreditPayment") || getOrder.Payments[0].AvailableActions[1].Contains("CreditPayment") || getOrder.Payments[0].AvailableActions[2].Contains("CreditPayment"));
            var creditPayment = PaymentFactory.PerformPaymentAction(handler: ShopperMsgHandler,
                                                                    orderId: getOrder.Id,
                                                                    paymentId: getOrder.Payments[0].Id,
                                                                    action: Generator.GeneratePaymentAction("CreditPayment",
                                                                      "", Convert.ToDecimal(getOrder.Total), getOrder.Payments[0].Id));

            Assert.AreEqual(creditPayment.Payments[0].AmountCredited, creditPayment.Total);

            //var createdCard = CardFactory.Create(ApiMsgHandler, card);

            var paymentAction = Generator.GeneratePaymentAction(action: "AuthorizePayment",
                amt: Convert.ToDecimal(order.Total),
                state: "TX",
                zip: "78717",
                card: card,
                savePart: discover.SavePart,
                manualInteraction: Generator.GeneratePaymentGatewayInteraction());

            var createdPaymentAction = PaymentFactory.CreatePaymentAction(handler: ShopperMsgHandler,
                                                                          orderId: order.Id,
                                                                          action: paymentAction,
                                                                          authTicket: ShopperAuth.AuthTicket,
                                                                          expectedCode: HttpStatusCode.OK,
                                                                          successCode: HttpStatusCode.OK);
            Assert.AreEqual(createdPaymentAction.Payments.Count, 2);
            Assert.AreEqual(createdPaymentAction.Payments[1].Status, "Authorized");
            Assert.AreEqual(createdPaymentAction.Payments[1].AmountCollected, 0);
            Assert.AreEqual(createdPaymentAction.Payments[1].Interactions.Count, 1);
            Assert.AreEqual(createdPaymentAction.Payments[1].Interactions[0].Status, "Authorized");
            Assert.IsTrue(createdPaymentAction.Payments[1].Interactions[0].IsManual);
            Assert.AreEqual(createdPaymentAction.PaymentStatus, "Pending");
            Assert.AreEqual(createdPaymentAction.Status, "Processing");
            paymentAction = Generator.GeneratePaymentAction(action: "CapturePayment",
                amt: Convert.ToDecimal(order.Total),
                state: "TX",
                zip: "78717",
                card: card,
                savePart: discover.SavePart,
                manualInteraction: Generator.GeneratePaymentGatewayInteraction());
            var capturePayment = PaymentFactory.PerformPaymentAction(handler: ShopperMsgHandler,
                orderId: getOrder.Id, paymentId: createdPaymentAction.Payments[1].Id, action: paymentAction);
            Assert.AreEqual(capturePayment.Payments[1].Status, "Collected");
            Assert.AreEqual(capturePayment.Payments[1].AmountCollected, capturePayment.Total);
            Assert.AreEqual(capturePayment.Payments[1].Interactions.Count, 2);
            Assert.AreEqual(capturePayment.Payments[1].Interactions[1].Status, "Captured");
            Assert.IsTrue(capturePayment.Payments[1].Interactions[1].IsManual);
            Assert.AreEqual(capturePayment.PaymentStatus, "Paid");
        }


        [TestMethod]
        [TestCategory("Mozu SDK Sample")]
        [Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [Description("Get Order.")]
        public void OrderTests_Test6()
        {
            var order = OrderFactory.GetOrder(ApiMsgHandler,"03c8fa4221f6630f5c6a7c2400000891");
        }


    }
}
