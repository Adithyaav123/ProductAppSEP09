using OrderLineItemApp.Model;

namespace OrderLineItemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(101, "Adithya");

            Order order = new(111, DateTime.Now);
            Order order1 = new Order(112, DateTime.Now);



            Product product = new Product(11, "Phone", 100, 10);
            Product product1 = new Product(12, "TV", 50, 20);
            Product product2 = new Product(13, "Book", 120, 5);
            Product product3 = new Product(14, "Bag", 800, 20);

            LineItem lineitem = new LineItem(100, 2, product);
            LineItem lineitem1 = new LineItem(101, 3, product1);

            LineItem lineitem2 = new LineItem(102, 2, product2);
            LineItem lineitem3 = new LineItem(103, 1, product3);

            Console.WriteLine(customer + "\n");

            Console.WriteLine(order + "\n");
            Console.WriteLine(lineitem + "\n");
            Console.WriteLine(lineitem1 + "\n");

            Console.WriteLine("======================================================================");
            Console.WriteLine(order1 + "\n");
            Console.WriteLine(lineitem2 + "\n");
            Console.WriteLine(lineitem3 + "\n");
            
        }

    }
    }
