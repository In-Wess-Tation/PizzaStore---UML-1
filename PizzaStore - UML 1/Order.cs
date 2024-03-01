using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore___UML_1
{
    public class Order
    {
        private Pizza _pizzaOne;
        private Pizza _pizzaTwo;
        private Pizza _pizzaThree;
        private Customer _customer;


        int _id;
        DateTime _date;
        private static int idCounter = 0;


        public int Id { get => _id; private set => _id = value;  }
        public DateTime Date { get => _date; private set => _date = value; }


        public Pizza PizzaOne { get => _pizzaOne; set => _pizzaOne = value; }
        public Pizza PizzaTwo { get => _pizzaTwo; set => _pizzaTwo = value; }
        public Pizza PizzaThree { get => _pizzaThree; set => _pizzaThree = value; }

        public Order(Pizza pizzaOne, Pizza pizzaTwo, Pizza pizzaThree, Customer customer)
        {
            this._pizzaOne = pizzaOne;
            this._pizzaTwo = pizzaTwo;
            this._pizzaThree = pizzaThree;
            this._customer = customer;

            Id = idCounter;
            Date = DateTime.Now;
            idCounter++;
        }


        public double TotalPizzaPrice()
        {
            return (_pizzaOne.Price + _pizzaTwo.Price + _pizzaThree.Price) * 1.25 + 40;
        }

        public override string ToString()
        {
            return Id + " Date: " + Date.ToString("dd-MM-yy : kl: HH:mm:ss:fff") + TotalPizzaPrice().ToString();
        }

        /*
          public override string ToString()
        {
            string message = "You have ordered " + pizzaOne + " and " + pizzaTwo + " and " + pizzaThree;
            return message;
        }*/
    }
}
