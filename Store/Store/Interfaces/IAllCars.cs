using Store.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Store.Interfaces
{
    interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavoriteCars { get; set; }
        Car GetObjectCar(int carId);

    }
}
