using OnlineStore.Models;
namespace OnlineStore;

public static class PrintReports
{
    #region Print Report Method
    public static void PrintReport(List<Product> products, Action<Product> print)
    // Action<Product> is used because the delegate performs an action on each Product without returning a value.
    {
        foreach (Product product in products)
        {
            print(product);
        }
    }
    #endregion

    #region  Transform Products Method
    public static List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
    // Func<Product, string> is used because the delegate transforms each Product into a string and returns it.
    {
        List<string> result = new List<string>();
        foreach (Product product in products)
        {
            result.Add(transform(product));
        }
        return result;
    } 
    #endregion
}
