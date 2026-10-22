using OnlineStore.Models;
namespace OnlineStore;

public static class PrintReports
{
    public static void PrintReport(List<Product> products, Action<Product> print)
    {
        foreach (Product product in products)
        {
            print(product);
        }
    }

    public static List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
    { 
        List<string> result = new List<string>();
        foreach(Product product in products)
        {
            result.Add(transform(product));
        }
        return result;
    }
}
