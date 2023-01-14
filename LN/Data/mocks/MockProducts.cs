using LN.Data.Interfaces;
using LN.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace LN.Data.mocks
{
    public class MockProducts : IAllProducts
    {

        private readonly ICategory category = new MockCategory();
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product> {
                    new Product {
                        Name = "Փափուջ",
                        Colour = "Դեղին",
                        Desc = "Նորածնի",
                        Img = "/img/1.jpg",
                        Price = 1500,
                        IsFavourite = true,
                        Available = true,
                        Category = category.AllCategories.First()
                    },
                    new Product {
                        Name = "Գլխարկ",
                        Colour = "2 տարեկանի",
                        Desc = "1 տարեկանի",
                        Img = "/img/2.jpg",
                        Price = 2000,
                        IsFavourite = true,
                        Available = true,
                        Category = category.AllCategories.First()
                    },
                    new Product {
                        Name = "Շարֆ",
                        Colour = "Սպիտակ",
                        Desc = "1 տարեկանի",
                        Img = "/img/3.jpg",
                        Price = 3000,
                        IsFavourite = true,
                        Available = true,
                        Category = category.AllCategories.First()
                    },
                    new Product {
                        Name = "Ձեռնոց",
                        Colour = "Կանաչ",
                        Desc = "Մեծահասակի",
                        Img = "/img/4.jpg",
                        Price = 2000,
                        IsFavourite = true,
                        Available = true,
                        Category = category.AllCategories.First()
                    },
                    new Product {
                        Name = "Զատիկ",
                        Colour = "Դեղին",
                        Desc = "Ձվի համար նախատեսված",
                        Img = "/img/5.jpg",
                        Price = 3000,
                        IsFavourite = true,
                        Available = true,
                        Category = category.AllCategories.First()
                    },
                    new Product {
                        Name = "Զգեստ",
                        Colour = "Սպիտակ-Դեղին",
                        Desc = "մինչև 1 տարեկանի",
                        Img = "/img/6.jpg",
                        Price = 9000,
                        IsFavourite = true,
                        Available = true,
                        Category = category.AllCategories.First()
                    },
                };
            }
        }
        public IEnumerable<Product> GetFavProducts { get; set; }

        public Product GetObjectProduct(int ProductId)
        {
            throw new System.NotImplementedException();
        }
    }
}
