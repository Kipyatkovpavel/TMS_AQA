using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.SecondTask
{
    public class Batch : BaseProduct
    {

        public int SumofBatch;
        public Batch(string name, int sumofBatch, float price,  DateOnly productionDate, DateOnly shelfLife) : base(name, price, productionDate, shelfLife)
        {
            this.SumofBatch = sumofBatch;
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
