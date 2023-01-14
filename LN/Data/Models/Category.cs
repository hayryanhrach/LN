using System.Collections.Generic;

namespace LN.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int Desc { get; set; }
        public List<Product> Products { get; set; }


    }
}
