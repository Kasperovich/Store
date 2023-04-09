using Microsoft.AspNetCore.Mvc;
using Store.Store.Interfaces;
using Store.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCaterogy;

        public CarsController(IAllCars iAllCars, ICarsCategory icarsCategory)
        {
            _allCars = iAllCars;
            _carsCaterogy = icarsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            var carsData = new CarsListViewModels() { AllCars = _allCars.Cars, CurrCategory = "Автомобили" };
            return View(carsData);
        }
    }
}
