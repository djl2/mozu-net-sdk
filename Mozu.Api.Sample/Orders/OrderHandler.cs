using System;
using System.Windows.Forms;
using Mozu.Api.Contracts.CommerceRuntime.Orders;
using Mozu.Api.Resources.Commerce;

namespace Mozu.Api.Sample.OrderHandler
{
    public partial class Orders : Form
    {
        private ApiContext _apiContext;
        public Orders(ApiContext apiContext)
        {
            InitializeComponent();
            _apiContext = apiContext;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var orderResource = new OrderResource(_apiContext);
            OrderCollection orders = orderResource.GetOrders();

            string orderInfo;

            foreach (Order order in orders.Items)
            {
                orderInfo = "Order ID: " + order.Id + " - Order Total: " + order.Total;
                ordersList.Items.Add(orderInfo);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
