using System.Collections.Generic;
using LN.Data.Models;
namespace LN.Data.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> AllCategories { get; }

            
    }
}
