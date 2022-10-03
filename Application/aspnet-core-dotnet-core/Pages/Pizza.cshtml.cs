using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace aspnet_core_dotnet_core.Pages
{

    public class PizzaModel : PageModel
    {
        public List<Product> Products;
        public void OnGet()
        {
            ProductModel productModel = new ProductModel();
            Products = productModel.findAll();
        }
    }
}
