using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace aspnet_core_dotnet_core.Pages
{
    public class PizzaModel : PageModel
    {
        //public int ID { get; set; }
        //public string Title { get; set; }
        //public string Price { get; set; }

        //PizzaModel[] pizza = new PizzaModel[]
        //    {
        //        new PizzaModel {ID=1, Title="Onion",Price="299" },
        //        new PizzaModel {ID=2, Title="Onion",Price="299" },
        //        new PizzaModel {ID=3, Title="Onion",Price="299" }
        //    };

        //public IEnumerable<PizzaModel> GetAllPizza()
        //{
        //    return pizza;
        //}


        public List<PizzaModel> Pizza { get; set; }
        public int ID { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
         
        public void OnGet()
        {
            Pizza = new List<PizzaModel>()
        {
            new PizzaModel(){quantity=1,image="https://www.svgrepo.com/show/295489/pizza.svg", name="FarmHouse Pizza", ID=01, price=299, description="A farmhouse pizza has the best vegetables you can expect to have in a mouth-watering pizza. Fresh tomatoes, crisp capsicum, and succulent mushrooms are the top toppings in a farmhouse pizza."},
            new PizzaModel(){quantity=1,image="https://www.svgrepo.com/show/56584/pizza.svg", name="Chesse Pizza", ID=02, price=349, description="Pizza margherita, as the Italians call it, is a simple pizza hailing from Naples. When done right, margherita pizza features a bubbly crust, crushed San Marzano tomato sauce, fresh mozzarella and basil, and a sprinkle of salt."},
            new PizzaModel(){quantity=1,image="https://www.svgrepo.com/show/295423/waffle.svg", name="Chicken Pizza", ID=03, price=399, description="chicken pizza recipe is a delicious mix of flat bread or base topped with cheese, chillies, onion, garlic sauce and chunks of chicken. Tossed to perfection, this quick and easy pizza recipe is the solution to all those chicken and cheese cravings."},
            new PizzaModel(){quantity=1,image = "https://www.svgrepo.com/show/295424/frittata.svg", name="Frittata Pizza", ID=04, price=499, description="Frittata is an Italian open-faced omelet that features a mixture of eggs and dairy and highlights a variety of other ingredients like meat, cheese, and vegetables. Think of frittata as a crustless, low-carb quiche."},
            new PizzaModel(){quantity=1,image = "https://www.svgrepo.com/show/295425/quesadilla.svg", name="Quesadilla Pizza", ID=05, price=599, description="Pizza quesadilla is a simple and delicious quesadilla made with all the toppings of your favorite pizza. To a classic combo, or pizza sauce, mozzarella, and pepperoni, I added sauteed mushrooms, bell pepper, and black olives." },
            new PizzaModel(){quantity=1,image="https://www.svgrepo.com/show/295428/sandwich.svg", name="Sandwich Pizza", ID=06, price=249, description="Pizza sandwich is a quick and filling snack made with bread, pizza sauce, mozzarella cheese, veggies, herbs and seasonings. For a healthier option use whole meal bread or whole grain bread."}

        };

        }

    }
}
