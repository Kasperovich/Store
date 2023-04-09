using Store.Store.Interfaces;
using Store.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Store.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        { 
            get
            {
                return new List<Car>
                {
                    new Car 
                    {
                        Name = "Tesla ModelS", 
                        Description="Быстрый автомобиль", 
                        LongDescription = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Img ="https://www.ixbt.com/img/n1/news/2022/0/4/tesla-roadster_large.jpg", 
                        Price = 45000, 
                        IsFavorite = true, 
                        Available = true, 
                        Category = _carsCategory.GetAllCategories.First()
                    },
                    new Car
                    {
                        Name = "Ford Fiesta",
                        Description="Тихий и спокойны",
                        LongDescription = "Удобный автомобиль для городской езды",
                        Img ="https://autoreview.ru/images/Article/1728/Article_172866_860_575.jpg",
                        Price = 11000,
                        IsFavorite = true,
                        Available = true,
                        Category = _carsCategory.GetAllCategories.Last()
                    },
                    new Car
                    {
                        Name = "BMW 3",
                        Description="Дерзкий и стильный",
                        LongDescription = "Тачка для пацанов, забудь о поворотниках",
                        Img ="https://content.onliner.by/news/1100x5616/16f5b8dd2884a08ce66758822e060b6f.jpeg",
                        Price = 21000,
                        IsFavorite = true,
                        Available = true,
                        Category = _carsCategory.GetAllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Mercedes C class",
                        Description="Тупо лакшери",
                        LongDescription = "Удобный автомобиль для демонстрации своих яиц",
                        Img ="https://avcdn.av.by/journalarticlepreview/0000/4552/7277.jpg",
                        Price = 31000,
                        IsFavorite = true,
                        Available = true,
                        Category = _carsCategory.GetAllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Niissan Leaf",
                        Description="Безшумный и экономный",
                        LongDescription = "Удобный автомобиль для городской езды",
                        Img ="https://avcdn.av.by/wisiwigimage/0001/6634/5176.jpeg",
                        Price = 31000,
                        IsFavorite = true,
                        Available = true,
                        Category = _carsCategory.GetAllCategories.Last()
                    },
                };
            } 
        }
        public IEnumerable<Car> GetFavoriteCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
