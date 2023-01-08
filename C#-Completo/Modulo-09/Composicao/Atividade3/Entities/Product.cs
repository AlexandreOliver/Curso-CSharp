

namespace Atividade3.Entities
{
    public class Product
    {
        public string Name { get; set; } = null!;
        public double Price { get; set; }

        
        public Product()
        {
            
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}