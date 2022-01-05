using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LumberManagerWebEdition.Data;
using LumberManagerWebEdition.Models;
using Microsoft.AspNetCore.Authorization;
using static Humanizer.In;
using Microsoft.AspNetCore.Http;
using System.Net;
using Nancy.Json;

namespace LumberManagerWebEdition.Controllers
{
    /// <summary>
    /// Controller that allows Add, Edit, Delete products to Database.
    /// </summary>
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public ProductsController(ApplicationDbContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }

        /// <summary>
        /// Displays the list of products in the database. 
        /// </summary>
        /// <param name="id">Product ID.</param>
        /// <param name="height">Height of a product.</param>
        /// <param name="width">Width of a product.</param>
        /// <param name="length">Length of a product.</param>
        /// <param name="category">Category of a product.</param>
        /// <param name="treatmentType">Treatment type of a product.</param>
        public async Task<IActionResult> Index(int? id, byte? height, byte? width, byte? length, string category, string treatmentType)
        {
            int pageNum = id ?? 1;
            const int PageSize = 20;
            ViewData["CurrentPage"] = pageNum;

            List<byte> listHeight = await ProductDb.GetHeightAsync(_context);

            // Getting values for filtered drop down boxes.
            var filterLists = await GetFilteredValues(height, width, length, category);

            // Getting products based off filter preferences.
            var filterProducts = await GetFilteredProducts(PageSize, pageNum, height, width, length, category, treatmentType);
            
            List<ProductCookieHelper> cartProducts = CookieHelper.GetCartProducts(_httpContext);

            ViewData["CartProducts"] = cartProducts;

            ViewData["Height"] = height;

            ViewData["Width"] = width;

            ViewData["Length"] = length;

            ViewData["Category"] = category;

            ViewData["Type"] = treatmentType;

            ViewData["ListHeight"] = listHeight;

            ViewData["ListWidth"] = filterLists.listWidth;

            ViewData["ListLength"] = filterLists.listLength;

            ViewData["ListCategory"] = filterLists.listCategory;

            ViewData["ListType"] = filterLists.listType;

            int totalPages = (int)Math.Ceiling((double)filterProducts.numProducts / PageSize);

            ViewData["MaxPage"] = totalPages;

            return View(filterProducts.products);
        }

        /// <summary>
        /// Grabs filter values based on previous filter data
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        private async Task<(List<byte> listWidth, List<byte> listLength, List<Category> listCategory, List<Category> listType)> GetFilteredValues(byte? height, byte? width, byte? length, string category)
        {
            List<byte> listWidth = new List<byte>();
            List<byte> listLength = new List<byte>();
            List<Category> listCategory = new List<Category>();
            List<Category> listType = new List<Category>();
            if (height != null)
            {
                listWidth = await ProductDb.GetWidthAsync(_context, (byte)height);
                if (width != null)
                {
                    listLength = await ProductDb.GetLengthAsync(_context, (byte)height, (byte)width);
                    if (length != null)
                    {
                        listCategory = await CategoryDb.GetCategoryAsync(_context, (byte)height, (byte)width, (byte)length);
                        if (category != null)
                        {
                            listType = await CategoryDb.GetTypeAsync(_context, (byte)height, (byte)width, (byte)length, category);
                        }
                    }
                }
            }
            return (listWidth, listLength, listCategory, listType);
        }

        /// <summary>
        /// Grabs products based on filter data and page number and page size
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="pageNum"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <param name="category"></param>
        /// <param name="treatmentType"></param>
        /// <returns></returns>
        private async Task<(List<Product> products, int numProducts)> GetFilteredProducts(int PageSize, int pageNum, byte? height, byte? width, byte? length, 
                                                                                                            string category, string treatmentType)
        {
            int numProducts;
            List<Product> products;
            if (height != null && width != null && length != null && category != null && treatmentType != null)
            {
                products = await ProductDb.GetAllProductsAsync(_context, PageSize, pageNum, (byte)height, (byte)width, (byte)length, category, treatmentType);
                numProducts = await ProductDb.GetTotalProductsAsync(_context, (byte)height, (byte)width, (byte)length, category, treatmentType);
            }
            else if (height != null && width != null && length != null && category != null)
            {
                products = await ProductDb.GetAllProductsAsync(_context, PageSize, pageNum, (byte)height, (byte)width, (byte)length, category);
                numProducts = await ProductDb.GetTotalProductsAsync(_context, (byte)height, (byte)width, (byte)length, category);
            }
            else if (height != null && width != null & length != null)
            {
                products = await ProductDb.GetAllProductsAsync(_context, PageSize, pageNum, (byte)height, (byte)width, (byte)length);
                numProducts = await ProductDb.GetTotalProductsAsync(_context, (byte)height, (byte)width, (byte)length);
            }
            else if (height != null && width != null)
            {
                products = await ProductDb.GetAllProductsAsync(_context, PageSize, pageNum, (byte)height, (byte)width);
                numProducts = await ProductDb.GetTotalProductsAsync(_context, (byte)height, (byte)width);
            }
            else if (height != null)
            {
                products = await ProductDb.GetAllProductsAsync(_context, PageSize, pageNum, (byte)height);
                numProducts = await ProductDb.GetTotalProductsAsync(_context, (byte)height);
            }
            else
            {
                products = await ProductDb.GetAllProductsAsync(_context, PageSize, pageNum);
                numProducts = await ProductDb.GetTotalProductsAsync(_context);
            }
            return (products, numProducts);
        }

        /// <summary>
        /// GET : Adds a product to the database.
        /// </summary>
        [Authorize(Roles = IdentityHelper.Admin)]
        [HttpGet]
        public IActionResult Create()
        {
            CreateProductViewModel createProductViewModel = new CreateProductViewModel();
            Category category1 = new Category() { CategoryID = 1, CategoryName = "WW" };
            Category category2 = new Category() { CategoryID = 2, CategoryName = ".25" };
            Category category3 = new Category() { CategoryID = 3, CategoryName = ".40" };
            Category category4 = new Category() { CategoryID = 4, CategoryName = ".60" };
            Category category5 = new Category() { CategoryID = 5, CategoryName = "ACQ" };
            Category category6 = new Category() { CategoryID = 6, CategoryName = "CCA" };
            createProductViewModel.Categories.Add(category1);
            createProductViewModel.Categories.Add(category2);
            createProductViewModel.Categories.Add(category3);
            createProductViewModel.Categories.Add(category4);
            createProductViewModel.Categories.Add(category5);
            createProductViewModel.Categories.Add(category6);
            return View(createProductViewModel);
        }

        /// <summary>
        /// POST : for Create // Adds product to database.
        /// </summary>
        /// <param name="createProductViewModel"></param>
        [Authorize(Roles = IdentityHelper.Admin)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProductViewModel createProductViewModel)
        {
            if (ModelState.IsValid)
            {
                bool wwSelected = (Request.Form["ww"] == "WW") ? true : false;
                bool twoFiveSelected = (Request.Form[".25"] == ".25") ? true : false;
                bool four0Selected = (Request.Form[".40"] == ".40") ? true : false;
                bool six0Selected = (Request.Form[".60"] == ".60") ? true : false;
                bool acqSelected = (Request.Form["acq"] == "ACQ") ? true : false;
                bool ccaSelected = (Request.Form["cca"] == "CCA") ? true : false;

                // Checking which checkboxes are checked to set category and treatment type.
                if (wwSelected)
                {
                    createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 1));
                    createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 7));
                }
                else
                {
                    if (twoFiveSelected && acqSelected)
                    {
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 2));
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 5));
                    }
                    else if (twoFiveSelected && ccaSelected)
                    {
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 2));
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 6));
                    }
                    else if (four0Selected && acqSelected)
                    {
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 3));
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 5));
                    }
                    else if (four0Selected && ccaSelected)
                    {
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 3));
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 6));
                    }
                    else if (six0Selected && acqSelected)
                    {
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 4));
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 5));
                    }
                    else if (six0Selected && ccaSelected)
                    {
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 4));
                        createProductViewModel.Product.Category.Add(CategoryDb.GetCategory(_context, 6));
                    }
                }

                // Checking to make sure that the product is NOT in the database.
                if (!(ProductDb.CheckForExistingProduct(_context, createProductViewModel.Product)))
                {
                    await ProductDb.AddProductAsync(_context, createProductViewModel.Product);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    Product product = ProductDb.GetProduct(_context, createProductViewModel.Product);
                    
                    if (product != null && !product.IsForSale)
                    {
                        product.IsForSale = true;
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        TempData["Message"] = "Product not added. Product already in database.";
                    }
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(createProductViewModel);
        }

        /// <summary>
        /// GET : Edits/Updates product in the database.
        /// </summary>
        /// <param name="id">ID of product.</param>
        [Authorize(Roles = IdentityHelper.Admin)]
        public IActionResult UpdateInventory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = ProductDb.GetProduct(_context, id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        /// <summary>
        /// POST : Edits/Updates product in the database.
        /// </summary>
        /// <param name="id">ID of product.</param>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        [Authorize(Roles = IdentityHelper.Admin)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateInventory(int id, Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await ProductDb.UpdateAsync(_context, product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        /// <summary>
        /// GET : Loads the delete page with the product ID.
        /// </summary>
        /// <param name="id">Product ID</param>
        [Authorize(Roles = IdentityHelper.Admin)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        /// <summary>
        /// POST : Deletes the product.
        /// </summary>
        /// <param name="id">Product ID.</param>
        /// <returns></returns>
        [Authorize(Roles = IdentityHelper.Admin)]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            product.IsForSale = false;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }
    }
}
