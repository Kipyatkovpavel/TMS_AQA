using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //Делегат Predicate<T> принимает один параметр и возвращает значение типа bool
    public class PredicateExample
    {
        public void Run()
        {
            Predicate<int> isPositive = x => x > 0;

            Console.WriteLine(isPositive(10));
            Console.WriteLine(isPositive(-10));
        }
    }
}
