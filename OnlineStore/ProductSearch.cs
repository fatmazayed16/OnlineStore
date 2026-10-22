using OnlineStore.Models;
namespace OnlineStore;

internal class ProductSearch
{
    
    public List<Product> SearchProducts(List<Product> products, Func<Product, bool> predicate)
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


    #region Filter Products Method
    public static List<Product> FilterProducts(List<Product> products, Predicate<Product> predicate)
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
