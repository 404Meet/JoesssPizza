using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace aspnet_core_dotnet_core.Pages
{
    public class CheckoutModel : PageModel
    {

        public List<Item> cart { get; set; }
        public double Total { get; set; }

        public void OnGet()
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            Total = cart.Sum(i => i.Product.price * i.Quantity);
        }
       
    }
}
