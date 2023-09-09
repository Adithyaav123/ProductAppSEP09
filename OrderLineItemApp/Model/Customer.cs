using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLineItemApp.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public List<Order> Orders { get; } = new List<Order>();

       

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        
        public override string ToString()
        {
            return $"Customer ID: {Id}\nName: {Name}\nNumber of Orders: {Orders.Count}";
        }

        //public  string PrintDetails()
        //{
        //    string details = $"Customer Id:{Id}\nCustomer Name:{Name}\n";
        //    foreach(Order order in Orders)
        //    {
        //        details += order.ToString();
        //        details += "\n";
        //    }
            //foreach (LineItem lineitem in order.Items)
            //{
            //    details += lineitem.ToString();
            //    details += "\n";
            //}

            //foreach (Product product in order.Products)
            //{
            //    details += product.ToString();
            //    details += "\n";
            //}
        
            //return details;
        //}

    }
}
