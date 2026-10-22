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
}
