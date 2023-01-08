using System;

namespace Atividade3.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; private set; }
        public Product Product { get; set; } = null!;

        public OrderItem()
        {

        }      

        public OrderItem(Product product, int quantity)
        {
            Product = new Product(product.Name, product.Price); // Isso ta certo? tenho minhas duvidas.
            Quantity = quantity;
            Price = product.Price;
        }
        
        public double subTotal()
        {
            double subtotal = Price * Quantity;
            return subtotal;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Price.ToString("F2")}, Quantity: {Quantity}, Subtotal: ${subTotal().ToString("F2")}";
            // TV, $1000.00, Quantity: 1, Subtotal: $1000.00
        }
    }
}