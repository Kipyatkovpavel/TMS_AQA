using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.SecondTask
{
    public abstract class BaseProduct
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public DateOnly ProductionDate { get; set; } //Дата производства
        public DateOnly ShelfLife { get; set; } //Срок годности

        public BaseProduct()
        {
        }
        public BaseProduct(string Name)
        {
            this.Name = Name;
        }
        public BaseProduct(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public BaseProduct(string name, float price, DateOnly productionDate)
        {
            Name = name;
            Price = price;
            ProductionDate = productionDate;

        }        
        public BaseProduct(string name, float price, DateOnly productionDate, DateOnly shelfLife)
        {
            Name = name;
            Price = price;
            ProductionDate = productionDate;
            ShelfLife = shelfLife;
        }
        public abstract void GetProductInfo();
        public abstract void CheckShelfLife();
    }
}
