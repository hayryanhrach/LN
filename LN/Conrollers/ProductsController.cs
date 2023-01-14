using LN.Data.Interfaces;
using LN.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LN.Conrollers
    
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly ICategory _allCategory;
        public ProductsController(IAllProducts allproducts, ICategory allcategory)
        {
            _allProducts=allproducts;
            _allCategory=allcategory;
        }
        public ViewResult List()
        {
            ViewBag.Title = "ԼԱԼԱՅԱՆ's ՆԱԽՇ";
            ProductsListViewModels obj=new ProductsListViewModels();
            obj.allProducts = _allProducts.Products;
            obj.currCategory ="Գործվածքներ";
            return View(obj);  
        }

    }
}
