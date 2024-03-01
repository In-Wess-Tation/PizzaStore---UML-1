using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore___UML_1
{
    public class Customer
    {

        private string _name;
        private string _address;
        private double _phoneNumber;


        public Customer(string name, string address, double phoneNumber)
        {
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
        }

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
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public double PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }

        public override string ToString()
        {
            return Name + Address + PhoneNumber;
        }





    }
}
