using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Store.Models
{
    /// <summary> Класс категории авто    /// </summary>
    public class Category
    {
        /// <summary> Уникальный код категории /// </summary>
        public int Id { get; set; }
        /// <summary> Наименование категории авто /// </summary>
        public string Name { get; set; }
        /// <summary> Описание категории авто /// </summary>
        public string Description { get; set; }
        /// <summary> Список автомобилей в категории  </summary>
        public List<Car> Cars { get; set; }
    }
}
