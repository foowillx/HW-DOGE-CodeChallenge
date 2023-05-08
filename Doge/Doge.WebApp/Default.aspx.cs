using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Doge.Model;
using Doge.Orders;

namespace Doge.WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service1 client = new Service1();
            List<Orders.Order> orders = client.GetOrders();
            string ordersHtml = "<div class='order-wrapper'>";
            foreach (var order in orders)
            {
                ordersHtml += "<div class='order-container bgc-white'><div class='order-id'><h3>ORD-" + order.OrderId + "</h3></div>";
                if(order.RequiredShippedTimestamp < DateTime.Now)
                {
                    ordersHtml += "<div class='order-status'><span class ='order-status-delayed text-danger-m3'>Delayed</span></div>";
                }
                else
                {
                    ordersHtml += "<div class='order-status'><span class ='order-status-delayed text-green-d1'>On Time</span></div>";
                }
                ordersHtml += "<div class='order-address'><span>" + order.ShipmentAddress + "</span></div></div>";
            }
            ordersHtml += "</div>";

            // Asigna la cadena HTML al div.
            ordersDiv.InnerHtml = ordersHtml;
        }
    }
}