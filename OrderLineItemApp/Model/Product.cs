using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLineItemApp.Model
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double DiscountPercent { get; set; }
        public Product(int id, string name, double unitPrice, double discountPercent)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            DiscountPercent = discountPercent;
        }

            public double CalculateDiscountedPrice()
            {
            double discountedPrice = UnitPrice - (UnitPrice * (DiscountPercent / 100));
            return discountedPrice;
        }
        public override string ToString()
        {
            return $"Product ID:{Id},Name:{Name},Unit Price:{UnitPrice},Discount Percent:{DiscountPercent}%,UnitCostAfterDiscount: {CalculateDiscountedPrice()}";
        }
    }
}

