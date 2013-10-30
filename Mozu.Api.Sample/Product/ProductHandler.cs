using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Mozu.Api;
using Mozu.Api.Contracts.ProductAdmin;
using Mozu.Api.Resources.Commerce.Catalog.Admin;
using Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition;
using Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition.Attributes;
using Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition.Producttypes;
using Mozu.Api.Resources.Platform;

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


            var productResource = new ProductResource(_apiContext);
            ProductCollection products = productResource.GetProducts();
            foreach (Product product in products.Items)
            {
                productList.Items.Add(product.ProductCode);
            }
            
            
            

        }
    }
}
