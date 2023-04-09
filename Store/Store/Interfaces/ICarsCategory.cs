using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Store.Models;

namespace Store.Store.Interfaces
{
    interface ICarsCategory
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
