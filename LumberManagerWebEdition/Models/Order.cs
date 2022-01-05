using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LumberManagerWebEdition.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        /// <summary>
        /// The date the order was placed.
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// The Business to ship to
        /// </summary>
        public string ShipBusiness { get; set; }

        /// <summary>
        /// The first name of the contact for shipping
        /// </summary>
        public string ShipContactFirstName { get; set; }

        /// <summary>
        /// The last name of the contact for shipping
        /// </summary>
        public string ShipContactLastName { get; set; }

        /// <summary>
        /// The date the order has shipped. (nullable)
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime ShipDate { get; set; }

        /// <summary>
        /// The Shipping Address
        /// </summary>
        public string ShipAddress { get; set; }

        /// <summary>
        /// The city to ship to
        /// </summary>
        public string ShipCity { get; set; }

        /// <summary>
        /// The state to ship to
        /// </summary>
        public string ShipState { get; set; }

        /// <summary>
        /// The zip code to ship to
        /// </summary>
        public string ShipZipCode { get; set; }

        public virtual List<OrderLineItems> OrderLineItems { get; set; } = new List<OrderLineItems>();

        public List<User> Customers { get; set; } = new List<User>();

        public Order()
        {
            this.InvoiceDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Order number: {OrderID}";
        }
    }
}
