using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore___UML_1
{
    public class Topping
    {
        private string _name;
        private int _price;


        public Topping(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Price
        { 
            get { return _price; } 
        }

        public override string ToString()
        {
            return Name;
        }





        /*      public string topping = tp1; 

              public Topping(string name)
              {
                  name = name;
              }

              public override string ToString()
              {
                  return "You have choosen " + name + " as a topping to your pizza.";
              }*/


    }
}
