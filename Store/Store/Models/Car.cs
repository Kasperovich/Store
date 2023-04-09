using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Store.Models
{
    /// <summary> Модель автомобиля </summary>
    public class Car
    {
        /// <summary>Уникальный идентификатор авто </summary>
        public int Id { get; set; }
        /// <summary>Марка авто </summary>
        public string Name { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string Img { get; set; }
        public ushort Price { get; set; }
        public bool IsFavorite { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
