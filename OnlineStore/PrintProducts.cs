using OnlineStore.Models;

namespace OnlineStore;

public static class PrintProducts
{
    public static void PrintProductList(string title, List<Product> products)
    {
        Console.WriteLine($"\n---- {title} ----\n");
        foreach (Product product in products)
        {
            Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
        }
    }
}
