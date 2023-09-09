using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLineItemApp.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        List<LineItem> items = new List<LineItem>();
       

        public Order(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }
        public void AddLineItem(LineItem item)
        {
            items.Add(item);
        }
        public double CalculateOrderPrice()
        {
            double orderCost = 0;
            foreach (LineItem item in items)
            {
                orderCost += item.CalculateLineItemCost();
            }
            return orderCost;
        }

        public  override string ToString()
        {
            return $"Order ID: {Id}\nDate: {Date}\nOrder Cost: {CalculateOrderPrice()}";
        }
    }

}