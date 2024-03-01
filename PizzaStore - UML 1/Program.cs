namespace PizzaStore___UML_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            Console.WriteLine(menu);



            Pizza magarita = new Pizza("Magarita", 69, new Topping("Cheese", 5), new Topping("Tomato", 2), new Topping("Gorgonzola", 5));
            Pizza vesuvio = new Pizza("Vesuvio", 75, new Topping("Tomato", 2), new Topping("Cheese", 5), new Topping("Ham", 7));
            Pizza vegetarian = new Pizza("Vegetarian", 80, new Topping("Tomato", 2), new Topping("Cheese", 5), new Topping("Vegetables", 8));
            Pizza contadina = new Pizza("Contadina", 85, new Topping("Tomato", 2), new Topping("Cheese", 5), new Topping("Mushrooms", 6));


            Customer customer1 = new Customer("Weslyn", "Random address", 55555555);
            Customer customer2 = new Customer("Camilla", "Second random address", 52525252);
            Customer customer3 = new Customer("Shreck", "Far Far Away", 63636363);


            //Oder One
            Order order1 = new Order(magarita, contadina, vesuvio, customer1);
            double totalPrice1 = order1.TotalPizzaPrice();

            Console.WriteLine($"Order for {customer1.Name}. You've ordered a {order1.PizzaOne.Name}, a {order1.PizzaTwo.Name} and a {order1.PizzaThree.Name}. Your total price comes to {totalPrice1}");
            Console.WriteLine($"Your order ID is: {order1.ToString()}");


            //Order Two
            Order order2 = new Order(magarita, vegetarian, vesuvio, customer2);
            double totalPrice2 = order2.TotalPizzaPrice();

            Console.WriteLine($"Order for {customer2.Name}. You've ordered a {order2.PizzaOne.Name}, a {order2.PizzaTwo.Name} and a {order2.PizzaThree.Name}. Your total price comes to {totalPrice2}");
            Console.WriteLine($"Your order ID is: {order2.ToString()}");


            //Order Three
            Order order3 = new Order(vegetarian, contadina, vesuvio, customer3);
            double totalPrice3 = order3.TotalPizzaPrice();

            Console.WriteLine($"Order for {customer3.Name}. You've ordered a {order3.PizzaOne.Name}, a {order3.PizzaTwo.Name} and a {order3.PizzaThree.Name}. Your total price comes to {totalPrice3}");
            Console.WriteLine($"Your order ID is: {order3.ToString()}");


            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}
