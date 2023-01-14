using LN.Data.Interfaces;
using LN.Data.Models;
using System.Collections.Generic;

namespace LN.Data.mocks

{
    public class MockCategory : ICategory

    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
            {
                new Category { CategoryName ="Գլխարկ"},
                new Category { CategoryName = "Շարֆ" },
                new Category { CategoryName = "Ձեռնոց" },
                new Category { CategoryName = "Փափուջ" },
                new Category { CategoryName = "Խաղալիքներ" },
                new Category { CategoryName = "Այլ" }
            };
            }
        }
    }
}
