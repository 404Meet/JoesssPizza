using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Xml.Linq;
using aspnet_core_dotnet_core.Pages;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace aspnet_core_dotnet_core.Pages
{
    public class CartModel : PageModel
    {
        //public PizzaModel p = new PizzaModel();

        //public List<CartModel> cart { get; set; }
        //public double Total { get; set; }

        //public void OnGet()
        //{
        //    p.OnGet();

        //    cart = SessionHelper.GetObjectFromJson<List<CartModel>>(HttpContext.Session, "cart");
        //    Total = cart.Sum(i => i.p.price * i.p.quantity);
        //}
        //public IActionResult OnGetBuyNow(int id)
        //    {
        //        var productModel = new PizzaModel.OnGet();
        //        return RedirectToPage("Cart");
        //    }
        //    public void OnPost(CartModel objj)
        //    {

        //    }



        public List<Item> cart { get; set; }
        public double Total { get; set; }

        public void OnGet()
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            Total = cart.Sum(i => i.Product.price * i.Quantity);
        }

        public IActionResult OnGetBuyNow(int id)
        {
            var productModel = new ProductModel();
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item
                {
                    Product = productModel.find(id),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        Product = productModel.find(id),
                        Quantity = 1
                    });
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToPage("Cart");
        }

        public IActionResult OnGetDelete(int id)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (var i = 0; i < cart.Count; i++)
            {
                cart[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }

        private int Exists(List<Item> cart, int id)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ID == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
