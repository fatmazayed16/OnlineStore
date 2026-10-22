using OnlineStore.Models;
namespace OnlineStore;

public static class ProductSearch
{
    #region Search Products Method
    public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> predicate)
    // Func<Product, bool> is used because the search condition takes a Product and returns true or false.
    {
        List<Product> result = new List<Product>();

        foreach (Product product in products)
        {
            if (predicate(product))
            {
                result.Add(product);
            }
        }
        return result;
    } 
    #endregion


    #region Filter Products Method
    public static List<Product> FilterProducts(List<Product> products, Predicate<Product> predicate)
    // Predicate<Product> is used because filtering requires a condition that takes a Product and returns true or false.
    {
        List<Product> result = new List<Product>();
        foreach (Product product in products)
        {
            if (predicate(product))
                result.Add(product);
        }
        return result;
    }

    #endregion

}
