 using LumberManagerWebEdition.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumberManagerWebEdition.Data
{
    /// <summary>
    /// The class for getting products from the database.
    /// </summary>
    public static class ProductDb
    {
        /// <summary>
        /// Adds the product to the databse.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="p">The product.</param>
        public static async Task<Product> AddProductAsync(ApplicationDbContext _context, Product p)
        {
            // Adds to database
            _context.Products.Add(p);
            for (int i = 0; i < p.Category.Count; i++)
            {
                _context.Categories.Attach(p.Category[i]);
            }
            await _context.SaveChangesAsync();
            return p;
        }

        /// <summary>
        /// Grabs a product based off of id.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="id">Product ID.</param>
        public static Product GetProduct(ApplicationDbContext _context, int? id)
        {
            Product product = (from p in _context.Products
                               where p.ProductID == id
                               select p).Include(nameof(Product.Category)).Single();
            return product;
        }

        public static Product GetProduct(ApplicationDbContext _context, Product product)
        {
            List<Product> products = (from p in _context.Products
                    where p.Height == product.Height && p.Width == product.Width && p.Length == product.Length
                    select p).Include(nameof(Product.Category)).ToList();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Category[0].CategoryName == product.Category[0].CategoryName 
                    && products[i].Category[1].CategoryName == product.Category[1].CategoryName)
                {
                    return products[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Grabs 'x' amount of products based off of page size.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="pageSize">Number of products to grab.</param>
        /// <param name="pageNum">Page number that will be applied.</param>
        public static async Task<List<Product>> GetAllProductsAsync(ApplicationDbContext _context, int pageSize, int pageNum)
        {
            List<Product> products = await (from p in _context.Products
                                            where p.IsForSale == true
                                            select p).Include(nameof(Product.Category))
                                               .ToListAsync();
            products = products.OrderBy(p => p.Category[1].CategoryName)
                                       .ThenBy(p => p.Height)
                                       .ThenBy(p => p.Width)
                                       .ThenBy(p => p.Category[0].CategoryName)
                                       .ThenBy(p => p.Length)
                                       .Skip(pageSize * (pageNum - 1))
                                       .Take(pageSize)
                                       .ToList();
            return products;
        }

        /// <summary>
        /// Grabs product based off of Height, Width, Length, Category and Treatment Type.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="pageSize">Number of products to grab.</param>
        /// <param name="pageNum">Page number that will be applied.</param>
        /// <param name="height">Height of product.</param>
        /// <param name="width">Width of product.</param>
        /// <param name="length">Length of product.</param>
        /// <param name="category">Category of a product.</param>
        /// <param name="treatmentType">Treatment Type of a product.</param>
        public static async Task<List<Product>> GetAllProductsAsync(ApplicationDbContext _context, int pageSize, int pageNum, byte height,
                                                                                                byte width, byte length, string category, string treatmentType)
        {
            List<Product> products = await (from p in _context.Products
                                            where p.Height == height && p.Width == width && p.Length == length && p.IsForSale == true
                                            select p).Include(nameof(Product.Category))
                                               .ToListAsync();
            products = products.OrderBy(p => p.Category[1].CategoryName)
                                       .ThenBy(p => p.Height)
                                       .ThenBy(p => p.Width)
                                       .ThenBy(p => p.Category[0].CategoryName)
                                       .ThenBy(p => p.Length)
                                       .Skip(pageSize * (pageNum - 1))
                                       .Take(pageSize)
                                       .ToList();

            List<Product> newProducts = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Category[0].CategoryName == category && products[i].Category[1].CategoryName == treatmentType)
                {
                    newProducts.Add(products[i]);
                }
            }
            return newProducts;
        }

        /// <summary>
        /// Grabs product based off of Height, Width, Length and Category.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="pageSize">Number of products to grab.</param>
        /// <param name="pageNum">Page number that will be applied.</param>
        /// <param name="height">Height of product.</param>
        /// <param name="width">Width of product.</param>
        /// <param name="length">Length of product.</param>
        /// <param name="category">Category of a product.</param>
        public static async Task<List<Product>> GetAllProductsAsync(ApplicationDbContext _context, int pageSize, int pageNum, byte height,
                                                                                                byte width, byte length, string category)
        {
            List<Product> products = await (from p in _context.Products
                                            where p.Height == height && p.Width == width && p.Length == length && p.IsForSale == true
                                            select p).Include(nameof(Product.Category))
                                               .ToListAsync();
            products = products.OrderBy(p => p.Category[1].CategoryName)
                                       .ThenBy(p => p.Height)
                                       .ThenBy(p => p.Width)
                                       .ThenBy(p => p.Category[0].CategoryName)
                                       .ThenBy(p => p.Length)
                                       .Skip(pageSize * (pageNum - 1))
                                       .Take(pageSize)
                                       .ToList();

            List<Product> newProducts = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Category[0].CategoryName == category)
                {
                    newProducts.Add(products[i]);
                }
            }
            return newProducts;
        }

        /// <summary>
        /// Grabs product based off of Height, Width and Length.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="pageSize">Number of products to grab.</param>
        /// <param name="pageNum">Page number that will be applied.</param>
        /// <param name="height">Height of product.</param>
        /// <param name="width">Width of product.</param>
        /// <param name="length">Category of a product.</param>
        /// <returns></returns>
        public static async Task<List<Product>> GetAllProductsAsync(ApplicationDbContext _context, int pageSize, int pageNum, byte height,
                                                                                                byte width, byte length)
        {
            List<Product> products = await (from p in _context.Products
                                            where p.Height == height && p.Width == width && p.Length == length && p.IsForSale == true
                                            select p).Include(nameof(Product.Category))
                                               .ToListAsync();
            products = products.OrderBy(p => p.Category[1].CategoryName)
                                       .ThenBy(p => p.Height)
                                       .ThenBy(p => p.Width)
                                       .ThenBy(p => p.Category[0].CategoryName)
                                       .ThenBy(p => p.Length)
                                       .Skip(pageSize * (pageNum - 1))
                                       .Take(pageSize)
                                       .ToList();
            return products;
        }

        /// <summary>
        /// Grabs product based off of Height and Width.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="pageSize">Number of products to grab.</param>
        /// <param name="pageNum">Page number that will be applied.</param>
        /// <param name="height">Height of product.</param>
        /// <param name="width">Width of product.</param>
        /// <returns></returns>
        public static async Task<List<Product>> GetAllProductsAsync(ApplicationDbContext _context, int pageSize, int pageNum, byte height,
                                                                                                byte width)
        {
            List<Product> products = await (from p in _context.Products
                                            where p.Height == height && p.Width == width && p.IsForSale == true
                                            select p).Include(nameof(Product.Category))
                                               .ToListAsync();
            products = products.OrderBy(p => p.Category[1].CategoryName)
                                       .ThenBy(p => p.Height)
                                       .ThenBy(p => p.Width)
                                       .ThenBy(p => p.Category[0].CategoryName)
                                       .ThenBy(p => p.Length)
                                       .Skip(pageSize * (pageNum - 1))
                                       .Take(pageSize)
                                       .ToList();
            return products;
        }

        /// <summary>
        /// Grabs product based off of Height.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="pageSize">Number of products to grab.</param>
        /// <param name="pageNum">Page number that will be applied.</param>
        /// <param name="height">Height of product.</param>
        /// <returns></returns>
        public static async Task<List<Product>> GetAllProductsAsync(ApplicationDbContext _context, int pageSize, int pageNum, byte height)
        {
            List<Product> products = await (from p in _context.Products
                                            where p.Height == height && p.IsForSale == true
                                            select p).Include(nameof(Product.Category))
                                               .ToListAsync();
            products = products.OrderBy(p => p.Category[1].CategoryName)
                                       .ThenBy(p => p.Height)
                                       .ThenBy(p => p.Width)
                                       .ThenBy(p => p.Category[0].CategoryName)
                                       .ThenBy(p => p.Length)
                                       .Skip(pageSize * (pageNum - 1))
                                       .Take(pageSize)
                                       .ToList();
            return products;
        }

        /// <summary>
        /// Change quantity of on hand product.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="p">The product.</param>
        /// <returns></returns>
        public static async Task<Product> UpdateAsync(ApplicationDbContext _context, Product p)
        {
            _context.Entry(p).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return p;
        }

        /// <summary>
        /// Pagination for total products.
        /// </summary>
        /// <param name="_context"></param>
        /// <returns></returns>
        public static async Task<int> GetTotalProductsAsync(ApplicationDbContext _context)
        {
            return await (from p in _context.Products
                          select p).CountAsync();
        }

        /// <summary>
        /// Pagination for total products with Height.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="height">Height of product.</param>
        /// <returns></returns>
        public static async Task<int> GetTotalProductsAsync(ApplicationDbContext _context, byte height)
        {
            return await (from p in _context.Products
                          where p.Height == height
                          select p).CountAsync();
        }

        /// <summary>
        /// Pagination for total products with Height and Width.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="height">Height of product.</param>
        /// <param name="width">Width of product.</param>
        /// <returns></returns>
        public static async Task<int> GetTotalProductsAsync(ApplicationDbContext _context, byte height, byte width)
        {
            return await (from p in _context.Products
                          where p.Height == height && p.Width == width
                          select p).CountAsync();
        }

        /// <summary>
        /// Pagination for total products with Height, Width and Length.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="height">Height of product.</param>
        /// <param name="width">Width of product.</param>
        /// <param name="length">Length of product.</param>
        /// <returns></returns>
        public static async Task<int> GetTotalProductsAsync(ApplicationDbContext _context, byte height, byte width, byte length)
        {
            return await (from p in _context.Products
                          where p.Height == height && p.Width == width && p.Length == length
                          select p).CountAsync();
        }

        /// <summary>
        /// Pagination for total products with Height, Width, Length and Category.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="height">Height of product.</param>
        /// <param name="width">Width of product.</param>
        /// <param name="length">Length of product.</param>
        /// <param name="category">Category of product.</param>
        /// <returns></returns>
        public static async Task<int> GetTotalProductsAsync(ApplicationDbContext _context, byte height, byte width, byte length, string category)
        {
            List<Product> products = await (from p in _context.Products
                                      where p.Height == height && p.Width == width && p.Length == length
                                      select p).Include(nameof(Product.Category)).ToListAsync();
            List<Product> newProducts = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Category[0].CategoryName == category)
                {
                    newProducts.Add(products[i]);
                }
            }
            return newProducts.Count;
        }

        /// <summary>
        /// Pagination for total products with Height, Width, Length, Category and Treatment Type.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="height">Height of product.</param>
        /// <param name="width">Width of product.</param>
        /// <param name="length">Length of product.</param>
        /// <param name="category">Category of product.</param>
        /// <param name="treatmentType">Treatment Type of product.</param>
        /// <returns></returns>
        public static async Task<int> GetTotalProductsAsync(ApplicationDbContext _context, byte height, byte width, byte length, string category, string treatmentType)
        {
            List<Product> products = await (from p in _context.Products
                                            where p.Height == height && p.Width == width && p.Length == length
                                            select p).Include(nameof(Product.Category)).ToListAsync();
            List<Product> newProducts = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Category[0].CategoryName == category && products[i].Category[1].CategoryName == treatmentType)
                {
                    newProducts.Add(products[i]);
                }
            }
            return newProducts.Count;
        }

        /// <summary>
        /// Checks to see if product exists in database.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="p">The product.</param>
        /// <returns></returns>
        public static bool CheckForExistingProduct(ApplicationDbContext _context, Product p)
        {
            List<Product> product = (from prod in _context.Products
                                     where prod.Height == p.Height
                                     && prod.Width == p.Width
                                     && prod.Length == p.Length
                                     select prod).Include(nameof(Product.Category)).ToList();
            for (int i = 0; i < product.Count; i++)
            {
                if (product[i].Category[0] == p.Category[0] && product[i].Category[1] == p.Category[1])
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets Height for filtering on Product index.
        /// </summary>
        /// <param name="_context"></param>
        /// <returns></returns>
        public static async Task<List<byte>> GetHeightAsync(ApplicationDbContext _context)
        {
            List<byte> height =  await (from p in _context.Products
                          select p.Height).Distinct().ToListAsync();
            return height;
        }

        /// <summary>
        /// Gets Width for filtering on Product index.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="height">Height of product.</param>
        /// <returns></returns>
        public static async Task<List<byte>> GetWidthAsync(ApplicationDbContext _context, byte height)
        {
            List<byte> width = await (from p in _context.Products
                                      where p.Height == height
                                      select p.Width).Distinct().ToListAsync();
            return width;
        }

        /// <summary>
        /// Gets Length for filtering on Product index.
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="height">Height of product.</param>
        /// <param name="width">Width of product.</param>
        /// <returns></returns>
        public static async Task<List<byte>> GetLengthAsync(ApplicationDbContext _context, byte height, byte width)
        {
            return await (from p in _context.Products
                          where p.Height == height && p.Width == width
                          select p.Length).Distinct().ToListAsync();
        }
    }
}
