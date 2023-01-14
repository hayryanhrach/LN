using LN.Data.Models;
using System.Collections.Generic;

namespace LN.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> GetFavProducts { get; set; }
        Product  GetObjectProduct(int ProductId);  
            
    }
}
