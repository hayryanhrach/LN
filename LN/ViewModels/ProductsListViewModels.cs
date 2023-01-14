using LN.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace LN.ViewModels
{
    public class ProductsListViewModels
    {
        public IEnumerable<Product> allProducts { get; set; }
        public string currCategory { get; set; }    
    }
}
