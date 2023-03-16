using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }
        public string Description { get; set; } = string.Empty;

        public Product(int id, string name, float price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }

        public Product(string name, float price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
