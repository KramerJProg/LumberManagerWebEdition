using LumberManagerWebEdition.Data;
using LumberManagerWebEdition.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace LumberManagerWebEdition.Controllers
{
    /// <summary>
    /// A controller for the cart.
    /// Adding and changing quantities of products in the cart.
    /// </summary>
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpcontext;
        private readonly UserManager<User> _userManager;

        private const double PricePer1000 = 1100.0;

        public CartController(ApplicationDbContext context, IHttpContextAccessor httpContext, UserManager<User> userManager)
        {
            
            _context = context;
            _httpcontext = httpContext;
            _userManager = userManager;
        }

        /// <summary>
        /// Adds a product to the cart.
        /// </summary>
        /// <param name="id">Product ID to be added.</param>
        /// <param name="previousUrl">Redirect to where user was.</param>
        /// <param name="inputquantity">Amount of product to be added to cart.</param>
        public IActionResult Add(int id, string previousUrl, byte inputquantity, int? scrollY)
        {
            Product p = ProductDb.GetProduct(_context, id);

            if (inputquantity > 0)
            {
                CookieHelper.AddProductToCart(_httpcontext, p, inputquantity);
                TempData["Message"] = p.Height + " x " + p.Width + " x " + p.Length + " " + p.Category[0] + " " + p.Category[1] + " was added successfully.";
            }
            else
            {
                bool isTrue = CookieHelper.CheckForExistingProduct(_httpcontext, id);
                CookieHelper.DeleteCartProducts(_httpcontext, id);

                if (isTrue)
                {
                    TempData["Message"] = p.Height + " x " + p.Width + " x " + p.Length + " " + p.Category[0] + " " + p.Category[1] + " was removed.";
                }
            }
            if (scrollY != null)
            {
                TempData["YPosition"] = scrollY;
            }
            else
            {
                TempData["YPosition"] = 0;
            }

            return Redirect(previousUrl);
        }

        /// <summary>
        /// View that shows the products in the cart.
        /// </summary>
        public IActionResult Summary()
        {
            List<ProductCookieHelper> cartProducts = CookieHelper.GetCartProducts(_httpcontext);
            List<Product> products = new List<Product>();
            List<int> quantity = new List<int>();
            for (int i = 0; i < cartProducts.Count; i++)
            {
                products.Add(ProductDb.GetProduct(_context, cartProducts[i].ProductID));
                quantity.Add(cartProducts[i].Quantity);
            }
            ViewData["Quantity"] = quantity;
            return View(products);
        }

        /// <summary>
        /// The confirmation page that is shown before order is submitted
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Confirm()
        {
            string currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            User user = await _userManager.FindByIdAsync(currentUserId);

            CreateOrderViewModel model = new CreateOrderViewModel();
            model.User = user;

            List<ProductCookieHelper> cartProducts = CookieHelper.GetCartProducts(_httpcontext);
            List<Product> products = new List<Product>();
            List<int> quantity = new List<int>();
            for (int i = 0; i < cartProducts.Count; i++)
            {
                products.Add(ProductDb.GetProduct(_context, cartProducts[i].ProductID));
                quantity.Add(cartProducts[i].Quantity);
            }

            double boardFeet = 0.0;

            for (int i = 0; i < products.Count; i++)
            {
                boardFeet += products[i].BoardFeet * quantity[i];
            }

            double totalPrice = boardFeet / 1000 * PricePer1000;

            int totalProducts = CookieHelper.GetTotalCartProducts(_httpcontext);

            ViewData["Cart"] = totalProducts;
            ViewData["Total Price"] = totalPrice; 
            return View(model);
        }

        /// <summary>
        /// Creates an order
        /// </summary>
        /// <param name="model"></param>
        [HttpPost]
        public async Task<IActionResult> Confirm(CreateOrderViewModel model)
        {
            string currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            User user = await _userManager.FindByIdAsync(currentUserId);

            List<ProductCookieHelper> cartProducts = CookieHelper.GetCartProducts(_httpcontext);
            CookieHelper.DeleteCookie(_httpcontext);
            List<Product> products = new List<Product>();
            List<short> quantity = new List<short>();
            GetCartProducts(cartProducts, products, quantity);

            OrderLineItems orderLineItem = new OrderLineItems();
            Order newOrder = CreateOrder(model, user);
            await CreateLineItems(products, quantity, orderLineItem, newOrder);

            return RedirectToAction("Submit");
        }

        /// <summary>
        /// Gets the cart products and puts them in lists.
        /// </summary>
        /// <param name="cartProducts"></param>
        /// <param name="products"></param>
        /// <param name="quantity"></param>
        private void GetCartProducts(List<ProductCookieHelper> cartProducts, List<Product> products, List<short> quantity)
        {
            for (int i = 0; i < cartProducts.Count; i++)
            {
                products.Add(ProductDb.GetProduct(_context, cartProducts[i].ProductID));
                quantity.Add(cartProducts[i].Quantity);
            }
        }

        /// <summary>
        /// Adding line items to the database.
        /// </summary>
        /// <param name="products"></param>
        /// <param name="quantity"></param>
        /// <param name="orderLineItem"></param>
        /// <param name="newOrder"></param>
        private async Task CreateLineItems(List<Product> products, List<short> quantity, OrderLineItems orderLineItem, Order newOrder)
        {
            for (int i = 0; i < products.Count; i++)
            {
                orderLineItem.OrderID = newOrder.OrderID;
                orderLineItem.ProductID = products[i].ProductID;
                orderLineItem.Quantity = quantity[i];
                orderLineItem.PricePer1000BoardFeet = PricePer1000;
                OrderLineItemsDB.AddOrderLineItem(_context, orderLineItem);

                products[i].Sold += quantity[i];
                await ProductDb.UpdateAsync(_context, products[i]);
            }
        }

        /// <summary>
        /// Creating an order.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        private Order CreateOrder(CreateOrderViewModel model, User user)
        {
            Order newOrder = new Order();
            newOrder.InvoiceDate = DateTime.Now;
            // Setting ship date in the past to make it invalid
            newOrder.ShipDate = DateTime.Now.AddDays(-14);
            newOrder.Customers.Add(user);

            newOrder.ShipBusiness = model.Order.ShipBusiness;
            newOrder.ShipContactFirstName = model.Order.ShipContactFirstName;
            newOrder.ShipContactLastName = model.Order.ShipContactLastName;
            newOrder.ShipAddress = model.Order.ShipAddress;
            newOrder.ShipCity = model.Order.ShipCity;
            newOrder.ShipState = model.Order.ShipState;
            newOrder.ShipZipCode = model.Order.ShipZipCode;

            OrderDB.AddOrder(_context, newOrder);
            return newOrder;
        }

        /// <summary>
        /// Creates an order based off of the cookie
        /// Once the order is created the cookie is deleted
        /// and the submit page is shown
        /// </summary>
        /// <returns></returns>
        public IActionResult Submit()
        {
            return View();
        }

        /// <summary>
        /// Deletes product from cart.
        /// </summary>
        /// <param name="id">Product ID.</param>
        /// <param name="previousUrl">Redirect to where user was.</param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            CookieHelper.DeleteCartProducts(_httpcontext, id);
            return RedirectToAction("Summary");
        }
    }
}
