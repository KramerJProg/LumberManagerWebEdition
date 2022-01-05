using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumberManagerWebEdition.Models
{
    /// <summary>
    /// A class to instantiate a Cookie.
    /// </summary>
    public class CookieHelper
    {
        const string CartCookie = "CartCookie";

        /// <summary>
        /// Grabs all products stored in the Cookie.
        /// </summary>
        /// <param name="http"></param>
        /// <returns></returns>
        public static List<ProductCookieHelper> GetCartProducts(IHttpContextAccessor http)
        {
            string existingItems = http.HttpContext.Request.Cookies[CartCookie];

            List<ProductCookieHelper> cartProducts = new List<ProductCookieHelper>();

            if (existingItems != null)
            {
                cartProducts = JsonConvert.DeserializeObject<List<ProductCookieHelper>>(existingItems);
            }

            return cartProducts;
        }

        /// <summary>
        /// Adds product to the Cookie.
        /// </summary>
        /// <param name="http"></param>
        /// <param name="p">The product.</param>
        /// <param name="quantity">Amount of the product to add.</param>
        public static void AddProductToCart(IHttpContextAccessor http, Product p, byte quantity)
        {
            List<ProductCookieHelper> cartProducts = GetCartProducts(http);

            ProductCookieHelper product = new ProductCookieHelper();
            product.ProductID = p.ProductID;
            product.Quantity = quantity;

            for (int i = 0; i < cartProducts.Count; i++)
            {
                if (cartProducts[i].ProductID == product.ProductID && cartProducts[i].Quantity == quantity)
                {
                    return;
                }
                else if (cartProducts[i].ProductID == product.ProductID && cartProducts[i].Quantity != quantity)
                {
                    cartProducts = DeleteCartProducts(http, product.ProductID);
                }
            }

            cartProducts.Add(product);
            string data = JsonConvert.SerializeObject(cartProducts, new JsonSerializerSettings() 
            { 
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddYears(1),
                Secure = true,
                IsEssential = true
            };

            http.HttpContext.Response.Cookies.Append(CartCookie, data, options);
        }

        /// <summary>
        /// Sets the cookie expiration date to last year to delete the cookie
        /// </summary>
        public static void DeleteCookie(IHttpContextAccessor _http)
        {
            List<ProductCookieHelper> cartProducts = GetCartProducts(_http);
            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddYears(-1),
                Secure = true,
                IsEssential = true
            };

            string data = JsonConvert.SerializeObject(cartProducts, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            _http.HttpContext.Response.Cookies.Append(CartCookie, data, options);
        }

        /// <summary>
        /// Removes product form Cookie.
        /// </summary>
        /// <param name="http"></param>
        /// <param name="id">Product Id.</param>
        public static List<ProductCookieHelper> DeleteCartProducts(IHttpContextAccessor http, int id)
        {
            List<ProductCookieHelper> cartProducts = GetCartProducts(http);
            cartProducts = cartProducts.Where(p => p.ProductID != id).ToList();
            string data = JsonConvert.SerializeObject(cartProducts, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            http.HttpContext.Response.Cookies.Append(CartCookie, data);
            return cartProducts;
        }

        /// <summary>
        /// Grabs the quantity of all the products that are in the Cookie.
        /// </summary>
        /// <param name="http"></param>
        public static int GetTotalCartProducts(IHttpContextAccessor http)
        {
            List<ProductCookieHelper> cartProducts = GetCartProducts(http);

            int total = 0;
            foreach (ProductCookieHelper totalProducts in cartProducts)
            {
                total += totalProducts.Quantity;
            }

            return total;
        }

        public static bool CheckForExistingProduct(IHttpContextAccessor http, int id)
        {
            List<ProductCookieHelper> cartProducts = GetCartProducts(http);

            for (int i = 0; i < cartProducts.Count; i++)
            {
                if (cartProducts[i].ProductID == id && cartProducts[i].Quantity > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
