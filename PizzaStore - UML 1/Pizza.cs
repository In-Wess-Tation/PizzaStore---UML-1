using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore___UML_1
{
    public class Pizza
    {
        private string _name;
        private int _price;
        private Topping _topping1;
        private Topping _topping2;
        private Topping _topping3;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Price
            {
            get
            {
                return _price + _topping1.Price + _topping2.Price + _topping3.Price;
            }
            set
            {
                _price = value;
            }
        }

        public Topping Topping1
        {
            get
            {
                return _topping1;
            }
            set
            {
                _topping1 = value;
            }
        }

        public Topping Topping2
        {
            get
            {
                return _topping2;
            }
            set
            {
                _topping2 = value;
            }
        }

        public Topping Topping3
        {
            get
            {
                return _topping3;
            }
            set
            {
                _topping3 = value;
            }
        }

        public Pizza(string name, int price, Topping topping1, Topping topping2, Topping topping3)
        {
            this._name = name;
            this._price = price;
            this._topping1 = topping1;
            this._topping2 = topping2;
            this._topping3 = topping3;
        }

        public override string ToString()
        {
            return "Pizza's name is " + _name + " The price is " + Price + " and it has " + _topping1 + " " + _topping2 + " and " + _topping3 + " as toppings. ";
        }
    }
}
