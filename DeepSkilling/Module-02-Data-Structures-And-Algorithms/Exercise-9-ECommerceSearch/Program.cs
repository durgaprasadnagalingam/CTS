using System;

class Product
{
    public int Id;
    public string Name = "";
}

class Program
{
    static void Main()
    {
        Product[] products =
        {
            new Product { Id = 1, Name = "Laptop" },
            new Product { Id = 2, Name = "Mouse" },
            new Product { Id = 3, Name = "Keyboard" },
            new Product { Id = 4, Name = "Monitor" }
        };

        string search = "Mouse";
        bool found = false;

        foreach (Product product in products)
        {
            if (product.Name.Equals(search, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Product Found");
                Console.WriteLine($"ID: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Product Not Found");
        }
    }
}