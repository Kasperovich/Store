using Store.Store.Interfaces;
using Store.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Store.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> GetAllCategories 
        {
            get
            {
                return new List<Category>
                {
                    new Category { Name = "Электромобили", Description = "Современный вид транспорта" },
                    new Category { Name = "Классические автомобили", Description = "Авто с двигателем внутреннего возгарания" }
                };
            }
        }
    }
}
