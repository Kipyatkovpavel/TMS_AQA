using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.SecondTask
{
    public class Set : BaseProduct
    {
        public string SetName;

        public BaseProduct[] productSet = new BaseProduct[10];

        public Set(string setName, BaseProduct[] productSet)
        {
            this.SetName = setName;
            this.productSet = productSet;
        }
        // Подсмотрел, как делали коллеги, не знал, как сделать формулу для подсчёта общей стоимости

        private float GetPriseSet() //Подсчёт стоимости продуктов
        {
            float setPrice = 0;
            foreach (BaseProduct product in productSet)
            {
                setPrice = setPrice + product.Price;
            }
            return setPrice;
        }
        public override void GetProductInfo()
        {
            foreach (var product in productSet)
            {
                Console.WriteLine($"Информация о товаре в комлекте: {product.Name}, стоимость:{product.Price}");
            }
            Console.WriteLine($"Информация о комплекте : {SetName}, стоимость:{GetPriseSet()}.");
        }
        public override void CheckShelfLife()
        
        {
            Console.WriteLine("Проверка сроков годности вашего комплекта: ");
            // Так же проверка из массива 
            foreach (BaseProduct product in productSet)
            {

                if (DateOnly.FromDateTime(DateTime.Now) <= product.ShelfLife)
                  {
                     Console.WriteLine($"Товар не просрочен.Срок годности {product.ShelfLife}");
                  }
                   else
                  {
                       Console.WriteLine($"Товар просрочен.Срок годности {product.ShelfLife}");
                  }

            }
        }
    }
}

