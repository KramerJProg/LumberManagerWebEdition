using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LumberManagerWebEdition.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        /// <summary>
        /// The height of the lumber. ex 2 inches
        /// </summary>
        [Required]
        public byte Height { get; set; }

        /// <summary>
        /// The width of the lumber. ex 4 inches
        /// </summary>
        [Required]
        public byte Width { get; set; }

        /// <summary>
        /// The length of the lumber ex 8 foot
        /// </summary>
        [Required]
        public byte Length { get; set; }

        /// <summary>
        /// The total board footage of a unit
        /// </summary>
        [Required]
        public int BoardFeet { get; set; }

        /// <summary>
        /// The amount in the inventory. Default is zero
        /// </summary>
        public short OnHand { get; set; } = 0;

        /// <summary>
        /// The amount of units sold. Default is zero
        /// </summary>
        public short Sold { get; set; } = 0;

        /// <summary>
        /// If the product is not for sale then it is not shown on the products page
        /// </summary>
        public bool IsForSale { get; set; } = true;

        public override string ToString()
        {
            return Height + " x " + Width + " x " + Length + " In Stock " + OnHand + " Sold " + Sold + " " + String.Join(" ", Category);
        }

        /// <summary>
        /// A ToString() method to be displayed on orders.
        /// </summary>
        public string OrderDisplayString()
        {
            if (Category[1].CategoryName == "N/A")
            {
                return $"{Height} x {Width} x {Length} White Wood";
            }
            else
            {
                return Height + " x " + Width + " x " + Length + " " + String.Join(" ", Category);
            }  
        }

        public List<Category> Category { get; set; } = new List<Category>();

        public virtual List<OrderLineItems> OrderLineItems { get; set; } = new List<OrderLineItems>();

    }
}
