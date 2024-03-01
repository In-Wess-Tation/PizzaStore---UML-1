using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore___UML_1
{
    public class Menu
    {
        Pizza magarita = new Pizza("Magarita", 69, new Topping("Cheese", 5), new Topping("Tomato", 2), new Topping("Gorgonzola", 5));
        Pizza vesuvio = new Pizza("Vesuvio", 75, new Topping("Tomato", 2), new Topping("Cheese", 5), new Topping("Ham", 7));
        Pizza vegetarian = new Pizza("Vegetarian", 80, new Topping("Tomato", 2), new Topping("Cheese", 5), new Topping("Vegetables", 8));
        Pizza contadina = new Pizza("Contadina", 85, new Topping("Tomato", 2), new Topping("Cheese", 5), new Topping("Mushrooms", 6));

        public override string ToString()
        {
            return magarita.ToString() + vesuvio.ToString() + vegetarian.ToString() + contadina.ToString();
        }
    }
}
