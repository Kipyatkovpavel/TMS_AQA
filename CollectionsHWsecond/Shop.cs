using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHWsecond
{
    public class Shop
    {
        public Dictionary<int, Product> basketproduct = new Dictionary<int, Product>();

        public void AddProduct(string nameproduct, double price, double quantity)
        {
            Product product = new Product(nameproduct, price, quantity);
            basketproduct.Add(product.productid, product);
            Console.WriteLine($"Вы добавили свой товар: {product.ShowInfo()} ");
        }

        public void ShowAllProduct()
        {
            if (basketproduct.Count == 0)
            {
                Console.WriteLine("На данный момент магазин пуст, добавьте свои товары");
            }
            else
            {
                foreach (var product in basketproduct)
                {
                    Console.WriteLine($"Key: {product.Key}, Value: {product.Value.nameproduct},{product.Value.price},{product.Value.quantity}");
                }
            }
        }
         public void FindProduct(int findid)
        {
            if (basketproduct.ContainsKey(findid))
            {
                Product basketproduct1 = basketproduct[findid];
                Console.WriteLine($"Key: {findid}, Value: {basketproduct1.nameproduct},{basketproduct1.price},{basketproduct1.quantity}");
            }
            else
            {
                Console.WriteLine("В нашем магазине не представлен товар по указанному вами id");
            }
        }
        public double updateprice;
        public double updatequantity;
 
        public void UpdateInfoPrice(int updateid, double updateprice)
        {
            basketproduct[updateid].price = updateprice;
            return;
        }
        public void UpdateInfoQuantity(int updateid, double updatequantity)
        {
                basketproduct[updateid].quantity = updatequantity;
                return;
        }
        public void RemoveProduct(int removeid)
        {
            if (basketproduct.ContainsKey(removeid))
            {
                basketproduct.Remove(removeid);
                return;
            }
        }
    }
}

