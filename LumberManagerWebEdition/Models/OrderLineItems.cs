using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LumberManagerWebEdition.Models
{
    public class OrderLineItems
    {
        [Key]
        public int OrderID { get; set; }

        [Key]
        public int ProductID { get; set; }

        /// <summary>
        /// The number of products that is displayed.
        /// </summary>
        [Required]
        public short Quantity { get; set; }

        public double PricePer1000BoardFeet { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
