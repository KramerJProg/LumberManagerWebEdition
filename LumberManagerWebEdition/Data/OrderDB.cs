using LumberManagerWebEdition.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace LumberManagerWebEdition.Data
{
    public static class OrderDB
    {
        /// <summary>
        /// Adds order to the database
        /// </summary>
        /// <param name="o">The order to be added</param>
        public static void AddOrder(ApplicationDbContext _context, Order o)
        {
            _context.Orders.Add(o);
            _context.Customers.Attach(o.Customers[0]);
            _context.SaveChanges();
        }

        /// <summary>
        /// Gets a single order based on orderId
        /// returns null if not found
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public static Order GetOrder(ApplicationDbContext _context, int orderId)
        {
                Order order = (from o in _context.Orders
                               where o.OrderID == orderId
                               select o).Include(u => u.Customers).SingleOrDefault();
                return order; 
        }

        /// <summary>
        /// Updates an order
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="order">The order to be updated</param>
        /// <returns></returns>
        public static async Task UpdateOrderAsync(ApplicationDbContext _context, Order order)
        {
            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
