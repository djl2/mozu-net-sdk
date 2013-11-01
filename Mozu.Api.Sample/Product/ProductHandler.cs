using System;
using System.Windows.Forms;
using Mozu.Api.Contracts.ProductAdmin;
using Mozu.Api.Resources.Commerce.Catalog.Admin;

namespace Mozu.Api.Sample.ProductHandler
{

    public partial class Home : Form
    {
        private ApiContext _apiContext;
        public Home(ApiContext apiContext)
        {
            InitializeComponent();
            _apiContext = apiContext;
        }

        private void getProductsBtn_Click(object sender, EventArgs e)
        {

            try
            {
                var productResource = new ProductResource(_apiContext);
                ProductCollection products = productResource.GetProducts();
                foreach (Product product in products.Items)
                {
                    productList.Items.Add(product.ProductCode);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
            
            

        }
    }
}
