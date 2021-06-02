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

namespace LumberManagerWebEdition.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public ProductsController(ApplicationDbContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }

        // GET: Products
        public async Task<IActionResult> Index(int? id, byte? height, byte? width, byte? length, string category, string treatmentType)
        {
            int pageNum = id ?? 1;
            const int PageSize = 10;
            ViewData["CurrentPage"] = pageNum;

            List<byte> listHeight = await ProductDb.GetHeightAsync(_context);
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

            List<Product> products;
            int numProducts;

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

            List<ProductCookieHelper> cartProducts = CookieHelper.GetCartProducts(_httpContext);

            ViewData["CartProducts"] = cartProducts;

            ViewData["Height"] = height;

            ViewData["Width"] = width;

            ViewData["Length"] = length;

            ViewData["Category"] = category;

            ViewData["Type"] = treatmentType;

            ViewData["ListHeight"] = listHeight;

            ViewData["ListWidth"] = listWidth;

            ViewData["ListLength"] = listLength;

            ViewData["ListCategory"] = listCategory;

            ViewData["ListType"] = listType;

            

            int totalPages = (int)Math.Ceiling((double)numProducts / PageSize);

            ViewData["MaxPage"] = totalPages;

            return View(products);
        }

        // GET: Products/Create
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

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
                if (!(ProductDb.CheckForExistingProduct(_context, createProductViewModel.Product)))
                {
                    await ProductDb.AddProductAsync(_context, createProductViewModel.Product);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["Message"] = "Product not added. Product already in database.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(createProductViewModel);
        }

        // GET: Products/Edit/5
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

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
                    await ProductDb.Update(_context, product);
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

        // GET: Products/Delete/5
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

        // POST: Products/Delete/5
        [Authorize(Roles = IdentityHelper.Admin)]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }
    }
}
