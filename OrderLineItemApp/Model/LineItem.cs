using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OrderLineItemApp.Model
{
    internal class LineItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
       
        public LineItem(int id, int quantity, Product product)
        {
            Id = id;
            Quantity = quantity;
            Product = product;
        }
        public double CalculateLineItemCost()
        {
            return Quantity * Product.CalculateDiscountedPrice();
        }
        public override string ToString()
        {
            return $"Line Item ID:{Id},Quantity:{Quantity},Product:{Product},Total LineItem cost:{CalculateLineItemCost()}";
        }
    }
}
