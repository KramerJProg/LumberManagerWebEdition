using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumberManagerWebEdition.Models
{
    /// <summary>
    /// The information to be stored in the Cookie.
    /// </summary>
    public class ProductCookieHelper
    {
        public int ProductID { get; set; }

        public byte Quantity { get; set; }
    }
}
