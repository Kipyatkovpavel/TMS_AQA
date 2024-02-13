using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.SecondTask
{
    public class Product : BaseProduct
    {

        public Product(string name, float price, DateOnly productionDate, DateOnly shelfLife) : base(name, price, productionDate, shelfLife)
        {
        }

        public override void GetProductInfo()
        {
            Console.WriteLine($"Информация о товаре: {Name},стоимость :{Price}, дата производства {ProductionDate}, срок годности {ShelfLife}");
        }
        public override void CheckShelfLife()
        {
            if (DateOnly.FromDateTime(DateTime.Now) <= ShelfLife)
            {
                Console.WriteLine($"Товар не просрочен.Срок годности {ShelfLife}");
            }
            else
            {
                Console.WriteLine($"Товар просрочен.Срок годности {ShelfLife}");
            }
        }
    }
}
