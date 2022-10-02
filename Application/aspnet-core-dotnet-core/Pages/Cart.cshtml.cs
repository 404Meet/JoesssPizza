using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Xml.Linq;
using aspnet_core_dotnet_core.Pages;
using System.Reflection;
using System.Collections.Generic;
    namespace aspnet_core_dotnet_core.Pages
{
    public class CartModel : PageModel
    {
        public int quan { get; set; }
        public PizzaModel p = new PizzaModel();
        
        
        public void OnGet()
        {
            p.OnGet(); 
        }
        public int Add()
        {
            p.OnGet();
            quan++;
            return quan;

        }
        public int Sub()
        {
            p.OnGet();
            quan--;
            return quan;
        }
    }
}
