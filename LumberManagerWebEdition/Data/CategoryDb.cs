using LumberManagerWebEdition.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumberManagerWebEdition.Data
{
    /// <summary>
    /// Accessing categories in the database.
    /// </summary>
    public class CategoryDb
    {
        /// <summary>
        /// Grabs a single category.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="id">Category ID.</param>
        /// <returns></returns>
        public static Category GetCategory(ApplicationDbContext _context, int id)
        {
            Category category = (from c in _context.Categories
                                 where c.CategoryID == id
                                 select c).Single();
            return category;
        }

        /// <summary>
        /// Grabs category based off product.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="height">Height of product.</param>
        /// <param name="width">Width of product.</param>
        /// <param name="length">Length of product.</param>
        public static async Task<List<Category>> GetCategoryAsync(ApplicationDbContext _context, byte height, byte width, byte length)
        {
            List<Product> products = await (from p in _context.Products
                                            where p.Height == height && p.Width == width && p.Length == length
                                            select p).Include(nameof(Product.Category)).ToListAsync();

            return (from p in products
                    select p.Category[0]).Distinct().ToList();
        }

        /// <summary>
        /// Grabs Treatment type based off product.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="height">Height of product.</param>
        /// <param name="width">Width of product.</param>
        /// <param name="length">Length of product.</param>
        /// <param name="category">Category of a product.</param>
        public static async Task<List<Category>> GetTypeAsync(ApplicationDbContext _context, byte height, byte width, byte length, string category)
        {
            List<Product> products = await (from p in _context.Products
                                            where p.Height == height && p.Width == width && p.Length == length
                                            select p).Include(nameof(Product.Category)).ToListAsync();

            List<Category> categories = new List<Category>();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Category[0].CategoryName == category)
                {
                    categories.Add(products[i].Category[1]);
                }
            }
            return categories;
        }
    }
}
