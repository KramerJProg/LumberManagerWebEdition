using LumberManagerWebEdition.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumberManagerWebEdition.Data
{
    public static class OrderLineItemsDB
    {
        /// <summary>
        /// Adds the line item to order
        /// </summary>
        /// <param name="orderLineItems">The line items to be added</param>
        public static void AddOrderLineItem(ApplicationDbContext _context, OrderLineItems orderLineItems)
        {
            _context.OrderLineItems.Add(orderLineItems);
            _context.SaveChanges();
        }

        public static List<OrderLineItems> GetOrderLineItems(ApplicationDbContext _context, int orderId)
        {
            List<OrderLineItems> orderLineItems = (from o in _context.OrderLineItems
                                                   where orderId == o.OrderID
                                                   select o).Include(o => o.Product).Include(p => p.Product.Category).ToList();
            return orderLineItems;
        }
    }
}
