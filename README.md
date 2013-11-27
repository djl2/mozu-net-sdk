Mozu-NET-SDK
============

Mozu - .NET Sample Application

The .NET application is a simple Windows Form example that demonstrates how to authenticate and how to retrieve orders and products from a Mozu developmet store.  Follow these steps to get the application up & running:

In Mozu Development Center:
1.	Login to the development center.
2.	Create a development store
3.	  Documentation on creating a store: http://developer.mozu.com/article/getting-started-development-stores
4.	Populate the store with some initial products and orders
5.	Create an application of type Extension: 
6.	  Documentation on creating an app: http://developer.mozu.com/article/getting-started-applications
7.	  The sample app requires the Behaviors of “Order Read” and “Product Read”
8.	Install the application into your Mozu development store


In Microsoft Visual Studio
  Open Mozu.Api.sln file
  Build and Run the Sample app solution
  On the sample app UI (shown below), select the “Sandbox” environment
  Enter the application ID and Shared Secret (from Dev Center)
  After authentication, you’ll be able to launch UI’s for retrieving products and orders
