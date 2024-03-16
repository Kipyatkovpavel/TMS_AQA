using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHWsecond
{
    public class Product
    {
        private static int id = 1;

        public int productid;
        public string nameproduct;
        public double price;
        public double quantity;
        internal double updateprice;

        public Product(string nameproduct, double price, double quantity)
        {
            this.productid = id++;
            this.nameproduct = nameproduct;
            this.price = price;
            this.quantity = quantity;
        }
        public string ShowInfo()
        {
            return $"Продукт: {nameproduct}, Цена: {price}, Остаток(штук/кг): {quantity}";
        }
    }
}
