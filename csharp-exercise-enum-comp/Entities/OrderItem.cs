using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercise_enum_comp.Entities
{
    internal class OrderItem
    {
        public int Quantity {  get; set; }
        public double price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            price = product.Price;
        }

        public double subTotal()
        {
            return price * Quantity;
        }

        public override string ToString()
        {
            return $"{Product.Name}, R${price}, Quantity: {Quantity}, Subtotal: R${subTotal()}";
        }
    }
}
